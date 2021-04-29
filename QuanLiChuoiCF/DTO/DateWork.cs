using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLiChuoiCF.DTO
{
    public class DateWork
    {
        public DateWork(string iDEmployee, DateTime date)
        {
            this.IDEmployee = iDEmployee;
            this.Date = date;
        }

        public DateWork(DataRow row)
        {
            this.IDEmployee = row["IDEmployee"].ToString().Trim();
            this.date = (DateTime)row["DateWork"];
        }

        private string iDEmployee;
        private DateTime date;

        public string IDEmployee { get => iDEmployee; set => iDEmployee = value; }
        public DateTime Date { get => date; set => date = value; }
    }
}
