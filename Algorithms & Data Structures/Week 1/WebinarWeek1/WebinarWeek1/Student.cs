using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebinarWeek1
{
    class Student:Person
    {
        private string id;

        public Student(string name, int age,string ID ): base(name)
        {
            Age = age;
        }

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public new int CompareTo(object obj)
        {
            Student other = (Student)obj;
            return id.CompareTo(other.id);
        }
    }
}
