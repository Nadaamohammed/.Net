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
    public partial class Main : Form
    {
        public string UserName { get; set; }
        public Main()
        {
            InitializeComponent();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            UserName = txtname.Text;
        }
    }
}
