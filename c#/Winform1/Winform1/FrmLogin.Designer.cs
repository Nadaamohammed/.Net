namespace Winform1
{
    partial class FrmLogin
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
            label2 = new Label();
            label1 = new Label();
            btnclear = new Button();
            btnshow = new Button();
            txtpassword = new TextBox();
            txtemail = new TextBox();
            btnview = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 105);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 11;
            label2.Text = "username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 40);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 10;
            label1.Text = "email";
            // 
            // btnclear
            // 
            btnclear.Location = new Point(352, 160);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(110, 29);
            btnclear.TabIndex = 9;
            btnclear.Text = "cancel";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // btnshow
            // 
            btnshow.Location = new Point(127, 160);
            btnshow.Name = "btnshow";
            btnshow.Size = new Size(125, 29);
            btnshow.TabIndex = 8;
            btnshow.Text = "login";
            btnshow.UseVisualStyleBackColor = true;
            btnshow.Click += btnshow_Click;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(127, 98);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(125, 27);
            txtpassword.TabIndex = 7;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(127, 34);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(125, 27);
            txtemail.TabIndex = 6;
            // 
            // btnview
            // 
            btnview.Location = new Point(520, 157);
            btnview.Name = "btnview";
            btnview.Size = new Size(110, 29);
            btnview.TabIndex = 12;
            btnview.Text = "show";
            btnview.UseVisualStyleBackColor = true;
            btnview.TextChanged += button1_TextChanged;
            btnview.Click += button1_Click_1;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 198);
            Controls.Add(btnview);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnclear);
            Controls.Add(btnshow);
            Controls.Add(txtpassword);
            Controls.Add(txtemail);
            Name = "FrmLogin";
            Text = "FrmLogin";
            Load += FrmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button btnclear;
        private Button btnshow;
        private TextBox txtpassword;
        private TextBox txtemail;
        private Button btnview;
    }
}