using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KursovoyGrafByClass
{
    public class NeorGraf
    {
        #region property
        private int[,] MS     { get; set; }
        private int NumVerhin { get; set; }
        private int NumReber  { get; set; }
        private int Diametr   { get; set; }
        #endregion

        #region metods

        /// <summary>
        /// Создание матрицы смежности
        /// </summary>
        /// <param name="tBFO">Текстовое поле со строкой данных</param>
        /// <returns>Успешное создание</returns>
        bool CreatMS(TextBox tBFO)
        {
            // создаем и обнуляем матрицу смежности 
            MS = new int[NumVerhin, NumVerhin];
            for (int i = 0; i < NumVerhin; i++)
                for (int j = 0; j < NumVerhin; j++)
                    MS[i, j] = 0;
            
            char ch = ' ';//символ -разделитель
            string str = tBFO.Text;//считываем строку
            string[] vect = str.Trim().Split(ch);//разбиваем строку на составляющие

            int L = 0;//индекс
            
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

        /// <summary>
        /// Проверка матрицы на симметричность
        /// </summary>
        /// <param name="msg"> строка с несиметричными элементами</param>
        /// <returns>Результат симметрии</returns>
        bool SimetrMS(ref string msg)
        {
            for (int i = 0; i < NumVerhin; i++)
                for (int j = i + 1; j < NumVerhin; j++)
                    if (MS[i, j] != MS[j, i])
                        msg = msg + "[(" + i.ToString() + "," +
                        j.ToString() + ")и(" + j.ToString() + "," +
                        i.ToString() + ")]";
            if (msg != "")
                return false;
            else
                return true;
        }

        /// <summary>
        /// Чтение данных с текстового поля и создание матрицы смежности
        /// </summary>
        /// <param name="nUDn">Число вершин графа</param>
        /// <param name="nUDm">Число ребер графа</param>
        /// <param name="tBFO">Текстовое поле с данными</param>
        public void Input_GrInEkran(NumericUpDown nUDn, NumericUpDown nUDm, TextBox tBFO)
        {
           //Считываем с экрана n, m;
           NumVerhin = (int)nUDn.Value;//преобразуем в целое, так как Value типа decimal
           NumReber = (int)nUDm.Value;
           //Выполняем контроль n и m  и заносим их в компоненты nUDn и nUDm
           if ((NumVerhin < 1) || (NumVerhin > 20))
           {
               MessageBox.Show("Ошибка ввода кол-ва вершин графа " + nUDn.Name);
           }

           if ((NumReber < 1) || (NumReber > 50))
           {
               MessageBox.Show("Ошибка ввода кол-ва ребер графа " + nUDm.Name);
           }

           if (tBFO.Text.Trim() == "")
           {
               MessageBox.Show("Заполните поле FO " + tBFO.Name);
           }
           // Проверка количества элементов FO
           int k = tBFO.Text.Trim().Split().Length;

           if (k != NumVerhin + 2 * NumReber)
           {
               //MessageBox.Show("Количество элементов " + tBFO.Name + " неверно");
               throw new MyExcept("Количество элементов " + tBFO.Name + " неверно");
               //return false;
           }
           MessageBox.Show("Количество элементов " + tBFO.Name + " равно " + k);


           //Считываем FO и строим матрицу смежности(1.3.1)
           if (!CreatMS(tBFO))
           {
               throw new MyExcept("Не удалось создать матрицу смежности");
               //return false;
           }

           //Контроль симметричности матрицы смежности(1.3.2)
           string msg = "";
           if (!SimetrMS(ref msg))
           {
               throw new MyExcept(msg);
               //return false;
           }
           //return true;
         }

        /// <summary>
        /// Копирование матриц
        /// </summary>
        /// <param name="A">Исходная матрица</param>
        /// <param name="B">Результирующая матрица</param>
        public void CopyMatr(int[,] A, ref int[,] B)
        {
            for (int i = 0; i < NumVerhin; i++)
                for (int j = 0; j < NumVerhin; j++)
                    B[i, j] = A[i, j];
        }
        /// <summary>
        /// Умножение матриц
        /// </summary>
        /// <param name="A">Первая матрица</param>
        /// <param name="B">Вторая матрица</param>
        /// <param name="C">Результирующая матрица</param>
        public void MulMatr(int[,] A, int[,] B, ref int[,] C)
        {
        int S;
        for(int i=0;i< NumVerhin; i++)
             for(int j=0;j< NumVerhin; j++)
            {
                 S=0;
                 for (int k = 0; k < NumVerhin; k++)
                     S = S + A[i, k] * B[k, j];
                 C[i,j]=S;
            }
        }


        //проводит гомеоморфное сжатие графа
        public void Sjatie()
        {
            bool edited = false;
            int countV = this.MS.GetLength(0);

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
                    if (this.MS[i, j] != 0)
                    {
                        //обнуляем счетчик
                        int countIncV = 0;
                        //проход по смежным вершинам
                        for (int v = 0; v < countV; v++)
                        {
                            if (this.MS[j, v] != 0)
                                countIncV++;
                        }

                        //если полустепень исхода равна 1
                        if (countIncV == 2)
                        {
                            //анализируем смежные с ней вершины
                            for (int k = 0; k < countV; k++)
                            {
                                //если это не родительская вершина
                                if ((this.MS[j, k] != 0) && (k != i))
                                {
                                    //если вершина уже редактировалась,конец цикла
                                    if (editedVList.Contains(k)) break;
                                    //если родительская вершина не смежна с текущей
                                    if ((this.MS[i, k] == 0) && (this.MS[k, i] == 0))
                                    {
                                        //проводим сжатие
                                        this.MS[i, k] = this.MS[k, i] = 1;
                                        this.MS[i, j] = this.MS[j, i] = this.MS[j, k] = this.MS[k, j] = 0;
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


        /// <summary>
        /// Расчет диаметра матрицы
        /// </summary>
        public void DiametrGraf()
        {
            int r = 1;
            int[,] MR = new int[NumVerhin, NumVerhin];
            int[,] B1 = new int[NumVerhin, NumVerhin];
            int[,] B2 = new int[NumVerhin, NumVerhin];
            bool pr = true;
            //копировать матрицу MS в MR(1.4.1)
            CopyMatr(MS, ref  MR);
            // копировать матрицу MS в В1
            CopyMatr(MS, ref  B1);
            while (pr)
            {
                pr = false;
                r ++;
                // Умножение матриц В2=В1*MS(1.4.2)
                MulMatr(B1, MS, ref  B2);
                for (int i = 0; i < NumVerhin; i++)
                    for (int j = 0; j < NumVerhin; j++)
                        if ((MR[i, j] == 0) && (B2[i, j] != 0))
                        {
                            MR[i, j] = r;
                            pr = true;
                        }
                //копировать матрицу B2 в В1
                CopyMatr(B2, ref B1);
            }
            this.Diametr = r - 1;
        }

        /// <summary>
        /// Сравнение графов по диаметру
        /// </summary>
        /// <param name="obj">экземпляр графа</param>
        /// <returns>Результат сравнения</returns>
        public bool Equals(NeorGraf obj)
        {
            if (this.Diametr == obj.Diametr)
                return true;
            else
                return false;
        }
        #endregion
    }
}
