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
    public partial class fExportMaterial : Form
    {
        private List<Material> materials = new List<Material>();
        private List<Material> searchedMaterials = new List<Material>();
        private List<DetailOfBillExport> detailOfBillExports = new List<DetailOfBillExport>();
        private string IDBillExport;

        public fExportMaterial()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            LoadCbbBranch();
            LoadCbbSearchBy();
            LoadCbbSortBy();
            materials = MaterialDAO.Instance.GetMaterials().FindAll(item => item.AmountLeft>0);
            searchedMaterials = materials;
            LoadLsvMaterial();
            GenIDBillExport();
        }

        private void GenIDBillExport()
        {
            List<BillExport> billExports = BillExportDAO.Instance.GetBillExports();
            BillExport[] arr = billExports.ToArray();
            if (arr.Length > 0)
            {
                IDBillExport = arr[arr.Length - 1].IDBillExport;
            }
            else
            {
                IDBillExport = "BE00";
            }
            IDBillExport = fAdmin.getIDIncrea(IDBillExport);
        }

        private void LoadCbbBranch()
        {
            foreach (Branch branch in BranchDAO.Instance.GetBranches())
            {
                cbbBranch.Items.Add(branch.IDBranch + "-" + branch.Name);
            }
        }

        private void LoadCbbSearchBy()
        {
            cbbSearchBy.Items.Add("Name");
            cbbSearchBy.Items.Add("Amount Left");
            cbbSearchBy.Items.Add("Unit");
            cbbSearchBy.Items.Add("Price");
            cbbSearchBy.Items.Add("Supplier");
            cbbSearchBy.Items.Add("Expiry Day");
            cbbSearchBy.SelectedItem = cbbSearchBy.Items[0];
        }

        private void LoadCbbSortBy()
        {
            cbbSortBy.Items.Add("Name");
            cbbSortBy.Items.Add("Amount Left");
            cbbSortBy.Items.Add("Unit");
            cbbSortBy.Items.Add("Price");
            cbbSortBy.Items.Add("Supplier");
            cbbSortBy.Items.Add("Expiry Day");
            cbbSortBy.SelectedItem = cbbSortBy.Items[0];
        }

        private void LoadLsvMaterial()
        {
            lsvMaterialInWarehouse.Items.Clear();
            foreach(Material item in searchedMaterials)
            {
                if (item.AmountLeft == 0) continue;
                InforOfMaterial inforOfMaterial = InforOfMaterialDAO.Instance.GetInfoOfMaterial(item.IDInfoOfMaterial);
                ListViewItem listViewItem = new ListViewItem(inforOfMaterial.Name);
                listViewItem.SubItems.Add(item.AmountLeft.ToString());
                listViewItem.SubItems.Add(fAdmin.getUnitByIDUnit(inforOfMaterial.IDUnit));
                listViewItem.SubItems.Add(inforOfMaterial.Price.ToString());
                listViewItem.SubItems.Add(SupplierDAO.Instance.GetNameByID(inforOfMaterial.IDSupplier));
                listViewItem.SubItems.Add(item.ExpiryDate.ToString("yyyy-MM-dd"));
                lsvMaterialInWarehouse.Items.Add(listViewItem);
            }
        }

        private void lsvMaterialInWarehouse_Click(object sender, EventArgs e)
        {
            if(!fAdmin.checkItemInCombobox(cbbBranch.Text, cbbBranch))
            {
                MessageBox.Show("Please choose one branch in combobox", "Missed Branch", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                cbbBranch.Focus();
                return;
            }

            if (lsvMaterialInWarehouse.SelectedItems.Count > 0)
            {
                DTO.Material materialInWarehouse = materials.ElementAt(lsvMaterialInWarehouse.SelectedItems[0].Index);
                fEnterNumberOfMaterialExport f = new fEnterNumberOfMaterialExport(materialInWarehouse.AmountLeft);
                f.Changed += Changed;
                f.ShowDialog();
            }
        }

        private void Changed(object sender, EventArgs e)
        {
            fEnterNumberOfMaterialExport f = sender as fEnterNumberOfMaterialExport;
            if (f != null)
            {
                int count = f.Value;
                Material material = materials.ElementAt(lsvMaterialInWarehouse.SelectedItems[0].Index);
                material.AmountLeft = material.AmountLeft - count;
                if(detailOfBillExports.FindAll(item=>item.IDMaterial == material.IDMaterial).Count > 0)
                {
                    foreach(DetailOfBillExport item in detailOfBillExports)
                    {
                        if(item.IDMaterial == material.IDMaterial)
                        {
                            item.Count += count;
                        }
                    }
                }
                else
                {
                    detailOfBillExports.Add(new DetailOfBillExport(IDBillExport, material.IDMaterial, count));
                }

                LoadLsvMaterial();
                LoadLsvBillExport();
            }
        }

        private void LoadLsvBillExport()
        {
            int totalAmount = 0;
            lsvBillExport.Items.Clear();
            detailOfBillExports.RemoveAll(item => item.Count <= 0);
            foreach(DetailOfBillExport item in detailOfBillExports)
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
                lsvBillExport.Items.Add(listViewItem);
                totalAmount += item.Count * inforOfMaterial.Price;
            }
            txbTotalAmount.Text = totalAmount.ToString();
        }

        private void cbbSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbbSortBy.SelectedItem)
            {
                case "Name":
                    searchedMaterials = searchedMaterials.OrderBy(item => InforOfMaterialDAO.Instance.GetNameByID(item.IDMaterial)).ToList();
                    break;
                case "AmountLeft":
                    searchedMaterials = searchedMaterials.OrderBy(item => item.AmountLeft).ToList();
                    break;
                case "Unit":
                    searchedMaterials = searchedMaterials.OrderBy(item => fAdmin.getUnitByIDUnit(InforOfMaterialDAO.Instance.GetInfoOfMaterial(item.IDMaterial).IDUnit)).ToList();
                    break;
                case "Price":
                    searchedMaterials = searchedMaterials.OrderBy(item => InforOfMaterialDAO.Instance.GetInfoOfMaterial(item.IDMaterial).Price).ToList();
                    break;
                case "Supplier":
                    searchedMaterials = searchedMaterials.OrderBy(item =>  SupplierDAO.Instance.GetNameByID(InforOfMaterialDAO.Instance.GetInfoOfMaterial(item.IDMaterial).IDSupplier)).ToList();
                    break;
                case "Expiry Day":
                    searchedMaterials = searchedMaterials.OrderBy(item => item.ExpiryDate).ToList();
                    break;
            }
            LoadLsvMaterial();
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            string searchingText = txbSearch.Text;
            switch (cbbSearchBy.SelectedItem)
            {
                case "Name":
                    searchedMaterials = materials.FindAll(item => InforOfMaterialDAO.Instance.GetNameByID(item.IDMaterial).Contains(searchingText));
                    break;
                case "AmountLeft":
                    searchedMaterials = materials.FindAll(item => item.AmountLeft.ToString().Contains(searchingText));
                    break;
                case "Unit":
                    searchedMaterials = materials.FindAll(item => fAdmin.getUnitByIDUnit(InforOfMaterialDAO.Instance.GetInfoOfMaterial(item.IDMaterial).IDUnit).Contains(searchingText));
                    break;
                case "Price":
                    searchedMaterials = materials.FindAll(item => InforOfMaterialDAO.Instance.GetInfoOfMaterial(item.IDMaterial).Price.ToString().Contains(searchingText));
                    break;
                case "Supplier":
                    searchedMaterials = materials.FindAll(item => SupplierDAO.Instance.GetNameByID(InforOfMaterialDAO.Instance.GetInfoOfMaterial(item.IDMaterial).IDSupplier).Contains(searchingText));
                    break;
                case "Expiry Day":
                    searchedMaterials = materials.FindAll(item => item.ExpiryDate.ToString("yyyy-MM-dd").Contains(searchingText));
                    break;
            }
            LoadLsvMaterial();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (!fAdmin.checkItemInCombobox(cbbBranch.Text, cbbBranch))
            {
                MessageBox.Show("Please choose one branch in combobox", "Missed Branch", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                cbbBranch.Focus();
                return;
            }
            string branch = cbbBranch.Text.Split('-')[0];

            if(detailOfBillExports.Count<=0)
            {
                MessageBox.Show("Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }
            if(BillExportDAO.Instance.AddBillExport(IDBillExport, branch, DateTime.Now))
            {
                foreach(DetailOfBillExport item in detailOfBillExports)
                {
                    DetailOfBillExportDAO.Instance.AddDetailOfBillExport(item.IDBillExport, item.IDMaterial, item.Count);
                }

                foreach(Material item in materials)
                {
                    MaterialDAO.Instance.UpdateMaterial(item.IDMaterial, item.IDInfoOfMaterial, item.Amount, item.AmountLeft, item.DateAdded, item.ExpiryDate);
                }

                GenIDBillExport();
                lsvBillExport.Items.Clear();
                detailOfBillExports.Clear();

                MessageBox.Show("Successfully", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else
            {
                MessageBox.Show("Don't have nothing to export", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private void lsvBillExport_Click(object sender, EventArgs e)
        {
            if (lsvBillExport.SelectedItems.Count > 0)
            {
                DetailOfBillExport detail = detailOfBillExports.ElementAt(lsvBillExport.SelectedItems[0].Index);
                int count = detail.Count;
                foreach(Material material in materials)
                {
                    if(material.IDMaterial == detail.IDMaterial)
                    {
                        count += material.AmountLeft;
                    }
                }
                fChangeNumberOfMaterialExport f = new fChangeNumberOfMaterialExport(count);
                f.Changed += ChangedDetailBillExport;
                f.ShowDialog();
            }
        }

        private void ChangedDetailBillExport(object sender, EventArgs e)
        {
            fChangeNumberOfMaterialExport f = sender as fChangeNumberOfMaterialExport;
            if (f != null)
            {
                DetailOfBillExport detail = detailOfBillExports.ElementAt(lsvBillExport.SelectedItems[0].Index);
                int count = f.Value;
                int numberBack = detail.Count - count;
                detail.Count = count;
                foreach(Material item in materials)
                {
                    if(item.IDMaterial == detail.IDMaterial)
                    {
                        item.AmountLeft += numberBack;
                    }
                }
                LoadLsvBillExport();
                LoadLsvMaterial();
            }
        }

        private void lsvBillExport_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
