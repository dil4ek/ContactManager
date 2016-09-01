using BusinessLogic.Entities;
using BusinessLogic.Repositories;
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
    public partial class AddPhones : Form
    {
        private Contact contact;
        private PhoneNumber phone;
        private TextPhoneRepositoy repoPhones = new TextPhoneRepositoy();

        //public AddPhones()
        //{
        //    InitializeComponent();
        //}

        public AddPhones(Contact contact)
        {
            InitializeComponent();

            this.contact = contact;
        }

        public AddPhones(PhoneNumber phone)
        {
            InitializeComponent();

            this.phone = phone;
            tbnumber.Text = this.phone.Number;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Action<PhoneNumber> dlg;

            if (this.phone == null)
            {
                phone = new PhoneNumber();
                phone.ContactId= contact.Id;
                phone.Number = tbnumber.Text;
                dlg = new Action<PhoneNumber>(AddPhone);
                dlg(phone);

            }
            else
            {
                phone.Number = tbnumber.Text;
                dlg = new Action<PhoneNumber>(UpdatePhone);
                dlg(phone);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void AddPhone(PhoneNumber phone)
        {
            if (phone.Number != string.Empty)
            {
                repoPhones.Add(phone);
                DialogResult = DialogResult.OK;
            }
            else
            {
                Action dlg = new Action(ShowMessage);
                dlg();
            }
        }

        private void UpdatePhone(PhoneNumber phone)
        {
            if (phone.Number != string.Empty)
            {
                repoPhones.Update(phone);
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
