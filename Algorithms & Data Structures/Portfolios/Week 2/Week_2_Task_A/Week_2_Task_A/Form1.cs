using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_2_Task_A
{
    public partial class Form1 : Form
    {

        //LinkListGen<WordClass> wordList = new LinkListGen<WordClass>();
        IntQueue nameQueue = new IntQueue();  // create an instance of the IntQueue class

        public Form1()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            nameQueue.Enqueue(nameTextBox.Text);
            numItemsLabel.Text = nameQueue.NumberOfItems().ToString();
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = nameQueue.Print();
            numItemsLabel.Text = nameQueue.NumberOfItems().ToString();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            nameQueue.Dequeue();
            displayLabel.Text = nameQueue.Print();
            numItemsLabel.Text = nameQueue.NumberOfItems().ToString();
        }
    }
}
