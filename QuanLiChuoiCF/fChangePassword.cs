using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiChuoiCF.DAO;
using QuanLiChuoiCF.DTO;
using System.Text.RegularExpressions;

namespace QuanLiChuoiCF
{
    public partial class fChangePassword : Form
    {
        private Account account;
        public fChangePassword(Account account)
        {
            this.account = account;
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string password = txbPassword.Text;
            if(password == "")
            {
                lbNotify.Text = "NOTIFY: Password is empty";
                return;
            }
            if(password != fLogin.passWord)
            {
                lbNotify.Text = "NOTIFY: Wrong password";
                return;
            }
            string newPassword = txbNewPassword.Text;
            if(!Regex.IsMatch(newPassword, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,30}$"))
            {
                lbNotify.Text = "NOTIFY: Password is not in correct format";
                return;
            }
            string confirmNewPassword = txbConfirmNewPassword.Text;
            if(confirmNewPassword == "")
            {
                lbNotify.Text = "NOTIFY: Confirm new password is empty";
                return;
            }
            if(newPassword != confirmNewPassword)
            {
                lbNotify.Text = "NOTIFY: Confirm new password is wrong";
                return;
            }
            if (AccountDAO.Instance.ChangePassword(account.Username, newPassword))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to change Password");
            }
        }
    }
}
