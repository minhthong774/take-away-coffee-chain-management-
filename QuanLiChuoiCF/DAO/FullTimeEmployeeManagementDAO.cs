using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiChuoiCF.DTO;
using System.Data;

namespace QuanLiChuoiCF.DAO
{
    public class FullTimeEmployeeManagementDAO
    {
        private static FullTimeEmployeeManagementDAO instance;
        public static FullTimeEmployeeManagementDAO Instance
        {
            get { if (instance == null) instance = new FullTimeEmployeeManagementDAO(); return instance; }
            private set { instance = value; }
        }

        public FullTimeEmployeeManagementDAO() { }

        public List<DateOff> GetDateOffs()
        {
            List<DateOff> dateOffs = new List<DateOff>();
            string query = "USP_GetDateOffs;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow row in data.Rows)
            {
                dateOffs.Add(new DateOff(row));
            }
            return dateOffs;
        }

        public bool AddDateOff(string iDEmployee, DateTime dateOff)
        {
            string DateOff = dateOff.ToString("yyyy-MM-dd");
            string query = string.Format("insert dbo.FullTimeEmployeeManagement (IDEmployee, DateOff) values('{0}', '{1}')", iDEmployee, DateOff);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool DeleteDateOff(string iDEmployee, DateTime dateOff)
        {
            string DateOff = dateOff.ToString("yyyy-MM-dd");
            string query = string.Format("delete dbo.FullTimeEmployeeManagement where IDEmployee = '{0}' and dateOff = '{1}'", iDEmployee, DateOff);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        //public List<DateOff> GetEmployeeByDate(DateTime date)
        //{
        //    string Date = date.ToString("yyyy-MM-dd");
        //    List<DateOff> dateOffs = new List<DateOff>();
        //    string query = string.Format("select * from dbo.FullTimeEmployeeManagement where date = {0}", Date);
        //    DataTable data = DataProvider.Instance.ExecuteQuery(query);
        //    foreach (DataRow row in data.Rows)
        //    {
        //        dateOffs.Add(new DateOff(row));
        //    }
        //    return dateOffs;
        //}

        public List<DateOff> GetDateOffsByIDEmployee(string iDEmployee)
        {
            List<DateOff> dateOffs = new List<DateOff>();
            string query = "USP_GetDateOffsByIDEmployee @id";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { iDEmployee });
            foreach (DataRow row in data.Rows)
            {
                dateOffs.Add(new DateOff(row));
            }
            return dateOffs;
        }

    }
}
