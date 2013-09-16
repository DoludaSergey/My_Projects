using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InsertSort
{
    public partial class Form1 : Form
    {
        int[] A;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCreateMas_Click(object sender, EventArgs e)
        {
            if (this.textBoxNum.Text != "")
            {
                int num;

                if (int.TryParse(this.textBoxNum.Text, out num))
                {
                    Random r = new Random();
                    A = new int[num];
                    StringBuilder str = new StringBuilder();

                    for (int i = 0; i < num; i++)
                    {
                        A[i] = r.Next(100);
                    }

                    this.listBox1.Items.Clear();
                    this.listBox1.Items.Add("Сгенерирован следующий исходный массив :");
                    this.listBox1.Items.Add("");

                    for (int i = 0; i < num; i++)
                    {
                        str.Append(string.Format(" {0}", A[i]));
                        if (i!=0 && (i % 30) == 0)
                        {
                            this.listBox1.Items.Add(str);
                            str.Clear();
                        }
                        
                    }
                    this.listBox1.Items.Add(str);
                }
                else
                    MessageBox.Show("Вводить нужно символы!!!", "Ошибка ввода!!!");
            }
            else
                MessageBox.Show("Введите количество сортируемых элементов!!!","Ошибка ввода!!!");


        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            if (A != null)
            {
                this.InputSort();

                StringBuilder str = new StringBuilder();

                this.listBox1.Items.Add("===========================================================================");
                this.listBox1.Items.Add("Массив после сортировки имеет следующий вид :");
                this.listBox1.Items.Add("");

                for (int i = 0; i < A.Length; i++)
                {
                    str.Append(string.Format(" {0}", A[i]));
                    if (i != 0 && (i % 30) == 0)
                    {
                        this.listBox1.Items.Add(str);
                        str.Clear();
                    }

                }
                this.listBox1.Items.Add(str);
            }
        }

        public void InputSort()
        {
            int x,j;
            for (int i = 1; i < A.Length; i++)
            {
                if (A[i - 1] > A[i])
                {
                    x = A[i];
                    j = i - 1;
                    while ((j >= 0) && (A[j] > x))
                    {
                        A[j + 1] = A[j];
                        --j;
                    }
                    A[j + 1] = x;
                }
            }
        }
    }
}
