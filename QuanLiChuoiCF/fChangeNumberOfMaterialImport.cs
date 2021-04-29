using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiChuoiCF
{
    public partial class fChangeNumberOfMaterialImport : Form
    {
        public int count;
        public DateTime expiryDate;
        public event EventHandler changed;

        public fChangeNumberOfMaterialImport(int count, DateTime expiryDate)
        {
            InitializeComponent();
            this.count = count;
            this.expiryDate = expiryDate;
            nudNumberOfMaterial.Value = count;
            dtpExpiryDate.Value = expiryDate;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            count = (int)nudNumberOfMaterial.Value;
            expiryDate = dtpExpiryDate.Value;
            changed(this, null);
            this.Close();
        }
    }
}
