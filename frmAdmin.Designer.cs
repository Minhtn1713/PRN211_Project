namespace CoffeeShopManager
{
    partial class frmAdmin
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpBill = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbEnd = new System.Windows.Forms.Label();
            this.lbFrom = new System.Windows.Forms.Label();
            this.btnSearchBill = new System.Windows.Forms.Button();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.tpDrink = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.cbDrinkCategory = new System.Windows.Forms.ComboBox();
            this.lbDrinkCatefory = new System.Windows.Forms.Label();
            this.txtDrinkName = new System.Windows.Forms.TextBox();
            this.lbDrinkName = new System.Windows.Forms.Label();
            this.txtDrinkID = new System.Windows.Forms.TextBox();
            this.lbDrinkID = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgvDrink = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtSearchDrinkName = new System.Windows.Forms.TextBox();
            this.btnSearchDrink = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnViewDrink = new System.Windows.Forms.Button();
            this.btnDeleteDrink = new System.Windows.Forms.Button();
            this.btnEditDrink = new System.Windows.Forms.Button();
            this.btnAddDrink = new System.Windows.Forms.Button();
            this.tpCategory = new System.Windows.Forms.TabPage();
            this.lbCategoryName = new System.Windows.Forms.Panel();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCategoryID = new System.Windows.Forms.TextBox();
            this.lbCategoryID = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnViewCategory = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnEditCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.tpTable = new System.Windows.Forms.TabPage();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.lbTableName = new System.Windows.Forms.Label();
            this.txtTableID = new System.Windows.Forms.TextBox();
            this.lbTabelID = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnViewTable = new System.Windows.Forms.Button();
            this.btnDeleteTable = new System.Windows.Forms.Button();
            this.btnEditTable = new System.Windows.Forms.Button();
            this.btnAddTable = new System.Windows.Forms.Button();
            this.tpAccount = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.nbAccountType = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.lbAccountType = new System.Windows.Forms.Label();
            this.txtAccountDisplayName = new System.Windows.Forms.TextBox();
            this.lbAccountName = new System.Windows.Forms.Label();
            this.txtAccountUsername = new System.Windows.Forms.TextBox();
            this.lbAccountID = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.panel14 = new System.Windows.Forms.Panel();
            this.btnViewAccount = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnEditAccount = new System.Windows.Forms.Button();
            this.btnAddAcount = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tpBill.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.tpDrink.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrink)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tpCategory.SuspendLayout();
            this.lbCategoryName.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            this.panel10.SuspendLayout();
            this.tpTable.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.panel12.SuspendLayout();
            this.tpAccount.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbAccountType)).BeginInit();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.panel14.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpBill);
            this.tabControl.Controls.Add(this.tpDrink);
            this.tabControl.Controls.Add(this.tpCategory);
            this.tabControl.Controls.Add(this.tpTable);
            this.tabControl.Controls.Add(this.tpAccount);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(868, 605);
            this.tabControl.TabIndex = 0;
            // 
            // tpBill
            // 
            this.tpBill.Controls.Add(this.panel2);
            this.tpBill.Controls.Add(this.panel1);
            this.tpBill.Location = new System.Drawing.Point(4, 24);
            this.tpBill.Name = "tpBill";
            this.tpBill.Padding = new System.Windows.Forms.Padding(3);
            this.tpBill.Size = new System.Drawing.Size(860, 577);
            this.tpBill.TabIndex = 0;
            this.tpBill.Text = "Doanh thu";
            this.tpBill.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbEnd);
            this.panel2.Controls.Add(this.lbFrom);
            this.panel2.Controls.Add(this.btnSearchBill);
            this.panel2.Controls.Add(this.dtpEndDate);
            this.panel2.Controls.Add(this.dtpFromDate);
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(848, 47);
            this.panel2.TabIndex = 3;
            // 
            // lbEnd
            // 
            this.lbEnd.AutoSize = true;
            this.lbEnd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbEnd.Location = new System.Drawing.Point(369, 15);
            this.lbEnd.Name = "lbEnd";
            this.lbEnd.Size = new System.Drawing.Size(41, 21);
            this.lbEnd.TabIndex = 4;
            this.lbEnd.Text = "Đến";
            // 
            // lbFrom
            // 
            this.lbFrom.AutoSize = true;
            this.lbFrom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbFrom.Location = new System.Drawing.Point(78, 15);
            this.lbFrom.Name = "lbFrom";
            this.lbFrom.Size = new System.Drawing.Size(30, 21);
            this.lbFrom.TabIndex = 3;
            this.lbFrom.Text = "Từ";
            // 
            // btnSearchBill
            // 
            this.btnSearchBill.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearchBill.Location = new System.Drawing.Point(687, 9);
            this.btnSearchBill.Name = "btnSearchBill";
            this.btnSearchBill.Size = new System.Drawing.Size(73, 32);
            this.btnSearchBill.TabIndex = 2;
            this.btnSearchBill.Text = "Tìm";
            this.btnSearchBill.UseVisualStyleBackColor = true;
            this.btnSearchBill.Click += new System.EventHandler(this.btnSearchBill_Click);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(438, 14);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 23);
            this.dtpEndDate.TabIndex = 1;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Location = new System.Drawing.Point(136, 14);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(200, 23);
            this.dtpFromDate.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Controls.Add(this.dgvBill);
            this.panel1.Location = new System.Drawing.Point(6, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(848, 512);
            this.panel1.TabIndex = 2;
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExport.ForeColor = System.Drawing.Color.Red;
            this.btnExport.Location = new System.Drawing.Point(17, 469);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(124, 35);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "Xuất file";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // dgvBill
            // 
            this.dgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Location = new System.Drawing.Point(3, 3);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.RowTemplate.Height = 25;
            this.dgvBill.Size = new System.Drawing.Size(842, 456);
            this.dgvBill.TabIndex = 0;
            // 
            // tpDrink
            // 
            this.tpDrink.Controls.Add(this.panel5);
            this.tpDrink.Controls.Add(this.panel6);
            this.tpDrink.Controls.Add(this.panel4);
            this.tpDrink.Controls.Add(this.panel3);
            this.tpDrink.Location = new System.Drawing.Point(4, 24);
            this.tpDrink.Name = "tpDrink";
            this.tpDrink.Padding = new System.Windows.Forms.Padding(3);
            this.tpDrink.Size = new System.Drawing.Size(860, 577);
            this.tpDrink.TabIndex = 1;
            this.tpDrink.Text = "Đồ uống";
            this.tpDrink.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtPrice);
            this.panel5.Controls.Add(this.lbPrice);
            this.panel5.Controls.Add(this.cbDrinkCategory);
            this.panel5.Controls.Add(this.lbDrinkCatefory);
            this.panel5.Controls.Add(this.txtDrinkName);
            this.panel5.Controls.Add(this.lbDrinkName);
            this.panel5.Controls.Add(this.txtDrinkID);
            this.panel5.Controls.Add(this.lbDrinkID);
            this.panel5.Location = new System.Drawing.Point(428, 78);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(426, 488);
            this.panel5.TabIndex = 3;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(148, 191);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(258, 23);
            this.txtPrice.TabIndex = 10;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPrice.Location = new System.Drawing.Point(20, 189);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(41, 25);
            this.lbPrice.TabIndex = 9;
            this.lbPrice.Text = "Giá";
            // 
            // cbDrinkCategory
            // 
            this.cbDrinkCategory.FormattingEnabled = true;
            this.cbDrinkCategory.Location = new System.Drawing.Point(148, 133);
            this.cbDrinkCategory.Name = "cbDrinkCategory";
            this.cbDrinkCategory.Size = new System.Drawing.Size(258, 23);
            this.cbDrinkCategory.TabIndex = 8;
            // 
            // lbDrinkCatefory
            // 
            this.lbDrinkCatefory.AutoSize = true;
            this.lbDrinkCatefory.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDrinkCatefory.Location = new System.Drawing.Point(20, 130);
            this.lbDrinkCatefory.Name = "lbDrinkCatefory";
            this.lbDrinkCatefory.Size = new System.Drawing.Size(102, 25);
            this.lbDrinkCatefory.TabIndex = 7;
            this.lbDrinkCatefory.Text = "Danh mục";
            // 
            // txtDrinkName
            // 
            this.txtDrinkName.Location = new System.Drawing.Point(148, 81);
            this.txtDrinkName.Name = "txtDrinkName";
            this.txtDrinkName.Size = new System.Drawing.Size(258, 23);
            this.txtDrinkName.TabIndex = 6;
            // 
            // lbDrinkName
            // 
            this.lbDrinkName.AutoSize = true;
            this.lbDrinkName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDrinkName.Location = new System.Drawing.Point(20, 79);
            this.lbDrinkName.Name = "lbDrinkName";
            this.lbDrinkName.Size = new System.Drawing.Size(125, 25);
            this.lbDrinkName.TabIndex = 5;
            this.lbDrinkName.Text = "Tên đồ uống";
            // 
            // txtDrinkID
            // 
            this.txtDrinkID.Location = new System.Drawing.Point(148, 28);
            this.txtDrinkID.Name = "txtDrinkID";
            this.txtDrinkID.ReadOnly = true;
            this.txtDrinkID.Size = new System.Drawing.Size(258, 23);
            this.txtDrinkID.TabIndex = 4;
            this.txtDrinkID.TextChanged += new System.EventHandler(this.txtDrinkID_TextChanged);
            // 
            // lbDrinkID
            // 
            this.lbDrinkID.AutoSize = true;
            this.lbDrinkID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDrinkID.Location = new System.Drawing.Point(20, 26);
            this.lbDrinkID.Name = "lbDrinkID";
            this.lbDrinkID.Size = new System.Drawing.Size(122, 25);
            this.lbDrinkID.TabIndex = 3;
            this.lbDrinkID.Text = "Mã đồ uống";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dgvDrink);
            this.panel6.Location = new System.Drawing.Point(6, 78);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(416, 488);
            this.panel6.TabIndex = 2;
            // 
            // dgvDrink
            // 
            this.dgvDrink.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDrink.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDrink.Location = new System.Drawing.Point(3, 3);
            this.dgvDrink.Name = "dgvDrink";
            this.dgvDrink.RowTemplate.Height = 25;
            this.dgvDrink.Size = new System.Drawing.Size(410, 482);
            this.dgvDrink.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtSearchDrinkName);
            this.panel4.Controls.Add(this.btnSearchDrink);
            this.panel4.Location = new System.Drawing.Point(428, 11);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(426, 61);
            this.panel4.TabIndex = 1;
            // 
            // txtSearchDrinkName
            // 
            this.txtSearchDrinkName.Location = new System.Drawing.Point(128, 20);
            this.txtSearchDrinkName.Name = "txtSearchDrinkName";
            this.txtSearchDrinkName.Size = new System.Drawing.Size(278, 23);
            this.txtSearchDrinkName.TabIndex = 11;
            // 
            // btnSearchDrink
            // 
            this.btnSearchDrink.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearchDrink.Location = new System.Drawing.Point(20, 16);
            this.btnSearchDrink.Name = "btnSearchDrink";
            this.btnSearchDrink.Size = new System.Drawing.Size(90, 30);
            this.btnSearchDrink.TabIndex = 10;
            this.btnSearchDrink.Text = "Tìm";
            this.btnSearchDrink.UseVisualStyleBackColor = true;
            this.btnSearchDrink.Click += new System.EventHandler(this.btnSearchDrink_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnViewDrink);
            this.panel3.Controls.Add(this.btnDeleteDrink);
            this.panel3.Controls.Add(this.btnEditDrink);
            this.panel3.Controls.Add(this.btnAddDrink);
            this.panel3.Location = new System.Drawing.Point(6, 11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(416, 61);
            this.panel3.TabIndex = 0;
            // 
            // btnViewDrink
            // 
            this.btnViewDrink.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnViewDrink.Location = new System.Drawing.Point(307, 16);
            this.btnViewDrink.Name = "btnViewDrink";
            this.btnViewDrink.Size = new System.Drawing.Size(90, 30);
            this.btnViewDrink.TabIndex = 9;
            this.btnViewDrink.Text = "Xem";
            this.btnViewDrink.UseVisualStyleBackColor = true;
            this.btnViewDrink.Click += new System.EventHandler(this.btnViewDrink_Click);
            // 
            // btnDeleteDrink
            // 
            this.btnDeleteDrink.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteDrink.Location = new System.Drawing.Point(211, 16);
            this.btnDeleteDrink.Name = "btnDeleteDrink";
            this.btnDeleteDrink.Size = new System.Drawing.Size(90, 30);
            this.btnDeleteDrink.TabIndex = 8;
            this.btnDeleteDrink.Text = "Xóa";
            this.btnDeleteDrink.UseVisualStyleBackColor = true;
            this.btnDeleteDrink.Click += new System.EventHandler(this.btnDeleteDrink_Click);
            // 
            // btnEditDrink
            // 
            this.btnEditDrink.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditDrink.Location = new System.Drawing.Point(115, 16);
            this.btnEditDrink.Name = "btnEditDrink";
            this.btnEditDrink.Size = new System.Drawing.Size(90, 30);
            this.btnEditDrink.TabIndex = 7;
            this.btnEditDrink.Text = "Sửa";
            this.btnEditDrink.UseVisualStyleBackColor = true;
            this.btnEditDrink.Click += new System.EventHandler(this.btnEditDrink_Click);
            // 
            // btnAddDrink
            // 
            this.btnAddDrink.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddDrink.Location = new System.Drawing.Point(19, 16);
            this.btnAddDrink.Name = "btnAddDrink";
            this.btnAddDrink.Size = new System.Drawing.Size(90, 30);
            this.btnAddDrink.TabIndex = 6;
            this.btnAddDrink.Text = "Thêm";
            this.btnAddDrink.UseVisualStyleBackColor = true;
            this.btnAddDrink.Click += new System.EventHandler(this.btnAddDrink_Click);
            // 
            // tpCategory
            // 
            this.tpCategory.Controls.Add(this.lbCategoryName);
            this.tpCategory.Controls.Add(this.panel8);
            this.tpCategory.Controls.Add(this.panel10);
            this.tpCategory.Location = new System.Drawing.Point(4, 24);
            this.tpCategory.Name = "tpCategory";
            this.tpCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tpCategory.Size = new System.Drawing.Size(860, 577);
            this.tpCategory.TabIndex = 2;
            this.tpCategory.Text = "Danh mục";
            this.tpCategory.UseVisualStyleBackColor = true;
            // 
            // lbCategoryName
            // 
            this.lbCategoryName.Controls.Add(this.txtCategoryName);
            this.lbCategoryName.Controls.Add(this.label3);
            this.lbCategoryName.Controls.Add(this.txtCategoryID);
            this.lbCategoryName.Controls.Add(this.lbCategoryID);
            this.lbCategoryName.Location = new System.Drawing.Point(428, 78);
            this.lbCategoryName.Name = "lbCategoryName";
            this.lbCategoryName.Size = new System.Drawing.Size(426, 488);
            this.lbCategoryName.TabIndex = 7;
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(155, 81);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(258, 23);
            this.txtCategoryName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(20, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên danh mục";
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.Location = new System.Drawing.Point(155, 28);
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.ReadOnly = true;
            this.txtCategoryID.Size = new System.Drawing.Size(258, 23);
            this.txtCategoryID.TabIndex = 4;
            // 
            // lbCategoryID
            // 
            this.lbCategoryID.AutoSize = true;
            this.lbCategoryID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCategoryID.Location = new System.Drawing.Point(20, 26);
            this.lbCategoryID.Name = "lbCategoryID";
            this.lbCategoryID.Size = new System.Drawing.Size(133, 25);
            this.lbCategoryID.TabIndex = 3;
            this.lbCategoryID.Text = "Mã danh mục";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.dgvCategory);
            this.panel8.Location = new System.Drawing.Point(6, 78);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(416, 488);
            this.panel8.TabIndex = 6;
            // 
            // dgvCategory
            // 
            this.dgvCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Location = new System.Drawing.Point(3, 3);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.RowTemplate.Height = 25;
            this.dgvCategory.Size = new System.Drawing.Size(410, 482);
            this.dgvCategory.TabIndex = 0;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btnViewCategory);
            this.panel10.Controls.Add(this.btnDeleteCategory);
            this.panel10.Controls.Add(this.btnEditCategory);
            this.panel10.Controls.Add(this.btnAddCategory);
            this.panel10.Location = new System.Drawing.Point(225, 14);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(416, 61);
            this.panel10.TabIndex = 4;
            // 
            // btnViewCategory
            // 
            this.btnViewCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnViewCategory.Location = new System.Drawing.Point(307, 16);
            this.btnViewCategory.Name = "btnViewCategory";
            this.btnViewCategory.Size = new System.Drawing.Size(90, 30);
            this.btnViewCategory.TabIndex = 9;
            this.btnViewCategory.Text = "Xem";
            this.btnViewCategory.UseVisualStyleBackColor = true;
            this.btnViewCategory.Click += new System.EventHandler(this.btnViewCategory_Click);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteCategory.Location = new System.Drawing.Point(211, 16);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(90, 30);
            this.btnDeleteCategory.TabIndex = 8;
            this.btnDeleteCategory.Text = "Xóa";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditCategory.Location = new System.Drawing.Point(115, 16);
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.Size = new System.Drawing.Size(90, 30);
            this.btnEditCategory.TabIndex = 7;
            this.btnEditCategory.Text = "Sửa";
            this.btnEditCategory.UseVisualStyleBackColor = true;
            this.btnEditCategory.Click += new System.EventHandler(this.btnEditCategory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddCategory.Location = new System.Drawing.Point(19, 16);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(90, 30);
            this.btnAddCategory.TabIndex = 6;
            this.btnAddCategory.Text = "Thêm";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // tpTable
            // 
            this.tpTable.Controls.Add(this.panel9);
            this.tpTable.Controls.Add(this.panel11);
            this.tpTable.Controls.Add(this.panel12);
            this.tpTable.Location = new System.Drawing.Point(4, 24);
            this.tpTable.Name = "tpTable";
            this.tpTable.Padding = new System.Windows.Forms.Padding(3);
            this.tpTable.Size = new System.Drawing.Size(860, 577);
            this.tpTable.TabIndex = 3;
            this.tpTable.Text = "Bàn";
            this.tpTable.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.txtTableName);
            this.panel9.Controls.Add(this.lbTableName);
            this.panel9.Controls.Add(this.txtTableID);
            this.panel9.Controls.Add(this.lbTabelID);
            this.panel9.Location = new System.Drawing.Point(428, 76);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(426, 488);
            this.panel9.TabIndex = 10;
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(155, 81);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(258, 23);
            this.txtTableName.TabIndex = 6;
            // 
            // lbTableName
            // 
            this.lbTableName.AutoSize = true;
            this.lbTableName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTableName.Location = new System.Drawing.Point(20, 79);
            this.lbTableName.Name = "lbTableName";
            this.lbTableName.Size = new System.Drawing.Size(82, 25);
            this.lbTableName.TabIndex = 5;
            this.lbTableName.Text = "Tên bàn";
            // 
            // txtTableID
            // 
            this.txtTableID.Location = new System.Drawing.Point(155, 28);
            this.txtTableID.Name = "txtTableID";
            this.txtTableID.ReadOnly = true;
            this.txtTableID.Size = new System.Drawing.Size(258, 23);
            this.txtTableID.TabIndex = 4;
            // 
            // lbTabelID
            // 
            this.lbTabelID.AutoSize = true;
            this.lbTabelID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTabelID.Location = new System.Drawing.Point(20, 26);
            this.lbTabelID.Name = "lbTabelID";
            this.lbTabelID.Size = new System.Drawing.Size(79, 25);
            this.lbTabelID.TabIndex = 3;
            this.lbTabelID.Text = "Mã bàn";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.dgvTable);
            this.panel11.Location = new System.Drawing.Point(6, 76);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(416, 488);
            this.panel11.TabIndex = 9;
            // 
            // dgvTable
            // 
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Location = new System.Drawing.Point(3, 3);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.RowTemplate.Height = 25;
            this.dgvTable.Size = new System.Drawing.Size(410, 482);
            this.dgvTable.TabIndex = 0;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.btnViewTable);
            this.panel12.Controls.Add(this.btnDeleteTable);
            this.panel12.Controls.Add(this.btnEditTable);
            this.panel12.Controls.Add(this.btnAddTable);
            this.panel12.Location = new System.Drawing.Point(225, 12);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(416, 61);
            this.panel12.TabIndex = 8;
            // 
            // btnViewTable
            // 
            this.btnViewTable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnViewTable.Location = new System.Drawing.Point(307, 16);
            this.btnViewTable.Name = "btnViewTable";
            this.btnViewTable.Size = new System.Drawing.Size(90, 30);
            this.btnViewTable.TabIndex = 9;
            this.btnViewTable.Text = "Xem";
            this.btnViewTable.UseVisualStyleBackColor = true;
            this.btnViewTable.Click += new System.EventHandler(this.btnViewTable_Click);
            // 
            // btnDeleteTable
            // 
            this.btnDeleteTable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteTable.Location = new System.Drawing.Point(211, 16);
            this.btnDeleteTable.Name = "btnDeleteTable";
            this.btnDeleteTable.Size = new System.Drawing.Size(90, 30);
            this.btnDeleteTable.TabIndex = 8;
            this.btnDeleteTable.Text = "Xóa";
            this.btnDeleteTable.UseVisualStyleBackColor = true;
            this.btnDeleteTable.Click += new System.EventHandler(this.btnDeleteTable_Click);
            // 
            // btnEditTable
            // 
            this.btnEditTable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditTable.Location = new System.Drawing.Point(115, 16);
            this.btnEditTable.Name = "btnEditTable";
            this.btnEditTable.Size = new System.Drawing.Size(90, 30);
            this.btnEditTable.TabIndex = 7;
            this.btnEditTable.Text = "Sửa";
            this.btnEditTable.UseVisualStyleBackColor = true;
            this.btnEditTable.Click += new System.EventHandler(this.btnEditTable_Click);
            // 
            // btnAddTable
            // 
            this.btnAddTable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddTable.Location = new System.Drawing.Point(19, 16);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(90, 30);
            this.btnAddTable.TabIndex = 6;
            this.btnAddTable.Text = "Thêm";
            this.btnAddTable.UseVisualStyleBackColor = true;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // tpAccount
            // 
            this.tpAccount.Controls.Add(this.panel7);
            this.tpAccount.Controls.Add(this.panel13);
            this.tpAccount.Controls.Add(this.panel14);
            this.tpAccount.Location = new System.Drawing.Point(4, 24);
            this.tpAccount.Name = "tpAccount";
            this.tpAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tpAccount.Size = new System.Drawing.Size(860, 577);
            this.tpAccount.TabIndex = 4;
            this.tpAccount.Text = "Tài khoản";
            this.tpAccount.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.nbAccountType);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.btnResetPassword);
            this.panel7.Controls.Add(this.lbAccountType);
            this.panel7.Controls.Add(this.txtAccountDisplayName);
            this.panel7.Controls.Add(this.lbAccountName);
            this.panel7.Controls.Add(this.txtAccountUsername);
            this.panel7.Controls.Add(this.lbAccountID);
            this.panel7.Location = new System.Drawing.Point(428, 76);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(426, 488);
            this.panel7.TabIndex = 13;
            // 
            // nbAccountType
            // 
            this.nbAccountType.Location = new System.Drawing.Point(155, 136);
            this.nbAccountType.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbAccountType.Name = "nbAccountType";
            this.nbAccountType.Size = new System.Drawing.Size(120, 23);
            this.nbAccountType.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "1 là Admin)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "(0 là Nhân viên";
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnResetPassword.Location = new System.Drawing.Point(308, 188);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(95, 59);
            this.btnResetPassword.TabIndex = 9;
            this.btnResetPassword.Text = "Đặt lại mật khẩu";
            this.btnResetPassword.UseVisualStyleBackColor = true;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // lbAccountType
            // 
            this.lbAccountType.AutoSize = true;
            this.lbAccountType.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbAccountType.Location = new System.Drawing.Point(20, 134);
            this.lbAccountType.Name = "lbAccountType";
            this.lbAccountType.Size = new System.Drawing.Size(137, 25);
            this.lbAccountType.TabIndex = 7;
            this.lbAccountType.Text = "Loại tài khoản";
            // 
            // txtAccountDisplayName
            // 
            this.txtAccountDisplayName.Location = new System.Drawing.Point(155, 81);
            this.txtAccountDisplayName.Name = "txtAccountDisplayName";
            this.txtAccountDisplayName.Size = new System.Drawing.Size(258, 23);
            this.txtAccountDisplayName.TabIndex = 6;
            // 
            // lbAccountName
            // 
            this.lbAccountName.AutoSize = true;
            this.lbAccountName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbAccountName.Location = new System.Drawing.Point(20, 79);
            this.lbAccountName.Name = "lbAccountName";
            this.lbAccountName.Size = new System.Drawing.Size(114, 25);
            this.lbAccountName.TabIndex = 5;
            this.lbAccountName.Text = "Tên hiển thị";
            // 
            // txtAccountUsername
            // 
            this.txtAccountUsername.Location = new System.Drawing.Point(155, 28);
            this.txtAccountUsername.Name = "txtAccountUsername";
            this.txtAccountUsername.Size = new System.Drawing.Size(258, 23);
            this.txtAccountUsername.TabIndex = 4;
            // 
            // lbAccountID
            // 
            this.lbAccountID.AutoSize = true;
            this.lbAccountID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbAccountID.Location = new System.Drawing.Point(20, 26);
            this.lbAccountID.Name = "lbAccountID";
            this.lbAccountID.Size = new System.Drawing.Size(131, 25);
            this.lbAccountID.TabIndex = 3;
            this.lbAccountID.Text = "Tên tài khoản";
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.dgvAccount);
            this.panel13.Location = new System.Drawing.Point(6, 76);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(416, 488);
            this.panel13.TabIndex = 12;
            // 
            // dgvAccount
            // 
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Location = new System.Drawing.Point(3, 3);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.RowTemplate.Height = 25;
            this.dgvAccount.Size = new System.Drawing.Size(410, 482);
            this.dgvAccount.TabIndex = 0;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.btnViewAccount);
            this.panel14.Controls.Add(this.btnDeleteAccount);
            this.panel14.Controls.Add(this.btnEditAccount);
            this.panel14.Controls.Add(this.btnAddAcount);
            this.panel14.Location = new System.Drawing.Point(225, 12);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(416, 61);
            this.panel14.TabIndex = 11;
            // 
            // btnViewAccount
            // 
            this.btnViewAccount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnViewAccount.Location = new System.Drawing.Point(307, 16);
            this.btnViewAccount.Name = "btnViewAccount";
            this.btnViewAccount.Size = new System.Drawing.Size(90, 30);
            this.btnViewAccount.TabIndex = 9;
            this.btnViewAccount.Text = "Xem";
            this.btnViewAccount.UseVisualStyleBackColor = true;
            this.btnViewAccount.Click += new System.EventHandler(this.btnViewAccount_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteAccount.Location = new System.Drawing.Point(211, 16);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(90, 30);
            this.btnDeleteAccount.TabIndex = 8;
            this.btnDeleteAccount.Text = "Xóa";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditAccount.Location = new System.Drawing.Point(115, 16);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.Size = new System.Drawing.Size(90, 30);
            this.btnEditAccount.TabIndex = 7;
            this.btnEditAccount.Text = "Sửa";
            this.btnEditAccount.UseVisualStyleBackColor = true;
            this.btnEditAccount.Click += new System.EventHandler(this.btnEditAccount_Click);
            // 
            // btnAddAcount
            // 
            this.btnAddAcount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddAcount.Location = new System.Drawing.Point(19, 16);
            this.btnAddAcount.Name = "btnAddAcount";
            this.btnAddAcount.Size = new System.Drawing.Size(90, 30);
            this.btnAddAcount.TabIndex = 6;
            this.btnAddAcount.Text = "Thêm";
            this.btnAddAcount.UseVisualStyleBackColor = true;
            this.btnAddAcount.Click += new System.EventHandler(this.btnAddAcount_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 629);
            this.Controls.Add(this.tabControl);
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Shown += new System.EventHandler(this.frmAdmin_Shown);
            this.tabControl.ResumeLayout(false);
            this.tpBill.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.tpDrink.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrink)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tpCategory.ResumeLayout(false);
            this.lbCategoryName.ResumeLayout(false);
            this.lbCategoryName.PerformLayout();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            this.panel10.ResumeLayout(false);
            this.tpTable.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.panel12.ResumeLayout(false);
            this.tpAccount.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbAccountType)).EndInit();
            this.panel13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.panel14.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpBill;
        private System.Windows.Forms.TabPage tpDrink;
        private System.Windows.Forms.TabPage tpCategory;
        private System.Windows.Forms.TabPage tpTable;
        private System.Windows.Forms.TabPage tpAccount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbEnd;
        private System.Windows.Forms.Label lbFrom;
        private System.Windows.Forms.Button btnSearchBill;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvDrink;
        private System.Windows.Forms.TextBox txtSearchDrinkName;
        private System.Windows.Forms.Button btnSearchDrink;
        private System.Windows.Forms.Button btnViewDrink;
        private System.Windows.Forms.Button btnDeleteDrink;
        private System.Windows.Forms.Button btnEditDrink;
        private System.Windows.Forms.Button btnAddDrink;
        private System.Windows.Forms.TextBox txtDrinkID;
        private System.Windows.Forms.Label lbDrinkID;
        private System.Windows.Forms.Label lbDrinkCatefory;
        private System.Windows.Forms.TextBox txtDrinkName;
        private System.Windows.Forms.Label lbDrinkName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.ComboBox cbDrinkCategory;
        private System.Windows.Forms.Panel lbCategoryName;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCategoryID;
        private System.Windows.Forms.Label lbCategoryID;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataGridView dgvCategory;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnViewCategory;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnEditCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.Label lbTableName;
        private System.Windows.Forms.TextBox txtTableID;
        private System.Windows.Forms.Label lbTabelID;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button btnViewTable;
        private System.Windows.Forms.Button btnDeleteTable;
        private System.Windows.Forms.Button btnEditTable;
        private System.Windows.Forms.Button btnAddTable;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lbAccountType;
        private System.Windows.Forms.TextBox txtAccountDisplayName;
        private System.Windows.Forms.Label lbAccountName;
        private System.Windows.Forms.TextBox txtAccountUsername;
        private System.Windows.Forms.Label lbAccountID;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button btnViewAccount;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnEditAccount;
        private System.Windows.Forms.Button btnAddAcount;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nbAccountType;
        private System.Windows.Forms.Button btnExport;
    }
}