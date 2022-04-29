using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3_Task_B
{
    class Program
    {
        static void Main(string[] args)
        {

            AVLTree<int> myTree = new AVLTree<int>();
            myTree.InsertItem(5);
            myTree.InsertItem(4);
            myTree.InsertItem(2);
            myTree.InsertItem(15);
            myTree.InsertItem(25);
            myTree.InsertItem(35);


            AVLTree<int> myTree2 = new AVLTree<int>();
            myTree2.InsertItem(5);
            myTree2.InsertItem(4);
            myTree2.InsertItem(15);
            myTree2.InsertItem(25);
            myTree2.InsertItem(35);

            Console.WriteLine(myTree.Equals(myTree2));

            Console.WriteLine(myTree.SubTree(myTree2)); // is myTree a subTree of myTree2

            Console.WriteLine("height of tree is: {0} ", myTree.FindHeight());

            myTree.InOrder();
            //myTree2.InOrder();

            //myTree.PreOrder();
            //myTree2.PreOrder();

            Console.ReadKey();
        }

    }
}
