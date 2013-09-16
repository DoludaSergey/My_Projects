using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TransportnayZadachaByWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            MyWorkingClass myWorkingClass = new MyWorkingClass();
            
            myWorkingClass.PrintMatrix(this.myDGV);
            myWorkingClass.DoIt(this.myLB);
            
        }              
    }
}
