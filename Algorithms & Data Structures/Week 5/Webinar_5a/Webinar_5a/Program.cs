using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webinar_5a
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph<char> myGraph = new Graph<char>();

            myGraph.AddNode('A');
            myGraph.AddNode('B');
            myGraph.AddNode('C');
            myGraph.AddNode('D');
            myGraph.AddNode('E');
            myGraph.AddNode('F');


            myGraph.AddEdge('A', 'B');
            myGraph.AddEdge('A', 'C');
            myGraph.AddEdge('B', 'C');
            myGraph.AddEdge('D', 'A');
            myGraph.AddEdge('D', 'E');
            myGraph.AddEdge('A', 'E');

            Console.WriteLine("is node {0} adjacent to node {1} ? Answer: {2} ", 
                myGraph.GetNodeById('B').ID, myGraph.GetNodeById('C').ID,
                myGraph.IsAdjacent(myGraph.GetNodeById('C'),
                myGraph.GetNodeById('B')));

            Console.WriteLine("is empty graph? " + myGraph.IsEmptyGraph());

            Console.WriteLine("number of node is: " + myGraph.NumNodesGraph());

            Console.WriteLine("number of edges are: " + myGraph.NumEdgesGraph());

            Console.ReadKey();
        }
    }
}
