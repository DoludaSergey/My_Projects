using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;

namespace QueueByStack
{
    public class QS
    {
        public Queue<ElQ> qs;
        //public Stack CurentSt;
        public ElQ elemQ;

        public QS()
        {
            //this.elemQ = new ElQ();
            //this.qs = new Queue<ElQ>();
            //this.elemQ.St = new Stack();
        }

        public void CreateQS()
        {
            if (this.qs == null)
            {
                this.qs = new Queue<ElQ>();
                MessageBox.Show("Контейнер типа очередь стеков успешно создан!!!");
            }
            else MessageBox.Show("Экземпляр контейнера очереди стеков уже существует!!!", 
                "Будьте внимательнее!!!");
        }

        public void CreateElQ(string name,int age)
        {
            if (this.elemQ == null)
            {
                this.elemQ = new ElQ(name,age);
                //this.qs.Enqueue(this.elemQ);
                MessageBox.Show("Экземпляр элемента списка (очереди) успешно создан!!!");
            }
            else MessageBox.Show("Экземпляр элемента очереди уже существует!!!",
                "Будьте внимательнее!!!");
        }
        public void CreateStForElQ()
        {
            if (this.elemQ == null)
                MessageBox.Show("Сначало необходимо создать элемент списка (очереди)!!!", 
                    "Элемент списка (очереди) еще не создан!!!");
            else
            if (this.elemQ.St == null)
            {
                this.elemQ.CreateSt();
                MessageBox.Show("Экземпляр подсписка (стека) успешно создан!!!","Метод CreateStForElQ() в QS");
            }
            else MessageBox.Show("Экземпляр подсписка (стека) уже существует!!!","Метод CreateStForElQ() в QS");
        }

        public void AddElStForElQ(int key, string info)
        {
            if (this.elemQ == null)
                MessageBox.Show("Сначало необходимо создать элемент списка (очереди) или взять его из очереди!!!", 
                    "Элемент списка (очереди) еще не создан!!!");
            else
                if (this.elemQ.St != null)
                {
                    this.elemQ.AddElSt(key, info);
                    MessageBox.Show("Элемент подсписка (стека) успешно добавлен в текущий список (стек)!!!");
                }
                else MessageBox.Show(
                    "Сначало необходимо создать элемент подсписка (стека) или взять его из очереди!!!",
                    "Элемента подсписка (стека) еще не существует!!!");
        }

        public void AddElQToQS()
        {
            if (this.qs != null)
            {
                if (this.elemQ == null)
                    MessageBox.Show("Сначало необходимо создать элемент списка (очереди) или взять его из очереди!!!", 
                        "Элемент списка (очереди) пуст или еще не создан!!!");
                else
                    if ( this.elemQ.St!=null && this.elemQ.St.Count > 0)
                    {
                        this.qs.Enqueue(this.elemQ);
                        this.elemQ = null;
                        MessageBox.Show("Элемент очереди стеков успешно добавлен в контейнер!!!");
                    }
                    else MessageBox.Show("Добавление в контейнер не произошло!!!",
                        "Подсписок (стек) пуст или еще не создан!!!");
            }
            else MessageBox.Show("Необходимо сначало создать контейнер для данных!!!",
                "Контейнер еще не создан!!!");
        }

        public void DeleteElStFromElQ()
        {
            if (this.elemQ != null)
            {
                if (this.elemQ.St != null && this.elemQ.St.Count > 0)
                {
                    this.elemQ.St.Pop();
                    MessageBox.Show("Элемент подсписка (стека) успешно удален!!!");
                }
                else MessageBox.Show("Удалять нечего!!!", "Подсписок (стек) пуст!!!");
            }
            else
                MessageBox.Show("Сначало необходимо создать елемент подсписка (стека)!!!",
                    "Подсписок (стек) пуст!!!");            
        }

        public void DeleteElQFromQS()
        {
            if (this.qs!=null && this.qs.Count > 0)
            {
                this.qs.Dequeue();
                MessageBox.Show("Элемент списка (очереди) успешно удален из контейнера!!!");
            }
            else MessageBox.Show("Удалять нечего!!!", "Контейнер пуст!!!");
        }

        public void FirstElStInElQ()
        {
            if (this.elemQ!=null && this.elemQ.St.Count > 0)
            {
                //ElSt elemSt = (ElSt)this.elemQ.St.Peek();
                MessageBox.Show(string.Format("Первый элемент в текущем стеке {0}!!!", 
                    this.elemQ.St.Peek().ToString()));
            }
            else 
                MessageBox.Show("Сначало необходимо создать элемент подсписка (стека)!!", 
                "Подсписок (стек) пуст!!!");
        }

        public void EmptySt()
        {
            if (this.elemQ != null)
                this.elemQ.EmptySt();
            else
                MessageBox.Show("Сначало необходимо создать элемент подсписка (стека)!!",
                "Подсписок (стек) пуст!!!");
        }

        public void FirstElQInQS(ListBox lb)
        {
            if (this.qs!=null && this.qs.Count > 0)
            {
                lb.Items.Clear();
                lb.Items.Add("Первый элемент в контейнере");
                this.elemQ = this.qs.Peek();
                this.elemQ.ShowElQ(lb);
            }
            else MessageBox.Show("Список (очередь) не содержит элементов!!!",
                "Контейнер пуст!!!");
        }

        public void EmptyQ()
        {
            if (this.qs != null && this.qs.Count > 0)
            {
                MessageBox.Show("Список (очередь) содержит элементы!!!",
                "Контейнер не пуст!!!");
            }
            else MessageBox.Show("Список (очередь) не содержит элементов!!!",
                "Контейнер пуст!!!");
        }

        public void ShowQ(ListBox lb)
        {
            if (this.qs != null)
            {
                lb.Items.Clear();
                lb.Items.Add("Содержимое контейнера (списка (очереди) подсписков (стеков))");
                
                if (this.qs.Count > 0)
                {
                    int count = 0;
                    foreach (ElQ items in this.qs)
                    {
                        count++;
                        lb.Items.Add("----------------------------------------------------------------------------------------------");
                        lb.Items.Add(string.Format("Содержимое {0} го элемента списка (очереди) :", count));
                        items.ShowElQ(lb);
                    }
                    this.elemQ = null;
                }
                else
                    lb.Items.Add("Контейнер пуст!!!");
            }
            else MessageBox.Show("Список (очередь) не содержит элементов!!!", 
                "Контейнер пуст!!!");
        }

        public void ShowSt(ListBox lb)
        {
            if (this.elemQ != null)
                this.elemQ.ShowElQ(lb);
            else
                MessageBox.Show("Сначало необходимо создать елемент подсписка (стека)!!!",
                    "Подсписок (стек) пуст!!!");
        }
    }
}
