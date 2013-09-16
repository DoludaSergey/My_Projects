using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace PhoneCompany
{
    public partial class MainForm : Form
    {
        TCallDetailRecord Caller;//объявления объекта
        public int count=0;//счетчик звонков
        static string err = "";//поле для отчета об ошике
        static string rec = "";//поле для отчета о подходящем звонке
        bool runCalling = false;//переменная для запуска и остановы работы телефонной компании
        static object locker = new object();//заглушка для потока



        public MainForm()
        {
            Caller = new TCallDetailRecord();//создание экземпляра телефонного звонка
            InitializeComponent();//инициализация главной формы

            //создаем файл для отчета об отобранных звонках
            FileInfo f = new FileInfo("CallerID.log");
            FileStream fs=  f.Create();
            fs.Close();
        }

        //обработчик события кнопки менню старт
        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.startToolStripMenuItem.Enabled = false;//делаем недоступной кнопку старта
            this.stopToolStripMenuItem.Enabled = true;//а кнопку остановы - доступной
            runCalling = true;//значение признака работы ставим в положение работы

            while (runCalling)//запускаем рабочий цикл 
            {
                Thread tr1 = new Thread(ExecuteCalls);//создаем новый поток
                tr1.IsBackground = true;//делаем его фоновым
                tr1.Start();//запускаем процесс
                tr1.Join();//ждать окончания работы потока

                Application.DoEvents();//обрабатываем сообщения виндовс
                this.lb_Calls.Items.Add(rec);//Выводим запись на экран
                this.grbx_GeneratedCalls.Refresh();//обновляем отрисовку группбокса

                Thread tr2 = new Thread(ExecuteFile);//создаем новый поток
                tr2.IsBackground = true;//делаем его фоновым
                tr2.Start();//запускаем процесс
                tr2.Join();//ждать окончания работы потока

                if (rec != "")//если строка с отчетом не пустая,
                {
                    this.lb_HandledCalls.Items.Add(rec);//выводим подходящую запись на экран
                    this.count++;
                    this.grbx_HandledCalls.Refresh();//обновляем отрисовку группбокса
                }


                if (err != "")//если строка с отчетом об ошибке не пустая,
                {
                    this.lb_ErrorLog.Items.Add(err);//выводим подходящую запись на экран
                    this.grbx_ErrorLog.Refresh();//обновляем отрисовку группбокса
                }
                Thread.Sleep(100);//задержка на 1 секунду
            }
            
        }

        private void ExecuteCalls()
        {
            lock (locker)//защита от синхронного доступа к переменным
            {
                //Application.DoEvents();
                TCAllThread.Execute(Caller);//вызываем процесс формирования звонка
                rec = TCAllThread.rec;//заполняем поле отчета о звонке
                Thread.Sleep(100);//задержка на 1 секунду
            }
        }

        private void ExecuteFile()
        {
            lock (locker)//защита от синхронного доступа к переменным
            {
                Thread.Sleep(100);//задержка на 1 секунду
                TFileThread.Execute(Caller);//вызываем обработку звонка
                rec = TFileThread.rec;//заполняем поле отчета о подходящем звонке
                err = TFileThread.erStr;//заполняем поле отчета о неподходящем звонке
            }
        }

        //обработка события нажатия на кнопку выход
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            runCalling = false;//переводим признак работы в состояние стоп
            this.Dispose();
        }

        //обработка события нажатия на кнопку about
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Example of MultiThreading \nDeveloped by Doluda Sergey");
        }

        //обработка события нажатия на кнопку остановы
        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.startToolStripMenuItem.Enabled = true;//делаем доступной кнопку старта
            this.stopToolStripMenuItem.Enabled = false;//а кнопку остановы - недоступной
            runCalling = false;//переводим признак работы в состояние стоп
            
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            runCalling = false;//переводим признак работы в состояние стоп
            
        }

        private void отчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("Общее количество звонков в Минск составляет {0}", this.count));
        }
    }
}
