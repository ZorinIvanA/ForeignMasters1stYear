using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    public class Teacher : PersonBase
    {
        public Teacher(String name, DateTime birthday) :
            base(name, birthday)

        {

        }

        public void ComeToUniversity(String subway1,
            String subway2)
        { }

        public void ComeToUniversity(String point1)
        { }
    }
}
