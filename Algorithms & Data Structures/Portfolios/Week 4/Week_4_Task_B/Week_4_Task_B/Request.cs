using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4_Task_B
{
    class Request
    {
        private int id;
        private string starting;
        private string finishing;

        public int Id
        {
            set { id = value; }
            get { return id; }
        }

        public string Starting
        {
            set { starting = value; }
            get { return starting; }
        }

        public string Finishing
        {
            set { finishing = value; }
            get { return finishing; }
        }

    }
}
