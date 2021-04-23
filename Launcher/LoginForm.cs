using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Launcher
{
    public partial class LoginForm : Form
    {
        private MainMenu _mainMenu;
        private RegisterAccount _regMenu;
        private AccountReader _accountReader;
        public LoginForm()
        {
            _accountReader = new AccountReader();
            _mainMenu = new MainMenu(this);
            _regMenu = new RegisterAccount(this, _accountReader);
            InitializeComponent();
        }
        private void sumbitRegistration_Click(object sender, EventArgs e)
        {
            _accountReader.ReadAccountsJson();
            var account = _accountReader.FindAccount(login.Text);
            if (account is Account)
            {
                if (account.password.Equals(password.Text))
                {
                    Enter(account);
                }
                else
                {
                    MessageBox.Show($"WrongPassword");
                }
            }
            else
            {
                MessageBox.Show($"Account doesn't exsist");
            }
        }
        private void Enter(Account account)
        {
            Hide();
            _mainMenu.ConfirmAccount(account);
            _mainMenu.Show();
        }
        private void password_DoubleClick(object sender, EventArgs e)
        {
            password.Text = string.Empty;
        }

        private void login_DoubleClick(object sender, EventArgs e)
        {
            login.Text = string.Empty;
        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            Hide();
            _regMenu.Show();
        }
    }
}
