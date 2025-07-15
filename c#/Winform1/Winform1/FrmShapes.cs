using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform1
{
    public partial class FrmShapes : Form
    {
        public FrmShapes()
        {
            InitializeComponent();
        }

        private void FrmShapes_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics grx = CreateGraphics();
            
            grx.FillRectangle(brush, e.X, e.Y, 50, 50);
        }
        Brush brush = new SolidBrush(Color.Blue);

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            brush = new SolidBrush(Color.Red);

        }

        private void greenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            brush = new SolidBrush(Color.Green);

        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
