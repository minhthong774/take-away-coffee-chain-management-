using QuanLiChuoiCF.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLiChuoiCF.DAO
{
    class DrinkDAO
    {
        public static int TableWidth =100;
        public static int TableHeight =100;

        private static DrinkDAO instance;
        public static DrinkDAO Instance
        {
            get
            {
                if (instance == null) instance = new DrinkDAO();
                return DrinkDAO.instance;
            }
            private set
            {
                DrinkDAO.instance = value;
            }
        }

        private DrinkDAO() { }
        public List<Drink> GetDrinks()
        {
            List<Drink> Drinks = new List<Drink>();
            string query = "USP_GetDrink";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach(DataRow item in data.Rows)
            {
                Drink drink = new Drink(item);
                Drinks.Add(drink);
            }

            return Drinks;
        }

        public bool AddDrink(string id,string name,  float price, int iDStatus)
        {
            string query = string.Format("insert dbo.Drink(IDDrink,Name,Price,IDStatus) values ('{0}', N'{1}', {2}, {3})", id, name, price, iDStatus);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateDrink(string id, string name, float price, int iDStatus)
        {
            string query = string.Format("update dbo.Drink SET name = N'{1}', price = {2}, IDStatus = {3} where IDDrink = N'{0}'", id, name, price, iDStatus);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteDrink(string id)
        {
            DetailOfBillDAO.Instance.DeleteBillInfoByDrinkID(id);
            string query = "delete dbo.Drink where IDDrink = N'" + id + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public Drink GetDrink(string ID)
        {
            string query = "USP_GetDrinkByID @id";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { ID });

            if (data.Rows.Count > 0)
            {
                return new Drink(data.Rows[0]);
            }

            return null;
        }

    }

}

