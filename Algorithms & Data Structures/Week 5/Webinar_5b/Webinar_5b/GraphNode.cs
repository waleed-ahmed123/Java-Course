using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webinar_5b
{
    class GraphNode<T>
    {
        private T id;
        private LinkedList<T> adjList;

        public GraphNode(T id)
        {
            this.id = id;
            this.adjList = new LinkedList<T>();
        }

        public T ID
        {
            get { return id; }
            set { id = value; }
        }

        public void AddEdge(GraphNode<T> to)
        {
            adjList.AddLast(to.ID);
        }

        public LinkedList<T> GetAdjList()
        {
            return adjList;
        } 

    }
}
