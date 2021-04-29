using QuanLiChuoiCF.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiChuoiCF.DAO
{
    class EmployeeDAO
    {
        private static EmployeeDAO instance;

        public static EmployeeDAO Instance {
            get { if (instance == null) instance = new EmployeeDAO(); return instance; }
            private set { instance = value; }
        }

        EmployeeDAO() {}

        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            string query = "select * from dbo.Employee ORDER BY IDEmployee";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                employees.Add(new Employee(item));
            }
            return employees;
        }

        public bool AddEmployee(string firstName, string lastName, string IDEmployee, string phoneNumber, int iDSexual
            , string address, DateTime dayIn, int numberOfDayOff, int iDTypeEmployee, string IDBranch, int iDStatus)
        {
            DateTime myDateTime = dayIn;
            string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd");
            string query = string.Format("insert dbo.Employee(FirstName, LastName,IDEmployee, Phone_Number, " +
                "IDSexual, Address, DayIn, NumberOfDayOff, IDTypeEmployee, IDBranch, iDStatus)" +
                "values(N'{0}',N'{1}',N'{2}',{3}, {4}, N'{5}','{6}', {7}, {8},'{9}', {10})",
                firstName, lastName, IDEmployee, phoneNumber, iDSexual, address, sqlFormattedDate, numberOfDayOff, iDTypeEmployee, IDBranch, iDStatus);
            return DataProvider.Instance.ExecuteNonQuery(query)>0;
        }

        public bool UpdateEmployee(string firstName, string lastName, string IDEmployee, string phoneNumber, int iDSexual
            , string address, DateTime dayIn, int numberOfDayOff, int iDTypeEmployee, string IDBranch, int iDStatus)
        {
            DateTime myDateTime = dayIn;
            string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd");
            string query = string.Format("update dbo.Employee set FirstName = N'{0}', LastName = N'{1}', Phone_Number = {3}, IDSexual = {4}, Address = N'{5}', DayIn = '{6}', NumberOfDayOff = {7}, IDTypeEmployee = {8}, IDBranch = N'{9}', IDStatus = {10} where  IDEmployee = N'{2}'",
                 firstName, lastName, IDEmployee, phoneNumber, iDSexual, address, sqlFormattedDate, numberOfDayOff, iDTypeEmployee, IDBranch, iDStatus);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool DeleteEmployee(string IDEmployee)
        {
            string query = string.Format("delete dbo.Employee where IDEmployee = N'{0}'", IDEmployee);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public string GetNameByIDEmployee(string IDEmployee)
        {
            string query = string.Format("select firstname, lastname from dbo.Employee where IDEmployee = '{0}'", IDEmployee);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count > 0)
            {
                return data.Rows[0]["FirstName"].ToString() + data.Rows[0]["LastName"].ToString();
            }
            return null;
        }

        public Employee GetEmployee(string IDEmployee)
        {
            List<Employee> employees = new List<Employee>();
            string query = string.Format("select * from dbo.Employee where IDEmployee = '{0}'", IDEmployee);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count > 0) return new Employee(data.Rows[0]);
            return null;
        }

    }
}
