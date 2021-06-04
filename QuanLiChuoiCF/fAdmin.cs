using QuanLiChuoiCF.DAO;
using QuanLiChuoiCF.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Globalization;

namespace QuanLiChuoiCF
{
    public partial class fAdmin : Form
    {
        public List<Drink> drinks = new List<Drink>();
        public List<Branch> branches = new List<Branch>();
        public List<Employee> employees = new List<Employee>();
        public List<Account> accounts = new List<Account>();
        public List<Supplier> suppliers = new List<Supplier>();
        public List<InforOfMaterial> infoOfMaterials = new List<InforOfMaterial>();
        public List<Material> materials = new List<Material>();
        public List<Bill> bills = new List<Bill>();
        public List<BillExport> billExports = new List<BillExport>();

        public List<Drink> searchedDrinks = new List<Drink>();
        public List<Branch> searchedBranches = new List<Branch>();
        public List<Employee> searchedEmployees = new List<Employee>();
        public List<Account> searchedAccounts = new List<Account>();
        public List<Supplier> searchedSuppliers = new List<Supplier>();
        public List<InforOfMaterial> searchedInfoOfMaterials = new List<InforOfMaterial>();
        public List<Material> searchedMaterials = new List<Material>();
        public List<Bill> searchedBills = new List<Bill>();
        public List<BillExport> searchedBillExports = new List<BillExport>();

        public string lastIDDrink;
        public string lastIDBranch;
        public string lastIDEmployees;
        public string lastIDSupplier;
        public string lastIDInfoOfMaterial;
        public string lastIDMaterial;
        public string lastIDBill;
        public string lastIDBillExport;

        public fAdmin()
        {
            InitializeComponent();
            LoadAndBinding();
        }
        void LoadAndBinding()
        {
            LoadDrinks();
            LoadBranches();
            LoadEmployees();
            LoadAccounts();
            LoadSupplier();
            LoadInfoOfMaterial();
            LoadMaterial();
            LoadBill();
            LoadBillExport();
            LoadStatistic();

            LoadSortAndSearchCombobox();
            LoadCbbAccountTypeInTabAccount();
            LoadCbbSexualInTabEmployee();
            LoadStatusCombobox();
            LoadTypeEmployeeCombobox();
            LoadUnitCombobox();
        }

        private void LoadSortAndSearchCombobox()
        {
            cbb_Drink_SortBy.Items.Add("ID");
            cbb_Drink_SortBy.Items.Add("Drink Name");
            cbb_Drink_SortBy.Items.Add("Price");
            cbb_Drink_SortBy.Items.Add("Status");
            cbb_Drink_SortBy.SelectedItem = cbb_Drink_SortBy.Items[0];

            cbb_Drink_SearchBy.Items.Add("ID");
            cbb_Drink_SearchBy.Items.Add("Drink Name");
            cbb_Drink_SearchBy.Items.Add("Price");
            cbb_Drink_SearchBy.Items.Add("Status");
            cbb_Drink_SearchBy.SelectedItem = cbb_Drink_SearchBy.Items[0];

            cbb_Branch_SortBy.Items.Add("ID");
            cbb_Branch_SortBy.Items.Add("Branch Name");
            cbb_Branch_SortBy.Items.Add("Manager");
            cbb_Branch_SortBy.Items.Add("Status");
            cbb_Branch_SortBy.SelectedItem = cbb_Branch_SortBy.Items[0];

            cbb_Branch_SearchBy.Items.Add("ID");
            cbb_Branch_SearchBy.Items.Add("Branch Name");
            cbb_Branch_SearchBy.Items.Add("Manager");
            cbb_Branch_SearchBy.Items.Add("Status");
            cbb_Branch_SearchBy.SelectedItem = cbb_Branch_SearchBy.Items[0];

            cbb_Account_SortBy.Items.Add("User Name");
            cbb_Account_SortBy.Items.Add("Employee");
            cbb_Account_SortBy.Items.Add("Type");
            cbb_Account_SortBy.Items.Add("Status");
            cbb_Account_SortBy.SelectedItem = cbb_Account_SortBy.Items[0];

            cbb_Account_SearchBy.Items.Add("User Name");
            cbb_Account_SearchBy.Items.Add("Employee");
            cbb_Account_SearchBy.Items.Add("Type");
            cbb_Account_SearchBy.Items.Add("Status");
            cbb_Account_SearchBy.SelectedItem = cbb_Account_SearchBy.Items[0];

            cbb_Employee_SortBy.Items.Add("ID of Employee");
            cbb_Employee_SortBy.Items.Add("First Name");
            cbb_Employee_SortBy.Items.Add("Last Name");
            cbb_Employee_SortBy.Items.Add("Phone Number");
            cbb_Employee_SortBy.Items.Add("Sexual");
            cbb_Employee_SortBy.Items.Add("Address");
            cbb_Employee_SortBy.Items.Add("Day In");
            cbb_Employee_SortBy.Items.Add("Number of Day Off");
            cbb_Employee_SortBy.Items.Add("Type");
            cbb_Employee_SortBy.Items.Add("Branch");
            cbb_Employee_SortBy.Items.Add("Status");
            cbb_Employee_SortBy.SelectedItem = cbb_Employee_SortBy.Items[0];

            cbb_Employee_SearchBy.Items.Add("ID of Employee");
            cbb_Employee_SearchBy.Items.Add("First Name");
            cbb_Employee_SearchBy.Items.Add("Last Name");
            cbb_Employee_SearchBy.Items.Add("Phone Number");
            cbb_Employee_SearchBy.Items.Add("Sexual");
            cbb_Employee_SearchBy.Items.Add("Address");
            cbb_Employee_SearchBy.Items.Add("Day In");
            cbb_Employee_SearchBy.Items.Add("Number of Day Off");
            cbb_Employee_SearchBy.Items.Add("Type");
            cbb_Employee_SearchBy.Items.Add("Branch");
            cbb_Employee_SearchBy.Items.Add("Status");
            cbb_Employee_SearchBy.SelectedItem = cbb_Employee_SearchBy.Items[0];

            cbb_InfoOfMaterial_SortBy.Items.Add("ID");
            cbb_InfoOfMaterial_SortBy.Items.Add("Name");
            cbb_InfoOfMaterial_SortBy.Items.Add("Unit");
            cbb_InfoOfMaterial_SortBy.Items.Add("Price");
            cbb_InfoOfMaterial_SortBy.Items.Add("Supplier");
            cbb_InfoOfMaterial_SortBy.Items.Add("Status");
            cbb_InfoOfMaterial_SortBy.SelectedItem = cbb_InfoOfMaterial_SortBy.Items[0];

            cbb_InfoOfMaterial_SearchBy.Items.Add("ID");
            cbb_InfoOfMaterial_SearchBy.Items.Add("Name");
            cbb_InfoOfMaterial_SearchBy.Items.Add("Unit");
            cbb_InfoOfMaterial_SearchBy.Items.Add("Price");
            cbb_InfoOfMaterial_SearchBy.Items.Add("Supplier");
            cbb_InfoOfMaterial_SearchBy.Items.Add("Status");
            cbb_InfoOfMaterial_SearchBy.SelectedItem = cbb_InfoOfMaterial_SearchBy.Items[0];

            cbb_Bill_SortBy.Items.Add("ID of Bill");
            cbb_Bill_SortBy.Items.Add("Branch");
            cbb_Bill_SortBy.Items.Add("Day Check In");
            cbb_Bill_SortBy.Items.Add("Total Amount");
            cbb_Bill_SortBy.SelectedItem = cbb_Bill_SortBy.Items[0];

            cbb_Bill_SearchBy.Items.Add("ID of Bill");
            cbb_Bill_SearchBy.Items.Add("Branch");
            cbb_Bill_SearchBy.Items.Add("Day Check In");
            cbb_Bill_SearchBy.Items.Add("Total Amount");
            cbb_Bill_SearchBy.SelectedItem = cbb_Bill_SearchBy.Items[0];

            cbb_Supplier_SortBy.Items.Add("ID");
            cbb_Supplier_SortBy.Items.Add("Name");
            cbb_Supplier_SortBy.Items.Add("Address");
            cbb_Supplier_SortBy.Items.Add("Status");
            cbb_Supplier_SortBy.SelectedItem = cbb_Supplier_SortBy.Items[0];

            cbb_Supplier_SearchBy.Items.Add("ID");
            cbb_Supplier_SearchBy.Items.Add("Name");
            cbb_Supplier_SearchBy.Items.Add("Address");
            cbb_Supplier_SearchBy.Items.Add("Status");
            cbb_Supplier_SearchBy.SelectedItem = cbb_Supplier_SearchBy.Items[0];

            cbb_Warehouse_SortBy.Items.Add("ID of Material");
            cbb_Warehouse_SortBy.Items.Add("ID information of Material");
            cbb_Warehouse_SortBy.Items.Add("Amount");
            cbb_Warehouse_SortBy.Items.Add("Amount Left");
            cbb_Warehouse_SortBy.Items.Add("Date Added");
            cbb_Warehouse_SortBy.Items.Add("Expiry Date");
            cbb_Warehouse_SortBy.SelectedItem = cbb_Warehouse_SortBy.Items[0];

            cbb_Warehouse_SearchBy.Items.Add("ID of Material");
            cbb_Warehouse_SearchBy.Items.Add("ID information of Material");
            cbb_Warehouse_SearchBy.Items.Add("Amount");
            cbb_Warehouse_SearchBy.Items.Add("Amount Left");
            cbb_Warehouse_SearchBy.Items.Add("Date Added");
            cbb_Warehouse_SearchBy.Items.Add("Expiry Date");
            cbb_Warehouse_SearchBy.SelectedItem = cbb_Warehouse_SearchBy.Items[0];

            cbb_BillExport_SortBy.Items.Add("ID of Bill Export");
            cbb_BillExport_SortBy.Items.Add("Date");
            cbb_BillExport_SortBy.Items.Add("Branch");
            cbb_BillExport_SortBy.Items.Add("Total Amount");
            cbb_BillExport_SortBy.SelectedItem = cbb_BillExport_SortBy.Items[0];

            cbb_BillExport_SearchBy.Items.Add("ID of Bill Export");
            cbb_BillExport_SearchBy.Items.Add("Date");
            cbb_BillExport_SearchBy.Items.Add("Branch");
            cbb_BillExport_SearchBy.Items.Add("Total Amount");
            cbb_BillExport_SearchBy.SelectedItem = cbb_BillExport_SearchBy.Items[0];

             
        }

        private void LoadCbbAccountTypeInTabAccount()
        {
            cbb_Account_AccountType.Items.Clear();
            cbb_Account_AccountType.Items.Add("Admin");
            cbb_Account_AccountType.Items.Add("Employee");
            cbb_Account_AccountType.SelectedItem = cbb_Account_AccountType.Items[0];
        }

        private void LoadCbbSexualInTabEmployee()
        {
            cbb_Employee_Sexual.Items.Clear();
            cbb_Employee_Sexual.Items.Add("Not known");
            cbb_Employee_Sexual.Items.Add("Male");
            cbb_Employee_Sexual.Items.Add("Female");
            cbb_Employee_Sexual.Items.Add("Not applicable");
            cbb_Employee_Sexual.SelectedItem = cbb_Employee_Sexual.Items[0];
        }

        private void LoadStatusCombobox()
        {
            cbb_Drink_Status.Items.Add("NotUse");
            cbb_Drink_Status.Items.Add("Use");
            cbb_Drink_Status.SelectedItem = cbb_Drink_Status.Items[1];

            cbb_Branch_Status.Items.Add("NotUse");
            cbb_Branch_Status.Items.Add("Use");
            cbb_Branch_Status.SelectedItem = cbb_Branch_Status.Items[1];

            cbb_Account_Status.Items.Add("NotUse");
            cbb_Account_Status.Items.Add("Use");
            cbb_Account_Status.SelectedItem = cbb_Account_Status.Items[1];

            cbb_Employee_Status.Items.Add("NotUse");
            cbb_Employee_Status.Items.Add("Use");
            cbb_Employee_Status.SelectedItem = cbb_Employee_Status.Items[1];

            cbb_InfoOfMaterial_Status.Items.Add("NotUse");
            cbb_InfoOfMaterial_Status.Items.Add("Use");
            cbb_InfoOfMaterial_Status.SelectedItem = cbb_InfoOfMaterial_Status.Items[1];

            cbb_Supplier_Status.Items.Add("NotUse");
            cbb_Supplier_Status.Items.Add("Use");
            cbb_Supplier_Status.SelectedItem = cbb_InfoOfMaterial_Status.Items[1];
        }

        private void LoadTypeEmployeeCombobox()
        {
            cbb_Employee_Type.Items.Add("Admin");
            cbb_Employee_Type.Items.Add("Employee");
            cbb_Employee_Type.SelectedItem = cbb_Employee_Type.Items[1];
        }

        private void LoadUnitCombobox()
        {
            cbb_InforOfMaterial_Unit.Items.Add("gram");
            cbb_InforOfMaterial_Unit.Items.Add("kilogram");
            cbb_InforOfMaterial_Unit.Items.Add("package");
            cbb_InforOfMaterial_Unit.Items.Add("bottle");
            cbb_InforOfMaterial_Unit.SelectedItem = cbb_InforOfMaterial_Unit.Items[0];
        }

        #region LoadListToListView
        private void LoadDrinksToLsvDrink(List<Drink> drinks)
        {

            lsv_Drink.Items.Clear();
            foreach(Drink item in drinks)
            {
                ListViewItem listViewItem = new ListViewItem(item.ID);
                listViewItem.SubItems.Add(item.Name);
                listViewItem.SubItems.Add(item.Price.ToString());
                listViewItem.SubItems.Add(getStatusByIDStatus(item.IDStatus));
                lsv_Drink.Items.Add(listViewItem);
            }
        }
        private void LoadBranchesToLsvBranch(List<Branch> branches)
        {
            lsv_Branch.Items.Clear();
            foreach (Branch item in branches)
            {
                ListViewItem listViewItem = new ListViewItem(item.IDBranch);
                listViewItem.SubItems.Add(item.Name);
                listViewItem.SubItems.Add(item.Manager);
                listViewItem.SubItems.Add(getStatusByIDStatus(item.IDStatus));
                lsv_Branch.Items.Add(listViewItem);
            }
        }
        private void LoadSuppliersToLsvSupplier(List<Supplier> suppliers)
        {
            lsv_Supplier.Items.Clear();
            foreach (Supplier item in suppliers)
            {
                ListViewItem listViewItem = new ListViewItem(item.IDSupplier);
                listViewItem.SubItems.Add(item.Name);
                listViewItem.SubItems.Add(item.Address);
                listViewItem.SubItems.Add(getStatusByIDStatus(item.IDStatus));
                lsv_Supplier.Items.Add(listViewItem);
            }
        }
        private void LoadEmployeesToLsvEmployee(List<Employee> employees)
        {
            lsv_Employee.Items.Clear();
            foreach (Employee item in employees)
            {
                ListViewItem listViewItem = new ListViewItem(item.IDEmployee);
                listViewItem.SubItems.Add(item.FirstName);
                listViewItem.SubItems.Add(item.LastName);
                listViewItem.SubItems.Add(item.PhoneNumber);
                listViewItem.SubItems.Add(getSexualByIDSexual(item.IDSexual));
                listViewItem.SubItems.Add(item.Address);
                listViewItem.SubItems.Add(item.DayIn.ToString());
                listViewItem.SubItems.Add(item.NumberOfDayOff.ToString());
                listViewItem.SubItems.Add(getTypeEmployeeByIDTypeEmployee(item.IDTypeEmployee));
                listViewItem.SubItems.Add(getIDNameBranch(item.IDBranch));
                listViewItem.SubItems.Add(getStatusByIDStatus(item.IDStatus));
                lsv_Employee.Items.Add(listViewItem);
            }
        }
        private void LoadInfoOfMaterialsToLsvInfoOfMaterial(List<InforOfMaterial> materials)
        {
            lsv_InfoOfMaterial.Items.Clear();
            foreach (InforOfMaterial item in materials)
            {
                ListViewItem listViewItem = new ListViewItem(item.IDInfoOfMaterial);
                listViewItem.SubItems.Add(item.Name);
                listViewItem.SubItems.Add(getUnitByIDUnit(item.IDUnit));
                listViewItem.SubItems.Add(item.Price.ToString());
                listViewItem.SubItems.Add(getIDNameSupplier(item.IDSupplier));
                listViewItem.SubItems.Add(getStatusByIDStatus(item.IDStatus));
                lsv_InfoOfMaterial.Items.Add(listViewItem);
            }
        }
        private void LoadAccountsToLsvAccount(List<Account> accounts)
        {
            lsv_Account.Items.Clear();
            foreach (Account item in accounts)
            {
                ListViewItem listViewItem = new ListViewItem(item.Username);
                listViewItem.SubItems.Add(getIDNameEmployee(item.IDEmployee));
                listViewItem.SubItems.Add(item.Password);
                listViewItem.SubItems.Add(getTypeAccountByIDTypeAccount(item.IDTypeAccount));
                listViewItem.SubItems.Add(getStatusByIDStatus(item.IDStatus));
                lsv_Account.Items.Add(listViewItem);
            }
        }
        private void LoadBillsToLsvBill(List<Bill> bills)
        {
            lsv_Bill.Items.Clear();
            foreach (Bill item in bills)
            {
                ListViewItem listViewItem = new ListViewItem(item.IDBill);
                listViewItem.SubItems.Add(getIDNameBranch(item.IDBranch));
                listViewItem.SubItems.Add(item.DateCheckIn.ToString());
                lsv_Bill.Items.Add(listViewItem);
            }
        }
        private void LoadMaterialToLsvMaterial(List<Material> materials)
        {
            lsv_Warehouse.Items.Clear();
            foreach (Material item in materials)
            {
                ListViewItem listViewItem = new ListViewItem(item.IDMaterial);
                listViewItem.SubItems.Add(getIDNameInfoOfMaterial(item.IDInfoOfMaterial));
                listViewItem.SubItems.Add(item.Amount.ToString());
                listViewItem.SubItems.Add(item.AmountLeft.ToString());
                listViewItem.SubItems.Add(item.DateAdded.ToString("yyyy-MM-dd"));
                listViewItem.SubItems.Add(item.ExpiryDate.ToString("yyyy-MM-dd"));
                lsv_Warehouse.Items.Add(listViewItem);
            }
        }
        private void LoadBillExportsToLsvBillExport(List<BillExport> billExports)
        {
            lsv_BillExport.Items.Clear();
            foreach (BillExport item in billExports)
            {
                ListViewItem listViewItem = new ListViewItem(item.IDBillExport);
                listViewItem.SubItems.Add(getIDNameBranch(item.IDBranch));
                listViewItem.SubItems.Add(item.Date.ToString());
                lsv_BillExport.Items.Add(listViewItem);
            }
        }

        #endregion

        #region loadAndBinding

        void LoadDrinks()
        {
            drinks = DrinkDAO.Instance.GetDrinks();
            searchedDrinks = drinks;
            Drink[] arr = drinks.ToArray();
            if (arr.Length > 0)
            {
                lastIDDrink = arr[arr.Length - 1].ID; 
            }
            else
            {
                lastIDDrink = "DR00";
            }
            LoadDrinksToLsvDrink(drinks);
        }
        void LoadStatistic()
        {
            dtpkDateTo.Value = DateTime.Now;
            TimeSpan t = new TimeSpan(30, 0, 0, 0);
            dtpkDateFrom.Value = DateTime.Now - t;
            foreach (Branch item in branches)
            {
                cbb_Statistic_Branch.Items.Add(item.Name.ToString());
            }
            cbb_Statistic_Branch.SelectedItem = cbb_Statistic_Branch.Items[0];

        }
        void LoadBranches()
        {
            branches = BranchDAO.Instance.GetBranches();
            searchedBranches = branches;
            Branch[] arr = branches.ToArray();
            if (arr.Length > 0)
            {
                lastIDBranch = arr[arr.Length - 1].IDBranch;
            }
            else
            {
                lastIDBranch = "BR00";
            }
            LoadBranchesToLsvBranch(branches);
        }

        void LoadEmployees()
        {
            employees = EmployeeDAO.Instance.GetEmployees();
            searchedEmployees = employees;
            Employee[] arr = employees.ToArray();
            if(arr.Length>0) lastIDEmployees = arr[arr.Length - 1].IDEmployee;
                    else lastIDEmployees = "EM00";
            LoadEmployeesToLsvEmployee(employees);
        }

        void LoadAccounts()
        {
            accounts = AccountDAO.Instance.GetAccounts();
            searchedAccounts = accounts;
            LoadAccountsToLsvAccount(accounts);
        }

        void LoadInfoOfMaterial()
        {
            infoOfMaterials = InforOfMaterialDAO.Instance.GetInfoOfMaterials();
            searchedInfoOfMaterials = infoOfMaterials;
            InforOfMaterial[] arr = infoOfMaterials.ToArray();
            if (arr.Length > 0) lastIDInfoOfMaterial = arr[arr.Length - 1].IDInfoOfMaterial;
            else
            {
                lastIDInfoOfMaterial = "IM00";
            }
            LoadInfoOfMaterialsToLsvInfoOfMaterial(infoOfMaterials);
        }

        void LoadSupplier()
        {
            suppliers = SupplierDAO.Instance.GetSuppliers();
            searchedSuppliers = suppliers;
            Supplier[] arr = suppliers.ToArray();
            if (arr.Length > 0)
            {
                lastIDSupplier = arr[arr.Length - 1].IDSupplier;
            }
            else
            {
                lastIDSupplier = "SP00";
            }
            LoadSuppliersToLsvSupplier(suppliers);
        }
        
        void LoadBill()
        {
            bills = BillDAO.Instance.GetBills();
            searchedBills = bills;
            Bill[] arr = bills.ToArray();
            if (arr.Length > 0) lastIDBill = arr[arr.Length - 1].IDBill;
            else
            {
                lastIDBill = "BI00";
            }
            LoadBillsToLsvBill(bills);
        }

        void LoadMaterial()
        {
            materials = MaterialDAO.Instance.GetMaterials();
            searchedMaterials = materials;
            Material[] arr = materials.ToArray();
            if (arr.Length > 0) lastIDMaterial = arr[arr.Length - 1].IDMaterial;
            else
            {
                lastIDMaterial = "WM00";
            }
            LoadMaterialToLsvMaterial(materials);
        }

        void LoadBillExport()
        {
            billExports = BillExportDAO.Instance.GetBillExports();
            searchedBillExports = billExports;
            BillExport[] arr = billExports.ToArray();
            if (arr.Length > 0)
            {
                lastIDBillExport = arr[arr.Length - 1].IDBillExport;
            }
            else
            {
                lastIDBillExport = "BE00";
            }
            LoadBillExportsToLsvBillExport(billExports);
        }

        void LoadMaterialByIDSupplier()
        {
            List<InforOfMaterial> listInfoMaterial = InforOfMaterialDAO.Instance.GetInfoOfMaterials();
            if (lsv_Supplier.SelectedItems.Count > 0)
            {
                string ID = searchedSuppliers.ElementAt(lsv_Supplier.SelectedItems[0].Index).IDSupplier;
                List<InforOfMaterial> listMaterialByIDSupplier = new List<InforOfMaterial>();
                foreach (InforOfMaterial item in listInfoMaterial)
                {
                    if (item.IDSupplier == ID)
                    {
                        listMaterialByIDSupplier.Add(item);
                    }
                }
                dtgv_Supplier_Material.DataSource = listMaterialByIDSupplier;
            }
        }

        #endregion

        #region DrinkHandler
        private event EventHandler insertDrink;
        public event EventHandler InsertDrink
        {
            add { insertDrink += value; }
            remove { insertDrink -= value; }
        }

        private event EventHandler updateDrink;
        public event EventHandler UpdateDrink
        {
            add { updateDrink += value; }
            remove { updateDrink -= value; }
        }

        private event EventHandler deleteDrink;
        public event EventHandler DeleteDrink
        {
            add { deleteDrink += value; }
            remove { deleteDrink -= value; }
        }
        #endregion

        #region events
        private void tpClick(object sender, EventArgs e)
        {
            switch (tab.SelectedTab.Text)
            {
                case "Money":
                    break;
                case "Drink":
                    break;
                case "Branch":
                    break;
                case "Account":
                    UpdateCbbAccountIdInTabAccount();
                    break;
                case "Employee":
                    UpdateCbbBranchInTabEmployee();
                    break;
                case "InfoOfMaterial":
                    UpdateCbbSupplierInTabInforOfMaterial();
                    break;
                case "Bill":
                    UpdateCbbBranchInTabBill();
                    getDetailOfBilltoLsv();
                    break;
                case "Supplier":
                    LoadMaterialByIDSupplier();
                    break;
                case "Bill Export":
                    UpdateCbbBranchInTabBillExport();
                    break;
                case "Warehouse":
                    UpdateCbbMaterialInTabWarehouse();
                    break;
            }
        }

        #region eventsDrink

        private void tbSearchCF_TextChanged(object sender, EventArgs e)
        {
            string searchingText = txb_Drink_Search.Text;
            switch (cbb_Drink_SearchBy.Text)
            {
                case "ID":
                    searchedDrinks = drinks.FindAll(item => item.ID.Contains(searchingText));
                    break;
                case "Drink Name":
                    searchedDrinks = drinks.FindAll(item => item.Name.Contains(searchingText));
                    break;
                case "Price":
                    searchedDrinks = drinks.FindAll(item => item.Price.ToString().Contains(searchingText));
                    break;
                case "Status":
                    searchedDrinks = drinks.FindAll(item => getStatusByIDStatus(item.IDStatus).Contains(searchingText));
                    break;
            }
            LoadDrinksToLsvDrink(searchedDrinks);
        }

        private void btn_Drink_AddClick(object sender, EventArgs e)
        {
            string id = getIDIncrea(lastIDDrink);

            string name = txb_Drink_Name.Text.Trim();
            if(name == "")
            {
                lb_Drink_Notify.Text = "NOTIFY: Name can't be empty";
                txb_Drink_Name.Focus();
                return;
            }

            int price = (int)nud_Drink_Price.Value;
            if (price == 0)
            {
                lb_Drink_Notify.Text = "NOTIFY: Price can't be lower than 0";
                nud_Drink_Price.Focus();
                return;
            }

            if(!checkItemInCombobox(cbb_Drink_Status.Text, cbb_Drink_Status))
            {
                lb_Drink_Notify.Text = "NOTIFY: Please choose Status in Combobox";
                cbb_Drink_Status.Focus();
                return;
            }
            int iDStatus = cbb_Drink_Status.SelectedIndex;

            if (DrinkDAO.Instance.AddDrink(id, name, price, iDStatus))
            {
                lb_Drink_Notify.Text = "NOTIFY: Drink was added Successfully";
                LoadDrinks();
                newDrink();
                if (insertDrink != null)
                    insertDrink(this, new EventArgs());
            }
            else
            {
                lb_Drink_Notify.Text = "NOTIFY: Failed to add Drink";
            }
        }

        private void btn_Drink_UpdateClick(object sender, EventArgs e)
        {
            string id;
            if (lsv_Drink.SelectedItems.Count > 0)
            {
                id = searchedDrinks.ElementAt(lsv_Drink.SelectedItems[0].Index).ID;
            }
            else
            {
                lb_Drink_Notify.Text = "NOTIFY: Please choose one Row in Table";
                return;
            }

            string name = txb_Drink_Name.Text.Trim();
            if (name == "")
            {
                lb_Drink_Notify.Text = "NOTIFY: Name can't be  empty";
                txb_Drink_Name.Focus();
                return;
            }

            int price = (int)nud_Drink_Price.Value;
            if (price == 0)
            {
                lb_Drink_Notify.Text = "NOTIFY: Price can't be lower than 0";
                nud_Drink_Price.Focus();
                return;
            }

            if (!checkItemInCombobox(cbb_Drink_Status.Text, cbb_Drink_Status))
            {
                lb_Drink_Notify.Text = "NOTIFY: Please choose Status in Combobox";
                cbb_Drink_Status.Focus();
                return;
            }
            int iDStatus = cbb_Drink_Status.SelectedIndex;

            if (DrinkDAO.Instance.UpdateDrink(id, name, price, iDStatus))
            {
                lb_Drink_Notify.Text = "NOTIFY: Drink was updated Successfully";
                LoadDrinks();
                newDrink();
            }
            else
            {
                lb_Drink_Notify.Text = "NOTIFY: Failed to update Drink";
            }
        }

        private void btn_Drink_DeleteCLick(object sender, EventArgs e)
        {
            string id;
            if(lsv_Drink.SelectedItems.Count > 0)
            {
                id = searchedDrinks.ElementAt(lsv_Drink.SelectedItems[0].Index).ID;
            }
            else
            {
                lb_Drink_Notify.Text = "NOTIFY: Please choose one Row in table";
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this drink", "Delete Drink", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,MessageBoxDefaultButton.Button1) != System.Windows.Forms.DialogResult.Yes)
            {
                return;
            }

            if (DrinkDAO.Instance.DeleteDrink(id))
            {
                lb_Drink_Notify.Text = "NOTIFY: Drink was deleted Successfully"; 
                LoadDrinks();
                if (deleteDrink != null)
                    deleteDrink(this, new EventArgs());
            }
            else
            {
                lb_Drink_Notify.Text = "Failed To Delete Drink";
            }
        }

        private void cbb_Drink_SortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbb_Drink_SortBy.Text)
            {
                case "ID":
                    searchedDrinks = searchedDrinks.OrderBy(o => o.ID).ToList();
                    break;
                case "Drink Name":
                    searchedDrinks = searchedDrinks.OrderBy(o => o.Name).ToList();
                    break;
                case "Price":
                    searchedDrinks = searchedDrinks.OrderBy(o => o.Price).ToList();
                    break;
                case "Status":
                    searchedDrinks = searchedDrinks.OrderBy(o => getStatusByIDStatus(o.IDStatus)).ToList();
                    break;
                    
            }
            LoadDrinksToLsvDrink(searchedDrinks);
        }

        #endregion

        #region accountEvents

        private void txb_Account_Search_TextChanged(object sender, EventArgs e)
        {
            string searchingText = txb_Account_Search.Text;
            switch (cbb_Account_SearchBy.Text)
            {
                case "User Name":
                    searchedAccounts = accounts.FindAll(item => item.Username.Contains(searchingText));
                    break;
                case "Employee":
                    searchedAccounts = accounts.FindAll(item => getIDNameEmployee(item.IDEmployee).Contains(searchingText));
                    break;
                case "Type":
                    searchedAccounts = accounts.FindAll(item => getTypeAccountByIDTypeAccount(item.IDTypeAccount).Contains(searchingText));
                    break;
                case "Status":
                    searchedAccounts = accounts.FindAll(item => getStatusByIDStatus(item.IDStatus).Contains(searchingText));
                    break;
            }
            LoadAccountsToLsvAccount(searchedAccounts);
        }

        private void cbb_Account_SortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbb_Account_SortBy.Text)
            {
                case "User Name":
                    searchedAccounts = searchedAccounts.OrderBy(o => o.Username).ToList();
                    break;
                case "Employee":
                    searchedAccounts = searchedAccounts.OrderBy(o => getIDNameEmployee(o.IDEmployee)).ToList();
                    break;
                case "Type":
                    searchedAccounts = searchedAccounts.OrderBy(o => getTypeAccountByIDTypeAccount(o.IDTypeAccount)).ToList();
                    break;
                case "Status":
                    searchedAccounts = searchedAccounts.OrderBy(o => getStatusByIDStatus(o.IDStatus)).ToList();
                    break;
            }
            LoadAccountsToLsvAccount(searchedAccounts);
        }

        private void btnDeleteAccountClick(object sender, EventArgs e)
        {
            string username;
            if (lsv_Account.SelectedItems.Count > 0)
            {
                username = lsv_Account.SelectedItems[0].SubItems[0].Text;
            }
            else
            {
                lb_Account_Notify.Text = "NOTIFY: Please choose one Row in Table";
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this Account", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) != System.Windows.Forms.DialogResult.Yes)
            {
                return;
            }
            if (AccountDAO.Instance.DeleteAccount(username))
            {
                lb_Account_Notify.Text = "Account was deleted Successfully";
                LoadAccounts();
            }
            else
            {
                lb_Account_Notify.Text = "Failed to delete Account";
            }
        }

        private void btnUpdateAccountClick(object sender, EventArgs e)
        {
            string username;
            if (lsv_Account.SelectedItems.Count > 0)
            {
                username = lsv_Account.SelectedItems[0].SubItems[0].Text;
            }
            else
            {
                lb_Account_Notify.Text = "NOTIFY: Please choose one Row in Table";
                return;
            }

            if(username != txb_Account_Username.Text)
            {
                lb_Account_Notify.Text = "NOTIFY: Username mustn't be change";
                txb_Account_Username.Focus();
                return;
            }

            //if(!checkItemInCombobox(cbb_Account_Employee.Text, cbb_Account_Employee))
            //{
            //    lb_Account_Notify.Text = "NOTIFY: Please choose Employee in Combobox";
            //    cbb_Account_Employee.Focus();
            //    return;
            //}
            //string IDEmployee = cbb_Account_Employee.Text.Split('-')[0];
            string IDEmployee = lsv_Account.SelectedItems[0].SubItems[1].Text.Split('-')[0];

            if (!checkItemInCombobox(cbb_Account_AccountType.Text, cbb_Account_AccountType))
            {
                lb_Employee_Notify.Text = "NOTIFY: Please choose Type in Combobox";
                cbb_Account_AccountType.Focus();
                return;
            }
            int type = cbb_Account_AccountType.SelectedIndex;

            if (!checkItemInCombobox(cbb_Account_Status.Text, cbb_Account_Status))
            {
                lb_Employee_Notify.Text = "NOTIFY: Please choose Status in Combobox";
                cbb_Account_Status.Focus();
                return;
            }
            int iDStatus = cbb_Account_Status.SelectedIndex;

            if (AccountDAO.Instance.UpdateAccount(username, IDEmployee, type, iDStatus))
            {
                lb_Account_Notify.Text = "NOTIFY: Account was updated Successfully";
                LoadAccounts();
                UpdateCbbAccountIdInTabAccount();
            }
            else
            {
                lb_Account_Notify.Text = "Failed to update Account";
            }
        }

        private void btn_Account_ChangePasswordClick(object sender, EventArgs e)
        {
            foreach(Account item in accounts)
            {
                if(item.Username == txb_Account_Username.Text)
                {
                    fChangePassword f = new fChangePassword(item);
                    f.ShowDialog();
                    LoadAccounts();
                    break;
                }
            }
            
        }

        private void btnAccountNewClick(object sender, EventArgs e)
        {
            fNewAccount f = new fNewAccount(accounts, employees);
            f.ShowDialog();
            LoadAccounts();
        }

        #endregion

        #region EmployeesEvent

        private void txb_Employee_Search_TextChanged(object sender, EventArgs e)
        {
            string searchingText = txb_Account_Search.Text;
            switch (cbb_Employee_SearchBy.Text)
            {
                case "ID of Employee":
                    searchedEmployees = employees.FindAll(o => o.IDEmployee.Contains(searchingText));
                    break;
                case "First Name":
                    searchedEmployees = employees.FindAll(o => o.FirstName.Contains(searchingText));
                    break;
                case "Last Name":
                    searchedEmployees = employees.FindAll(o => o.LastName.Contains(searchingText));
                    break;
                case "Phone Number":
                    searchedEmployees = employees.FindAll(o => o.PhoneNumber.Contains(searchingText));
                    break;
                case "Sexual":
                    searchedEmployees = employees.FindAll(o => getSexualByIDSexual(o.IDSexual).Contains(searchingText));
                    break;
                case "Address":
                    searchedEmployees = employees.FindAll(o => o.Address.Contains(searchingText));
                    break;
                case "Day In":
                    searchedEmployees = employees.FindAll(o => o.DayIn.ToString().Contains(searchingText));
                    break;
                case "Number of Day Off":
                    searchedEmployees = employees.FindAll(o => o.NumberOfDayOff.ToString().Contains(searchingText));
                    break;
                case "Type":
                    searchedEmployees = employees.FindAll(o => getTypeEmployeeByIDTypeEmployee(o.IDTypeEmployee).Contains(searchingText));
                    break;
                case "Branch":
                    searchedEmployees = employees.FindAll(o => getIDNameBranch(o.IDBranch).Contains(searchingText));
                    break;
                case "Status":
                    searchedEmployees = employees.FindAll(o => getStatusByIDStatus(o.IDStatus).Contains(searchingText));
                    break;
            }
            LoadEmployeesToLsvEmployee(searchedEmployees);
        }

        private void cbb_Employee_SortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbb_Employee_SortBy.Text)
            {
                case "ID of Employee":
                    searchedEmployees = searchedEmployees.OrderBy(o => o.IDEmployee).ToList();
                    break;
                case "First Name":
                    searchedEmployees = searchedEmployees.OrderBy(o => o.FirstName).ToList();
                    break;
                case "Last Name":
                    searchedEmployees = searchedEmployees.OrderBy(o => o.LastName).ToList();
                    break;
                case "Phone Number":
                    searchedEmployees = searchedEmployees.OrderBy(o => o.PhoneNumber).ToList();
                    break;
                case "Sexual":
                    searchedEmployees = searchedEmployees.OrderBy(o => getSexualByIDSexual(o.IDSexual)).ToList();
                    break;
                case "Address":
                    searchedEmployees = searchedEmployees.OrderBy(o => o.Address).ToList();
                    break;
                case "Day In":
                    searchedEmployees = searchedEmployees.OrderBy(o => o.DayIn).ToList();
                    break;
                case "Number of Day Off":
                    searchedEmployees = searchedEmployees.OrderBy(o => o.NumberOfDayOff).ToList();
                    break;
                case "Type":
                    searchedEmployees = searchedEmployees.OrderBy(o => getTypeEmployeeByIDTypeEmployee(o.IDTypeEmployee)).ToList();
                    break;
                case "Branch":
                    searchedEmployees = searchedEmployees.OrderBy(o => getIDNameBranch(o.IDBranch)).ToList();
                    break;
                case "Status":
                    searchedEmployees = searchedEmployees.OrderBy(o => getStatusByIDStatus(o.IDStatus)).ToList();
                    break;
            }
            LoadEmployeesToLsvEmployee(searchedEmployees);
        }

        private void btnAddEmployeeClick(object sender, EventArgs e)
        {
            string id = getIDIncrea(lastIDEmployees);

            string firstName = txb_Employee_FirstName.Text.Trim();
            if (firstName == "")
            {
                lb_Employee_Notify.Text = "NOTIFY: First Name can't be empty";
                txb_Employee_FirstName.Focus();
                return;
            }
            string lastName = txb_Employee_LastName.Text.Trim();
            if (lastName == "")
            {
                lb_Employee_Notify.Text = "NOTIFY: Last Name can't be empty";
                txb_Employee_LastName.Focus();
                return;
            }
            string phoneNumber = txb_Employee_PhoneNumber.Text.Trim();
            if (!Regex.IsMatch(phoneNumber, @"^(84|0[3|5|7|8|9])+([0-9]{8})\b$"))
            {
                lb_Employee_Notify.Text = "NOTIFY: Phone Number is not in correct format";
                txb_Employee_PhoneNumber.Focus();
                return;
            }
            if (!checkItemInCombobox(cbb_Employee_Sexual.Text, cbb_Employee_Sexual))
            {
                lb_Employee_Notify.Text = "NOTIFY: please choose Sexual in Combobox";
                cbb_Employee_Sexual.Focus();
                return;
            }
            int sexual;
            switch (cbb_Employee_Sexual.SelectedItem.ToString())
            {
                case "Not known":
                    sexual = 0;
                    break;
                case "Male":
                    sexual = 1;
                    break;
                case "Female":
                    sexual = 2;
                    break;
                case "Not applicable":
                    sexual = 9;
                    break;
                default:
                    sexual = 0;
                    break;
            }

            string address = txb_Employee_Address.Text.Trim();
            if (address == "")
            {
                lb_Employee_Notify.Text = "NOTIFY: Address can't be empty";
                txb_Employee_Address.Focus();
                return;
            }

            DateTime dayIn = dtp_Employee_DayIn.Value;

            int NumberOfdayOff = (int)nud_Employee_NumberOfDayOff.Value;
            if (NumberOfdayOff <= 0)
            {
                lb_Employee_Notify.Text = "NOTIFY: Day Off must be greater than 0";
                nud_Employee_NumberOfDayOff.Focus();
                return;
            }

            if (!checkItemInCombobox(cbb_Employee_Type.Text, cbb_Employee_Type))
            {
                lb_Employee_Notify.Text = "NOTIFY: please choose Type in Combobox";
                cbb_Employee_Type.Focus();
                return;
            }
            int iDTypeEmployee = cbb_Employee_Type.SelectedIndex;

            if (!checkItemInCombobox(cbb_Employee_Branch.Text, cbb_Employee_Branch))
            {
                lb_Employee_Notify.Text = "NOTIFY: please choose Branch in Combobox";
                cbb_Employee_Branch.Focus();
                return;
            }
            string IDBranch = cbb_Employee_Branch.Text.Split('-')[0];

            if (!checkItemInCombobox(cbb_Employee_Status.Text, cbb_Employee_Status))
            {
                lb_Employee_Notify.Text = "NOTIFY: please choose Branch in Combobox";
                cbb_Employee_Status.Focus();
                return;
            }
            int iDStatus = cbb_Employee_Status.SelectedIndex;

            if (EmployeeDAO.Instance.AddEmployee(firstName, lastName, id, phoneNumber, sexual, address,
                dayIn, NumberOfdayOff, iDTypeEmployee, IDBranch, iDStatus))
            {
                lb_Employee_Notify.Text = "NOTIFY: Employee was added Successfully";
                LoadEmployees();
                newEmployee();
            }
            else
            {
                lb_Employee_Notify.Text = "NOTIFY: Failed to added Employee";
                newEmployee();
            }
        }

        private void btnDeleteEmployeeClick(object sender, EventArgs e)
        {
            string id;

            if (lsv_Employee.SelectedItems.Count > 0)
            {
                id = searchedEmployees.ElementAt(lsv_Employee.SelectedItems[0].Index).IDEmployee;
            }
            else
            {
                lb_Employee_Notify.Text = "NOTIFY: Please choose one Row in Table";
                return;
            }

            foreach(Account account in accounts)
            {
                if(account.IDEmployee == id)
                {
                    MessageBox.Show("There is a Account related to Employee", "Access denied!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    return;
                }
            }

            if (MessageBox.Show("Are you sure you want to delete this Employee", "Delete Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) != System.Windows.Forms.DialogResult.Yes)
            {
                return;
            }
            if(EmployeeDAO.Instance.DeleteEmployee(id))
            {
                lb_Employee_Notify.Text = "NOTIFY: Employee was deleted Successfully";
                LoadEmployees();
            }
            else
            {
                lb_Employee_Notify.Text = "NOTIFY: Failed to delete Employee";
            }
        }

        private void btnUpdateEmployeeClick(object sender, EventArgs e)
        {
            string id;

            if (lsv_Employee.SelectedItems.Count > 0)
            {
                id = searchedEmployees.ElementAt(lsv_Employee.SelectedItems[0].Index).IDEmployee;
            }
            else
            {
                lb_Employee_Notify.Text = "NOTIFY: Please choose one Row in Table";
                return;
            }

            string firstName = txb_Employee_FirstName.Text.Trim();
            if (firstName == "")
            {
                lb_Employee_Notify.Text = "NOTIFY: First Name can't be empty";
                txb_Employee_FirstName.Focus();
                return;
            }

            string lastName = txb_Employee_LastName.Text.Trim();
            if (lastName == "")
            {
                lb_Employee_Notify.Text = "NOTIFY: Last Name can't be empty";
                txb_Employee_LastName.Focus();
                return;
            }

            string phoneNumber = txb_Employee_PhoneNumber.Text.Trim();
            if (!Regex.IsMatch(phoneNumber, @"^(84|0[3|5|7|8|9])+([0-9]{8})\b$"))
            {
                lb_Employee_Notify.Text = "NOTIFY: Phone Number is not in correct format";
                txb_Employee_PhoneNumber.Focus();
                return;
            }

            if (!checkItemInCombobox(cbb_Employee_Sexual.Text, cbb_Employee_Sexual))
            {
                lb_Employee_Notify.Text = "NOTIFY: please choose Sexual in Combobox";
                cbb_Employee_Sexual.Focus();
                return;
            }
            int sexual;
            switch (cbb_Employee_Sexual.SelectedItem.ToString())
            {
                case "Not known":
                    sexual = 0;
                    break;
                case "Male":
                    sexual = 1;
                    break;
                case "Female":
                    sexual = 2;
                    break;
                case "Not applicable":
                    sexual = 9;
                    break;
                default:
                    sexual = 0;
                    break;
            }

            string address = txb_Employee_Address.Text.Trim();
            if (address == "")
            {
                lb_Employee_Notify.Text = "NOTIFY: Address can't be empty";
                txb_Employee_Address.Focus();
                return;
            }

            DateTime dayIn = dtp_Employee_DayIn.Value;

            int NumberOfdayOff = (int)nud_Employee_NumberOfDayOff.Value;
            if (NumberOfdayOff <= 0)
            {
                lb_Employee_Notify.Text = "NOTIFY: Day Off must be greater than 0";
                nud_Employee_NumberOfDayOff.Focus();
                return;
            }

            if (!checkItemInCombobox(cbb_Employee_Type.Text, cbb_Employee_Type))
            {
                lb_Employee_Notify.Text = "NOTIFY: please choose Type in Combobox";
                cbb_Employee_Type.Focus();
                return;
            }
            int iDTypeEmployee = cbb_Employee_Type.SelectedIndex;

            if (!checkItemInCombobox(cbb_Employee_Branch.Text, cbb_Employee_Branch))
            {
                lb_Employee_Notify.Text = "NOTIFY: please choose Branch in Combobox";
                cbb_Employee_Branch.Focus();
                return;
            }
            string IDBranch = cbb_Employee_Branch.Text.Split('-')[0];

            if (!checkItemInCombobox(cbb_Employee_Status.Text, cbb_Employee_Status))
            {
                lb_Employee_Notify.Text = "NOTIFY: please choose Branch in Combobox";
                cbb_Employee_Status.Focus();
                return;
            }
            int iDStatus = cbb_Employee_Status.SelectedIndex;

            if (EmployeeDAO.Instance.UpdateEmployee(firstName, lastName, id, phoneNumber, sexual, address, dayIn, NumberOfdayOff, iDTypeEmployee, IDBranch, iDStatus))
            {
                lb_Employee_Notify.Text = "NOTIFY: Employee was updated Successfully";
                LoadEmployees();
            }
            else
            {
                lb_Employee_Notify.Text = "NOTIFY: Failed to update Employee";
            }
        }

        private void btnNewEmployeeClick(object sender, EventArgs e)
        {
            newEmployee();
        }
        #endregion

        #region BranchEvents

        private void txb_Branch_Search_TextChanged(object sender, EventArgs e)
        {
            string searchingText = txb_Branch_Search.Text;
            switch (cbb_Branch_SearchBy.Text)
            {
                case "ID":
                    searchedBranches = branches.FindAll(item => item.IDBranch.Contains(searchingText));
                    break;
                case "Branch Name":
                    searchedBranches = branches.FindAll(item => item.Name.Contains(searchingText));
                    break;
                case "Manager":
                    searchedBranches = branches.FindAll(item => item.Manager.Contains(searchingText));
                    break;
                case "Status":
                    searchedBranches = branches.FindAll(item => getStatusByIDStatus(item.IDStatus).Contains(searchingText));
                    break;
            }
            LoadBranchesToLsvBranch(searchedBranches);
        }

        private void btnAddBranchClick(object sender, EventArgs e)
        {
            string branchId = getIDIncrea(lastIDBranch);

            string branchName = txb_branch_Name.Text.Trim();
            if(branchName == "")
            {
                lb_Branch_Notify.Text = "Name can't be empty";
                txb_branch_Name.Focus();
                return;
            }

            string manager = txb_branch_Manager.Text.Trim();
            if(manager == "")
            {
                lb_Branch_Notify.Text = "Manager can't be empty";
                txb_branch_Manager.Focus();
                return;
            }

            if (!checkItemInCombobox(cbb_Branch_Status.Text, cbb_Branch_Status))
            {
                lb_Branch_Notify.Text = "NOTIFY: please choose Status in Combobox";
                cbb_Branch_Status.Focus();
                return;
            }
            int iDStatus = cbb_Branch_Status.SelectedIndex;

            if (BranchDAO.Instance.AddBranch(branchId, branchName, manager, iDStatus))
            {
                lb_Branch_Notify.Text = "Branch Was Added Successfully";
                LoadBranches();
                newBranch();
            }
            else
            {
                lb_Branch_Notify.Text = "Failed To Added Branch";
                newBranch();
            }
        }

        private void btnDeleteBranchClick(object sender, EventArgs e)
        {
            string branchID;
            if (lsv_Branch.SelectedItems.Count > 0)
            {
                branchID = searchedBranches.ElementAt(lsv_Branch.SelectedItems[0].Index).IDBranch;
            }
            else
            {
                lb_Branch_Notify.Text = "NOTIFY: Please choose one row in table";
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this branch", "Delete Branch", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) != System.Windows.Forms.DialogResult.Yes)
            {
                return;
            }

            foreach (Employee employee in employees)
            {
                if(employee.IDBranch == branchID)
                {
                    MessageBox.Show("There is a employee relation to this Branch", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    return;
                }
            }

            foreach(Bill bill in bills)
            {
                if(bill.IDBranch == branchID)
                {
                    MessageBox.Show("There is a bill relation to this Branch", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    return;
                }
            }

            foreach(BillExport billExport in billExports)
            {
                if(billExport.IDBranch == branchID)
                {
                    MessageBox.Show("There is a billexport relation to this Branch", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    return;
                }
            }

            if (BranchDAO.Instance.DeleteBranch(branchID))
            {
                lb_Branch_Notify.Text = "Branch Was Deleted Successfully";
                LoadBranches();
            }
            else
            {
                lb_Branch_Notify.Text = "Failed To Delete Branch";
            }
        }

        private void btnUpdateBranchClick(object sender, EventArgs e)
        {
            string branchID;
            if (lsv_Branch.SelectedItems.Count > 0)
            {
                branchID = searchedBranches.ElementAt(lsv_Branch.SelectedItems[0].Index).IDBranch;
            }
            else
            {
                lb_Branch_Notify.Text = "NOTIFY: Please choose one Row in Table";
                return;
            }

            string branchName = txb_branch_Name.Text.Trim();
            if (branchName == "")
            {
                lb_Branch_Notify.Text = "NOTIFY: Name can't be empty";
                return;
            }

            string manager = txb_branch_Manager.Text.Trim();
            if(manager == "")
            {
                lb_Branch_Notify.Text = "NOTIFY: Manager can't be empty";
                return;
            }

            if (!checkItemInCombobox(cbb_Branch_Status.Text, cbb_Branch_Status))
            {
                lb_Branch_Notify.Text = "NOTIFY: please choose Branch in Combobox";
                cbb_Branch_Status.Focus();
                return;
            }
            int iDStatus = cbb_Branch_Status.SelectedIndex;

            if (BranchDAO.Instance.UpdateBranch(branchID, branchName, manager, iDStatus))
            {
                lb_Branch_Notify.Text = "Branch Was Updated Successfully";
                LoadBranches();
            }
            else
            {
                lb_Branch_Notify.Text = "Failed To Update Branch";
            }
        }

        private void cbb_Branch_SortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbb_Branch_SortBy.Text)
            {
                case "ID":
                    searchedBranches = searchedBranches.OrderBy(o => o.IDBranch).ToList();
                    break;
                case "Branch Name":
                    searchedBranches = searchedBranches.OrderBy(o => o.Name).ToList();
                    break;
                case "Manager":
                    searchedBranches = searchedBranches.OrderBy(o => o.Manager).ToList();
                    break;
                case "Status":
                    searchedBranches = searchedBranches.OrderBy(o => getStatusByIDStatus(o.IDStatus)).ToList();
                    break;
            }
            LoadBranchesToLsvBranch(searchedBranches);
        }
        #endregion

        #region InforOfMaterialEvent

        private void txb_InfoOfMaterial_Search_TextChanged(object sender, EventArgs e)
        {
            string searchingText = txb_InfoOfMaterial_Search.Text;
            switch (cbb_InfoOfMaterial_SearchBy.Text)
            {
                case "ID":
                    searchedInfoOfMaterials = infoOfMaterials.FindAll(o => o.IDInfoOfMaterial.Contains(searchingText));
                    break;
                case "Name":
                    searchedInfoOfMaterials = infoOfMaterials.FindAll(o => o.Name.Contains(searchingText));
                    break;
                case "Unit":
                    searchedInfoOfMaterials = infoOfMaterials.FindAll(o => (getUnitByIDUnit(o.IDUnit)).Contains(searchingText));
                    break;
                case "Price":
                    searchedInfoOfMaterials = infoOfMaterials.FindAll(o => o.Price.ToString().Contains(searchingText));
                    break;
                case "Supplier":
                    searchedInfoOfMaterials = infoOfMaterials.FindAll(o => getIDNameSupplier(o.IDSupplier).Contains(searchingText));
                    break;
                case "Status":
                    searchedInfoOfMaterials = infoOfMaterials.FindAll(o => getStatusByIDStatus(o.IDStatus).Contains(searchingText));
                    break;
            }
            LoadInfoOfMaterialsToLsvInfoOfMaterial(searchedInfoOfMaterials);
        }

        private void cbb_InfoOfMaterial_SortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbb_InfoOfMaterial_SortBy.Text)
            {
                case "ID":
                    searchedInfoOfMaterials = searchedInfoOfMaterials.OrderBy(o => o.IDInfoOfMaterial).ToList();
                    break;
                case "Name":
                    searchedInfoOfMaterials = searchedInfoOfMaterials.OrderBy(o => o.Name).ToList();
                    break;
                case "Unit":
                    searchedInfoOfMaterials = searchedInfoOfMaterials.OrderBy(o => getUnitByIDUnit(o.IDUnit)).ToList();
                    break;
                case "Price":
                    searchedInfoOfMaterials = searchedInfoOfMaterials.OrderBy(o => o.Price).ToList();
                    break;
                case "Supplier":
                    searchedInfoOfMaterials = searchedInfoOfMaterials.OrderBy(o => getIDNameSupplier(o.IDSupplier)).ToList();
                    break;
                case "Status":
                    searchedInfoOfMaterials = searchedInfoOfMaterials.OrderBy(o => getStatusByIDStatus(o.IDStatus)).ToList();
                    break;
            }
            LoadInfoOfMaterialsToLsvInfoOfMaterial(searchedInfoOfMaterials);
        }

        private void btn_InfoOfMaterial_Delete_Click(object sender, EventArgs e)
        {
            string iD;
            if (lsv_InfoOfMaterial.SelectedItems.Count > 0)
            {
                iD = searchedInfoOfMaterials.ElementAt(lsv_InfoOfMaterial.SelectedItems[0].Index).IDInfoOfMaterial;

            }
            else
            {
                lb_InforOfMaterial_Notify.Text = "NOTIFY: Please select Row in table";
                return;
            }

            foreach(DetailOfBillExport item in DetailOfBillExportDAO.Instance.GetDetailOfBillExports())
            {
                if(item.IDMaterial == iD)
                {
                    MessageBox.Show("There is a billExport relation to this Material", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    return;
                }
            }

            foreach(Material item in materials)
            {
                if(item.IDMaterial == iD)
                {
                    MessageBox.Show("There is a Material in Warehouse relation to this Material", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    return;
                }
            }

            if (InforOfMaterialDAO.Instance.DeleteInfoOfMaterial(iD))
            {
                lb_InforOfMaterial_Notify.Text = "NOTIFY: Information of material was deleted successfully";
                LoadInfoOfMaterial();
            }
            else
            {
                lb_InforOfMaterial_Notify.Text = "NOTIFY: failed to delete";
            }
        }

        private void btn_InfoOfMaterial_Update_Click(object sender, EventArgs e)
        {
            string iD;
            if (lsv_InfoOfMaterial.SelectedItems.Count > 0)
            {
                iD = searchedInfoOfMaterials.ElementAt(lsv_InfoOfMaterial.SelectedItems[0].Index).IDInfoOfMaterial;

            }
            else
            {
                lb_InforOfMaterial_Notify.Text = "NOTIFY: Please select Row in table";
                return;
            }

            string name = txb_InforOfMaterial_Name.Text;
            if (name == "")
            {
                lb_InforOfMaterial_Notify.Text = "NOTIFY: Name can't be empty";
                txb_InforOfMaterial_Name.Focus();
                return;
            }

            if(!checkItemInCombobox(cbb_InforOfMaterial_Unit.Text, cbb_InforOfMaterial_Unit))
            {
                lb_InforOfMaterial_Notify.Text = "NOTIFY: Please choose one Unit in Combobox";
                lb_InfoOfMaterial_Unit.Focus();
                return;
            }
            int iDUnit = cbb_InforOfMaterial_Unit.SelectedIndex;

            int price = int.Parse(nud_InforOfMaterial_Price.Text);
            if (price < 1000)
            {
                lb_InforOfMaterial_Notify.Text = "NOTIFY: Price can't be lower than 1000VND";
                nud_InforOfMaterial_Price.Focus();
                return;
            }

            if (!checkItemInCombobox(cbb_InforOfMaterial_Supplier.Text, cbb_InforOfMaterial_Supplier))
            {
                lb_InforOfMaterial_Notify.Text = "NOTIFY: Please select Supplier in Combobox";
                cbb_InforOfMaterial_Supplier.Focus();
                return;
            }
            string supplier = cbb_InforOfMaterial_Supplier.Text.Split('-')[0];

            if (!checkItemInCombobox(cbb_InfoOfMaterial_Status.Text, cbb_InfoOfMaterial_Status))
            {
                lb_InforOfMaterial_Notify.Text = "NOTIFY: Please select Status in Combobox";
                cbb_InfoOfMaterial_Status.Focus();
                return;
            }
            int status = cbb_InfoOfMaterial_Status.SelectedIndex;

            if (InforOfMaterialDAO.Instance.UpdateInfoOfMaterial(iD, name, iDUnit, price, supplier, status))
            {
                lb_InforOfMaterial_Notify.Text = "NOTIFY: Information of material was updated successfully";
                LoadInfoOfMaterial();
                newInforOfMaterial();
            }
            else
            {
                lb_InforOfMaterial_Notify.Text = "NOTIFY: failed to update";
            }
        }

        private void btn_InforOfMaterial_Add_Click(object sender, EventArgs e)
        {
            string iD = getIDIncrea(lastIDInfoOfMaterial);

            string name = txb_InforOfMaterial_Name.Text;
            if (name == "")
            {
                lb_InforOfMaterial_Notify.Text = "NOTIFY: Name can't be empty";
                txb_InforOfMaterial_Name.Focus();
                return;
            }

            if (!checkItemInCombobox(cbb_InforOfMaterial_Unit.Text, cbb_InforOfMaterial_Unit))
            {
                lb_InforOfMaterial_Notify.Text = "NOTIFY: Please choose one Unit in Combobox";
                lb_InfoOfMaterial_Unit.Focus();
                return;
            }
            int iDUnit = cbb_InforOfMaterial_Unit.SelectedIndex;

            int price = int.Parse(nud_InforOfMaterial_Price.Text);
            if (price < 1000)
            {
                lb_InforOfMaterial_Notify.Text = "NOTIFY: Price can't be lower than 1000VND";
                nud_InforOfMaterial_Price.Focus();
                return;
            }

            if(!checkItemInCombobox(cbb_InforOfMaterial_Supplier.Text, cbb_InforOfMaterial_Supplier))
            {
                lb_InforOfMaterial_Notify.Text = "NOTIFY: Please select Supplier in Combobox";
                cbb_InforOfMaterial_Supplier.Focus();
                return;
            }
            string supplier = cbb_InforOfMaterial_Supplier.Text.Split('-')[0];

            if (!checkItemInCombobox(cbb_InfoOfMaterial_Status.Text, cbb_InfoOfMaterial_Status))
            {
                lb_InforOfMaterial_Notify.Text = "NOTIFY: Please select Status in Combobox";
                cbb_InfoOfMaterial_Status.Focus();
                return;
            }
            int status = cbb_InfoOfMaterial_Status.SelectedIndex;

            if (InforOfMaterialDAO.Instance.AddInfoOfMaterial(iD, name, iDUnit, price, supplier, status))
            {
                lb_InforOfMaterial_Notify.Text = "NOTIFY: InforOfMaterial was added successfully";
                LoadInfoOfMaterial();
            }
            else
            {
                lb_InforOfMaterial_Notify.Text = "NOTIFY: failed to added";
            }
        }
        #endregion

        #region BillEvent

        private void txb_Bill_Search_TextChanged(object sender, EventArgs e)
        {
            string searchingText = txb_Bill_Search.Text;
            switch (cbb_Bill_SearchBy.Text)
            {
                case "ID of Bill":
                    searchedBills = bills.FindAll(o => o.IDBill.Contains(searchingText));
                    break;
                case "Branch":
                    searchedBills = bills.FindAll(o => getIDNameBranch(o.IDBranch).Contains(searchingText));
                    break;
                case "Day Check In":
                    searchedBills = bills.FindAll(o => o.DateCheckIn.ToString().Contains(searchingText));
                    break;
            }
            LoadBillsToLsvBill(searchedBills);
        }

        private void cbb_Bill_SortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbb_Bill_SortBy.Text)
            {
                case "ID of Bill":
                    searchedBills = bills.OrderBy(o => o.IDBill).ToList();
                    break;
                case "Branch":
                    searchedBills = bills.OrderBy(o => getIDNameBranch(o.IDBranch)).ToList();
                    break;
                case "Day Check In":
                    searchedBills = bills.OrderBy(o => o.DateCheckIn).ToList();
                    break;
            }
            LoadBillsToLsvBill(searchedBills);
        }

        private void btn_Bill_NewClick(object sender, EventArgs e)
        {
            newBill();
        }

        private void btn_Bill_AddClick(object sender, EventArgs e)
        {
            string IDBill = txb_Bill_IDBill.Text;
            foreach(Bill item in bills)
            {
                if(IDBill == item.IDBill)
                {
                    lb_Bill_Notify.Text = "WARNING: ID was existed in database, please press new for new ID";
                    btn_Bill_Clear.Focus();
                    return;
                }
            }
            string IDBranch = cbb_Bill_Branch.SelectedItem.ToString();
            if(IDBranch == "")
            {
                lb_Bill_Notify.Text = "WARNING: ID of branch can't be empty";
                cbb_Bill_Branch.Focus();
                return;
            }
            DateTime dateCheckIn = dtp_Bill_DateCheckIn.Value;

            if (BillDAO.Instance.AddBill(IDBill, IDBranch, dateCheckIn))
            {
                lb_Bill_Notify.Text = "NOTIFY: Bill was added Successfully";
                LoadBill();
                newBill();
            }
            else
            {
                lb_Bill_Notify.Text = "NOTIFY: Failed to added bill";
            }
        }

        private void btn_Bill_UpdateClick(object sender, EventArgs e)
        {
            string IDBill = txb_Bill_IDBill.Text;

            string IDBranch = cbb_Bill_Branch.SelectedItem.ToString();
            if (IDBranch == "")
            {
                lb_Bill_Notify.Text = "WARNING: ID of branch can't be empty";
                return;
            }

            DateTime dateCheckIn = dtp_Bill_DateCheckIn.Value;

            if (BillDAO.Instance.UpdateBill(IDBill, IDBranch, dateCheckIn))
            {
                lb_Bill_Notify.Text = "NOTIFY: Bill was updated Successfully";
                LoadBill();
            }
            else
            {
                lb_Bill_Notify.Text = "NOTIFY: Failed to update bill";
            }
        }

        private void btn_Bill_DeleteClick(object sender, EventArgs e)
        {
            string IDBill = txb_Bill_IDBill.Text;

            if (BillDAO.Instance.DeleteBill(IDBill))
            {
                lb_Bill_Notify.Text = "NOTIFY: Bill was deleted Successfully";
                LoadBill();
            }
            else
            {
                lb_Bill_Notify.Text = "NOTIFY: Failed to delete bill";
            }
        }

        #endregion

        #region SupplierEvent

        private void txb_Supplier_Search_TextChanged(object sender, EventArgs e)
        {
            string searchingText = txb_Supplier_Search.Text;
            switch (cbb_Supplier_SearchBy.Text)
            {
                case "ID":
                    searchedSuppliers = suppliers.FindAll(o => o.IDSupplier.Contains(searchingText));
                    break;
                case "Name":
                    searchedSuppliers = suppliers.FindAll(o => o.Name.Contains(searchingText));
                    break;
                case "Address":
                    searchedSuppliers = suppliers.FindAll(o => o.Address.Contains(searchingText));
                    break;
                case "Status":
                    searchedSuppliers = suppliers.FindAll(o => getStatusByIDStatus(o.IDStatus).Contains(searchingText));
                    break;
            }
            LoadSuppliersToLsvSupplier(searchedSuppliers);
        }

        private void cbb_Supplier_SortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbb_Supplier_SortBy.Text)
            {
                case "ID":
                    searchedSuppliers = suppliers.OrderBy(o => o.IDSupplier).ToList();
                    break;
                case "Name":
                    searchedSuppliers = suppliers.OrderBy(o => o.Name).ToList();
                    break;
                case "Address":
                    searchedSuppliers = suppliers.OrderBy(o => o.Address).ToList();
                    break;
                case "Status":
                    searchedSuppliers = suppliers.OrderBy(o => getStatusByIDStatus(o.IDStatus)).ToList();
                    break;
            }
            LoadSuppliersToLsvSupplier(searchedSuppliers);
        }

        private void btn_Supplier_Add_Click(object sender, EventArgs e)
        {
            string iD = getIDIncrea(lastIDSupplier);

            string Name = txt_Supplier_Name.Text.Trim();
            if (Name == "")
            {
                lb_Supplier_Notify.Text = "NOTIFY: Name cann't be empty!";
                txt_Supplier_Name.Focus();
                return;
            }

            string Address = txt_Supplier_Address.Text.Trim();
            if (Address == "")
            {
                lb_Supplier_Notify.Text = "NOTIFY: Address cann't be empty!";
                txt_Supplier_Address.Focus();
                return;
            }

            if(!checkItemInCombobox(cbb_Supplier_Status.Text, cbb_Supplier_Status))
            {
                lb_Supplier_Notify.Text = "NOTIFY: Please choose one Status in Combobox";
                cbb_Supplier_Status.Focus();
                return;
            }
            int status = cbb_Supplier_Status.SelectedIndex;

            if (SupplierDAO.Instance.AddSupplier(iD, Name, Address, status))
            {
                lb_Supplier_Notify.Text = "NOTIFY: Supplier Was Added successfully!";
                LoadSupplier();
                newSupplier();
            }
            else
            {
                lb_Supplier_Notify.Text = "NOTIFY: Failed To Add Supplier";
            }
        }

        private void btn_Supplier_Delete_Click(object sender, EventArgs e)
        {
            string iD;

            if (lsv_Supplier.SelectedItems.Count > 0)
            {
                iD = searchedSuppliers.ElementAt(lsv_Supplier.SelectedItems[0].Index).IDSupplier;
            }
            else
            {
                lb_Supplier_Notify.Text = "NOTIFY: Please select row in Table";
                return;
            }

            foreach(InforOfMaterial inforOfMaterial in infoOfMaterials)
            {
                if(inforOfMaterial.IDSupplier == iD)
                {
                    MessageBox.Show("There is a info of material ralate to this supplier", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    return;
                }
            }

            if (MessageBox.Show("Are you sure you want to delete this Supplier", "Delete Supplier", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) != System.Windows.Forms.DialogResult.Yes)
            {
                return;
            }
            if (SupplierDAO.Instance.DeleteSupplier(iD))
            {
                lb_Supplier_Notify.Text = "NOTIFY: Supplier Was Deleted Successfully!";
                LoadSupplier();
            }
            else
            {
                lb_Supplier_Notify.Text = "NOTIFY: Fail To Delete Supplier!";
                return;
            }

        }

        private void btn_Supplier_Update_Click(object sender, EventArgs e)
        {
            string iD;
            if (lsv_Supplier.SelectedItems.Count > 0)
            {
                iD = searchedSuppliers.ElementAt(lsv_Supplier.SelectedItems[0].Index).IDSupplier;
            }
            else
            {
                lb_Supplier_Notify.Text = "NOTIFY: Please choose one row in Table!";
                return;
            }

            string Name = txt_Supplier_Name.Text.Trim();
            if (Name == "")
            {
                lb_Supplier_Notify.Text = "NOTIFY: Name cann't be empty!";
                txt_Supplier_Name.Focus();
                return;
            }
            string Address = txt_Supplier_Address.Text.Trim();
            if (Address == "")
            {
                lb_Supplier_Notify.Text = "NOTIFY: Address cann't be empty!";
                txt_Supplier_Address.Focus();
                return;
            }
            foreach (Supplier item in suppliers)
            {
                if (item.IDSupplier == iD)
                {
                    if (item.Address == Address && item.Name == Name)
                    {
                        lb_Supplier_Notify.Text = "NOTIFY: Nothing Change To Update!!";
                        return;
                    }
                }
            }

            if(!checkItemInCombobox(cbb_Supplier_Status.Text, cbb_Supplier_Status))
            {
                lb_Supplier_Notify.Text = "NOTIFY: Please choose Status in Combobox";
                cbb_Supplier_Status.Focus();
                return;
            }
            int status = cbb_Supplier_Status.SelectedIndex;

            if (SupplierDAO.Instance.UpdateSupplier(iD, Name, Address, status))
            {
                lb_Supplier_Notify.Text = "NOTIFY: Supplier Was Updated Successfully!!";
                LoadSupplier();
            }
            else
            {
                lb_Supplier_Notify.Text = "NOTIFY: Failed to update Supplier!";
            }
        }

        #endregion

        #region Warehouse

        private void txb_Warehouse_Search_TextChanged(object sender, EventArgs e)
        {
            string searchingText = txb_Account_Search.Text;
            switch (cbb_Warehouse_SearchBy.Text)
            {
                case "ID of Material":
                    searchedMaterials = materials.FindAll(o => o.IDMaterial.Contains(searchingText));
                    break;
                case "ID information of Material":
                    searchedMaterials = materials.FindAll(o => getIDNameInfoOfMaterial(o.IDMaterial).Contains(searchingText));
                    break;
                case "Amount":
                    searchedMaterials = materials.FindAll(o => o.Amount.ToString().Contains(searchingText));
                    break;
                case "AmountLeft":
                    searchedMaterials = materials.FindAll(o => o.AmountLeft.ToString().Contains(searchingText));
                    break;
                case "Date Added":
                    searchedMaterials = materials.FindAll(o => o.DateAdded.ToString().Contains(searchingText));
                    break;
                case "Expiry Date":
                    searchedMaterials = materials.FindAll(o => o.ExpiryDate.ToString().Contains(searchingText));
                    break;
            }
            LoadMaterialToLsvMaterial(searchedMaterials);
        }

        private void cbb_Warehouse_SortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbb_Warehouse_SortBy.Text)
            {
                case "ID of Material":
                    searchedMaterials = searchedMaterials.OrderBy(o => o.IDMaterial).ToList();
                    break;
                case "ID infomation of Material":
                    searchedMaterials = searchedMaterials.OrderBy(o => getIDNameInfoOfMaterial(o.IDMaterial)).ToList();
                    break;
                case "Amount":
                    searchedMaterials = searchedMaterials.OrderBy(o => o.Amount).ToList();
                    break;
                case "AmountLeft":
                    searchedMaterials = searchedMaterials.OrderBy(o => o.AmountLeft).ToList();
                    break;
                case "Date Added":
                    searchedMaterials = searchedMaterials.OrderBy(o => o.DateAdded).ToList();
                    break;
                case "Expiry Date":
                    searchedMaterials = searchedMaterials.OrderBy(o => o.ExpiryDate).ToList();
                    break;
            }
            LoadMaterialToLsvMaterial(searchedMaterials);
        }

        private void btn_Warehouse_NewClick(object sender, EventArgs e)
        {
            txb_Warehouse_IDMaterial.Text = getIDIncrea(lastIDMaterial);
            cbb_Warehouse_IDInfoOfMaterial.SelectedItem = cbb_Warehouse_IDInfoOfMaterial.Items[0];
            nud_Warehouse_Amount.Value = 0;
            nud_Warehouse_AmountLeft.Value = 0;
            dtp_Warehouse_DateImport.Value = DateTime.Now;
            dtp_Warehouse_ExpiryDate.Value = DateTime.Now;
        }

        private void btn_Warehouse_AddClick(object sender, EventArgs e)
        {
            string IDMaterial = getIDIncrea(lastIDMaterial);

            if (!checkItemInCombobox(cbb_Warehouse_IDInfoOfMaterial.Text, cbb_Warehouse_IDInfoOfMaterial))
            {
                lb_Warehouse_Notify.Text = "NOTIFY: Please choose one Material in Combobox";
                return;
            }
            string IDInforOfMaterial = cbb_Warehouse_IDInfoOfMaterial.Text.Split('-')[0];

            int amount = (int)nud_Warehouse_Amount.Value;
            if (amount <= 0)
            {
                lb_Warehouse_Notify.Text = "NOTIFY: Amount must be greater than 0";
                nud_Warehouse_Amount.Focus();
                return;
            }
            int amountLeft = (int)nud_Warehouse_AmountLeft.Value;
            if (amountLeft <= 0)
            {
                lb_Warehouse_Notify.Text = "NOTIFY: Amount left must be greater than 0";
                nud_Warehouse_AmountLeft.Focus();

                return;
            }
            DateTime dateAdded = dtp_Warehouse_DateImport.Value;
            DateTime expiryDate = dtp_Warehouse_ExpiryDate.Value;
            if (DAO.MaterialDAO.Instance.AddMaterial(IDMaterial, IDMaterial, amount, amountLeft, dateAdded, expiryDate))
            {
                lb_Warehouse_Notify.Text = "NOTIFY: Material was added Successfully";
                LoadMaterial();
            }
            else
            {
                lb_Warehouse_Notify.Text = "NOTIFY: Failed to add Material";
            }
        }

        private void btn_Warehouse_DeleteClick(object sender, EventArgs e)
        {
            string IDMaterial;
            if (lsv_Warehouse.SelectedItems.Count > 0)
            {
                IDMaterial = lsv_Warehouse.SelectedItems[0].SubItems[0].Text;
            }
            else
            {
                lb_Warehouse_Notify.Text = "NOTIFY: Please choose one Row in Table";
                return;
            }

            if (DAO.MaterialDAO.Instance.DeleteMaterial(IDMaterial))
            {
                lb_Warehouse_Notify.Text = "NOTIFY: Material was deleted Successfully";
                LoadMaterial();
            }
            else
            {
                lb_Warehouse_Notify.Text = "NOTIFY: Failed to delete Material";
            }
        }

        private void btn_Warehouse_UpdateClick(object sender, EventArgs e)
        {
            string IDMaterial;
            if (lsv_Warehouse.SelectedItems.Count > 0)
            {
                IDMaterial = lsv_Warehouse.SelectedItems[0].SubItems[0].Text;
            }
            else
            {
                lb_Warehouse_Notify.Text = "NOTIFY: Please choose one Row in Table";
                return;
            }

            if (!checkItemInCombobox(cbb_Warehouse_IDInfoOfMaterial.Text, cbb_Warehouse_IDInfoOfMaterial))
            {
                lb_Warehouse_Notify.Text = "NOTIFY: Please choose one Material in Combobox";
                return;
            }
            string IDInfoOfMaterial = cbb_Warehouse_IDInfoOfMaterial.Text.Split('-')[0];

            int amount = (int)nud_Warehouse_Amount.Value;
            if (amount <= 0)
            {
                lb_Warehouse_Notify.Text = "NOTIFY: Amount must be greater than 0";
                nud_Warehouse_Amount.Focus();
                return;
            }
            int amountLeft = (int)nud_Warehouse_AmountLeft.Value;
            if (amountLeft <= 0)
            {
                lb_Warehouse_Notify.Text = "NOTIFY: Amount left must be greater than 0";
                nud_Warehouse_AmountLeft.Focus();

                return;
            }
            DateTime dateAdded = dtp_Warehouse_DateImport.Value;
            DateTime expiryDate = dtp_Warehouse_ExpiryDate.Value;
            if (DAO.MaterialDAO.Instance.UpdateMaterial(IDMaterial, IDMaterial, amount, amountLeft, dateAdded, expiryDate))
            {
                lb_Warehouse_Notify.Text = "NOTIFY: Material was updated Successfully";
                LoadMaterial();
            }
            else
            {
                lb_Warehouse_Notify.Text = "NOTIFY: Failed to update Material";
            }
        }
        #endregion

        #region BillExportEvent

        private void txb_BillExport_search_TextChanged(object sender, EventArgs e)
        {
            string searchingText = txb_BillExport_search.Text;
            switch (cbb_BillExport_SearchBy.Text)
            {
                case "ID of Bill Export":
                    searchedBillExports = billExports.FindAll(item => item.IDBillExport.Contains(searchingText));
                    break;
                case "Date":
                    searchedBillExports = billExports.FindAll(item => item.Date.ToString().Contains(searchingText));
                    break;
                case "Branch":
                    searchedBillExports = billExports.FindAll(item => getIDNameBranch(item.IDBranch).Contains(searchingText));
                    break;
            }
            LoadBillExportsToLsvBillExport(searchedBillExports);
        }

        private void cbb_BillExport_SortBy_SelectedIndexChanged(object sender, EventArgs e)
        {;
            switch (cbb_BillExport_SortBy.Text)
            {
                case "ID of Bill Export":
                    searchedBillExports = searchedBillExports.OrderBy(item => item.IDBillExport).ToList();
                    break;
                case "Date":
                    searchedBillExports = searchedBillExports.OrderBy(item => item.Date).ToList();
                    break;
                case "Branch":
                    searchedBillExports = searchedBillExports.OrderBy(item => getIDNameBranch(item.IDBranch)).ToList();
                    break;
            }
            LoadBillExportsToLsvBillExport(searchedBillExports);
        }

        private void btn_BillExport_New_Click(object sender, EventArgs e)
        {
            newBillExport();
            cbb_BillExport_Branch.SelectedIndex = -1;
            dtp_BillExport_Date.Value = DateTime.Now;
            nm_BillExport_TotalPrice.Value = 0000;
        }

        private void btn_BillExport_Add_Click(object sender, EventArgs e)
        {
            lastIDBillExport = getIDIncrea(lastIDBillExport);
            string IDBillExport = txt_BillExport_ID.Text;
            foreach (BillExport item in billExports)
            {
                if (IDBillExport == item.IDBillExport)
                {
                    lb_BillExport_Notify.Text = "WARNING: ID was existed in database, please press new for new ID";
                    return;
                }
            }
            string IDBranch = cbb_BillExport_Branch.Text;
            if (IDBranch == "")
            {
                lb_BillExport_Notify.Text = "WARNING: ID of branch can't be empty";
                cbb_BillExport_Branch.Focus();
                return;
            }
            DateTime dateCheckIn = dtp_BillExport_Date.Value;

            if (BillExportDAO.Instance.AddBillExport(IDBillExport, IDBranch, dateCheckIn))
            {
                lb_BillExport_Notify.Text = "NOTIFY: Bill Export was added Successfully";
                LoadBillExport();
            }
            else
            {
                lb_BillExport_Notify.Text = "NOTIFY: Failed to added bill export";
            }
        }

        private void btn_BillExport_Update_Click(object sender, EventArgs e)
        {

            string IDBillExport = txt_BillExport_ID.Text;
            string IDBranch = cbb_BillExport_Branch.Text;
            if (IDBranch == "")
            {
                lb_BillExport_Notify.Text = "WARNING: ID of branch can't be empty";
                cbb_BillExport_Branch.Focus();
                return;
            }
            DateTime date = dtp_BillExport_Date.Value;

            if (BillExportDAO.Instance.UpdateBillExport(IDBillExport, IDBranch, date))
            {
                lb_BillExport_Notify.Text = "NOTIFY: Bill export was updated Successfully";
                LoadBillExport();
            }
            else
            {
                lb_BillExport_Notify.Text = "NOTIFY: Failed to update bill export";
            }

        }

        private void btn_BillExport_Delete_Click(object sender, EventArgs e)
        {
            string IDBillExport = txt_BillExport_ID.Text.Trim();
            if (MessageBox.Show("Are you sure you want to delete this bill export", "Delete Bill Export", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                if (BillExportDAO.Instance.DeleteBillExport(IDBillExport))
                {
                    MessageBox.Show("Bill Export Was Deleted Successfully!");
                    LoadBillExport();
                }
                else
                {
                    MessageBox.Show("Fail To Delete Bill Export!");
                    return;
                }
            }
        }
        
        private void newBillExport()
        {
            txt_BillExport_ID.Text = getIDIncrea(lastIDBillExport);
        }

        #endregion

        #endregion

        private void newDrink()
        {
            txb_Drink_Name.Text = "";
            nud_Drink_Price.Value = 20000;
            txb_Drink_Name.Focus();
        }

        private void newBranch()
        {
            txb_branch_Name.Text = "";
            txb_branch_Manager.Text = "";
            txb_branch_Name.Focus();
        }

        private void newAccount()
        {
            txb_Account_Username.Text = "";
            if (cbb_Account_Employee.Items.Count > 0)
            {
                cbb_Account_Employee.Text = cbb_Account_Employee.Items[0].ToString();
            }
            cbb_Account_AccountType.Text = cbb_Account_AccountType.Items[0].ToString();
        }

        private void newEmployee()
        {
            txb_Employee_IDEmPloyee.Text = getIDIncrea(lastIDEmployees);
            txb_Employee_FirstName.Text = "";
            txb_Employee_LastName.Text = "";
            txb_Employee_PhoneNumber.Text = "";
            cbb_Employee_Sexual.SelectedItem = cbb_Employee_Sexual.Items[0];
            txb_Employee_Address.Text = "";
            dtp_Employee_DayIn.Value = DateTime.Today;
            nud_Employee_NumberOfDayOff.Value = 10;
            cbb_Employee_Type.SelectedIndex = 1;
            cbb_Employee_Branch.SelectedItem = cbb_Employee_Branch.Items[0];
            cbb_Employee_Status.SelectedIndex = 1;
            txb_Employee_FirstName.Focus();
        }

        private void newInforOfMaterial()
        {
            txb_InforOfMaterial_Name.Text = "";
            cbb_InforOfMaterial_Unit.Text = "";
            nud_InforOfMaterial_Price.Value = 100000;
            cbb_InforOfMaterial_Supplier.SelectedItem = cbb_InforOfMaterial_Supplier.Items[0];
            txb_InforOfMaterial_Name.Focus();
        }

        private void newBill()
        {
            txb_Bill_IDBill.Text = getIDIncrea(lastIDBill);
            cbb_Bill_Branch.SelectedItem = cbb_Bill_Branch.Items[0];
            dtp_Bill_DateCheckIn.Value = DateTime.Now;
            nud_Bill_TotalAmount.Value = 100000;
            cbb_Bill_Branch.Focus();
        }

        private void newSupplier()
        {
            txt_Supplier_Name.Text = "";
            txt_Supplier_Address.Text = "";
        }

        private void UpdateCbbBranchInTabEmployee()
        {
            cbb_Employee_Branch.Items.Clear();
            if(branches.Count > 0)
            {
                foreach (Branch item in branches)
                {
                    cbb_Employee_Branch.Items.Add(item.IDBranch+"-"+BranchDAO.Instance.GetNameByID(item.IDBranch));
                }
                cbb_Employee_Branch.SelectedItem = cbb_Employee_Branch.Items[0];
            }
        }
        
        private void UpdateCbbAccountIdInTabAccount()
        {
            cbb_Account_Employee.Items.Clear();
            if (employees.Count > 0)
            {
                foreach(Employee employee in employees)
                {
                    bool isHadAccount = false;
                    foreach(Account account in accounts)
                    {
                        if(account.IDEmployee == employee.IDEmployee)
                        {
                            isHadAccount = true;
                            break;
                        }
                    }
                    if(!isHadAccount)cbb_Account_Employee.Items.Add(employee.IDEmployee + "-" + EmployeeDAO.Instance.GetNameByIDEmployee(employee.IDEmployee));
                }
                if (cbb_Account_Employee.Items.Count > 0)
                {
                    cbb_Account_Employee.SelectedItem = cbb_Account_Employee.Items[0];
                }
            }
        }

        private void UpdateCbbSupplierInTabInforOfMaterial()
        {
            if (suppliers.Count > 0)
            {
                cbb_InforOfMaterial_Supplier.Items.Clear();
                foreach(Supplier supplier in suppliers)
                {
                    cbb_InforOfMaterial_Supplier.Items.Add(supplier.IDSupplier+"-"+ SupplierDAO.Instance.GetNameByID(supplier.IDSupplier));
                }
                cbb_InforOfMaterial_Supplier.SelectedItem = cbb_InforOfMaterial_Supplier.Items[0];
            }
        }

        private void UpdateCbbBranchInTabBill()
        {
            if (branches.Count > 0)
            {
                cbb_Bill_Branch.Items.Clear();
                foreach(Branch branch in branches)
                {
                    cbb_Bill_Branch.Items.Add(branch.IDBranch + "-" + BranchDAO.Instance.GetNameByID(branch.IDBranch));
                }
                cbb_Bill_Branch.SelectedItem = cbb_Bill_Branch.Items[0];
            }
        }

        private void UpdateCbbBranchInTabBillExport()
        {
            if (branches.Count > 0)
            {
                cbb_BillExport_Branch.Items.Clear();
                foreach (Branch branch in branches)
                {
                    cbb_BillExport_Branch.Items.Add(branch.IDBranch + "-" + BranchDAO.Instance.GetNameByID(branch.IDBranch));
                }
                cbb_BillExport_Branch.SelectedItem = cbb_BillExport_Branch.Items[0];
            }
        }

        private void UpdateCbbMaterialInTabWarehouse()
        {
            cbb_Warehouse_IDInfoOfMaterial.Items.Clear();
            if (infoOfMaterials.Count > 0)
            {
                foreach(InforOfMaterial inforOfMaterial in infoOfMaterials)
                {
                    cbb_Warehouse_IDInfoOfMaterial.Items.Add(inforOfMaterial.IDInfoOfMaterial + "-" + inforOfMaterial.Name);
                }
                cbb_Warehouse_IDInfoOfMaterial.SelectedIndex = 0;
            }
        }

        public static string getIDIncrea(string ID)
        {
            string iD_Temp;
            int num;
            num = int.Parse(ID.Substring(2));
            if (num < 9)
            {
                iD_Temp = ID.Substring(0, 3);
            }
            else
            {
                iD_Temp = ID.Substring(0, 2);
            }
            num++;
            iD_Temp = String.Concat(iD_Temp, num);
            return iD_Temp;
        }

        private void getDetailOfBilltoLsv()
        {
            string IDBill = txb_Bill_IDBill.Text;
            lsvDetailOfBill.Items.Clear();
            List<DetailOfBill> detailOfBills = new List<DetailOfBill>();
            detailOfBills = DetailOfBillDAO.Instance.GetDetailOfBills(IDBill);
            foreach (DetailOfBill item in detailOfBills)
            {
                Drink drink = new Drink();
                foreach (Drink tmp in drinks)
                {
                    if (item.IDDrink == tmp.ID)
                    {
                        drink = tmp;
                        break;
                    }
                }
                ListViewItem lsvItem = new ListViewItem(drink.Name.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(drink.Price.ToString());
                int totalAmount = item.Count * drink.Price;
                lsvItem.SubItems.Add(totalAmount.ToString());
                lsvDetailOfBill.Items.Add(lsvItem);
            }
        }

        private string getIDNameEmployee(string IDEmployee)
        {
            return IDEmployee + "-" + EmployeeDAO.Instance.GetNameByIDEmployee(IDEmployee);
        }

        private string getIDNameBranch(string IDBranch)
        {
            return IDBranch + "-" + BranchDAO.Instance.GetNameByID(IDBranch);
        }

        private string getIDNameInfoOfMaterial(string IDInfoOfMaterial)
        {
            return IDInfoOfMaterial + "-" + InforOfMaterialDAO.Instance.GetNameByID(IDInfoOfMaterial);
        }

        private string getIDNameSupplier(string IDSupplier)
        {
            return IDSupplier + "-" + SupplierDAO.Instance.GetNameByID(IDSupplier);
        }

        private string getTypeEmployeeByIDTypeEmployee(int iD)
        {
            return iD==0 ? "PartTime" : "FullTime";
        }

        private string getTypeAccountByIDTypeAccount(int iD)
        {
            return iD == 0 ? "Admin" : "Employee";
        }

        private string getStatusByIDStatus(int iD)
        {
            return iD == 0 ? "NotUse" : "Use";
        }

        private string getSexualByIDSexual(int iD)
        {
            switch (iD)
            {
                case 0:
                    return "Not known";
                case 1:
                    return "Male";
                case 2:
                    return "Female";
                case 9:
                    return "Not applicable";
            }
            return null;
        }

        public static string getUnitByIDUnit(int iD)
        {
            switch (iD)
            {
                case 0:
                    return "gram";
                case 1:
                    return "kilogram";
                case 2:
                    return "package";
                case 3:
                    return "bottle";
                default:
                    return null;
            }
        }

        //vùng click nhầm :)))))

        private void panel19_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        #region noUse
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tpDanhMuc_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        public static bool checkItemInCombobox(string item, ComboBox comboBox)
        {
            if (comboBox.SelectedIndex < 0) return false;
            if(comboBox.SelectedItem.ToString() == item)
            {
                return true;
            }
            return false;
        }

        #endregion

        private void lsv_Drink_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsv_Drink.SelectedItems.Count > 0)
            {
                txb_Drink_Name.Text = lsv_Drink.SelectedItems[0].SubItems[1].Text;
                nud_Drink_Price.Value = int.Parse(lsv_Drink.SelectedItems[0].SubItems[2].Text);
                cbb_Drink_Status.SelectedIndex = lsv_Drink.SelectedItems[0].SubItems[3].Text == "Use" ? 1 : 0;
            }
        }

        private void lsv_Branch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsv_Branch.SelectedItems.Count > 0)
            {
                txb_branch_Name.Text = lsv_Branch.SelectedItems[0].SubItems[1].Text;
                txb_branch_Manager.Text = lsv_Branch.SelectedItems[0].SubItems[2].Text;
                cbb_Branch_Status.SelectedIndex = lsv_Branch.SelectedItems[0].SubItems[3].Text == "Use" ? 1 : 0;
            }
        }

        private void lsv_Account_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lsv_Account.SelectedItems.Count > 0)
            {
                txb_Account_Username.Text = lsv_Account.SelectedItems[0].SubItems[0].Text;
                cbb_Account_Employee.Text = lsv_Account.SelectedItems[0].SubItems[1].Text;
                cbb_Account_AccountType.Text = lsv_Account.SelectedItems[0].SubItems[3].Text;
                cbb_Account_Status.SelectedIndex = lsv_Account.SelectedItems[0].SubItems[4].Text == "Use" ? 1 : 0;
            }
        }

        private void lsv_Employee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lsv_Employee.SelectedItems.Count > 0)
            {
                txb_Employee_IDEmPloyee.Text = lsv_Employee.SelectedItems[0].SubItems[0].Text;
                txb_Employee_FirstName.Text = lsv_Employee.SelectedItems[0].SubItems[1].Text;
                txb_Employee_LastName.Text = lsv_Employee.SelectedItems[0].SubItems[2].Text;
                txb_Employee_PhoneNumber.Text = lsv_Employee.SelectedItems[0].SubItems[3].Text;
                cbb_Employee_Sexual.Text = lsv_Employee.SelectedItems[0].SubItems[4].Text;
                txb_Employee_Address.Text = lsv_Employee.SelectedItems[0].SubItems[5].Text;
                dtp_Employee_DayIn.Text = lsv_Employee.SelectedItems[0].SubItems[6].Text;
                nud_Employee_NumberOfDayOff.Text = lsv_Employee.SelectedItems[0].SubItems[7].Text;
                cbb_Employee_Type.Text = lsv_Employee.SelectedItems[0].SubItems[8].Text;
                cbb_Employee_Branch.Text = lsv_Employee.SelectedItems[0].SubItems[9].Text;
                cbb_Employee_Status.Text = lsv_Employee.SelectedItems[0].SubItems[10].Text;
            }
        }

        private void lsv_InfoOfMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lsv_InfoOfMaterial.SelectedItems.Count> 0)
            {
                txb_InforOfMaterial_Name.Text = lsv_InfoOfMaterial.SelectedItems[0].SubItems[1].Text;
                cbb_InforOfMaterial_Unit.Text = lsv_InfoOfMaterial.SelectedItems[0].SubItems[2].Text;
                nud_InforOfMaterial_Price.Value = int.Parse(lsv_InfoOfMaterial.SelectedItems[0].SubItems[3].Text);
                cbb_InforOfMaterial_Supplier.Text = lsv_InfoOfMaterial.SelectedItems[0].SubItems[4].Text;
                cbb_InfoOfMaterial_Status.SelectedIndex = lsv_InfoOfMaterial.SelectedItems[0].SubItems[5].Text == "Use" ? 1 : 0;
            }
        }

        private void lsv_Bill_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsv_Bill.SelectedItems.Count > 0)
            {
                txb_Bill_IDBill.Text = lsv_Bill.SelectedItems[0].SubItems[0].Text;
                cbb_Bill_Branch.Text = lsv_Bill.SelectedItems[0].SubItems[1].Text;
                dtp_Bill_DateCheckIn.Value = DateTime.Parse(lsv_Bill.SelectedItems[0].SubItems[2].Text);
                nud_Bill_TotalAmount.Value = int.Parse(lsv_Bill.SelectedItems[0].SubItems[3].Text);
            }
        }

        private void lsv_Supplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsv_Supplier.SelectedItems.Count > 0)
            {
                txt_Supplier_Name.Text = lsv_Supplier.SelectedItems[0].SubItems[1].Text;
                txt_Supplier_Address.Text = lsv_Supplier.SelectedItems[0].SubItems[2].Text;
                cbb_Supplier_Status.SelectedIndex = lsv_Supplier.SelectedItems[0].SubItems[3].Text == "Use" ? 1 : 0;
            }
        }

        private void lsv_Warehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lsv_Warehouse.SelectedItems.Count >0)
            {
                txb_Warehouse_IDMaterial.Text = lsv_Warehouse.SelectedItems[0].SubItems[0].Text;
                cbb_Warehouse_IDInfoOfMaterial.Text = lsv_Warehouse.SelectedItems[0].SubItems[1].Text;
                nud_Warehouse_Amount.Text = lsv_Warehouse.SelectedItems[0].SubItems[2].Text;
                nud_Warehouse_AmountLeft.Text = lsv_Warehouse.SelectedItems[0].SubItems[3].Text;
                dtp_Warehouse_DateImport.Text = lsv_Warehouse.SelectedItems[0].SubItems[4].Text;
                dtp_Warehouse_DateImport.Text = lsv_Warehouse.SelectedItems[0].SubItems[5].Text;
            }
        }

        private void lsv_BillExport_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsv_BillExport.SelectedItems.Count > 0)
            {
                txt_BillExport_ID.Text = lsv_BillExport.SelectedItems[0].SubItems[0].Text;
                cbb_BillExport_Branch.Text = lsv_BillExport.SelectedItems[0].SubItems[1].Text;
                dtp_BillExport_Date.Value = DateTime.Parse(lsv_BillExport.SelectedItems[0].SubItems[2].Text);

                BillExport billexport = searchedBillExports.ElementAt(lsv_BillExport.SelectedItems[0].Index);

                List<DetailOfBillExport> detailOfBillExports =  DetailOfBillExportDAO.Instance.GetDetailOfBillExports(billexport.IDBillExport);
                int totalAmount = 0;
                lsv_BillExport_DetailOfBillExport.Items.Clear();
                foreach (DetailOfBillExport item in detailOfBillExports)
                {
                    Material material = MaterialDAO.Instance.GetMaterial(item.IDMaterial);
                    InforOfMaterial inforOfMaterial = InforOfMaterialDAO.Instance.GetInfoOfMaterial(material.IDInfoOfMaterial);
                    ListViewItem listViewItem = new ListViewItem(inforOfMaterial.Name);
                    listViewItem.SubItems.Add(item.Count.ToString());
                    listViewItem.SubItems.Add(fAdmin.getUnitByIDUnit(inforOfMaterial.IDUnit));
                    listViewItem.SubItems.Add(inforOfMaterial.Price.ToString());
                    listViewItem.SubItems.Add(SupplierDAO.Instance.GetNameByID(inforOfMaterial.IDSupplier));
                    listViewItem.SubItems.Add(material.ExpiryDate.ToString());
                    listViewItem.SubItems.Add((item.Count * inforOfMaterial.Price).ToString());
                    lsv_BillExport_DetailOfBillExport.Items.Add(listViewItem);
                    totalAmount += item.Count * inforOfMaterial.Price;
                }
                nm_BillExport_TotalPrice.Value = totalAmount;
            }
        }

        private void btn_Drink_Clear_Click(object sender, EventArgs e)
        {
            newDrink();
        }

        private void btn_Branch_Clear_Click(object sender, EventArgs e)
        {
            newBranch();
        }

        private void btn_Account_Clear_Click(object sender, EventArgs e)
        {
            newAccount();
        }

        private void btn_InfoOfMateria_Clear_Click(object sender, EventArgs e)
        {
            newInforOfMaterial();
        }

        private void btn_Supplier_Clear_Click(object sender, EventArgs e)
        {
            newSupplier();
        }

        private void cbb_Bill_SearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnStatictis_Click(object sender, EventArgs e)
        {
            string query = string.Format("select Drink.Name,DetailOfBill.Count, Drink.Price " +
                " from bill,DetailOfBill,Drink  where DateCheckIn>='{0}' and DateCheckIn<='{1}' and " +
                "( select Name from Branch where IDBranch= bill.IDBranch)='{2}' and Bill.IDBill=DetailOfBill.IDBill and DetailOfBill.IDDrink=Drink.IDDrink",
             dtpkDateFrom.Value.ToString("yyyyMMdd"), dtpkDateTo.Value.ToString("yyyyMMdd"), cbb_Statistic_Branch.SelectedItem.ToString());

            string query1 = string.Format("select InforOfMaterial.Name,count, Count *Price as Total from BillExport, DetailOfBillExport,Material, InforOfMaterial where BillExport.IDBranch='{0}' " +
                "and BillExport.IDBillExport=DetailOfBillExport.IDBillExport and Date >= '{1}' and Date <= '{2}' and " +
                "DetailOfBillExport.IDMaterial = Material.IDMaterial and Material.IDInfoOfMaterial = InforOfMaterial.IDInfoOfMaterial",
                  cbb_Statistic_Branch.SelectedItem.ToString(),dtpkDateFrom.Value.ToString("yyyyMMdd"), dtpkDateTo.Value.ToString("yyyyMMdd"));

            float total_Re = 0;
            float total_Ex = 0;

            dtgv_Expenditure.Refresh();
            dtgv_Revenue.Refresh();
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            dtgv_Revenue.DataSource = data;

            DataTable data1 = DataProvider.Instance.ExecuteQuery(query1);
            dtgv_Expenditure.DataSource = data1;

            foreach (DataRow row in data.Rows)
            {
                total_Re+= float.Parse(row[2].ToString());

            }
            foreach (DataRow row in data1.Rows)
            {
                total_Ex+= float.Parse(row[2].ToString());

            }
            lb_Revenue_TotalRevenue.Text =total_Re.ToString("n1", CultureInfo.InvariantCulture);//để có định dạng kiểu 9,999,999.0
            lb_Revenue_TotalExpenditure.Text =total_Ex.ToString("n1", CultureInfo.InvariantCulture);//để có định dạng kiểu 9,999,999.0
            lb_Revenue_TotalIncome.Text =(total_Re-total_Ex).ToString("n1", CultureInfo.InvariantCulture);//để có định dạng kiểu 9,999,999.0

        }
    }
}
