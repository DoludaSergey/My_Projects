using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLibraryOfCollection
{
    public class MyDataOfEntity1
    {
        public string FirstName1 { get; private set; }

        public string LastName1 { get; private set; }

        public string Rank { get; private set; }

        public int Service { get; private set; }

        public string Position { get; private set; }

        public string Form1 { get; private set; }
        
        public string Annotation1 { get; private set; }


        public MyDataOfEntity1(string firstName, string lastName,string rank,
            int service,string position,string form,string annotation)
        {
            FirstName1 = firstName;
            LastName1 = lastName;
            Rank = rank;
            Service = service;
            Position = position;
            Form1 = form;
            Annotation1 = annotation;
        }


        public override string ToString()
        {
            return string.Format(
                "Фамилия - {0}, Имя - {1}, звание - {2}, выслуга лет - {3}, должность - {4}, форма службы - {5}, примечание - {6}",
                FirstName1, LastName1, Rank, Service, Position, Form1, Annotation1);
        }
    }
}

