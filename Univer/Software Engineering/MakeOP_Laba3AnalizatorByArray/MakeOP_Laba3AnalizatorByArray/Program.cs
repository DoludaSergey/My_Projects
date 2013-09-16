using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace MakeOP_Laba3AnalizatorByArray
{
    public struct Syn
    {
        public char Ch;//Символ
        public int Go;//Переход
        public bool Err;//Ошибка
        public bool Call;//Вызов
        public bool Read;//Читать
        public int Proc;//Процедура
    }
    
    class Program
    {
        static Syn[] SynTable;//Таблица

        static char[] Digital = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        static char Ch;//Текущий символ
        static int Err;//Признак ошибки
        static Stack MyStack;//Стек
        static int i;//Номер состояния


        static int _Pos;       //Номер позиции анализируемого знака.
        static char _Ch;       //Переменная для хранения анализируемого знака.
        static char _Op;       //Переменная для хранения знака операции.

        static bool _EndOfAnaliz = false;//Признак окончания анализа.
        static bool _AllRight = false;   //Признак правильного ввода выражения.

        static string _Text;   //Переменная для хранения введенного текста.
        //Переменная для хранения конечного правильного вида выражения.
        static StringBuilder _ResultText = new StringBuilder();

        const char EOT = ('~');//Признак окончания строки.
        
        static void Main(string[] args)
        {
            InitSynTable();
            ResetText();
            MyStack = new Stack();
            MyStack.Push(0);
            Err = 0;
            i = 1;

            do
            {
                if (Ch == SynTable[i].Ch ||
                    SynTable[i].Ch=='Л' || //Если это любой символ 
                    SynTable[i].Ch == 'Ц' && Digital.Contains(Ch))
                {
                    //if (SynTable[i].Proc != 0)
                    //    Proc(SynTable[i].Proc);
                    if (SynTable[i].Read)
                        NextCh();
                    if (SynTable[i].Go == 0)
                        i = (int)MyStack.Pop();
                    else
                    {
                        if (SynTable[i].Call)
                            MyStack.Push(i + 1);
                        i = SynTable[i].Go;
                    }
                }
                else if (SynTable[i].Err)
                    Err = i;
                else
                    i++;
            } while (i != 0 && Err == 0);

            if (Err == 0)
            {
                Console.WriteLine("Выражение введенно верно!!!");
            }
            else
            {
                Console.WriteLine("Выражение введенно неверно!!!");
                //Console.WriteLine("Ожидается "+SynTable[Err].Ch);

                if (_Pos != 1)//Если ошибка не в первом символе,указываем ее местоположение
                {
                    Console.WriteLine((_Text.Substring(0, _Pos - 1)).ToString()
                        + " - дальше начинается ошибка!");
                }
            }

            Console.ReadKey();
        }


        private static void InitSynTable()
        {
            SynTable = new Syn[24];

            SynTable[1].Ch = 'Л';
            SynTable[1].Go = 2;
            SynTable[1].Err = false;
            SynTable[1].Call = false;
            SynTable[1].Read = false;
            SynTable[1].Proc = 3;

            SynTable[2].Ch = '+';
            SynTable[2].Go = 5;
            SynTable[2].Err = false;
            SynTable[2].Call = false;
            SynTable[2].Read = true;
            SynTable[2].Proc = 4;

            SynTable[3].Ch = '-';
            SynTable[3].Go = 5;
            SynTable[3].Err = false;
            SynTable[3].Call = false;
            SynTable[3].Read = true;
            SynTable[3].Proc = 4;

            SynTable[4].Ch = 'Л';
            SynTable[4].Go = 5;
            SynTable[4].Err = false;
            SynTable[4].Call = false;
            SynTable[4].Read = false;
            SynTable[4].Proc = 5;

            SynTable[5].Ch = 'Л';
            SynTable[5].Go = 12;
            SynTable[5].Err = false;
            SynTable[5].Call = true;
            SynTable[5].Read = false;
            SynTable[5].Proc = 0;

            SynTable[6].Ch = 'Л';
            SynTable[6].Go = 7;
            SynTable[6].Err = false;
            SynTable[6].Call = false;
            SynTable[6].Read = false;
            SynTable[6].Proc = 6;

            SynTable[7].Ch = '+';
            SynTable[7].Go = 10;
            SynTable[7].Err = false;
            SynTable[7].Call = false;
            SynTable[7].Read = true;
            SynTable[7].Proc = 4;

            SynTable[8].Ch = '-';
            SynTable[8].Go = 10;
            SynTable[8].Err = false;
            SynTable[8].Call = false;
            SynTable[8].Read = true;
            SynTable[8].Proc = 4;

            SynTable[9].Ch = '~';
            SynTable[9].Go = 0;
            SynTable[9].Err = true;
            SynTable[9].Call = false;
            SynTable[9].Read = false;
            SynTable[9].Proc = 7;

            SynTable[10].Ch = 'Л';
            SynTable[10].Go = 12;
            SynTable[10].Err = false;
            SynTable[10].Call = true;
            SynTable[10].Read = false;
            SynTable[10].Proc = 0;

            SynTable[11].Ch = 'Л';
            SynTable[11].Go = 7;
            SynTable[11].Err = false;
            SynTable[11].Call = false;
            SynTable[11].Read = false;
            SynTable[11].Proc = 6;

            SynTable[12].Ch = 'Ц';
            SynTable[12].Go = 14;
            SynTable[12].Err = false;
            SynTable[12].Call = false;
            SynTable[12].Read = false;
            SynTable[12].Proc = 0;

            SynTable[13].Ch = 'Л';
            SynTable[13].Go = 0;
            SynTable[13].Err = true;
            SynTable[13].Call = false;
            SynTable[13].Read = false;
            SynTable[13].Proc = 9;

            SynTable[14].Ch = 'Л';
            SynTable[14].Go = 20;
            SynTable[14].Err = false;
            SynTable[14].Call = true;
            SynTable[14].Read = false;
            SynTable[14].Proc = 0;

            SynTable[15].Ch = 'Л';
            SynTable[15].Go = 16;
            SynTable[15].Err = false;
            SynTable[15].Call = false;
            SynTable[15].Read = false;
            SynTable[15].Proc = 8;

            SynTable[16].Ch = '/';
            SynTable[16].Go = 18;
            SynTable[16].Err = false;
            SynTable[16].Call = false;
            SynTable[16].Read = true;
            SynTable[16].Proc = 10;

            SynTable[17].Ch = 'Л';
            SynTable[17].Go = 0;
            SynTable[17].Err = true;
            SynTable[17].Call = false;
            SynTable[17].Read = false;
            SynTable[17].Proc = 6;

            SynTable[18].Ch = 'Л';
            SynTable[18].Go = 20;
            SynTable[18].Err = false;
            SynTable[18].Call = true;
            SynTable[18].Read = false;
            SynTable[18].Proc = 0;

            SynTable[19].Ch = 'Л';
            SynTable[19].Go = 0;
            SynTable[19].Err = false;
            SynTable[19].Call = false;
            SynTable[19].Read = false;
            SynTable[19].Proc = 9;

            SynTable[20].Ch = 'Л';
            SynTable[20].Go = 21;
            SynTable[20].Err = false;
            SynTable[20].Call = false;
            SynTable[20].Read = false;
            SynTable[20].Proc = 1;

            SynTable[21].Ch = 'Ц';
            SynTable[21].Go = 22;
            SynTable[21].Err = true;
            SynTable[21].Call = false;
            SynTable[21].Read = true;
            SynTable[21].Proc = 2;

            SynTable[22].Ch = 'Ц';
            SynTable[22].Go = 22;
            SynTable[22].Err = false;
            SynTable[22].Call = false;
            SynTable[22].Read = true;
            SynTable[22].Proc = 2;

            SynTable[23].Ch = 'Л';
            SynTable[23].Go = 0;
            SynTable[23].Err = false;
            SynTable[23].Call = false;
            SynTable[23].Read = false;
            SynTable[23].Proc = 0;
        }

        private static void NextCh()
        {
            do
            {
                if (_Pos < _Text.Length)
                {
                    Ch = _Text.ToCharArray()[_Pos++];
                }
                else
                {
                    Ch = EOT;//Устанавливаем признак конца текста
                    _Pos++;
                    _EndOfAnaliz = true;
                }
            } while (Ch == ' ');//Игнорируем пробелы
        }

        private static void Proc(int p)
        {
            throw new NotImplementedException();
        }

        private static void ResetText()
        {
            Console.WriteLine("Введите выражение сложения обычных дробей!(Допускается ввод пробелов)");
            _Text = Console.ReadLine();

            _Pos = 0;//Обнуляем указатель позиции
            NextCh();//Читаем первый символ
        }
    }
}