namespace Winform1
{
    partial class FrmShapes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            redToolStripMenuItem = new ToolStripMenuItem();
            redToolStripMenuItem1 = new ToolStripMenuItem();
            colorToolStripMenuItem = new ToolStripMenuItem();
            redToolStripMenuItem2 = new ToolStripMenuItem();
            greenToolStripMenuItem = new ToolStripMenuItem();
            blueToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { redToolStripMenuItem, redToolStripMenuItem1, colorToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // redToolStripMenuItem
            // 
            redToolStripMenuItem.Name = "redToolStripMenuItem";
            redToolStripMenuItem.Size = new Size(45, 24);
            redToolStripMenuItem.Text = "red";
            redToolStripMenuItem.Click += redToolStripMenuItem_Click;
            // 
            // redToolStripMenuItem1
            // 
            redToolStripMenuItem1.Name = "redToolStripMenuItem1";
            redToolStripMenuItem1.Size = new Size(45, 24);
            redToolStripMenuItem1.Text = "red";
            redToolStripMenuItem1.Click += greenToolStripMenuItem1_Click;
            // 
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { redToolStripMenuItem2, greenToolStripMenuItem, blueToolStripMenuItem });
            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new Size(57, 24);
            colorToolStripMenuItem.Text = "color";
            colorToolStripMenuItem.Click += colorToolStripMenuItem_Click;
            // 
            // redToolStripMenuItem2
            // 
            redToolStripMenuItem2.Name = "redToolStripMenuItem2";
            redToolStripMenuItem2.Size = new Size(224, 26);
            redToolStripMenuItem2.Text = "red";
            // 
            // greenToolStripMenuItem
            // 
            greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            greenToolStripMenuItem.Size = new Size(224, 26);
            greenToolStripMenuItem.Text = "green";
            // 
            // blueToolStripMenuItem
            // 
            blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            blueToolStripMenuItem.Size = new Size(224, 26);
            blueToolStripMenuItem.Text = "blue";
            // 
            // FrmShapes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmShapes";
            Text = "FrmShapes";
            MouseClick += FrmShapes_MouseClick;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem redToolStripMenuItem;
        private ToolStripMenuItem redToolStripMenuItem1;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ToolStripMenuItem redToolStripMenuItem2;
        private ToolStripMenuItem greenToolStripMenuItem;
        private ToolStripMenuItem blueToolStripMenuItem;
    }
}