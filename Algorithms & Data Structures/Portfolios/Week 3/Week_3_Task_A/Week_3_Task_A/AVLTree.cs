using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3_Task_A
{
   
    class AVLTree<T> : BSTree<T> where T : IComparable
    {
        public new void InsertItem(T item)
        {
            insertItem(item, ref root);
        }

        private void insertItem(T item, ref Node<T> tree)
        {
            //see lecture notes for help
            //old insertItem including the stopping condition
            //balanceFactor
            //rotate left or right if not balanced

            if (tree == null)
            {
                tree = new Node<T>(item);
            }
            if (item.CompareTo(tree.Data) < 0)
            {
                insertItem(item, ref tree.Left);
            }
            else if (item.CompareTo(tree.Data) > 0)
            {
                insertItem(item, ref tree.Right);
            }
            tree.BalanceFactor = findHeight(tree.Left) - findHeight(tree.Right);
            if (tree.BalanceFactor <= -2)
            {
                rotateLeft(ref tree);
            }
            else if (tree.BalanceFactor >= 2)
            {
                rotateRight(ref tree);
            }
        }


        private void rotateLeft(ref Node<T> tree)
        {
            //do we have to rotate right first?
            //left rotate algorithm
            //double rotate -see lecture notes for help
            if (tree.Right.BalanceFactor > 0)
                rotateRight(ref tree.Right);

            Node<T> newRoot, oldRoot;

            oldRoot = tree;
            newRoot = oldRoot.Right;


            oldRoot.Right = newRoot.Left;
            newRoot.Left = oldRoot;

            tree = newRoot;

        }

        private void rotateRight(ref Node<T> tree)
        {
            //do we have to rotate right first?
            //left rotate algorithm
            //double rotate -see lecture notes for help
            if (tree.Left.BalanceFactor > 0)
                rotateLeft(ref tree.Left);


            Node<T> newRoot, oldRoot;

            oldRoot = tree;
            newRoot = oldRoot.Left;
            

            oldRoot.Left = newRoot.Right;
            newRoot.Right = oldRoot;

            tree = newRoot;

        }


    
    }
}
