using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GomeomorfnoeSjatie
{
    public partial class MainForm : Form
    {

        //int[,] A = {{0,1,0,1,1,0},
        //           {1,0,1,1,1,1},
        //           {0,1,0,1,0,1},
        //           {1,1,1,0,0,1},
        //           {1,1,0,0,0,0},
        //           {0,1,1,1,0,0}};

        int[,] A = {{0,1,0,0,0,0},
                   {1,0,1,0,0,1},
                   {0,1,0,1,0,0},
                   {0,0,1,0,1,0},
                   {0,0,0,1,0,0},
                   {0,1,0,0,0,0}};
        
        int countV;
        
        public MainForm()
        {
            InitializeComponent();

            countV = A.GetLength(0);

            ShowMatrix();

        }

        private void ShowMatrix()
        {
            this.dataGridView1.Rows.Clear();
            this.dataGridView1.ColumnCount = countV;
            this.dataGridView1.Rows.Add(countV);

            for (int i = 0; i < countV; i++)
            {
                this.dataGridView1.Columns[i].ReadOnly = true;
                this.dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                this.dataGridView1.Columns[i].Name = (i+1).ToString();
                this.dataGridView1.Columns[i].Width = 30;
                this.dataGridView1.Rows[i].HeaderCell.Value = (i+1).ToString();


            }

            for (int i = 0; i < countV; i++)
                for (int j = 0; j < countV; j++)
                {
                    this.dataGridView1.Rows[i].Cells[j].Value = A[i, j];
                }
        }

        private void buttonSjatie_Click(object sender, EventArgs e)
        {
            Sjatie();

            ShowMatrix();
        }

        //проводит гомеоморфное сжатие графа
        private void Sjatie()
        {
            bool edited = false;

            //список редактированных вершин
            List<int> editedVList = new List<int>();

            //проход по всем вершинам
            for (int i = 0; i < countV; i++)
            {
                edited = false;//сбрасываем флаг

                //проход по смежным вершинам
                for (int j = 0; j < countV; j++)
                {
                    //если смежная вершина уже редактировалась,конец цикла
                    if (edited) break;

                    

                    //находим смежную вершину
                    if (A[i, j] != 0)
                    {

                        int countIncV = 0;
                        for (int v = 0; v < countV; v++)
                        {
                            if (A[j, v] != 0 )
                                countIncV++;
                        }

                        //если степень полуисхода равна 1
                        if (countIncV == 2)
                        {
                            //анализируем смежные с ней вершины
                            for (int k = 0; k < countV; k++)
                            {
                                //если это не родительская вершина
                                if ((A[j, k] != 0) && (k != i))
                                {
                                    //если вершина уже редактировалась,конец цикла
                                    if (editedVList.Contains(k)) break;
                                    //если родительская вершина не смежна с текущей
                                    if ((A[i, k] == 0) && (A[k, i] == 0))
                                    {
                                        //проводим сжатие
                                        A[i, k] = A[k, i] = 1;
                                        A[i, j] = A[j, i] = A[j, k] = A[k, j] = 0;
                                        //устанавливаем признак редактирования
                                        edited = true;
                                        //добавляем вершину в список редактированных
                                        editedVList.Add(i);
                                        break;//конец цикла
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
