namespace PhoneBookWinUI
{
    partial class AddContacts
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
            this.tblname = new System.Windows.Forms.TextBox();
            this.tbfname = new System.Windows.Forms.TextBox();
            this.lbllname = new System.Windows.Forms.Label();
            this.lblfname = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tblname
            // 
            this.tblname.Location = new System.Drawing.Point(97, 52);
            this.tblname.Margin = new System.Windows.Forms.Padding(4);
            this.tblname.Name = "tblname";
            this.tblname.Size = new System.Drawing.Size(132, 22);
            this.tblname.TabIndex = 8;
            // 
            // tbfname
            // 
            this.tbfname.Location = new System.Drawing.Point(97, 20);
            this.tbfname.Margin = new System.Windows.Forms.Padding(4);
            this.tbfname.Name = "tbfname";
            this.tbfname.Size = new System.Drawing.Size(132, 22);
            this.tbfname.TabIndex = 7;
            // 
            // lbllname
            // 
            this.lbllname.AutoSize = true;
            this.lbllname.Location = new System.Drawing.Point(13, 52);
            this.lbllname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbllname.Name = "lbllname";
            this.lbllname.Size = new System.Drawing.Size(76, 17);
            this.lbllname.TabIndex = 6;
            this.lbllname.Text = "Last Name";
            // 
            // lblfname
            // 
            this.lblfname.AutoSize = true;
            this.lblfname.Location = new System.Drawing.Point(13, 20);
            this.lblfname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfname.Name = "lblfname";
            this.lblfname.Size = new System.Drawing.Size(76, 17);
            this.lblfname.TabIndex = 5;
            this.lblfname.Text = "First Name";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(245, 108);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(129, 108);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 167);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tblname);
            this.Controls.Add(this.tbfname);
            this.Controls.Add(this.lbllname);
            this.Controls.Add(this.lblfname);
            this.Name = "AddContacts";
            this.Text = "Contacts Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tblname;
        private System.Windows.Forms.TextBox tbfname;
        private System.Windows.Forms.Label lbllname;
        private System.Windows.Forms.Label lblfname;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}