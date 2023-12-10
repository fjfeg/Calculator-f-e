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
using Button = System.Windows.Forms.Button;

namespace Calculator
{
    public partial class Form1 : Form
    {

        double enterFirstNumber, enterSecondNumber;
        String op;
        public Form1()
        {
            InitializeComponent();
        }


        private void EnterNumbers(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            if (textBox1.Text == "0")
                textBox1.Text = " ";
            {
                if (num.Text == ".")
                {
                    if (!textBox1.Text.Contains("."))
                        textBox1.Text = textBox1.Text + num.Text;
                }
                else
                {
                    textBox1.Text = textBox1.Text + num.Text;
                }
            }


        }

        private void numOpr(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            enterFirstNumber = Convert.ToDouble(textBox1.Text);
            op = num.Text;
            textBox1.Text = "";
        }

        private void equal_Click(object sender, EventArgs e)
        {
            enterSecondNumber = Convert.ToDouble(textBox1.Text);
            switch(op)
            {
                case "+":
                    textBox1.Text = (enterFirstNumber + enterSecondNumber).ToString();

                    break;

                case "-":
                    textBox1.Text = (enterFirstNumber - enterSecondNumber).ToString();
                    break;

                case "*":
                    textBox1.Text = (enterFirstNumber * enterSecondNumber).ToString();
                    break;

                case "/":
                    textBox1.Text = (enterFirstNumber / enterSecondNumber).ToString();
                    break;

            }
        }

        private void deleteAll_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            double q = Convert.ToDouble(textBox1.Text);
            textBox1.Text = Convert.ToString(-1*q);
        }

        private void change_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            enterFirstNumber = 0;
            enterSecondNumber = 0;
            op = null;

        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length  - 1, 1);
            }
            if (textBox1.Text == " ")
            {
                textBox1.Text = "0";
            }
        }


        private double Factorial(double n)
        {
            if (n < 0)
            {
                return 0;
            }

            double result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }

        private void standartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 495;
            textBox1.Width = 442;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult exitCall;
            exitCall = MessageBox.Show("Confirm if you want to exit the Scientific calculator",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (exitCall == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void bPI_Click(object sender, EventArgs e)
        {
            textBox1.Text = "3,1415926535";
        }

        private void bTNLOg_Click(object sender, EventArgs e)
        {
            double login = Convert.ToDouble(textBox1.Text);
            login = Math.Log10(login);
            textBox1.Text = Convert.ToString(login);
        }

        private void sin_Click(object sender, EventArgs e)
        {
            double sinus = Convert.ToDouble(textBox1.Text);
            sinus = Math.Sin(sinus);
            textBox1.Text = Convert.ToString(sinus);
        }

        private void cos_Click(object sender, EventArgs e)
        {
            double cosinus = Convert.ToDouble(textBox1.Text);
            cosinus = Math.Cos(cosinus);
            textBox1.Text = Convert.ToString(cosinus);
        }

        private void tan_Click(object sender, EventArgs e)
        {
            double tanus = Convert.ToDouble(textBox1.Text);
            tanus = Math.Tan(tanus);
            textBox1.Text = Convert.ToString(tanus);
        }

        private void In_Click(object sender, EventArgs e)
        {
            double inputValue = Convert.ToDouble(textBox1.Text);
            double result = Factorial(inputValue);
            textBox1.Text = result.ToString();
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            double expos = Convert.ToDouble(textBox1.Text);
             expos= Math.Exp(expos);
            textBox1.Text = Convert.ToString(expos);
        }

        private void root_Click(object sender, EventArgs e)
        {
            double sqrt = Convert.ToDouble(textBox1.Text);
            sqrt = Math.Sqrt(sqrt);
            textBox1.Text = Convert.ToString(sqrt);
        }

        private void Cosh_Click(object sender, EventArgs e)
        {
            double cosh = Convert.ToDouble(textBox1.Text);
            cosh = Math.Cosh(cosh);
            textBox1.Text = Convert.ToString(cosh);

        }

        private void Sinh_Click(object sender, EventArgs e)
        {
            double sinh = Convert.ToDouble(textBox1.Text);
            sinh = Math.Sinh(sinh);
            textBox1.Text = Convert.ToString(sinh);
        }

        private void tanh_Click(object sender, EventArgs e)
        {
            double tanh = Convert.ToDouble(textBox1.Text);
            tanh = Math.Tanh(tanh);
            textBox1.Text = Convert.ToString(tanh);
        }

        private void prosent_Click(object sender, EventArgs e)
        {
            double prosent = Convert.ToDouble(textBox1.Text);
            prosent = prosent / 100;
            textBox1.Text = Convert.ToString(prosent);
        }

        

        private void Xpower2_Click(object sender, EventArgs e)
        {
            double xp2 = Convert.ToDouble(textBox1.Text);
            xp2 = Math.Pow(xp2,2);
            textBox1.Text = Convert.ToString(xp2);

        }

        private void xPOWER3_Click(object sender, EventArgs e)
        {
            double xp3 = Convert.ToDouble(textBox1.Text);
            xp3 = Math.Pow(xp3, 3);
            textBox1.Text = Convert.ToString(xp3);
        }

        private void dbg_Click(object sender, EventArgs e)
        {
            double odr = Convert.ToDouble(textBox1.Text);
            odr = 1 / odr;
            textBox1.Text = Convert.ToString(odr);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 295;

        }
    }
}
