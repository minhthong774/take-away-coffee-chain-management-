using QuanLiChuoiCF.DTO;
using System.Collections.Generic;
using System.Data;

namespace QuanLiChuoiCF.DAO
{
    public class DetailOfBillDAO
    {
        private static DetailOfBillDAO instance;
            
        public static DetailOfBillDAO Instance
        {
            get
            {
                if (instance == null) instance = new DetailOfBillDAO(); return instance;
            }
            private set => instance = value; 
        } 
        private DetailOfBillDAO() { }
        
        public List<DetailOfBill> GetDetailOfBills(string id)
        {
            List<DetailOfBill> listDetailOfBill = new List<DetailOfBill>();
            DataTable data = DataProvider.Instance.ExecuteQuery("Select *from dbo.DetailOfBill where  IDbill='" + id + "' ORDER BY IDBill, IDDrink");
            foreach(DataRow item in data.Rows)
            {
                DetailOfBill detail = new DetailOfBill(item);
                listDetailOfBill.Add(detail);
            }
            return listDetailOfBill;
        }

        //Nguy Hiem Khong Nen Dung
        public bool DeleteBillInfoByDrinkID(string id)
        {
            return DataProvider.Instance.ExecuteNonQuery("delete dbo.DetailOfBill where IDDrink = N'" + id +"'")>0;
        }

        public bool AddDetailOfBill(string IDBill, string IDDrink, int count)
        {
            string query = string.Format("insert dbo.DetailOfBill(IDBill, IDDrink, Count) values ('{0}', '{1}', {2})", IDBill, IDDrink, count);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool UpdateDetailOfBill(string IDBill, string IDDrink, int count)
        {
            string query = string.Format("update dbo.DetailOfBill set Count = {2}) where IDBill = '{0}' and IDDrink = '{1}'", IDBill, IDDrink, count);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool DeleteDetailOfBill(string IDBill, string IDDrink)
        {
            string query = string.Format("delete dbo.DetailOfBill where IDBill = '{0}' and IDDrink = '{1}'", IDBill, IDDrink);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
}
}
