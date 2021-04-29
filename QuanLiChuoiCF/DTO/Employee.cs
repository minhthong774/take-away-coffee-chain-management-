using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiChuoiCF.DTO
{
    public class Employee
    {
        public Employee() { }

        private Employee(string firstName, string lastName, string IDEmployee, string phoneNumber, int iDSexual
            , string address, DateTime dayIn, int numberOfDayOff, int iDTypeEmployee, string IDBranch, int iDStatus)
        {
            this.IDEmployee = IDEmployee;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PhoneNumber = phoneNumber;
            this.IDSexual = iDSexual;
            this.Address = address;
            this.DayIn = dayIn;
            this.NumberOfDayOff = numberOfDayOff;
            this.IDTypeEmployee = iDTypeEmployee;
            this.IDBranch = IDBranch;
            this.IDStatus = iDStatus;
        }
        public Employee(DataRow row)
        {
            this.FirstName = ((string)row["FirstName"]).Trim();
            this.LastName = ((string)row["LastName"]).Trim();
            this.IDEmployee = ((string)row["IDEmployee"]).Trim();
            this.PhoneNumber = ((string)row["Phone_Number"]).Trim();
            this.IDSexual = (Byte)row["IDSexual"];
            this.Address = ((string)row["Address"]).Trim();
            this.DayIn = (DateTime)row["DayIn"];
            this.NumberOfDayOff = (Byte)row["NumberOfDayOff"];
            this.IDTypeEmployee = (Byte)row["IDTypeEmployee"];
            this.IDBranch = ((string)row["IDBranch"]).Trim();
            this.IDStatus = (Byte)row["IDStatus"];
        }

        private string iDEmployee;
        private string firstName;
        private string lastName;
        private string phoneNumber;
        private int iDSexual;
        private string address;
        private DateTime dayIn;
        private int numberOfDayOff;
        private int iDTypeEmployee;
        private string iDBranch;
        private int iDStatus;

        public string IDEmployee { get => iDEmployee; set => iDEmployee = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public int IDSexual { get => iDSexual; set => iDSexual = value; }
        public string Address { get => address; set => address = value; }
        public DateTime DayIn { get => dayIn; set => dayIn = value; }
        public int NumberOfDayOff { get => numberOfDayOff; set => numberOfDayOff = value; }
        public int IDTypeEmployee { get => iDTypeEmployee; set => iDTypeEmployee = value; }
        public string IDBranch { get => iDBranch; set => iDBranch = value; }
        public int IDStatus { get => iDStatus; set => iDStatus = value; }
    }
}
