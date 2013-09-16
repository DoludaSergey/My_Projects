using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ZadachONaznacheniiByWF
{
    class Naznachenie
    {
        public int Cost { get; set; }
        public bool Visited { get; set; }
        public bool Naznachen { get; set; }
    }

    public class MyWorkClass
    {
        int n = 4, cost;//размер матрицы и переменная для ввода стоимости
        string temp;//временная переменная, для безопасного ввода
        //матрица назначений со стоимостью работ
        Naznachenie[,] MasNaznach ;
        //массивы вычеркнутых строк и столбцов
        bool[] MasGorLine, MasVertLine;
        //переменная для хранения количества линий
        int countLines = 0;
        ListBox myCurentListBox;

        public void DoIt(ListBox myListBox)
        {
            myCurentListBox = myListBox;

            //myCurentListBox.Items.Add("Приложение поиска оптимального назначения!!!");
            //myCurentListBox.Items.Add("Developed by Doluda S.V.");

            //EnterTheCost();

            //копируем матрицу стоимостей для дальнейшей обработки
            Naznachenie[,] CopyMasNaznach = new Naznachenie[n, n];
            CopyMatrix(CopyMasNaznach);

            VergenMethod(CopyMasNaznach);
        }
        /// <summary>
        /// Заполнение матрицы заказов и стоимости индивидуальных перевозок
        /// </summary>
        /// <param name="myDGV"></param>
        public void PrintMatrix(DataGridView myDGV)
        {
            string fileName = "TextFile1.txt";
            string str;
            int line = 0;
            StreamReader sr = new StreamReader(fileName);
            MasNaznach = new Naznachenie[n, n];
            Naznachenie tempLog;            
            string[] vect ;
                     
            while ((str = sr.ReadLine()) != null)
            {
                vect = str.Trim().Split();
                myDGV.Rows.Add();
                myDGV.Rows[line].HeaderCell.Value = string.Format("Сотрудник №{0}", line + 1);

                for (int i = 0; i < vect.Length; i++)
                {
                    
                    myDGV.Rows[line].Cells[i].Value = vect[i];

                    tempLog = new Naznachenie();
                    tempLog.Cost = int.Parse(vect[i]);
                    MasNaznach[line, i] = tempLog;
                    
                }
                line++;
            }
        }

        private void VergenMethod(Naznachenie[,] CopyMasNaznach)
        {
            //countLines = 0;
            myCurentListBox.Items.Add("Выполняется Венгерский метод!");
            myCurentListBox.Items.Add("-----------------------------------------------------------------------");
            do
            {
                myCurentListBox.Items.Add("");
                myCurentListBox.Items.Add("Выполняется предварительное преобразование!");
                //предварительное преобразование матрицы
                PredvoritPreobrazovanie(CopyMasNaznach);
                myCurentListBox.Items.Add("Выполняется удаление строк с нулями!");
                //вычеркивание строк с нулями
                DeleteLine(CopyMasNaznach);

                //если количество линий равно размерности матрицы,
                //оптимальное назначение найдено
                if (countLines == n)
                {
                    myCurentListBox.Items.Add("-----------------------------------------------------------------------");
                    myCurentListBox.Items.Add("Найдено оптимальное назначение!");
                    //устанавливаем назначения
                    SetNaznachenie(CopyMasNaznach);
                    //выводим их на экран
                    PrintNaznachenie(CopyMasNaznach);
                }//если не найдено оптимального назначения
                else
                    EditMatrix(CopyMasNaznach);//редактируем матрицу

            } while (countLines != n);
            //пока количество линей не равно размерности матрицы
        }

        /// <summary>
        /// Преобразует матрицу назначений
        /// </summary>
        /// <param name="CopyMasNaznach"></param>
        private void EditMatrix(Naznachenie[,] CopyMasNaznach)
        {
            myCurentListBox.Items.Add("");
            myCurentListBox.Items.Add("Оптимальное назначение не найдено!");
            myCurentListBox.Items.Add("Выполняется редактирование матрицы!");
            int min = 999999;//условно большое число
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    if (!CopyMasNaznach[i, j].Visited)
                        if (min > CopyMasNaznach[i, j].Cost)
                            min = CopyMasNaznach[i, j].Cost;
            //находим минимальный элемент

            //делаем коректировку матрицы стоимости
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    //если эл зачеркнут двумя линиями,увеличить на минимум
                    if (MasGorLine[i] && MasVertLine[j])
                        CopyMasNaznach[i, j].Cost += min;
                    else//если одной линией, ничего не делаем
                        if (MasGorLine[i] || MasVertLine[j])
                            continue;
                        //если не зачеркнут,уменьшаем на минимум
                        else CopyMasNaznach[i, j].Cost -= min;

                }
        }

        /// <summary>
        /// Выводит результат назначений на экран
        /// </summary>
        /// <param name="CopyMasNaznach"></param>
        private void PrintNaznachenie(Naznachenie[,] CopyMasNaznach)
        {
            int sum = 0;//общая сумма назначений

            myCurentListBox.Items.Add("----------------------------------------------------------------------");
            myCurentListBox.Items.Add("Получаем следующее оптимальное назначение :");
            myCurentListBox.Items.Add("");
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    if (CopyMasNaznach[i, j].Naznachen)
                    {
                        myCurentListBox.Items.Add(string.Format("{0} й сотрудник назначен на {1} ю работу", i + 1, j + 1));
                        sum += MasNaznach[i, j].Cost;
                    }
            myCurentListBox.Items.Add("");
            myCurentListBox.Items.Add(string.Format("Общая стоимость назначений составит {0} единиц!", sum));
        }

        /// <summary>
        /// Устанавливает назначения
        /// </summary>
        /// <param name="CopyMasNaznach"></param>
        private void SetNaznachenie(Naznachenie[,] CopyMasNaznach)
        {
            //сбразываем признак посещения ячеек
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    CopyMasNaznach[i, j].Visited = false;

            bool hasZero = true;

            int countNullInLine;//количество нулей в строке

            while (hasZero)
            {
                hasZero = false;//сбрасываем признак

                for (int i = 0; i < n; i++)
                {
                    countNullInLine = 0;//обнуляем количество нулей
                    for (int j = 0; j < n; j++)
                        if (CopyMasNaznach[i, j].Cost == 0
                            && !CopyMasNaznach[i, j].Naznachen
                            && !CopyMasNaznach[i, j].Visited)
                        {
                            countNullInLine++;
                        }

                    if (countNullInLine == 1)
                    {//если в строке 1 ноль
                        for (int j = 0; j < n; j++)
                            if (CopyMasNaznach[i, j].Cost == 0
                                && !CopyMasNaznach[i, j].Naznachen
                                && !CopyMasNaznach[i, j].Visited)
                            {
                                //устанавливаем назначение
                                CopyMasNaznach[i, j].Naznachen = true;
                                hasZero = true;

                                //в столбце отмечаем посещенными остальные нули
                                for (int k = 0; k < n; k++)
                                    if (CopyMasNaznach[k, j].Cost == 0
                                        && !CopyMasNaznach[k, j].Visited)
                                        CopyMasNaznach[k, j].Visited = true;
                            }
                    }
                }
            }
        }

        /// <summary>
        /// Вычеркивает строки с максимальным количеством нулей
        /// </summary>
        /// <param name="CopyMasNaznach"></param>
        private void DeleteLine(Naznachenie[,] CopyMasNaznach)
        {
            //массивы вычеркнутых строк и столбцов
            MasGorLine = new bool[n];
            MasVertLine = new bool[n];
            //массивы для хранение количества нулей в строках и столбцах
            int[] MasNullByGor = new int[n];
            int[] MasNullByVert = new int[n];

            //считаем количество нулей в строках
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    if (CopyMasNaznach[i, j].Cost == 0)
                        MasNullByGor[i]++;
            //считаем количество нулей в столбцах
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    if (CopyMasNaznach[j, i].Cost == 0)
                        MasNullByVert[i]++;

            //находим максимальное количество нулей
            int maxGor = MasNullByGor.Max();
            int maxVer = MasNullByVert.Max();
            int max = Math.Max(maxGor, maxVer);
            
            bool hasZeroInLine;//признак наличия нулей
            
            while (max > 0)//пока есть необработанные нули
            {
                //проход по элементам массива нулей горизонтали
                for (int i = 0; i < n; i++)
                {
                    if (MasNullByGor[i] == max)
                    {//находим строку с максимальным количеством нулей
                        hasZeroInLine = false;//сбрасываем признак наличия нулей

                        for (int j = 0; j < n; j++)
                            if (CopyMasNaznach[i, j].Cost == 0
                                && !CopyMasNaznach[i, j].Visited)
                                hasZeroInLine = true;

                        if (hasZeroInLine)
                        {
                            countLines++;//увеличиваем количество линий
                            MasGorLine[i] = true;

                            //помечаем строку посещенной
                            for (int j = 0; j < n; j++)
                                CopyMasNaznach[i, j].Visited = true;
                        }
                    }
                }

                //проход по элементам массива нулей вертикали
                for (int i = 0; i < n; i++)
                {
                    if (MasNullByVert[i] == max)
                    {
                        hasZeroInLine = false;

                        for (int j = 0; j < n; j++)
                            if (CopyMasNaznach[j, i].Cost == 0
                                && !CopyMasNaznach[j, i].Visited)
                                hasZeroInLine = true;

                        if (hasZeroInLine)
                        {
                            countLines++;
                            MasVertLine[i] = true;

                            for (int j = 0; j < n; j++)
                                CopyMasNaznach[j, i].Visited = true;
                        }
                    }
                }
                max--;//уменьшаем значение максимального кол нулей
            }
            myCurentListBox.Items.Add(string.Format("Вычеркнуто {0} линии!", countLines));
        }

        /// <summary>
        /// Предворительное преобразование матрицы назначений
        /// </summary>
        /// <param name="CopyMasNaznach"></param>
        private void PredvoritPreobrazovanie(Naznachenie[,] CopyMasNaznach)
        {
            //проход по строкам
            for (int i = 0; i < n; i++)
            {
                int min = 999999;//любое условно большое число

                for (int j = 0; j < n; j++)
                {//находим минимальный элемент строки
                    if (min > CopyMasNaznach[i, j].Cost)
                        min = CopyMasNaznach[i, j].Cost;
                }
                //вычитаем от элемента минимальный
                for (int j = 0; j < n; j++)
                    CopyMasNaznach[i, j].Cost -= min;
            }

            //аналогично проход по столбцам
            for (int i = 0; i < n; i++)
            {
                int min = 999999;//любое условно большое число

                for (int j = 0; j < n; j++)
                {//находим минимальный элемент столбца
                    if (min > CopyMasNaznach[j, i].Cost)
                        min = CopyMasNaznach[j, i].Cost;
                }
                //вычитаем от элемента минимальный
                for (int j = 0; j < n; j++)
                    CopyMasNaznach[j, i].Cost -= min;
            }
        }

        private void CopyMatrix(Naznachenie[,] CopyMasNaznach)
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    CopyMasNaznach[i, j] = new Naznachenie();
                    CopyMasNaznach[i, j].Cost = MasNaznach[i, j].Cost;
                }
        }

        //private void EnterTheCost()
        //{
        //    //ввод стоимости работ
        //    for (int i = 0; i < n; i++)
        //        for (int j = 0; j < n; j++)
        //        {
        //            Naznachenie tempNazn = new Naznachenie();

        //            do
        //            {
        //                Console.Write("Введите стоимость работ {0} го сотрудника на {1} й должности --> ",
        //                    i + 1, j + 1);
        //                temp = Console.ReadLine();
        //            } while (!int.TryParse(temp, out cost));

        //            tempNazn.Cost = cost;
        //            MasNaznach[i, j] = tempNazn;
        //        }
        //}
    }
}
