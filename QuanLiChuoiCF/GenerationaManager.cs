using QuanLiChuoiCF.DAO;
using QuanLiChuoiCF.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLiChuoiCF
{
    public partial class fTableManager : Form
    {
        private static List<Drink> drinks;
        private static int totalPrice;
        public static List<Drink> searchedDrinks = new List<Drink>();
        List<Drink> drinksTemp = new List<Drink>();
        public static List<Drink> Drinks { get => drinks; set => drinks = value; }
        public static int TotalPrice { get => totalPrice; set => totalPrice = value; }

        public fTableManager()
        {
            InitializeComponent();
            LoadDrink();
            searchedDrinks = Drinks;
            cbb_Drink_SearchBy.Items.Add("ID");
            cbb_Drink_SearchBy.Items.Add("Drink Name");
            cbb_Drink_SearchBy.Items.Add("Price");
            cbb_Drink_SearchBy.SelectedItem = cbb_Drink_SearchBy.Items[0];

            cbb_Drink_SortBy.Items.Add("ID");
            cbb_Drink_SortBy.Items.Add("Drink Name");
            cbb_Drink_SortBy.Items.Add("Price");
            cbb_Drink_SortBy.SelectedItem = cbb_Drink_SearchBy.Items[0];
            
        }
        #region Method
        public string getIDIncrea(string ID)
        {
            string iD_Temp;
            string numericID;
            int num;
            num = int.Parse(ID.Substring(2));
            if (num < 9)
            {
                numericID = ID.Substring(3);
                iD_Temp = ID.Substring(0, 3);
            }
            else
            {
                numericID = ID.Substring(2);
                iD_Temp = ID.Substring(0, 2);
            }
            num++;
            iD_Temp = String.Concat(iD_Temp, num);
            return iD_Temp;
        }
        void LoadDrink()
        {
            flpDrink.Controls.Clear();
            cbb_addDrink.Items.Clear();
            Drinks = DrinkDAO.Instance.GetDrinks();
            foreach (Drink item in Drinks)
            {
                Button btn = new Button()
                {
                    Width = DrinkDAO.TableWidth,
                    Height = DrinkDAO.TableHeight
                };
                btn.Text = item.Name + Environment.NewLine+ item.Price;
                btn.Click += btn_Click;
                btn.Tag = item;
                flpDrink.Controls.Add(btn);
                flpDrink.FlowDirection = FlowDirection.LeftToRight;
                cbb_addDrink.Items.Add(item.ID + "-" +item.Name);
            }
        }

        #endregion
        #region events
        void btn_Click(object sender, EventArgs e)
        {
            string drinkID = ((sender as Button).Tag as Drink).ID;
            foreach (Drink item in Drinks)
            {
                if(item.ID == drinkID)
                {
                    cbb_addDrink.SelectedItem = item.ID + "-" +item.Name;
                    break;
                }
            }
        }
        void btn_AddDrink_click(object sender, EventArgs e)
        {
            string name = cbb_addDrink.Text;
            if (name == "") return;
            int count = Convert.ToInt32(numericUpDown1.Value);
            numericUpDown1.Value = 1;
            int price = 0, totalPriceRow;

            //get price from drinks list
            foreach (Drink item in Drinks)
            {
                if (item.Name == name)
                {
                    price = item.Price;
                    break;
                }
            }
            foreach(ListViewItem item in lsvBill.Items)
            {
                if (name == item.SubItems[0].Text)
                {
                    int last_count = int.Parse(item.SubItems[1].Text);

                    if(count + last_count <= 0)
                    {
                        item.Remove();
                        return;
                    }

                    totalPriceRow = (count + last_count) * price;
                    totalPrice += count * price;

                    item.SubItems[1].Text = (count+last_count).ToString();
                    item.SubItems[2].Text = price.ToString();
                    item.SubItems[3].Text = totalPriceRow.ToString();

                    txbTotalPrice.Text = totalPrice.ToString();

                    return;
                }
                
            }

            totalPriceRow = price * count;
            ListViewItem lsvItem = new ListViewItem(name);
            lsvItem.SubItems.Add(count.ToString());
            lsvItem.SubItems.Add(price.ToString());
            lsvItem.SubItems.Add(totalPriceRow.ToString());
            totalPrice += totalPriceRow;

            lsvBill.Items.Add(lsvItem);
            txbTotalPrice.Text = totalPrice.ToString();
        }
        private void fTableManager_Load(object sender, EventArgs e)
        {

        }



        void f_UpdateDrink(object sender, EventArgs e)
        {
            LoadDrink();
        }

        void f_DeleteDrink(object sender, EventArgs e)
        {
            LoadDrink();
        }

        void f_InsertDrink(object sender, EventArgs e)
        {
            LoadDrink();
        }
        #endregion

      
        private void btnDeleteOrderClick(object sender, EventArgs e)
        {
            if(lsvBill.SelectedItems.Count > 0)
            {
                lsvBill.SelectedItems[0].Remove();
            }
        }


        private void lsvSelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvBill.SelectedItems.Count > 0)
            {
                var item = lsvBill.SelectedItems[0];
                cbb_addDrink.SelectedItem = item.SubItems[0].Text;
                numericUpDown1.Value = int.Parse(item.SubItems[1].Text);
            }
        }

        private void numericUpDown1Click(object sender, EventArgs e)
        {
            if (lsvBill.SelectedItems.Count > 0)
            {
                var item = lsvBill.SelectedItems[0];
                item.SubItems[1].Text = numericUpDown1.Value.ToString();
            }
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            string lastIDBill="";
            Bill bill = new Bill();
            List<Bill> bills = BillDAO.Instance.GetBills();
            Bill[] arr = bills.ToArray();
            if (arr.Length > 0)
            {
                lastIDBill = arr[arr.Length - 1].IDBill;
            }
            else
            {
                lastIDBill = "BI00";
            }
            lastIDBill = getIDIncrea(lastIDBill);
            //float totalPrice = float.Parse(txbTotalPrice.Text.ToString());
            string branch=this.getBrandOfAccount().IDBranch;
            
            if (BillDAO.Instance.AddBill(lastIDBill,branch ,DateTime.Now))
            {
                int count = 0;
                foreach(ListViewItem item in lsvBill.Items)
                {
                    Drink drink = DrinkDAO.Instance.GetDrink(item.SubItems[0].Text.Split('-')[0]);
                    count = Int16.Parse(item.SubItems[1].Text.ToString());
                    DetailOfBillDAO.Instance.AddDetailOfBill(lastIDBill, drink.ID, count);                 
                }
                Payment p = new Payment();
                p.ShowDialog();
                p.Close();
            }
            //Reset list view bill
            lsvBill.Items.Clear();   
           
        }
        public Branch getBrandOfAccount()
        {
            string query = "select dbo.Branch.IDBranch, name,Manager, dbo.Branch.IDStatus from dbo.Branch, dbo.Employee, dbo.Account where dbo.Employee.IDEmployee=dbo.Account.IDEmployee and dbo.Account.Username='" + fLogin.userName + "' and dbo.employee.IDbranch=dbo.branch.IDbranch";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            if (data != null)
            {
                return new Branch(data.Rows[0]);
            }
            return null;
        }



        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
       
        private void cbb_Drink_SortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbb_Drink_SortBy.Text)
            {
                case "":
                    LoadDrink();
                    break;
                case "ID":
                    searchedDrinks = searchedDrinks.OrderBy(o => o.ID).ToList();
                    LoadChangeSortAndSearchData();
                    break;
                case "Drink Name":
                    searchedDrinks = searchedDrinks.OrderBy(o => o.Name).ToList();
                    LoadChangeSortAndSearchData();
                    break;
                case "Price":
                    searchedDrinks = searchedDrinks.OrderBy(o => o.Price).ToList();
                    LoadChangeSortAndSearchData();
                    break;
            }
            
        }
     

        private void txb_Drink_Search_TextChanged(object sender, EventArgs e)
        {
            string searchingText = txb_Drink_Search.Text;
            switch (cbb_Drink_SearchBy.Text)
            {
                case "":
                    LoadDrink();
                    break;
                case "ID":
                    searchedDrinks = Drinks.FindAll(item => item.ID.Contains(searchingText));
                    LoadChangeSortAndSearchData();
                    break;
                case "Drink Name":
                    searchedDrinks = Drinks.FindAll(item => item.Name.Contains(searchingText));
                    LoadChangeSortAndSearchData();
                    break;
                case "Price":
                    searchedDrinks = Drinks.FindAll(item => item.Price.ToString().Contains(searchingText));
                    LoadChangeSortAndSearchData();
                    break;
            } 
        }
        void LoadChangeSortAndSearchData()
        {
            flpDrink.Controls.Clear();
            cbb_addDrink.Items.Clear();
            foreach (Drink item in searchedDrinks)
            {
                Button btn = new Button()
                {
                    Width = DrinkDAO.TableWidth,
                    Height = DrinkDAO.TableHeight
                };
                btn.Text = item.Name + Environment.NewLine + item.Price;
                btn.Click += btn_Click;
                btn.Tag = item;
                flpDrink.Controls.Add(btn);
                flpDrink.FlowDirection = FlowDirection.LeftToRight;
                cbb_addDrink.Items.Add(item.ID + "-" + item.Name);
            }
        }
    }
}
