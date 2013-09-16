#region using
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
#endregion
namespace KursovoyGraf1
{
    public partial class MainForm : Form
    {
        bool error = false;

        public MainForm()
        {
            InitializeComponent();
        }

        #region Move_Gr_fileToEcran
        /// <summary>
        /// Заполнение формы на экране данными из файла
        /// </summary>
        /// <param name="Potok">поток чтения из файла</param>
        /// <param name="nUDn">поле формы с количеством вершин графа</param>
        /// <param name="nUDm">поле формы с количеством ребер графа</param>
        /// <param name="tBFO">текстовое поле с FO представлением графа</param>
        /// <param name="error">отчет об ошибке</param>
        public void Move_Gr_fileToEcran(StreamReader Potok, NumericUpDown nUDn,
            NumericUpDown nUDm, TextBox tBFO, ref bool error)
        {
            //Перенос чисел  n и m  на форму в компоненты  numericUpDown
            //Считываем строку с файла и преобразуем ее в вектор строк (vekt)
            //В vect[0] будет n, а в  vect[1] будет m (см.в спецификации размещение данных)
            char ch = ' ';
            string str = Potok.ReadLine();
            string[] vect = str.Trim().Split();
            int n = int.Parse(vect[0]);
            int m = int.Parse(vect[1]);

            //Выполняем контроль n и m  и заносим их в компоненты nUDn и nUDm
            if ((n < 1) || (n > 20))
            {
                MessageBox.Show("Ошибка ввода кол-ва вершин графа");
                error = true;
                return;
            }
            nUDn.Value = n;
            if ((m < 1) || (m > 50))
            {
                MessageBox.Show("Ошибка ввода кол-ва ребер графа");
                error = true;
                return;
            }
            nUDm.Value = m;
            //Перенос FO на форму в компоненту tbFO 
            //Считываем FO(может занимать несколько строк) с файла в строку S и преобразуем 
            //ее в вектор строк (vect), который переписываем в tbFO без контроля.
            string strp = "";
            string tmps = "";
            while ((str = Potok.ReadLine()) != null)
                strp += str;
            vect = strp.Split(ch);
            int k = vect.Length;
            tBFO.Clear();
            for (int i = 0; i < k; i++)
                tmps += vect[i] + " ";
            tBFO.Text = tmps.Trim();

        }
        #endregion

        #region Input_GrInEkran
        /// <summary>
        /// Ввод графа с экрана
        /// </summary>
        /// <param name="nUDn">поле с формы с количеством вершин графа</param>
        /// <param name="nUDm">поле с формы с количеством ребер графа</param>
        /// <param name="tBFO">текстовое поле с FO представлением графа</param>
        /// <param name="n">количество вершин графа</param>
        /// <param name="m">количество ребер графа</param>
        /// <param name="MS">матрица смежности</param>
        /// <param name="error">отчет об ошибке</param>
        public void Input_GrInEkran(NumericUpDown nUDn, NumericUpDown nUDm,
            TextBox tBFO, ref int n, ref int m, ref int[,] MS, ref bool error)
        {
            error = false;
            //Считываем с экрана n, m;
            n = (int)nUDn.Value;//преобразуем в целое, так как Value типа decimal
            m = (int)nUDm.Value;

            //Выполняем контроль n и m  и заносим их в компоненты nUDn и nUDm
            if ((n < 1) || (n > 20))
            {
                MessageBox.Show("Ошибка ввода кол-ва вершин графа " + nUDn.Name);
                error = true;
                return;
            }

            if ((m < 1) || (m > 50))
            {
                MessageBox.Show("Ошибка ввода кол-ва ребер графа " + nUDm.Name);
                error = true;
                return;
            }

            if (tBFO.Text == "")
            {
                MessageBox.Show("Заполните поле FO " + tBFO.Name);
                error = true;
                return;
            }
            // Проверка количества элементов FO
            int k = tBFO.Text.Trim().Split().Length;

            if (k != n + 2 * m)
            {
                MessageBox.Show("Количество элементов " + tBFO.Name + " неверно");
                error = true;
                return;
            }
            MessageBox.Show("Количество элементов " + tBFO.Name + " равно " + k);

            //обнуляем матрицу смежности 
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    MS[i, j] = 0;

            //Считываем FO и строим матрицу смежности(1.3.1)
            if (!CreatMS(tBFO, ref MS))
            {
                error = true;
                return;
            }

            //Контроль симметричности матрицы смежности(1.3.2)
            string msg = "";
            if (!SimetrMS(MS, ref msg))
            {
                MessageBox.Show(msg);
                error = true;
                return;
            }
        }
        #endregion

        #region Radius
        /// <summary>
        /// подсчет радиуса графа
        /// </summary>
        /// <param name="MS">матрица смежности</param>
        /// <returns>возвращаем радиус графа</returns>
        public int Radius(int[,] MS)
        {
            int n = (int)Math.Sqrt(MS.Length);
            int r = 1;
            int[,] MR = new int[n, n];
            int[,] B1 = new int[n, n];
            int[,] B2 = new int[n, n];
            bool pr = true;
            int[] R = new int[n];
            //копировать матрицу MS в MR=MS(1.4.1)
            CopyMatr(MS, ref  MR);
            // копировать матрицу MS в В1=MS
            CopyMatr(MS, ref  B1);
            while (pr)
            {
                pr = false;
                r = r + 1;
                // Умножение матриц В2=В1*MS(1.4.2)
                MulMatr(B1, MS, ref  B2);
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                        if ((MR[i, j] == 0) && (B2[i, j] != 0) && i != j)
                        {
                            MR[i, j] = r;
                            pr = true;
                        }
                //копировать матрицу B2 в В1=B2
                CopyMatr(B2, ref B1);
            }

            for (int i = 0; i < n; i++)
            {
                R[i] = MR[i, 0];
                for (int j = 0; j < n; j++)
                {
                    if (R[i] < MR[i, j]) R[i] = MR[i, j];
                }
            }

            int minR = 9999;
            for (int i = 0; i < n; i++)
            {
                if (R[i] < minR && R[i] != 0)
                    minR = R[i];
            }

            return minR;
        }
        #endregion

        #region CreatMS

        /// <summary>
        /// создаем матрицу смежности графа
        /// </summary>
        /// <param name="tBFO">текстовое поле</param>
        /// <param name="MS">матрица смежности</param>
        /// <returns>успех создания матрицы смежности</returns>
        public bool CreatMS(TextBox tBFO, ref int[,] MS)
        {
            char ch = ' ';
            string str = tBFO.Text;
            string[] vect = str.Trim().Split(ch);


            int L = 0;//индекс строки в компоненте tBFO
            int n = (int)Math.Sqrt(MS.Length);
            for (int i = 0; i < n; i++) //по вершинам графа
            {
                // считываем первую вершину j следующую за i
                int j = int.Parse(vect[L]);
                //контроль j
                if ((j < 0) || (j > n))
                {
                    MessageBox.Show("Элемент  FO- неверный");
                    return false;
                }
                //считывание остальных вершин j следующих за i
                while (j != 0)
                {
                    MS[i, j - 1] = 1;
                    L++;
                    j = int.Parse(vect[L]);
                    //контроль j
                    if ((j < 0) || (j > n))
                    {
                        MessageBox.Show("Элемент  FO- неверный");
                        return false;
                    }
                }
                L++;
            }
            return true;
        }
        #endregion

        #region SimetrMS
        /// <summary>
        /// проверка на симметричность матрицы смежности
        /// </summary>
        /// <param name="MS">матрица смежности</param>
        /// <param name="msg">строка с некоректными значениями</param>
        /// <returns>симетрична ли матрица</returns>
        public bool SimetrMS(int[,] MS, ref string msg)
        {
            int n = (int)Math.Sqrt(MS.Length);
            for (int i = 0; i < n; i++)
                for (int j = i + 1; j < n; j++)
                    if (MS[i, j] != MS[j, i])
                        msg = msg + "[(" + i.ToString() + "," +
                            j.ToString() + ")и(" + j.ToString() + "," + i.ToString() + ")]";
            if (msg != "")
            {
                msg = "Проверить ребра " + msg;
                return false;
            }
            else
                return true;
        }
        #endregion

        #region CopyMatr
        /// <summary>
        /// копирование матриц
        /// </summary>
        /// <param name="A">что копировать</param>
        /// <param name="B">куда копировать</param>
        public void CopyMatr(int[,] A, ref int[,] B)
        {
            int n = (int)Math.Sqrt(A.Length);
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    B[i, j] = A[i, j];
        }
        #endregion

        #region MulMatr
        /// <summary>
        /// умножение матриц
        /// </summary>
        /// <param name="A">первая матрица</param>
        /// <param name="B">вторая матрица</param>
        /// <param name="C">результирующая матрица</param>
        public void MulMatr(int[,] A, int[,] B, ref int[,] C)
        {
            int n = (int)Math.Sqrt(A.Length);
            int S;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    S = 0;
                    for (int k = 0; k < n; k++)
                        S = S + A[i, k] * B[k, j];
                    C[i, j] = S;
                }
        }
        #endregion

        //проводит гомеоморфное сжатие графа
        private void Sjatie(ref int[,] A)
        {
            bool edited = false;
            int countV = A.GetLength(0);

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
                        //обнуляем счетчик
                        int countIncV = 0;
                        //проход по смежным вершинам
                        for (int v = 0; v < countV; v++)
                        {
                            if (A[j, v] != 0)
                                countIncV++;
                        }

                        //если полустепень исхода равна 1
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

        #region buttonRezult_Click

        private void buttonRezult_Click(object sender, EventArgs e)
        {
            Sravnenie();//рабочий метод
        }

        // вычисление эквивалентности графов по их радиусу
        private void Sravnenie()
        {
            //рабочие переменные
            int n1 = 0, m1 = 0, n2 = 0, m2 = 0;
            int[,] MS1, MS2;
            string filename;

            if (/*ввод с файла*/checkBoxFromFile1.Checked)
            {

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    filename = openFileDialog1.FileName;

                    //создание потока и подсоединение к файлу 
                    StreamReader Potok = new StreamReader(filename);

                    //перепись 1-го графа  с частичным контролем  из файла на  экран;  (1.2) 
                    Move_Gr_fileToEcran(Potok, numericUpDownN1, numericUpDownM1,
                                        textBoxFO1, ref error);
                    if (error)
                    {
                        MessageBox.Show("В данных на файле ошибка!");
                        return;
                    }

                    Potok.Close();

                }
            }
            if (/*ввод с файла*/checkBoxFromFile2.Checked)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    filename = openFileDialog1.FileName;

                    //создание потока и подсоединение к файлу 
                    StreamReader Potok = new StreamReader(filename);
                    //перепись 2-го графа  с частичным контролем  из файла на  экран;
                    Move_Gr_fileToEcran(Potok, numericUpDownN2, numericUpDownM2,
                                        textBoxFO2, ref error);
                    if (error)
                    {
                        MessageBox.Show("В данных на файле ошибка!");
                        return;
                    }
                    Potok.Close();
                }
            }
            //Ввод с экрана 1-го графа с полным контролем и построением матрицы смежности 
            //MS1 (1.3)
            n1 = (int)numericUpDownN1.Value;
            MS1 = new int[n1, n1];

            Input_GrInEkran(numericUpDownN1, numericUpDownM1,
                textBoxFO1, ref  n1, ref m1, ref  MS1, ref error);

            if (error)
            {
                MessageBox.Show("В данных на форме ошибка");
                return;
            }
            //Ввод с экрана 2-го графа с полным контролем и построением матрицы смежности
            // MS2
            n2 = (int)numericUpDownN2.Value;
            MS2 = new int[n2, n2];

            Input_GrInEkran(numericUpDownN2, numericUpDownM2,
                textBoxFO2, ref  n2, ref m2, ref  MS2, ref error);
            if (error)
            {
                MessageBox.Show("В данных на форме ошибка");
                return;
            }
            //Гомеоморфное сжатие 1-го графа(1.4)
            Sjatie(ref MS1);
            //Гомеоморфное сжатие 2-го графа
            Sjatie(ref MS2);

            //Расчет радиуса 1-го графа  d1 (1.5)
            int r1 = Radius(MS1);
            //Расчет  радиуса 2-го графа d2;
            int r2 = Radius(MS2);

            MessageBox.Show(
                "Радиус первого графа равен " + r1 + " а второго " + r2);
            if ( r1 == r2)
                MessageBox.Show(
                    "Графы по радиусу эквивалентны !!!", "Поздравляю!!!");
            else
                MessageBox.Show(
                    "Графы по радиусу не эквивалентны!!!", "Увы!!!");
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Спасибо за использование данной программы!",
                "Created by Doluda S.V.");
            this.Close();
        }

    }
}
