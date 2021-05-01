
namespace QuanLiChuoiCF
{
    partial class fChangeNumberOfMaterialExport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fChangeNumberOfMaterialExport));
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nudNumberOfMaterial = new System.Windows.Forms.NumericUpDown();
            this.lbNotify = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfMaterial)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Wheat;
            this.btnOK.ForeColor = System.Drawing.Color.Teal;
            this.btnOK.Location = new System.Drawing.Point(133, 51);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(103, 45);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Wheat;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter number of material:";
            // 
            // nudNumberOfMaterial
            // 
            this.nudNumberOfMaterial.ForeColor = System.Drawing.Color.Teal;
            this.nudNumberOfMaterial.Location = new System.Drawing.Point(12, 25);
            this.nudNumberOfMaterial.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudNumberOfMaterial.Name = "nudNumberOfMaterial";
            this.nudNumberOfMaterial.Size = new System.Drawing.Size(350, 20);
            this.nudNumberOfMaterial.TabIndex = 3;
            // 
            // lbNotify
            // 
            this.lbNotify.AutoSize = true;
            this.lbNotify.Location = new System.Drawing.Point(12, 107);
            this.lbNotify.Name = "lbNotify";
            this.lbNotify.Size = new System.Drawing.Size(7, 13);
            this.lbNotify.TabIndex = 6;
            this.lbNotify.Text = "\r\n";
            // 
            // fChangeNumberOfMaterialExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(376, 129);
            this.Controls.Add(this.lbNotify);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudNumberOfMaterial);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fChangeNumberOfMaterialExport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Change Number Of Material Export";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfMaterial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudNumberOfMaterial;
        private System.Windows.Forms.Label lbNotify;
    }
}