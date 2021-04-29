
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
            this.btnWorkManagement = new System.Windows.Forms.Button();
            this.btnAdminMode = new System.Windows.Forms.Button();
            this.btnExportMaterial = new System.Windows.Forms.Button();
            this.btnImportMaterial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWorkManagement
            // 
            this.btnWorkManagement.Location = new System.Drawing.Point(12, 12);
            this.btnWorkManagement.Name = "btnWorkManagement";
            this.btnWorkManagement.Size = new System.Drawing.Size(200, 100);
            this.btnWorkManagement.TabIndex = 0;
            this.btnWorkManagement.Text = "Work Management";
            this.btnWorkManagement.UseVisualStyleBackColor = true;
            this.btnWorkManagement.Click += new System.EventHandler(this.btnWorkManagement_Click);
            // 
            // btnAdminMode
            // 
            this.btnAdminMode.Location = new System.Drawing.Point(12, 118);
            this.btnAdminMode.Name = "btnAdminMode";
            this.btnAdminMode.Size = new System.Drawing.Size(200, 100);
            this.btnAdminMode.TabIndex = 1;
            this.btnAdminMode.Text = "Admin Mode";
            this.btnAdminMode.UseVisualStyleBackColor = true;
            this.btnAdminMode.Click += new System.EventHandler(this.btnAdminMode_Click);
            // 
            // btnExportMaterial
            // 
            this.btnExportMaterial.Location = new System.Drawing.Point(218, 12);
            this.btnExportMaterial.Name = "btnExportMaterial";
            this.btnExportMaterial.Size = new System.Drawing.Size(200, 100);
            this.btnExportMaterial.TabIndex = 2;
            this.btnExportMaterial.Text = "ExportMaterial";
            this.btnExportMaterial.UseVisualStyleBackColor = true;
            this.btnExportMaterial.Click += new System.EventHandler(this.btnExportMaterial_Click);
            // 
            // btnImportMaterial
            // 
            this.btnImportMaterial.Location = new System.Drawing.Point(218, 118);
            this.btnImportMaterial.Name = "btnImportMaterial";
            this.btnImportMaterial.Size = new System.Drawing.Size(200, 100);
            this.btnImportMaterial.TabIndex = 3;
            this.btnImportMaterial.Text = "ImportMaterial";
            this.btnImportMaterial.UseVisualStyleBackColor = true;
            this.btnImportMaterial.Click += new System.EventHandler(this.btnImportMaterial_Click);
            // 
            // fSelectModeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 349);
            this.Controls.Add(this.btnImportMaterial);
            this.Controls.Add(this.btnExportMaterial);
            this.Controls.Add(this.btnAdminMode);
            this.Controls.Add(this.btnWorkManagement);
            this.Name = "fSelectModeAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fSelectModeAdmin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWorkManagement;
        private System.Windows.Forms.Button btnAdminMode;
        private System.Windows.Forms.Button btnExportMaterial;
        private System.Windows.Forms.Button btnImportMaterial;
    }
}