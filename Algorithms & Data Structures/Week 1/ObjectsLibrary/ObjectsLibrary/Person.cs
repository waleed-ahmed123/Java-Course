using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsLibrary
{
    class Person : IComparable
    {
        private int age;
        private string name;

        public Person(string name) //constructor with one argument
        {
            this.name = name;
            age = 18; //default age
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public int CompareTo(Object obj) //implementation of CompareTo
        {					// 		for IComparable

            Person other = (Person)obj;
            return Name.CompareTo(other.Name);
        }

    }

}
