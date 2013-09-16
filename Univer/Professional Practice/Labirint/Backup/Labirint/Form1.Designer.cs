namespace Labirint
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonShowLabirint = new System.Windows.Forms.Button();
            this.dataGridViewLabirint = new System.Windows.Forms.DataGridView();
            this.buttonShowPath = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonSetStart = new System.Windows.Forms.Button();
            this.buttonSetFinish = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLabirint)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonShowLabirint
            // 
            this.buttonShowLabirint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonShowLabirint.Location = new System.Drawing.Point(793, 46);
            this.buttonShowLabirint.Name = "buttonShowLabirint";
            this.buttonShowLabirint.Size = new System.Drawing.Size(125, 27);
            this.buttonShowLabirint.TabIndex = 1;
            this.buttonShowLabirint.Text = "Показать лабиринт";
            this.buttonShowLabirint.UseVisualStyleBackColor = true;
            this.buttonShowLabirint.Click += new System.EventHandler(this.buttonShowLabirint_Click);
            // 
            // dataGridViewLabirint
            // 
            this.dataGridViewLabirint.AllowUserToAddRows = false;
            this.dataGridViewLabirint.AllowUserToDeleteRows = false;
            this.dataGridViewLabirint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewLabirint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLabirint.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewLabirint.Name = "dataGridViewLabirint";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 3.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewLabirint.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewLabirint.Size = new System.Drawing.Size(775, 752);
            this.dataGridViewLabirint.TabIndex = 2;
            this.dataGridViewLabirint.Visible = false;
            // 
            // buttonShowPath
            // 
            this.buttonShowPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonShowPath.Location = new System.Drawing.Point(793, 101);
            this.buttonShowPath.Name = "buttonShowPath";
            this.buttonShowPath.Size = new System.Drawing.Size(125, 27);
            this.buttonShowPath.TabIndex = 3;
            this.buttonShowPath.Text = "Показать путь";
            this.buttonShowPath.UseVisualStyleBackColor = true;
            this.buttonShowPath.Visible = false;
            this.buttonShowPath.Click += new System.EventHandler(this.buttonShowPath_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.Location = new System.Drawing.Point(793, 356);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(124, 27);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Visible = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonSetStart
            // 
            this.buttonSetStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSetStart.Location = new System.Drawing.Point(793, 159);
            this.buttonSetStart.Name = "buttonSetStart";
            this.buttonSetStart.Size = new System.Drawing.Size(124, 27);
            this.buttonSetStart.TabIndex = 5;
            this.buttonSetStart.Text = "Установить старт";
            this.buttonSetStart.UseVisualStyleBackColor = true;
            this.buttonSetStart.Visible = false;
            this.buttonSetStart.Click += new System.EventHandler(this.buttonSetStart_Click);
            // 
            // buttonSetFinish
            // 
            this.buttonSetFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSetFinish.Location = new System.Drawing.Point(794, 212);
            this.buttonSetFinish.Name = "buttonSetFinish";
            this.buttonSetFinish.Size = new System.Drawing.Size(124, 27);
            this.buttonSetFinish.TabIndex = 6;
            this.buttonSetFinish.Text = "Установить финиш";
            this.buttonSetFinish.UseVisualStyleBackColor = true;
            this.buttonSetFinish.Visible = false;
            this.buttonSetFinish.Click += new System.EventHandler(this.buttonSetFinish_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 776);
            this.Controls.Add(this.buttonSetFinish);
            this.Controls.Add(this.buttonSetStart);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonShowPath);
            this.Controls.Add(this.dataGridViewLabirint);
            this.Controls.Add(this.buttonShowLabirint);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLabirint)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonShowLabirint;
        private System.Windows.Forms.DataGridView dataGridViewLabirint;
        private System.Windows.Forms.Button buttonShowPath;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSetStart;
        private System.Windows.Forms.Button buttonSetFinish;
    }
}

