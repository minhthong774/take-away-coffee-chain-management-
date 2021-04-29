using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiChuoiCF.DTO
{
    public class DetailOfBillExport
    {
        public DetailOfBillExport() { }

        public DetailOfBillExport(string iDBillExport, string iDMaterial, int count)
        {
            this.IDBillExport = iDBillExport;
            this.IDMaterial = iDMaterial;
            this.Count = count;
        }

        public DetailOfBillExport(DataRow row)
        {
            this.IDBillExport = (row["IDBillExport"].ToString()).Trim();
            this.IDMaterial = (row["IDMaterial"].ToString()).Trim();
            this.Count = (int)row["Count"];
        }

        private string iDBillExport;
        private string iDMaterial;
        private int count;

        public string IDBillExport { get => iDBillExport; set => iDBillExport = value; }
        public string IDMaterial { get => iDMaterial; set => iDMaterial = value; }
        public int Count { get => count; set => count = value; }
    }
}
