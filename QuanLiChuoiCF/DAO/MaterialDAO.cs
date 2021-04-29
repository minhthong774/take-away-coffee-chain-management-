using QuanLiChuoiCF.DTO;
using System.Collections.Generic;
using System.Data;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiChuoiCF.DAO
{
    class MaterialDAO
    {
        private static MaterialDAO instance;
        public static MaterialDAO Instance
        {
            get { if (instance == null) instance = new MaterialDAO(); return instance; }
            private set { instance = value; }
        }

        public List<Material> GetMaterials()
        {
            List<Material> materials = new List<Material>();
            string query = "select * from dbo.Material ORDER BY IDMaterial";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                materials.Add(new Material(item));
            }
            return materials;
        }

        public bool AddMaterial(string IDMaterial, string IDInfoOfMaterial, int amount, int amountLeft, DateTime dateAdded, DateTime expiryDate)
        {
            DateTime myDateTime1 = dateAdded;
            string dateAddedConverted = myDateTime1.ToString("yyyy-MM-dd");
            DateTime myDateTime2 = expiryDate;
            string expiryDateConverted = myDateTime2.ToString("yyyy-MM-dd");
            string query = string.Format("insert dbo.Material(IDMaterial,IDInfoOfMaterial, Amount, AmountLeft, DateAdded, ExpiryDate) values('{0}', '{1}', {2}, {3}, '{4}', '{5}')",IDMaterial, IDInfoOfMaterial, amount, amountLeft, dateAddedConverted, expiryDateConverted);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool UpdateMaterial(string IDMaterial, string IDInfoOfMaterial, int amount, int amountLeft, DateTime dateAdded, DateTime expiryDate)
        {
            DateTime myDateTime1 = dateAdded;
            string dateAddedConverted = myDateTime1.ToString("yyyy-MM-dd");
            DateTime myDateTime2 = expiryDate;
            string expiryDateConverted = myDateTime2.ToString("yyyy-MM-dd");
            string query = string.Format("update dbo.Material set IDInfoOfMaterial = '{1}', Amount = {2}, AmountLeft = {3}, DateAdded = '{4}', ExpiryDate = '{5}' where IDMaterial = '{0}'", IDMaterial, IDInfoOfMaterial, amount, amountLeft, dateAddedConverted, expiryDateConverted);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool DeleteMaterial(string IDMaterial)
        {
            string query = string.Format("delete dbo.Material where IDMaterial = '{0}'", IDMaterial);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public Material GetMaterial(string IDMaterial)
        {
            string query = string.Format("select * from dbo.Material where IDMaterial = '{0}'",IDMaterial);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count > 0)
            {
                return new Material(data.Rows[0]);
            }
            return null;
        }

    }
}
