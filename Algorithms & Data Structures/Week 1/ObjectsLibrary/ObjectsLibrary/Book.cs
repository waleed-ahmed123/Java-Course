using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsLibrary
{
    class Book : IComparable
    {
        private String title;
        private Person author;
        private Genre genres;


        public Book(string title)
        {
            this.title = title;
        }

        public Book(string title, Person author, Genre genres) 
        {
            this.title = title;
            this.author = author;
            this.genres = genres;
        }

        public string Title
        {
            get { return title; }
            set { title = value; } 
        }


        internal Genre Genres
        {
            get { return genres; }
            set { genres = value; }
        }

        internal Person Author
        {
            get { return author; }
            set { author = value; }
        }
        //private members string title and Person author.


        public int CompareTo(Object obj) //implementation of CompareTo
        {					// 		for IComparable

            Book other = (Book)obj;
            return title.CompareTo(other.title);
        }
    }
}
