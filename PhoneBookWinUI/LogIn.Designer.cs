namespace PhoneBookWinUI
{
    partial class LogIn
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
            this.lnkUser = new System.Windows.Forms.LinkLabel();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbusername = new System.Windows.Forms.TextBox();
            this.btnok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lnkUser
            // 
            this.lnkUser.AutoSize = true;
            this.lnkUser.Location = new System.Drawing.Point(204, 114);
            this.lnkUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkUser.Name = "lnkUser";
            this.lnkUser.Size = new System.Drawing.Size(65, 17);
            this.lnkUser.TabIndex = 11;
            this.lnkUser.TabStop = true;
            this.lnkUser.Text = "NewUser";
            this.lnkUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkUser_LinkClicked);
            // 
            // tbpassword
            // 
            this.tbpassword.Location = new System.Drawing.Point(149, 64);
            this.tbpassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.PasswordChar = '*';
            this.tbpassword.Size = new System.Drawing.Size(193, 22);
            this.tbpassword.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Pass Word";
            // 
            // tbusername
            // 
            this.tbusername.Location = new System.Drawing.Point(149, 32);
            this.tbusername.Margin = new System.Windows.Forms.Padding(4);
            this.tbusername.Name = "tbusername";
            this.tbusername.Size = new System.Drawing.Size(193, 22);
            this.tbusername.TabIndex = 6;
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(304, 108);
            this.btnok.Margin = new System.Windows.Forms.Padding(4);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(100, 28);
            this.btnok.TabIndex = 9;
            this.btnok.Text = "LogIn";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "User Name";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 172);
            this.Controls.Add(this.lnkUser);
            this.Controls.Add(this.tbpassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbusername);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.label1);
            this.Name = "LogIn";
            this.Text = "Log In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkUser;
        private System.Windows.Forms.TextBox tbpassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbusername;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Label label1;
    }
}