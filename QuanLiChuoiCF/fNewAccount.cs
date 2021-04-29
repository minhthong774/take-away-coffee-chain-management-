using QuanLiChuoiCF.DAO;
using QuanLiChuoiCF.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace QuanLiChuoiCF
{
    public partial class fNewAccount : Form
    {
        private List<Employee> employees = new List<Employee>();
        private List<Account> accounts = new List<Account>();
        public fNewAccount(List<Account> accounts, List<Employee> employees)
        {
            InitializeComponent();
            this.accounts = accounts;
            this.employees = employees;
            Load();
        }

        public void Load()
        {
            cbbType.Items.Add("0");
            cbbType.Items.Add("1");
            cbbType.SelectedItem = cbbType.Items[0];

            cbbEmployee.Items.Clear();
            if (employees.Count > 0)
            {
                foreach (Employee employee in employees)
                {
                    bool isHadAccount = false;
                    foreach (Account account in accounts)
                    {
                        if (account.IDEmployee == employee.IDEmployee)
                        {
                            isHadAccount = true;
                        }
                    }
                    if (!isHadAccount) cbbEmployee.Items.Add(employee.IDEmployee + "-" + EmployeeDAO.Instance.GetNameByIDEmployee(employee.IDEmployee));
                }
                cbbEmployee.SelectedItem = cbbEmployee.Items[0];
            }
        }

        private void btnOkClick(object sender, EventArgs e)
        {
            string username = txbUserName.Text;
            if(username == "")
            {
                lbNotify.Text = "NOTIFY: Username can't be empty";
                txbUserName.Focus();
                return;
            }
            foreach(Account item in accounts)
            {
                if(username == item.Username)
                {
                    lbNotify.Text = "NOTIFY: Username was be used";
                    txbUserName.Focus();
                    return;
                }
            }
            if(!fAdmin.checkItemInCombobox(cbbEmployee.Text, cbbEmployee))
            {
                lbNotify.Text = "NOTIFY: Please choose Employee in Combobox";
                cbbEmployee.Focus();
                return;
            }
            string IDEmployee = cbbEmployee.Text.Split('-')[0];
            string password = txbPassword.Text;
            if(!Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,30}$"))
            {
                lbNotify.Text = "NOTIFY: Password is not in correct format";
                txbPassword.Focus();
                return;
            }
            string confirmPassword = txbConfirmPassword.Text;
            if(confirmPassword == "")
            {
                lbNotify.Text = "NOTIFY: Confirm password can't be empty";
                txbConfirmPassword.Focus();
                return;
            }
            if(confirmPassword != password)
            {
                lbNotify.Text = "NOTIFY: Confirm password is wrong";
                txbConfirmPassword.Focus();
                return;
            }
            int type = int.Parse(cbbType.Text);

            if(AccountDAO.Instance.AddAccount(username,IDEmployee,password, type))
            {
                lbNotify.Text = "NOTIFY: Account was added Successully";
                this.Close();
            }
            else
            {
                lbNotify.Text = "NOTIFY: Failed to add Account";
                return;
            }
        }
    }
}
