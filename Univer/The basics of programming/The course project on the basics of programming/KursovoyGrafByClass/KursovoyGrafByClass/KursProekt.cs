using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace KursovoyGrafByClass
{
    public class MyExcept : ApplicationException
    {
        public MyExcept(string msg) : base(msg) { }
    }

    public class KursProekt
    {
        //свойства класса
        public NeorGraf Gr1 { get; set; }
        public NeorGraf Gr2 { get; set; }
        public String FileName { get; set; }
        public StreamReader Potok { get; set; }

        
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public KursProekt()
        {
            Gr1 = new NeorGraf();
            Gr2 = new NeorGraf();
        }

        public void Sravnenie(bool fileEkran1,bool fileEkran2, 
            OpenFileDialog openFileDialog,NumericUpDown nUDn1, 
            NumericUpDown nUDm1,TextBox tBFO1,NumericUpDown nUDn2,
            NumericUpDown nUDm2, TextBox tBFO2)
        {
            try//контроль переписи с файла и ввода с экрана
            {
                if (fileEkran1)
                {
                    if (!ConectFile(openFileDialog))//подключение к файлу и создани потока (1.1)
                        {
                            MessageBox.Show("Файл не выбран! Повторите ввод");
                            return;
                        }

                    try//контроль переписи с файла   
                    {
                        //перепись 1-го графа  с частичным контролем  из файла на  экран;  (1.2)
                        Move_Gr_fileToEcran(1,nUDn1, nUDm1, tBFO1);
                    }
                    // обработка исключений при переписи с файла 
                    catch (MyExcept e)
                    //здесь исключение вновь создается с уточнением места ошибки
                    {
                        throw new MyExcept(e.Message + " при чтении из файла");
                    }
                }

                if (fileEkran2)
                {
                    if (!ConectFile(openFileDialog))//подключение к файлу и создани потока (1.1)
                    {
                        MessageBox.Show("Файл не выбран! Повторите ввод");
                        return;
                    }
                    try//контроль переписи с файла   
                    {
                        //перепись 2-го графа  с частичным контролем  из файла на  экра;                            
                        Move_Gr_fileToEcran(2, nUDn2, nUDm2, tBFO2);//gr2.ng
                    }
                    // обработка исключений при переписи с файла 
                    catch (MyExcept e)
                    //здесь исключение вновь создается с уточнением места ошибки
                    {
                        throw new MyExcept(e.Message + "\nошибка возникла при чтении из файла");
                    }
                }

                try//контроль  ввода с экрана
                {
                    //Ввод с экрана 1-го графа с полным контролем и построением матрицы смежности MS1 (1.3)
                    Gr1.Input_GrInEkran(nUDn1, nUDm1, tBFO1);
                    //Ввод с экрана 2-го графа с полным контролем и построением матрицы смежности MS2
                    Gr2.Input_GrInEkran(nUDn2, nUDm2, tBFO2);
                }
                // обработка исключений при вводе с экрана     
                catch (MyExcept e)
                {
                    //здесь исключение вновь создается с уточнением места ошибки
                    throw new MyExcept(e.Message  + "\nошибка возникла при чтении с экрана");
                }
            }

            //обработка  всех исключений
            catch (MyExcept e)
            {
                MessageBox.Show(e.Message);
                return;
            }

            //Гомеоморфное сжатие 1-го графа(1.4)
            Gr1.Sjatie();
            //Гомеоморфное сжатие 2-го графа
            Gr2.Sjatie();

            //Расчет диаметра графа 1(1.5)
            Gr1.DiametrGraf();
            //Расчет диаметра графа 2
            Gr2.DiametrGraf();

            if (Gr1.Equals(Gr2))//сравнение характеристик(1.5)
               MessageBox.Show("Графы по диаметру эквивалентны!!!","Поздравляем!!!");
            else
                MessageBox.Show("Графы по диаметру не эквивалентны!!!","Неудача");
        }

        /// <summary>
        /// Создает поток для чтения из файла
        /// </summary>
        /// <param name="openFileDialog1">Диалоговое окно выбора файла</param>
        /// <returns>Удалось ли выполнить подключение</returns>
        public bool ConectFile(OpenFileDialog openFileDialog1)
        {
            //Выбор файла и создание потока(1.1)
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.FileName = openFileDialog1.FileName;
                //создание потока и подсоединение к файлу 
                this.Potok = new StreamReader(FileName);
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Чтение данных из файла и перенос их на форму
        /// </summary>
        /// <param name="ng">Номер текущего графа</param>
        /// <param name="nUDn">Количество вершин</param>
        /// <param name="nUDm">Количество ребер</param>
        /// <param name="tBFO">Текстовое поле для предстафления графа в виде FO</param>
        void Move_Gr_fileToEcran(int ng, NumericUpDown nUDn,  
                NumericUpDown nUDm,TextBox tBFO)
        {
            //Перенос чисел  n и m  на форму в компоненты  numericUpDown
            //Считываем строку с файла и преобразуем ее в вектор строк (veсt)
            //В vect[0] будет n, а в  vect[1] будет m (см.в спецификации размещение данных)
            char ch = ' ';
            string str = Potok.ReadLine();
            string[] vect = str.Trim().Split();
            int n, m;
            
            try// контроль формата чисел
            {
               n = int.Parse(vect[0]);
               m = int.Parse(vect[1]);
            }
            
            catch (FormatException e)
            {
               //добавим в класс графа поле целого типа ng, 
               //которое позволит уточнить в каком графе ошибка
               throw new MyExcept("В числах n или m недопустимый символ в графе"+ ng.ToString());
            }
            
            //Выполняем контроль n и m  и заносим их в компоненты nUDn и nUDm
            if ((n < 1) || (n > 20))
              throw new MyExcept("Ошибка ввода кол-ва вершин графа " + ng.ToString());
            
            nUDn.Value = n;
            
            if ((m < 1) || (m > 50))
              throw new MyExcept("Ошибка ввода кол-ва ребер графа " + ng.ToString());
            
            nUDm.Value = m;
            
            //Перенос FO на форму в компоненту tbFO 
            //Считываем FO с файла в строку str и преобразуем
            // ее в вектор строк (vect), который переписываем в tbFO без контроля
            
            string strp = "";
            string tmps = "";

            while ((str = Potok.ReadLine()) != null)
                strp +=" "+ str.Trim();
            
            vect = strp.Split(ch);
            int k = vect.Length;
            tBFO.Clear();
            for (int i = 0; i < k ; i++)
                tmps += vect[i] + " ";
            tBFO.Text = tmps.Trim();
        }


    }
}
