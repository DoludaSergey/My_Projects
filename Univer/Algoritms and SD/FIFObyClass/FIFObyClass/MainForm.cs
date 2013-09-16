using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FIFObyClass
{
    public partial class MainForm : Form
    {
        MyQueue Q;

        public MainForm()
        {
            InitializeComponent();

            Q = new MyQueue();
        }

        private void buttonShowList_Click(object sender, EventArgs e)
        {
            Q.ShowMyQ(ref this.listBox1);
        }

        private void buttonAddNode_Click(object sender, EventArgs e)
        {
            int key;
            int.TryParse(this.textBoxKey.Text,out key);

            Q.AddElQ(this.textBoxData.Text, key);
            
            this.textBoxKey.Text = string.Empty;
            this.textBoxData.Text = string.Empty;
        }

        private void buttonDeleteList_Click(object sender, EventArgs e)
        {
            Q.DeleteElQ();
            Q.ShowMyQ(ref this.listBox1);
        }

        private void buttonFirstNode_Click(object sender, EventArgs e)
        {
            string s = Q.FirstElQ();

            if (s == "")
                MessageBox.Show("Можете занимать)", "В очереди никого нет!!!");
            else
                MessageBox.Show(s,"Первый в очереди:");
        }

        private void buttonEmpty_Click(object sender, EventArgs e)
        {
            if (Q.Empty())
                MessageBox.Show("Можете занимать)", "В очереди никого нет!!!");
            else
                MessageBox.Show("Становитесь за мной)", "Тут есть очередь!!!");
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
