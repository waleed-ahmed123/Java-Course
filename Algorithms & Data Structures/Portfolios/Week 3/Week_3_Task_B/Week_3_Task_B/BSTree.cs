using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3_Task_B
{
    class BSTree<T> : BinTree<T> where T : IComparable
    {  //root declared as protected in Parent Class – Binary Tree
        public BSTree()
        {
            root = null;
        }

        public void InsertItem(T item)
        {
            insertItem(item, ref root);
        }

        private void insertItem(T item, ref Node<T> tree)  // we are passing by reference because the tree is changing 
        {
            if (tree == null) // if the tree is null
            {
                tree = new Node<T>(item); // insert the node into the tree
            }
            else if (item.CompareTo(tree.Data) < 0) // if item is smaller than tree.data
            {
                insertItem(item, ref tree.Left); // recursive call in the left subtree
            }

            else if (item.CompareTo(tree.Data) > 0) // if item is bigger than tree.data
            {
                insertItem(item, ref tree.Right);  // recursive call in the right subtree
            }
            else //tree.Data ==item
            {
                // dont add because you cant have two of the same items in a BSTree
            }
        }

    }
}
