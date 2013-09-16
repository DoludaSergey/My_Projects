using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Common
{
    [Serializable]
    public class ManagerStudent : ISerializable
    {
        private List<Student> students ;
        //private IFilter<Student> filter ;
        
        #region properties

        public List<Student> Students 
        { 
            get 
            {
                if (Filter == null)
                    return this.students;
                else
                {
                    List<Student> filteredStudents = new List<Student>();
                    foreach (Student stud in students)
                        if (Filter.Filter(stud))
                            filteredStudents.Add(stud);

                    return filteredStudents;
                }
            }
            //set { }
        }

        public IFilter<Student> Filter { get; set; }

        #endregion

        #region constructor

        public ManagerStudent() { students = new List<Student>(); }
        public ManagerStudent(SerializationInfo sInfo, StreamingContext contextArg)
        {
            this.students = (List<Student>)sInfo.GetValue("Students", typeof(List<Student>));
        }

        #endregion

        #region methods

        public void GetObjectData(SerializationInfo sInfo, StreamingContext contextArg)
        {
            sInfo.AddValue("Students", this.students);
        }
        
        public void AddStudent(int course, string fakultet, string firstName, string secondName)
        {
            Student student;

            student = new Student(course, fakultet, firstName, secondName);
            this.students.Add(student);
        }

        public void ShowStudent(List<Student> stud)
        {
            if (stud != null)
                foreach (Student st in stud)
                {
                    Console.WriteLine(st);
                }
        }

        public void DeleteStudent(int index)
        {
            if (this.students.Count>0)
                this.students.RemoveAt(index);
        }

        public void EditStudent(Student stud, int index)
        {
            if (stud != null)
            {
                if (this.students.Count > 0)
                {
                    this.students.RemoveAt(index);
                    this.students.Insert(index, stud);
                }
            }
        }

        public int GetIndexStudentInStudents(Student stud)
        {
            if (stud != null)
            {
                int count = 0;
                foreach (Student st in students)
                {
                    if (st.Course == stud.Course &&
                        st.Faculty == stud.Faculty &&
                        st.Info.FirstName == stud.Info.FirstName &&
                        st.Info.LastName == stud.Info.LastName)
                        return count;
                    count++;
                }
            }
            return -1;
        }

        #endregion
    }
}
