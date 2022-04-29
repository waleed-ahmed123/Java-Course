using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webinar1b_StackOfObjects
{
    class Job
    {
        string id, description;
        Employee worker;

        public Job( string id, string desc, Employee worker)
        {
            this.worker = worker;
            this.id = id;
            this.description = desc;
        }

        public string ToString()
        {
            return id + ":" + description + ", employee:" + worker.Name;
        }

        public Employee Worker
        {
            set { this.worker = value; }
            get { return this.worker; }
        }

        public string ID
        {
            set { this.id = value; }
            get { return this.id; }
        }

        public string Description
        {
            set { this.description = value; }
            get { return this.description; }
        }
    }

}
