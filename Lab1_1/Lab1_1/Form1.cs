﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_1

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            int n_1 = Convert.ToInt32(textBox1.Text);
            int n_2 = Convert.ToInt32(textBox2.Text);
            textBox3.Text = (n_1 + n_2).ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n_1 = Convert.ToInt32(textBox1.Text);
            int n_2 = Convert.ToInt32(textBox2.Text);
            textBox3.Text = (n_1 - n_2).ToString();

        }


        private void button3_Click(object sender, EventArgs e)
        {
            int n_1 = Convert.ToInt32(textBox1.Text);
            int n_2 = Convert.ToInt32(textBox2.Text);
            textBox3.Text = (n_1 * n_2).ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n_1 = Convert.ToInt32(textBox1.Text);
            int n_2 = Convert.ToInt32(textBox2.Text);
            textBox3.Text = (n_1 / n_2).ToString();

        }

    }


}
