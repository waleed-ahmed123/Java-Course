using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5_Task_A
{
    public class Graph<T> where T : IComparable
    {
        private LinkedList<GraphNode<T>> nodes; //linkedlist of nodes (graphnodes)

        public Graph()
        {
            nodes = new LinkedList<GraphNode<T>>(); // creates an empty linkedlist of graphnodes and assigns it to nodes
        }

        public bool IsEmptyGraph()
        {
            return nodes.Count == 0; // uses c# property count
            //returns true if count is equa to 0 else returns false
        }

        public void AddNode(T id)
        {
            nodes.AddLast(new GraphNode<T>(id));  // creates a new graphnode and adds it to the list of nodes. 
        }

        public bool ContainsGraph(GraphNode<T> node)
        {
            foreach (GraphNode<T> n in nodes) // goes through each node in the nodes list 
            {
                if (n.ID.CompareTo(node.ID) == 0) // returns true if it has found the node 
                {
                    return true;
                }
            }
            return false; // otherwise returns false
        }


        public GraphNode<T> GetNodeById(T id)
        {
            foreach (GraphNode<T> n in nodes) // goes through each node
            {
                if (id.CompareTo(n.ID) == 0) // returns the node if it finds it
                {
                    return n;
                }
            }
            return null; // otherwise returns null
        }


        public bool IsAdjacent(GraphNode<T> from, GraphNode<T> to)
        {
            foreach (GraphNode<T> n in nodes)
            {
                if (n.ID.CompareTo(from.ID) == 0) // first you have to find 'from'
                {
                    bool b = from.GetAdjList().Contains(to.ID); // check if 'to' is adjacent to 'from' using the c# contains method 
                    if (b == true)
                    {
                        return true; // returns true if it is
                    }
                }
            }
            return false;  // returns false if it isn't
        }


        public void AddEdge(T from, T to)
        {
            GraphNode<T> n1 = GetNodeById(from); // get the node id of from
            GraphNode<T> n2 = GetNodeById(to);   // get the node id of to

            if (n1 != null && n2 != null)
            {
                n1.AddEdge(n2);  // use the addEdge method from the class graphnode and establish an edge
            }
            else
            {
                Console.WriteLine("nodes not found, edge not added"); // else return its not found
            }
        }



        // returns the total number of nodes present in the graph
        public int NumNodesGraph()
        {
            // to be completed
            int count = 0; // count variable

            // hint: how can you get the list of all nodes in the graph ? 
            // once you have that you can count (and return) how many elements are in the list 
            foreach (GraphNode<T> n in nodes)  // everytime you get to a node
            {
                count++; // increment count 
            }

            return count; // and return it
             
        }


        // returns the total number of edges present in the graph
        public int NumEdgesGraph()
        {

            // to be completed
            int count = 0;

            foreach (GraphNode<T> n in nodes) // everytime you reach a node
            {
                // hint: this loop allows to run over all the nodes present in the   graph.

                // to get the total number of edges in the graph: 
                // you need to count how many outgoing edges each node has and then return the sum obtained considering all nodes in the graph
                
                count += n.GetAdjList().Count; // use the c# count method to cont how many nodes are adjacent to it and add it to count

                // how can you get the number of outgoing edges for each node ? (i.e.,     use the adjacency list of the node)
            }

            return count; // return count 

        }
    }
}
