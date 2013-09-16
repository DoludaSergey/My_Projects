namespace ShopsWorkersProducts
{
    partial class MainForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnFIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNShop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNPoduktA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNPoduktB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNPoduktС = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxAddProduktC = new System.Windows.Forms.TextBox();
            this.labelAddProduktC = new System.Windows.Forms.Label();
            this.textBoxAddProduktB = new System.Windows.Forms.TextBox();
            this.labelAddProduktB = new System.Windows.Forms.Label();
            this.textBoxAddProduktA = new System.Windows.Forms.TextBox();
            this.labelAddProduktA = new System.Windows.Forms.Label();
            this.textBoxAddNShop = new System.Windows.Forms.TextBox();
            this.labelAddNShop = new System.Windows.Forms.Label();
            this.textBoxAddFIO = new System.Windows.Forms.TextBox();
            this.buttonAddWorkersProduktInfo = new System.Windows.Forms.Button();
            this.labelAddFIO = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBoxEditProduktC = new System.Windows.Forms.TextBox();
            this.labelEditNProduktC = new System.Windows.Forms.Label();
            this.textBoxEditProduktB = new System.Windows.Forms.TextBox();
            this.labelEditNProduktB = new System.Windows.Forms.Label();
            this.textBoxEditNProduktA = new System.Windows.Forms.TextBox();
            this.labelEditNProduktA = new System.Windows.Forms.Label();
            this.textBoxEditNShop = new System.Windows.Forms.TextBox();
            this.labelEditNShop = new System.Windows.Forms.Label();
            this.textBoxEditFIO = new System.Windows.Forms.TextBox();
            this.buttonEditWorkersProduktsInfo = new System.Windows.Forms.Button();
            this.labelEditFIO = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.textBoxDeleteNProduktC = new System.Windows.Forms.TextBox();
            this.labelDeleteNProduktC = new System.Windows.Forms.Label();
            this.textBoxDeleteNProduktB = new System.Windows.Forms.TextBox();
            this.labelDeleteNProduktB = new System.Windows.Forms.Label();
            this.textBoxDeleteNProduktA = new System.Windows.Forms.TextBox();
            this.labelDeleteNProduktA = new System.Windows.Forms.Label();
            this.textBoxDeleteNShop = new System.Windows.Forms.TextBox();
            this.labelDeleteNShop = new System.Windows.Forms.Label();
            this.textBoxDeleteFIO = new System.Windows.Forms.TextBox();
            this.buttonDeleteWorkersProduktsInfo = new System.Windows.Forms.Button();
            this.labelDeleteFIO = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonFind = new System.Windows.Forms.Button();
            this.labelRezult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnFIO,
            this.ColumnNShop,
            this.ColumnNPoduktA,
            this.ColumnNPoduktB,
            this.ColumnNPoduktС});
            this.dataGridView1.Location = new System.Drawing.Point(12, 292);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(656, 199);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // ColumnFIO
            // 
            this.ColumnFIO.HeaderText = "Фамилия  рабочего цеха";
            this.ColumnFIO.Name = "ColumnFIO";
            // 
            // ColumnNShop
            // 
            this.ColumnNShop.HeaderText = "Наименование цеха";
            this.ColumnNShop.Name = "ColumnNShop";
            // 
            // ColumnNPoduktA
            // 
            this.ColumnNPoduktA.HeaderText = "Количество изделия А";
            this.ColumnNPoduktA.Name = "ColumnNPoduktA";
            // 
            // ColumnNPoduktB
            // 
            this.ColumnNPoduktB.HeaderText = "Количество изделия B";
            this.ColumnNPoduktB.Name = "ColumnNPoduktB";
            // 
            // ColumnNPoduktС
            // 
            this.ColumnNPoduktС.HeaderText = "Количество изделия С";
            this.ColumnNPoduktС.Name = "ColumnNPoduktС";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(656, 256);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelRezult);
            this.tabPage1.Controls.Add(this.buttonFind);
            this.tabPage1.Controls.Add(this.labelInfo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(648, 230);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Инфо";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBoxAddProduktC);
            this.tabPage2.Controls.Add(this.labelAddProduktC);
            this.tabPage2.Controls.Add(this.textBoxAddProduktB);
            this.tabPage2.Controls.Add(this.labelAddProduktB);
            this.tabPage2.Controls.Add(this.textBoxAddProduktA);
            this.tabPage2.Controls.Add(this.labelAddProduktA);
            this.tabPage2.Controls.Add(this.textBoxAddNShop);
            this.tabPage2.Controls.Add(this.labelAddNShop);
            this.tabPage2.Controls.Add(this.textBoxAddFIO);
            this.tabPage2.Controls.Add(this.buttonAddWorkersProduktInfo);
            this.tabPage2.Controls.Add(this.labelAddFIO);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(648, 230);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Добавить";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBoxAddProduktC
            // 
            this.textBoxAddProduktC.Location = new System.Drawing.Point(278, 128);
            this.textBoxAddProduktC.Name = "textBoxAddProduktC";
            this.textBoxAddProduktC.Size = new System.Drawing.Size(346, 20);
            this.textBoxAddProduktC.TabIndex = 22;
            // 
            // labelAddProduktC
            // 
            this.labelAddProduktC.AutoSize = true;
            this.labelAddProduktC.Location = new System.Drawing.Point(24, 128);
            this.labelAddProduktC.Name = "labelAddProduktC";
            this.labelAddProduktC.Size = new System.Drawing.Size(121, 13);
            this.labelAddProduktC.TabIndex = 21;
            this.labelAddProduktC.Text = "Количество изделия C";
            // 
            // textBoxAddProduktB
            // 
            this.textBoxAddProduktB.Location = new System.Drawing.Point(278, 102);
            this.textBoxAddProduktB.Name = "textBoxAddProduktB";
            this.textBoxAddProduktB.Size = new System.Drawing.Size(346, 20);
            this.textBoxAddProduktB.TabIndex = 20;
            // 
            // labelAddProduktB
            // 
            this.labelAddProduktB.AutoSize = true;
            this.labelAddProduktB.Location = new System.Drawing.Point(24, 102);
            this.labelAddProduktB.Name = "labelAddProduktB";
            this.labelAddProduktB.Size = new System.Drawing.Size(121, 13);
            this.labelAddProduktB.TabIndex = 19;
            this.labelAddProduktB.Text = "Количество изделия B";
            // 
            // textBoxAddProduktA
            // 
            this.textBoxAddProduktA.Location = new System.Drawing.Point(278, 76);
            this.textBoxAddProduktA.Name = "textBoxAddProduktA";
            this.textBoxAddProduktA.Size = new System.Drawing.Size(346, 20);
            this.textBoxAddProduktA.TabIndex = 18;
            // 
            // labelAddProduktA
            // 
            this.labelAddProduktA.AutoSize = true;
            this.labelAddProduktA.Location = new System.Drawing.Point(24, 76);
            this.labelAddProduktA.Name = "labelAddProduktA";
            this.labelAddProduktA.Size = new System.Drawing.Size(121, 13);
            this.labelAddProduktA.TabIndex = 17;
            this.labelAddProduktA.Text = "Количество изделия А";
            // 
            // textBoxAddNShop
            // 
            this.textBoxAddNShop.Location = new System.Drawing.Point(278, 50);
            this.textBoxAddNShop.Name = "textBoxAddNShop";
            this.textBoxAddNShop.Size = new System.Drawing.Size(346, 20);
            this.textBoxAddNShop.TabIndex = 16;
            // 
            // labelAddNShop
            // 
            this.labelAddNShop.AutoSize = true;
            this.labelAddNShop.Location = new System.Drawing.Point(24, 50);
            this.labelAddNShop.Name = "labelAddNShop";
            this.labelAddNShop.Size = new System.Drawing.Size(109, 13);
            this.labelAddNShop.TabIndex = 15;
            this.labelAddNShop.Text = "Наименование цеха";
            // 
            // textBoxAddFIO
            // 
            this.textBoxAddFIO.Location = new System.Drawing.Point(278, 24);
            this.textBoxAddFIO.Name = "textBoxAddFIO";
            this.textBoxAddFIO.Size = new System.Drawing.Size(346, 20);
            this.textBoxAddFIO.TabIndex = 14;
            // 
            // buttonAddWorkersProduktInfo
            // 
            this.buttonAddWorkersProduktInfo.Location = new System.Drawing.Point(404, 181);
            this.buttonAddWorkersProduktInfo.Name = "buttonAddWorkersProduktInfo";
            this.buttonAddWorkersProduktInfo.Size = new System.Drawing.Size(75, 23);
            this.buttonAddWorkersProduktInfo.TabIndex = 12;
            this.buttonAddWorkersProduktInfo.Text = "Добавить";
            this.buttonAddWorkersProduktInfo.UseVisualStyleBackColor = true;
            this.buttonAddWorkersProduktInfo.Click += new System.EventHandler(this.buttonAddWorkersProduktInfo_Click);
            // 
            // labelAddFIO
            // 
            this.labelAddFIO.AutoSize = true;
            this.labelAddFIO.Location = new System.Drawing.Point(24, 24);
            this.labelAddFIO.Name = "labelAddFIO";
            this.labelAddFIO.Size = new System.Drawing.Size(180, 13);
            this.labelAddFIO.TabIndex = 13;
            this.labelAddFIO.Text = "Фамилия Имя Отчество рабочего";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBoxEditProduktC);
            this.tabPage3.Controls.Add(this.labelEditNProduktC);
            this.tabPage3.Controls.Add(this.textBoxEditProduktB);
            this.tabPage3.Controls.Add(this.labelEditNProduktB);
            this.tabPage3.Controls.Add(this.textBoxEditNProduktA);
            this.tabPage3.Controls.Add(this.labelEditNProduktA);
            this.tabPage3.Controls.Add(this.textBoxEditNShop);
            this.tabPage3.Controls.Add(this.labelEditNShop);
            this.tabPage3.Controls.Add(this.textBoxEditFIO);
            this.tabPage3.Controls.Add(this.buttonEditWorkersProduktsInfo);
            this.tabPage3.Controls.Add(this.labelEditFIO);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(648, 230);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Редактировать";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBoxEditProduktC
            // 
            this.textBoxEditProduktC.Location = new System.Drawing.Point(278, 128);
            this.textBoxEditProduktC.Name = "textBoxEditProduktC";
            this.textBoxEditProduktC.Size = new System.Drawing.Size(346, 20);
            this.textBoxEditProduktC.TabIndex = 22;
            // 
            // labelEditNProduktC
            // 
            this.labelEditNProduktC.AutoSize = true;
            this.labelEditNProduktC.Location = new System.Drawing.Point(24, 128);
            this.labelEditNProduktC.Name = "labelEditNProduktC";
            this.labelEditNProduktC.Size = new System.Drawing.Size(200, 13);
            this.labelEditNProduktC.TabIndex = 21;
            this.labelEditNProduktC.Text = "Редактировать количество изделия C";
            // 
            // textBoxEditProduktB
            // 
            this.textBoxEditProduktB.Location = new System.Drawing.Point(278, 102);
            this.textBoxEditProduktB.Name = "textBoxEditProduktB";
            this.textBoxEditProduktB.Size = new System.Drawing.Size(346, 20);
            this.textBoxEditProduktB.TabIndex = 20;
            // 
            // labelEditNProduktB
            // 
            this.labelEditNProduktB.AutoSize = true;
            this.labelEditNProduktB.Location = new System.Drawing.Point(24, 102);
            this.labelEditNProduktB.Name = "labelEditNProduktB";
            this.labelEditNProduktB.Size = new System.Drawing.Size(200, 13);
            this.labelEditNProduktB.TabIndex = 19;
            this.labelEditNProduktB.Text = "Редактировать количество изделия B";
            // 
            // textBoxEditNProduktA
            // 
            this.textBoxEditNProduktA.Location = new System.Drawing.Point(278, 76);
            this.textBoxEditNProduktA.Name = "textBoxEditNProduktA";
            this.textBoxEditNProduktA.Size = new System.Drawing.Size(346, 20);
            this.textBoxEditNProduktA.TabIndex = 18;
            // 
            // labelEditNProduktA
            // 
            this.labelEditNProduktA.AutoSize = true;
            this.labelEditNProduktA.Location = new System.Drawing.Point(24, 76);
            this.labelEditNProduktA.Name = "labelEditNProduktA";
            this.labelEditNProduktA.Size = new System.Drawing.Size(200, 13);
            this.labelEditNProduktA.TabIndex = 17;
            this.labelEditNProduktA.Text = "Редактировать количество изделия A";
            // 
            // textBoxEditNShop
            // 
            this.textBoxEditNShop.Location = new System.Drawing.Point(278, 50);
            this.textBoxEditNShop.Name = "textBoxEditNShop";
            this.textBoxEditNShop.Size = new System.Drawing.Size(346, 20);
            this.textBoxEditNShop.TabIndex = 16;
            // 
            // labelEditNShop
            // 
            this.labelEditNShop.AutoSize = true;
            this.labelEditNShop.Location = new System.Drawing.Point(24, 50);
            this.labelEditNShop.Name = "labelEditNShop";
            this.labelEditNShop.Size = new System.Drawing.Size(187, 13);
            this.labelEditNShop.TabIndex = 15;
            this.labelEditNShop.Text = "Редактировать наименование цеха";
            // 
            // textBoxEditFIO
            // 
            this.textBoxEditFIO.Location = new System.Drawing.Point(278, 24);
            this.textBoxEditFIO.Name = "textBoxEditFIO";
            this.textBoxEditFIO.Size = new System.Drawing.Size(346, 20);
            this.textBoxEditFIO.TabIndex = 14;
            // 
            // buttonEditWorkersProduktsInfo
            // 
            this.buttonEditWorkersProduktsInfo.Location = new System.Drawing.Point(408, 175);
            this.buttonEditWorkersProduktsInfo.Name = "buttonEditWorkersProduktsInfo";
            this.buttonEditWorkersProduktsInfo.Size = new System.Drawing.Size(115, 23);
            this.buttonEditWorkersProduktsInfo.TabIndex = 12;
            this.buttonEditWorkersProduktsInfo.Text = "Редактировать";
            this.buttonEditWorkersProduktsInfo.UseVisualStyleBackColor = true;
            this.buttonEditWorkersProduktsInfo.Click += new System.EventHandler(this.buttonEditWorkersProduktsInfo_Click);
            // 
            // labelEditFIO
            // 
            this.labelEditFIO.AutoSize = true;
            this.labelEditFIO.Location = new System.Drawing.Point(24, 24);
            this.labelEditFIO.Name = "labelEditFIO";
            this.labelEditFIO.Size = new System.Drawing.Size(187, 13);
            this.labelEditFIO.TabIndex = 13;
            this.labelEditFIO.Text = "Редактировать Фамилию рабочего";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.textBoxDeleteNProduktC);
            this.tabPage4.Controls.Add(this.labelDeleteNProduktC);
            this.tabPage4.Controls.Add(this.textBoxDeleteNProduktB);
            this.tabPage4.Controls.Add(this.labelDeleteNProduktB);
            this.tabPage4.Controls.Add(this.textBoxDeleteNProduktA);
            this.tabPage4.Controls.Add(this.labelDeleteNProduktA);
            this.tabPage4.Controls.Add(this.textBoxDeleteNShop);
            this.tabPage4.Controls.Add(this.labelDeleteNShop);
            this.tabPage4.Controls.Add(this.textBoxDeleteFIO);
            this.tabPage4.Controls.Add(this.buttonDeleteWorkersProduktsInfo);
            this.tabPage4.Controls.Add(this.labelDeleteFIO);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(648, 230);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Удалить";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // textBoxDeleteNProduktC
            // 
            this.textBoxDeleteNProduktC.Location = new System.Drawing.Point(278, 128);
            this.textBoxDeleteNProduktC.Name = "textBoxDeleteNProduktC";
            this.textBoxDeleteNProduktC.Size = new System.Drawing.Size(346, 20);
            this.textBoxDeleteNProduktC.TabIndex = 22;
            // 
            // labelDeleteNProduktC
            // 
            this.labelDeleteNProduktC.AutoSize = true;
            this.labelDeleteNProduktC.Location = new System.Drawing.Point(24, 128);
            this.labelDeleteNProduktC.Name = "labelDeleteNProduktC";
            this.labelDeleteNProduktC.Size = new System.Drawing.Size(192, 13);
            this.labelDeleteNProduktC.TabIndex = 21;
            this.labelDeleteNProduktC.Text = "Количество изделия C для удаления";
            // 
            // textBoxDeleteNProduktB
            // 
            this.textBoxDeleteNProduktB.Location = new System.Drawing.Point(278, 102);
            this.textBoxDeleteNProduktB.Name = "textBoxDeleteNProduktB";
            this.textBoxDeleteNProduktB.Size = new System.Drawing.Size(346, 20);
            this.textBoxDeleteNProduktB.TabIndex = 20;
            // 
            // labelDeleteNProduktB
            // 
            this.labelDeleteNProduktB.AutoSize = true;
            this.labelDeleteNProduktB.Location = new System.Drawing.Point(24, 102);
            this.labelDeleteNProduktB.Name = "labelDeleteNProduktB";
            this.labelDeleteNProduktB.Size = new System.Drawing.Size(192, 13);
            this.labelDeleteNProduktB.TabIndex = 19;
            this.labelDeleteNProduktB.Text = "Количество изделия B для удаления";
            // 
            // textBoxDeleteNProduktA
            // 
            this.textBoxDeleteNProduktA.Location = new System.Drawing.Point(278, 76);
            this.textBoxDeleteNProduktA.Name = "textBoxDeleteNProduktA";
            this.textBoxDeleteNProduktA.Size = new System.Drawing.Size(346, 20);
            this.textBoxDeleteNProduktA.TabIndex = 18;
            // 
            // labelDeleteNProduktA
            // 
            this.labelDeleteNProduktA.AutoSize = true;
            this.labelDeleteNProduktA.Location = new System.Drawing.Point(24, 76);
            this.labelDeleteNProduktA.Name = "labelDeleteNProduktA";
            this.labelDeleteNProduktA.Size = new System.Drawing.Size(192, 13);
            this.labelDeleteNProduktA.TabIndex = 17;
            this.labelDeleteNProduktA.Text = "Количество изделия A для удаления";
            // 
            // textBoxDeleteNShop
            // 
            this.textBoxDeleteNShop.Location = new System.Drawing.Point(278, 50);
            this.textBoxDeleteNShop.Name = "textBoxDeleteNShop";
            this.textBoxDeleteNShop.Size = new System.Drawing.Size(346, 20);
            this.textBoxDeleteNShop.TabIndex = 16;
            // 
            // labelDeleteNShop
            // 
            this.labelDeleteNShop.AutoSize = true;
            this.labelDeleteNShop.Location = new System.Drawing.Point(24, 50);
            this.labelDeleteNShop.Name = "labelDeleteNShop";
            this.labelDeleteNShop.Size = new System.Drawing.Size(180, 13);
            this.labelDeleteNShop.TabIndex = 15;
            this.labelDeleteNShop.Text = "Наименование цеха для удаления";
            // 
            // textBoxDeleteFIO
            // 
            this.textBoxDeleteFIO.Location = new System.Drawing.Point(278, 24);
            this.textBoxDeleteFIO.Name = "textBoxDeleteFIO";
            this.textBoxDeleteFIO.Size = new System.Drawing.Size(346, 20);
            this.textBoxDeleteFIO.TabIndex = 14;
            // 
            // buttonDeleteWorkersProduktsInfo
            // 
            this.buttonDeleteWorkersProduktsInfo.Location = new System.Drawing.Point(401, 179);
            this.buttonDeleteWorkersProduktsInfo.Name = "buttonDeleteWorkersProduktsInfo";
            this.buttonDeleteWorkersProduktsInfo.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteWorkersProduktsInfo.TabIndex = 12;
            this.buttonDeleteWorkersProduktsInfo.Text = "Удалить";
            this.buttonDeleteWorkersProduktsInfo.UseVisualStyleBackColor = true;
            this.buttonDeleteWorkersProduktsInfo.Click += new System.EventHandler(this.buttonDeleteWorkersProduktsInfo_Click);
            // 
            // labelDeleteFIO
            // 
            this.labelDeleteFIO.AutoSize = true;
            this.labelDeleteFIO.Location = new System.Drawing.Point(24, 24);
            this.labelDeleteFIO.Name = "labelDeleteFIO";
            this.labelDeleteFIO.Size = new System.Drawing.Size(176, 13);
            this.labelDeleteFIO.TabIndex = 13;
            this.labelDeleteFIO.Text = "Фамилия рабочего для удаления";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(106, 59);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(436, 13);
            this.labelInfo.TabIndex = 0;
            this.labelInfo.Text = "Для поиска рабочего,собравшего максимальное количество изделий нажми Найти";
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(277, 103);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(75, 23);
            this.buttonFind.TabIndex = 1;
            this.buttonFind.Text = "Найти";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // labelRezult
            // 
            this.labelRezult.AutoSize = true;
            this.labelRezult.Location = new System.Drawing.Point(109, 176);
            this.labelRezult.Name = "labelRezult";
            this.labelRezult.Size = new System.Drawing.Size(0, 13);
            this.labelRezult.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 515);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainForm";
            this.Text = "База данных информации об  изделиях цеха (разработал Долуда С.В.)";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxAddProduktC;
        private System.Windows.Forms.Label labelAddProduktC;
        private System.Windows.Forms.TextBox textBoxAddProduktB;
        private System.Windows.Forms.Label labelAddProduktB;
        private System.Windows.Forms.TextBox textBoxAddProduktA;
        private System.Windows.Forms.Label labelAddProduktA;
        private System.Windows.Forms.TextBox textBoxAddNShop;
        private System.Windows.Forms.Label labelAddNShop;
        private System.Windows.Forms.TextBox textBoxAddFIO;
        private System.Windows.Forms.Button buttonAddWorkersProduktInfo;
        private System.Windows.Forms.Label labelAddFIO;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBoxEditProduktC;
        private System.Windows.Forms.Label labelEditNProduktC;
        private System.Windows.Forms.TextBox textBoxEditProduktB;
        private System.Windows.Forms.Label labelEditNProduktB;
        private System.Windows.Forms.TextBox textBoxEditNProduktA;
        private System.Windows.Forms.Label labelEditNProduktA;
        private System.Windows.Forms.TextBox textBoxEditNShop;
        private System.Windows.Forms.Label labelEditNShop;
        private System.Windows.Forms.TextBox textBoxEditFIO;
        private System.Windows.Forms.Button buttonEditWorkersProduktsInfo;
        private System.Windows.Forms.Label labelEditFIO;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox textBoxDeleteNProduktC;
        private System.Windows.Forms.Label labelDeleteNProduktC;
        private System.Windows.Forms.TextBox textBoxDeleteNProduktB;
        private System.Windows.Forms.Label labelDeleteNProduktB;
        private System.Windows.Forms.TextBox textBoxDeleteNProduktA;
        private System.Windows.Forms.Label labelDeleteNProduktA;
        private System.Windows.Forms.TextBox textBoxDeleteNShop;
        private System.Windows.Forms.Label labelDeleteNShop;
        private System.Windows.Forms.TextBox textBoxDeleteFIO;
        private System.Windows.Forms.Button buttonDeleteWorkersProduktsInfo;
        private System.Windows.Forms.Label labelDeleteFIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNShop;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNPoduktA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNPoduktB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNPoduktС;
        private System.Windows.Forms.Label labelRezult;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Label labelInfo;
    }
}

