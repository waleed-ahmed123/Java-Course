using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class LinkList
    {
        private Link list = null;

        public void AddItem(int item)
        {
            list = new Link(item, list);
        }



        public String DisplayItems()
        {
            Link temp = list;
            String buffer = "";
            while (temp != null)
            {
                buffer += temp.Data + ", "; 
                temp = temp.Next;
            }

            return buffer;
        }
    }


}
