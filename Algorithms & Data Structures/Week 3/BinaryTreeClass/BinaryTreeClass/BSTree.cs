using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeClass
{
    class BSTree<T> : BinTree<T> where T : IComparable
    {
        //protected Node<T> root,   declared in BinTree

        public BSTree()
        {
            root = null;
        }       

        private void insertItem(T item, ref Node<T> tree)
        {
            if (tree == null)
                tree = new Node<T>(item);

            else if (item.CompareTo(tree.Data) < 0)
                insertItem(item, ref tree.Left);

            else if (item.CompareTo(tree.Data) > 0)
                insertItem(item, ref tree.Right);
        }

        public void InsertItem(T item)
        { 
            insertItem(item, ref root); 
        }


        private T leastItem(Node<T> tree)
        {
            if(tree.Left == null)
            {
                return tree.Data;
            }
            else
            {
                return leastItem(tree.Left);
            }
        }
    }

}
