using QuanLiChuoiCF.DTO;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiChuoiCF.DAO
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
        public bool Login(string userName, string passWord)
        {
            string query = "USP_Login @userName , @passWord ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord });
            return result.Rows.Count > 0;
        }

        public Account GetAccountByUsername(string username)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetAccountByUserName", new object[] { username });

            if (data!=null)
            {
                return new Account(data.Rows[0]);
            }

            return null;
        }

        public List<Account> GetAccounts()
        {
            List<Account> accounts = new List<Account>();
            string query = "USP_Account";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                accounts.Add(new Account(item));
            }
            return accounts;
        }

        public bool AddAccount(string username, string IDEmployee, string password, int type, int iDStatus = 1)
        {
            string query = string.Format("insert dbo.Account(Username, IDEmployee, Password, IDTypeAccount, IDStatus)values(N'{0}', N'{1}', N'{2}', {3}, {4})", username, IDEmployee, password, type, iDStatus);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool UpdateAccount(string username, string IDEmployee, int type, int iDStatus)
        {
            string query = string.Format("update dbo.Account set IDEmployee = '{1}', IDTypeAccount = {2}, IDStatus = {3} where Username = '{0}'", username, IDEmployee, type, iDStatus);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool DeleteAccount(string username)
        {
            string query = string.Format("delete dbo.Account where Username = N'{0}'", username);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool ChangePassword(string username, string password)
        {
            string query = string.Format("update dbo.Account set Password = N'{0}' where Username = '{1}'", password, username);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public string getBranch(string username)
        {
            string query = "USP_GetBranchByUserName @username";
            DataTable data = DataProvider.Instance.ExecuteQuery(query,new object[] { username });
            if (data.Rows.Count > 0) 
            {
                return data.Rows[0]["IDBranch"].ToString();
            }
            return null;
        }
        public Employee GetEmployeethroughUserName(string username)
        {
            string querry = "uspGetEmpolyeeByUserName @userName";
            DataTable employee = DataProvider.Instance.ExecuteQuery(querry, new object[] { username });
            if (employee.Rows.Count > 0)
            {
                return new Employee(employee.Rows[0]);
            }
            return null;
        }

    }
}
