using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyDLL;

namespace MyWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnPrintText1_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Add( MyMethodsClass.PrintText1());
        }

        private void BtnPrintText2_Click(object sender, EventArgs e)
        {
            this.listBox2.Items.Add(MyMethodsClass.PrintText2());
        }
    }
}
