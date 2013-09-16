using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FIFObyClass
{
    public class ELQ
    {
        public string data;
        public int key;
        public ELQ next;

        public ELQ() : base() { }
        public ELQ(int key, string data)
        {
            this.key = key;
            this.data = data;
        }
        public override string ToString()
        {
            return string.Format(" key={0} data={1}", this.key, this.data);
        }
    }
}
