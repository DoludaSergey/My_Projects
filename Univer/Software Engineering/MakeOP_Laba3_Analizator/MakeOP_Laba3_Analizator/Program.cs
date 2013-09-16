using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MakeOP_Laba3_Analizator
{
    class Program
    {
        static int _Pos;       //Номер позиции анализируемого знака
        static char _Ch;       //Переменная для хранения анализируемого знака
        static string _Text;   //Переменная для хранения введенного текста
        static bool _EndOfAnaliz = false;
        static bool _AllRight = false;

        //Массив цифр
        static char[] _Digitals = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        const char EOT = ('~');//Признак окончания строки

        static void Main(string[] args)
        {
            ResetText();//Запрос ввода текста для анализа

            E();        //Анализ введенного текста

            if (_AllRight)//Если достигнут конец выражение,все в порядке
            {
                Console.WriteLine();
                Console.WriteLine("Цепочка принята!!!Выражение введенно правильно!!!");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Цепочка не принята!!!Выражение введено некорректно!!!");
            }

            Console.ReadLine();
        }

        /// <summary>
        /// Нетерминал Е,анализ введенного текста на соответствие правилам
        /// </summary>
        private static void E()
        {
            T();//Анализ слогаемого(дроби)

            if (!_EndOfAnaliz)//Если анализ еще не окончен
            {
                //Если это знак + или -
                if (_Ch == '+' || _Ch == '-')
                {
                    //В цикле пока есть + или -
                    while (_Ch == '+' || _Ch == '-')
                    {
                        //Сбрасываем признак того,что ввод правильный
                        _AllRight = false;

                        NextCh();//Читаем следующий символ

                        T();//Анализ слогаемого(дроби)
                    }
                }
                else if (_Ch == '/')//Если это знак /
                {
                    Error("Ожидается знак + , - или конец ввода!");
                }
                else//Иначе
                    Error("Ожидается дробь!");
            }
        }

        /// <summary>
        /// Нетерминал Т,анализ слогаемого(дроби)
        /// </summary>
        private static void T()
        {
            //Если достигнут конец выражения
            if (_Ch==EOT)
            {
                Error("Ожидается число!");
                return;
            }

            M();//Анализ числа

            //Сбрасываем признак того,что ввод правильный
            _AllRight = false;

            //Если анализ еще не окончен
            if (!_EndOfAnaliz)
            {
                //Если это знак /
                if (_Ch == '/')
                {
                    NextCh();//Читаем следующий символ

                    //Если это цифра
                    if (_Digitals.Contains(_Ch))
                    {
                        M();//Анализ числа

                        //Если анализ окончен
                        if (_EndOfAnaliz)
                        {
                            //Устанавливаем признок правильного ввода
                            _AllRight = true;
                        }
                    }
                    else
                        Error("Неправильно записана дробь.Ожидается цифра!");
                }
                else//Иначе
                    Error("Неправильно записана дробь, ожидается знак / !");
            }
            else Error("Неправильно записана дробь!");
            
        }

        /// <summary>
        /// Нетерминал М.Анализ цифры
        /// </summary>
        private static void M()
        {
            //Если анализ еще не окончен
            if (!_EndOfAnaliz)
            {
                //Если это цифра
                if (_Digitals.Contains(_Ch))
                {
                    //В цикле,пока идут цифры
                    while (_Digitals.Contains(_Ch))
                    {
                        NextCh();//Читаем следующий символ
                    }
                    //if (_Ch == EOT)//Если конец текста
                    //{
                    //    _EndOfAnaliz = true;
                    //    //return;//Выход из метода
                    //}
                }
                else
                    Error("Ожидается цифра!");//Сообщаем об ошибке
            }
        }

        /// <summary>
        /// Вывод сообщений об ошибке
        /// </summary>
        /// <param name="p"></param>
        private static void Error(string p)
        {
            Console.WriteLine();
            Console.WriteLine("Ошибка!!!");
            Console.WriteLine(p);
            Console.WriteLine();

            if (_Pos != 1)//Если ошибка не в первом символе,указываем ее местоположение
            {
                Console.WriteLine((_Text.Substring(0, _Pos - 1)).ToString()
                    + " - дальше начинается ошибка!");
            }
            _Ch = EOT;
            _EndOfAnaliz = true;
            //Console.ReadLine();
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
