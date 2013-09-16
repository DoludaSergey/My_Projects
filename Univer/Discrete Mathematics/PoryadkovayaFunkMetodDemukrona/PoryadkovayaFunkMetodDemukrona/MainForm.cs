using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PoryadkovayaFunkMetodDemukrona
{
    public partial class MainForm : Form
    {
        List<int> M;//список сумм элементов по всем столбцам матрицы А
        List<int> I;//список вершин найденного порядка
        List<List<int>> Ord;//список списков вершин(найденных порядков)
        int nVershin;

        //матрицы смежности графа
        int[,] A = new int[,]{
                                {0,1,1,0,0,0,1},
                                {0,0,0,1,0,0,0},
                                {0,0,0,0,0,0,1},
                                {0,0,0,0,1,1,0},
                                {0,0,0,0,0,1,0},
                                {0,0,0,0,0,0,1},
                                {0,0,0,0,0,0,0}
                                };
        
        public MainForm()
        {
            InitializeComponent();

            nVershin = A.GetLength(0);//количество вершин;

            ShowMatrix();

        }

        /// <summary>
        /// заполняет данными датагрид
        /// </summary>
        private void ShowMatrix()
        {
            //формирование и вывод dataGridView
            this.dataGridView1.ColumnCount = nVershin;//количество столбцов
            this.dataGridView1.Rows.Add(nVershin);//количество строк

            for (int i = 0; i < nVershin; i++)
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
            for (int i = 0; i < nVershin; i++)
            {
                for (int j = 0; j < nVershin; j++)
                {
                    this.dataGridView1.Rows[i].Cells[j].Value = A[i, j];
                }
            }
        }

        private void DoIt()
        {
            
            M = new List<int>(nVershin);//инициализация списка сумм столбцов матрицы
            Ord = new List<List<int>>();//инициализация списка вершин порядковых функций
            int sum;//переменная для хранения суммы столбца

            while (!Empty(M))//пока список непуст
            //(пока найденны не все порядковые функции)
            {
                //если список отобранных вершин с нулевыми значениями пуст
                //или их количество не равно нулю
                if ((I == null) || (I.Count == 0))
                {
                    //сумируем значения столбцов матрицы смежности
                    for (int i = 0; i < nVershin; i++)
                    {
                        //обнуление счетчика сумм при переходе на новый столбец
                        sum = 0;
                        
                        for (int j = 0; j < nVershin; j++)
                        {
                            sum += A[j, i];
                        }
                        
                        //добавляем сумму в список
                        M.Add(sum);
                    }
                }
                //иначе(если список отобранных вершин содержит элементы)
                else
                {
                    //перебираем список отобранных вершин
                    foreach (int item in I)
                        //и вычетаем из списка сумм строки с номерами из списка вершин
                        for (int i = 0; i < nVershin; i++)
                            M[i] -= A[item, i];
                }

                int count = 0;//инициализация счетчика
                I = new List<int>();//создаем новый список для вершин

                //проходим по списку сумм
                foreach (int item in M)
                {
                    //если элемент в списке равен нулю
                    if (item == 0)
                        //добавляем номер элемента в список отобранных вершин
                        I.Add(count);

                    count++;//увеличиваем счетчик
                }

                //проходим по списку отобранных вершин
                foreach (int item in I)
                {
                    //маскируем нулевые значения в списке сумм
                    M.RemoveAt(item);
                    M.Insert(item, -1);
                }


                //добавляем список отобранных вершин в основной список порядков
                Ord.Add(I);
            }

            //выводим отчет на экран
            PrintOtchet();
        }

        /// <summary>
        /// формирует отчет и выводит его на экран
        /// </summary>
        private void PrintOtchet()
        {
            this.listBox1.Items.Add(string.Format(
                "Порядковая функция выделенного графа равна O(x)={0}", Ord.Count));
            int counter = 0;

            foreach (List<int> list in Ord)
            {
                StringBuilder strOtcheta = new StringBuilder();
                strOtcheta.Clear();
                strOtcheta.Append(string.Format(
                    "Функция N{0} порядка содержит следующие вершины :", counter));
                foreach (int item in list)
                {
                    strOtcheta.Append(string.Format(" X{0}", item + 1));
                }
                this.listBox1.Items.Add(strOtcheta);
                counter++;
            }
        }

        /// <summary>
        /// Проверяем пуст ли список сумм
        /// </summary>
        /// <param name="M">список сумм столбцов матрицы смежности</param>
        /// <returns>пуст ли список</returns>
        private bool Empty(List<int> M)
        {
            bool empty=true;//флаг

            //если список пуст,возвращаем false
            if (M.Count==0) return false;

            //проходим по списку сумм
            foreach (int item in M)
                //если остались незамаскированные элементы,сбрасываем флаг
                if (item !=-1)
                    empty = false;

            return empty;
        }
        //обработчик события клика на кнопке Выполнить
        private void buttonDoIt_Click(object sender, EventArgs e)
        {
            DoIt();//рабочий метод
        }

    }
}
