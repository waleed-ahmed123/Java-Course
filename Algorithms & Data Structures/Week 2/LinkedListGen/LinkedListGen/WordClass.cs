using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListGen
{
    class WordClass : IComparable
    {
        // Word Class should contain the word,
        //the number of occurrences(how many times that word was added),
        //a ToString method
        private string word;
        private int occurances = 1;

        public WordClass(string word)
        {
            this.word = word;
        }

        public string Word
        {
            set { word = value; }
            get { return word; }
        }


        public int Occurances
        {
            set { occurances = value; }
            get { return occurances; }
        }

        public int CompareTo(object obj)
        {
            WordClass other = (WordClass)obj;
            return this.word.CompareTo(other.word);
        }


        public override string ToString()
        {
            return word + ":" + occurances.ToString() + ",";
        }
    }
}
