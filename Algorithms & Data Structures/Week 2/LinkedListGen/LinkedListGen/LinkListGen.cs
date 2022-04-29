using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListGen
{
    class LinkListGen<T> where T : IComparable
    {
        private LinkGen<T> list;
        private int count = 0;

        public LinkListGen()
        {
            //create an empty list
            this.list = null;
        }


        public void AddItem(T item)
        {
            list = new LinkGen<T>(item, list); //create new link on the front of the list
        }


        public string DisplayList()
        {
            string buffer = "";
            LinkGen<T> temp = list; //temp starts at the beggining of the list
            while (temp != null)
            {
                buffer = buffer + temp.Data.ToString();
                temp = temp.Next; //MOVE ALONG THE LINK
            }

            return buffer;
        }

        //search for the item and return iff present, default (T) othewise
        public T Find(T item)
        {
            LinkGen<T> temp = list; //temp starts at the beggining of the list
            while (temp != null)
            {
                if (temp.Data.CompareTo(item) == 0) //if current link.Data is the same as item
                {
                    return temp.Data; // return wordClass instance
                }
                temp = temp.Next;
            }

            return default(T); //return an empty T
        }


        public int Count
        {
            set { count = value; }
            get { return count; }
        }

        public int NumberOfItems()
        {
            //string buffer = "";
            
            LinkGen<T> temp = list;
            while (temp != null)
            {
                count++;
                //buffer = buffer + temp.Data.ToString();
                temp = temp.Next; //MOVE ALONG THE LINK
            }

            return count;
        }


        /*public bool IsPresentItem(int item)
        {
            LinkGen<T> temp = list;

            if(temp == null)
            {
                return false;
            }


            if(item == temp.Data)
            {
                return true;
            }
            else
             {
                return false;            
             }
        }


        public void AppendItem(T item)
        {
            LinkGen<T> temp = list;
            if (temp == null)
            {
                AddItem(item);
            }
            else
            {
                while(temp != null)
                {
                    temp = temp.Next;
                }
                AddItem(item);
            }
        }
        

        public void RemoveItem(T item)
        {
            LinkGen<T> temp = list;
            if(temp == null)
            {
                
            }
            else
            {
                for (int i = 0; i < count - 1; i++)
                    temp = temp.Next;

                temp.Data = temp.Next.Data;
                temp.Next = temp.Next.Next.Next;
            }

            count--;
        }
        */
        
    }
}
