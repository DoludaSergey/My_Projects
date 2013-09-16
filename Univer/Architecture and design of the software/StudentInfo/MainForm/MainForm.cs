using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Common;

namespace MainForm
{
    public partial class MainForm : Form
    {
        ManagerStudent obj;
        List<Student> students;
        Student curentStudent;
        MySerializer serializer;
        
        public MainForm()
        {
            InitializeComponent();

            students = new List<Student>();
            serializer = new MySerializer();
            obj = new ManagerStudent();//Создаем объект для сериализации,равный нашему списку

        }

        private void ReadFromFile()
        {
            //извлекаем список студентов из двоичного файла
            obj = serializer.DeserializeObject("output.txt");
            students = obj.Students;
        }

        private void SaveToFile()
        {
            //Сериализируем(сохраняем) список в двоичный файл
            serializer.SerializeObject("output.txt", obj);
        }

        private void btn_AddStudent_Click(object sender, EventArgs e)
        {
            int course;
            string fakulty, firstName, lastName;
            
            int.TryParse(tb_Course.Text,out course );

            fakulty = tb_Fakulty.Text;
            firstName = tb_FirstName.Text;
            lastName = tb_LastName.Text;
            
            obj.AddStudent(course, fakulty, firstName, lastName);
            students = obj.Students;
            
            AddToGrid(students);
            Clear();
        }

        private void AddToGrid(List<Student> students)
        {
            dataGridViewStudent.Rows.Clear();
            
            foreach (Student stud in students)
                dataGridViewStudent.Rows.Add(
                    stud.Course,
                    stud.Faculty, 
                    stud.Info.FirstName, 
                    stud.Info.LastName);
        }

        private void Clear()
        {
            tb_Course.Text = "";
            tb_Fakulty.Text = "";
            tb_FirstName.Text = "";
            tb_LastName.Text = "";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ReadFromFile();
            AddToGrid(students);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveToFile();
        }



        private void btn_SearchStudent_Click(object sender, EventArgs e)
        {
            if (tb_SearchPattern.Text.Trim() != "")
            {
                switch (cb_SearchFilter.SelectedIndex)
                {
                    case 0:
                        SearchByCourseStudentFilter filterByCourse = new SearchByCourseStudentFilter();
                        filterByCourse.SearchPattern = tb_SearchPattern.Text.Trim().ToLower();
                        obj.Filter = filterByCourse;
                        break;

                    case 1:
                        SearchByFakultyStudentFilter filterByFakulty = new SearchByFakultyStudentFilter();
                        filterByFakulty.SearchPattern = tb_SearchPattern.Text.Trim().ToLower();
                        obj.Filter = filterByFakulty;
                        break;

                    case 2:
                        SearchByFirstNameStudentFilter filterByFirstName = new SearchByFirstNameStudentFilter();
                        filterByFirstName.SearchPattern= tb_SearchPattern.Text.Trim().ToLower();
                        obj.Filter = filterByFirstName;
                        break;

                    case 3:
                        SearchByLastNameStudentFilter filterByLastName = new SearchByLastNameStudentFilter();
                        filterByLastName.SearchPattern = tb_SearchPattern.Text.Trim().ToLower();
                        obj.Filter = filterByLastName;
                        break;
                    case 4: 
                    default:    
                        FullSearchStudentFilter fullFilter =new FullSearchStudentFilter();
                        fullFilter.SearchPattern=tb_SearchPattern.Text.Trim().ToLower();
                        obj.Filter = fullFilter;
                        break;
                }
            }
            students = obj.Students;
            AddToGrid(students);
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tb_SearchPattern.Text="";
            obj.Filter = null;
            students = obj.Students;
            AddToGrid(students);
        }

        private void dataGridViewStudent_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //if (this.tabPageDelete.)
            {
                if (this.dataGridViewStudent.Rows.Count > 1)
                {
                    TextBox[] textboxsForDelete = { tb_DeleteCourse, tb_DeleteFakulty, tb_DeleteFirstName, tb_DeleteLastName };
                    TextBox[] textboxsForEdit = { tb_EditCourse, tb_EditFakulty, tb_EditFistName, tb_EditLastName };

                    int i = 0;
                    List<string> param = new List<string>();

                    foreach (DataGridViewCell cell in this.dataGridViewStudent.CurrentRow.Cells)
                    {
                        textboxsForDelete[i].Text = cell.Value.ToString();
                        textboxsForEdit[i].Text = cell.Value.ToString();
                        param.Add(cell.Value.ToString());
                        i++;

                    }

                    curentStudent = new Student(int.Parse(param[0]), param[1], param[2], param[3]);
                }
            }
            
        }

        private void btn_DeleteStudent_Click(object sender, EventArgs e)
        {
            obj.DeleteStudent(obj.GetIndexStudentInStudents(curentStudent));
            students = obj.Students;
            AddToGrid(students);
        }

        private void btn_EditStudent_Click(object sender, EventArgs e)
        {
            int index=obj.GetIndexStudentInStudents(curentStudent);
            int course;
            int.TryParse(tb_EditCourse.Text,out course);
            
            Student newStudent = new Student(
                    course,
                    tb_EditFakulty.Text,
                    tb_EditFistName.Text,
                    tb_EditLastName.Text);

            obj.EditStudent(newStudent, index);
            students = obj.Students;
            AddToGrid(students);

            tb_EditCourse.Text = "";
            tb_EditFakulty.Text = "";
            tb_EditFistName.Text = "";
            tb_EditLastName.Text = "";
        }

        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectTab(this.tabPageSeartch);
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectTab(this.tabPageAddStudent);
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectTab(this.tabPageEdit);
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectTab(this.tabPageDelete);
        }

        private void сохранитьДанныеВФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveToFile();
        }

        private void обАвтореToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed by Doluda Sergey");
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SaveToFile();
            this.Close();
        }
    }
}
