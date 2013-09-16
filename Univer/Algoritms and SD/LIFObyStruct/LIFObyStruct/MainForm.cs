using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LIFObyStruct
{
    public partial class MainForm : Form
    {
        public MySt mySt;

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            CreateSt();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddEl();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DelEl();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            ShowS();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            First();
        }

        private void buttonEmpty_Click(object sender, EventArgs e)
        {
            Empty();
        }

        private void CreateSt()
        {
            if (mySt == null)
            {
                mySt = new MySt();

                this.listBoxRezult.Items.Clear();
                this.listBoxRezult.Items.Add("Экземпляр стека успешно создан!!!");
            }
        }

        private void AddEl()
        {
            if (IsSteck())
            {

                int count;

                if (int.TryParse(this.textBoxCount.Text, out count))
                {

                    mySt.AddElSt(this.textBoxInfo.Text, this.textBoxName.Text, count);

                    this.textBoxName.Text = "";
                    this.textBoxInfo.Text = "";
                    this.textBoxCount.Text = "";

                    this.listBoxRezult.Items.Add("Элемент успешно добавлен в стек!!!");
                }
                else
                {
                    this.listBoxRezult.Items.Clear();
                    this.listBoxRezult.Items.Add("Ошибка ввода!!!");
                    this.listBoxRezult.Items.Add("В поле возраст надо вводить цифры!!!");
                }
            }
        }

        private void DelEl()
        {
            if (this.mySt.EmptySt())
                this.listBoxRezult.Items.Add("В стеке нет элементов!!!");
            else
            {
                this.mySt.DeleteElSt();

                this.listBoxRezult.Items.Add("Элемент успешно удален из стека!!!");
            }
        }

        private void ShowS()
        {
            if (IsSteck())
                this.mySt.ShowSt(this.listBoxRezult);
        }

        private void Empty()
        {
            if (IsSteck())
            {
                this.listBoxRezult.Items.Clear();

                if (this.mySt.EmptySt())
                    this.listBoxRezult.Items.Add("В стеке нет элементов!!!");
                else this.listBoxRezult.Items.Add("В стеке содержаться элементы!!!");
            }
        }

        private void First()
        {
            if (IsSteck())
            {
                this.listBoxRezult.Items.Clear();

                string firstEl = this.mySt.FirstElSt();

                if (firstEl == "")
                    this.listBoxRezult.Items.Add("В стеке нет элементов!!!");
                else
                {
                    this.listBoxRezult.Items.Add("Первый элемент в стеке следующий :");
                    this.listBoxRezult.Items.Add(firstEl);
                }
            }
        }

        private bool IsSteck()
        {
            if (mySt == null)
            {
                this.listBoxRezult.Items.Clear();
                this.listBoxRezult.Items.Add("Стек еще не создан!!!Нажмите кнопку Создать");
                return false;
            }
            return true;
        }
    }
}
