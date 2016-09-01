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
    public partial class MainForm : Form
    {
        private TextContactRepositoy repoContact;
        private TextPhoneRepositoy repoPhones;

        public MainForm()
        {
            InitializeComponent();

            repoContact = new TextContactRepositoy();
            repoPhones = new TextPhoneRepositoy();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FillContactsList();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lbUsers_Click(object sender, EventArgs e)
        {
            if (lbUsers.SelectedIndex == -1)
                return;

            FillPhoneList();
        }

        private void toolbtnAdd_Click(object sender, EventArgs e)
        {
            AddContacts addContacts = new AddContacts();
            addContacts.ShowDialog();

            FillContactsList();
            lbphones.Items.Clear();
        }

        private void toolbtnDelete_Click(object sender, EventArgs e)
        {
            if (lbUsers.SelectedIndex == -1)
                return;

            Contact contact = (Contact)lbUsers.SelectedItem;
            repoContact.Delete(contact);

            List<PhoneNumber> phones = repoPhones.GetAll(contact.Id);

            for (int i = 0; i < phones.Count; i++)
            {
                repoPhones.Delete(phones[i]);
            }

            FillContactsList();
            lbphones.Items.Clear();

        }

        private void toolbtnUpdate_Click(object sender, EventArgs e)
        {
            if (lbUsers.SelectedIndex == -1)
                return;

            AddContacts addContacts = new AddContacts((Contact)lbUsers.SelectedItem);
            addContacts.ShowDialog();
            FillContactsList();
        }

        private void btnAddPhone_Click(object sender, EventArgs e)
        {
            if (lbUsers.SelectedIndex == -1)
                return;

            AddPhones addPhone = new AddPhones((Contact)lbUsers.SelectedItem);
            addPhone.ShowDialog();
            FillPhoneList();
        }

        private void btnDeletePhone_Click(object sender, EventArgs e)
        {
            if (lbUsers.SelectedIndex == -1)
                return;

            if (lbphones.SelectedIndex == -1)
                return;

            PhoneNumber deletedNumber = (PhoneNumber)lbphones.SelectedItem;
            repoPhones.Delete(deletedNumber);

            FillPhoneList();
        }

        private void btnUpdatePhone_Click(object sender, EventArgs e)
        {
            if (lbUsers.SelectedIndex == -1)
                return;

            if (lbphones.SelectedIndex == -1)
                return;

            AddPhones addPhone = new AddPhones((PhoneNumber)lbphones.SelectedItem);
            addPhone.ShowDialog();
            FillPhoneList();
        }

        private void linkUpdatAcaount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddUser updateUser = new AddUser();
            updateUser.ShowDialog();
        }

        private void FillContactsList()
        {
            lbUsers.Items.Clear();
            List<Contact> listContact = repoContact.GetAll(AuthenticationServices.LoggedUser.Id);

            for (int i = 0; i < listContact.Count; i++)
            {
                lbUsers.Items.Add(listContact[i]);
            }
        }

        private void FillPhoneList()
        {
            lbphones.Items.Clear();
            Contact contact = (Contact)lbUsers.SelectedItem;
            List<PhoneNumber> listPhone = repoPhones.GetAll(contact.Id);

            for (int i = 0; i < listPhone.Count; i++)
            {
                lbphones.Items.Add(listPhone[i]);
            }
        }
    }
}
