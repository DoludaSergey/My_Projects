using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace DFS
{
    public partial class MainForm : Form
    {
        int[,] A = {{0,1,0,0,0,0,0,1},
                   {1,0,1,0,0,0,0,1},
                   {0,1,0,1,0,0,0,0},
                   {0,0,1,0,0,1,1,1},
                   {0,0,0,0,0,1,0,0},
                   {0,0,0,1,1,0,1,0},
                   {0,0,0,1,0,1,0,1},
                   {1,1,0,1,0,0,1,0}};

        char[] vershinList = {'A','B','C','D','E','F','G','H' };
        List<string> resultVershinList;//список отобранных вершин маршрута поиска
        bool[] Visited  ;//массив признака посещения
        int countV;//количество вершин
        int[] nCount;//порядковый номер в дереве
        Stack STACK;//рабочий стек
        
        public MainForm()
        {
            InitializeComponent();

            countV = A.GetLength(0);

            ShowMatrix();
                
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
                this.dataGridView1.Columns[i].Name = vershinList[i].ToString();
                //ширина столбцов
                this.dataGridView1.Columns[i].Width = 30;
                //подпись строк
                this.dataGridView1.Rows[i].HeaderCell.Value = vershinList[i].ToString();

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

        //обработчик нажатия на кнопку
        private void buttonDoIt_Click(object sender, EventArgs e)
        {
            //очищаем листбокс
            this.listBox1.Items.Clear();
            this.listBox1.Items.Add("Поиск ведется в следующей последовательности :");

            DoIt();

            ShowOtchet();
        }

        /// <summary>
        /// рабочий метод
        /// </summary>
        private void DoIt()
        {
            STACK = new Stack();//инициализация стека
            Visited = new bool[countV];//инициализация массива посещений
            resultVershinList = new List<string>();//список последовательности ребер
            nCount = new int[countV];

            int v;//рабочая вершина

            //int Count = 0;

            STACK.Push(0);//помещаем в стек стартовую вершину
            Visited[0] = true;//помечаем начальную вершину посещенной

            //resultVershinList.Add(vershinList[0]);

            //пока стек не пуст
            while (STACK.Count != 0)
            {
                //извлекаем из стека рабочую вершину
                v = (int)STACK.Peek();
                int control = 1;//назначаем контролер

                for (int i = 0; i < countV; i++, control++)
                {
                    //если у вершины есть связь и та вершина еще не посещалась
                    if ((A[v, i] != 0) && (!Visited[i]))
                    {
                        //заталкиваем ее в стек
                        STACK.Push(i);
                        //помечаем вершину посещенной
                        Visited[i] = true;
                        //Count++;
                        control = 0;//обнуляем контролер
                        //nCount[i] = Count;
                        //в  результирующий список добавляем информацию о пути
                        resultVershinList.Add(string.Format("Из {0} в {1}", vershinList[v], vershinList[i]));
                        break;
                    }
                    //если у вершины нет дочерних связей, удаляем вершину из стека
                    if (control == 8) STACK.Pop();
                    //далее переход на новую итерацию цикла
                }
            }
        }

        /// <summary>
        /// Вывод отчета на экран
        /// </summary>
        private void ShowOtchet()
        {
            //проходим по результирующему списку
            foreach (string item in resultVershinList)
                //выводим содержимое элементов на экран
                this.listBox1.Items.Add(item.ToString());
        }
    }
}
