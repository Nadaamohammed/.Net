using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform1
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender; // Get the button that was clicked


            txtcalc.Text += btn.Text;
        }

        private void numbers(object sender, EventArgs e)
        {
            Button btn = (Button)sender; // Get the button that was clicked


            txtcalc.Text += btn.Text;

        }
        string s = "";
        int num1;
        int num2;

        private void button13_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender; // Get the button that was clicked
            s = btn.Text;
            num1 = int.Parse(txtcalc.Text); // Parse the first number from the text box
            txtcalc.Text = ""; // Clear the text box for the next number


        }

        private void button14_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(txtcalc.Text); // Parse the second number from the text box
            //int result = 0; // Initialize the result variable
            //switch(s) // Check the operator
            //{
            //    case "+":
            //        txtcalc.Text = (num1 + num2).ToString(); // Add the two numbers
            //        break;
            //    case "-":
            //        txtcalc.Text = (num1 - num2).ToString(); // Subtract the second number from the first
            //        break;
                
            //}
            if (s == "+")
            {
                txtcalc.Text = (num1 + num2).ToString(); // Add the two numbers
            }
            else if (s == "-")
            {
                txtcalc.Text = (num1 - num2).ToString(); // Subtract the second number from the first
            }
            else if (s == "*")
            {
                txtcalc.Text = (num1 * num2).ToString(); // Multiply the two numbers
            }
            else if (s == "/")
            {
                if (num2 != 0)
                {
                    txtcalc.Text = (num1 / num2).ToString(); // Divide the first number by the second
                }
                else
                {
                    MessageBox.Show("Cannot divide by zero!"); // Show an error message if dividing by zero
                }
            }

        }
    }
}
