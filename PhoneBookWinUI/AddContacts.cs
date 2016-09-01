using BusinessLogic.Entities;
using BusinessLogic.Repositories;
using BusinessLogic.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBookWinUI
{
    public partial class AddContacts : Form
    {
        private Contact contact;
        private TextContactRepositoy repoContact = new TextContactRepositoy();

        public AddContacts()
        {
            InitializeComponent();
        }

        public AddContacts(Contact contact)
        {
            InitializeComponent();

            this.contact = contact;

            tbfname.Text = this.contact.Firstname;
            tblname.Text = this.contact.LastName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            Action<Contact> dlg;

            if (this.contact == null)
            {
                dlg = new Action<Contact>(AddContact);

                this.contact = new Contact();
                contact.UserId = AuthenticationServices.LoggedUser.Id;
                contact.Firstname = tbfname.Text;
                contact.LastName = tblname.Text;

                dlg(contact);

            }
            else
            {
                dlg = new Action<Contact>(UpdateContact);

                contact.Firstname = tbfname.Text;
                contact.LastName = tblname.Text;

                dlg(contact);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            return;
        }

        private void AddContact(Contact contact)
        {

            if (contact.Firstname != string.Empty && contact.LastName != string.Empty)
            {
                repoContact.Add(contact);
                DialogResult = DialogResult.OK;
            }
            else
            {
                Action dlg = new Action(ShowMessage);
                dlg();
            }
        }

        private void UpdateContact(Contact contact)
        {
            if (contact.Firstname != string.Empty && contact.LastName != string.Empty) 
            {
                repoContact.Update(contact);
                DialogResult = DialogResult.OK;
            }
            else
            {
                Action dlg = new Action(ShowMessage);
                dlg();
            }

        }

        private void ShowMessage()
        {
            MessageBox.Show("Invalid data!",
         "Authentication",
        MessageBoxButtons.OK,
        MessageBoxIcon.Asterisk,
        MessageBoxDefaultButton.Button1);
        }
    }
}
