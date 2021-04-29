using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLiChuoiCF.DTO
{
    public class Supplier
    {
        public Supplier() { }

        private Supplier(string iDSupplier, string name, string address, int iDStatus)
        {
            this.IDSupplier = iDSupplier;
            this.Name = name;
            this.Address = address;
            this.IDStatus = iDStatus;
        }

        public Supplier(DataRow row)
        {
            this.IDSupplier = row["IDSupplier"].ToString().Trim();
            this.Name = row["Name"].ToString().Trim();
            this.Address = row["Address"].ToString().Trim();
            this.IDStatus = (Byte)row["IDStatus"];
        }

        private string iDSupplier;
        private string name;
        private string address;
        private int iDStatus;

        public string IDSupplier { get => iDSupplier; set => iDSupplier = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public int IDStatus { get => iDStatus; set => iDStatus = value; }
    }
}
