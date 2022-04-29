using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webinar1b_StackOfObjects
{
    class Employee : Person
    {
        private string specialism;
        private float salary; //in Thousands K
        public Employee(string name, string specialism, float salary) : base(name)
        {
            this.specialism = specialism;
            this.salary = salary;
        }

        public string Specialism
        {
            set { this.specialism = value;  }
            get { return this.specialism; }
        }

        public float Salary
        {
            set { this.salary = value; }
            get { return this.salary; }
        }
    }

}
