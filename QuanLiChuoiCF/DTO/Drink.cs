using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiChuoiCF.DTO
{
    public  class Drink
    {
        private Drink(string iD,string name, int price, int iDStatus = 1)
        {
            this.ID = iD;
            this.Name = name;
            this.Price = price;
            this.IDStatus = iDStatus;
        }

        public Drink() { }
      
        public Drink(DataRow row )   
        {
            this.ID = (row["IDDrink"].ToString()).Trim();
            this.Name = row["name"].ToString().Trim();
            this.Price = (int)float.Parse(row["price"].ToString());
            this.iDStatus = (Byte)row["IDStatus"];
        }
        public string ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public int IDStatus { get => iDStatus; set => iDStatus = value; }

        private string iD;
        private string name;
        private int price;
        private int iDStatus;
    }
}
