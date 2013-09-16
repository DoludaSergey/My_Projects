using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MakeOP_Laba2_Analizator
{
    class Program
    {
        static int _Pos;       //Номер позиции анализируемого знака
        static char _Ch;       //Переменная для хранения анализируемого знака
        static string _Text;   //Переменная для хранения введенного текста

        //Массив цифр
        static char[] _Digitals = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        const char EOT = ('~');//Признак окончания строки
        
        static void Main(string[] args)
        {
            ResetText();           //Запрос ввода текста для анализа

            AdditionOfFractions(); //Анализ введенного текста

            if (_Ch!=EOT)//Если достигнут конец выражение,все в порядке
            {
                Console.WriteLine();
                Error("Цепочка не принята!!!Выражение введено некорректно!!!");
            }
            else Console.WriteLine("Цепочка принята!!!Выражение введенно правильно!!!" );

            Console.ReadLine();
        }

        /// <summary>
        /// Анализ выражения на принадлежность к сложению обычных дробей
        /// </summary>
        private static void AdditionOfFractions()
        {
            
            if (_Digitals.Contains(_Ch))//Если это цифра
            {
                Addend();//Анализ слогаемого
            }
            else Error("Ожидается цифра!!!");//Иначе ошибка

            while (_Ch=='+'||_Ch=='-')//Пока присутствует + или -
            {
                NextCh();//Читаем следующий символ
                Addend();//Анализ слогаемого
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

            if (_Pos!=1)//Если ошибка не в первом символе,указываем ее местоположение
            {
                Console.WriteLine((_Text.Substring(0, _Pos - 1)).ToString() 
                    + " - дальше начинается ошибка!");
            }
        }

        /// <summary>
        /// Анализ слогаемого
        /// </summary>
        private static void Addend()
        {
            Number();//Анализ цислителя

            if (_Ch=='/')//Если встретился знак деления
            {
                NextCh();//Считываем следующий символ
                Number();//Анализ знаменателя
            }
            else Error("Неправильно сформирована дробь!!!");//Иначе ошибка
        }

        /// <summary>
        /// Анализ числа
        /// </summary>
        private static void Number()
        {
            //Если это цифра
            if (_Digitals.Contains(_Ch))
            {
                NextCh();//Читаем следующий символ
            }//Иначе сообщаем о ошибке
            else Error("Число начинается не с цифры!!!");
            
            //Пока идут цифры
            while (_Digitals.Contains(_Ch))
            {
                NextCh();//Читаем следующий символ
            }
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
                else _Ch = EOT;//Устанавливаем признак конца текста
            } while (_Ch==' ');//Игнорируем пробелы
        }
    }
}
