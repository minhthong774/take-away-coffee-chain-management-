using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiChuoiCF.DTO
{
    public class DetailOfBill
    {
        public DetailOfBill() { }

        public DetailOfBill(string iDBill, string iDDrink, int count)
        {
            this.IDBill = iDBill;
            this.IDDrink = iDDrink;
            this.Count = count;
        }
        
        public DetailOfBill(DataRow row)
        {
            this.IDBill = (row["iDBill"].ToString()).Trim();
            this.IDDrink = (row["IDDrink"].ToString()).Trim();
            this.Count = (int)row["count"];
        }

        private string iDBill;
        private string iDDrink;
        private int count;

        public int Count { get => count; set => count = value; }
        public string IDBill { get => iDBill; set => iDBill = value; }
        public string IDDrink { get => iDDrink; set => iDDrink = value; }
    }
}
