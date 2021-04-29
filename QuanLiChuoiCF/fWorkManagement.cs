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

namespace QuanLiChuoiCF
{
    public partial class fWorkManagement : Form
    {
        private List<Employee> employees = new List<Employee>();
        private int month;
        private int year;

        public int Month { get => month; set => month = value; }
        public int Year { get => year; set => year = value; }

        public fWorkManagement()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            LoadEmployee();
            this.Month = DateTime.Now.Month;
            this.Year = DateTime.Now.Year;
            UpdateBtnMonthAndYear();
            LoadCbbMode();
            LoadCbbList();
            LoadDtgvWorkManagement();
        }

        private void LoadCbbMode() 
        {
            cbbMode.Items.Clear();
            cbbMode.Items.Add("Branch");
            cbbMode.Items.Add("Employee");
            cbbMode.SelectedItem = cbbMode.Items[0];
        }
        private void LoadCbbList() 
        {
            cbbList.Items.Clear();
            if(fAdmin.checkItemInCombobox(cbbMode.Text, cbbMode))
            {
                switch (cbbMode.Text)
                {
                    case "Branch":
                        foreach(Branch branch in BranchDAO.Instance.GetBranches())
                        {
                            cbbList.Items.Add(branch.IDBranch + "-" + branch.Name);
                        }
                        if (cbbList.Items.Count > 0)
                        {
                            cbbList.SelectedItem = cbbList.Items[0];
                        }
                        break;
                    case "Employee":
                        foreach (Employee employee in employees)
                        {
                            if(employee.IDStatus == 1)cbbList.Items.Add(employee.IDEmployee + "-" + employee.FirstName + " " + employee.LastName);
                        }
                        if (cbbList.Items.Count > 0)
                        {
                            cbbList.SelectedItem = cbbList.Items[0];
                        }
                        break;
                }
            }
        }

        private void LoadEmployee()
        {
            employees = EmployeeDAO.Instance.GetEmployees();
        }

        private void LoadDtgvWorkManagement()
        {
            flpWorkManagement.Controls.Clear();
            if(cbbMode.Text == "Branch")
            {
                string iDBranch = cbbList.Text.Split('-')[0];
                LoadDtgvWorkManagementByBranch(iDBranch);
            }
            else
            {
                string iDEmployee = cbbList.Text.Split('-')[0];
                LoadDtgvWorkManagementByEmployee(iDEmployee);
            }
        }

        private void UpdateBtnMonthAndYear()
        {
            btnMonth.Text = Month.ToString();
            btnYear.Text = Year.ToString();
        }

        private void LoadDtgvWorkManagementByBranch(string iDBranch)
        {
            int days = DateTime.DaysInMonth(year, month);
            List<DateOff> dateOffsInSpecificMonthYear = FullTimeEmployeeManagementDAO.Instance.GetDateOffs().FindAll(item => (item.Date.Month == month && item.Date.Year == year && EmployeeDAO.Instance.GetEmployee(item.IDEmployee).IDBranch==iDBranch));

            List<DateWork> dateWorksInSpecificMonthYear = PartTimeEmployeeManagementDAO.Instance.GetDateWorks().FindAll(item => (item.Date.Month == month && item.Date.Year == year && EmployeeDAO.Instance.GetEmployee(item.IDEmployee).IDBranch == iDBranch));

            DateTime dayfirst = new DateTime(year, month, 1);
            for (int i = 1; i < (int)dayfirst.DayOfWeek; i++) 
            {
                Button btn = new Button()
                {
                    Width = 124,
                    Height = 94
                };
                flpWorkManagement.Controls.Add(btn);
                flpWorkManagement.FlowDirection = FlowDirection.LeftToRight;
            }
            for(int i =1; i <= days; i++)
            {
                DateTime date1 = new DateTime(year, month, i);
                Button btn = new Button()
                {
                    Width = 124,
                    Height = 94
                };
                List<Employee> employeesWorkInThisDay = new List<Employee>();
                foreach(DateWork item in dateWorksInSpecificMonthYear)
                {
                    if(item.Date.Day == i)
                    {
                        employeesWorkInThisDay.Add(EmployeeDAO.Instance.GetEmployee(item.IDEmployee));
                    }
                }

                foreach(Employee employee in employees)
                {
                    if(employee.IDTypeEmployee == 1 && employee.IDStatus == 1 && employee.DayIn <= date1)
                    {
                        employeesWorkInThisDay.Add(EmployeeDAO.Instance.GetEmployee(employee.IDEmployee));
                    }
                }

                foreach(DateOff item in dateOffsInSpecificMonthYear)
                {
                    if(item.Date.Day == i)
                    {
                        employeesWorkInThisDay.RemoveAll(o => o.IDEmployee == item.IDEmployee);
                    }
                }
                btn.Text += i + Environment.NewLine;
                foreach(Employee item in employeesWorkInThisDay)
                {
                    btn.Text += item.IDEmployee + "-" + item.FirstName + " " + item.LastName + Environment.NewLine;
                }
                if(date1 > DateTime.Now)btn.Click += btn_Click;
                btn.Tag = employeesWorkInThisDay;
                flpWorkManagement.Controls.Add(btn);
                flpWorkManagement.FlowDirection = FlowDirection.LeftToRight;
            }
            for (int i = (int)dayfirst.DayOfWeek - 1 + days; i <= 7*6; i++)
            {
                Button btn = new Button()
                {
                    Width = 124,
                    Height = 94
                };
                flpWorkManagement.Controls.Add(btn);
                flpWorkManagement.FlowDirection = FlowDirection.LeftToRight;
            }
        }

        private void LoadDtgvWorkManagementByEmployee(string iDEmployee)
        {
            if (EmployeeDAO.Instance.GetEmployee(iDEmployee).IDTypeEmployee == 0)
            {//PartTime
                int days = DateTime.DaysInMonth(year, month);
                List<DateWork> dateWorks = PartTimeEmployeeManagementDAO.Instance.GetDateWorksByIDEmployee(iDEmployee).FindAll(o=>o.Date.Year == year && o.Date.Month==month);

                DateTime dayfirst = new DateTime(year, month, 1);
                for (int i = 1; i < (int)dayfirst.DayOfWeek; i++)
                {
                    Button btn = new Button()
                    {
                        Width = 124,
                        Height = 94
                    };
                    flpWorkManagement.Controls.Add(btn);
                    flpWorkManagement.FlowDirection = FlowDirection.LeftToRight;
                }
                for (int i = 1; i <= days; i++)
                {
                    DateTime date1 = new DateTime(year, month, i);
                    Button btn = new Button()
                    {
                        Width = 124,
                        Height = 94
                    };
                    btn.Text = i + Environment.NewLine;
                    btn.Click += btn_Click_Switch;
                    flpWorkManagement.Controls.Add(btn);
                    flpWorkManagement.FlowDirection = FlowDirection.LeftToRight;
                    if (date1 < EmployeeDAO.Instance.GetEmployee(iDEmployee).DayIn) continue;
                    btn.Text = i + Environment.NewLine + "NO";
                    btn.BackColor = Color.Red;
                    foreach (DateWork dateWork in dateWorks)
                    {
                        if(dateWork.Date.Day == i)
                        {
                            btn.Text = i + Environment.NewLine + "YES";
                            btn.BackColor = Color.FromArgb(91, 100, 245);
                            break;
                        }
                    }
                }
                for (int i = (int)dayfirst.DayOfWeek - 1 + days; i <= 7 * 6; i++)
                {
                    Button btn = new Button()
                    {
                        Width = 124,
                        Height = 94
                    };
                    flpWorkManagement.Controls.Add(btn);
                    flpWorkManagement.FlowDirection = FlowDirection.LeftToRight;
                }
            }
            else
            {//FullTime
                int days = DateTime.DaysInMonth(year, month);
                List<DateOff> dateOffs = FullTimeEmployeeManagementDAO.Instance.GetDateOffsByIDEmployee(iDEmployee).FindAll(o => o.Date.Year == year && o.Date.Month == month);

                DateTime dayfirst = new DateTime(year, month, 1);
                for (int i = 1; i < (int)dayfirst.DayOfWeek; i++)
                {
                    Button btn = new Button()
                    {
                        Width = 124,
                        Height = 94
                    };
                    flpWorkManagement.Controls.Add(btn);
                    flpWorkManagement.FlowDirection = FlowDirection.LeftToRight;
                }
                for (int i = 1; i <= days; i++)
                {
                    DateTime date1 = new DateTime(year, month, i);
                    Button btn = new Button()
                    {
                        Width = 124,
                        Height = 94
                    };
                    btn.Text = i + Environment.NewLine;
                    btn.Click += btn_Click_Switch;
                    flpWorkManagement.Controls.Add(btn);
                    flpWorkManagement.FlowDirection = FlowDirection.LeftToRight;
                    if (date1 < EmployeeDAO.Instance.GetEmployee(iDEmployee).DayIn) continue;
                    btn.Text = i + Environment.NewLine + "YES";
                    btn.BackColor = Color.FromArgb(91, 100, 245);
                    foreach (DateOff dateOff in dateOffs)
                    {
                        if (dateOff.Date.Day == i)
                        {
                            btn.Text = i + Environment.NewLine + "NO";
                            btn.BackColor = Color.Red;
                            break;
                        }
                    }
                }
                for (int i = (int)dayfirst.DayOfWeek - 1 + days; i <= 7 * 6; i++)
                {
                    Button btn = new Button()
                    {
                        Width = 124,
                        Height = 94
                    };
                    flpWorkManagement.Controls.Add(btn);
                    flpWorkManagement.FlowDirection = FlowDirection.LeftToRight;
                }
            }
        }

        void btn_Click(object sender, EventArgs e)
        {
            List<Employee> employeesWorkInThisDay = (sender as Button).Tag as List<Employee>;
            Button button = sender as Button;
            int day = int.Parse((sender as Button).Text.Split('\n')[0]);
            fAddSubEmployeeInWorkDay f = new fAddSubEmployeeInWorkDay(button, employeesWorkInThisDay, new DateTime(year,Month,day));
            f.ShowDialog();
        }

        void btn_Click_Switch(object sender, EventArgs e)
        {
            int day = int.Parse((sender as Button).Text.Split('\n')[0]);
            bool work = (sender as Button).Text.Split('\n')[1] == "YES" ? true : false;
            if (work)
            {
                (sender as Button).Text = day + Environment.NewLine + "NO";
                (sender as Button).BackColor = Color.Red;
            }
            else
            {
                (sender as Button).Text = day + Environment.NewLine + "YES";
                (sender as Button).BackColor = Color.FromArgb(91, 100, 245);
            }
            string IDEmployee = cbbList.Text.Split('-')[0];
            if (EmployeeDAO.Instance.GetEmployee(IDEmployee).IDTypeEmployee == 0)
            {
                if (work)
                {
                    PartTimeEmployeeManagementDAO.Instance.DeleteDateWork(IDEmployee, new DateTime(year, Month, day));
                }
                else
                {
                    PartTimeEmployeeManagementDAO.Instance.AddDateWork(IDEmployee, new DateTime(year, Month, day));
                }
            }
            else
            {
                if (work)
                {
                    FullTimeEmployeeManagementDAO.Instance.AddDateOff(IDEmployee, new DateTime(year, Month, day));
                }
                else
                {
                    FullTimeEmployeeManagementDAO.Instance.DeleteDateOff(IDEmployee, new DateTime(year, Month, day));
                }
            }
        }

        private void cbbMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCbbList();
        }

        private void cbbList_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDtgvWorkManagement();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.Month > 1)
            {
                this.Month--;
            }
            else
            {
                this.Month = 12;
                this.Year--;
            }
            LoadDtgvWorkManagement();
            UpdateBtnMonthAndYear();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (this.Month < 12)
            {
                this.Month++;
            }
            else
            {
                this.Month = 1;
                this.Year++;
            }
            LoadDtgvWorkManagement();
            UpdateBtnMonthAndYear();
        }

    }
}
