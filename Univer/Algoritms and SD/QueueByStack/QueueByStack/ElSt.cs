using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QueueByStack
{
    public class ElSt
    {
        public int key;
        public string info;

        public ElSt():base(){}
        public ElSt(int key, string info)
        {
            this.key = key;
            this.info = info;
        }

        public override string ToString()
        {
            return string.Format("Key = {0}, info = {1}",this.key,this.info);
        }

    }
}
