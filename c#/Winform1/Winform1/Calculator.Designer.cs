namespace Winform1
{
    partial class Calculator
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
            txtcalc = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            SuspendLayout();
            // 
            // txtcalc
            // 
            txtcalc.Dock = DockStyle.Top;
            txtcalc.Location = new Point(0, 0);
            txtcalc.Name = "txtcalc";
            txtcalc.Size = new Size(543, 27);
            txtcalc.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(12, 140);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "0\r\n";
            button1.UseVisualStyleBackColor = true;
            button1.Click += numbers;
            // 
            // button2
            // 
            button2.Location = new Point(180, 140);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "1";
            button2.UseVisualStyleBackColor = true;
            button2.Click += numbers;
            // 
            // button3
            // 
            button3.Location = new Point(297, 140);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 3;
            button3.Text = "2\r\n";
            button3.UseVisualStyleBackColor = true;
            button3.Click += numbers;
            // 
            // button4
            // 
            button4.Location = new Point(12, 198);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 4;
            button4.Text = "3";
            button4.UseVisualStyleBackColor = true;
            button4.Click += numbers;
            // 
            // button5
            // 
            button5.Location = new Point(180, 198);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 5;
            button5.Text = "4\r\n";
            button5.UseVisualStyleBackColor = true;
            button5.Click += numbers;
            // 
            // button6
            // 
            button6.Location = new Point(297, 198);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 6;
            button6.Text = "5";
            button6.UseVisualStyleBackColor = true;
            button6.Click += numbers;
            // 
            // button7
            // 
            button7.Location = new Point(12, 246);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 7;
            button7.Text = "6";
            button7.UseVisualStyleBackColor = true;
            button7.Click += numbers;
            // 
            // button8
            // 
            button8.Location = new Point(180, 246);
            button8.Name = "button8";
            button8.Size = new Size(94, 29);
            button8.TabIndex = 8;
            button8.Text = "7";
            button8.UseVisualStyleBackColor = true;
            button8.Click += numbers;
            // 
            // button9
            // 
            button9.Location = new Point(297, 246);
            button9.Name = "button9";
            button9.Size = new Size(94, 29);
            button9.TabIndex = 9;
            button9.Text = "8\r\n";
            button9.UseVisualStyleBackColor = true;
            button9.Click += numbers;
            // 
            // button10
            // 
            button10.Location = new Point(12, 291);
            button10.Name = "button10";
            button10.Size = new Size(94, 29);
            button10.TabIndex = 10;
            button10.Text = "9\r\n";
            button10.UseVisualStyleBackColor = true;
            button10.Click += numbers;
            // 
            // button11
            // 
            button11.Location = new Point(180, 291);
            button11.Name = "button11";
            button11.Size = new Size(94, 29);
            button11.TabIndex = 11;
            button11.Text = "11\r\n";
            button11.UseVisualStyleBackColor = true;
            button11.Click += numbers;
            // 
            // button12
            // 
            button12.Location = new Point(438, 188);
            button12.Name = "button12";
            button12.Size = new Size(94, 29);
            button12.TabIndex = 12;
            button12.Text = "-";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button13_Click;
            // 
            // button13
            // 
            button13.Location = new Point(438, 263);
            button13.Name = "button13";
            button13.Size = new Size(94, 29);
            button13.TabIndex = 13;
            button13.Text = "+\r\n";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // button14
            // 
            button14.Location = new Point(438, 318);
            button14.Name = "button14";
            button14.Size = new Size(94, 29);
            button14.TabIndex = 14;
            button14.Text = "=\r\n";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 348);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtcalc);
            Name = "Calculator";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtcalc;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
    }
}