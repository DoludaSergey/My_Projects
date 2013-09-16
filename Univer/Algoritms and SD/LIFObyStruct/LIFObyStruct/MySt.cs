using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LIFObyStruct
{
    public class MySt
    {
        public ElSt head;

        public MySt()
        {

        }

        public void AddElSt(string info, string name, int count)
        {
            ElSt elemStack = new ElSt(info, name, count);

            if (this.head == null)
            {
                elemStack.next = elemStack;
                elemStack.prev = elemStack;
            }
            else
                if (this.head.next == this.head)
                {
                    elemStack.next = this.head;
                    elemStack.prev = this.head;
                    this.head.next = elemStack;
                    this.head.prev = elemStack;
                }
                else
                {
                    elemStack.next = this.head;
                    elemStack.prev = this.head.prev;
                    this.head.prev.next = elemStack;
                    this.head.prev = elemStack;
                }
            this.head = elemStack;

        }

        public void DeleteElSt()
        {
            if (this.head == null)
                return;
            else if (this.head.next == this.head)
                this.head = null;
            else
            {
                this.head.next.prev = this.head.prev;
                this.head.prev.next = this.head.next;
                this.head = this.head.next;
            }
        }

        public string FirstElSt()
        {
            if (this.head == null)
                return "";
            else return this.head.ToString();
        }

        public bool EmptySt()
        {
            return (this.head == null);
        }

        public void ShowSt(ListBox lb)
        {
            lb.Items.Clear();

            if (this.head == null)
            {
                lb.Items.Add("Стек пуст!!!");
                return;
            }
            lb.Items.Add("Стек содержит следующие элементы :");

            ElSt elSt = this.head;

            while (elSt.next != this.head)
            {
                lb.Items.Add(elSt.ToString());
                elSt = elSt.next;
            }
            lb.Items.Add(elSt.ToString());
        }
    }
}
