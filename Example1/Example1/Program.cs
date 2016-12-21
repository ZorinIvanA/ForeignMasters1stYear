using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            //PersonBase teacher = new Teacher(
            //    "Jane", DateTime.Parse("10.10.1982"));

            //PersonBase[] persons = new PersonBase[]
            //    {
            //        new Teacher("", DateTime.Parse("10.10.1982")),
            //        new Student("", DateTime.Parse("10.10.1982"))

            //    };



            //String result = "Name: " + st1.Name + ", Birthday: " +
            //    st1.Birthday + ", Age: " + st1.Age;

            //String result1 = $"Name: {st1.Name}, Birthday: {st1.Birthday}, Age: {st1.Age}";

            Student st1 = new Student("Michael",
                DateTime.Parse("12.05.2000"));

            Console.WriteLine(st1.Hire(DateTime.Now));




            //Console.WriteLine(result);

            //PersonBase st = new 

            Console.ReadKey();
        }
    }
}
