using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace TransportnayZadachaByWF
{
    public class MyWorkingClass
    {
        private int[] STOCKS, copyStocks;
        private int[] SHOPS, copyShops;
        private int price;
        private ListBox CurentListBox;
        private Logistica[,] Transportation;

        /// <summary>
        /// Заполнение матрицы товаров, заказов и стоимости индивидуальных перевозок
        /// </summary>
        /// <param name="myDGV"></param>
        public void PrintMatrix(DataGridView myDGV)
        {
            string fileName = "TextFile1.txt";
            string str;
            int line = 0;
            StreamReader sr = new StreamReader(fileName);

            //заполнение массива заказов
            str = sr.ReadLine().Trim();
            string[] vect = str.Trim().Split();
            SHOPS = new int[vect.Length];

            myDGV.Rows.Add();//добавляем строку
            //назначаем имя заголовка столбца
            myDGV.Rows[0].HeaderCell.Value = "Заказано:";
            //заполняем строку заказов
            for (int i = 0; i < vect.Length; i++)
            {
                SHOPS[i] = int.Parse(vect[i]);
                myDGV.Rows[line].Cells[i+1].Value = "    Заказал "+vect[i]+" шт";
            }

            //заполнение массива товара на складах
            str = sr.ReadLine().Trim();
            vect = str.Trim().Split();
            STOCKS = new int[vect.Length];
            //добавляем строки для ввода стоимости индивидуальных перевозок
            myDGV.Rows.Add(vect.Length);
            //заполняем заголовки строк и данные стоимостей индивидуальных перевозок
            for (int i = 0; i < vect.Length; i++)
            {
                myDGV.Rows[i+1].HeaderCell.Value = string.Format("Склад №{0}", i+1);
                myDGV.Rows[i + 1].Cells[0].Value = "  В наличии "+vect[i]+" шт";
                STOCKS[i] = int.Parse(vect[i]);
            }

            //заполняем матрицу стоимости индивидуальных перевозок
            line = 1;//начинаем со второй строки
            Transportation = new Logistica[STOCKS.Length, SHOPS.Length];
            Logistica tempLog;

            while ((str = sr.ReadLine()) != null)
            {
                vect = str.Trim().Split();
                
                for (int i = 0; i < vect.Length; i++)
                {
                    myDGV.Rows[line].Cells[i+1].Value = " Цена перевозки "+vect[i];
                    //заполнение матрицы стоимостей
                    tempLog = new Logistica();
                    tempLog.Cost = int.Parse(vect[i]);
                    Transportation[line-1, i] = tempLog;
                }
                line++;
            }
        }

        /// <summary>
        /// Выполняет основные расчеты транспортной задачи
        /// </summary>
        /// <param name="myListBox"></param>
        public void DoIt(ListBox myListBox)
        {
            CurentListBox = myListBox;//Сохраняем ссылку на листбокс
                        
            copyStocks = (int[])STOCKS.Clone();//копируем склады для обработки
            copyShops = (int[])SHOPS.Clone();//копируем магазины для обработки
            
            //если количество товара в заказах равно количеству товара на складе
            if (SumGoods(copyStocks) == SumGoods(copyShops))
            {

                Logistica[,] copyTransportation = new Logistica[copyStocks.Length, copyShops.Length];
                CopyCost(copyTransportation);//копируем стоимости индивидуальных отгрузок для обработки
                
                NorthWestCorner(copyTransportation);//метод Северо-западного угла
                CurentListBox.Items.Add("");
                CurentListBox.Items.Add("Метод Северо-западного угла завершен! Его результаты :");
                TotalCost(copyTransportation);//вывод общей стоимости отгрузки

                PotencialsMethod(copyTransportation);//метод потенциалов

                MinElemMethod(copyTransportation);
                TotalCost(copyTransportation);//вывод общей стоимости отгрузки

                PotencialsMethod(copyTransportation);//метод потенциалов
            }
            else CurentListBox.Items.Add(
                "Несоответствие количества товара на складах с количеством товара в заказах");
        }

        /// <summary>
        /// Метод минимального элемента
        /// </summary>
        /// <param name="copyTransportation"></param>
        private void MinElemMethod(Logistica[,] copyTransportation)
        {
            CurentListBox.Items.Add("======================================================");
            CurentListBox.Items.Add("");
            CurentListBox.Items.Add("Выполняется метод минимального элемента :");

            copyStocks = (int[])STOCKS.Clone();//копируем склады для обработки
            copyShops = (int[])SHOPS.Clone();//копируем магазины для обработки
            //copiOtgruzki = new Logistica[copiStocks.Length, copiShops.Length];
            CopyCost(copyTransportation);//копируем стоимости индивидуальных отгрузок для обработки

            //пока есть товар на скадах
            while (SumGoods(copyStocks) > 0)
            {
                //создаем ссылку на элемент с минимальной стоимостью
                Logistica ElemMinPrice = new Logistica();
                //условно присваиваем ему любое большое число
                ElemMinPrice.Cost = 999999;
                int n = -1, k = -1;//значения по умолчанию

                //проход по складам для поиска элемента с минимальной стоимостью
                for (int i = 0; i < copyStocks.Length; i++)
                    if (copyStocks[i] > 0)//если есть товар на текущем складе
                        for (int j = 0; j < copyShops.Length; j++)
                        {//проходим по магазинам
                            if (copyShops[j] > 0 &&//если нужен товар на текущий магазин
                                //и стоимость элемента меньше стоимости минимального элемента
                                copyTransportation[i, j].Cost < ElemMinPrice.Cost &&
                                //и у элемента еще нет отгрузки товара
                                copyTransportation[i, j].Count == 0)
                            {
                                //меняем значение указателя на элемент с мин стоимостью
                                ElemMinPrice = copyTransportation[i, j];
                                n = i;
                                k = j;
                            }
                        }
                if (n != -1 && k != -1)//если был найден элемент с мин стоимостью
                    if (copyStocks[n] >= copyShops[k])
                    {//если на складе больше или равно товара, чем заказано
                        //отгружаем это количество
                        ElemMinPrice.Count = copyShops[k];
                        //уменьшаем остаток товара на складе
                        copyStocks[n] -= copyShops[k];
                        //снимаем заказ с магазина
                        copyShops[k] = 0;
                    }
                    else
                    {//иначе (если на складе товара меньше чем надо)
                        //отгружаем все что есть на складе
                        ElemMinPrice.Count = copyStocks[n];
                        //уменьшаем заказ на отгруженное количество
                        copyShops[k] -= copyStocks[n];
                        //обнуляем остаток товара на складе
                        copyStocks[n] = 0;
                    }
            }
            CurentListBox.Items.Add("");
            CurentListBox.Items.Add("Метод минимального элемента завершен! Его результаты :");
        }

        /// <summary>
        /// Метод потенциалов
        /// </summary>
        /// <param name="copyTransportation"></param>
        private void PotencialsMethod(Logistica[,] copyTransportation)
        {
            int[] U, V;//потенциалы поставщиков и заказчиков соответственно
            bool hasEkonom = true;//признак 

            do
            {
                CurentListBox.Items.Add("");
                CurentListBox.Items.Add("Выполняется метод потенциалов");

                hasEkonom = false;//признак возможности экономии
                //создаем массивы потенциалов
                U = new int[copyStocks.Length];
                V = new int[copyShops.Length];

                //накладываем маску на потенциалы
                for (int i = 0; i < copyStocks.Length; i++)
                    U[i] = 999999;
                for (int i = 0; i < copyShops.Length; i++)
                    V[i] = 999999;

                U[0] = 0;//условно принимаем потенциал первого поставщика равным нулю

                bool hasMask = true;//устанавливаем признак окончания поиска потенциалов
                //пока есть маски на потенциалах
                //просчитываем потенциалы поставщиков и потребителей
                while (hasMask)
                {
                    hasMask = false;//сбрасываем признак

                    //проходим по всем элементам матрицы отгрузок
                    for (int i = 0; i < copyStocks.Length; i++)
                        for (int j = 0; j < copyShops.Length; j++)
                        {
                            //если потенциал поставщика известен
                            if (U[i] != 999999)//999999 - маска
                            {
                                //если потенциал заказчика не найден и есть отгрузка на этого заказчика
                                if (V[j] == 999999 && copyTransportation[i, j].Count != 0)
                                    //вычисляем потенциал заказчика
                                    V[j] = copyTransportation[i, j].Cost - U[i];
                            }
                            //иначе если потенциал поставщика не известен
                            else
                                //если известен потенциал заказчика и есть отгрузка на этого заказчика
                                if (V[j] != 999999 && copyTransportation[i, j].Count != 0)
                                    //вичисляем потенциал поставщика
                                    U[i] = (int)copyTransportation[i, j].Cost - V[j];
                                //иначе если не известен
                                else
                                    //устанавливаем признак наличия маски
                                    hasMask = true;
                        }
                }

                //обнуляем потенциалы
                for (int i = 0; i < copyStocks.Length; i++)
                    for (int j = 0; j < copyShops.Length; j++)
                        copyTransportation[i, j].InderectCost = 0;

                //расчет косвенных стоимостей
                for (int i = 0; i < copyStocks.Length; i++)
                    for (int j = 0; j < copyShops.Length; j++)
                        //если нет отгрузки в данной ячейке(свободная ячейка)
                        if (copyTransportation[i, j].Count == 0)
                            //вычисляем косвенную стоимость
                            copyTransportation[i, j].InderectCost = U[i] + V[j];

                int n = 0, k = 0, tempN, tempK;
                int eko = 0;//сумма экономии

                //проверка условия оптимальности плана
                for (int i = 0; i < copyStocks.Length; i++)
                    for (int j = 0; j < copyShops.Length; j++)
                        if (copyTransportation[i, j].Count == 0
                            //&& copyTransportation[i, j].InderectCost!=999999
                            && copyTransportation[i, j].InderectCost > copyTransportation[i, j].Cost
                            && eko < copyTransportation[i, j].InderectCost - copyTransportation[i, j].Cost)
                        {
                            //если возможна экономия, устанавливаем признак
                            hasEkonom = true;
                            eko = copyTransportation[i, j].InderectCost - copyTransportation[i, j].Cost;
                            //запоминаем координаты данной ячейки
                            n = i;
                            k = j;
                        }

                //копируем координаты ячейки для обработки
                tempN = n;
                tempK = k;

                //если возможна экономия
                if (hasEkonom)
                {
                    int x = 0, y = 0, tempX = 0, tempY = 0;

                    CurentListBox.Items.Add(string.Format("Возможно сэкономить {0} денежных единиц на 1 единице груза!", eko));
                    //проходим по матрице отгрузок по направляющим от исходной ячейки
                    //по вертикали
                    for (int i = 0; i < copyStocks.Length; i++)
                    {
                        if (tempN > 0)//движемся вверх от исходной ячейки
                        {
                            //если есть отгрузка в текущей ячейке
                            if (copyTransportation[(--tempN), tempK].Count > 0)
                            {
                                //запоминаем количество отгружаемого товара
                                x = copyTransportation[(tempN), tempK].Count;
                                //запоминаем позицию текущей ячейки
                                tempX = tempN;
                                break;//принудительный выход из цикла
                            }
                        }
                        else //иначе движемся снизу
                            if (copyTransportation[((copyStocks.Length + --tempN)), tempK].Count > 0)
                            {
                                x = copyTransportation[(copyStocks.Length + tempN), tempK].Count;
                                tempX = (copyStocks.Length + tempN);
                                break;
                            }
                    }

                    //аналогично по горизонтали
                    for (int i = 0; i < copyShops.Length; i++)
                    {
                        if (tempK < copyShops.Length - 1)
                        {
                            if (copyTransportation[n, (++tempK)].Count > 0)
                            {
                                y = copyTransportation[n, (tempK)].Count;
                                tempY = tempK;
                                break;
                            }
                        }
                        else if (copyTransportation[n, (copyShops.Length - Math.Abs(copyShops.Length - 1 - (++tempK)))].Count > 0)
                        {
                            y = copyTransportation[n, (copyShops.Length - Math.Abs(copyShops.Length - 1 - (tempK)))].Count;
                            tempY = (copyShops.Length - Math.Abs(copyShops.Length - 1 - (tempK)));
                            break;
                        }
                    }

                    //вычисляем лямбду(минимум из выбранных значений)
                    int lamda = Math.Min(x, y);
                    CurentListBox.Items.Add(string.Format("Лямбда равна {0}", lamda));
                    CurentListBox.Items.Add("Выравниваем баланс с поправкой на лямбду");

                    //выравниваем баланс с поправкой на лямбду
                    copyTransportation[n, k].Count += lamda;
                    copyTransportation[tempX, k].Count -= lamda;
                    copyTransportation[tempX, tempY].Count += lamda;
                    copyTransportation[n, tempY].Count -= lamda;

                    CurentListBox.Items.Add("");
                    CurentListBox.Items.Add("Метод потенциалов завершен!Получили следующий результат :");
                    TotalCost(copyTransportation);//вывод общей стоимости отгрузки
                }

            } while (hasEkonom);
            CurentListBox.Items.Add("Сэкономить больше неначем!!!Найден оптимальный результат!!!");
        }

        /// <summary>
        /// подсчет количества товара
        /// </summary>
        /// <param name="mass"></param>
        /// <returns></returns>
        private static int SumGoods(int[] mass)
        {
            int sumTovara = 0;

            for (int i = 0; i < mass.Length; i++)
                sumTovara += mass[i];

            return sumTovara;
        }
        /// <summary>
        /// подсчет общей стоимости перевозок
        /// </summary>
        /// <param name="copiOtgruzki"></param>
        private void TotalCost(Logistica[,] copiOtgruzki)
        {
            //Console.WriteLine("\nВыполняется метод поиска общей стоимости перевозок :");
            price = 0;

            CurentListBox.Items.Add("");
            for (int i = 0; i < copyStocks.Length; i++)
                for (int j = 0; j < copyShops.Length; j++)
                {
                    price += copiOtgruzki[i, j].Count * copiOtgruzki[i, j].Cost;
                    if (copiOtgruzki[i, j].Count > 0)
                        CurentListBox.Items.Add(string.Format("С {0}-го склада на {1}-й магазин отгрузить {2} единиц товара",
                            i + 1, j + 1, copiOtgruzki[i, j].Count));
                }

            CurentListBox.Items.Add("");
            CurentListBox.Items.Add(string.Format("Общая стоимость перевозок составит {0} грн", price));
            CurentListBox.Items.Add("======================================================");
        }
        /// <summary>
        /// метод Северо-западного угла
        /// </summary>
        /// <param name="copiOtgruzki"></param>
        private void NorthWestCorner(Logistica[,] copiOtgruzki)
        {
            CurentListBox.Items.Add("Выполняется метод Северо-западного угла :");

            for (int i = 0; i < copyStocks.Length; i++)
                for (int j = 0; j < copyShops.Length; j++)
                {
                    if (copyShops[j] > 0)//если нужен товар на даный магазин
                    {
                        if (copyStocks[i] >= copyShops[j])
                        {//если на складе товара больше,чем надо на магазин
                            //отгружаем нужное количество товара
                            copiOtgruzki[i, j].Count = copyShops[j];
                            //обнуляем остаток на складе
                            copyStocks[i] -= copyShops[j];
                            //обнуляем заказ
                            copyShops[j] = 0;
                        }
                        else
                        {//иначе,если на складе товара меньше,чем надо
                            //отгружаем столько,сколько есть на складе
                            copiOtgruzki[i, j].Count = copyStocks[i];
                            //уменьшаем заказ
                            copyShops[j] -= copyStocks[i];
                            //обнуляем остаток на складе
                            copyStocks[i] = 0;
                        }
                    }

                }
        }
        /// <summary>
        /// копирование элементов матрицы отгрузки
        /// </summary>
        /// <param name="copiOtgruzki"></param>
        private void CopyCost(Logistica[,] copiOtgruzki)
        {
            //Console.WriteLine("\nВыполняется метод копирования массива отгрузок :");
            for (int i = 0; i < copyStocks.Length; i++)
                for (int j = 0; j < copyShops.Length; j++)
                {
                    copiOtgruzki[i, j] = new Logistica();
                    copiOtgruzki[i, j].Cost = Transportation[i, j].Cost;
                }
        }

        public class Logistica
        {
            public int Cost { get; set; }
            public int Count { get; set; }
            public int InderectCost { get; set; }
        }

    }
}
