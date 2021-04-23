using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Launcher
{
    public class GameManager
    {
        public string path;
        public DirectoryInfo[] gamesFolder;
        public GameManager()
        {
            path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).Replace('\\', '/').Remove(0, 6);
            gamesFolder = new DirectoryInfo(@$"{path}/Games").GetDirectories();
        }
        public List<Button> CreateGameEnterBtns()
        {
            List<Button> buttons = new List<Button>();
            for (int i = 0; i < gamesFolder.Length; i++)
            {
                var name = gamesFolder[i].Name;
                var game = gamesFolder[i].GetFiles($"{name}.*")[0];
                var btn = new Button()
                {
                    Width = 100,
                    Height = 60,
                    Location = new Point(60, i * 120 + 60),
                    Text = game.Name,
                };
                btn.Click += ((s, e) => Process.Start(game.FullName));
                buttons.Add(btn);
            }
            return buttons;
        }
        public void CreateAccountDirectory(Account account)
        {
            Directory.CreateDirectory($"{path}/{account.userName}");
        }
    }
}