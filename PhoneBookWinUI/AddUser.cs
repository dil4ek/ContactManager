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
    public partial class AddUser : Form
    {
        private TextUserRepository repoUser = new TextUserRepository();

        public AddUser()
        {
            InitializeComponent();
            if (AuthenticationServices.LoggedUser != null)
            {
                tbUserName.Text = AuthenticationServices.LoggedUser.UserName;
                tbPassword.Text = AuthenticationServices.LoggedUser.Password;
                tbFName.Text = AuthenticationServices.LoggedUser.FirstName;
                tbLName.Text = AuthenticationServices.LoggedUser.LastName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Action<User> dlg;

            if (AuthenticationServices.LoggedUser == null)
            {
                User user = new User();
                user.UserName = tbUserName.Text;
                user.Password = tbPassword.Text;
                user.FirstName = tbFName.Text;
                user.LastName = tbLName.Text;

                dlg = new Action<User>(AddUsers);
                dlg(user);
            }
            else
            {
                AuthenticationServices.LoggedUser.UserName = tbUserName.Text;
                AuthenticationServices.LoggedUser.Password = tbPassword.Text;
                AuthenticationServices.LoggedUser.FirstName = tbFName.Text;
                AuthenticationServices.LoggedUser.LastName = tbLName.Text;

                dlg = new Action<User>(UpdateUsers);
                dlg(AuthenticationServices.LoggedUser);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            return;
        }

        private void AddUsers(User user)
        {
            if (user.UserName != string.Empty && user.Password != string.Empty &&
                user.FirstName != string.Empty && user.LastName != string.Empty)
            {
                repoUser.Add(user);
                DialogResult = DialogResult.OK;
                return;
            }
            else
            {
                Action dlg = new Action(ShowMessage);
                dlg();
            }
        }

        private void UpdateUsers(User user)
        {
            if (user.UserName != string.Empty && user.Password != string.Empty &&
                user.FirstName != string.Empty && user.LastName != string.Empty)
            {
                repoUser.Update(user);
                DialogResult = DialogResult.OK;
                return;
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

