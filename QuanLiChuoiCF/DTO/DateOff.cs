using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLiChuoiCF.DTO
{
    public class DateOff
    {
        public DateOff(string iDEmployee, DateTime date)
        {
            this.IDEmployee = iDEmployee;
            this.Date = date;
        }

        public DateOff(DataRow row)
        {
            this.IDEmployee = row["IDEmployee"].ToString().Trim();
            this.date = (DateTime)row["DateOff"];
        }

        private string iDEmployee;
        private DateTime date;

        public string IDEmployee { get => iDEmployee; set => iDEmployee = value; }
        public DateTime Date { get => date; set => date = value; }
    }
}
