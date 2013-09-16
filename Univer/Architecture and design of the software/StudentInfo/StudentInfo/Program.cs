using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace StudentInfo1
{
    class Program
    {
        
        static void Main(string[] args)
        {


            List<Student> students = new List<Student>();

            //Заполнение списка студентов
            //students.Add(AddStudent());
            //students.Add(AddStudent());
            
            //PrintStudents(students);

            //Console.ReadLine();

            //Создаем объект для сериализации,равный нашему списку
            SerializableObject obj = new SerializableObject();
            obj.Students = students;

            //Создаем объект сериализации
            //MySerializer serializer = new MySerializer();
            
            //Сериализируем(сохраняем) список в двоичный файл
            //serializer.SerializeObject("output.txt", obj);

            //
            //извлекаем список студентов из двоичного файла
            //obj = serializer.DeserializeObject("output.txt");
            //students = obj.Students;


        }

        static private Student AddStudent()
        {
            Student student ;

            Console.WriteLine("Введите номер курса :");
            int kurs;
            int.TryParse( Console.ReadLine(),out kurs);
            Console.WriteLine("Введите название факультета :");
            string fakultet;
            fakultet = Console.ReadLine();
            Console.WriteLine("Введите фамилию студента :");
            string firstName;
            firstName = Console.ReadLine();
            Console.WriteLine("Введите имя студента :");
            string secondName;
            secondName = Console.ReadLine();

            student = new Student(kurs, fakultet, firstName, secondName);
            return student;

            
            
        }

        static private void PrintStudents(List<Student> stud)
        {
            if (stud!=null)
            foreach (Student st in stud)
            {
                Console.WriteLine(string.Format("Курс номер {0}, факультет : {1},имя студента : {2}, фамилия студента :{3}",
                st.Course,st.Faculty,st.Info.FirstName,st.Info.SecondName    ));
            }
        }
    }



    [Serializable]
    public class Student : ISerializable
    {
        public Student() { }

        public Student(int course, string faculty, string firstName, string secondName)
        {
            this.Course = course;
            this.Faculty = faculty;
            this.info = new FIO() { FirstName = firstName, SecondName = secondName };
        }

        public Student(SerializationInfo sInfo, StreamingContext contextArg)
        {
            this.Course = (int)sInfo.GetValue("Course", typeof(int));
            this.Faculty = (string)sInfo.GetValue("Faculty", typeof(string));
            this.info = (FIO)sInfo.GetValue("FIO", typeof(FIO));
        }

        public void GetObjectData(SerializationInfo sInfo, StreamingContext contextArg)
        {
            sInfo.AddValue("Course", this.Course);
            sInfo.AddValue("Faculty", this.Faculty);
            sInfo.AddValue("FIO", this.Info);
        }

        public int Course 
        { 
            get { return this.course; } 
            set { this.course=value; }
        }

        public string Faculty
        {
            get { return this.faculty; }
            set { this.faculty = value; }
        }

        public FIO Info
        {
            get 
            {
                return this.info; 
            }
            set { this.info = value; }
        }

        private int course;
        private string faculty;
        private FIO info;

        public override string ToString()
        {
            return string.Format("Курс номер {0}, факультет : {1},имя студента : {2}, фамилия студента :{3}",
                this.Course, this.Faculty, this.Info.FirstName, this.Info.SecondName);
        }
    }

    [Serializable]
    public class FIO : ISerializable
    {
        public FIO() { }

        public FIO(string firstName, string secondName)
        {
            this.firstName = firstName;
            this.secondName = secondName;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string SecondName
        {
            get { return this.secondName; }
            set { this.secondName = value; }
        }
        public FIO(SerializationInfo sInfo, StreamingContext contextArg)
        {
            this.firstName = (string)sInfo.GetValue("FirstName", typeof(string));
            this.secondName = (string)sInfo.GetValue("SecondName", typeof(string));
        }

        public void GetObjectData(SerializationInfo sInfo, StreamingContext contextArg)
        {
            sInfo.AddValue("FirstName", this.firstName);
            sInfo.AddValue("SecondName", this.secondName);
        }

        private string firstName;
        private string secondName;
    }


    [Serializable]
    public class SerializableObject : ISerializable
    {
        private List<Student> students;

        public List<Student> Students
        {
            get { return this.students; }
            set { this.students = value; }
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

        public void Delete(Student stud)
        {
            this.students.Remove(stud);
            //this.students.RemoveAt(this.students.IndexOf(stud));
        }

        public SerializableObject() { }

        public SerializableObject(SerializationInfo sInfo, StreamingContext contextArg)
        {
            this.students = (List<Student>)sInfo.GetValue("Students", typeof(List<Student>));
        }

        public void GetObjectData(SerializationInfo sInfo, StreamingContext contextArg)
        {
            sInfo.AddValue("Students", this.students);
        }
    }



    public class MySerializer
    {
        public MySerializer() { }

        public void SerializeObject(string fileName, SerializableObject objToSerialize)
        {
            FileStream fstream = File.Open(fileName, FileMode.Create);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(fstream, objToSerialize);
            fstream.Close();
        }

        public SerializableObject DeserializeObject(string fileName)
        {
            SerializableObject objToSerialize = null;
            FileStream fstream = File.Open(fileName, FileMode.Open);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            objToSerialize = (SerializableObject)binaryFormatter.Deserialize(fstream);
            fstream.Close();
            return objToSerialize;
        }
    }    


}
