using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLiChuoiCF.DTO;

namespace QuanLiChuoiCF.DAO
{
    class DetailOfBillExportDAO
    {
        private static DetailOfBillExportDAO instance;
        public static DetailOfBillExportDAO Instance
        {
            get { if (instance == null) instance = new DetailOfBillExportDAO(); return instance; }
            private set { instance = value; }
        }
        private DetailOfBillExportDAO() { }

        public List<DetailOfBillExport> GetDetailOfBillExports()
        {
            List<DetailOfBillExport> detailOfBillExports = new List<DetailOfBillExport>();
            string query = "USP_GetDetailOfBillExport";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                detailOfBillExports.Add(new DetailOfBillExport(item));
            }
            return detailOfBillExports;
        }

        public List<DetailOfBillExport> GetDetailOfBillExports(string iDBillExport)
        {
            List<DetailOfBillExport> detailOfBillExports = new List<DetailOfBillExport>();
            string query = "USP_GetDetailOfBillExports @id";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { iDBillExport });
            foreach (DataRow item in data.Rows)
            {
                detailOfBillExports.Add(new DetailOfBillExport(item));
            }
            return detailOfBillExports;
        }

        public bool AddDetailOfBillExport(string IDBillExport, string IDMaterial, int count)
        {
            string query = string.Format("insert dbo.DetailOfBillExport(IDBillExport, IDMaterial, Count) values ('{0}','{1}',{2})", IDBillExport, IDMaterial, count);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool UpdateDetailOfBillExport(string IDBillExport, string IDMaterial, int count)
        {
            string query = string.Format("update dbo.DetailOfBillExport set Count = {2} where IDBillExport = '{0}' and IDMaterial = '{1}'", IDBillExport, IDMaterial, count);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool DeleteDetailOfBillExport(string IDBillExport, string IDMaterial)
        {
            string query = string.Format("delete dbo.DetailOfBillExport where IDBillExport = '{0}' and IDMaterial = '{1}'", IDBillExport, IDMaterial);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
}
}
