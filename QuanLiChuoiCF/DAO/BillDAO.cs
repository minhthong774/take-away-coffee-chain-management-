using QuanLiChuoiCF.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiChuoiCF.DAO
{
    class BillDAO
    {
        private static BillDAO instance;
        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return instance; }
            private set { instance = value; }
        }

        private BillDAO() { }

        public List<Bill> GetBills()
        {
            List<Bill> bills = new List<Bill>();
            string query = "USP_GetBill";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                bills.Add(new Bill(item));
            }

            return bills;
        }

        public bool AddBill(string IDBill, string IDbranch, DateTime dateCheckIn)
        {
            DateTime myDateTime = dateCheckIn;
            string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd");
            string query = string.Format("insert dbo.Bill(IDBill, IDBranch, DateCheckIn) values ('{0}', '{1}', '{2}')", IDBill, IDbranch, sqlFormattedDate);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool UpdateBill(string IDBill, string IDbranch, DateTime dateCheckIn)
        {
            DateTime myDateTime = dateCheckIn;
            string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd");
            string query = string.Format("update dbo.Bill set IDBranch = '{1}', DateCheckIn = '{2}' where IDBill = '{0}'", IDBill, IDbranch, sqlFormattedDate);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool DeleteBill(string IDBill)
        {
            string query = string.Format("delete dbo.Bill where IDBill = '{0}'", IDBill);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public List<Bill> GetBillsByBranch(string IDBranch)
        {
            List<Bill> bills = new List<Bill>();
            string query = "USP_GetBilsByBranch @id" ;
            DataTable data = DataProvider.Instance.ExecuteQuery(query,new object[] { IDBranch });
            foreach (DataRow item in data.Rows)
            {
                bills.Add(new Bill(item));
            }

            return bills;
        }
        /// <summary>
        ///Sao lai IDBranch maf truyen vao laf IDBill
        /// </summary>
        /// <param name="IDBill"></param>
        /// <returns></returns>
        public Bill GetBill(string IDBill)
        {
            string query = string.Format("select * from dbo.Bill where IDBranch = '{0}'", IDBill);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count > 0)
                return new Bill(data.Rows[0]);
            return null;
        }

    }
}
