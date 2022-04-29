using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webinar_5a
{
    public class Graph<T> where T : IComparable
    {
        private LinkedList<GraphNode<T>> nodes;

        public Graph()
        {
            nodes = new LinkedList<GraphNode<T>>();
        }

        public bool IsEmptyGraph()
        {
            return nodes.Count == 0;
        }

        public void AddNode(T id)
        {
            nodes.AddLast(new GraphNode<T>(id));
        }

        public bool ContainsGraph(GraphNode<T> node)
        {
            foreach(GraphNode<T> n in nodes)
            {
                if (n.ID.CompareTo(node.ID) == 0)
                {
                    return true;
                }
            }
            return false;
        }


        public GraphNode<T> GetNodeById(T id)
        {
            foreach(GraphNode<T> n in nodes)
            {
                if(id.CompareTo(n.ID) == 0)
                {
                    return n;
                }
            }
            return null;
        }


        public bool IsAdjacent(GraphNode<T> from, GraphNode<T> to)
        {
            foreach(GraphNode<T> n in nodes)
            {
                if (n.ID.CompareTo(from.ID) == 0)
                {
                    bool b = from.GetAdjList().Contains(to.ID);
                    if (b == true)
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        public void AddEdge(T from, T to)
        {
            GraphNode<T> n1 = GetNodeById(from);
            GraphNode<T> n2 = GetNodeById(to);

            if(n1 != null && n2 != null)
            {
                n1.AddEdge(n2);
            }
            else
            {
                Console.WriteLine("nodes not found, edge not added");
            }
        }



        // returns the total number of nodes present in the graph
        public int NumNodesGraph()
        {
            // to be completed
            int count = 0;

            // hint: how can you get the list of all nodes in the graph ? 
            // once you have that you can count (and return) how many elements are in the list 
            foreach(GraphNode<T> n in nodes)
            {
                count++;
            }

            return count;

        }


        // returns the total number of edges present in the graph
        public int NumEdgesGraph()
        {

            // to be completed
            int count = 0;

            foreach (GraphNode<T> n in nodes)
            {
                // hint: this loop allows to run over all the nodes present in the   graph.

                // to get the total number of edges in the graph: 
                // you need to count how many outgoing edges each node has and then return the sum obtained considering all nodes in the graph
                count += n.GetAdjList().Count;
                // how can you get the number of outgoing edges for each node ? (i.e.,     use the adjacency list of the node)
            }

            return count;

        }

    }
}
