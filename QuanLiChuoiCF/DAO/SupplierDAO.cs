using QuanLiChuoiCF.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiChuoiCF.DAO
{
    class SupplierDAO
    {
        private static SupplierDAO instance;

        SupplierDAO() { }

        internal static SupplierDAO Instance 
        {
            get { if (instance == null) instance = new SupplierDAO(); return instance; }
            private set => instance = value; 
        }
        public List<Supplier> GetSuppliers()
        {
            List<Supplier> bills = new List<Supplier>();
            string query = "USP_GetSuppliers";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                bills.Add(new Supplier(item));
            }

            return bills;
        }
        public bool AddSupplier(string IDSupplier, string Name,string Address,int iDStatus)
        {
         
            string query = string.Format("insert dbo.Supplier(IDSupplier, Name, Address, IDStatus) values ('{0}', N'{1}', N'{2}', {3})", IDSupplier, Name, Address, iDStatus);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        public bool UpdateSupplier(string idOSupplier, string Name, string Address, int iDStatus)
        {
            string query = string.Format("update dbo.Supplier set Name = N'{1}', Address = N'{2}', IDStatus = {3} where IDSupplier = '{0}'", idOSupplier, Name, Address, iDStatus);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        public bool DeleteSupplier(string IDSuplier)
        {
            string query = string.Format("delete dbo.Supplier where IDSupplier = '{0}'", IDSuplier);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public string GetNameByID(string iD)
        {
            string query = "USP_GetNameByIDSupplier @id";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { iD});

            if (data.Rows.Count > 0)
            {
                return data.Rows[0]["Name"].ToString();
            }

            return null;
        }
    }
}
