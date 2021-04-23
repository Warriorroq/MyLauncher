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
    public partial class RegisterAccount : Form
    {
        private AccountReader _reader;
        private Form _loginForm;
        public RegisterAccount(Form login, AccountReader reader)
        {
            _reader = reader;
            _loginForm = login;
            InitializeComponent();
        }

        private void sumbitRegistration_Click(object sender, EventArgs e)
        {
            if(login.Text.Equals(string.Empty))
            {
                MessageBox.Show("nickname is empty");
                return;
            }
            else if (password.Text.Length < 3)
            {
                MessageBox.Show("password is less that 3 symbols");
                return;
            }
            _reader.Add(new Account(login.Text, password.Text));
            _reader.CreateJson();
            _loginForm.Show();
            Hide();
        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            _loginForm.Show();
            Hide();
        }

        private void login_DoubleClick(object sender, EventArgs e)
        {
            login.Text = string.Empty;
        }

        private void password_DoubleClick(object sender, EventArgs e)
        {
            password.Text = string.Empty;
        }
    }
}
