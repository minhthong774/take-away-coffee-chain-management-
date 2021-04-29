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
    public partial class fEnterNumberOfMaterialImport : Form
    {
        public event EventHandler changed;
        public int value;
        public DateTime expiryDate;
        public fEnterNumberOfMaterialImport()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.value = (int)nudNumberOfMaterial.Value;
            if(this.value == 0)
            {
                lbNotify.Text = "NOTIFY: Please enter Number of Material greater than 0";
                return;
            }

            this.expiryDate = dtpExpiryDate.Value;

            if(changed!=null)
                changed(this, null);

            this.Close();

        }
    }
}
