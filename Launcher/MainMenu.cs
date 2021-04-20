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
        private DownLoadManager _loadManager;
        public MainMenu(Form loginForm)
        {
            _loginForm = loginForm;
            _loadManager = new DownLoadManager();
            InitializeComponent();
            CreateGameEnterBtn();
        }
        private void CreateGameEnterBtn()
        {
            for (int i = 0; i < _loadManager.gamesFolder.Length; i++)
            {
                var name = _loadManager.gamesFolder[i].Name;
                var game = _loadManager.gamesFolder[i].GetFiles($"{name}.*")[0];
                var btn = new Button()
                {
                    Width = 100,
                    Height = 60,
                    Location = new Point(60, i * 120 + 60),
                    Text = game.Name,
                };
                btn.Click += ((s, e) => Process.Start(game.FullName));
                Controls.Add(btn);
            }
        }
    }
}
