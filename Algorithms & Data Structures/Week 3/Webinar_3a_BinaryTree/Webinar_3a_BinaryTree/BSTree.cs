﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webinar_3a_BinaryTree
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

        private void insertItem(T item, ref Node<T> tree)
        {
            if (tree == null)
            {
                tree = new Node<T>(item); 
            }
            else if(item.CompareTo(tree.Data)<0)
            {
                insertItem(item, ref tree.Left);
            }

            else if (item.CompareTo(tree.Data) > 0)
            {
                insertItem(item, ref tree.Right);
            }
            else //tree.Data ==item
            {

            }
        }

    }

}
