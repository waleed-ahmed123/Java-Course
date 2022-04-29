using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WebinarWeek1
{
    public partial class Form1 : Form
    {

        private List<Student> studentList;

        public Form1()
        {
            InitializeComponent();
            studentList = new List<Student>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int newAge = Convert.ToInt32(ageTextBox.Text);
            Student newStudent = new Student(nameTextBox.Text, newAge, idTextBox.Text);

            studentList.Add(newStudent);

            countLabel.Text = "count " + studentList.Count();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student removeStu = new Student("", 0, idTextBox.Text);
            foreach(Student current in studentList)
            {
                if (current.CompareTo(removeStu) == 0)
                {
                    removeStu = current;
                    break;
                }

                studentList.Remove(removeStu);
                countLabel.Text = "count " + studentList.Count();
            }
        }
    }
}
