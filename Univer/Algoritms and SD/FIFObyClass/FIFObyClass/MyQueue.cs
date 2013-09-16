using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FIFObyClass
{
    public class MyQueue
    {
        public ELQ Head, Finish;

        public MyQueue()
        {
            this.Head = null;
            this.Finish = new ELQ();
        }

        public void AddElQ(string d,int k)
        {
            this.Finish.data = d;
            this.Finish.key = k;

            ELQ p = new ELQ();

            this.Finish.next = p;

            if (this.Head == null)
            {
                this.Head = Finish;
            }
            this.Finish = p;
        }

        public void DeleteElQ()
        {
            if (this.Head == null)
                return;
            else
            {
                ELQ p = this.Head;
                this.Head = p.next;
            }
        }

        public string FirstElQ()
        {
            if (this.Head == null || this.Head == this.Finish) return "";
            else return(this.Head.ToString());
        }

        public bool Empty()
        {
            if (this.Head == null || this.Head == this.Finish)
                return true;
            else return false;
        }

        public void ShowMyQ(ref ListBox lb)
        {
            lb.Items.Clear();

            if (this.Head == null)
                lb.Items.Add("Увы!Пустая очередь!!!");
            else
            {
                ELQ p = this.Head;

                lb.Items.Add("В очереди следующие элементы :");
                while (p != null)
                {
                    if (p == this.Finish) break;
                    lb.Items.Add(p.ToString());
                    p = p.next;
                }
            }
        }
    }
}
