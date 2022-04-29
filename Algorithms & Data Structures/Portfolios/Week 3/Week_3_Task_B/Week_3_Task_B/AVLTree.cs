using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3_Task_B
{
    class AVLTree<T> : BSTree<T> where T : IComparable // inherits from BSTree and implements iComparable 
    {
        public new void InsertItem(T item)
        {
            insertItem(item, ref root);
        }

        private void insertItem(T item, ref Node<T> tree) // we are passing by reference because the tree is changing
        {
            //see lecture notes for help
            //old insertItem including the stopping condition
            //balanceFactor
            //rotate left or right if not balanced

            if (tree == null) // if the tree is null
            {
                tree = new Node<T>(item);  // insert the node into the tree
            }
            if (item.CompareTo(tree.Data) < 0) // if item is smaller than tree.data
            {
                insertItem(item, ref tree.Left); // recursive call in the left subtree
            }
            else if (item.CompareTo(tree.Data) > 0) // if item is bigger than tree.data
            {
                insertItem(item, ref tree.Right);  // recursive call in the right subtree
            }
            tree.BalanceFactor = findHeight(tree.Left) - findHeight(tree.Right); // finds the balance factor of the tree
            if (tree.BalanceFactor <= -2) // if the balance factor is less than or equal to 2
            {
                rotateLeft(ref tree); // do a rotateLeft
            }
            else if (tree.BalanceFactor >= 2) // if the balance factor is greater than or equal to 2
            {
                rotateRight(ref tree); // do a rotateRight
            }
        }


        private void rotateLeft(ref Node<T> tree)
        {
            //do we have to rotate right first?
            //left rotate algorithm
            //double rotate -see lecture notes for help
            if (tree.Right.BalanceFactor > 0) // tree.right balancefactor is greter than 0, 
                rotateRight(ref tree.Right); // rotateRight

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
            if (tree.Left.BalanceFactor < 0)  // if the balancefactor is less than 0
                rotateLeft(ref tree.Left); // do a rotateleft


            Node<T> newRoot, oldRoot;

            oldRoot = tree;
            newRoot = oldRoot.Left;


            oldRoot.Left = newRoot.Right;
            newRoot.Right = oldRoot;

            tree = newRoot;

        }


    }
}