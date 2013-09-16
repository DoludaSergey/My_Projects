using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MakeOP_Laba4_Analizator
{
    class MultiplicationOfFractions
    {
        static int _Pos;       //Номер позиции анализируемого знака.
        static char _Ch;       //Переменная для хранения анализируемого знака.
        static char _Op;       //Переменная для хранения знака операции.
        
        static bool _EndOfAnaliz = false;//Признак окончания анализа.
        static bool _AllRight = false;   //Признак правильного ввода выражения.

        static int _Y;         //Переменная для хранения целого числа.
        static float _Drob;    //Переменная для хранения значения дроби.
        static float _Summa;   //Переменная для хранения суммы выражения.

        static string _Text;   //Переменная для хранения введенного текста.
        //Переменная для хранения конечного правильного вида выражения.
        static StringBuilder _ResultText = new StringBuilder();

        //Массив цифр.
        static char[] _Digitals = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        const char EOT = ('~');//Признак окончания строки.


        static void Main(string[] args)
        {
            ResetText();  //Запрос ввода текста для анализа.

            Analizator(); //Нетерминал Е.Анализ введенного текста.

            if (_AllRight)//Если достигнут конец выражения и все в порядке.
            {
                Console.WriteLine();
                Console.WriteLine("Цепочка принята!!!Выражение введенно правильно!!!");
                Console.WriteLine("Сумма выражения {0} равна : {1:F}", _ResultText,_Summa);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Цепочка не принята!!!Выражение введено некорректно!!!");
            }

            Console.ReadLine();
        }

        /// <summary>
        /// Нетерминал Е.Анализ введенного текста на соответствие правилам.
        /// </summary>
        private static void Analizator()
        {
            _Summa = 0;//Семантическая процедура Р3.Обнуление суммы выражения.

            if (_Ch == '+' || _Ch == '-')
            {
                _Op = _Ch;//Семантическая процедура Р4.
                _ResultText.Append(_Op);//Семантическая процедура P11.

                NextCh();//Читаем следующий символ.
            }
            else
                _Op = '+';//Семантическая процедура Р5.

            Addend();//Нетерминал Т.Анализ слогаемого(дроби).

            if (_Op == '+')//Семантическая процедура Р6.
            {
                _Summa += _Drob;
            }
            else
            {
                _Summa -= _Drob;
            }

            if (!_EndOfAnaliz)//Если анализ еще не окончен.
            {
                //Если это знак + или -.
                if (_Ch == '+' || _Ch == '-')
                {
                    //В цикле пока есть + или -.
                    while (_Ch == '+' || _Ch == '-')
                    {
                        //Сбрасываем признак того,что ввод правильный.
                        _AllRight = false;

                        _Op = _Ch;//Семантическая процедура Р4.

                        _ResultText.Append(_Op);//Семантическая процедура P11.

                        NextCh();//Читаем следующий символ.

                        Addend();//Нетерминал Т.Анализ слогаемого(дроби).

                        if (_Op == '+')//Семантическая процедура Р6.
                        {
                            _Summa += _Drob;
                        }
                        else
                            _Summa -= _Drob;
                    }
                }
                else if (_Ch == '/')//Если это знак /.
                {
                    Error("Ожидается знак + , - или конец ввода!");
                }
                else//Иначе.
                    Error("Ожидается дробь!");
            }
        }

        /// <summary>
        /// Нетерминал Т,анализ слогаемого(дроби).
        /// </summary>
        private static void Addend()
        {
            int chisl, znam;//Переменные для числителя и знаменателя.
            
            //Если достигнут конец выражения.
            if (_EndOfAnaliz)
            {
                Error("Ожидается число!");
                return;
            }

            Number();//Нетерминал М.Анализ числа.

            chisl = _Y;//Семантическая процедура P8.

            //Сбрасываем признак того,что ввод правильный.
            _AllRight = false;

            //Если анализ еще не окончен.
            if (!_EndOfAnaliz)
            {
                //Если это знак /.
                if (_Ch == '/')
                {
                    NextCh();//Читаем следующий символ.

                    //Если это цифра.
                    if (_Digitals.Contains(_Ch))
                    {
                        Number();//Анализ числа.

                        znam = _Y;//Семантическая процедура P9.

                        if (znam != 0)
                        {
                            _Drob = chisl / (float)znam;//Семантическая процедура P10.

                            _ResultText.Append(chisl);//Семантическая процедура P11.
                            _ResultText.Append('/');
                            _ResultText.Append(znam);
                        }
                        else
                            Error("Деление на ноль!!!");
                        

                        //Если анализ окончен.
                        if (_EndOfAnaliz)
                        {
                            //Устанавливаем признок правильного ввода.
                            _AllRight = true;
                        }
                    }
                    else
                        Error("Неправильно записана дробь.Ожидается цифра!");
                }
                else//Иначе.
                    Error("Неправильно записана дробь, ожидается знак / !");
            }
            else Error("Неправильно записана дробь!");
        }

        /// <summary>
        /// Нетерминал М.Анализ цифры.
        /// </summary>
        private static void Number()
        {
            //Переменные для хранения считанной цифры и остатка от деления.
            int d,r;

            _Y = 0;//Семантическая процедура Р1.Обнуление целого числа.
            
            //Если анализ еще не окончен.
            if (!_EndOfAnaliz)
            {
                //Если это цифра
                if (_Digitals.Contains(_Ch))
                {
                    //В цикле,пока идут цифры.
                    while (_Digitals.Contains(_Ch))
                    {
                        //Семантическая процедура Р2.Считывание значения целого числа.
                        d = int.Parse(_Ch.ToString());
                        
                        //Проверка на переполнение.
                        if (_Y<= Math.DivRem((int.MaxValue-d),10,out r))
                        {
                            _Y = 10 * _Y + d;
                        }

                        NextCh();//Читаем следующий символ.
                    }
                }
                else
                    Error("Ожидается цифра!");//Сообщаем об ошибке.
            }
        }

        /// <summary>
        /// Вывод сообщений об ошибке.
        /// </summary>
        /// <param name="p"></param>
        private static void Error(string p)
        {
            Console.WriteLine();
            Console.WriteLine("Синтаксическая ошибка!!!");
            Console.WriteLine(p);
            Console.WriteLine();

            if (_Pos != 1)//Если ошибка не в первом символе,указываем ее местоположение
            {
                Console.WriteLine((_Text.Substring(0, _Pos - 1)).ToString()
                    + " - дальше начинается ошибка!");
            }
            _Ch = EOT;
            _EndOfAnaliz = true;
        }

        /// <summary>
        /// Запрос ввода выражения для анализа
        /// </summary>
        private static void ResetText()
        {
            Console.WriteLine("Введите выражение сложения обычных дробей!(Допускается ввод пробелов)");
            _Text = Console.ReadLine();

            _Pos = 0;//Обнуляем указатель позиции
            NextCh();//Читаем первый символ
        }

        /// <summary>
        /// Читает следующий символ введенного выражения
        /// </summary>
        private static void NextCh()
        {
            do
            {
                if (_Pos < _Text.Length)
                {
                    _Ch = _Text.ToCharArray()[_Pos++];
                }
                else
                {
                    _Ch = EOT;//Устанавливаем признак конца текста
                    _Pos++;
                    _EndOfAnaliz = true;
                }
            } while (_Ch == ' ');//Игнорируем пробелы
        }
    }
}
