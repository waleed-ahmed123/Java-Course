using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_Task_B
{
    class Book : IComparable
    {
        private String title;
        private int isbn;
        private string author;
        //private Person author;

        public Book(string title, string author, int isbn)
        {
            this.title = title;
            this.author = author;
            this.isbn = isbn;
        }


        public string Title
        {
            set { title = value; }
            get { return title; }
        }


        public string Author
        {

            set { author = value; }
            get { return author; }
        }


        public int Isbn
        {

            set { isbn = value; }
            get { return isbn; }
        }


        public int CompareTo(Object obj) //implementation of CompareTo
        {					// 		for IComparable

            Book other = (Book)obj;
            return isbn.CompareTo(other.isbn);
        }


        public override string ToString()
        {
            return title + " " + author + " " + isbn + ", ";
        }
    }
}
