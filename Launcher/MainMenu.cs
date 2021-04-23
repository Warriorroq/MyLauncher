using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Launcher
{
    public partial class MainMenu : Form
    {
        private Form _loginForm;
        private GameManager _loadManager;
        private Account _account;
        public MainMenu(Form loginForm)
        {
            _loginForm = loginForm;
            _loadManager = new GameManager();
            InitializeComponent();
        }
        public void ConfirmAccount(Account account)
        {
            _account = account;
            _loadManager.CreateGameEnterBtns().ForEach(x => Controls.Add(x));
            _loadManager.CreateAccountDirectory(_account);
        }
    }
}
