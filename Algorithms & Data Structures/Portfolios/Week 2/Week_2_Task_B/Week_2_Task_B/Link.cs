using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_Task_B
{
    class Link<T>
    {
        private T data;
        private Link<T> next;

        public Link(T item, Link<T> list)
        {
            data = item;
            next = list;
        }


        public Link(T item)
        {
            data = item;
            next = null;
        }

        public Link<T> Next
        {
            set { next = value; }
            get { return next; }
        }
        public T Data
        {
            set { data = value; }
            get { return data; }
        }

    }
}
