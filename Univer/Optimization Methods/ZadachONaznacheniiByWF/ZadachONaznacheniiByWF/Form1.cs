using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ZadachONaznacheniiByWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            MyWorkClass myWorkClass = new MyWorkClass();

            myWorkClass.PrintMatrix(this.myDGW);
            myWorkClass.DoIt(this.myLB);
        }
    }
}
