namespace Winform1
{
    partial class Main
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
            txtname = new TextBox();
            label1 = new Label();
            btnok = new Button();
            btncancel = new Button();
            SuspendLayout();
            // 
            // txtname
            // 
            txtname.Location = new Point(426, 14);
            txtname.Name = "txtname";
            txtname.Size = new Size(125, 27);
            txtname.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(328, 21);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 1;
            label1.Text = "fullname\r\n";
            // 
            // btnok
            // 
            btnok.DialogResult = DialogResult.OK;
            btnok.Location = new Point(356, 63);
            btnok.Name = "btnok";
            btnok.Size = new Size(94, 29);
            btnok.TabIndex = 2;
            btnok.Text = "ok\r\n";
            btnok.UseVisualStyleBackColor = true;
            btnok.Click += btnok_Click;
            // 
            // btncancel
            // 
            btncancel.DialogResult = DialogResult.Cancel;
            btncancel.Location = new Point(524, 63);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(94, 29);
            btncancel.TabIndex = 3;
            btncancel.Text = "cancel\r\n";
            btncancel.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 104);
            Controls.Add(btncancel);
            Controls.Add(btnok);
            Controls.Add(label1);
            Controls.Add(txtname);
            Name = "Main";
            Text = "Main";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtname;
        private Label label1;
        private Button btnok;
        private Button btncancel;
    }
}