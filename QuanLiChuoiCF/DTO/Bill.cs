using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiChuoiCF.DTO
{
    public class Bill
    {
        public Bill(string idBill,string iDbranch, DateTime dateCheckIn)
        {
            this.IDBill = idBill;
            this.IDBranch = iDbranch;
            this.DateCheckIn = dateCheckIn;
        }
        public Bill( DataRow row)
        {
            this.IDBill = ((string)row["IDBill"]).Trim();
            this.IDBranch = ((string)row["IDbranch"]).Trim();
            this.DateCheckIn = (DateTime)row["DateCheckIn"];
        }

        public Bill() { }

        private string iDBill;
        private string iDBranch;
        private DateTime dateCheckIn;

        public string IDBill { get => iDBill; set => iDBill = value; }
        public string IDBranch { get => iDBranch; set => iDBranch = value; }
        public DateTime DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
    }
}
