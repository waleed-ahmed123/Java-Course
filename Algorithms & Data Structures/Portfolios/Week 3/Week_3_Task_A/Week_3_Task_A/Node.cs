using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3_Task_A
{
    class Node<T> where T : IComparable
    {
        private T data;
        public int balanceFactor = 0; // accessible from other classes 

        public Node<T> Left, Right;  // accessible from other classes that inderit from it 

        public Node(T item)
        {
            data = item;
            Left = null;
            Right = null;
        }
        public T Data
        {
            set { data = value; }
            get { return data; }
        }

        public int BalanceFactor
        {
            set { balanceFactor = value; }
            get { return balanceFactor; }
        }
    }
}
