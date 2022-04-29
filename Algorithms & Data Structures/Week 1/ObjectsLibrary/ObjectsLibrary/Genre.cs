using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsLibrary
{
    class Genre : Book
    {
        public string genres;

      

        public Genre(string genres, string title ) : base (title)
        {
            this.genres = genres;
        }

        public string GenreType
        {
            set { genres = value; }
            get { return genres; }
        }


    }
}
