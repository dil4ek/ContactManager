namespace PhoneBookWinUI
{
    partial class AddUser
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbLName = new System.Windows.Forms.TextBox();
            this.tbFName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(333, 201);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 39);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(221, 201);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 39);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbLName
            // 
            this.tbLName.Location = new System.Drawing.Point(112, 131);
            this.tbLName.Margin = new System.Windows.Forms.Padding(4);
            this.tbLName.Name = "tbLName";
            this.tbLName.Size = new System.Drawing.Size(213, 22);
            this.tbLName.TabIndex = 17;
            // 
            // tbFName
            // 
            this.tbFName.Location = new System.Drawing.Point(112, 99);
            this.tbFName.Margin = new System.Windows.Forms.Padding(4);
            this.tbFName.Name = "tbFName";
            this.tbFName.Size = new System.Drawing.Size(213, 22);
            this.tbFName.TabIndex = 16;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(112, 65);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(213, 22);
            this.tbPassword.TabIndex = 15;
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(112, 34);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(4);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(213, 22);
            this.tbUserName.TabIndex = 14;
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(23, 131);
            this.lblLName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(76, 17);
            this.lblLName.TabIndex = 13;
            this.lblLName.Text = "Last Name";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(23, 65);
            this.lblpassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(69, 17);
            this.lblpassword.TabIndex = 12;
            this.lblpassword.Text = "Password";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(24, 34);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(79, 17);
            this.lblUserName.TabIndex = 11;
            this.lblUserName.Text = "User Name";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(24, 99);
            this.lblFName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(76, 17);
            this.lblFName.TabIndex = 10;
            this.lblFName.Text = "First Name";
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 280);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbLName);
            this.Controls.Add(this.tbFName);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.lblLName);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblFName);
            this.Name = "AddUser";
            this.Text = "User Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbLName;
        private System.Windows.Forms.TextBox tbFName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblFName;
    }
}