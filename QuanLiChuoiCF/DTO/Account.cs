using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiChuoiCF.DTO
{
    public class Account
    {
        private Account(string username, string iDEmployee, string password, int iDTypeAccount = 1, int iDStatus = 0)
        {
            this.Username = username;
            this.IDEmployee = iDEmployee;
            this.Password = password;
            this.IDTypeAccount = iDTypeAccount;
            this.IDStatus = iDStatus;
        }

        public Account() { }

        public Account(DataRow row)
        {
            this.Username = ((string)row["Username"]).Trim();
            this.IDEmployee = ((string)row["IDEmployee"]).Trim();
            this.Password = ((string)row["Password"]).Trim(); ;
            this.IDTypeAccount = (Byte)row["IDTypeAccount"];
            this.IDStatus = (Byte)row["IDStatus"];
        }

        private string username;
        private string iDEmployee;
        private string password;
        private int iDTypeAccount;
        private int iDStatus;

        public string Username { get => username; set => username = value; }
        public string IDEmployee { get => iDEmployee; set => iDEmployee = value; }
        public string Password { get => password; set => password = value; }
        public int IDTypeAccount { get => iDTypeAccount; set => iDTypeAccount = value; }
        public int IDStatus { get => iDStatus; set => iDStatus = value; }
    }
}
