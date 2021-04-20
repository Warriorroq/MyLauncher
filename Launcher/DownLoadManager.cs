using System;
using System.IO;

namespace Launcher
{
    public class DownLoadManager
    {
        public string path;
        public DirectoryInfo[] gamesFolder;
        public DownLoadManager()
        {
            path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).Replace('\\', '/').Remove(0, 6);
            gamesFolder = new DirectoryInfo(@$"{path}/Games").GetDirectories();
        }
    }
}