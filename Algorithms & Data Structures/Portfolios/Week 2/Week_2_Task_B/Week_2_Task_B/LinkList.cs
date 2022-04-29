using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_Task_B
{
    class LinkList<T> where T : IComparable
    {
        private Link<T> list;
        private Link<T> p;
        private int count = 0;

        public LinkList()
        {
            //create an empty list
            this.list = null;
        }


        public int Count
        {
            set { count = value; }
            get { return count; }
        }



        public void AddItem(T item)
        {
            list = new Link<T>(item, list); //create new link on the front of the list
        }


        public string DisplayList()
        {
            string buffer = "";
            Link<T> temp = list; //temp starts at the beggining of the list
            while (temp != null)
            {
                buffer = buffer + temp.Data.ToString();
                temp = temp.Next; //MOVE ALONG THE LINK
            }

            return buffer;
        }

        //search for the item and return if present, default (T) othewise
        public T Find(T item)
        {
            Link<T> temp = list; //temp starts at the beggining of the list
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


        public int NumberOfItems()
        {
            //string buffer = "";

            Link<T> temp = list;
            while (temp != null)
            {
                count++;
                //buffer = buffer + temp.Data.ToString();
                temp = temp.Next; //MOVE ALONG THE LINK
            }

            return count;
        }


        public void RemoveItem(T item)
        {
            Link<T> temp = list;
            if (temp == null)
            {
                return;
            }
            else if (temp.Data.CompareTo(item) == 0)
            {
                temp = temp.Next;
                return;
            }
            while (temp.Next != null)
            {
                if (temp.Next.Data.CompareTo(item) == 0)
                {
                    break;
                }
                temp = temp.Next;
            }

            if (temp.Next == null)
            {
                Console.WriteLine("not in the list");
            }
            else
            {
                temp.Next = temp.Next.Next;
            }

        }


        public void AppendItem(T item)
        {
            Link<T> p;
            Link<T> temp = new Link<T>(item);

            if (list == null)
            {
                AddItem(item);
            }

            p = list;
            while (p.Next != null)
            {
                p = p.Next;
            }

            p.Next = temp;
        }





        public void SortData()
        {
            Link<T> p, q, end;
            Link<T> temp = list;

            for(end = null; end!=temp.Next; end = p)
            {
                for(p=temp; p.Next!=end; p = p.Next)
                {
                    q = p.Next;
                    if (p.Data.CompareTo(q.Data) > 0)
                    {
                        T h = p.Data;
                        p.Data = q.Data;
                        q.Data = h;
                    }
                }
            }
        }






        /*public bool IsPresentItem(T item)
         {
             Link<T> temp = list;

             if (temp == null)
                 return false;

             while (temp != null)
             {
                 if (temp.Data == item)
                     return true;
                temp = temp.Next;
             }

         }*/
    
    

    }
}
