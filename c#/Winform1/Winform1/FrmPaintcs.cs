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
    public partial class FrmPaintcs : Form
    {
        public FrmPaintcs()
        {
            InitializeComponent();
        }

        private void FrmPaintcs_MouseMove(object sender, MouseEventArgs e)
        {
            //Graphics grx = CreateGraphics();
            //Brush brush = new SolidBrush(Color.Blue); // Default color
            //if (e.Button == MouseButtons.Right)
            //{
            //    grx.FillRectangle(brush, e.X - 25, e.Y - 25, 50, 50);

            //}
            //else
            //{
            //    Brush erase = new SolidBrush(BackColor);
            //    grx.FillRectangle(erase, e.X - 25, e.Y - 25, 50, 50);
            //}


        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        

        private void FrmPaintcs_Paint(object sender, PaintEventArgs e)
        {
            Graphics grx = e.Graphics;
            grx.FillRectangle(Brushes.Blue, x, 30, 50, 50);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            x += 5;
            this.Invalidate(); // This will trigger the Paint event
            if (x > this.Width)
            {
                x = 0; // Reset position if it goes off screen
            }
        }
    }
}
