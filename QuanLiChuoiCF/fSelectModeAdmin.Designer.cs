
namespace QuanLiChuoiCF
{
    partial class fSelectModeAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSelectModeAdmin));
            this.btnWorkManagement = new System.Windows.Forms.Button();
            this.btnAdminMode = new System.Windows.Forms.Button();
            this.btnExportMaterial = new System.Windows.Forms.Button();
            this.btnImportMaterial = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnWorkManagement
            // 
            this.btnWorkManagement.BackColor = System.Drawing.Color.Teal;
            this.btnWorkManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWorkManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWorkManagement.ForeColor = System.Drawing.Color.Wheat;
            this.btnWorkManagement.Location = new System.Drawing.Point(15, 5);
            this.btnWorkManagement.Name = "btnWorkManagement";
            this.btnWorkManagement.Size = new System.Drawing.Size(250, 100);
            this.btnWorkManagement.TabIndex = 0;
            this.btnWorkManagement.Text = "Work Management";
            this.btnWorkManagement.UseVisualStyleBackColor = false;
            this.btnWorkManagement.Click += new System.EventHandler(this.btnWorkManagement_Click);
            // 
            // btnAdminMode
            // 
            this.btnAdminMode.BackColor = System.Drawing.Color.Teal;
            this.btnAdminMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminMode.ForeColor = System.Drawing.Color.Wheat;
            this.btnAdminMode.Location = new System.Drawing.Point(15, 120);
            this.btnAdminMode.Name = "btnAdminMode";
            this.btnAdminMode.Size = new System.Drawing.Size(250, 99);
            this.btnAdminMode.TabIndex = 2;
            this.btnAdminMode.Text = "Admin Mode";
            this.btnAdminMode.UseVisualStyleBackColor = false;
            this.btnAdminMode.Click += new System.EventHandler(this.btnAdminMode_Click);
            // 
            // btnExportMaterial
            // 
            this.btnExportMaterial.BackColor = System.Drawing.Color.Teal;
            this.btnExportMaterial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportMaterial.ForeColor = System.Drawing.Color.Wheat;
            this.btnExportMaterial.Location = new System.Drawing.Point(284, 5);
            this.btnExportMaterial.Name = "btnExportMaterial";
            this.btnExportMaterial.Size = new System.Drawing.Size(250, 100);
            this.btnExportMaterial.TabIndex = 1;
            this.btnExportMaterial.Text = "ExportMaterial";
            this.btnExportMaterial.UseVisualStyleBackColor = false;
            this.btnExportMaterial.Click += new System.EventHandler(this.btnExportMaterial_Click);
            // 
            // btnImportMaterial
            // 
            this.btnImportMaterial.BackColor = System.Drawing.Color.Teal;
            this.btnImportMaterial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImportMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportMaterial.ForeColor = System.Drawing.Color.Wheat;
            this.btnImportMaterial.Location = new System.Drawing.Point(284, 120);
            this.btnImportMaterial.Name = "btnImportMaterial";
            this.btnImportMaterial.Size = new System.Drawing.Size(250, 99);
            this.btnImportMaterial.TabIndex = 3;
            this.btnImportMaterial.Text = "ImportMaterial";
            this.btnImportMaterial.UseVisualStyleBackColor = false;
            this.btnImportMaterial.Click += new System.EventHandler(this.btnImportMaterial_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.225806F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96.77419F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 264F));
            this.tableLayoutPanel1.Controls.Add(this.btnExportMaterial, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnWorkManagement, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnImportMaterial, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnAdminMode, 1, 1);
            this.tableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.91489F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.08511F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(548, 236);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // fSelectModeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(548, 236);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fSelectModeAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Mode Admin";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWorkManagement;
        private System.Windows.Forms.Button btnAdminMode;
        private System.Windows.Forms.Button btnExportMaterial;
        private System.Windows.Forms.Button btnImportMaterial;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}