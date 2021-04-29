
namespace QuanLiChuoiCF
{
    partial class fExportMaterial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lsvBillExport = new System.Windows.Forms.ListView();
            this.clMaterial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clUnit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.txbTotalAmount = new System.Windows.Forms.TextBox();
            this.lbBranch = new System.Windows.Forms.Label();
            this.cbbBranch = new System.Windows.Forms.ComboBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbSortBy = new System.Windows.Forms.ComboBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.cbbSearchBy = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.lsvMaterialInWarehouse = new System.Windows.Forms.ListView();
            this.clName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clAmountLeft = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnConfirm = new System.Windows.Forms.Button();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsvBillExport
            // 
            this.lsvBillExport.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clMaterial,
            this.clNumber,
            this.clUnit,
            this.clPrice,
            this.columnHeader2,
            this.columnHeader6,
            this.clAmount});
            this.lsvBillExport.FullRowSelect = true;
            this.lsvBillExport.HideSelection = false;
            this.lsvBillExport.Location = new System.Drawing.Point(744, 67);
            this.lsvBillExport.Name = "lsvBillExport";
            this.lsvBillExport.Size = new System.Drawing.Size(600, 600);
            this.lsvBillExport.TabIndex = 1;
            this.lsvBillExport.UseCompatibleStateImageBehavior = false;
            this.lsvBillExport.View = System.Windows.Forms.View.Details;
            this.lsvBillExport.SelectedIndexChanged += new System.EventHandler(this.lsvBillExport_SelectedIndexChanged);
            this.lsvBillExport.Click += new System.EventHandler(this.lsvBillExport_Click);
            // 
            // clMaterial
            // 
            this.clMaterial.Text = "Name";
            this.clMaterial.Width = 150;
            // 
            // clNumber
            // 
            this.clNumber.Text = "Number";
            // 
            // clUnit
            // 
            this.clUnit.Text = "Unit";
            this.clUnit.Width = 70;
            // 
            // clPrice
            // 
            this.clPrice.Text = "Price";
            this.clPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clPrice.Width = 80;
            // 
            // clAmount
            // 
            this.clAmount.Text = "Amount";
            this.clAmount.Width = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(990, 673);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total Amount:";
            // 
            // txbTotalAmount
            // 
            this.txbTotalAmount.Location = new System.Drawing.Point(1117, 673);
            this.txbTotalAmount.Name = "txbTotalAmount";
            this.txbTotalAmount.Size = new System.Drawing.Size(227, 20);
            this.txbTotalAmount.TabIndex = 3;
            // 
            // lbBranch
            // 
            this.lbBranch.AutoSize = true;
            this.lbBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbBranch.Location = new System.Drawing.Point(990, 13);
            this.lbBranch.Name = "lbBranch";
            this.lbBranch.Size = new System.Drawing.Size(71, 20);
            this.lbBranch.TabIndex = 4;
            this.lbBranch.Text = "Branch:";
            // 
            // cbbBranch
            // 
            this.cbbBranch.FormattingEnabled = true;
            this.cbbBranch.Location = new System.Drawing.Point(1082, 12);
            this.cbbBranch.Name = "cbbBranch";
            this.cbbBranch.Size = new System.Drawing.Size(262, 21);
            this.cbbBranch.TabIndex = 5;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label3);
            this.panel9.Controls.Add(this.cbbSortBy);
            this.panel9.Location = new System.Drawing.Point(393, 21);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(319, 37);
            this.panel9.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sort By:";
            // 
            // cbbSortBy
            // 
            this.cbbSortBy.FormattingEnabled = true;
            this.cbbSortBy.Location = new System.Drawing.Point(111, 13);
            this.cbbSortBy.Name = "cbbSortBy";
            this.cbbSortBy.Size = new System.Drawing.Size(205, 21);
            this.cbbSortBy.TabIndex = 0;
            this.cbbSortBy.SelectedIndexChanged += new System.EventHandler(this.cbbSortBy_SelectedIndexChanged);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label17);
            this.panel7.Controls.Add(this.cbbSearchBy);
            this.panel7.Controls.Add(this.label13);
            this.panel7.Controls.Add(this.txbSearch);
            this.panel7.Location = new System.Drawing.Point(12, 9);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(363, 52);
            this.panel7.TabIndex = 6;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 36);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "Search:";
            // 
            // cbbSearchBy
            // 
            this.cbbSearchBy.FormattingEnabled = true;
            this.cbbSearchBy.Location = new System.Drawing.Point(71, 2);
            this.cbbSearchBy.Name = "cbbSearchBy";
            this.cbbSearchBy.Size = new System.Drawing.Size(281, 21);
            this.cbbSearchBy.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Search By:";
            // 
            // txbSearch
            // 
            this.txbSearch.Location = new System.Drawing.Point(71, 29);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(281, 20);
            this.txbSearch.TabIndex = 0;
            this.txbSearch.TextChanged += new System.EventHandler(this.txbSearch_TextChanged);
            // 
            // lsvMaterialInWarehouse
            // 
            this.lsvMaterialInWarehouse.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clName,
            this.clAmountLeft,
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lsvMaterialInWarehouse.FullRowSelect = true;
            this.lsvMaterialInWarehouse.HideSelection = false;
            this.lsvMaterialInWarehouse.Location = new System.Drawing.Point(9, 67);
            this.lsvMaterialInWarehouse.Name = "lsvMaterialInWarehouse";
            this.lsvMaterialInWarehouse.Size = new System.Drawing.Size(700, 600);
            this.lsvMaterialInWarehouse.TabIndex = 8;
            this.lsvMaterialInWarehouse.UseCompatibleStateImageBehavior = false;
            this.lsvMaterialInWarehouse.View = System.Windows.Forms.View.Details;
            this.lsvMaterialInWarehouse.Click += new System.EventHandler(this.lsvMaterialInWarehouse_Click);
            // 
            // clName
            // 
            this.clName.Text = "Name";
            this.clName.Width = 200;
            // 
            // clAmountLeft
            // 
            this.clAmountLeft.Text = "Amount Left";
            this.clAmountLeft.Width = 80;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Unit";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Supplier";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Expiry Day";
            this.columnHeader5.Width = 100;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(1104, 699);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(240, 34);
            this.btnConfirm.TabIndex = 9;
            this.btnConfirm.Text = "CONFIRM";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Supplier";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Expiry Day";
            this.columnHeader6.Width = 80;
            // 
            // fExportMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 769);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lsvMaterialInWarehouse);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.cbbBranch);
            this.Controls.Add(this.lbBranch);
            this.Controls.Add(this.txbTotalAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsvBillExport);
            this.Name = "fExportMaterial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fExportMaterial";
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lsvBillExport;
        private System.Windows.Forms.ColumnHeader clMaterial;
        private System.Windows.Forms.ColumnHeader clNumber;
        private System.Windows.Forms.ColumnHeader clUnit;
        private System.Windows.Forms.ColumnHeader clPrice;
        private System.Windows.Forms.ColumnHeader clAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTotalAmount;
        private System.Windows.Forms.Label lbBranch;
        private System.Windows.Forms.ComboBox cbbBranch;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbSortBy;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbbSearchBy;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.ListView lsvMaterialInWarehouse;
        private System.Windows.Forms.ColumnHeader clName;
        private System.Windows.Forms.ColumnHeader clAmountLeft;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}