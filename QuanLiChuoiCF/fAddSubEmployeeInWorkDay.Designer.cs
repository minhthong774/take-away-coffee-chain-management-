
namespace QuanLiChuoiCF
{
    partial class fAddSubEmployeeInWorkDay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAddSubEmployeeInWorkDay));
            this.lsvEmployeeWorkInThisDay = new System.Windows.Forms.ListView();
            this.cl_IDEmployee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbbEmployeeWithOutWork = new System.Windows.Forms.ComboBox();
            this.lbNotify = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lsvEmployeeWorkInThisDay
            // 
            this.lsvEmployeeWorkInThisDay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lsvEmployeeWorkInThisDay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cl_IDEmployee,
            this.cl_FirstName,
            this.cl_LastName});
            this.lsvEmployeeWorkInThisDay.ForeColor = System.Drawing.Color.Teal;
            this.lsvEmployeeWorkInThisDay.FullRowSelect = true;
            this.lsvEmployeeWorkInThisDay.HideSelection = false;
            this.lsvEmployeeWorkInThisDay.Location = new System.Drawing.Point(12, 65);
            this.lsvEmployeeWorkInThisDay.Name = "lsvEmployeeWorkInThisDay";
            this.lsvEmployeeWorkInThisDay.Size = new System.Drawing.Size(500, 376);
            this.lsvEmployeeWorkInThisDay.TabIndex = 0;
            this.lsvEmployeeWorkInThisDay.UseCompatibleStateImageBehavior = false;
            this.lsvEmployeeWorkInThisDay.View = System.Windows.Forms.View.Details;
            // 
            // cl_IDEmployee
            // 
            this.cl_IDEmployee.Text = "ID";
            this.cl_IDEmployee.Width = 100;
            // 
            // cl_FirstName
            // 
            this.cl_FirstName.Text = "First Name";
            this.cl_FirstName.Width = 200;
            // 
            // cl_LastName
            // 
            this.cl_LastName.Text = "Last Name";
            this.cl_LastName.Width = 200;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Wheat;
            this.btnAdd.ForeColor = System.Drawing.Color.Teal;
            this.btnAdd.Location = new System.Drawing.Point(356, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Wheat;
            this.btnDelete.ForeColor = System.Drawing.Color.Teal;
            this.btnDelete.Location = new System.Drawing.Point(437, 14);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbbEmployeeWithOutWork
            // 
            this.cbbEmployeeWithOutWork.ForeColor = System.Drawing.Color.Teal;
            this.cbbEmployeeWithOutWork.FormattingEnabled = true;
            this.cbbEmployeeWithOutWork.Location = new System.Drawing.Point(12, 14);
            this.cbbEmployeeWithOutWork.Name = "cbbEmployeeWithOutWork";
            this.cbbEmployeeWithOutWork.Size = new System.Drawing.Size(338, 21);
            this.cbbEmployeeWithOutWork.TabIndex = 3;
            // 
            // lbNotify
            // 
            this.lbNotify.AutoSize = true;
            this.lbNotify.ForeColor = System.Drawing.Color.Wheat;
            this.lbNotify.Location = new System.Drawing.Point(9, 41);
            this.lbNotify.Name = "lbNotify";
            this.lbNotify.Size = new System.Drawing.Size(49, 13);
            this.lbNotify.TabIndex = 4;
            this.lbNotify.Text = "NOTIFY:";
            // 
            // fAddSubEmployeeInWorkDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(527, 450);
            this.Controls.Add(this.lbNotify);
            this.Controls.Add(this.cbbEmployeeWithOutWork);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lsvEmployeeWorkInThisDay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fAddSubEmployeeInWorkDay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Sub Employee In WorkDay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvEmployeeWorkInThisDay;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cbbEmployeeWithOutWork;
        private System.Windows.Forms.ColumnHeader cl_IDEmployee;
        private System.Windows.Forms.ColumnHeader cl_FirstName;
        private System.Windows.Forms.ColumnHeader cl_LastName;
        private System.Windows.Forms.Label lbNotify;
    }
}