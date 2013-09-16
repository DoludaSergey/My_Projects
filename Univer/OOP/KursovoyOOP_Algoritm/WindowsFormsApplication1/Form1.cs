using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyLibraryOfCollection;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        IMyCollection<MyDataOfEntity> MyCollection;

        public Form1()
        {
            InitializeComponent();

            comboBox1.SelectedItem = comboBox1.Items[0];
        }

        /// <summary>
        /// Обработчик клика по кнопке "Создать экземпляр колекции"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                MyCollection = new MyStack<MyDataOfEntity>();
            if (radioButton2.Checked)
                MyCollection = new MyQueue<MyDataOfEntity>();
            if (radioButton3.Checked)
                MyCollection = new MyList<MyDataOfEntity>();
            if (radioButton4.Checked)
                MyCollection = new MyDictionary<MyDataOfEntity>();

            textBox3.Text = "Создан новый экземпляр коллекции типа "+MyCollection.GetType();
            panel1.Enabled = MyCollection!=null;
        }

        /// <summary>
        /// Обработчик клика по кнопке "Добавить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty && textBox2.Text !=string.Empty)
            {
                //Заполняем данные в элемент данных
                var infoEntity = new MyDataOfEntity(
                        textBox2.Text.ToString() == string.Empty ? "Иванов" : textBox2.Text,
                        textBox4.Text.ToString() == string.Empty ? "Иван" : textBox4.Text,
                        textBox5.Text.ToString() == string.Empty ? "93ПЗ1" : textBox5.Text,
                        textBox7.Text.ToString() == string.Empty ? 3 : int.Parse(textBox7.Text),
                        textBox6.Text.ToString() == string.Empty ? "Программное обеспечение" : textBox6.Text,
                        comboBox1.SelectedItem.ToString() == string.Empty ? "Очная" : comboBox1.SelectedItem.ToString(),
                        textBox8.Text.ToString() == string.Empty ? "Не назначено" : textBox8.Text
                        );
                
                //
                var allInfo = new MyEntity<MyDataOfEntity>(
                    int.Parse(textBox1.Text), infoEntity);

                MyCollection.Add(allInfo);

                textBox3.Text += Environment.NewLine + "Создан новый элемент списка с ключем - " +
                    textBox1.Text + " и данными - " + infoEntity;
            }
            else
                textBox3.Text += Environment.NewLine + "Необходимо заполнить поля Id и Фамилия!!!";
            
            //Очистка текстовых полей
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;
            textBox7.Text = string.Empty;
            textBox8.Text = string.Empty;
        }

        /// <summary>
        /// Обработчик клика по кнопке "Найти"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                var res = MyCollection.FindByKey(int.Parse(textBox1.Text));
                textBox3.Text += Environment.NewLine + "Поиск по ключу: " + textBox1.Text +
                    (res == null ? " По этому запросу ничего не найденно!!" : " Данные - " + res.ToString());
            }else
                textBox3.Text += Environment.NewLine + "Необходимо заполнить поле ключа для поиска элемента!!!";
            textBox1.Text = string.Empty;
        }

        /// <summary>
        /// Обработчик клика по кнопке "Удаить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            var res = MyCollection.GetAndDel();
            textBox3.Text += Environment.NewLine + "Удаление первого элемента!!" + 
                (res == null ? "В коллекции нечего удалять!!!" : " Ключ - "+res.Key + " Данные - " + res.Data);

        }

        /// <summary>
        /// Обработчик кика по кнопке "Размер"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            if (MyCollection.GetSize()==0)
            {
                textBox3.Text += Environment.NewLine + "Коллекция пуста и не содержит данных!!!";
            }
            else textBox3.Text += Environment.NewLine + "Текущий размер коллекции : " + MyCollection.GetSize();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
