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
using QuanLiChuoiCF.DAO;

namespace QuanLiChuoiCF
{
    public partial class fAddSubEmployeeInWorkDay : Form
    {
        Button button;
        private List<Employee> employeesWorkInThisDay = new List<Employee>();
        private DateTime date;

        public DateTime Date { get => date; set => date = value; }

        public fAddSubEmployeeInWorkDay(Button button, List<Employee> employeesWorkInThisDay, DateTime date)
        {
            InitializeComponent();
            this.button = button;
            this.employeesWorkInThisDay = employeesWorkInThisDay;
            this.date = date;
            Load();
        }

        private void Load()
        {
            LoadLsvEmployeeWorkInThisDay();
            LoadCbbEmployeeWithOutWork();
        }

        private void LoadLsvEmployeeWorkInThisDay()
        {
            lsvEmployeeWorkInThisDay.Items.Clear();
            foreach(Employee employee in employeesWorkInThisDay)
            {
                ListViewItem listViewItem = new ListViewItem(employee.IDEmployee);
                listViewItem.SubItems.Add(employee.FirstName);
                listViewItem.SubItems.Add(employee.LastName);
                lsvEmployeeWorkInThisDay.Items.Add(listViewItem);
            }
        }

        private void LoadCbbEmployeeWithOutWork()
        {
            List<Employee> employees = EmployeeDAO.Instance.GetEmployees();
            List<Employee> employeesWithOutWork = employees.FindAll(o => !(employeesWorkInThisDay.FindAll(item=>item.IDEmployee==o.IDEmployee).Count > 0)&&o.IDStatus==1);
            cbbEmployeeWithOutWork.Items.Clear();
            cbbEmployeeWithOutWork.Text = "";
            foreach (Employee employeeWithOutWork in employeesWithOutWork)
            {
                cbbEmployeeWithOutWork.Items.Add(employeeWithOutWork.IDEmployee +"-"+employeeWithOutWork.FirstName +" "+employeeWithOutWork.LastName);
            }
            if (cbbEmployeeWithOutWork.Items.Count > 0)
            {
                cbbEmployeeWithOutWork.SelectedItem = cbbEmployeeWithOutWork.Items[0];
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(!fAdmin.checkItemInCombobox(cbbEmployeeWithOutWork.Text, cbbEmployeeWithOutWork))
            {
                lbNotify.Text = "Please choose one Employee in combobox";
                cbbEmployeeWithOutWork.Focus();
                return;
            }
            else
            {
                string ID = cbbEmployeeWithOutWork.Text.Split('-')[0];
                if(EmployeeDAO.Instance.GetEmployee(ID).IDTypeEmployee == 0)
                {//parttime
                    if(PartTimeEmployeeManagementDAO.Instance.AddDateWork(ID, Date))
                    {
                        lbNotify.Text = "NOTIFY: Adding successfully";
                        employeesWorkInThisDay.Add(EmployeeDAO.Instance.GetEmployee(ID));
                        LoadLsvEmployeeWorkInThisDay();
                        LoadCbbEmployeeWithOutWork();
                        UpdateButton();
                    }
                    else
                    {
                        lbNotify.Text = "NOTIFY: Failed to added";
                    }
                }
                else
                {//fulltime
                    if (FullTimeEmployeeManagementDAO.Instance.DeleteDateOff(ID, Date))
                    {
                        lbNotify.Text = "NOTIFY: Adding successfully";
                        employeesWorkInThisDay.Add(EmployeeDAO.Instance.GetEmployee(ID));
                        LoadLsvEmployeeWorkInThisDay();
                        LoadCbbEmployeeWithOutWork();
                        UpdateButton();
                    }
                    else
                    {
                        lbNotify.Text = "NOTIFY: Failed to added";
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lsvEmployeeWorkInThisDay.SelectedItems.Count > 0)
            {
                string ID = lsvEmployeeWorkInThisDay.SelectedItems[0].Text;
                if (EmployeeDAO.Instance.GetEmployee(ID).IDTypeEmployee == 0)
                {//parttime
                    if (PartTimeEmployeeManagementDAO.Instance.DeleteDateWork(ID, Date))
                    {
                        lbNotify.Text = "NOTIFY: Delete successfully";
                        employeesWorkInThisDay.RemoveAll(o=>o.IDEmployee==ID);
                        LoadLsvEmployeeWorkInThisDay();
                        LoadCbbEmployeeWithOutWork();
                        UpdateButton();
                    }
                    else
                    {
                        lbNotify.Text = "NOTIFY: Failed to delete";
                    }
                }
                else
                {//fulltime
                    if (FullTimeEmployeeManagementDAO.Instance.AddDateOff(ID, Date))
                    {
                        lbNotify.Text = "NOTIFY: Delete successfully";
                        employeesWorkInThisDay.RemoveAll(o => o.IDEmployee == ID);
                        LoadLsvEmployeeWorkInThisDay();
                        LoadCbbEmployeeWithOutWork();
                        UpdateButton();
                    }
                    else
                    {
                        lbNotify.Text = "NOTIFY: Failed to delete";
                    }
                }
            }
            else
            {
                lbNotify.Text = "NOTIFY: Please choose one Row in Table";
                return;
            }
        }

        private void UpdateButton()
        {
            button.Text = date.Day + Environment.NewLine;
            foreach (Employee item in employeesWorkInThisDay)
            {
                button.Text += item.IDEmployee + "-" + item.FirstName + " " + item.LastName + Environment.NewLine;
            }
            button.Tag = employeesWorkInThisDay;
        }

    }
}
