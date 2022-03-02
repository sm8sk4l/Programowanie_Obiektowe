using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1.Classes
{
    class PersonProperties
    {
        private string _name;

        private PersonProperties(string name)
        {
            _name = name; 
        }

        public static PersonProperties OfName(string name)
        {
            if (name != null && name.Length >= 2)
            {
                return new PersonProperties(name);

            }
            else
            {
                throw new ArgumentOutOfRangeException("Imie zbyt krotkie");
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if(value != null && value.Length >= 2)
                {
                    _name = value;
                }
            }
        }
    }
}

