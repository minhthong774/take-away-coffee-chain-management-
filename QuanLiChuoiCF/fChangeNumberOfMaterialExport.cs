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
    public partial class fChangeNumberOfMaterialExport : Form
    {
        public event EventHandler Changed;
        int max;
        private int value;

        public int Value { get => value; set => this.value = value; }
        public int Max { get => max; set => max = value; }

        public fChangeNumberOfMaterialExport(int max)
        {
            InitializeComponent();
            this.max = max;
            nudNumberOfMaterial.Maximum = max;
            label1.Text = label1.Text + "(Maximum: " + max + ")";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (nudNumberOfMaterial.Value > this.max)
            {
                lbNotify.Text = "NOTIFY: Don't enough material";
                nudNumberOfMaterial.Focus();
                return;
            }
            this.value = (int)nudNumberOfMaterial.Value;
            OnChanged(null);
            this.Close();
        }

        protected virtual void OnChanged(EventArgs e)
        {
            EventHandler eh = Changed;
            if (eh != null)
            {
                eh(this, e);
            }
        }
    }
}
