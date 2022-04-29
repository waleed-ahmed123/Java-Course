using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5_Task_B
{
    class Airport<T> : Graph<T> where T : IComparable
    {
        private string Id;

        public Airport(string id)
        {
            this.Id = id;
        }

        public string ID
        {
            set { Id = value; }
            get { return Id; }
        }
    }
}
