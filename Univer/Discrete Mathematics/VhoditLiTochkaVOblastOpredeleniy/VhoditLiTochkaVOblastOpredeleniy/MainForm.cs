using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VhoditLiTochkaVOblastOpredeleniy
{
    public partial class MainForm : Form
    {
        public double X { get; set; }//Х координата
        public double Y { get; set; }//Y координата

        public MainForm()
        {
            InitializeComponent();
        }

        //обработчик клика по кнопке
        private void buttonTest_Click(object sender, EventArgs e)
        {
            DoIt();
        }

        /// <summary>
        /// Рабочий метод
        /// </summary>
        private void DoIt()
        {
            try
            {
                //если текстовые поля координат непусты
                if ((this.textBoxX.Text != string.Empty) && (this.textBoxY.Text != string.Empty))
                {
                    //присваиваем Х и Y значения текстовых полей
                    this.X = double.Parse(this.textBoxX.Text);
                    this.Y = double.Parse(this.textBoxY.Text);

                    //если выполняются условия предикатов
                    if ((S1() || S2() || S3() || S4()) &&
                        !(S5() && S6()) || (S5() && S6()) &&
                        !(S1() || S2() || S3() || S4()))
                        //выводим положительный ответ
                        MessageBox.Show("Данная точка входит в заданную область!", "Мои поздравления!");
                    else
                        //иначе,отрицательный ответ
                        MessageBox.Show("Данная точка не входит в заданную область!", "Печалька!");
                }
                //иначе, сообщение об ошибке
                else MessageBox.Show("Введите координаты точки!", "Внимание!");
            }
            catch (Exception e1) { MessageBox.Show("Ошибка ввода!", "Внимание!"); }
        }

        //отдельные предикаты
        private bool S1()
        {
            return (X * X + Y * Y - 2 * Y <= 0);
        }

        private bool S2()
        {
            return (X * X + Y * Y + 2 * Y <= 0);
        }

        private bool S3()
        {
            return (X * X + Y * Y - 2 * X <= 0);
        }

        private bool S4()
        {
            return (X * X + Y * Y + 2 * X <= 0);
        }

        private bool S5()
        {
            return (Y >= X-1);
        }

        private bool S6()
        {
            return (Y <= X+1);
        }

    }
}
