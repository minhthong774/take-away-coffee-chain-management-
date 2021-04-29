using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLiChuoiCF.DTO;

namespace QuanLiChuoiCF.DAO
{
    public class PartTimeEmployeeManagementDAO
    {
        private static PartTimeEmployeeManagementDAO instance;
        public static PartTimeEmployeeManagementDAO Instance
        {
            get { if (instance == null) instance = new PartTimeEmployeeManagementDAO(); return instance; }
            private set { instance = value; }
        }

        public PartTimeEmployeeManagementDAO() { }

        public List<DateWork> GetDateWorks()
        {
            List<DateWork> dateWorks = new List<DateWork>();
            string query = "select * from dbo.PartTimeEmployeeManagement";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                dateWorks.Add(new DateWork(row));
            }
            return dateWorks;
        }

        public bool AddDateWork(string iDEmployee, DateTime dateWork)
        {
            string DateWork = dateWork.ToString("yyyy-MM-dd");
            string query = string.Format("insert dbo.PartTimeEmployeeManagement (IDEmployee, DateWork) values('{0}', '{1}')", iDEmployee, DateWork);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool DeleteDateWork(string iDEmployee, DateTime dateWork)
        {
            string DateWork = dateWork.ToString("yyyy-MM-dd");
            string query = string.Format("delete dbo.PartTimeEmployeeManagement where IDEmployee = '{0}' and DateWork = '{1}'", iDEmployee, DateWork);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        //public List<DateWork> GetEmployeeByDate(DateTime date)
        //{
        //    string Date = date.ToString("yyyy-MM-dd");
        //    List<DateWork> dateWorks = new List<DateWork>();
        //    string query = string.Format("select * from dbo.PartTimeEmployeeManagement where date = {0}", Date);
        //    DataTable data = DataProvider.Instance.ExecuteQuery(query);
        //    foreach (DataRow row in data.Rows)
        //    {
        //        dateWorks.Add(new DateWork(row));
        //    }
        //    return dateWorks;
        //}

        public List<DateWork> GetDateWorksByIDEmployee(string iDEmployee)
        {
            List<DateWork> dateWorks = new List<DateWork>();
            string query = string.Format("select * from dbo.PartTimeEmployeeManagement where IDEmployee = '{0}'", iDEmployee);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                dateWorks.Add(new DateWork(row));
            }
            return dateWorks;
        }

    }
}
