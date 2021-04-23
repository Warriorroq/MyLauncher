using System.Windows.Forms;
namespace Launcher
{
    public class Account
    {
        public string userName;
        public string password;
        public Account(string Name, string password)
        {
            userName = Name;
            this.password = ProtectString.Encode(password);
        }
        public override bool Equals(object obj)
        {
            return userName.Equals(obj);
        }
    }
}
