namespace MyMusicGUI
{
    partial class MainPanel
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
            this.tabControlLogs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.searchProductButton = new System.Windows.Forms.Button();
            this.searchTermBox = new System.Windows.Forms.TextBox();
            this.removeProductButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.updateProductButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.productIdBox = new System.Windows.Forms.TextBox();
            this.productCountBox = new System.Windows.Forms.TextBox();
            this.productPriceBox = new System.Windows.Forms.TextBox();
            this.productBrandBox = new System.Windows.Forms.TextBox();
            this.productNameBox = new System.Windows.Forms.TextBox();
            this.refreshDataButton = new System.Windows.Forms.Button();
            this.addProductButton = new System.Windows.Forms.Button();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.orderCompleteButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.customersRefreshButton = new System.Windows.Forms.Button();
            this.dataGridViewCustomers = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.employeeRemoveButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.employeeUpdateButton = new System.Windows.Forms.Button();
            this.employeeDateBox = new System.Windows.Forms.TextBox();
            this.employeeAdressBox = new System.Windows.Forms.TextBox();
            this.employeePhoneBox = new System.Windows.Forms.TextBox();
            this.employeeNameBox = new System.Windows.Forms.TextBox();
            this.employeeIdBox = new System.Windows.Forms.TextBox();
            this.employeeRefreshButton = new System.Windows.Forms.Button();
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.logRefreshButton = new System.Windows.Forms.Button();
            this.dataGridViewLogs = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControlLogs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlLogs
            // 
            this.tabControlLogs.Controls.Add(this.tabPage1);
            this.tabControlLogs.Controls.Add(this.tabPage2);
            this.tabControlLogs.Controls.Add(this.tabPage3);
            this.tabControlLogs.Controls.Add(this.tabPage4);
            this.tabControlLogs.Controls.Add(this.tabPage5);
            this.tabControlLogs.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9.75F, System.Drawing.FontStyle.Bold);
            this.tabControlLogs.Location = new System.Drawing.Point(12, 22);
            this.tabControlLogs.Name = "tabControlLogs";
            this.tabControlLogs.SelectedIndex = 0;
            this.tabControlLogs.Size = new System.Drawing.Size(954, 565);
            this.tabControlLogs.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.OldLace;
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.searchProductButton);
            this.tabPage1.Controls.Add(this.searchTermBox);
            this.tabPage1.Controls.Add(this.removeProductButton);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.refreshDataButton);
            this.tabPage1.Controls.Add(this.addProductButton);
            this.tabPage1.Controls.Add(this.dataGridViewProducts);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(946, 536);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Products";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Alphabetically",
            "Price Asc",
            "Price Desc"});
            this.comboBox1.Location = new System.Drawing.Point(787, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // searchProductButton
            // 
            this.searchProductButton.Location = new System.Drawing.Point(550, 8);
            this.searchProductButton.Name = "searchProductButton";
            this.searchProductButton.Size = new System.Drawing.Size(67, 20);
            this.searchProductButton.TabIndex = 6;
            this.searchProductButton.Text = "Search";
            this.searchProductButton.UseVisualStyleBackColor = true;
            this.searchProductButton.Click += new System.EventHandler(this.searchProductButton_Click);
            // 
            // searchTermBox
            // 
            this.searchTermBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.searchTermBox.Location = new System.Drawing.Point(170, 8);
            this.searchTermBox.Name = "searchTermBox";
            this.searchTermBox.Size = new System.Drawing.Size(374, 20);
            this.searchTermBox.TabIndex = 5;
            // 
            // removeProductButton
            // 
            this.removeProductButton.Location = new System.Drawing.Point(23, 139);
            this.removeProductButton.Name = "removeProductButton";
            this.removeProductButton.Size = new System.Drawing.Size(119, 37);
            this.removeProductButton.TabIndex = 4;
            this.removeProductButton.Text = "Remove Product";
            this.removeProductButton.UseVisualStyleBackColor = true;
            this.removeProductButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.updateProductButton);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.productIdBox);
            this.groupBox1.Controls.Add(this.productCountBox);
            this.groupBox1.Controls.Add(this.productPriceBox);
            this.groupBox1.Controls.Add(this.productBrandBox);
            this.groupBox1.Controls.Add(this.productNameBox);
            this.groupBox1.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(170, 342);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(738, 191);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Info";
            // 
            // updateProductButton
            // 
            this.updateProductButton.Location = new System.Drawing.Point(617, 134);
            this.updateProductButton.Name = "updateProductButton";
            this.updateProductButton.Size = new System.Drawing.Size(98, 36);
            this.updateProductButton.TabIndex = 10;
            this.updateProductButton.Text = "Update";
            this.updateProductButton.UseVisualStyleBackColor = true;
            this.updateProductButton.Click += new System.EventHandler(this.updateProductButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(329, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Count";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(483, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Brand";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            // 
            // productIdBox
            // 
            this.productIdBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.productIdBox.Location = new System.Drawing.Point(52, 39);
            this.productIdBox.Name = "productIdBox";
            this.productIdBox.ReadOnly = true;
            this.productIdBox.Size = new System.Drawing.Size(88, 20);
            this.productIdBox.TabIndex = 4;
            // 
            // productCountBox
            // 
            this.productCountBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.productCountBox.Location = new System.Drawing.Point(380, 109);
            this.productCountBox.Name = "productCountBox";
            this.productCountBox.Size = new System.Drawing.Size(182, 20);
            this.productCountBox.TabIndex = 3;
            // 
            // productPriceBox
            // 
            this.productPriceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.productPriceBox.Location = new System.Drawing.Point(98, 109);
            this.productPriceBox.Name = "productPriceBox";
            this.productPriceBox.Size = new System.Drawing.Size(182, 20);
            this.productPriceBox.TabIndex = 2;
            // 
            // productBrandBox
            // 
            this.productBrandBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.productBrandBox.Location = new System.Drawing.Point(533, 41);
            this.productBrandBox.Name = "productBrandBox";
            this.productBrandBox.Size = new System.Drawing.Size(182, 20);
            this.productBrandBox.TabIndex = 1;
            // 
            // productNameBox
            // 
            this.productNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.productNameBox.Location = new System.Drawing.Point(253, 41);
            this.productNameBox.Name = "productNameBox";
            this.productNameBox.Size = new System.Drawing.Size(182, 20);
            this.productNameBox.TabIndex = 0;
            // 
            // refreshDataButton
            // 
            this.refreshDataButton.BackgroundImage = global::MyMusicGUI.Properties.Resources.refresh;
            this.refreshDataButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refreshDataButton.Location = new System.Drawing.Point(915, 34);
            this.refreshDataButton.Name = "refreshDataButton";
            this.refreshDataButton.Size = new System.Drawing.Size(25, 25);
            this.refreshDataButton.TabIndex = 2;
            this.refreshDataButton.UseVisualStyleBackColor = true;
            this.refreshDataButton.Click += new System.EventHandler(this.refreshDataButton_Click);
            // 
            // addProductButton
            // 
            this.addProductButton.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9.75F, System.Drawing.FontStyle.Bold);
            this.addProductButton.Location = new System.Drawing.Point(23, 76);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(119, 39);
            this.addProductButton.TabIndex = 1;
            this.addProductButton.Text = "Add Product";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(170, 34);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.Size = new System.Drawing.Size(739, 302);
            this.dataGridViewProducts.TabIndex = 0;
            this.dataGridViewProducts.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewProducts_RowHeaderMouseClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.OldLace;
            this.tabPage2.Controls.Add(this.orderCompleteButton);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.dataGridViewOrders);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(946, 536);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Orders";
            // 
            // orderCompleteButton
            // 
            this.orderCompleteButton.Location = new System.Drawing.Point(794, 486);
            this.orderCompleteButton.Name = "orderCompleteButton";
            this.orderCompleteButton.Size = new System.Drawing.Size(114, 33);
            this.orderCompleteButton.TabIndex = 4;
            this.orderCompleteButton.Text = "Complete";
            this.orderCompleteButton.UseVisualStyleBackColor = true;
            this.orderCompleteButton.Click += new System.EventHandler(this.orderCompleteButton_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::MyMusicGUI.Properties.Resources.refresh;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(915, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(34, 34);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.Size = new System.Drawing.Size(875, 435);
            this.dataGridViewOrders.TabIndex = 1;
            this.dataGridViewOrders.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewOrders_RowHeaderMouseClick);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.OldLace;
            this.tabPage3.Controls.Add(this.customersRefreshButton);
            this.tabPage3.Controls.Add(this.dataGridViewCustomers);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(946, 536);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Customers";
            // 
            // customersRefreshButton
            // 
            this.customersRefreshButton.BackgroundImage = global::MyMusicGUI.Properties.Resources.refresh;
            this.customersRefreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.customersRefreshButton.Location = new System.Drawing.Point(915, 34);
            this.customersRefreshButton.Name = "customersRefreshButton";
            this.customersRefreshButton.Size = new System.Drawing.Size(25, 25);
            this.customersRefreshButton.TabIndex = 4;
            this.customersRefreshButton.UseVisualStyleBackColor = true;
            this.customersRefreshButton.Click += new System.EventHandler(this.customersRefreshButton_Click);
            // 
            // dataGridViewCustomers
            // 
            this.dataGridViewCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomers.Location = new System.Drawing.Point(37, 34);
            this.dataGridViewCustomers.Name = "dataGridViewCustomers";
            this.dataGridViewCustomers.Size = new System.Drawing.Size(873, 465);
            this.dataGridViewCustomers.TabIndex = 2;
            this.dataGridViewCustomers.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewCustomers_RowHeaderMouseClick);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.OldLace;
            this.tabPage4.Controls.Add(this.employeeRemoveButton);
            this.tabPage4.Controls.Add(this.groupBox2);
            this.tabPage4.Controls.Add(this.employeeRefreshButton);
            this.tabPage4.Controls.Add(this.dataGridViewEmployees);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(946, 536);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Employees";
            // 
            // employeeRemoveButton
            // 
            this.employeeRemoveButton.Location = new System.Drawing.Point(34, 474);
            this.employeeRemoveButton.Name = "employeeRemoveButton";
            this.employeeRemoveButton.Size = new System.Drawing.Size(96, 36);
            this.employeeRemoveButton.TabIndex = 7;
            this.employeeRemoveButton.Text = "Remove";
            this.employeeRemoveButton.UseVisualStyleBackColor = true;
            this.employeeRemoveButton.Click += new System.EventHandler(this.employeeRemoveButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.employeeUpdateButton);
            this.groupBox2.Controls.Add(this.employeeDateBox);
            this.groupBox2.Controls.Add(this.employeeAdressBox);
            this.groupBox2.Controls.Add(this.employeePhoneBox);
            this.groupBox2.Controls.Add(this.employeeNameBox);
            this.groupBox2.Controls.Add(this.employeeIdBox);
            this.groupBox2.Location = new System.Drawing.Point(148, 345);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(760, 171);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Employee Info";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(352, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Employement Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(126, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Adress";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(352, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Phone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(126, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "ID";
            // 
            // employeeUpdateButton
            // 
            this.employeeUpdateButton.Location = new System.Drawing.Point(663, 132);
            this.employeeUpdateButton.Name = "employeeUpdateButton";
            this.employeeUpdateButton.Size = new System.Drawing.Size(91, 33);
            this.employeeUpdateButton.TabIndex = 5;
            this.employeeUpdateButton.Text = "Update";
            this.employeeUpdateButton.UseVisualStyleBackColor = true;
            this.employeeUpdateButton.Click += new System.EventHandler(this.employeeUpdateButton_Click);
            // 
            // employeeDateBox
            // 
            this.employeeDateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.employeeDateBox.Location = new System.Drawing.Point(481, 104);
            this.employeeDateBox.Name = "employeeDateBox";
            this.employeeDateBox.ReadOnly = true;
            this.employeeDateBox.Size = new System.Drawing.Size(143, 20);
            this.employeeDateBox.TabIndex = 4;
            // 
            // employeeAdressBox
            // 
            this.employeeAdressBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.employeeAdressBox.Location = new System.Drawing.Point(181, 106);
            this.employeeAdressBox.Name = "employeeAdressBox";
            this.employeeAdressBox.Size = new System.Drawing.Size(143, 20);
            this.employeeAdressBox.TabIndex = 3;
            // 
            // employeePhoneBox
            // 
            this.employeePhoneBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.employeePhoneBox.Location = new System.Drawing.Point(405, 34);
            this.employeePhoneBox.Name = "employeePhoneBox";
            this.employeePhoneBox.Size = new System.Drawing.Size(143, 20);
            this.employeePhoneBox.TabIndex = 2;
            // 
            // employeeNameBox
            // 
            this.employeeNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.employeeNameBox.Location = new System.Drawing.Point(181, 32);
            this.employeeNameBox.Name = "employeeNameBox";
            this.employeeNameBox.Size = new System.Drawing.Size(143, 20);
            this.employeeNameBox.TabIndex = 1;
            // 
            // employeeIdBox
            // 
            this.employeeIdBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.employeeIdBox.Location = new System.Drawing.Point(55, 32);
            this.employeeIdBox.Name = "employeeIdBox";
            this.employeeIdBox.ReadOnly = true;
            this.employeeIdBox.Size = new System.Drawing.Size(55, 20);
            this.employeeIdBox.TabIndex = 0;
            // 
            // employeeRefreshButton
            // 
            this.employeeRefreshButton.BackgroundImage = global::MyMusicGUI.Properties.Resources.refresh;
            this.employeeRefreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.employeeRefreshButton.Location = new System.Drawing.Point(915, 34);
            this.employeeRefreshButton.Name = "employeeRefreshButton";
            this.employeeRefreshButton.Size = new System.Drawing.Size(25, 25);
            this.employeeRefreshButton.TabIndex = 5;
            this.employeeRefreshButton.UseVisualStyleBackColor = true;
            this.employeeRefreshButton.Click += new System.EventHandler(this.employeeRefreshButton_Click);
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Location = new System.Drawing.Point(34, 34);
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.Size = new System.Drawing.Size(875, 287);
            this.dataGridViewEmployees.TabIndex = 3;
            this.dataGridViewEmployees.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewEmployees_RowHeaderMouseClick);
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.OldLace;
            this.tabPage5.Controls.Add(this.logRefreshButton);
            this.tabPage5.Controls.Add(this.dataGridViewLogs);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(946, 536);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Logs";
            // 
            // logRefreshButton
            // 
            this.logRefreshButton.BackgroundImage = global::MyMusicGUI.Properties.Resources.refresh;
            this.logRefreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logRefreshButton.Location = new System.Drawing.Point(915, 34);
            this.logRefreshButton.Name = "logRefreshButton";
            this.logRefreshButton.Size = new System.Drawing.Size(25, 25);
            this.logRefreshButton.TabIndex = 5;
            this.logRefreshButton.UseVisualStyleBackColor = true;
            this.logRefreshButton.Click += new System.EventHandler(this.logRefreshButton_Click);
            // 
            // dataGridViewLogs
            // 
            this.dataGridViewLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLogs.Location = new System.Drawing.Point(36, 34);
            this.dataGridViewLogs.Name = "dataGridViewLogs";
            this.dataGridViewLogs.Size = new System.Drawing.Size(873, 465);
            this.dataGridViewLogs.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyMusicGUI.Properties.Resources._2c6009ff_fd50_47ff_9870_dfa28c9b29a2_200x200;
            this.pictureBox1.Location = new System.Drawing.Point(972, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1050, 599);
            this.Controls.Add(this.tabControlLogs);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainPanel";
            this.Text = "MainPanel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainPanel_FormClosed);
            this.tabControlLogs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControlLogs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button refreshDataButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.DataGridView dataGridViewCustomers;
        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.Windows.Forms.DataGridView dataGridViewLogs;
        private System.Windows.Forms.TextBox productNameBox;
        private System.Windows.Forms.TextBox productBrandBox;
        private System.Windows.Forms.TextBox productIdBox;
        private System.Windows.Forms.TextBox productCountBox;
        private System.Windows.Forms.TextBox productPriceBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button updateProductButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button removeProductButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button customersRefreshButton;
        private System.Windows.Forms.Button employeeRefreshButton;
        private System.Windows.Forms.Button logRefreshButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button employeeUpdateButton;
        private System.Windows.Forms.TextBox employeeDateBox;
        private System.Windows.Forms.TextBox employeeAdressBox;
        private System.Windows.Forms.TextBox employeePhoneBox;
        private System.Windows.Forms.TextBox employeeNameBox;
        private System.Windows.Forms.TextBox employeeIdBox;
        private System.Windows.Forms.Button employeeRemoveButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button orderCompleteButton;
        private System.Windows.Forms.Button searchProductButton;
        private System.Windows.Forms.TextBox searchTermBox;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}