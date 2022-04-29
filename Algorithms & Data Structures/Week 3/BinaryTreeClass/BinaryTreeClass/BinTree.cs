using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeClass
{
    class BinTree<T> where T : IComparable
    {
        protected Node<T> root;
        public BinTree()  //creates an empty tree
        {
            root = null;
        }
        public BinTree(Node<T> node)  //creates a tree with node as the root
        {
            root = node;
        }

        public void InOrder(ref string buffer)
        {
            inOrder(root, ref buffer);
        }

        private void inOrder(Node<T> tree, ref string buffer)
        {
            if (tree != null)
            {
                inOrder(tree.Left, ref buffer);
                buffer += tree.Data.ToString() +", ";
                inOrder(tree.Right, ref buffer);
            }
        }


        private T biggestItem(Node<T> tree)
        {
            if (tree == null)
                return default(T);
            else
            {
                T big = biggestItem(tree.Left);
                if (tree.Data.CompareTo(big) > 0)
                    big = tree.Data;
                T rightBig = biggestItem(tree.Right);
                if (big.CompareTo(rightBig) > 0)
                    return big;
                return rightBig;
            }
        }



    }

}


