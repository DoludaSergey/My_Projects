using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Laba7_OS_Registry
{
    public partial class Form1 : Form
    {
        string subName;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Создание подраздела в системном реестре
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (this.tbCreateSub.Text!="")//Если текстовое поле заполнено
            {
                subName = this.tbCreateSub.Text.Trim();
                //Считываем имя подраздела из текстового поля

                try
                {
                    RegistryKey key = Registry.CurrentUser.OpenSubKey("Software", true);
                    // Открыли папку , true означает - хотим ли мы записывать в этот раздел 
                    // реестра ?
                    RegistryKey wKey = key.CreateSubKey("RegistryTesting");
                    //Создали новую папку в реестре
                    RegistryKey nKey = wKey.CreateSubKey(subName);
                    //Создали новую папку в реестре

                    MessageBox.Show("Создание подраздела прошло успешно!!!", "Инфо.", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.panel1.Enabled = true;
                }
                catch (System.Exception err)
                {
                    MessageBox.Show("Произошла ошибка при создании подраздела : " + err.Message);
                }
            }
            else MessageBox.Show("Необходимо заполнить текстовые поля!!!", "Внимание.", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            

        }

        /// <summary>
        /// Ввод параметров в раздел
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnterValue_Click(object sender, EventArgs e)
        {
            //Если поля заполненны
            if (this.tbEnterName.Text!="" && this.tbEnterValue.Text!="")
            {
                //считываем значения имени и значения
                string name = this.tbEnterName.Text.Trim();
                string value = this.tbEnterValue.Text.Trim();

                if (subName != "")//Если задан путь к разделу
                {
                    try
                    {
                        RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\RegistryTesting\\" + subName, true);
                        // Открыли папку , true означает - хотим ли мы записывать в этот раздел реестра ?

                        //Заносим значения в реестр
                        key.SetValue(name, value);

                        MessageBox.Show("Сохранение значений прошло успешно!!!", "Сохранение.", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                    catch (System.Exception err)
                    {
                        MessageBox.Show("Произошла ошибка при сохранении параметров : " + err.Message);
                    }
                }
            }
            else MessageBox.Show("Необходимо заполнить текстовые поля!!!", "Внимание.", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            
        }

        /// <summary>
        /// Редактирование параметров в разделе реестра
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            //Если поля заполненны
            if (this.tbEditName.Text != "" && this.tbEditValue.Text != "")
            {
                //считываем значения имени и значения
                string name = this.tbEditName.Text.Trim();
                string value = this.tbEditValue.Text.Trim();

                if (subName != "")
                {
                    try
                    {
                        RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\RegistryTesting\\" + subName, true);
                        // Открыли папку , true означает - хотим ли мы записывать в этот раздел реестра ?

                        //Проверка на существование параметра по имени
                        System.Object myKey = key.GetValue(name, true);

                        if (myKey is bool)//если такого не найдено
                        {
                            MessageBox.Show("Значений с таким именем не найденно!!!", "Редактирование.", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else//если такой параметр есть
                        {
                            //Перезаписываем значения
                            key.SetValue(name, value);
                            MessageBox.Show("Изменение значений прошло успешно!!!", "Редактирование.", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (System.Exception err)
                    {
                        MessageBox.Show("Произошла ошибка при сохранении параметров : " + err.Message);
                    }
                }
            }
            else MessageBox.Show("Необходимо заполнить текстовые поля!!!", "Внимание.", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Удаление параметра
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Если поля заполненны
            if (this.tbDelete.Text != "")
            {
                //считываем значения имени
                string name = this.tbDelete.Text.Trim();

                if (subName != "")
                {
                    try
                    {

                        RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\RegistryTesting\\" + subName, true);
                         //Открыли папку , true означает - хотим ли мы записывать в этот раздел реестра ? 

                        //Проверка на существование параметра по имени
                        System.Object myKey = key.GetValue(name, true);

                        if (myKey is bool)
                        {
                            MessageBox.Show(
                                "Значение с таким именем не найденно!!!", "Удаление.", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            key.DeleteValue(name);
                            MessageBox.Show(
                                "Удаление значения прошло успешно!!!", "Удаление.", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (System.Exception err)
                    {
                        MessageBox.Show("Произошла ошибка при удалении параметров : " + err.Message);
                    }
                }
            }
            else MessageBox.Show("Необходимо заполнить текстовые поля!!!", "Внимание.", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Обработчик события при закрытии формы
        /// Запрашиваем у ползователя,сохранять ли изменения в реестре
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Сохранить изменения в реестре?","Сохранение.",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.No)
            {
                try
                {
                    RegistryKey key = Registry.CurrentUser.OpenSubKey("Software", true);
                    key.DeleteSubKeyTree("RegistryTesting");

                    MessageBox.Show(
                        "Все изменения в реестре были удалены!!!", "Сохранение.", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (System.Exception err)
                {
                    MessageBox.Show("Произошла ошибка при удалении подраздела : " + err.Message);
                }
                
            }
            else MessageBox.Show(
                "Все изменения в реестре сохранены!!!","Сохранение.",
                MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
