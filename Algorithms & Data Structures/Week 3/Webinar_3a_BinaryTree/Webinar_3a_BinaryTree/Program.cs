using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Webinar_3a_BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Node<int> treeNode = new Node<int>(12);
            treeNode.Right = new Node<int>(15);
            treeNode.Left = new Node<int>(10);*/

            AVLTree<int> myTree = new AVLTree<int>();
            myTree.InsertItem(5);
            myTree.InsertItem(15);
            myTree.InsertItem(25);
            

            

            //Console.WriteLine("***************");

            //Console.WriteLine(myTree.Count());

            Console.WriteLine("***************");

            Console.WriteLine(myTree.FindHeight());

            Console.WriteLine("***************");

            myTree.PreOrder();

           

            //myTree.InOrder();

            /*BinTree<int> myTree = new BinTree<int>(treeNode);
            myTree.PreOrder();
            Console.WriteLine(myTree.Count());*/


            Console.ReadKey();
        }
    }
}
