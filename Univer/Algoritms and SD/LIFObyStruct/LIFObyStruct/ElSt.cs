using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LIFObyStruct
{
    public class ElSt
    {
        public ElSt next;
        public ElSt prev;
        public ElInfo info;

        public ElSt() : base() { }
        public ElSt(string info, string name, int count)
        {
            this.info = new ElInfo(info, name, count);
        }

        public override string ToString()
        {
            return this.info.ToString();
        }
    }
}
