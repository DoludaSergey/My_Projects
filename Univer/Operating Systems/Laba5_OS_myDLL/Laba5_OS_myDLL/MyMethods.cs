using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDLL
{
    public class MyMethodsClass
    {
        public static string PrintText1()
        {
            return "Hello, world!!!From MyDll.....";
        }

        public static string PrintText2()
        {
            return "Текст из динамически подключаемой библиотеки MyDll.....";
        }
    }
}
