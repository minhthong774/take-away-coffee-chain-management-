using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLiChuoiCF.DTO
{
    public class InforOfMaterial
    {
        public InforOfMaterial() { }

        public InforOfMaterial(string iDInfoOfMaterial, string name, int iDUnit, int price, int iDStatus = 1)
        {
            this.IDInfoOfMaterial = iDInfoOfMaterial;
            this.Name = name;
            this.IDUnit = iDUnit;
            this.Price = price;
            this.IDSupplier = iDSupplier;
            this.IDStatus = iDStatus;
        }

        public InforOfMaterial(DataRow row)
        {
            this.IDInfoOfMaterial = row["IDInfoOfMaterial"].ToString().Trim();
            this.Name = row["Name"].ToString().Trim();
            this.IDUnit = (Byte)row["IDUnit"];
            this.Price = (int)float.Parse(row["Price"].ToString());
            this.IDSupplier = row["IDSupplier"].ToString().Trim();
            this.iDStatus = (Byte)row["IDStatus"];
        }

        private string iDInfoOfMaterial;
        private string name;
        private int iDUnit;
        private int price;
        private string iDSupplier;
        private int iDStatus;

        public string IDInfoOfMaterial { get => iDInfoOfMaterial; set => iDInfoOfMaterial = value; }
        public string Name { get => name; set => name = value; }
        public int IDUnit { get => iDUnit; set => iDUnit = value; }
        public int Price { get => price; set => price = value; }
        public string IDSupplier { get => iDSupplier; set => iDSupplier = value; }
        public int IDStatus { get => iDStatus; set => iDStatus = value; }
    }
}
