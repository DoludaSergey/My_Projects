using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MinPathFinderByAlgForda
{
    public partial class MainForm : Form
    {
        //матрица смежности графа
        int[,] A ;

        int countV;//количество вершин

        public MainForm()
        {
            InitializeComponent();

            ReadFromFile();//загрузка графа из файла(выбрать Graf1)
              
            countV = A.GetLength(0);//количество вершин

            ShowMatrix();//вывод матрицу смежности
        }

        private void ShowMatrix()
        {
            //формирование и вывод dataGridView
            this.dataGridView1.ColumnCount = countV;//количество столбцов
            this.dataGridView1.Rows.Add(countV);//количество строк

            for (int i = 0; i < countV; i++)
            {
                //ячейки только для чтения
                this.dataGridView1.Columns[i].ReadOnly = true;
                //отмена сортировки
                this.dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                //подпись столбцов
                this.dataGridView1.Columns[i].Name = string.Format("X{0}", i + 1);
                //ширина столбцов
                this.dataGridView1.Columns[i].Width = 30;
                //подпись строк
                this.dataGridView1.Rows[i].HeaderCell.Value = string.Format("X{0}", i + 1);

            }
            //вывод значений матрицы смежности
            for (int i = 0; i < countV; i++)
            {
                for (int j = 0; j < countV; j++)
                {
                    this.dataGridView1.Rows[i].Cells[j].Value = A[i, j];
                }
            }
        }

        //обработчик клика по кнопке
        private void button1_Click(object sender, EventArgs e)
        {
            DoIt();
        }

        /// <summary>
        /// Рабочий метод
        /// </summary>
        private void DoIt()
        {
            bool Changed = true;//флаг(признак уменшения дистанции)
            int count = 0;//счетчик контролер

            int[] d = new int[countV];//массив минимальных дистанций
            int[] p = new int[countV];//массив родителя

            for (int i = 0; i < countV; i++)
                d[i] = 9999;//изначально назначаем любое большое число

            d[0] = 0;//начальная точка(Х1)

            //запускаем цикл,равный кол вершин -1(чтоб избежать зацикливания)
            for (int k = 0; k < countV - 1; k++)
            {
                //если есть уменьшения минимальной дистанции
                if (Changed)
                {
                    //перебираем все дуги графа
                    for (int i = 0; i < countV; i++)
                        for (int j = 0; j < countV; j++, count++)
                            //если старая дистанция больше новой
                            if ((A[i, j] != 0) && (d[j] > d[i] + A[i, j]))
                            {
                                //обновляем значение дистанции
                                d[j] = d[i] + A[i, j];
                                p[j] = i;//обновляем родителя(источник)
                                count = 0;//обнуляем счетчик-контролер
                            }
                    //если счетчик равен 144
                    if (count == 12 * 12)
                        //значит дистации не менялись(конец цикла)
                        Changed = false;
                }
            }
            //вывод отчета
            this.listBox1.Items.Add("Поиск произведен методом Форда");
            PrintOtchet(d, p);
        }

        /// <summary>
        /// Формирование и вывод отчета
        /// </summary>
        /// <param name="d">массив дистанций</param>
        /// <param name="p">массив родителей</param>
        private void PrintOtchet(int[] d, int[] p)
        {
            int c, finishV;//переменные для хранения конечной вершины
            c = finishV = 11;//по умолчанию это Х12

            //если текстбокс содержит значения
            if (this.textBoxFinishV.Text != string.Empty)
            {
                finishV = int.Parse(this.textBoxFinishV.Text) - 1;
                if (finishV >= 0 && finishV <= 12)
                    //если сначение в диапозоне от 1 до 12
                    //меняем значение конечной вершины
                    c = finishV;
                else MessageBox.Show("Некорректное значение!!!", "Внимание!");
            }

            //строка отчета
            StringBuilder str = new StringBuilder();

            str.Append(string.Format(
                "Минимальный путь из вершины  X1  в  X{0}  содержит следующие вершины: ", c + 1));

            //список вершин пути
            List<int> pathList = new List<int>();

            //пока не дошли до стартовой вершины
            while (c != 0)
            {
                //заполняем список пути от конечной вершины до старта
                pathList.Add(c);
                //переходим к родителю
                c = p[c];
            }
            //добавляем стартовую вершину
            pathList.Add(c);

            //реверсируем путь
            pathList.Reverse();

            //добавляем вершины пути в строку отчета
            foreach (int item in pathList)
                str.Append(string.Format(" X{0} ", item + 1));

            //выводим отчет на экран
            this.listBox1.Items.Add(str);
            this.listBox1.Items.Add(string.Format(
                "Растояние между этими вершинами составляет {0}", d[finishV]));
        }

        public void ReadFromFile()
        {
            string fileName,str;//имя файла и рабочая строка
            int[,] MatrixA;//рабочая матрица

            //вызов диалогового окна выбора файла
            OpenFileDialog ofd=new OpenFileDialog();

            //если выбран файл и нажата кнопка Ок
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileName = ofd.FileName;
                MessageBox.Show("Открыт файл с именем:\r\n" + fileName);
                
                //создаем поток на чтение
                StreamReader reader = new StreamReader(fileName);

                str = reader.ReadLine();//считываем размер матрицы
                int nVershin = int.Parse(str);
                int line = 0;//рабочая вершина

                //создаем матрицу
                MatrixA = new int[nVershin, nVershin];

                //считываем строки из файла, пока не конец файла
                while ((str = reader.ReadLine()) != null)
                {
                    //расщипляем строку на данные
                    string[] ver = str.Trim().Split();

                    //проход по ячейкам строки
                    for (int i = 0; i < nVershin; i++)
                    {
                        //заносим данные в матрицу смежности
                        MatrixA[line, i] = int.Parse(ver[i]);
                    }
                    //переход к следующей вершине
                    line++;
                }
                //назначаем значения созданной матрицы нашему полю
                this.A = MatrixA;
                //закрываем поток чтения
                reader.Close();
            }

            else//иначе выводим сообщение
            {
                MessageBox.Show("Файл не выбран!!!Запустим граф по умолчанию!");

                //и назначаем граф по умолчанию
                this.A= new int[,] {{0,0,0,0,0,3,14,0,0,0,0,0},
                          {9,0,10,0,0,0,0,25,0,0,0,0,},
                          {0,8,0,7,0,0,0,7,0,0,0,0},
                          {0,0,6,0,0,19,0,0,0,4,0,15},
                          {0,0,0,0,0,0,0,0,0,9,0,0},
                          {0,0,0,0,0,0,0,0,0,0,0,0,},
                          {12,0,10,0,0,0,0,11,0,0,0,0},
                          {0,0,0,0,0,0,12,0,4,2,0,0},
                          {0,0,0,0,11,0,0,5,0,0,8,0},
                          {0,0,0,6,7,0,0,0,3,0,0,0},
                          {0,0,0,0,0,0,0,0,0,0,0,9},
                          {0,0,0,0,4,0,0,0,12,0,9,0}};
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MetodDijkstra();

        }

        private void MetodDijkstra()
        {
            //массив дистанций до вершины
            int[] dToVershinList = new int[this.countV];
            //признак окончания анализа вершины
            bool[] visited = new bool[this.countV];
            //массив родителя
            int[] parent = new int[countV];

            //изначально дистанция любое большое число
            for (int i = 0; i < countV; i++)
                dToVershinList[i] = 9999;

            int v = 0;//стартовая вершина
            //дистанция до стартовой вершины равна нулю
            dToVershinList[v] = 0;
            //родитель для стартовой вершины это она сама
            parent[v] = 0;
            //помечаем ее проверенной
            visited[v] = true;

            //проходим по всем вершинам
            for (int i = 0; i < countV; i++)
            {
                //анализируем вершины, инцидентные текущей
                for (int j = 0; j < countV; j++)
                {
                    //если вершина инцидентна, еще не проверена
                    //и старая ее дистанция больше иследуемой
                    if ((A[v, j] != 0) && (!visited[j]) && (dToVershinList[j] > dToVershinList[v] + A[v, j]))
                    {
                        //обновляем эту дистанцию
                        dToVershinList[j] = dToVershinList[v] + A[v, j];
                        //и родителя
                        parent[j] = v;
                    }
                }

                int minCount = 0;//счетчик-контролер
                int min = 9999;//минимум, изначально любое большое число

                //находим минимальный путь из незамаскированных
                for (int k = 0; k < countV; k++)
                {
                    if ((!visited[k]) && dToVershinList[k] < min)
                    {
                        min = dToVershinList[k];
                        minCount = k;
                    }
                }
                //маскируем его
                visited[minCount] = true;
                //назначаем рабочую вершину
                v = minCount;

            }

            //вывод отчета
            this.listBox1.Items.Add("Поиск произведен методом Дейкстры");
            PrintOtchet(dToVershinList, parent);
        }
    }
}
