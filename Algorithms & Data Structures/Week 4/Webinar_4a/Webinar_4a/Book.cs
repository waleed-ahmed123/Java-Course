using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webinar_4a
{
    class Book : IComparable
    {
        public string Title;
        public string Author;
        public string ISBN;

        public Book(string Title, string Author, string ISBN)
        {
            this.Title = Title;
            this.Author = Author;
            this.ISBN = ISBN;
        }

        public override string ToString()
        {
            return Title + Author + ISBN;
        }

        public int CompareTo(object other)
        {
            Book b = (Book)other;
            return this.Title.CompareTo(b.Title);
        }
    }
}
