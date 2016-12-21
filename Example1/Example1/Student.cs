using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    public sealed class Student : PersonBase
    {
        public int Age
        {
            get { return (DateTime.Now.Year - Birthday.Year); }
        }

        public String MarkBook { get; set; }

        public Student(String name, DateTime birthday) :
            base(name, birthday)
        {
            MarkBook = String.Empty;
        }

        public Student(String name, DateTime birthday,
            String markBook) : base(name, birthday)
        {
            MarkBook = markBook;
        }

        public new string Hire(DateTime date)
        {
            return "Student hired";
        }
    }
}
