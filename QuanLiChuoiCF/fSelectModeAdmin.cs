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
    public partial class fSelectModeAdmin : Form
    {
        public fSelectModeAdmin()
        {
            InitializeComponent();
        }

        private void btnWorkManagement_Click(object sender, EventArgs e)
        {
            fWorkManagement f = new fWorkManagement();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnAdminMode_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnExportMaterial_Click(object sender, EventArgs e)
        {
            fExportMaterial f = new fExportMaterial();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnImportMaterial_Click(object sender, EventArgs e)
        {
            fImportMaterial f = new fImportMaterial();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
