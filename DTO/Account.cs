using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManager.DTO
{
    public class Account
    {
        private string userName;
        private string passWord;
        private string displayName;
        private int type;

        public Account(string userName, string passWord, string displayName, int type)
        {
            UserName = userName;
            PassWord = passWord;
            DisplayName = displayName;
            Type = type;
            
        }

        public Account(DataRow row)
        {
            UserName = row["userName"].ToString();
            PassWord = row["passWord"].ToString();
            DisplayName = row["displayName"].ToString();
            Type = (int)row["type"];
        }

        public string UserName { get => userName; set => userName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public string DisplayName { get => displayName; set => displayName = value; }
        public int Type { get => type; set => type = value; }
    }
}
