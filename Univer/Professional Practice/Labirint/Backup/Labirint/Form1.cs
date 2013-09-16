using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Labirint
{
    public partial class Form1 : Form
    {
        const int Length = 56;
        PathFinger pf = new PathFinger();

        public Form1()
        {
            InitializeComponent();

            pf.CopyMapToFielld();
        }

        #region buttonShowLabirint_Click
        /// <summary>
        /// Вывод на экран лабиринта по нажатию на кнопку Показать лабиринт
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowLabirint_Click(object sender, EventArgs e)
        {
            pf.SetStartAndFinish();//устанавливаем координаты финиша и старта
            ShowLabirint();//Выводим на экран лабиринт
            buttonShowPath.Visible = true;//Делаем видимой кнопку Показать путь
            buttonShowLabirint.Visible = false;//а кнопку Показать лабиринт -невидимой
            buttonSetStart.Visible =buttonSetFinish.Visible = true;
        }

        #region ShowLabirint
        /// <summary>
        /// Вывод на экран лабиринта
        /// </summary>
        private void ShowLabirint()
        {
            
            int[,] map = pf.Filld;//копируем карту лабиринта

            dataGridViewLabirint.ColumnCount = 0;//удаляем все колонки
            dataGridViewLabirint.ColumnCount = Length;//создаем колонки в количестве Length
            dataGridViewLabirint.Rows.Add(Length);//добавляем строки в количестве Length

            for (int i = 0; i < Length; i++)
            {
                dataGridViewLabirint.Columns[i].ReadOnly = true;
                //устанавливаем колонки в режим только чтение
                dataGridViewLabirint.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                //отменяем возможность сортировки колонок
                dataGridViewLabirint.Columns[i].Width = 13;
                //устанавливаем ширину колонок
                dataGridViewLabirint.Rows[i].Height  = 13;


            }
            for (int i = 0; i < Length; i++)
                for (int j = 0; j < Length; j++)
                {
                    if (map[i, j] == -3) dataGridViewLabirint.Rows[i].Cells[j].Style.BackColor = Color.Black;
                        //устанавливаем черный цвет для стен
                    else if (map[i, j] == 0) dataGridViewLabirint.Rows[i].Cells[j].Style.BackColor = Color.Green;
                        //зеленый цвет для старта
                    else if (map[i, j] == -5 || map[i, j] == -1) dataGridViewLabirint.Rows[i].Cells[j].Style.BackColor = Color.Red;
                        //красный-для финиша и маршрута
                    else dataGridViewLabirint.Rows[i].Cells[j].Style.BackColor = Color.Aquamarine;
                        //ультрамарин- для коридора
                }
            dataGridViewLabirint.Visible = true;
            //делаем таблицу видимой

        }
        #endregion
        #endregion

        #region buttonShowPath_Click
        /// <summary>
        /// Отображение минимального маршрута
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowPath_Click(object sender, EventArgs e)
        {
            dataGridViewLabirint.Visible = false;
            //временно делаем таблицу невидимой

            pf.FindPath();//поиск возможных маршрутов
            pf.MinPath();//поиск минимального маршрута

            ShowLabirint();//вывод лабиринта
            buttonShowPath.Visible = false;//кнопку Показать путь делаем невидимой
            buttonExit.Visible = true;//а кнопку Выход -видимой
        }
        #endregion

        #region buttonSetStart_Click
        /// <summary>
        /// Реакция на кнопку Установить старт
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetStart_Click(object sender, EventArgs e)
        {
            pf.CopyMapToFielld();//копируем лабиринт в поле для обработки

            //запоминаем координаты старта
            int  y =dataGridViewLabirint.CurrentCell.RowIndex ;
            int  x = dataGridViewLabirint.CurrentCell.ColumnIndex ;

            //если это стена-выводим сообщение
            if (!pf.SetStart (y, x)) MessageBox.Show("Не получилось установить старт!Возможно там стена");

            buttonShowLabirint.Visible = true;//делаем видимой кнопку Показать лабиринт
        }
        #endregion

        #region buttonSetFinish_Click
        private void buttonSetFinish_Click(object sender, EventArgs e)
        {
            pf.CopyMapToFielld();//копируем лабиринт в поле для обработки

            //запоминаем координаты финиша
            int y = dataGridViewLabirint.CurrentCell.RowIndex;
            int x = dataGridViewLabirint.CurrentCell.ColumnIndex;

            //если это стена-выводим сообщение
            if (!pf.SetFinish (y, x)) MessageBox.Show("Не получилось установить старт!Возможно там стена");

            buttonShowLabirint.Visible = true;//делаем видимой кнопку Показать лабиринт
        }
        #endregion
        
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();//выход из приложения
        }
    }
}
