using QuanLiChuoiCF.DAO;
using QuanLiChuoiCF.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiChuoiCF
{

    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
            printdoc1.PrintPage += new PrintPageEventHandler(printdoc1_PrintPage);
            LoadAndPrepareBeforePrinting();
        }
        private void LoadAndPrepareBeforePrinting()
        {
            string query = "";
            DataTable data = new DataTable();
            string lastIDBill = "";
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
            List<DetailOfBill> detail = DetailOfBillDAO.Instance.GetDetailOfBills(lastIDBill);
            int totalAmount = 0;
            foreach(DetailOfBill item in detail)
            {
                query = "Select dbo.Drink.name as 'Name of drink',dbo.DetailOfBill.Count, dbo.Drink.Price from dbo.DetailOfBill,dbo.drink where  IDbill='" + lastIDBill+"' and drink.IDDrink='"+item.IDDrink+ "' and Drink.IDDrink=DetailOfBill.IDDrink ORDER BY IDBill, DetailOfBill.IDDrink";
                data.Merge(DataProvider.Instance.ExecuteQuery(query));
                totalAmount += item.Count * DrinkDAO.Instance.GetDrink(item.IDDrink).Price;

            }
            
            lb_Payment_Totalprice.Text = totalAmount.ToString();
            dtgvBill.DataSource = data;
            lb_Time.Text = DateTime.Now.ToString();
        }
        //Rest of the code

        Bitmap MemoryImage;
        PrintDocument printdoc1 = new PrintDocument();
        private Panel pannel = null;
        public void GetPrintArea(Panel pnl)
        {
            MemoryImage = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(MemoryImage, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            if (MemoryImage != null)
            {
                e.Graphics.DrawImage(MemoryImage, 0, 0);
                base.OnPaint(e);
            }
        }
        void printdoc1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(MemoryImage, (pagearea.Width / 2) - (this.panel1.Width / 2), this.panel1.Location.Y);
        }
        public void Print(Panel pnl)
        {
            pannel = pnl;
            GetPrintArea(pnl);
            printdoc1.Print();
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Print(this.panel4);
            this.Close();
        }
    }
}
