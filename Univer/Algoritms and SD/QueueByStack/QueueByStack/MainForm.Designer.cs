namespace QueueByStack
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
            this.buttonCreateQS = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.textBoxAddElStName = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonCreateElQ = new System.Windows.Forms.Button();
            this.buttonCreateSt = new System.Windows.Forms.Button();
            this.buttonAddElSt = new System.Windows.Forms.Button();
            this.buttonDelElSt = new System.Windows.Forms.Button();
            this.buttonFirstElSt = new System.Windows.Forms.Button();
            this.buttonFirstElinQ = new System.Windows.Forms.Button();
            this.buttonDelElinQ = new System.Windows.Forms.Button();
            this.buttonAddEltoQ = new System.Windows.Forms.Button();
            this.buttonShoeQ = new System.Windows.Forms.Button();
            this.textBoxAddElStAge = new System.Windows.Forms.TextBox();
            this.textBoxElStInfo = new System.Windows.Forms.TextBox();
            this.textBoxElStKey = new System.Windows.Forms.TextBox();
            this.labelElStName = new System.Windows.Forms.Label();
            this.labelElStAge = new System.Windows.Forms.Label();
            this.labelElQInfo = new System.Windows.Forms.Label();
            this.labelElQKey = new System.Windows.Forms.Label();
            this.buttonShowSt = new System.Windows.Forms.Button();
            this.labelQInfo = new System.Windows.Forms.Label();
            this.labelStInfo = new System.Windows.Forms.Label();
            this.buttonEmptyQ = new System.Windows.Forms.Button();
            this.buttonEmptySt = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCreateQS
            // 
            this.buttonCreateQS.Location = new System.Drawing.Point(430, 8);
            this.buttonCreateQS.Name = "buttonCreateQS";
            this.buttonCreateQS.Size = new System.Drawing.Size(177, 23);
            this.buttonCreateQS.TabIndex = 0;
            this.buttonCreateQS.Text = "Создать контейнер";
            this.buttonCreateQS.UseVisualStyleBackColor = true;
            this.buttonCreateQS.Click += new System.EventHandler(this.buttonCreateQS_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(8, 8);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(330, 13);
            this.labelInfo.TabIndex = 1;
            this.labelInfo.Text = "Для добавления информации заполните соответсвующие поля";
            // 
            // textBoxAddElStName
            // 
            this.textBoxAddElStName.Location = new System.Drawing.Point(105, 74);
            this.textBoxAddElStName.Name = "textBoxAddElStName";
            this.textBoxAddElStName.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddElStName.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(16, 173);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(394, 277);
            this.listBox1.TabIndex = 3;
            // 
            // buttonCreateElQ
            // 
            this.buttonCreateElQ.Location = new System.Drawing.Point(430, 41);
            this.buttonCreateElQ.Name = "buttonCreateElQ";
            this.buttonCreateElQ.Size = new System.Drawing.Size(177, 23);
            this.buttonCreateElQ.TabIndex = 4;
            this.buttonCreateElQ.Text = "Создать элемент списка";
            this.buttonCreateElQ.UseVisualStyleBackColor = true;
            this.buttonCreateElQ.Click += new System.EventHandler(this.buttonCreateElQ_Click);
            // 
            // buttonCreateSt
            // 
            this.buttonCreateSt.Location = new System.Drawing.Point(430, 239);
            this.buttonCreateSt.Name = "buttonCreateSt";
            this.buttonCreateSt.Size = new System.Drawing.Size(177, 23);
            this.buttonCreateSt.TabIndex = 5;
            this.buttonCreateSt.Text = "Создать элемент подсписка";
            this.buttonCreateSt.UseVisualStyleBackColor = true;
            this.buttonCreateSt.Click += new System.EventHandler(this.buttonCreateSt_Click);
            // 
            // buttonAddElSt
            // 
            this.buttonAddElSt.Location = new System.Drawing.Point(430, 272);
            this.buttonAddElSt.Name = "buttonAddElSt";
            this.buttonAddElSt.Size = new System.Drawing.Size(177, 23);
            this.buttonAddElSt.TabIndex = 6;
            this.buttonAddElSt.Text = "Добавить элемент подсписка";
            this.buttonAddElSt.UseVisualStyleBackColor = true;
            this.buttonAddElSt.Click += new System.EventHandler(this.buttonAddElSt_Click);
            // 
            // buttonDelElSt
            // 
            this.buttonDelElSt.Location = new System.Drawing.Point(430, 305);
            this.buttonDelElSt.Name = "buttonDelElSt";
            this.buttonDelElSt.Size = new System.Drawing.Size(177, 23);
            this.buttonDelElSt.TabIndex = 7;
            this.buttonDelElSt.Text = "Удалить элемент подсписка";
            this.buttonDelElSt.UseVisualStyleBackColor = true;
            this.buttonDelElSt.Click += new System.EventHandler(this.buttonDelElSt_Click);
            // 
            // buttonFirstElSt
            // 
            this.buttonFirstElSt.Location = new System.Drawing.Point(430, 371);
            this.buttonFirstElSt.Name = "buttonFirstElSt";
            this.buttonFirstElSt.Size = new System.Drawing.Size(177, 23);
            this.buttonFirstElSt.TabIndex = 8;
            this.buttonFirstElSt.Text = "Первый элемент подсписка";
            this.buttonFirstElSt.UseVisualStyleBackColor = true;
            this.buttonFirstElSt.Click += new System.EventHandler(this.buttonFirstElSt_Click);
            // 
            // buttonFirstElinQ
            // 
            this.buttonFirstElinQ.Location = new System.Drawing.Point(430, 173);
            this.buttonFirstElinQ.Name = "buttonFirstElinQ";
            this.buttonFirstElinQ.Size = new System.Drawing.Size(177, 23);
            this.buttonFirstElinQ.TabIndex = 9;
            this.buttonFirstElinQ.Text = "Первый элемент списка";
            this.buttonFirstElinQ.UseVisualStyleBackColor = true;
            this.buttonFirstElinQ.Click += new System.EventHandler(this.buttonFirstElinQ_Click);
            // 
            // buttonDelElinQ
            // 
            this.buttonDelElinQ.Location = new System.Drawing.Point(430, 107);
            this.buttonDelElinQ.Name = "buttonDelElinQ";
            this.buttonDelElinQ.Size = new System.Drawing.Size(177, 23);
            this.buttonDelElinQ.TabIndex = 10;
            this.buttonDelElinQ.Text = "Удалить элемент списка";
            this.buttonDelElinQ.UseVisualStyleBackColor = true;
            this.buttonDelElinQ.Click += new System.EventHandler(this.buttonDelElinQ_Click);
            // 
            // buttonAddEltoQ
            // 
            this.buttonAddEltoQ.Location = new System.Drawing.Point(430, 74);
            this.buttonAddEltoQ.Name = "buttonAddEltoQ";
            this.buttonAddEltoQ.Size = new System.Drawing.Size(177, 23);
            this.buttonAddEltoQ.TabIndex = 11;
            this.buttonAddEltoQ.Text = "Добавить элемент списка";
            this.buttonAddEltoQ.UseVisualStyleBackColor = true;
            this.buttonAddEltoQ.Click += new System.EventHandler(this.buttonAddEltoQ_Click);
            // 
            // buttonShoeQ
            // 
            this.buttonShoeQ.Location = new System.Drawing.Point(430, 206);
            this.buttonShoeQ.Name = "buttonShoeQ";
            this.buttonShoeQ.Size = new System.Drawing.Size(177, 23);
            this.buttonShoeQ.TabIndex = 12;
            this.buttonShoeQ.Text = "Показать список";
            this.buttonShoeQ.UseVisualStyleBackColor = true;
            this.buttonShoeQ.Click += new System.EventHandler(this.buttonShoeQ_Click);
            // 
            // textBoxAddElStAge
            // 
            this.textBoxAddElStAge.Location = new System.Drawing.Point(310, 74);
            this.textBoxAddElStAge.Name = "textBoxAddElStAge";
            this.textBoxAddElStAge.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddElStAge.TabIndex = 13;
            // 
            // textBoxElStInfo
            // 
            this.textBoxElStInfo.Location = new System.Drawing.Point(105, 137);
            this.textBoxElStInfo.Name = "textBoxElStInfo";
            this.textBoxElStInfo.Size = new System.Drawing.Size(100, 20);
            this.textBoxElStInfo.TabIndex = 14;
            // 
            // textBoxElStKey
            // 
            this.textBoxElStKey.Location = new System.Drawing.Point(310, 137);
            this.textBoxElStKey.Name = "textBoxElStKey";
            this.textBoxElStKey.Size = new System.Drawing.Size(100, 20);
            this.textBoxElStKey.TabIndex = 15;
            // 
            // labelElStName
            // 
            this.labelElStName.AutoSize = true;
            this.labelElStName.Location = new System.Drawing.Point(49, 77);
            this.labelElStName.Name = "labelElStName";
            this.labelElStName.Size = new System.Drawing.Size(35, 13);
            this.labelElStName.TabIndex = 16;
            this.labelElStName.Text = "Name";
            // 
            // labelElStAge
            // 
            this.labelElStAge.AutoSize = true;
            this.labelElStAge.Location = new System.Drawing.Point(254, 77);
            this.labelElStAge.Name = "labelElStAge";
            this.labelElStAge.Size = new System.Drawing.Size(26, 13);
            this.labelElStAge.TabIndex = 17;
            this.labelElStAge.Text = "Age";
            // 
            // labelElQInfo
            // 
            this.labelElQInfo.AutoSize = true;
            this.labelElQInfo.Location = new System.Drawing.Point(49, 140);
            this.labelElQInfo.Name = "labelElQInfo";
            this.labelElQInfo.Size = new System.Drawing.Size(25, 13);
            this.labelElQInfo.TabIndex = 18;
            this.labelElQInfo.Text = "Info";
            // 
            // labelElQKey
            // 
            this.labelElQKey.AutoSize = true;
            this.labelElQKey.Location = new System.Drawing.Point(255, 140);
            this.labelElQKey.Name = "labelElQKey";
            this.labelElQKey.Size = new System.Drawing.Size(25, 13);
            this.labelElQKey.TabIndex = 19;
            this.labelElQKey.Text = "Key";
            // 
            // buttonShowSt
            // 
            this.buttonShowSt.Location = new System.Drawing.Point(430, 404);
            this.buttonShowSt.Name = "buttonShowSt";
            this.buttonShowSt.Size = new System.Drawing.Size(177, 23);
            this.buttonShowSt.TabIndex = 20;
            this.buttonShowSt.Text = "Показать подсписок";
            this.buttonShowSt.UseVisualStyleBackColor = true;
            this.buttonShowSt.Click += new System.EventHandler(this.buttonShowSt_Click);
            // 
            // labelQInfo
            // 
            this.labelQInfo.AutoSize = true;
            this.labelQInfo.Location = new System.Drawing.Point(102, 41);
            this.labelQInfo.Name = "labelQInfo";
            this.labelQInfo.Size = new System.Drawing.Size(210, 13);
            this.labelQInfo.TabIndex = 21;
            this.labelQInfo.Text = "Данные для элемента списка (очереди)";
            // 
            // labelStInfo
            // 
            this.labelStInfo.AutoSize = true;
            this.labelStInfo.Location = new System.Drawing.Point(102, 107);
            this.labelStInfo.Name = "labelStInfo";
            this.labelStInfo.Size = new System.Drawing.Size(216, 13);
            this.labelStInfo.TabIndex = 22;
            this.labelStInfo.Text = "Данные для элемента подсписка (стека)";
            // 
            // buttonEmptyQ
            // 
            this.buttonEmptyQ.Location = new System.Drawing.Point(430, 140);
            this.buttonEmptyQ.Name = "buttonEmptyQ";
            this.buttonEmptyQ.Size = new System.Drawing.Size(177, 23);
            this.buttonEmptyQ.TabIndex = 23;
            this.buttonEmptyQ.Text = "Список (очередь) пуст(а)?";
            this.buttonEmptyQ.UseVisualStyleBackColor = true;
            this.buttonEmptyQ.Click += new System.EventHandler(this.buttonEmptyQ_Click);
            // 
            // buttonEmptySt
            // 
            this.buttonEmptySt.Location = new System.Drawing.Point(430, 338);
            this.buttonEmptySt.Name = "buttonEmptySt";
            this.buttonEmptySt.Size = new System.Drawing.Size(177, 23);
            this.buttonEmptySt.TabIndex = 24;
            this.buttonEmptySt.Text = "Подсписок (стек) пуст?";
            this.buttonEmptySt.UseVisualStyleBackColor = true;
            this.buttonEmptySt.Click += new System.EventHandler(this.buttonEmptySt_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(430, 433);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(177, 23);
            this.buttonExit.TabIndex = 25;
            this.buttonExit.Text = "Выйти!";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 466);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonEmptySt);
            this.Controls.Add(this.buttonEmptyQ);
            this.Controls.Add(this.labelStInfo);
            this.Controls.Add(this.labelQInfo);
            this.Controls.Add(this.buttonShowSt);
            this.Controls.Add(this.labelElQKey);
            this.Controls.Add(this.labelElQInfo);
            this.Controls.Add(this.labelElStAge);
            this.Controls.Add(this.labelElStName);
            this.Controls.Add(this.textBoxElStKey);
            this.Controls.Add(this.textBoxElStInfo);
            this.Controls.Add(this.textBoxAddElStAge);
            this.Controls.Add(this.buttonShoeQ);
            this.Controls.Add(this.buttonAddEltoQ);
            this.Controls.Add(this.buttonDelElinQ);
            this.Controls.Add(this.buttonFirstElinQ);
            this.Controls.Add(this.buttonFirstElSt);
            this.Controls.Add(this.buttonDelElSt);
            this.Controls.Add(this.buttonAddElSt);
            this.Controls.Add(this.buttonCreateSt);
            this.Controls.Add(this.buttonCreateElQ);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBoxAddElStName);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.buttonCreateQS);
            this.Name = "MainForm";
            this.Text = "Контейнер списка (очереди) подсписков (стеков) (Copyright by Doluda S.V.)";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateQS;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.TextBox textBoxAddElStName;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonCreateElQ;
        private System.Windows.Forms.Button buttonCreateSt;
        private System.Windows.Forms.Button buttonAddElSt;
        private System.Windows.Forms.Button buttonDelElSt;
        private System.Windows.Forms.Button buttonFirstElSt;
        private System.Windows.Forms.Button buttonFirstElinQ;
        private System.Windows.Forms.Button buttonDelElinQ;
        private System.Windows.Forms.Button buttonAddEltoQ;
        private System.Windows.Forms.Button buttonShoeQ;
        private System.Windows.Forms.TextBox textBoxAddElStAge;
        private System.Windows.Forms.TextBox textBoxElStInfo;
        private System.Windows.Forms.TextBox textBoxElStKey;
        private System.Windows.Forms.Label labelElStName;
        private System.Windows.Forms.Label labelElStAge;
        private System.Windows.Forms.Label labelElQInfo;
        private System.Windows.Forms.Label labelElQKey;
        private System.Windows.Forms.Button buttonShowSt;
        private System.Windows.Forms.Label labelQInfo;
        private System.Windows.Forms.Label labelStInfo;
        private System.Windows.Forms.Button buttonEmptyQ;
        private System.Windows.Forms.Button buttonEmptySt;
        private System.Windows.Forms.Button buttonExit;
    }
}

