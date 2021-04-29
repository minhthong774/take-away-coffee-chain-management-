using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiChuoiCF.DTO
{
    public class Branch
    {
        public Branch(string iDBranch, string nameBranch, string manager, int iDStatus)
        {
            this.IDBranch = iDBranch;
            this.Name = nameBranch;
            this.Manager = manager;
            this.IDStatus = iDStatus;
        }
        public Branch(DataRow row)
        {
            this.IDBranch = ((string)row["IDBranch"]).Trim();
            this.Name = ((string)row["Name"]).Trim();
            this.Manager = ((string)row["Manager"]).Trim();
            this.iDStatus = (Byte)row["IDStatus"];
        }

        private string iDBranch;
        private string name;
        private string manager;
        private int iDStatus;

        public string IDBranch { get => iDBranch; set => iDBranch = value; }
        public string Name { get => name; set => name = value; }
        public string Manager { get => manager; set => manager = value; }
        public int IDStatus { get => iDStatus; set => iDStatus = value; }
    }
}
