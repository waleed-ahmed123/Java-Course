using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3_Task_B
{
    class BinTree<T> where T : IComparable
    {
        protected Node<T> root; //change to protected

        public BinTree()  //creates an empty tree
        {
            root = null;
        }
        public BinTree(Node<T> node)  //creates a tree with node as the root
        {
            root = node;
        }

        public void PreOrder() //for the user of this class- hides the nodes away
        {
            preOrder(root);
        }

        private void preOrder(Node<T> tree) //current node we are on
        {
            if (tree == null)
            {

                //do nothing
            }
            else
            {
                Console.Write(tree.Data.ToString() + ", ");

                // recursive call(s) - left and right
                //name my method, look at parameter(s), 
                preOrder(tree.Left);
                preOrder(tree.Right);
            }
        }


        public void InOrder() //for the user of this class- hides the nodes away
        {
            inOrder(root);
        }


        private void inOrder(Node<T> tree) //current node we are on
        {
            if (tree == null)
            {
                //do nothing
            }
            else
            {
                // recursive call(s) - left and right
                //name my method, look at parameter(s), 
                inOrder(tree.Left); // traverse the ledt subtree
                Console.Write(tree.Data.ToString() + ", "); // visit the node
                inOrder(tree.Right); // traverse the right subtree
            }
        }


        public int Count() // public count method
        {
            return count(root); 
        }

        private int count(Node<T> tree) // takes in the root node
        {

            if (tree == null) // if the tree is empty
            {
                return 0; // return 0
            }
            else  // do a recursive call of count, to count the number of nodes in the left subtree, 
                //then do the same for the right
            {
                return 1 + count(tree.Left) + count(tree.Right);  // add 1 for the root node as well
            }
        }



        public int FindHeight() // public of findHeight
        {
            return findHeight(root);
        }


        protected int findHeight(Node<T> tree)
        {
            if (tree == null) //if the root node is null
            {
                return 0;  // return 0
            }
            else
            {
                return 1 + Math.Max(findHeight(tree.Left), findHeight(tree.Right)); //math.max returns the larger number
                // recursive of call findHeight of the left side and the right side, returns the larger number
            }
        }


        public void CopyTo(BinTree<T> tree)
        {
            copyTo(this.root, ref tree.root);
        }
        private void copyTo(Node<T> copiedFromNode, ref Node<T> copiedToNode)
        {
            if (copiedFromNode == null)
                copiedToNode = null;
            else
            {
                copiedToNode = new Node<T>(copiedFromNode.Data); //process node 
                copyTo(copiedFromNode.Left, ref copiedToNode.Left); //copy left subtree
                copyTo(copiedFromNode.Right, ref copiedToNode.Right); //copy right subtree
            }
        }



        public bool Equals(AVLTree<T> tree) // public method for equals
        {
            //returns true if this BSTree object contains all the same data as
            //tree with the same structure and ordering of data.
            return equals(this.root, tree.root);

        }


        private bool equals(Node<T> tree1, Node<T> tree2)
        {
            if (tree1 == null && tree2 == null) // checks if both trees are empty
            {
                return true; // return true if they are
            }
            else if (tree1 == null || tree2 == null) // then checks if one of them are empty
            {
                return false; // return false if one them are
            }
            else if (tree1.Data.CompareTo(tree2.Data) != 0) // then checks if the root of the 2 trees arent the same
            {
                return false; // return false if that is the case
            }
            else
            {
                return equals(tree1.Left, tree2.Left) && equals(tree1.Right, tree2.Right); // else do a recursive call 
                // on the left of both trees and a recursive call on the right of both trees. 
            }
        }


        public bool SubTree(AVLTree<T> tree)
        {
            //returns true if this BSTree object contains the subtree tree. 
            //A subtree of a tree T is a tree consisting of a node in T and all
            // of its descendants in T
            return subTree(this.root, tree.root);
        }

        private bool subTree(Node<T> sub, Node<T> tree)  // sub = myTree1    tree = myTree2
        {
            if (sub == null)
            {
                // if the main tree is null then it cant have a subtree
                return true;
            }

            if (tree == null)
            {
                return false;
            }

            else if (equals(sub, tree))
            { // return true if the two trees are the same
                return true;
            }
            //If the tree with root as current  
            //node doesn't match then try left 
            //and right subtrees one by one 
            else
            {
                return subTree(sub, tree.Left) || subTree(sub, tree.Right);
            }
        }
    }
}
