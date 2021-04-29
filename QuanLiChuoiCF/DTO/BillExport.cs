using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiChuoiCF.DTO
{
    public class BillExport
    {
        public BillExport() { }
        private BillExport(string iDBillExport, string iDBranch, DateTime date)
        {
            this.IDBillExport = iDBillExport;
            this.IDBranch = iDBranch;
            this.Date = date;
        }

        public BillExport(DataRow row)
        {
            this.IDBillExport = (row["IDBillExport"].ToString()).Trim();
            this.IDBranch = (row["IDBranch"].ToString()).Trim();
            this.Date = (DateTime)row["Date"];
        }

        private string iDBillExport;
        private string iDBranch;
        private DateTime date;

        public string IDBillExport { get => iDBillExport; set => iDBillExport = value; }
        public DateTime Date { get => date; set => date = value; }
        public string IDBranch { get => iDBranch; set => iDBranch = value; }
    }
}
