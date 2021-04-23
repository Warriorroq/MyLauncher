using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Launcher
{
    public class AccountReader
    {
        private List<Account> _accounts;
        public AccountReader()
        {
            _accounts = new List<Account>();
        }
        public void Add(Account account)
        {
            if(FindAccount(account.userName) is null)
                _accounts.Add(account);
        }
        public void CreateJson()
        {
            var json = JsonConvert.SerializeObject(_accounts, Formatting.Indented);
            File.WriteAllText($"accounts.json", json);
        }
        public void ReadAccountsJson()
        {
            _accounts = JsonConvert.DeserializeObject<List<Account>>(File.ReadAllText($"accounts.json"));
        }
        public Account FindAccount(string accountName)
        {
            foreach (var acc in _accounts)
            {
                if (acc.Equals(accountName))
                {
                    return acc;
                }
            }
            return null;
        }
    }
}
