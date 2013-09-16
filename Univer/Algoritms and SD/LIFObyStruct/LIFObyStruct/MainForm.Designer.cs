namespace LIFObyStruct
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelText = new System.Windows.Forms.Label();
            this.listBoxRezult = new System.Windows.Forms.ListBox();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.labelFIO = new System.Windows.Forms.Label();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonShow = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonEmpty = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(423, 41);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Location = new System.Drawing.Point(8, 8);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(181, 13);
            this.labelText.TabIndex = 1;
            this.labelText.Text = "Введите пожалуйста информацию";
            // 
            // listBoxRezult
            // 
            this.listBoxRezult.FormattingEnabled = true;
            this.listBoxRezult.Location = new System.Drawing.Point(12, 85);
            this.listBoxRezult.Name = "listBoxRezult";
            this.listBoxRezult.Size = new System.Drawing.Size(395, 173);
            this.listBoxRezult.TabIndex = 2;
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.Location = new System.Drawing.Point(275, 5);
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.Size = new System.Drawing.Size(132, 20);
            this.textBoxInfo.TabIndex = 3;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(198, 47);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(55, 13);
            this.labelAge.TabIndex = 4;
            this.labelAge.Text = "Возраст :";
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(198, 8);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(71, 13);
            this.labelPosition.TabIndex = 5;
            this.labelPosition.Text = "Должность :";
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Location = new System.Drawing.Point(9, 47);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(40, 13);
            this.labelFIO.TabIndex = 6;
            this.labelFIO.Text = "ФИО :";
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(275, 44);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(132, 20);
            this.textBoxCount.TabIndex = 7;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(55, 44);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(134, 20);
            this.textBoxName.TabIndex = 8;
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(423, 84);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(75, 23);
            this.buttonShow.TabIndex = 9;
            this.buttonShow.Text = "Показать";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(423, 123);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(423, 162);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(75, 23);
            this.buttonFirst.TabIndex = 11;
            this.buttonFirst.Text = "Первый";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonEmpty
            // 
            this.buttonEmpty.Location = new System.Drawing.Point(423, 195);
            this.buttonEmpty.Name = "buttonEmpty";
            this.buttonEmpty.Size = new System.Drawing.Size(75, 23);
            this.buttonEmpty.TabIndex = 12;
            this.buttonEmpty.Text = "Пусто?";
            this.buttonEmpty.UseVisualStyleBackColor = true;
            this.buttonEmpty.Click += new System.EventHandler(this.buttonEmpty_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(423, 234);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 13;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(423, 4);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 14;
            this.buttonCreate.Text = "Создать";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 270);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonEmpty);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.labelFIO);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.textBoxInfo);
            this.Controls.Add(this.listBoxRezult);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.buttonAdd);
            this.Name = "MainForm";
            this.Text = "Стек без барьера, элемент стека-структура (разработал Долуда С.В.)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.ListBox listBoxRezult;
        private System.Windows.Forms.TextBox textBoxInfo;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonEmpty;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonCreate;
    }
}

