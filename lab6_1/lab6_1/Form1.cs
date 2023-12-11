using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab6_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            // Add the value from textBox1 to listBox1
            string value = textBox2.Text;
            listBox1.Items.Add(value);

            // Clear the textBox1 after adding the value
            textBox2.Text = "";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to clear the entire list?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Clear listBox1 if the user clicks Yes
            if (result == DialogResult.Yes)
            {
                listBox1.Items.Clear();
            }
        }
    }
}
