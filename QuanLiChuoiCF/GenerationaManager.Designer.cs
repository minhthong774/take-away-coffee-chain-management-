namespace QuanLiChuoiCF
{
    partial class fTableManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTableManager));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTotalPrice = new System.Windows.Forms.TextBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.labelCount = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labelDrinkName = new System.Windows.Forms.Label();
            this.cbb_addDrink = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flpDrink = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel25 = new System.Windows.Forms.Panel();
            this.label26 = new System.Windows.Forms.Label();
            this.cbb_Bill_SearchBy = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txb_Bill_Search = new System.Windows.Forms.TextBox();
            this.panel43 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.cbb_Bill_SortBy = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel25.SuspendLayout();
            this.panel43.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Wheat;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.AutoSize = false;
            this.adminToolStripMenuItem.BackColor = System.Drawing.Color.Wheat;
            this.adminToolStripMenuItem.ForeColor = System.Drawing.Color.Teal;
            this.adminToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("adminToolStripMenuItem.Image")));
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.AutoSize = false;
            this.thôngTinToolStripMenuItem.BackColor = System.Drawing.Color.Wheat;
            this.thôngTinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userInformationToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.thôngTinToolStripMenuItem.ForeColor = System.Drawing.Color.Teal;
            this.thôngTinToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thôngTinToolStripMenuItem.Image")));
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.thôngTinToolStripMenuItem.Text = "Account";
            // 
            // userInformationToolStripMenuItem
            // 
            this.userInformationToolStripMenuItem.BackColor = System.Drawing.SystemColors.Info;
            this.userInformationToolStripMenuItem.ForeColor = System.Drawing.Color.Teal;
            this.userInformationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("userInformationToolStripMenuItem.Image")));
            this.userInformationToolStripMenuItem.Name = "userInformationToolStripMenuItem";
            this.userInformationToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.userInformationToolStripMenuItem.Text = "User information";
            this.userInformationToolStripMenuItem.Click += new System.EventHandler(this.userInformationToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.BackColor = System.Drawing.SystemColors.Info;
            this.logOutToolStripMenuItem.ForeColor = System.Drawing.Color.Teal;
            this.logOutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logOutToolStripMenuItem.Image")));
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lsvBill);
            this.panel2.Location = new System.Drawing.Point(786, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(483, 433);
            this.panel2.TabIndex = 2;
            // 
            // lsvBill
            // 
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvBill.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lsvBill.FullRowSelect = true;
            this.lsvBill.GridLines = true;
            this.lsvBill.HideSelection = false;
            this.lsvBill.Location = new System.Drawing.Point(-2, -1);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(474, 434);
            this.lsvBill.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lsvBill.TabIndex = 0;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            this.lsvBill.SelectedIndexChanged += new System.EventHandler(this.lsvSelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Drink Name";
            this.columnHeader1.Width = 203;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Count";
            this.columnHeader2.Width = 55;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price";
            this.columnHeader3.Width = 87;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total";
            this.columnHeader4.Width = 100;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Wheat;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txbTotalPrice);
            this.panel3.Controls.Add(this.btnThanhToan);
            this.panel3.Location = new System.Drawing.Point(786, 566);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(472, 81);
            this.panel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total price:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbTotalPrice
            // 
            this.txbTotalPrice.BackColor = System.Drawing.Color.BurlyWood;
            this.txbTotalPrice.ForeColor = System.Drawing.Color.Teal;
            this.txbTotalPrice.Location = new System.Drawing.Point(97, 23);
            this.txbTotalPrice.Name = "txbTotalPrice";
            this.txbTotalPrice.ReadOnly = true;
            this.txbTotalPrice.Size = new System.Drawing.Size(193, 20);
            this.txbTotalPrice.TabIndex = 4;
            this.txbTotalPrice.Text = "0";
            this.txbTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.BurlyWood;
            this.btnThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.Teal;
            this.btnThanhToan.Location = new System.Drawing.Point(307, 11);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnThanhToan.Size = new System.Drawing.Size(154, 49);
            this.btnThanhToan.TabIndex = 3;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Wheat;
            this.panel4.Controls.Add(this.btnThemMon);
            this.panel4.Controls.Add(this.btnDeleteOrder);
            this.panel4.Controls.Add(this.labelCount);
            this.panel4.Controls.Add(this.numericUpDown1);
            this.panel4.Controls.Add(this.labelDrinkName);
            this.panel4.Controls.Add(this.cbb_addDrink);
            this.panel4.Location = new System.Drawing.Point(774, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(484, 94);
            this.panel4.TabIndex = 5;
            // 
            // btnThemMon
            // 
            this.btnThemMon.BackColor = System.Drawing.Color.BurlyWood;
            this.btnThemMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMon.ForeColor = System.Drawing.Color.Teal;
            this.btnThemMon.Location = new System.Drawing.Point(346, 54);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(114, 34);
            this.btnThemMon.TabIndex = 2;
            this.btnThemMon.Text = "Add Drink";
            this.btnThemMon.UseVisualStyleBackColor = false;
            this.btnThemMon.Click += new System.EventHandler(this.btn_AddDrink_click);
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.BackColor = System.Drawing.Color.BurlyWood;
            this.btnDeleteOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteOrder.ForeColor = System.Drawing.Color.Tomato;
            this.btnDeleteOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteOrder.Location = new System.Drawing.Point(26, 55);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(116, 33);
            this.btnDeleteOrder.TabIndex = 7;
            this.btnDeleteOrder.Text = "DELETE  X";
            this.btnDeleteOrder.UseVisualStyleBackColor = false;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrderClick);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCount.ForeColor = System.Drawing.Color.Teal;
            this.labelCount.Location = new System.Drawing.Point(372, 5);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(49, 17);
            this.labelCount.TabIndex = 9;
            this.labelCount.Text = "Count:";
            this.labelCount.Click += new System.EventHandler(this.labelCount_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.BurlyWood;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.ForeColor = System.Drawing.Color.Teal;
            this.numericUpDown1.Location = new System.Drawing.Point(346, 28);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(114, 23);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Click += new System.EventHandler(this.numericUpDown1Click);
            // 
            // labelDrinkName
            // 
            this.labelDrinkName.AutoSize = true;
            this.labelDrinkName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDrinkName.ForeColor = System.Drawing.Color.Teal;
            this.labelDrinkName.Location = new System.Drawing.Point(23, 5);
            this.labelDrinkName.Name = "labelDrinkName";
            this.labelDrinkName.Size = new System.Drawing.Size(86, 17);
            this.labelDrinkName.TabIndex = 8;
            this.labelDrinkName.Text = "Drink Name:";
            // 
            // cbb_addDrink
            // 
            this.cbb_addDrink.BackColor = System.Drawing.Color.BurlyWood;
            this.cbb_addDrink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_addDrink.ForeColor = System.Drawing.Color.Teal;
            this.cbb_addDrink.FormattingEnabled = true;
            this.cbb_addDrink.Location = new System.Drawing.Point(26, 28);
            this.cbb_addDrink.Name = "cbb_addDrink";
            this.cbb_addDrink.Size = new System.Drawing.Size(304, 24);
            this.cbb_addDrink.TabIndex = 0;
            this.cbb_addDrink.SelectedIndexChanged += new System.EventHandler(this.cbb_addDrink_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.flpDrink);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(30, 123);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(717, 530);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // flpDrink
            // 
            this.flpDrink.AutoScroll = true;
            this.flpDrink.BackColor = System.Drawing.Color.White;
            this.flpDrink.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flpDrink.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flpDrink.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpDrink.Location = new System.Drawing.Point(3, 3);
            this.flpDrink.Name = "flpDrink";
            this.flpDrink.Size = new System.Drawing.Size(711, 521);
            this.flpDrink.TabIndex = 0;
            this.flpDrink.Paint += new System.Windows.Forms.PaintEventHandler(this.flpBranch_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.Location = new System.Drawing.Point(3, 653);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1255, 25);
            this.panel1.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Wheat;
            this.panel5.Location = new System.Drawing.Point(3, 30);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(26, 626);
            this.panel5.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Wheat;
            this.panel6.Location = new System.Drawing.Point(749, 30);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(31, 617);
            this.panel6.TabIndex = 9;
            // 
            // ribbonTab7
            // 
            // 
            // ribbonPanel3
            // 
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.panel25);
            this.panel7.Controls.Add(this.panel43);
            this.panel7.Location = new System.Drawing.Point(29, 30);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(714, 94);
            this.panel7.TabIndex = 10;
            // 
            // panel25
            // 
            this.panel25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel25.Controls.Add(this.label26);
            this.panel25.Controls.Add(this.cbb_Bill_SearchBy);
            this.panel25.Controls.Add(this.label27);
            this.panel25.Controls.Add(this.txb_Bill_Search);
            this.panel25.Location = new System.Drawing.Point(6, 5);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(406, 82);
            this.panel25.TabIndex = 25;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Wheat;
            this.label26.Location = new System.Drawing.Point(24, 49);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(57, 17);
            this.label26.TabIndex = 3;
            this.label26.Text = "Search:";
            // 
            // cbb_Bill_SearchBy
            // 
            this.cbb_Bill_SearchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Bill_SearchBy.ForeColor = System.Drawing.Color.Teal;
            this.cbb_Bill_SearchBy.FormattingEnabled = true;
            this.cbb_Bill_SearchBy.Location = new System.Drawing.Point(86, 11);
            this.cbb_Bill_SearchBy.Name = "cbb_Bill_SearchBy";
            this.cbb_Bill_SearchBy.Size = new System.Drawing.Size(307, 24);
            this.cbb_Bill_SearchBy.TabIndex = 2;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Wheat;
            this.label27.Location = new System.Drawing.Point(3, 14);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(77, 17);
            this.label27.TabIndex = 1;
            this.label27.Text = "Search By:";
            // 
            // txb_Bill_Search
            // 
            this.txb_Bill_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Bill_Search.ForeColor = System.Drawing.Color.Teal;
            this.txb_Bill_Search.Location = new System.Drawing.Point(86, 50);
            this.txb_Bill_Search.Name = "txb_Bill_Search";
            this.txb_Bill_Search.Size = new System.Drawing.Size(307, 23);
            this.txb_Bill_Search.TabIndex = 0;
            // 
            // panel43
            // 
            this.panel43.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel43.Controls.Add(this.label10);
            this.panel43.Controls.Add(this.cbb_Bill_SortBy);
            this.panel43.ForeColor = System.Drawing.Color.Wheat;
            this.panel43.Location = new System.Drawing.Point(405, 29);
            this.panel43.Name = "panel43";
            this.panel43.Size = new System.Drawing.Size(309, 37);
            this.panel43.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(26, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Sort By:";
            // 
            // cbb_Bill_SortBy
            // 
            this.cbb_Bill_SortBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Bill_SortBy.ForeColor = System.Drawing.Color.Teal;
            this.cbb_Bill_SortBy.FormattingEnabled = true;
            this.cbb_Bill_SortBy.Location = new System.Drawing.Point(86, 9);
            this.cbb_Bill_SortBy.Name = "cbb_Bill_SortBy";
            this.cbb_Bill_SortBy.Size = new System.Drawing.Size(209, 24);
            this.cbb_Bill_SortBy.TabIndex = 0;
            // 
            // fTableManager
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fTableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coffee Chain Management ";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Load += new System.EventHandler(this.fTableManager_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel25.ResumeLayout(false);
            this.panel25.PerformLayout();
            this.panel43.ResumeLayout(false);
            this.panel43.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.ComboBox cbb_addDrink;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.FlowLayoutPanel flpDrink;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTotalPrice;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Label labelDrinkName;
        private System.Windows.Forms.Label labelCount;
 
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ToolStripMenuItem userInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox cbb_Bill_SearchBy;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txb_Bill_Search;
        private System.Windows.Forms.Panel panel43;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbb_Bill_SortBy;
    }
}