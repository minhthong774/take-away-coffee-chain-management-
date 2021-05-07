using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiChuoiCF.DTO;
using System.Data;

namespace QuanLiChuoiCF.DAO
{
    class InforOfMaterialDAO
    {
        private static InforOfMaterialDAO instance;
        public static InforOfMaterialDAO Instance
        {
            get { if (instance == null) instance = new InforOfMaterialDAO(); return instance; }
            private set { instance = value; }
        }
        private InforOfMaterialDAO() { }

        public List<InforOfMaterial> GetInfoOfMaterials()
        {
            List<InforOfMaterial> infoOfMaterials = new List<InforOfMaterial>();
            string query = "USP_GetInfoOfMaterials";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                infoOfMaterials.Add(new InforOfMaterial(item));
            }

            return infoOfMaterials;
        }

        public bool AddInfoOfMaterial(string IDInfoOfMaterial, string name, int IDUnit, int price, string IDSupplier, int iDStatus)
        {
            string query = string.Format("insert InforOfMaterial(IDInfoOfMaterial, Name, IDUnit, Price, IDSupplier, IDStatus) values ('{0}',N'{1}',N'{2}',{3},'{4}', {5})", IDInfoOfMaterial, name, IDUnit, price, IDSupplier, iDStatus);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool UpdateInfoOfMaterial(string IDInfoOfMaterial, string name, int iDUnit, int price, string IDSupplier, int iDStatus)
        {
            string query = string.Format("update InforOfMaterial set Name = N'{1}', IDUnit = {2}, Price = {3}, IDSupplier = '{4}', IDStatus = {5} where IDInfoOfMaterial = '{0}'", IDInfoOfMaterial, name, iDUnit, price, IDSupplier, iDStatus);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool DeleteInfoOfMaterial(string IDInfoOfMaterial)
        {
            string query = string.Format("delete InforOfMaterial where IDInfoOfMaterial = '{0}'", IDInfoOfMaterial);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public string GetNameByID(string iD)
        {
            string query = "USP_GetNameByIDInforMaterial @id";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { iD });
            if (data.Rows.Count > 0)
            {
                return data.Rows[0]["Name"].ToString();
            }
            return null;
        }

        public InforOfMaterial GetInfoOfMaterial(string ID)
        {
            string query = "USP_GetInfoOfMaterial @id";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { ID });
            if (data.Rows.Count > 0)
            {
                return new InforOfMaterial(data.Rows[0]);
            }
            return null;
        }

    }
}
