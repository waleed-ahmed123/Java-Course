﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            messageTextBox.Text = "Hi";
        }

        private void ColourCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            messageTextBox.ForeColor = Color.Red;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
