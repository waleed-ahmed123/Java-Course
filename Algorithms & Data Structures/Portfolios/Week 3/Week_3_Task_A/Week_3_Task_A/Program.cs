using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Week_3_Task_A
{
    class Program
    {
        static void Main(string[] args)
        {

            readFile("textFile.txt");
            Console.ReadKey();
        }



        static void readFile(string fileName)
        {
            BSTree<string> textWords = new BSTree<string>(); // creates a bstree called textwords

            const int MAX_FILE_LINES = 50000;
            string[] AllLines = new string[MAX_FILE_LINES]; // creates an array strings of size 50,000

            //reads from bin/DEBUG subdirectory of project directory
            AllLines = File.ReadAllLines(fileName); //reads all the lines in the file

            foreach (string line in AllLines) // uses a foreach loop to take each array element one at a time
            {
                //split words using space , . ?
                string[] words = line.Split(' ', ',', '.', '?', ';', ':', '!'); //everytime it sees one of these characters it splits the words up.
                foreach (string word in words) // foreach loop used to display the words on the screen 
                {
                    if (word != "")
                    {
                        Console.Write(word.ToLower() + " ");
                    }

                    textWords.InsertItem(word.ToLower() + " ");
                }
            }

            Console.WriteLine("***************");

            Console.WriteLine(textWords.Count());

            Console.WriteLine("***************");

            Console.WriteLine(textWords.FindHeight());


        }




    }
}
