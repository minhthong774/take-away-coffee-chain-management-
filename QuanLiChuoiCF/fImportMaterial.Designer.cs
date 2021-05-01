
namespace QuanLiChuoiCF
{
    partial class fImportMaterial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fImportMaterial));
            this.lsvInfoOfMaterial = new System.Windows.Forms.ListView();
            this.clName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel9 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbSortBy = new System.Windows.Forms.ComboBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.cbbSearchBy = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.lsvBillImport = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnImport = new System.Windows.Forms.Button();
            this.txbTotalAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsvInfoOfMaterial
            // 
            this.lsvInfoOfMaterial.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clName,
            this.columnHeader2,
            this.columnHeader6,
            this.columnHeader7});
            this.lsvInfoOfMaterial.ForeColor = System.Drawing.Color.Teal;
            this.lsvInfoOfMaterial.FullRowSelect = true;
            this.lsvInfoOfMaterial.HideSelection = false;
            this.lsvInfoOfMaterial.Location = new System.Drawing.Point(12, 60);
            this.lsvInfoOfMaterial.Name = "lsvInfoOfMaterial";
            this.lsvInfoOfMaterial.Size = new System.Drawing.Size(700, 600);
            this.lsvInfoOfMaterial.TabIndex = 17;
            this.lsvInfoOfMaterial.UseCompatibleStateImageBehavior = false;
            this.lsvInfoOfMaterial.View = System.Windows.Forms.View.Details;
            this.lsvInfoOfMaterial.SelectedIndexChanged += new System.EventHandler(this.lsvInfoOfMaterial_SelectedIndexChanged);
            this.lsvInfoOfMaterial.Click += new System.EventHandler(this.lsvInfoOfMaterial_Click);
            // 
            // clName
            // 
            this.clName.Text = "Name";
            this.clName.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Unit";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Price";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Supplier";
            this.columnHeader7.Width = 300;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label3);
            this.panel9.Controls.Add(this.cbbSortBy);
            this.panel9.Location = new System.Drawing.Point(393, 14);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(319, 37);
            this.panel9.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Wheat;
            this.label3.Location = new System.Drawing.Point(49, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sort By:";
            // 
            // cbbSortBy
            // 
            this.cbbSortBy.ForeColor = System.Drawing.Color.Teal;
            this.cbbSortBy.FormattingEnabled = true;
            this.cbbSortBy.Location = new System.Drawing.Point(111, 13);
            this.cbbSortBy.Name = "cbbSortBy";
            this.cbbSortBy.Size = new System.Drawing.Size(205, 21);
            this.cbbSortBy.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label17);
            this.panel7.Controls.Add(this.cbbSearchBy);
            this.panel7.Controls.Add(this.label13);
            this.panel7.Controls.Add(this.txbSearch);
            this.panel7.Location = new System.Drawing.Point(12, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(363, 52);
            this.panel7.TabIndex = 15;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Wheat;
            this.label17.Location = new System.Drawing.Point(3, 36);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "Search:";
            // 
            // cbbSearchBy
            // 
            this.cbbSearchBy.ForeColor = System.Drawing.Color.Teal;
            this.cbbSearchBy.FormattingEnabled = true;
            this.cbbSearchBy.Location = new System.Drawing.Point(71, 2);
            this.cbbSearchBy.Name = "cbbSearchBy";
            this.cbbSearchBy.Size = new System.Drawing.Size(281, 21);
            this.cbbSearchBy.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Wheat;
            this.label13.Location = new System.Drawing.Point(3, 5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Search By:";
            // 
            // txbSearch
            // 
            this.txbSearch.ForeColor = System.Drawing.Color.Teal;
            this.txbSearch.Location = new System.Drawing.Point(71, 29);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(281, 20);
            this.txbSearch.TabIndex = 0;
            // 
            // lsvBillImport
            // 
            this.lsvBillImport.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader10,
            this.columnHeader4,
            this.columnHeader3,
            this.columnHeader8,
            this.columnHeader5,
            this.columnHeader9});
            this.lsvBillImport.ForeColor = System.Drawing.Color.Teal;
            this.lsvBillImport.FullRowSelect = true;
            this.lsvBillImport.HideSelection = false;
            this.lsvBillImport.Location = new System.Drawing.Point(738, 60);
            this.lsvBillImport.Name = "lsvBillImport";
            this.lsvBillImport.Size = new System.Drawing.Size(602, 600);
            this.lsvBillImport.TabIndex = 18;
            this.lsvBillImport.UseCompatibleStateImageBehavior = false;
            this.lsvBillImport.View = System.Windows.Forms.View.Details;
            this.lsvBillImport.Click += new System.EventHandler(this.lsvBillImport_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Supplier";
            this.columnHeader10.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Expiry Day";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Number";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Unit";
            this.columnHeader8.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Price";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Amount";
            this.columnHeader9.Width = 100;
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.Wheat;
            this.btnImport.ForeColor = System.Drawing.Color.Teal;
            this.btnImport.Location = new System.Drawing.Point(1203, 692);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(137, 49);
            this.btnImport.TabIndex = 19;
            this.btnImport.Text = "IMPORT";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // txbTotalAmount
            // 
            this.txbTotalAmount.ForeColor = System.Drawing.Color.Teal;
            this.txbTotalAmount.Location = new System.Drawing.Point(1162, 666);
            this.txbTotalAmount.Name = "txbTotalAmount";
            this.txbTotalAmount.Size = new System.Drawing.Size(178, 20);
            this.txbTotalAmount.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Wheat;
            this.label1.Location = new System.Drawing.Point(1035, 666);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Total Amount:";
            // 
            // fImportMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1352, 753);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbTotalAmount);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.lsvBillImport);
            this.Controls.Add(this.lsvInfoOfMaterial);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel7);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fImportMaterial";
            this.Text = "Import Material";
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvInfoOfMaterial;
        private System.Windows.Forms.ColumnHeader clName;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbSortBy;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbbSearchBy;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.ListView lsvBillImport;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.TextBox txbTotalAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader9;
    }
}