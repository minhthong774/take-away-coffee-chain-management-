using QuanLiChuoiCF.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiChuoiCF.DTO;

namespace QuanLiChuoiCF
{
    public partial class fLogin : Form
    {
        public static String userName;
        public static String passWord;
        public static Account account;
        public static String Branch;
        public fLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            userName= txtUsername.Text;
            passWord = txtPassword.Text;

            if(Login(userName, passWord))
            {
                account = AccountDAO.Instance.GetAccountByUsername(userName);
                if(account.IDTypeAccount == 0)
                {
                    fSelectModeAdmin f = new fSelectModeAdmin();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    fTableManager f = new fTableManager();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!!!!!!");

            }

        }
        bool Login(string userName, string passWord)
        {
            return AccountDAO.Instance.Login(userName, passWord);
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát chương trình?","Thông báo", MessageBoxButtons.OKCancel)!=System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }    
        }
    }
}
