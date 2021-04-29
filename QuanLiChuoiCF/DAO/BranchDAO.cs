using QuanLiChuoiCF.DTO;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiChuoiCF.DAO
{
    class BranchDAO
    {
        private static BranchDAO instance;
        public static BranchDAO Instance
        {
            get { if (instance == null) instance = new BranchDAO(); return instance; }
            private set { instance = value; }
        }
        private BranchDAO() { }

        public List<Branch> GetBranches()
        {
            List<Branch> branches = new List<Branch>();

            string query = "select * from Branch ORDER BY IDBranch";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach(DataRow item in data.Rows)
            {
                branches.Add(new Branch(item));
            }

            return branches;
        }

        public bool AddBranch(string branchId, string branchName, string manager, int iDStatus)
        {
            string query = string.Format("insert dbo.Branch(IDBranch, Name, Manager, IDStatus)values(N'{0}', N'{1}', N'{2}', {3})", branchId, branchName, manager, iDStatus);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool UpdateBranch(string branchId, string branchName, string manager, int iDStatus)
        {
            string query = string.Format("update dbo.Branch set Name = N'{1}', manager = N'{2}', IDStatus = {3} where IDBranch = '{0}'", branchId, branchName, manager, iDStatus);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool DeleteBranch(string branchId)
        {
            string query = string.Format("delete dbo.Branch where IDBranch = '{0}'", branchId);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public string GetNameByID(string iD)
        {
            string query = string.Format("select Name from Branch where IDBranch = '{0}'", iD);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count > 0)
            {
                return data.Rows[0]["Name"].ToString();
            }
            return null;
        }

    }
}
