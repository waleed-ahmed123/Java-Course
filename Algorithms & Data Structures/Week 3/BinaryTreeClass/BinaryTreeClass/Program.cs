using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeClass
{
    class Program
    {
        static void Main(string[] args)
        {
            BSTree<int> myTree = new BSTree<int>();
            //Node<int> tree = new Node<int>(6);
            //tree.Left = new Node<int>(2);
            //tree.Left.Right = new Node<int>(5);
            //tree.Left.Right.Data = 3;
            //tree.Right = new Node<int>(8);
            myTree.InsertItem(20);
            myTree.InsertItem(15);
            myTree.InsertItem(18);
            myTree.InsertItem(7);
            myTree.InsertItem(25);

            string treeOut = "";
            myTree.InOrder(ref treeOut);
            Console.WriteLine("Tree: " + treeOut);
            treeOut = "";
            //myTree.RemoveItem(20);
            myTree.InOrder(ref treeOut);
            Console.WriteLine("Tree: " + treeOut);
            Console.ReadKey();
        }
    }
}
