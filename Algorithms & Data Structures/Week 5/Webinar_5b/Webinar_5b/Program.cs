using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webinar_5b
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a graphnode with id 'a'
            GraphNode<Char> node = new GraphNode<char>('A');
            GraphNode<Char> node2 = new GraphNode<char>('B');
            GraphNode<Char> node3 = new GraphNode<char>('C');

            node.AddEdge(node2);
            node.AddEdge(node3);

            LinkedList<char> l = new LinkedList<char>();

            l = node.GetAdjList();

            foreach(char an in l)
            {
                Console.WriteLine(an);
            }


            Graph<char> myGraph = new Graph<char>();

            Console.WriteLine("is graph empty? " + myGraph.isEmpty());

            //add a node with id 'a'
            myGraph.AddNode('a');

            Console.WriteLine("is graph empty? " + myGraph.isEmpty());

            Graph<char> myGraph3 = new Graph<char>();
            myGraph3.AddNode('A');
            myGraph3.AddNode('B');
            myGraph3.AddNode('C');

            myGraph.AddEdge('A', 'B');
            myGraph.AddEdge('A', 'C');

            Console.ReadKey();
        }
    }
}
