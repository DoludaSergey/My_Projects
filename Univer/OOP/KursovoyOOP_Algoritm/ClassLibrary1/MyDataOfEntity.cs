using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLibraryOfCollection
{
    public class MyDataOfEntity
    {
        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public string Group { get; private set; }

        public int CourseNumber { get; private set; }

        public string Faculty { get; private set; }

        public string Form { get; private set; }
        
        public string Annotation { get; private set; }


        public MyDataOfEntity(string firstName, string lastName,string group,
            int courseNumber,string faculty,string form,string annotation)
        {
            FirstName = firstName;
            LastName = lastName;
            Group = group;
            CourseNumber = courseNumber;
            Faculty = faculty;
            Form = form;
            Annotation = annotation;
        }


        public override string ToString()
        {
            return string.Format(
                "Фамилия - {0}, Имя - {1}, звание - {2}, выслуга лет - {3}, должность - {4}, форма службы - {5}, примечание - {6}",
                FirstName,LastName,Group,CourseNumber,Faculty,Form,Annotation);
        }
    }
}
