using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webinar_4b
{
    class Exercise:IComparable
    {
        private string name;
        private int credits;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Credits
        {
            get { return credits; }
            set { credits = value; }
        }
        
        public int CompareTo(object other)
        {
            Exercise b = (Exercise)other;
            return b.credits.CompareTo(this.credits);
        }
    }
}
