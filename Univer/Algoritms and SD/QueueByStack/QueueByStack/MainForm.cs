using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QueueByStack
{
    public partial class MainForm : Form
    {
        QS myqs;

        public MainForm()
        {
            InitializeComponent();
            myqs = new QS();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonCreateQS_Click(object sender, EventArgs e)
        {
            this.myqs.CreateQS();
        }

        private void buttonCreateElQ_Click(object sender, EventArgs e)
        {
            if (this.textBoxAddElStAge.Text != "" && this.textBoxAddElStName.Text != "")
            {
                int age;
                int.TryParse(this.textBoxAddElStAge.Text, out age);

                this.myqs.CreateElQ(this.textBoxAddElStName.Text, age);

                this.textBoxAddElStName.Text = "";
                this.textBoxAddElStAge.Text = "";
            }
            else MessageBox.Show("Необходимо заполнить поля Name и Age!!!", 
                "Будьте внимательнее!!!");
        }

        private void buttonCreateSt_Click(object sender, EventArgs e)
        {
            this.myqs.CreateStForElQ();
        }

        private void buttonAddElSt_Click(object sender, EventArgs e)
        {
            if (this.myqs.elemQ != null)
            {
                if (this.textBoxElStInfo.Text != "" && this.textBoxElStKey.Text != "")
                {
                    int key;
                    int.TryParse(this.textBoxElStKey.Text, out key);

                    this.myqs.AddElStForElQ(key, this.textBoxElStInfo.Text);
                    //MessageBox.Show("Элемент подсписка (стека) успешно добавлен!!!");
                    this.textBoxElStInfo.Text = "";
                    this.textBoxElStKey.Text = "";
                }
                else MessageBox.Show("Необходимо заполнить поля Key и Info!!!",
                    "Будьте внимательнее!!!");
            }
            else MessageBox.Show("Сначало необходимо создать элемент подсписка (стека)!!!",
                "Элемент подсписка (стека) еще не создан!!!");
        }

        private void buttonAddEltoQ_Click(object sender, EventArgs e)
        {
             this.myqs.AddElQToQS();
        }

        private void buttonShoeQ_Click(object sender, EventArgs e)
        {
            this.myqs.ShowQ(this.listBox1);
        }

        private void buttonShowSt_Click(object sender, EventArgs e)
        {
            this.myqs.ShowSt(this.listBox1);
        }

        private void buttonDelElinQ_Click(object sender, EventArgs e)
        {
            this.myqs.DeleteElQFromQS();
        }

        private void buttonDelElSt_Click(object sender, EventArgs e)
        {
            this.myqs.DeleteElStFromElQ();
        }

        private void buttonFirstElinQ_Click(object sender, EventArgs e)
        {
            this.myqs.FirstElQInQS(this.listBox1);
        }

        private void buttonFirstElSt_Click(object sender, EventArgs e)
        {
            this.myqs.FirstElStInElQ();
        }

        private void buttonEmptyQ_Click(object sender, EventArgs e)
        {
            this.myqs.EmptyQ();
        }

        private void buttonEmptySt_Click(object sender, EventArgs e)
        {
            this.myqs.EmptySt();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
