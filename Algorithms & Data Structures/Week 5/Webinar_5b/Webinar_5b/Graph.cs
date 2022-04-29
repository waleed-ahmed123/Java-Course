using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webinar_5b
{
    class Graph<T> where T : IComparable
    {
        private LinkedList<GraphNode<T>> nodes;

        public Graph()
        {
            nodes = new LinkedList<GraphNode<T>>();
        }

        public bool isEmpty()
        {
            if (nodes.Count == 0)
            {
                return true;
            }
            return false;
        }


        public void AddNode(T id)
        {
            nodes.AddLast(new GraphNode<T>(id));
        }


        public void AddEdge(T from, T to)
        {
            GraphNode<T> n1 = GetNodeById(from);
            GraphNode<T> n2 = GetNodeById(to);

            if (n1 != null && n2 != null)
            {
                n1.AddEdge(n2);
            }
            else
            {
                Console.WriteLine("nodes nnot there");
            }
        }


        public GraphNode<T> GetNodeById(T id)
        {
            //loop over all nodes in graph
            foreach(GraphNode<T> n in nodes)
            {
                if (id.CompareTo(n.ID) == 0)
                {
                    return n;
                }
                
            }

            return null;
        }
    }
}
