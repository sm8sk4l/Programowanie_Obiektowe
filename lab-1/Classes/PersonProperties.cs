using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1.Classes
{
    class PersonProperties : IEquatable<PersonProperties>
    {
        private string _name;
        public int Ects { get; set; }
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

        public override string ToString()
        {
            return $"Name: {_name}";
        }

        public override bool Equals(object obj)
        {
            return obj is PersonProperties properties &&
                   Ects == properties.Ects &&
                   Name == properties.Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Ects, Name);
        }

        public bool Equals(PersonProperties other)
        {
            return other._name.Equals(_name) && other.Ects == Ects;
        }
    }       

}

