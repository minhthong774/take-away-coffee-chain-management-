using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLiChuoiCF.DTO
{
    public class FullTimeEmployeeManagement
    {
        public FullTimeEmployeeManagement(string iDEmployee, DateTime dateOff)
        {
            this.IDEmployee = iDEmployee;
            this.DateOff = dateOff;
        }

        public FullTimeEmployeeManagement(DataRow row)
        {
            this.IDEmployee = row["IDEmployee"].ToString();
            this.DateOff = (DateTime)row["DateOff"];
        }

        private string iDEmployee;
        private DateTime dateOff;

        public string IDEmployee { get => iDEmployee; set => iDEmployee = value; }
        public DateTime DateOff { get => dateOff; set => dateOff = value; }
    }
}
