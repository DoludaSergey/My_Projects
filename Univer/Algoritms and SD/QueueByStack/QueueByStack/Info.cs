using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QueueByStack
{
    public struct Info
    {
        public string name;
        public int age;

        public Info(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            return string.Format("Name = {0}, age = {1}",this.name,this.age);
        }
    }
}
