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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtemail.Text = "";
            txtpassword.Text = "";
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            string str = $"{txtemail.Text} {txtpassword}";
            MessageBox.Show(str, "name");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Main form = new Main();
            //form.Show();// Show the Main form , i can handel the parent form
            if(form.ShowDialog() == DialogResult.OK) // Show the Main form as a dialog
            {
                string s= form.UserName; // Get the UserName property from Main form
                var res = s.Split(' '); // Split the string by space
                txtemail.Text = res[0]; // Set the first part to txtemail
                txtpassword.Text = res[1]; // Set the second part to txtpassword

                //Text = "ok";

            }
            else
            {
                Text = "cancel";

            }
        }

        private void button1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
