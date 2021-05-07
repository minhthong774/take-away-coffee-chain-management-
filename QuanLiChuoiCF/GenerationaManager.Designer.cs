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
            this.tc_Employee = new System.Windows.Forms.TabControl();
            this.tp_PaymentManager = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel25 = new System.Windows.Forms.Panel();
            this.label26 = new System.Windows.Forms.Label();
            this.cbb_Drink_SearchBy = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txb_Drink_Search = new System.Windows.Forms.TextBox();
            this.panel43 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.cbb_Drink_SortBy = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flpDrink = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_AddDrink = new System.Windows.Forms.Button();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.labelCount = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labelDrinkName = new System.Windows.Forms.Label();
            this.cbb_addDrink = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTotalPrice = new System.Windows.Forms.TextBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tp_AccountProfile = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txbConfirmNewPassword = new System.Windows.Forms.TextBox();
            this.txbNewPassword = new System.Windows.Forms.TextBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.txbIDOfEmployee = new System.Windows.Forms.TextBox();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelConfirmNewPassword = new System.Windows.Forms.Label();
            this.labelNewPassword = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.tc_Employee.SuspendLayout();
            this.tp_PaymentManager.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel25.SuspendLayout();
            this.panel43.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tp_AccountProfile.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // tc_Employee
            // 
            this.tc_Employee.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tc_Employee.Controls.Add(this.tp_PaymentManager);
            this.tc_Employee.Controls.Add(this.tp_AccountProfile);
            this.tc_Employee.Location = new System.Drawing.Point(0, 0);
            this.tc_Employee.Name = "tc_Employee";
            this.tc_Employee.SelectedIndex = 0;
            this.tc_Employee.Size = new System.Drawing.Size(1292, 674);
            this.tc_Employee.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tc_Employee.TabIndex = 1;
            this.tc_Employee.Selected += new System.Windows.Forms.TabControlEventHandler(this.tc_Employee_Selected);
            // 
            // tp_PaymentManager
            // 
            this.tp_PaymentManager.BackColor = System.Drawing.Color.Teal;
            this.tp_PaymentManager.Controls.Add(this.panel7);
            this.tp_PaymentManager.Controls.Add(this.panel6);
            this.tp_PaymentManager.Controls.Add(this.panel8);
            this.tp_PaymentManager.Controls.Add(this.panel5);
            this.tp_PaymentManager.Controls.Add(this.panel1);
            this.tp_PaymentManager.Controls.Add(this.flowLayoutPanel1);
            this.tp_PaymentManager.Controls.Add(this.panel4);
            this.tp_PaymentManager.Controls.Add(this.panel3);
            this.tp_PaymentManager.Controls.Add(this.panel2);
            this.tp_PaymentManager.Location = new System.Drawing.Point(4, 25);
            this.tp_PaymentManager.Name = "tp_PaymentManager";
            this.tp_PaymentManager.Padding = new System.Windows.Forms.Padding(3);
            this.tp_PaymentManager.Size = new System.Drawing.Size(1284, 645);
            this.tp_PaymentManager.TabIndex = 0;
            this.tp_PaymentManager.Text = "Payment Manager";
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.panel25);
            this.panel7.Controls.Add(this.panel43);
            this.panel7.Location = new System.Drawing.Point(25, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(714, 94);
            this.panel7.TabIndex = 19;
            // 
            // panel25
            // 
            this.panel25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel25.Controls.Add(this.label26);
            this.panel25.Controls.Add(this.cbb_Drink_SearchBy);
            this.panel25.Controls.Add(this.label27);
            this.panel25.Controls.Add(this.txb_Drink_Search);
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
            // cbb_Drink_SearchBy
            // 
            this.cbb_Drink_SearchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Drink_SearchBy.ForeColor = System.Drawing.Color.Teal;
            this.cbb_Drink_SearchBy.FormattingEnabled = true;
            this.cbb_Drink_SearchBy.Location = new System.Drawing.Point(86, 11);
            this.cbb_Drink_SearchBy.Name = "cbb_Drink_SearchBy";
            this.cbb_Drink_SearchBy.Size = new System.Drawing.Size(307, 24);
            this.cbb_Drink_SearchBy.TabIndex = 2;
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
            // txb_Drink_Search
            // 
            this.txb_Drink_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Drink_Search.ForeColor = System.Drawing.Color.Teal;
            this.txb_Drink_Search.Location = new System.Drawing.Point(86, 50);
            this.txb_Drink_Search.Name = "txb_Drink_Search";
            this.txb_Drink_Search.Size = new System.Drawing.Size(307, 23);
            this.txb_Drink_Search.TabIndex = 1;
            this.txb_Drink_Search.TextChanged += new System.EventHandler(this.txb_Drink_Search_TextChanged);
            // 
            // panel43
            // 
            this.panel43.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel43.Controls.Add(this.label10);
            this.panel43.Controls.Add(this.cbb_Drink_SortBy);
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
            // cbb_Drink_SortBy
            // 
            this.cbb_Drink_SortBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Drink_SortBy.ForeColor = System.Drawing.Color.Teal;
            this.cbb_Drink_SortBy.FormattingEnabled = true;
            this.cbb_Drink_SortBy.Location = new System.Drawing.Point(86, 9);
            this.cbb_Drink_SortBy.Name = "cbb_Drink_SortBy";
            this.cbb_Drink_SortBy.Size = new System.Drawing.Size(209, 24);
            this.cbb_Drink_SortBy.TabIndex = 0;
            this.cbb_Drink_SortBy.SelectedIndexChanged += new System.EventHandler(this.cbb_Drink_SortBy_SelectedIndexChanged);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Wheat;
            this.panel6.Location = new System.Drawing.Point(745, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(31, 617);
            this.panel6.TabIndex = 18;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Wheat;
            this.panel8.Location = new System.Drawing.Point(1260, -1);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(26, 652);
            this.panel8.TabIndex = 16;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Wheat;
            this.panel5.Location = new System.Drawing.Point(-1, -1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(26, 626);
            this.panel5.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.Location = new System.Drawing.Point(-1, 625);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1266, 25);
            this.panel1.TabIndex = 15;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.flpDrink);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(26, 96);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(717, 530);
            this.flowLayoutPanel1.TabIndex = 14;
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
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Wheat;
            this.panel4.Controls.Add(this.btn_AddDrink);
            this.panel4.Controls.Add(this.btnDeleteOrder);
            this.panel4.Controls.Add(this.labelCount);
            this.panel4.Controls.Add(this.numericUpDown1);
            this.panel4.Controls.Add(this.labelDrinkName);
            this.panel4.Controls.Add(this.cbb_addDrink);
            this.panel4.Location = new System.Drawing.Point(770, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(484, 94);
            this.panel4.TabIndex = 13;
            // 
            // btn_AddDrink
            // 
            this.btn_AddDrink.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_AddDrink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddDrink.ForeColor = System.Drawing.Color.Teal;
            this.btn_AddDrink.Location = new System.Drawing.Point(346, 54);
            this.btn_AddDrink.Name = "btn_AddDrink";
            this.btn_AddDrink.Size = new System.Drawing.Size(114, 34);
            this.btn_AddDrink.TabIndex = 2;
            this.btn_AddDrink.Text = "Add Drink";
            this.btn_AddDrink.UseVisualStyleBackColor = false;
            this.btn_AddDrink.Click += new System.EventHandler(this.btn_AddDrink_click);
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
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
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
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Wheat;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txbTotalPrice);
            this.panel3.Controls.Add(this.btnThanhToan);
            this.panel3.Location = new System.Drawing.Point(782, 540);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(472, 81);
            this.panel3.TabIndex = 12;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.lsvBill);
            this.panel2.Location = new System.Drawing.Point(782, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(483, 433);
            this.panel2.TabIndex = 11;
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
            // tp_AccountProfile
            // 
            this.tp_AccountProfile.Controls.Add(this.tableLayoutPanel1);
            this.tp_AccountProfile.Location = new System.Drawing.Point(4, 25);
            this.tp_AccountProfile.Name = "tp_AccountProfile";
            this.tp_AccountProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tp_AccountProfile.Size = new System.Drawing.Size(1284, 645);
            this.tp_AccountProfile.TabIndex = 1;
            this.tp_AccountProfile.Text = "Account Profile";
            this.tp_AccountProfile.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.LemonChiffon;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.5834F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.4166F));
            this.tableLayoutPanel1.Controls.Add(this.panel9, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txbConfirmNewPassword, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txbNewPassword, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txbPassword, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txbIDOfEmployee, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txbUsername, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelConfirmNewPassword, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelNewPassword, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelPassword, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelUserName, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1278, 639);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnUpdate);
            this.panel9.Controls.Add(this.btnThoat);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(202, 533);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1073, 70);
            this.panel9.TabIndex = 9;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Teal;
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Wheat;
            this.btnUpdate.Location = new System.Drawing.Point(0, 0);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(172, 70);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Teal;
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Wheat;
            this.btnThoat.Location = new System.Drawing.Point(910, 0);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(163, 70);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // txbConfirmNewPassword
            // 
            this.txbConfirmNewPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txbConfirmNewPassword.Location = new System.Drawing.Point(202, 467);
            this.txbConfirmNewPassword.Name = "txbConfirmNewPassword";
            this.txbConfirmNewPassword.Size = new System.Drawing.Size(364, 20);
            this.txbConfirmNewPassword.TabIndex = 3;
            this.txbConfirmNewPassword.UseSystemPasswordChar = true;
            // 
            // txbNewPassword
            // 
            this.txbNewPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txbNewPassword.Location = new System.Drawing.Point(202, 361);
            this.txbNewPassword.Name = "txbNewPassword";
            this.txbNewPassword.Size = new System.Drawing.Size(364, 20);
            this.txbNewPassword.TabIndex = 2;
            this.txbNewPassword.UseSystemPasswordChar = true;
            // 
            // txbPassword
            // 
            this.txbPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txbPassword.Location = new System.Drawing.Point(202, 255);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(364, 20);
            this.txbPassword.TabIndex = 1;
            this.txbPassword.UseSystemPasswordChar = true;
            // 
            // txbIDOfEmployee
            // 
            this.txbIDOfEmployee.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txbIDOfEmployee.Location = new System.Drawing.Point(202, 149);
            this.txbIDOfEmployee.Name = "txbIDOfEmployee";
            this.txbIDOfEmployee.ReadOnly = true;
            this.txbIDOfEmployee.Size = new System.Drawing.Size(364, 20);
            this.txbIDOfEmployee.TabIndex = 0;
            // 
            // txbUsername
            // 
            this.txbUsername.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txbUsername.Location = new System.Drawing.Point(202, 43);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.ReadOnly = true;
            this.txbUsername.Size = new System.Drawing.Size(364, 20);
            this.txbUsername.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelConfirmNewPassword
            // 
            this.labelConfirmNewPassword.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelConfirmNewPassword.AutoSize = true;
            this.labelConfirmNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmNewPassword.Location = new System.Drawing.Point(37, 469);
            this.labelConfirmNewPassword.Name = "labelConfirmNewPassword";
            this.labelConfirmNewPassword.Size = new System.Drawing.Size(159, 15);
            this.labelConfirmNewPassword.TabIndex = 0;
            this.labelConfirmNewPassword.Text = "Confirm New Password:";
            // 
            // labelNewPassword
            // 
            this.labelNewPassword.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelNewPassword.AutoSize = true;
            this.labelNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewPassword.Location = new System.Drawing.Point(99, 363);
            this.labelNewPassword.Name = "labelNewPassword";
            this.labelNewPassword.Size = new System.Drawing.Size(97, 15);
            this.labelNewPassword.TabIndex = 0;
            this.labelNewPassword.Text = "NewPassword";
            // 
            // labelPassword
            // 
            this.labelPassword.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(123, 257);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(73, 15);
            this.labelPassword.TabIndex = 0;
            this.labelPassword.Text = "Password:";
            // 
            // labelUserName
            // 
            this.labelUserName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(88, 151);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(108, 15);
            this.labelUserName.TabIndex = 0;
            this.labelUserName.Text = "ID of Employee:";
            // 
            // fTableManager
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1291, 674);
            this.Controls.Add(this.tc_Employee);
            this.Name = "fTableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coffee Chain Management ";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Load += new System.EventHandler(this.fTableManager_Load);
            this.tc_Employee.ResumeLayout(false);
            this.tp_PaymentManager.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel25.ResumeLayout(false);
            this.panel25.PerformLayout();
            this.panel43.ResumeLayout(false);
            this.panel43.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tp_AccountProfile.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc_Employee;
        private System.Windows.Forms.TabPage tp_PaymentManager;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox cbb_Drink_SearchBy;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txb_Drink_Search;
        private System.Windows.Forms.Panel panel43;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbb_Drink_SortBy;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flpDrink;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_AddDrink;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label labelDrinkName;
        private System.Windows.Forms.ComboBox cbb_addDrink;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTotalPrice;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TabPage tp_AccountProfile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txbConfirmNewPassword;
        private System.Windows.Forms.TextBox txbNewPassword;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.TextBox txbIDOfEmployee;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelConfirmNewPassword;
        private System.Windows.Forms.Label labelNewPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUserName;
    }
}