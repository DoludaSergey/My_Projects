using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Laba6_OS_Threading
{
    public partial class Form1 : Form
    {
        public delegate void AddListItem1(string s);
        public delegate void AddListItem2(int ind,int progr);
        
        public AddListItem1 myDelegate1;
        public AddListItem2 myDelegate2;
        
        private Thread myThread1;
        private Thread myThread2;
        
        public Form1()
        {
            InitializeComponent();
            
        }

        /// <summary>
        /// Обработчик клика по кнопке Начать
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDoIt_Click(object sender, EventArgs e)
        {
            //назначаем делегаты
            myDelegate1 = new AddListItem1(PrintText);
            myDelegate2 = new AddListItem2(ShowProgresBar);
            //создаем новые потоки
            myThread1 = new Thread(new ThreadStart(ThreadFunction1));
            myThread2 = new Thread(new ThreadStart(ThreadFunction2));
            //назначаем их фоновыми
            myThread1.IsBackground = true;
            myThread2.IsBackground = true;
            //запускаем 1 й поток
            myThread1.Start();
            //приостанавливаем работу на 0,5 секунды
            Thread.Sleep(500);
            //запускаем 2 й поток
            myThread2.Start();            
        }

        /// <summary>
        /// Вывод текста
        /// </summary>
        /// <param name="s">текст</param>
        public void PrintText(string s)
        {
            listBox1.Items.Add(s);
        }

        /// <summary>
        /// Отображение значения линейного индикатора
        /// </summary>
        /// <param name="index">индекс указателя</param>
        /// <param name="progres">значение прогресса</param>
        public void ShowProgresBar(int index,int progres)
        {
            if (index==0)//Вывод в 1й индикатор
            {
                this.progressBar1.Value = progres;
                progressBar1.Update();
            }
            if (index == 1)//Вывод во 2й индикатор
            {
                this.progressBar2.Value = progres;
                progressBar2.Update();
            }
        }

        /// <summary>
        /// Создает новый экземпляр класса MyThreadClass и вызывает метод Run
        /// </summary>
        private void ThreadFunction1()
        {
            MyThreadClass myThreadClassObject1 = new MyThreadClass(this);
            myThreadClassObject1.Run(0);
        }
        /// <summary>
        /// Аналогично преидущему,только с другим индексом
        /// </summary>
        private void ThreadFunction2()
        {
            MyThreadClass myThreadClassObject1 = new MyThreadClass(this);
            myThreadClassObject1.Run(1);
        }
    }
    
    /// <summary>
    /// Класс с рабочим методом Run
    /// </summary>
    public class MyThreadClass
    {
        Form1 myFormControl1;
        public MyThreadClass(Form1 myForm)
        {
            myFormControl1 = myForm;
        }

        public void Run(int index)
        {            
            float sum = 0;
            Random r = new Random();
            int n = r.Next(50);

            //Вызов делегата в основном потоке для вывода информации
            myFormControl1.Invoke(myFormControl1.myDelegate1, (
                string.Format("Начат процесс вычислений функции №{0}!!! Вычисляется сумма {1} элементов массива!!!",index+1, n)));
            
            for (int i = 0; i < n; i++)
            {
                sum += r.Next(20);//подсчет суммы

                //выводим данные о выполнении процесса в линейный индикатор
                myFormControl1.Invoke(myFormControl1.myDelegate2, index, (int)((i / (float)n) * 100));

                Thread.Yield();
                //приостанавливаем процесс
                Thread.Sleep(500);
                Application.DoEvents();//обрабатываем сообщения виновс
            }
            myFormControl1.Invoke(myFormControl1.myDelegate2, index, 100);
            
            myFormControl1.Invoke(myFormControl1.myDelegate1, 
                string.Format("Выполнение процесса №{0} завершено!!! Сумма равна {1}",index+1 ,sum));
            
        }
    }

}
