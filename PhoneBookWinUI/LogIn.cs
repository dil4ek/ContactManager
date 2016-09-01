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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            AuthenticationServices.AuthenticationUser(tbusername.Text, tbpassword.Text);

            if (AuthenticationServices.LoggedUser != null)
            {
                DialogResult = DialogResult.OK;
                return;
            }
            else
            {
                MessageBox.Show("Invalid user",
                    "Authentication",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk,
                    MessageBoxDefaultButton.Button1);
            }
        }

        private void lnkUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.ShowDialog();
        }
    }
}
