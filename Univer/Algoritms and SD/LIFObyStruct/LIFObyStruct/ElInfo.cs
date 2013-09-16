using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LIFObyStruct
{
    public struct ElInfo
    {
        public string position;
        public string fio;
        public int age;

        public ElInfo(string position, string fio, int age)
        {
            this.position = position;
            this.fio = fio;
            this.age = age;
        }

        public override string ToString()
        {
            return string.Format("Должность = {0}, ФИО = {1}, Возраст = {2}",
                this.position,this.fio,this.age);
        }
    }
}
