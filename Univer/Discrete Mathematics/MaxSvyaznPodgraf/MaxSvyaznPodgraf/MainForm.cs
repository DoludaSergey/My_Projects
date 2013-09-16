using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MaxSvyaznPodgraf
{
    public partial class MainForm : Form
    {
        int nVershin;//количество вершин,
        int[,] NewMas;//рабочий массив
        List<int> masG = new List<int>();//транзитивное замыкание вершины
        List<int> masGOtr = new List<int>();//обратное транзитивное замыкание вершины
        List<int> vershList = new List<int>();//список вершин
        bool test;//включение тестового режима программы
        int nClass;//порядковый номер найденного класса
        //переменные для хранения стартовой вершины и смещения
        int startV,deltaOfStart;

        //матрица смежности графа
        int[,] A = {{0,1,1,0,0,0,0},
                   {0,0,0,0,0,0,0},
                   {1,0,0,0,0,0,0},
                   {0,0,1,0,0,0,0},
                   {0,0,0,1,0,0,0},
                   {0,0,0,1,0,1,1},
                   {0,0,0,1,1,0,0}};

        public MainForm()
        {
            InitializeComponent();

            test = false;//тестовый режим отключен
            //количество вершин и номер для контроля смещения берем из ширины матрицы смежности
            nVershin = A.GetLength(0);
            nClass = 0;//изначально сильно-связанные классы отсутствуют 
            startV = 0;//по умолчанию стартовая вершина Х1

            //заполняем список вершин значениями от нуля
            for (int i = 0; i < nVershin; i++)
                vershList.Add(i);

            //вывод на экран матрицы смежности
            PrintMatrix();
            
        }

        /// <summary>
        /// поиск максимально-сильно связанных подграфов
        /// </summary>
        private void DoIt()
        {
            //копируем значения матрицы смежности в рабочий массив
            int[,] CurentA = CopyMatrix(A);

            //пока не выделены все вершины
            while (vershList.Count > 0)
            {
                nClass++;//увеличиваем значение порядкового номера класса

                //создаем и обнуляем массив транзитивного замыкания вершины
                ResetMasG(ref masG);
                //создаем и обнуляем массив обратного транзитивного замыкания вершины
                ResetMasGOtr(ref masGOtr);

                //находим транзитивное замыкание вершины
                GetMasG(CurentA, ref masG);

                //находим обратное транзитивное замыкание вершины
                GetMasGOtr(CurentA, ref masGOtr);

                //формируем отчет и выводим его на экран
                PrintRaport();

                //если еще есть невыделенные вершины
                if (vershList.Count > 0)
                    //получаем новую рабочую матрицу
                    CurentA = GetNewMasA(vershList);
            }
        }

        /// <summary>
        /// отображение на экране матрицы смежности
        /// </summary>
        private void PrintMatrix()
        {
            //формируем dataGridView1
            this.dataGridView1.ColumnCount = nVershin;
            this.dataGridView1.Rows.Add(nVershin);

            for (int i = 0; i < nVershin; i++)
            {
                //устанавливаем в режим только чтение
                this.dataGridView1.Columns[i].ReadOnly = true;
                //запрещаем сортировку
                this.dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                //назначаем имена стобцов и строк
                this.dataGridView1.Columns[i].Name = string.Format("X{0}", i + 1);
                this.dataGridView1.Rows[i].HeaderCell.Value = string.Format("X{0}", i + 1);
                //устанавливаем ширину колонки
                this.dataGridView1.Columns[i].Width = 25;
            }

            //выводим значения матрицы смежности
            for (int i = 0; i < nVershin; i++)
                for (int j = 0; j < nVershin; j++)
                    this.dataGridView1.Rows[i].Cells[j].Value = A[i, j];
        }

        /// <summary>
        /// формирует отчет и выводит его на экран
        /// </summary>
        private void PrintRaport()
        {
            //если включен отладочный режим
            if (test)
            {
                //выводим подробный отчет
                this.listBox1.Items.Add(
                    "Получаем следующие вершины транзитивного замыкания");
                int c = 0;
                foreach (int item in masG)
                {
                    c++;
                    if (item != -1)
                        this.listBox1.Items.Add(c);
                }

                this.listBox1.Items.Add(
                    "Также Получаем следующие вершины обратного транзитивного замыкания");
                c = 0;
                foreach (int item in masGOtr)
                {
                    c++;
                    if (item != -1)
                        this.listBox1.Items.Add(c);
                }
            }

            //создаем список вершин максимально-сильно связанного графа(класс)
            List<int> ClassList = new List<int>();


            //проход по транзитивному и обратному транзитивному замыканиям вершин
            //и отбираем номера тех,которые пересекаются
            for (int item = 0; item < masG.Count; item++)
                if (masG[item] != -1 && masGOtr[item] != -1)
                {
                    //добавляем такие вершины в класс
                    ClassList.Add(vershList[item]);
                }

            //и удаляем их в рабочем списке вершин
            foreach(int item in ClassList)
                vershList.Remove(item);

            //если вводилась стартовая вершина,делаем поправку
            if (vershList.Count > deltaOfStart && deltaOfStart!=0)
                startV = vershList.Count - deltaOfStart;
            else
                startV = 0;

            //формируем строку отчета и выводим ее на экран
            string str = string.Format("{0}-й класс содержит следующие вершины :", nClass);
            this.listBox1.Items.Add(str);

            //выводим номера вершин сильносвязанного подграфа
            foreach (int item in ClassList)
            {
                this.listBox1.Items.Add(string.Format ("X{0}",item + 1));
            }
        }

        /// <summary>
        /// копирует элементы матрицы в новый двумерный массив
        /// </summary>
        /// <param name="A">исходная матрица</param>
        /// <returns>копия элементов матрицы</returns>
        private static int[,] CopyMatrix(int[,] A)
        {
            //создаем новую матрицу
            int[,] NewMatrix = new int[A.GetLength(1), A.GetLength(1)];

            //копируем элемены
            for (int b = 0; b < A.GetLength(1); b++)
                for (int e = 0; e < A.GetLength(1); e++)
                    NewMatrix[b, e] = A[b, e];
            
            //возвращаем копию матрицы
            return NewMatrix;
        }

        /// <summary>
        /// формирует новую матрицу на основании количества необработанных вершин
        /// </summary>
        /// <param name="vershList">список вершин</param>
        /// <returns>новая матрица смежности</returns>
        private int[,] GetNewMasA(List<int> vershList)
        {
            nVershin = vershList.Count;//количество вершин

            //создаем новый массив
            NewMas = new int[nVershin, nVershin];

            int nStroki;//номер рабочей строки

            //заполняем данными новый массив
            for (int i = 0; i < nVershin; i++)
            {
                //номер рабочей строки приравниваем номеру вершины
                nStroki = vershList[i];
                
                //проход по строке
                for (int j = 0; j < nVershin; j++)
                {
                    //копируем значения с поправкой на удаленные вершины
                    NewMas[i, j] = this.A[nStroki, (vershList[j]-j) + j];
                }
            }
            //возврат новой матрицы
            return NewMas;
        }

        /// <summary>
        /// формирует список для данных  транзитивного замыкания вершины
        /// </summary>
        /// <param name="masG">список транзитивного замыкания вершины</param>
        private void ResetMasG(ref List<int> masG)
        {
            masG.Clear();//удаляет старый список
            for (int i = 0; i < nVershin; i++)
                //изначально заполняем список -1
                //(признак необратки данной вершины)
                masG.Add(-1);
        }

        /// <summary>
        /// аналогично ResetMasG
        /// только для данных обратного транзитивного замыкания вершины
        /// </summary>
        /// <param name="masGOtr">список обратного транзитивного замыкания вершины</param>
        private void ResetMasGOtr(ref List<int> masGOtr)
        {
            masGOtr.Clear();
            for (int i = 0; i < nVershin; i++)
                masGOtr.Add(-1);
        }

        /// <summary>
        /// заполняет список данных  транзитивного замыкания вершины
        /// </summary>
        /// <param name="A">матрица смежности</param>
        /// <param name="masG">список данных  транзитивного замыкания вершины</param>
        private void GetMasG(int[,] A, ref List<int> masG)
        {
            int curentCount;//текущая позиция 
            int count;//очередная позиция
            int nStroki;//номер рабочей строки
            bool Complete = false;//признаки окончания цикла
            bool noLink = false;//признак отсутствия связей

            count = 0;//обнуляем счетчик
            nStroki = startV;//назначаем стартовую вершину
            masG[nStroki] = count;//в начальную позицию ставим ноль

            //пока не обработанны все вершины
            while (!Complete)
            {
                curentCount = count;//назначаем текущую позицию
                count++;//увеличиваем очередную позицию

                //перебераем все элементы списка транзитивного замыкания
                for (int k = 0; k < nVershin; k++)
                {
                    //если элемент массива равен текущей позиции
                    if (masG[k] == curentCount)
                    {
                        //номеру строки присваиваем порядковое значение элемента
                        nStroki = k;
                        //назначаем значение контролера в исходное состояние
                        int control = -1;
                        //перебераем элементы строки
                        for (int j = 0; j < nVershin; j++)
                        {
                            control++;//увеличиваем значение контролера
                            //если элемент матрицы =1
                            if (A[nStroki, j] == 1)
                            {
                                //если элемент списка транзитивного замыкания не использован(=-1)
                                if (masG[j] == -1)
                                {
                                    //присваеваем ему значение очередной позиции
                                    masG[j] = count;
                                    //сбрасываем значение контролера в исходное состояние
                                    control = -1;
                                    //сбрасываем признак отсутствия связей
                                    noLink = false;
                                }
                            }
                            //если контролер равен количеству вершин
                            //(строка инцидентности пуста) и
                            //пройденны все элементы списка транзитивного замыкания
                            if (control >= nVershin - 1) 
                                //устанавливаем признак отсутствия связи
                                noLink = true;
                        }
                    }
                    //если пройден весь список транзитивного замыкания
                    //и связей больше не обнаружено
                    if ((k == nVershin - 1) && (noLink))
                        //выполнение цикла оконченно
                        Complete = true;
                }

            }
        }
        /// <summary>
        /// заполняет список данных  обратного транзитивного замыкания вершины
        /// аналогично транзитивному замыканию
        /// </summary>
        /// <param name="A">исходная матрица</param>
        /// <param name="masGOtr">список данных  обратного транзитивного замыкания</param>
        private void GetMasGOtr(int[,] A, ref List<int> masGOtr)
        {
            int curentCount, count, n;
            bool Complete=false;
            bool noLink = false;

            count = 0;
            n = startV;
            masGOtr[n] = count;

            while (!Complete)
            {
                curentCount = count;
                count++;

                for (int k = 0; k < nVershin; k++)
                {
                    if (masGOtr[k] == curentCount)
                    {
                        n = k;
                        
                        int control = -1;
                        for (int j = 0; j < nVershin; j++)
                        {
                            control++;
                            if (A[j, n] == 1)
                            {

                                if (masGOtr[j] == -1)
                                {
                                    masGOtr[j] = count;
                                    control = -1;
                                    noLink = false;
                                }
                            }
                            if ((control >= nVershin - 1)) noLink = true;
                        }
                    }
                    if ((k == nVershin - 1) && (noLink))
                        Complete = true;
                }
            }
        }

        //обработчик клика по кнопке Найти
        private void buttonDoIt_Click(object sender, EventArgs e)
        {
            DoIt();//рабочий метод
        }

        //обработчик клика по кнопке Установить
        private void buttonStartV_Click(object sender, EventArgs e)
        {
            int temp;
            try
            {
                if (this.textBox1.Text != "")
                {
                    //считываем данные с текстового поля
                    temp = int.Parse(this.textBox1.Text)-1;
                    //проверка на корректный диапазон
                    if ((temp >= 0) && temp < 7)
                    {
                        //устанавливаем значение стартовой вершины
                        this.startV = temp;
                        //и поправка на смещение
                        deltaOfStart = nVershin - temp;
                    }
                    else
                        MessageBox.Show("Некоректный ввод!!!");
                }
            }
            catch(Exception ee)
            {}
        }
    }
}
