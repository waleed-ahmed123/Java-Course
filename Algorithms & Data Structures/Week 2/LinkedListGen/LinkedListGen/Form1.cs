using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkedListGen
{
    public partial class Form1 : Form
    {
        LinkListGen<WordClass> wordList = new LinkListGen<WordClass>();

        public Form1()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //get a string from the textBox

            //string str = WordTextBox.Text;

            WordClass newWord = new WordClass(WordTextBox.Text); //create a new wordClass

            //add it to the list
            // insert unique word to the list - increment occurnaces if already there

            WordClass FoundItem = wordList.Find(newWord);

            if (FoundItem == null)
            {
                wordList.AddItem(newWord);
                countLabel.Text = wordList.NumberOfItems().ToString();
            }
            else
            {
                FoundItem.Occurances++;
            }

            outputLabel.Text = wordList.DisplayList();


        }

       
    }
}
