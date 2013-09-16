using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public interface IFilter<T>
    {
        bool Filter(T entry);
    }

    public class FullSearchStudentFilter : IFilter<Student>
    {
        public string SearchPattern { get; set; }

        public bool Filter(Student entry)
        {
            return (entry.Course.ToString().Contains(SearchPattern) ||
                entry.Faculty.ToLower().Contains(SearchPattern) ||
                entry.Info.FirstName.ToLower().Contains(SearchPattern) ||
                entry.Info.LastName.ToLower().Contains(SearchPattern));
        }
    }

    public class SearchByCourseStudentFilter : IFilter<Student>
    {
        public string SearchPattern { get; set; }

        public bool Filter(Student entry)
        {
            return entry.Course.ToString().ToLower().Contains(SearchPattern) ;
        }
    }

    public class SearchByFakultyStudentFilter : IFilter<Student>
    {
        public string SearchPattern { get; set; }

        public bool Filter(Student entry)
        {
            return entry.Faculty.ToLower().Contains(SearchPattern);
        }
    }

    public class SearchByFirstNameStudentFilter : IFilter<Student>
    {
        public string SearchPattern { get; set; }

        public bool Filter(Student entry)
        {
            return entry.Info.FirstName.ToLower().Contains(SearchPattern);
        }
    }

    public class SearchByLastNameStudentFilter : IFilter<Student>
    {
        public string SearchPattern { get; set; }

        public bool Filter(Student entry)
        {
            return entry.Info.LastName.ToLower().Contains(SearchPattern);
        }
    }
}
