using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5_Task_A
{
    public class GraphNode<T>
    {
        private T id;
        private LinkedList<T> adjList;

        public GraphNode(T id)
        {
            this.id = id;
            adjList = new LinkedList<T>();  // creates an empty linkList
        }


        public T ID  // getters and setters for ID
        {
            get { return id; }
            set { id = value; }
        }

        public void AddEdge(GraphNode<T> to) // this creates a link between one node another by adding it to the adjacency list
        {
            adjList.AddLast(to.ID); // adds it to the end of the list
        }

        public LinkedList<T> GetAdjList() // returns the adjacency list
        {
            return adjList;
        }
    }
}
