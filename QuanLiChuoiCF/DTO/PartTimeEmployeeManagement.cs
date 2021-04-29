using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLiChuoiCF.DTO
{
    public class PartTimeEmployeeManagement
    {
        private PartTimeEmployeeManagement(string iDEmplyee, DateTime dateWork)
        {
            this.IDEmployee = iDEmplyee;
            this.DateWork = dateWork;
        }

        public PartTimeEmployeeManagement(DataRow row)
        {
            this.IDEmployee = row["IDEmployee"].ToString();
            this.DateWork = (DateTime)row["DateWork"];
        }

        private string iDEmplyee;
        private DateTime DateWork;

        public string IDEmployee { get => iDEmplyee; set => iDEmplyee = value; }
        public DateTime DateWork1 { get => DateWork; set => DateWork = value; }
    }
}
