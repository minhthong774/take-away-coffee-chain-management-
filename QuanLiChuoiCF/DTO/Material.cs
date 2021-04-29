using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiChuoiCF.DTO
{
    public class Material
    {
        public Material() { }

        public Material(string iDMaterial, string iDInfoOfMaterial, int amount, int amountLeft, DateTime dateAdded, DateTime expiryDate)
        {
            this.IDMaterial = iDMaterial;
            this.IDInfoOfMaterial = iDInfoOfMaterial;
            this.Amount = amount;
            this.AmountLeft = amountLeft;
            this.DateAdded = dateAdded;
            this.ExpiryDate = expiryDate;
        }

        public Material(DataRow row)
        {
            this.IDMaterial = row["IDMaterial"].ToString().Trim();
            this.IDInfoOfMaterial = row["IDInfoOfMaterial"].ToString().Trim();
            this.Amount = (int)row["Amount"];
            this.AmountLeft = (int)row["AmountLeft"];
            this.DateAdded = (DateTime)row["DateAdded"];
            this.ExpiryDate = (DateTime)row["ExpiryDate"];
        }

        private string iDMaterial;
        private string iDInfoOfMaterial;
        private int amount;
        private int amountLeft;
        private DateTime dateAdded;
        private DateTime expiryDate;

        public string IDMaterial { get => iDMaterial; set => iDMaterial = value; }
        public string IDInfoOfMaterial { get => iDInfoOfMaterial; set => iDInfoOfMaterial = value; }
        public int Amount { get => amount; set => amount = value; }
        public int AmountLeft { get => amountLeft; set => amountLeft = value; }
        public DateTime DateAdded { get => dateAdded; set => dateAdded = value; }
        public DateTime ExpiryDate { get => expiryDate; set => expiryDate = value; }
    }
}
