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
    public partial class fEnterNumberOfMaterialExport : Form
    {
        public event EventHandler Changed;
        private int amountLeft;
        private int value;

        public int Value { get => value; set => this.value = value; }
        public int AmountLeft { get => amountLeft; set => amountLeft = value; }

        public fEnterNumberOfMaterialExport(int amountLeft)
        {
            InitializeComponent();
            this.AmountLeft = amountLeft;
            nudNumberOfMaterial.Maximum = amountLeft;
            label1.Text = label1.Text + "(Maximum: " + amountLeft + ")";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(nudNumberOfMaterial.Value <= 0)
            {
                lbNotify.Text = "NOTIFY: Please enter number greater than 0";
                nudNumberOfMaterial.Focus();
                return;
            }
            if (nudNumberOfMaterial.Value >this.amountLeft)
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
            if(eh!= null)
            {
                eh(this, e);
            }
        }

    }
}
