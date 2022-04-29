using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Webinar1b_StackOfObjects
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            float salary = (float)Convert.ToDecimal(SalaryTextBox.Text);
            Employee newWorker = new Employee(NameTextBox.Text, SpecialismTextBox.Text, salary);

            Job newJob = new Job(JobIdTextBox.Text, JobDescTextBox.Text, newWorker);
            jobs.Push(newJob);
        }
    }
}
