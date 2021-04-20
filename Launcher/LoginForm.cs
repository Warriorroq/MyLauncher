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
        private Form _mainMenu;
        public LoginForm()
        {
            InitializeComponent();
            _mainMenu = new MainMenu(this);
        }
        private void sumbitRegistration_Click(object sender, EventArgs e)
        {
            Enter();
        }
        private void Enter()
        {
            Hide();
            _mainMenu.Show();
        }
        private void login_TextChanged(object sender, EventArgs e)
        {
            login.Text = string.Empty;
        }
        private void password_TextChanged(object sender, EventArgs e)
        {
            password.Text = string.Empty;
        }
    }
}
