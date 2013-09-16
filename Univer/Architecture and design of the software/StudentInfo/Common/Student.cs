using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Common
{
    [Serializable]
    public class Student : ISerializable
    {
        #region contructor
        public Student() { }

        public Student(int course, string faculty, string firstName, string secondName)
        {
            this.Course = course;
            this.Faculty = faculty;
            this.Info = new FIO() { FirstName = firstName, LastName = secondName };
        }
        #endregion

        #region properties

        public int Course { get; set; }
        public string Faculty { get; set; }
        public FIO Info { get; set; }

        #endregion
        
        public Student(SerializationInfo sInfo, StreamingContext contextArg)
        {
            this.Course = (int)sInfo.GetValue("Course", typeof(int));
            this.Faculty = (string)sInfo.GetValue("Faculty", typeof(string));
            this.Info = (FIO)sInfo.GetValue("FIO", typeof(FIO));
        }

        public void GetObjectData(SerializationInfo sInfo, StreamingContext contextArg)
        {
            sInfo.AddValue("Course", this.Course);
            sInfo.AddValue("Faculty", this.Faculty);
            sInfo.AddValue("FIO", this.Info);
        }

        public override string ToString()
        {
            return string.Format("Курс номер {0}, факультет : {1},имя студента : {2}, фамилия студента :{3}",
                this.Course, this.Faculty, this.Info.FirstName, this.Info.LastName);
        }
    }
}
