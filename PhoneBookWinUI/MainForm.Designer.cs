namespace PhoneBookWinUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.linkUpdatAcaount = new System.Windows.Forms.LinkLabel();
            this.btnUpdatePhone = new System.Windows.Forms.Button();
            this.btnDeletePhone = new System.Windows.Forms.Button();
            this.btnAddPhone = new System.Windows.Forms.Button();
            this.toolUpdateContacts = new System.Windows.Forms.ToolStrip();
            this.toolbtnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolbtnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolbtnUpdate = new System.Windows.Forms.ToolStripButton();
            this.lbphones = new System.Windows.Forms.ListBox();
            this.lbUsers = new System.Windows.Forms.ListBox();
            this.btncancel = new System.Windows.Forms.Button();
            this.toolUpdateContacts.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkUpdatAcaount
            // 
            this.linkUpdatAcaount.AutoSize = true;
            this.linkUpdatAcaount.Location = new System.Drawing.Point(591, 10);
            this.linkUpdatAcaount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkUpdatAcaount.Name = "linkUpdatAcaount";
            this.linkUpdatAcaount.Size = new System.Drawing.Size(108, 17);
            this.linkUpdatAcaount.TabIndex = 15;
            this.linkUpdatAcaount.TabStop = true;
            this.linkUpdatAcaount.Text = "Update accaunt";
            this.linkUpdatAcaount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkUpdatAcaount_LinkClicked);
            // 
            // btnUpdatePhone
            // 
            this.btnUpdatePhone.Location = new System.Drawing.Point(248, 362);
            this.btnUpdatePhone.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdatePhone.Name = "btnUpdatePhone";
            this.btnUpdatePhone.Size = new System.Drawing.Size(115, 28);
            this.btnUpdatePhone.TabIndex = 14;
            this.btnUpdatePhone.Text = "Update Phone";
            this.btnUpdatePhone.UseVisualStyleBackColor = true;
            this.btnUpdatePhone.Click += new System.EventHandler(this.btnUpdatePhone_Click);
            // 
            // btnDeletePhone
            // 
            this.btnDeletePhone.Location = new System.Drawing.Point(121, 362);
            this.btnDeletePhone.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeletePhone.Name = "btnDeletePhone";
            this.btnDeletePhone.Size = new System.Drawing.Size(117, 28);
            this.btnDeletePhone.TabIndex = 13;
            this.btnDeletePhone.Text = "Delete Phone";
            this.btnDeletePhone.UseVisualStyleBackColor = true;
            this.btnDeletePhone.Click += new System.EventHandler(this.btnDeletePhone_Click);
            // 
            // btnAddPhone
            // 
            this.btnAddPhone.Location = new System.Drawing.Point(13, 362);
            this.btnAddPhone.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddPhone.Name = "btnAddPhone";
            this.btnAddPhone.Size = new System.Drawing.Size(100, 28);
            this.btnAddPhone.TabIndex = 12;
            this.btnAddPhone.Text = "Add Phone";
            this.btnAddPhone.UseVisualStyleBackColor = true;
            this.btnAddPhone.Click += new System.EventHandler(this.btnAddPhone_Click);
            // 
            // toolUpdateContacts
            // 
            this.toolUpdateContacts.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolUpdateContacts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbtnAdd,
            this.toolbtnDelete,
            this.toolbtnUpdate});
            this.toolUpdateContacts.Location = new System.Drawing.Point(0, 0);
            this.toolUpdateContacts.Name = "toolUpdateContacts";
            this.toolUpdateContacts.Size = new System.Drawing.Size(705, 27);
            this.toolUpdateContacts.TabIndex = 11;
            this.toolUpdateContacts.Text = "Contacts";
            // 
            // toolbtnAdd
            // 
            this.toolbtnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolbtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnAdd.Image")));
            this.toolbtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnAdd.Name = "toolbtnAdd";
            this.toolbtnAdd.Size = new System.Drawing.Size(24, 24);
            this.toolbtnAdd.Text = "Save Contacts";
            this.toolbtnAdd.Click += new System.EventHandler(this.toolbtnAdd_Click);
            // 
            // toolbtnDelete
            // 
            this.toolbtnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolbtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnDelete.Image")));
            this.toolbtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnDelete.Name = "toolbtnDelete";
            this.toolbtnDelete.Size = new System.Drawing.Size(24, 24);
            this.toolbtnDelete.Text = "Delete Contacts";
            this.toolbtnDelete.Click += new System.EventHandler(this.toolbtnDelete_Click);
            // 
            // toolbtnUpdate
            // 
            this.toolbtnUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolbtnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnUpdate.Image")));
            this.toolbtnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnUpdate.Name = "toolbtnUpdate";
            this.toolbtnUpdate.Size = new System.Drawing.Size(24, 24);
            this.toolbtnUpdate.Text = "Update Contacts";
            this.toolbtnUpdate.Click += new System.EventHandler(this.toolbtnUpdate_Click);
            // 
            // lbphones
            // 
            this.lbphones.FormattingEnabled = true;
            this.lbphones.ItemHeight = 16;
            this.lbphones.Location = new System.Drawing.Point(13, 211);
            this.lbphones.Margin = new System.Windows.Forms.Padding(4);
            this.lbphones.Name = "lbphones";
            this.lbphones.Size = new System.Drawing.Size(588, 132);
            this.lbphones.TabIndex = 10;
            // 
            // lbUsers
            // 
            this.lbUsers.FormattingEnabled = true;
            this.lbUsers.ItemHeight = 16;
            this.lbUsers.Location = new System.Drawing.Point(13, 42);
            this.lbUsers.Margin = new System.Windows.Forms.Padding(4);
            this.lbUsers.Name = "lbUsers";
            this.lbUsers.Size = new System.Drawing.Size(588, 148);
            this.lbUsers.TabIndex = 9;
            this.lbUsers.Click += new System.EventHandler(this.lbUsers_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(500, 386);
            this.btncancel.Margin = new System.Windows.Forms.Padding(4);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(103, 33);
            this.btncancel.TabIndex = 8;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 430);
            this.Controls.Add(this.linkUpdatAcaount);
            this.Controls.Add(this.btnUpdatePhone);
            this.Controls.Add(this.btnDeletePhone);
            this.Controls.Add(this.btnAddPhone);
            this.Controls.Add(this.toolUpdateContacts);
            this.Controls.Add(this.lbphones);
            this.Controls.Add(this.lbUsers);
            this.Controls.Add(this.btncancel);
            this.Name = "MainForm";
            this.Text = "Phone Book";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolUpdateContacts.ResumeLayout(false);
            this.toolUpdateContacts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkUpdatAcaount;
        private System.Windows.Forms.Button btnUpdatePhone;
        private System.Windows.Forms.Button btnDeletePhone;
        private System.Windows.Forms.Button btnAddPhone;
        private System.Windows.Forms.ToolStrip toolUpdateContacts;
        private System.Windows.Forms.ToolStripButton toolbtnAdd;
        private System.Windows.Forms.ToolStripButton toolbtnDelete;
        private System.Windows.Forms.ToolStripButton toolbtnUpdate;
        private System.Windows.Forms.ListBox lbphones;
        private System.Windows.Forms.ListBox lbUsers;
        private System.Windows.Forms.Button btncancel;

    }
}

