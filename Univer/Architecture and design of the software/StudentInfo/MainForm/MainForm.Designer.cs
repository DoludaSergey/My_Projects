namespace MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageAddStudent = new System.Windows.Forms.TabPage();
            this.btn_AddStudent = new System.Windows.Forms.Button();
            this.tb_Fakulty = new System.Windows.Forms.TextBox();
            this.tb_FirstName = new System.Windows.Forms.TextBox();
            this.tb_LastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblFakulty = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.tb_Course = new System.Windows.Forms.TextBox();
            this.tabPageSeartch = new System.Windows.Forms.TabPage();
            this.lblFilter = new System.Windows.Forms.Label();
            this.cb_SearchFilter = new System.Windows.Forms.ComboBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_SearchStudent = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tb_SearchPattern = new System.Windows.Forms.TextBox();
            this.tabPageEdit = new System.Windows.Forms.TabPage();
            this.btn_EditStudent = new System.Windows.Forms.Button();
            this.tb_EditFakulty = new System.Windows.Forms.TextBox();
            this.tb_EditFistName = new System.Windows.Forms.TextBox();
            this.tb_EditLastName = new System.Windows.Forms.TextBox();
            this.lblEditLastName = new System.Windows.Forms.Label();
            this.lblEditFirstName = new System.Windows.Forms.Label();
            this.lblEditFakulty = new System.Windows.Forms.Label();
            this.lblEditCourse = new System.Windows.Forms.Label();
            this.tb_EditCourse = new System.Windows.Forms.TextBox();
            this.tabPageDelete = new System.Windows.Forms.TabPage();
            this.btn_DeleteStudent = new System.Windows.Forms.Button();
            this.tb_DeleteFakulty = new System.Windows.Forms.TextBox();
            this.tb_DeleteFirstName = new System.Windows.Forms.TextBox();
            this.tb_DeleteLastName = new System.Windows.Forms.TextBox();
            this.lblDeleteLastName = new System.Windows.Forms.Label();
            this.lblDeleteFirstName = new System.Windows.Forms.Label();
            this.lblDeleteFakulty = new System.Windows.Forms.Label();
            this.lblDeleteCourse = new System.Windows.Forms.Label();
            this.tb_DeleteCourse = new System.Windows.Forms.TextBox();
            this.dataGridViewStudent = new System.Windows.Forms.DataGridView();
            this.Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fakultety = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьДанныеВФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обАвтореToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPageAddStudent.SuspendLayout();
            this.tabPageSeartch.SuspendLayout();
            this.tabPageEdit.SuspendLayout();
            this.tabPageDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageAddStudent);
            this.tabControl1.Controls.Add(this.tabPageSeartch);
            this.tabControl1.Controls.Add(this.tabPageEdit);
            this.tabControl1.Controls.Add(this.tabPageDelete);
            this.tabControl1.Location = new System.Drawing.Point(12, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(640, 209);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageAddStudent
            // 
            this.tabPageAddStudent.Controls.Add(this.btn_AddStudent);
            this.tabPageAddStudent.Controls.Add(this.tb_Fakulty);
            this.tabPageAddStudent.Controls.Add(this.tb_FirstName);
            this.tabPageAddStudent.Controls.Add(this.tb_LastName);
            this.tabPageAddStudent.Controls.Add(this.lblLastName);
            this.tabPageAddStudent.Controls.Add(this.lblFirstName);
            this.tabPageAddStudent.Controls.Add(this.lblFakulty);
            this.tabPageAddStudent.Controls.Add(this.lblCourse);
            this.tabPageAddStudent.Controls.Add(this.tb_Course);
            this.tabPageAddStudent.Location = new System.Drawing.Point(4, 22);
            this.tabPageAddStudent.Name = "tabPageAddStudent";
            this.tabPageAddStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddStudent.Size = new System.Drawing.Size(632, 183);
            this.tabPageAddStudent.TabIndex = 1;
            this.tabPageAddStudent.Text = "Добавить";
            this.tabPageAddStudent.UseVisualStyleBackColor = true;
            // 
            // btn_AddStudent
            // 
            this.btn_AddStudent.Location = new System.Drawing.Point(434, 154);
            this.btn_AddStudent.Name = "btn_AddStudent";
            this.btn_AddStudent.Size = new System.Drawing.Size(176, 23);
            this.btn_AddStudent.TabIndex = 4;
            this.btn_AddStudent.Text = "Добавить";
            this.btn_AddStudent.UseVisualStyleBackColor = true;
            this.btn_AddStudent.Click += new System.EventHandler(this.btn_AddStudent_Click);
            // 
            // tb_Fakulty
            // 
            this.tb_Fakulty.Location = new System.Drawing.Point(200, 49);
            this.tb_Fakulty.Name = "tb_Fakulty";
            this.tb_Fakulty.Size = new System.Drawing.Size(410, 20);
            this.tb_Fakulty.TabIndex = 1;
            // 
            // tb_FirstName
            // 
            this.tb_FirstName.Location = new System.Drawing.Point(200, 82);
            this.tb_FirstName.Name = "tb_FirstName";
            this.tb_FirstName.Size = new System.Drawing.Size(410, 20);
            this.tb_FirstName.TabIndex = 2;
            // 
            // tb_LastName
            // 
            this.tb_LastName.Location = new System.Drawing.Point(200, 112);
            this.tb_LastName.Name = "tb_LastName";
            this.tb_LastName.Size = new System.Drawing.Size(410, 20);
            this.tb_LastName.TabIndex = 3;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(19, 115);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(106, 13);
            this.lblLastName.TabIndex = 13;
            this.lblLastName.Text = "Введите фамилию :";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(19, 85);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(78, 13);
            this.lblFirstName.TabIndex = 12;
            this.lblFirstName.Text = "Введите имя :";
            // 
            // lblFakulty
            // 
            this.lblFakulty.AutoSize = true;
            this.lblFakulty.Location = new System.Drawing.Point(19, 52);
            this.lblFakulty.Name = "lblFakulty";
            this.lblFakulty.Size = new System.Drawing.Size(168, 13);
            this.lblFakulty.TabIndex = 11;
            this.lblFakulty.Text = "Введите название факультета :";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(19, 17);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(122, 13);
            this.lblCourse.TabIndex = 10;
            this.lblCourse.Text = "Введите номер курса :";
            // 
            // tb_Course
            // 
            this.tb_Course.Location = new System.Drawing.Point(200, 14);
            this.tb_Course.Name = "tb_Course";
            this.tb_Course.Size = new System.Drawing.Size(410, 20);
            this.tb_Course.TabIndex = 0;
            // 
            // tabPageSeartch
            // 
            this.tabPageSeartch.Controls.Add(this.lblFilter);
            this.tabPageSeartch.Controls.Add(this.cb_SearchFilter);
            this.tabPageSeartch.Controls.Add(this.btn_Clear);
            this.tabPageSeartch.Controls.Add(this.btn_SearchStudent);
            this.tabPageSeartch.Controls.Add(this.lblSearch);
            this.tabPageSeartch.Controls.Add(this.tb_SearchPattern);
            this.tabPageSeartch.Location = new System.Drawing.Point(4, 22);
            this.tabPageSeartch.Name = "tabPageSeartch";
            this.tabPageSeartch.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSeartch.Size = new System.Drawing.Size(632, 183);
            this.tabPageSeartch.TabIndex = 2;
            this.tabPageSeartch.Text = "Поиск";
            this.tabPageSeartch.UseVisualStyleBackColor = true;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(81, 87);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(85, 13);
            this.lblFilter.TabIndex = 22;
            this.lblFilter.Text = "Вести поиск по";
            // 
            // cb_SearchFilter
            // 
            this.cb_SearchFilter.FormattingEnabled = true;
            this.cb_SearchFilter.Items.AddRange(new object[] {
            "номеру курса",
            "названию факультета",
            "имени студента",
            "фамилии студента",
            "всем полям"});
            this.cb_SearchFilter.Location = new System.Drawing.Point(202, 84);
            this.cb_SearchFilter.Name = "cb_SearchFilter";
            this.cb_SearchFilter.Size = new System.Drawing.Size(410, 21);
            this.cb_SearchFilter.TabIndex = 21;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(358, 139);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(176, 23);
            this.btn_Clear.TabIndex = 20;
            this.btn_Clear.Text = "Показать все";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_SearchStudent
            // 
            this.btn_SearchStudent.Location = new System.Drawing.Point(96, 139);
            this.btn_SearchStudent.Name = "btn_SearchStudent";
            this.btn_SearchStudent.Size = new System.Drawing.Size(176, 23);
            this.btn_SearchStudent.TabIndex = 18;
            this.btn_SearchStudent.Text = "Найти";
            this.btn_SearchStudent.UseVisualStyleBackColor = true;
            this.btn_SearchStudent.Click += new System.EventHandler(this.btn_SearchStudent_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(21, 34);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(159, 13);
            this.lblSearch.TabIndex = 19;
            this.lblSearch.Text = "Введите данные для поиска  :";
            // 
            // tb_SearchPattern
            // 
            this.tb_SearchPattern.Location = new System.Drawing.Point(202, 31);
            this.tb_SearchPattern.Name = "tb_SearchPattern";
            this.tb_SearchPattern.Size = new System.Drawing.Size(410, 20);
            this.tb_SearchPattern.TabIndex = 14;
            // 
            // tabPageEdit
            // 
            this.tabPageEdit.Controls.Add(this.btn_EditStudent);
            this.tabPageEdit.Controls.Add(this.tb_EditFakulty);
            this.tabPageEdit.Controls.Add(this.tb_EditFistName);
            this.tabPageEdit.Controls.Add(this.tb_EditLastName);
            this.tabPageEdit.Controls.Add(this.lblEditLastName);
            this.tabPageEdit.Controls.Add(this.lblEditFirstName);
            this.tabPageEdit.Controls.Add(this.lblEditFakulty);
            this.tabPageEdit.Controls.Add(this.lblEditCourse);
            this.tabPageEdit.Controls.Add(this.tb_EditCourse);
            this.tabPageEdit.Location = new System.Drawing.Point(4, 22);
            this.tabPageEdit.Name = "tabPageEdit";
            this.tabPageEdit.Size = new System.Drawing.Size(632, 183);
            this.tabPageEdit.TabIndex = 3;
            this.tabPageEdit.Text = "Редактировать";
            this.tabPageEdit.UseVisualStyleBackColor = true;
            // 
            // btn_EditStudent
            // 
            this.btn_EditStudent.Location = new System.Drawing.Point(436, 150);
            this.btn_EditStudent.Name = "btn_EditStudent";
            this.btn_EditStudent.Size = new System.Drawing.Size(176, 23);
            this.btn_EditStudent.TabIndex = 18;
            this.btn_EditStudent.Text = "Редактировать";
            this.btn_EditStudent.UseVisualStyleBackColor = true;
            this.btn_EditStudent.Click += new System.EventHandler(this.btn_EditStudent_Click);
            // 
            // tb_EditFakulty
            // 
            this.tb_EditFakulty.Location = new System.Drawing.Point(202, 45);
            this.tb_EditFakulty.Name = "tb_EditFakulty";
            this.tb_EditFakulty.Size = new System.Drawing.Size(410, 20);
            this.tb_EditFakulty.TabIndex = 15;
            // 
            // tb_EditFistName
            // 
            this.tb_EditFistName.Location = new System.Drawing.Point(202, 78);
            this.tb_EditFistName.Name = "tb_EditFistName";
            this.tb_EditFistName.Size = new System.Drawing.Size(410, 20);
            this.tb_EditFistName.TabIndex = 16;
            // 
            // tb_EditLastName
            // 
            this.tb_EditLastName.Location = new System.Drawing.Point(202, 108);
            this.tb_EditLastName.Name = "tb_EditLastName";
            this.tb_EditLastName.Size = new System.Drawing.Size(410, 20);
            this.tb_EditLastName.TabIndex = 17;
            // 
            // lblEditLastName
            // 
            this.lblEditLastName.AutoSize = true;
            this.lblEditLastName.Location = new System.Drawing.Point(21, 111);
            this.lblEditLastName.Name = "lblEditLastName";
            this.lblEditLastName.Size = new System.Drawing.Size(106, 13);
            this.lblEditLastName.TabIndex = 22;
            this.lblEditLastName.Text = "Введите фамилию :";
            // 
            // lblEditFirstName
            // 
            this.lblEditFirstName.AutoSize = true;
            this.lblEditFirstName.Location = new System.Drawing.Point(21, 81);
            this.lblEditFirstName.Name = "lblEditFirstName";
            this.lblEditFirstName.Size = new System.Drawing.Size(78, 13);
            this.lblEditFirstName.TabIndex = 21;
            this.lblEditFirstName.Text = "Введите имя :";
            // 
            // lblEditFakulty
            // 
            this.lblEditFakulty.AutoSize = true;
            this.lblEditFakulty.Location = new System.Drawing.Point(21, 48);
            this.lblEditFakulty.Name = "lblEditFakulty";
            this.lblEditFakulty.Size = new System.Drawing.Size(168, 13);
            this.lblEditFakulty.TabIndex = 20;
            this.lblEditFakulty.Text = "Введите название факультета :";
            // 
            // lblEditCourse
            // 
            this.lblEditCourse.AutoSize = true;
            this.lblEditCourse.Location = new System.Drawing.Point(21, 13);
            this.lblEditCourse.Name = "lblEditCourse";
            this.lblEditCourse.Size = new System.Drawing.Size(122, 13);
            this.lblEditCourse.TabIndex = 19;
            this.lblEditCourse.Text = "Введите номер курса :";
            // 
            // tb_EditCourse
            // 
            this.tb_EditCourse.Location = new System.Drawing.Point(202, 10);
            this.tb_EditCourse.Name = "tb_EditCourse";
            this.tb_EditCourse.Size = new System.Drawing.Size(410, 20);
            this.tb_EditCourse.TabIndex = 14;
            // 
            // tabPageDelete
            // 
            this.tabPageDelete.Controls.Add(this.btn_DeleteStudent);
            this.tabPageDelete.Controls.Add(this.tb_DeleteFakulty);
            this.tabPageDelete.Controls.Add(this.tb_DeleteFirstName);
            this.tabPageDelete.Controls.Add(this.tb_DeleteLastName);
            this.tabPageDelete.Controls.Add(this.lblDeleteLastName);
            this.tabPageDelete.Controls.Add(this.lblDeleteFirstName);
            this.tabPageDelete.Controls.Add(this.lblDeleteFakulty);
            this.tabPageDelete.Controls.Add(this.lblDeleteCourse);
            this.tabPageDelete.Controls.Add(this.tb_DeleteCourse);
            this.tabPageDelete.Location = new System.Drawing.Point(4, 22);
            this.tabPageDelete.Name = "tabPageDelete";
            this.tabPageDelete.Size = new System.Drawing.Size(632, 183);
            this.tabPageDelete.TabIndex = 4;
            this.tabPageDelete.Text = "Удалить";
            this.tabPageDelete.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteStudent
            // 
            this.btn_DeleteStudent.Location = new System.Drawing.Point(436, 150);
            this.btn_DeleteStudent.Name = "btn_DeleteStudent";
            this.btn_DeleteStudent.Size = new System.Drawing.Size(176, 23);
            this.btn_DeleteStudent.TabIndex = 18;
            this.btn_DeleteStudent.Text = "Удалить";
            this.btn_DeleteStudent.UseVisualStyleBackColor = true;
            this.btn_DeleteStudent.Click += new System.EventHandler(this.btn_DeleteStudent_Click);
            // 
            // tb_DeleteFakulty
            // 
            this.tb_DeleteFakulty.Location = new System.Drawing.Point(202, 45);
            this.tb_DeleteFakulty.Name = "tb_DeleteFakulty";
            this.tb_DeleteFakulty.ReadOnly = true;
            this.tb_DeleteFakulty.Size = new System.Drawing.Size(410, 20);
            this.tb_DeleteFakulty.TabIndex = 15;
            // 
            // tb_DeleteFirstName
            // 
            this.tb_DeleteFirstName.Location = new System.Drawing.Point(202, 78);
            this.tb_DeleteFirstName.Name = "tb_DeleteFirstName";
            this.tb_DeleteFirstName.ReadOnly = true;
            this.tb_DeleteFirstName.Size = new System.Drawing.Size(410, 20);
            this.tb_DeleteFirstName.TabIndex = 16;
            // 
            // tb_DeleteLastName
            // 
            this.tb_DeleteLastName.Location = new System.Drawing.Point(202, 108);
            this.tb_DeleteLastName.Name = "tb_DeleteLastName";
            this.tb_DeleteLastName.ReadOnly = true;
            this.tb_DeleteLastName.Size = new System.Drawing.Size(410, 20);
            this.tb_DeleteLastName.TabIndex = 17;
            // 
            // lblDeleteLastName
            // 
            this.lblDeleteLastName.AutoSize = true;
            this.lblDeleteLastName.Location = new System.Drawing.Point(21, 111);
            this.lblDeleteLastName.Name = "lblDeleteLastName";
            this.lblDeleteLastName.Size = new System.Drawing.Size(106, 13);
            this.lblDeleteLastName.TabIndex = 22;
            this.lblDeleteLastName.Text = "Введите фамилию :";
            // 
            // lblDeleteFirstName
            // 
            this.lblDeleteFirstName.AutoSize = true;
            this.lblDeleteFirstName.Location = new System.Drawing.Point(21, 81);
            this.lblDeleteFirstName.Name = "lblDeleteFirstName";
            this.lblDeleteFirstName.Size = new System.Drawing.Size(78, 13);
            this.lblDeleteFirstName.TabIndex = 21;
            this.lblDeleteFirstName.Text = "Введите имя :";
            // 
            // lblDeleteFakulty
            // 
            this.lblDeleteFakulty.AutoSize = true;
            this.lblDeleteFakulty.Location = new System.Drawing.Point(21, 48);
            this.lblDeleteFakulty.Name = "lblDeleteFakulty";
            this.lblDeleteFakulty.Size = new System.Drawing.Size(168, 13);
            this.lblDeleteFakulty.TabIndex = 20;
            this.lblDeleteFakulty.Text = "Введите название факультета :";
            // 
            // lblDeleteCourse
            // 
            this.lblDeleteCourse.AutoSize = true;
            this.lblDeleteCourse.Location = new System.Drawing.Point(21, 13);
            this.lblDeleteCourse.Name = "lblDeleteCourse";
            this.lblDeleteCourse.Size = new System.Drawing.Size(122, 13);
            this.lblDeleteCourse.TabIndex = 19;
            this.lblDeleteCourse.Text = "Введите номер курса :";
            // 
            // tb_DeleteCourse
            // 
            this.tb_DeleteCourse.Location = new System.Drawing.Point(202, 10);
            this.tb_DeleteCourse.Name = "tb_DeleteCourse";
            this.tb_DeleteCourse.ReadOnly = true;
            this.tb_DeleteCourse.Size = new System.Drawing.Size(410, 20);
            this.tb_DeleteCourse.TabIndex = 14;
            // 
            // dataGridViewStudent
            // 
            this.dataGridViewStudent.AllowUserToAddRows = false;
            this.dataGridViewStudent.AllowUserToDeleteRows = false;
            this.dataGridViewStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Course,
            this.Fakultety,
            this.FirstName,
            this.LastName});
            this.dataGridViewStudent.Location = new System.Drawing.Point(12, 243);
            this.dataGridViewStudent.Name = "dataGridViewStudent";
            this.dataGridViewStudent.ReadOnly = true;
            this.dataGridViewStudent.Size = new System.Drawing.Size(640, 208);
            this.dataGridViewStudent.TabIndex = 5;
            this.dataGridViewStudent.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudent_CellEnter);
            // 
            // Course
            // 
            this.Course.HeaderText = "Курс";
            this.Course.Name = "Course";
            this.Course.ReadOnly = true;
            // 
            // Fakultety
            // 
            this.Fakultety.HeaderText = "Факультет";
            this.Fakultety.Name = "Fakultety";
            this.Fakultety.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "Имя";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Фамилия";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.действияToolStripMenuItem,
            this.обАвтореToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(664, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // действияToolStripMenuItem
            // 
            this.действияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.поискToolStripMenuItem,
            this.редактироватьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.сохранитьДанныеВФайлToolStripMenuItem});
            this.действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            this.действияToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.действияToolStripMenuItem.Text = "Действия";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.поискToolStripMenuItem.Text = "Поиск";
            this.поискToolStripMenuItem.Click += new System.EventHandler(this.поискToolStripMenuItem_Click);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.редактироватьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // сохранитьДанныеВФайлToolStripMenuItem
            // 
            this.сохранитьДанныеВФайлToolStripMenuItem.Name = "сохранитьДанныеВФайлToolStripMenuItem";
            this.сохранитьДанныеВФайлToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.сохранитьДанныеВФайлToolStripMenuItem.Text = "Сохранить данные в файл";
            this.сохранитьДанныеВФайлToolStripMenuItem.Click += new System.EventHandler(this.сохранитьДанныеВФайлToolStripMenuItem_Click);
            // 
            // обАвтореToolStripMenuItem
            // 
            this.обАвтореToolStripMenuItem.Name = "обАвтореToolStripMenuItem";
            this.обАвтореToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.обАвтореToolStripMenuItem.Text = "Об авторе";
            this.обАвтореToolStripMenuItem.Click += new System.EventHandler(this.обАвтореToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 463);
            this.Controls.Add(this.dataGridViewStudent);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Список студентов";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageAddStudent.ResumeLayout(false);
            this.tabPageAddStudent.PerformLayout();
            this.tabPageSeartch.ResumeLayout(false);
            this.tabPageSeartch.PerformLayout();
            this.tabPageEdit.ResumeLayout(false);
            this.tabPageEdit.PerformLayout();
            this.tabPageDelete.ResumeLayout(false);
            this.tabPageDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAddStudent;
        private System.Windows.Forms.Button btn_AddStudent;
        private System.Windows.Forms.TextBox tb_Fakulty;
        private System.Windows.Forms.TextBox tb_FirstName;
        private System.Windows.Forms.TextBox tb_LastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblFakulty;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.TextBox tb_Course;
        private System.Windows.Forms.TabPage tabPageSeartch;
        private System.Windows.Forms.DataGridView dataGridViewStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fakultety;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.Button btn_SearchStudent;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox tb_SearchPattern;
        private System.Windows.Forms.TabPage tabPageEdit;
        private System.Windows.Forms.Button btn_EditStudent;
        private System.Windows.Forms.TextBox tb_EditFakulty;
        private System.Windows.Forms.TextBox tb_EditFistName;
        private System.Windows.Forms.TextBox tb_EditLastName;
        private System.Windows.Forms.Label lblEditLastName;
        private System.Windows.Forms.Label lblEditFirstName;
        private System.Windows.Forms.Label lblEditFakulty;
        private System.Windows.Forms.Label lblEditCourse;
        private System.Windows.Forms.TextBox tb_EditCourse;
        private System.Windows.Forms.TabPage tabPageDelete;
        private System.Windows.Forms.Button btn_DeleteStudent;
        private System.Windows.Forms.TextBox tb_DeleteFakulty;
        private System.Windows.Forms.TextBox tb_DeleteFirstName;
        private System.Windows.Forms.TextBox tb_DeleteLastName;
        private System.Windows.Forms.Label lblDeleteLastName;
        private System.Windows.Forms.Label lblDeleteFirstName;
        private System.Windows.Forms.Label lblDeleteFakulty;
        private System.Windows.Forms.Label lblDeleteCourse;
        private System.Windows.Forms.TextBox tb_DeleteCourse;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox cb_SearchFilter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem действияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьДанныеВФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обАвтореToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
    }
}

