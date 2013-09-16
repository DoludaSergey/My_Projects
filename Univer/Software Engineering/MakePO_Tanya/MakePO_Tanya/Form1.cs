using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MakePO_Tanya
{
    public partial class Form1 : Form
    {
        int pos = 0;
        char Op;       //Переменная для хранения знака операции.
        int Y, a, b, c;         //Переменная для хранения целого числа и коэфициэнтов.
        double D, x1, x2;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            string err = "";
            S(str, ref err);
            if (err.Length == 0) 
            {
                D = b * b - 4 * a * c;

                if (D > 0)
                {
                    x1 = (-b + Math.Sqrt(D)) / (2 * a);
                    x2 = (-b - Math.Sqrt(D)) / (2 * a);
                    label4.Text = string.Format("Результат уравнения : x1= {0:F}, x2= {1:F}", x1, x2);
                }
                else
                    if (D == 0)
                    {
                        x1 = (-b ) / (2 * a);
                        label4.Text = string.Format("Результат уравнения : x1= {0:F}, x2= {1:F}", x1);
                    }
                    else label4.Text = string.Format("Дискременант отрицательный, решений нет!");
                
                label2.Text ="Строка введена корректно!"; 
            }
            else { label2.Text = err; }
        }

        private void S(string str, ref string err)
        {
            int pos = 0;

            if (str[pos] == '-')
            {
                pos++;
                Op = '-';
            }
            else Op = '+';

            U(str,ref pos, ref err);

            if (err.Length == 0)
            {
                if (str[pos] == '=')
                {
                    pos++;

                    if (str[pos] == '0')
                    {
                        pos++;
                        if (pos != str.Length) { err = "Результат : Ошибка в позиции " + (pos + 1).ToString() + " , ожидается окончание!"; } 
                    }
                    else
                    {
                        err = "Результат : Ошибка в позиции " + (pos + 1).ToString() + " ,  ожидается '0'!";
                        label2.Text = err;
                    }
                }
                else
                {
                    err = "Результат : Ошибка в позиции " + (pos + 1).ToString() + " , ожидается '='!";
                    label2.Text = err;
                }
            }
        }

        private void U(string str, ref int pos, ref string err)
        {
            if (err.Length == 0)
            {
                K(str, ref pos, ref err);

                if (Op == '+')
                    a = Y;
                else
                    a = -Y;

                if (err.Length == 0)
                {
                    if (str[pos] == 'x')
                    {
                        pos++;

                        if (str[pos] == '^')
                        {
                            pos++;

                            if (str[pos] == 'x')
                            {
                                pos++;

                                Z(str, ref pos, ref err);

                                if (err.Length == 0)
                                {
                                    K(str, ref pos, ref err);

                                    if (Op == '+')
                                        b = Y;
                                    else
                                        b = -Y;

                                    if (err.Length == 0)
                                    {
                                        if (str[pos] == 'x')
                                        {
                                            pos++;
                                            if (err.Length == 0) 
                                            {
                                                Z(str, ref pos, ref err);

                                                if (err.Length == 0)
                                                {
                                                    K(str, ref pos, ref err);

                                                    if (Op == '+')
                                                        c = Y;
                                                    else
                                                        c = -Y;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            err = "Результат : Ошибка в позиции " + (pos + 1).ToString() + " , ожидается 'x'!";
                                            label2.Text = err;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                err = "Результат : Ошибка в позиции " + (pos + 1).ToString() + " , ожидается 'x'!";
                                label2.Text = err;
                            }
                        }
                        else
                        {
                            err = "Результат : Ошибка в позиции " + (pos + 1).ToString() + " , ожидается '^'!";
                            label2.Text = err;
                        }
                    }
                    else
                    {
                        err = "Результат : Ошибка в позиции " + (pos + 1).ToString() + " , ожидается 'x'!";
                        label2.Text = err;
                    }
                }
            }
            
            
        }

        private void Z(string str, ref int pos, ref string err)
        {
            if (err.Length == 0)
            {
                if (str[pos] == '+')
                {
                    pos++;
                    Op = '+';
                }
                else
                    if (str[pos] == '-')
                    {
                        pos++;
                        Op = '-';
                    }
                    else
                    {
                        err = "Результат : Ошибка в позиции " + (pos + 1).ToString() + " , ожидается '+' или '-'!";
                        label2.Text = err;
                    }
            }
        }

        private void K(string str, ref int pos, ref string err)
        {
            int iter = 0;
            Y = 0;//Семантическая процедура Р1.Обнуление целого числа.
            
            do
            {
                iter++;
                
                C(str, ref pos, ref err);
                
                if (err.Length == 0)
                {
                    pos++;
                }
            } while (err.Length == 0);
            if (iter > 1 && err.Length != 0)
            {
                err = "";
            }
        }

        private void C(string str, ref int pos, ref string err)
        {
            //Переменные для хранения считанной цифры и остатка от деления.
            int d, r;

            byte[] bb = Encoding.UTF8.GetBytes(str);
            if (bb[pos] >= 48 && bb[pos] <= 57)
            {
                //Семантическая процедура Р2.Считывание значения целого числа.
                d = int.Parse(str[pos].ToString());

                //Проверка на переполнение.
                if (Y <= Math.DivRem((int.MaxValue - d), 10, out r))
                {
                    Y = 10 * Y + d;
                }
            }
            else
            {
                err = "Результат : Ошибка в позиции " + (pos + 1).ToString() + " , ожидается цифра !";
            }
        }

        public class elem
        {
            public int state;
            public string symbol;
            public int jump;
            public bool error;
            public bool next;

            public elem(int state, string symbol, int jump, bool error, bool next)
            {
                this.state = state;
                this.symbol = symbol;
                this.jump = jump;
                this.error = error;
                this.next = next;

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            elem[] TP = new elem[] {
                new elem(0, "-", 1, false, true),
                new elem(1, "digit", 2, true, true),
                new elem(2, "digit", 2, false, true),
                new elem(3, "any", 4, false, false),
                new elem(4, "x", 5, true, true),
                new elem(5, "^", 6, true, true),
                new elem(6, "x", 7, true, true),
                new elem(7, "+", 9, false, true),
                new elem(8, "-", 9, true, true),
                new elem(9, "digit", 10, true, true),
                new elem(10, "digit", 10, false, true),
                new elem(11, "any", 12, false, false),
                new elem(12, "x", 13, true, true),
                new elem(13, "+", 15, false, true),
                new elem(14, "-", 15, true, true),
                new elem(15, "digit", 16, true, true),
                new elem(16, "digit", 16, false, true),
                new elem(17, "any", 18, false, false),
                new elem(18, "=", 19, true, true),
                new elem(19, "0", 20, true, true),
                new elem(20, "any", 100, false, false)
            };
            string str = textBox1.Text; pos = 0;
            int stat = 0; string err = "";
            do
            {
                int l = TP[stat].symbol.Length;
                bool cond;
                if (l == 1) { string s = str.Substring(pos, 1); cond = TP[stat].symbol == s; }
                else if (l == 5) { byte bb = (byte)str[pos]; cond = (bb > 46 && bb < 58); }
                else cond = true;

                if (cond == true) { if (TP[stat].next == true) { pos++; } stat = TP[stat].jump; }
                else if (TP[stat].error == false) { stat = stat + 1; } else { err = TP[stat].symbol; }

            }
            while (stat != 100 && err.Length == 0);

            string answer;
            if (err.Length == 0) { answer = "Результат: Строка введена корректно!"; }
            else { answer = "Результат: Ошибка в позиции " + (pos + 1).ToString() + " ожидается '" + err + "' "; };
            label3.Text = answer;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
