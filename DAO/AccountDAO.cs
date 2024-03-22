using CoffeeShopManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManager.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }
        private AccountDAO() { }

        public bool Login(string username, string password)
        {
            string query = "EXEC User_login @userName , @passWord";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, password });

            return result.Rows.Count > 0;
        }
        public bool UpdateAccountInfo(string username, string displayName, string password, string newPassword)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec UpdateAccount @userName , @displayName , @passWord , @newPassword ", new object[] { username, displayName, password, newPassword });
            return result > 0;
        }
        public DataTable GetListAccount()
        {
            return DataProvider.Instance.ExecuteQuery("select userName,displayName,type from dbo.Account");
        }
        public Account GetAccountByUsername(string userName)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Account WHERE userName ='" + userName + "'");
            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }
            return null;
        }
        public Boolean InsertAccountAdmin(string userName, string displayName, int type)
        {
            string query = string.Format("INSERT dbo.Account(userName , displayName , type)VALUES(N'{0}',N'{1}', {2})", userName, displayName, type);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public Boolean UpdateAccountAdmin(string userName, string displayName, int type)
        {
            string query = string.Format("UPDATE dbo.Account SET  displayName=N'{0}', type = {1} where userName =N'{2}'", displayName, type, userName);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public Boolean DeleteAccountAdmin(string userName)
        {
            string query = string.Format("DELETE FROM dbo.Account WHERE userName =N'{0}'", userName);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public Boolean resetPassword(string userName)
        {
            string query = string.Format("UPDATE dbo.Account SET passWord = N'0' WHERE userName =N'{0}'", userName);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public int checkAccountExist(string userName)
        {
            string query = string.Format(" SELECT COUNT(*) FROM dbo.Account WHERE userName = N'{0}'", userName);
            int result = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            return result;
        }
    }
}
