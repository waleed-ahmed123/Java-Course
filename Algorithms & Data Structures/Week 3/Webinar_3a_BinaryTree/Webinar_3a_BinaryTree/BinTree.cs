using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webinar_3a_BinaryTree
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
                inOrder(tree.Left);
                Console.Write(tree.Data.ToString() + ", ");
                inOrder(tree.Right);
            }
        }



        public int Count()
        {
            return count(root);
        }

        private int count(Node<T> tree)
        {

            if (tree == null)
            {
                return 0;
            }
            else
            {
                return 1 + count(tree.Left) + count(tree.Right);
            }
        }



        public int FindHeight()
        {
            return findHeight(root);
        }


        protected int findHeight(Node<T> tree)
        {
            if(tree == null)
            {
                return 0;
            }
            else
            {
                return 1 + Math.Max(findHeight(tree.Left), findHeight(tree.Right));
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




        /*protected int findHeight(Node<T> tree)
        {
            //Check whether tree is empty  
            if (root == null)
            {
                Console.WriteLine("Tree is empty");
                return 0;
            }
            else
            {
                int leftHeight = 0, rightHeight = 0;

                //Calculate the height of left subtree  
                if (tree.Left != null)
                    leftHeight = findHeight(tree.Left);

                //Calculate the height of right subtree  
                if (tree.Right != null)
                    rightHeight = findHeight(tree.Right);

                //Compare height of left subtree and right subtree   
                //and store maximum of two in variable max  
                int max = (leftHeight > rightHeight) ? leftHeight : rightHeight;

                //Calculate the total height of tree by adding height of root  
                return (max + 1);
            }

        }*/
    }
}


