using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;

namespace QueueByStack
{
    public class ElQ
    {
        public Info data;
        public Stack St;

        public ElQ() : base() { this.St = new Stack(); }
        public ElQ(string name, int age)
        {
            this.data = new Info(name, age);
        }

        public void CreateSt()
        {
            if (this.St == null)
            {
                this.St = new Stack();
                MessageBox.Show("Новый элемент подсписка (стек) создан успешно!!!",
                    "Работает метод CreateSt() в ElQ");
            }
        }

        public void AddElSt(int key, string info)
        {
            if (this.St != null)
            {
                ElSt elemSt = new ElSt(key, info);
                this.St.Push(elemSt);
                MessageBox.Show("Элемент подсписка (стека) успешно добавлен!!!",
                    "Работает метод AddElSt() в ElQ");
            }
            else
                MessageBox.Show("Сначало создайте объект стека!!!",
                    "Работает метод AddElSt() в ElQ");
        }

        public void DeleteElSt()
        {
            if (this.St.Count > 0)
            {
                this.St.Pop();
                MessageBox.Show("Элемент подсписка (стека) успешно удален!!!",
                    "Работает метод DeleteElSt() в ElQ");
            }
            else
                MessageBox.Show("Стек пуст!!!Удалять нечего!!!",
                    "Работает метод DeleteElSt() в ElQ");
        }

        public void FirstElSt()
        {
            if (this.St.Count > 0)
            {
                ElSt elemSt = (ElSt)this.St.Peek();
                MessageBox.Show(string.Format("Первый элемент в стеке - {0}",elemSt.ToString()),
                    "Работает метод FirstElSt() в ElQ");
            }
            else
                MessageBox.Show("Стек пуст!!!",
                    "Работает метод FirstElSt() в ElQ");
        }

        public void EmptySt()
        {
            if(this.St.Count>0)
                MessageBox.Show("Стек содержит элементы!!!",
                    "Работает метод EmptySt() в ElQ");
            else MessageBox.Show("Стек пуст!!!",
                "Работает метод EmptySt() в ElQ");
        }

        public void ShowElQ(ListBox lb)
        {
            lb.Items.Add(string.Format("{0}",this.data));
            lb.Items.Add("Содержит следующую информацию подсписка (стека) :");

            if ((this.St!=null)&&(this.St.Count > 0))
            {
                foreach(ElSt item in this.St)
                    lb.Items.Add(string.Format("\t{0}",item));
                lb.Items.Add("----------------------------------------------------------------------------------------------");
            }
            else lb.Items.Add("Стек пуст!!!");
        }
    }
}
