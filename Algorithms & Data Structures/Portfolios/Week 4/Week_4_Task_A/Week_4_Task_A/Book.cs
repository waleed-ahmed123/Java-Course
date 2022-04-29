using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4_Task_A
{
    class Book : IComparable
    {
        public string Title;
        public string Author;
        public string ISBN;

        public Book(string ISBN, string Title, string Author)
        {
            this.Title = Title;
            this.Author = Author;
            this.ISBN = ISBN;
        }

        public override string ToString()
        {
            return Title + ", " + Author + ", " + ISBN;
            //return ISBN + ", " + Title + ", " + Author;
        }

        public int CompareTo(object other)
        {
            Book b = (Book)other;
            return this.Title.CompareTo(b.Title);
        }
    }
}
