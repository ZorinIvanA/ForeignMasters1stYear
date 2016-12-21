using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    public abstract class PersonBase
    {
        private String _name;
        public String Name
        {
            get { return _name; }
            set
            {
                _name = value;
                NotifyPropertyChaged("Name");
            }
        }

        public DateTime Birthday { get; set; }

        private String NotifyPropertyChaged(String name)
        {
            return $"{name} property was changed.";
        }

        public PersonBase(String name, DateTime birthday)
        {
            Name = name;
            Birthday = birthday;
        }

        public virtual String Hire(DateTime date)
        {
            return "Person hired";
        }
    }
}
