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
    public partial class fImportMaterial : Form
    {
        private List<InforOfMaterial> inforOfMaterials = new List<InforOfMaterial>();
        private List<InforOfMaterial> searchedInforOfMaterials = new List<InforOfMaterial>();
        private List<Material> materials = new List<Material>();
        private string iDMaterial;

        public string IDMaterial { get => iDMaterial; set => iDMaterial = value; }

        public fImportMaterial()
        {
            InitializeComponent();
            Load();
        }

        public void Load()
        {
            LoadCbbSearchBy();
            LoadCbbSortBy();
            inforOfMaterials = InforOfMaterialDAO.Instance.GetInfoOfMaterials().FindAll(item=>item.IDStatus ==1);
            searchedInforOfMaterials = inforOfMaterials;
            LoadLsvInfoOfMaterial();
            GenIDMaterial();
        }

        private void LoadCbbSearchBy()
        {
            cbbSearchBy.Items.Add("Name");
            cbbSearchBy.Items.Add("Unit");
            cbbSearchBy.Items.Add("Price");
            cbbSearchBy.Items.Add("Supplier");
            cbbSearchBy.SelectedItem = cbbSearchBy.Items[0];
        }

        private void LoadCbbSortBy()
        {
            cbbSortBy.Items.Add("Name");
            cbbSortBy.Items.Add("Unit");
            cbbSortBy.Items.Add("Price");
            cbbSortBy.Items.Add("Supplier");
            cbbSortBy.SelectedItem = cbbSortBy.Items[0];
        }

        private void LoadLsvInfoOfMaterial()
        { 
            foreach(InforOfMaterial item in inforOfMaterials)
            {
                ListViewItem listViewItem = new ListViewItem(item.Name);
                listViewItem.SubItems.Add(fAdmin.getUnitByIDUnit(item.IDUnit));
                listViewItem.SubItems.Add(item.Price.ToString());
                listViewItem.SubItems.Add(SupplierDAO.Instance.GetNameByID(item.IDSupplier));
                lsvInfoOfMaterial.Items.Add(listViewItem);
            }
        }

        private void LoadLsvBillImport()
        {
            int totalAmount = 0;
            lsvBillImport.Items.Clear();
            foreach(Material item in materials)
            {
                InforOfMaterial inforOfMaterial = InforOfMaterialDAO.Instance.GetInfoOfMaterial(item.IDInfoOfMaterial);
                ListViewItem listViewItem = new ListViewItem(inforOfMaterial.Name);
                listViewItem.SubItems.Add(SupplierDAO.Instance.GetNameByID(inforOfMaterial.IDSupplier));
                listViewItem.SubItems.Add(item.ExpiryDate.ToString());
                listViewItem.SubItems.Add(item.Amount.ToString());
                listViewItem.SubItems.Add(fAdmin.getUnitByIDUnit(inforOfMaterial.IDUnit));
                listViewItem.SubItems.Add(inforOfMaterial.Price.ToString());
                listViewItem.SubItems.Add((item.Amount * inforOfMaterial.Price).ToString());
                lsvBillImport.Items.Add(listViewItem);
                totalAmount += item.Amount * inforOfMaterial.Price;
            }
            txbTotalAmount.Text = totalAmount.ToString();
        }

        private void GenIDMaterial()
        {
            Material[] a  = MaterialDAO.Instance.GetMaterials().ToArray();
            if(a.Length>0)
                IDMaterial = fAdmin.getIDIncrea(a[a.Length - 1].IDMaterial);
            else
            {
                IDMaterial = "MA01";
            }
        }

        private void lsvInfoOfMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lsvInfoOfMaterial_Click(object sender, EventArgs e)
        {
            if (lsvInfoOfMaterial.SelectedItems.Count > 0)
            {
                fEnterNumberOfMaterialImport f = new fEnterNumberOfMaterialImport();
                f.changed += Changed;
                f.ShowDialog();
            }
        }

        private void Changed(object sender, EventArgs e)
        {
            InforOfMaterial inforOfMaterial = searchedInforOfMaterials.ElementAt(lsvInfoOfMaterial.SelectedItems[0].Index);
            fEnterNumberOfMaterialImport f = sender as fEnterNumberOfMaterialImport;
            int count = f.value;
            DateTime expiryDate = f.expiryDate;
            foreach(Material material in materials)
            {
                if(material.IDInfoOfMaterial == inforOfMaterial.IDInfoOfMaterial)
                {
                    material.Amount += count;
                    material.AmountLeft += count;
                    LoadLsvBillImport();
                    return;
                }
            }
            materials.Add(new Material(IDMaterial, inforOfMaterial.IDInfoOfMaterial, count, count, DateTime.Now, expiryDate));
            IDMaterial = fAdmin.getIDIncrea(IDMaterial);
            LoadLsvBillImport();
        }

        private void lsvBillImport_Click(object sender, EventArgs e)
        {
            if (lsvBillImport.SelectedItems.Count > 0)
            {
                Material material = materials.ElementAt(lsvBillImport.SelectedItems[0].Index);
                fChangeNumberOfMaterialImport f = new fChangeNumberOfMaterialImport(material.Amount, material.ExpiryDate);
                f.changed += ChangedBillImport;
                f.ShowDialog();
            }
        }

        private void ChangedBillImport(object sender, EventArgs e)
        {
            Material material = materials.ElementAt(lsvBillImport.SelectedItems[0].Index);
            fChangeNumberOfMaterialImport f = sender as fChangeNumberOfMaterialImport;
            int count = f.count;
            DateTime expiryDate = f.expiryDate;
            if (count != 0)
            {
                material.Amount = count;
                material.AmountLeft = count;
                material.ExpiryDate = expiryDate;
            }
            else
            {
                materials.Remove(material);
            }
            LoadLsvBillImport();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (materials.Count > 0)
            {
                GenIDMaterial();
                foreach (Material material in materials)
                {
                    MaterialDAO.Instance.AddMaterial(IDMaterial, material.IDInfoOfMaterial, material.Amount, material.AmountLeft, material.DateAdded, material.ExpiryDate);
                    IDMaterial = fAdmin.getIDIncrea(IDMaterial);
                }
                lsvBillImport.Clear();
                MessageBox.Show("Import successfully", "SUCCESSFULLY", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else{
                MessageBox.Show("Don't have nothing to import", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
