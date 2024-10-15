namespace DevFstPOSSuite.Windowforms
{
    partial class Supplier
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label businessNameLabel;
            System.Windows.Forms.Label businessTypeLabel;
            System.Windows.Forms.Label contactPersonLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label landLineLabel;
            System.Windows.Forms.Label mobileLabel;
            System.Windows.Forms.Label shortNameLabel;
            System.Windows.Forms.Label defaultBankIDLabel;
            System.Windows.Forms.Label accountNoLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Supplier));
            System.Windows.Forms.Label label2;
            this.activeCheckBox = new System.Windows.Forms.CheckBox();
            this.supplierEditModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.businessNameTextBox = new System.Windows.Forms.TextBox();
            this.businessTypeTextBox = new System.Windows.Forms.TextBox();
            this.contactPersonTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.landLineTextBox = new System.Windows.Forms.TextBox();
            this.mobileTextBox = new System.Windows.Forms.TextBox();
            this.shortNameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comBox_DefaultBankID = new System.Windows.Forms.ComboBox();
            this.bankBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountNoTextBox = new System.Windows.Forms.TextBox();
            this.SaveBtn = new MetroFramework.Controls.MetroTile();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.suppliersListGrid = new MetroFramework.Controls.MetroGrid();
            this.supplierModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.filterApplyBtn = new MetroFramework.Controls.MetroButton();
            this.filterTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.resetRecord = new MetroFramework.Controls.MetroTile();
            this.PaymentDaysTextBox = new System.Windows.Forms.TextBox();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.businessNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shortNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.businessTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactPersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.landLineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.defaultBankIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.accountNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            addressLabel = new System.Windows.Forms.Label();
            businessNameLabel = new System.Windows.Forms.Label();
            businessTypeLabel = new System.Windows.Forms.Label();
            contactPersonLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            landLineLabel = new System.Windows.Forms.Label();
            mobileLabel = new System.Windows.Forms.Label();
            shortNameLabel = new System.Windows.Forms.Label();
            defaultBankIDLabel = new System.Windows.Forms.Label();
            accountNoLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.supplierEditModelBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bankBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersListGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierModelBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(13, 57);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 2;
            addressLabel.Text = "Address:";
            // 
            // businessNameLabel
            // 
            businessNameLabel.AutoSize = true;
            businessNameLabel.Location = new System.Drawing.Point(13, 25);
            businessNameLabel.Name = "businessNameLabel";
            businessNameLabel.Size = new System.Drawing.Size(87, 13);
            businessNameLabel.TabIndex = 4;
            businessNameLabel.Text = "*Business Name:";
            // 
            // businessTypeLabel
            // 
            businessTypeLabel.AutoSize = true;
            businessTypeLabel.Location = new System.Drawing.Point(544, 25);
            businessTypeLabel.Name = "businessTypeLabel";
            businessTypeLabel.Size = new System.Drawing.Size(79, 13);
            businessTypeLabel.TabIndex = 6;
            businessTypeLabel.Text = "Business Type:";
            // 
            // contactPersonLabel
            // 
            contactPersonLabel.AutoSize = true;
            contactPersonLabel.Location = new System.Drawing.Point(793, 26);
            contactPersonLabel.Name = "contactPersonLabel";
            contactPersonLabel.Size = new System.Drawing.Size(83, 13);
            contactPersonLabel.TabIndex = 8;
            contactPersonLabel.Text = "Contact Person:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(209, 88);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 10;
            emailLabel.Text = "Email:";
            // 
            // landLineLabel
            // 
            landLineLabel.AutoSize = true;
            landLineLabel.Location = new System.Drawing.Point(793, 57);
            landLineLabel.Name = "landLineLabel";
            landLineLabel.Size = new System.Drawing.Size(57, 13);
            landLineLabel.TabIndex = 14;
            landLineLabel.Text = "Land Line:";
            // 
            // mobileLabel
            // 
            mobileLabel.AutoSize = true;
            mobileLabel.Location = new System.Drawing.Point(12, 88);
            mobileLabel.Name = "mobileLabel";
            mobileLabel.Size = new System.Drawing.Size(41, 13);
            mobileLabel.TabIndex = 16;
            mobileLabel.Text = "Mobile:";
            // 
            // shortNameLabel
            // 
            shortNameLabel.AutoSize = true;
            shortNameLabel.Location = new System.Drawing.Point(293, 101);
            shortNameLabel.Name = "shortNameLabel";
            shortNameLabel.Size = new System.Drawing.Size(70, 13);
            shortNameLabel.TabIndex = 18;
            shortNameLabel.Text = "*Short Name:";
            // 
            // defaultBankIDLabel
            // 
            defaultBankIDLabel.AutoSize = true;
            defaultBankIDLabel.Location = new System.Drawing.Point(559, 88);
            defaultBankIDLabel.Name = "defaultBankIDLabel";
            defaultBankIDLabel.Size = new System.Drawing.Size(72, 13);
            defaultBankIDLabel.TabIndex = 19;
            defaultBankIDLabel.Text = "Default Bank:";
            // 
            // accountNoLabel
            // 
            accountNoLabel.AutoSize = true;
            accountNoLabel.Location = new System.Drawing.Point(793, 88);
            accountNoLabel.Name = "accountNoLabel";
            accountNoLabel.Size = new System.Drawing.Size(67, 13);
            accountNoLabel.TabIndex = 20;
            accountNoLabel.Text = "Account No:";
            accountNoLabel.Click += new System.EventHandler(this.accountNoLabel_Click);
            // 
            // activeCheckBox
            // 
            this.activeCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.supplierEditModelBindingSource, "Active", true));
            this.activeCheckBox.Location = new System.Drawing.Point(227, 110);
            this.activeCheckBox.Name = "activeCheckBox";
            this.activeCheckBox.Size = new System.Drawing.Size(58, 24);
            this.activeCheckBox.TabIndex = 12;
            this.activeCheckBox.Text = "Active";
            this.activeCheckBox.UseVisualStyleBackColor = true;
            // 
            // supplierEditModelBindingSource
            // 
            this.supplierEditModelBindingSource.DataSource = typeof(DevFstPOSSuite.Models.SupplierEditModel);
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierEditModelBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(101, 53);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(678, 20);
            this.addressTextBox.TabIndex = 5;
            // 
            // businessNameTextBox
            // 
            this.businessNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierEditModelBindingSource, "BusinessName", true));
            this.businessNameTextBox.Location = new System.Drawing.Point(101, 22);
            this.businessNameTextBox.Name = "businessNameTextBox";
            this.businessNameTextBox.Size = new System.Drawing.Size(152, 20);
            this.businessNameTextBox.TabIndex = 1;
            // 
            // businessTypeTextBox
            // 
            this.businessTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierEditModelBindingSource, "BusinessType", true));
            this.businessTypeTextBox.Location = new System.Drawing.Point(627, 22);
            this.businessTypeTextBox.Name = "businessTypeTextBox";
            this.businessTypeTextBox.Size = new System.Drawing.Size(152, 20);
            this.businessTypeTextBox.TabIndex = 3;
            // 
            // contactPersonTextBox
            // 
            this.contactPersonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierEditModelBindingSource, "ContactPerson", true));
            this.contactPersonTextBox.Location = new System.Drawing.Point(881, 22);
            this.contactPersonTextBox.Name = "contactPersonTextBox";
            this.contactPersonTextBox.Size = new System.Drawing.Size(152, 20);
            this.contactPersonTextBox.TabIndex = 4;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierEditModelBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(250, 84);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(302, 20);
            this.emailTextBox.TabIndex = 8;
            // 
            // landLineTextBox
            // 
            this.landLineTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierEditModelBindingSource, "LandLine", true));
            this.landLineTextBox.Location = new System.Drawing.Point(881, 53);
            this.landLineTextBox.Name = "landLineTextBox";
            this.landLineTextBox.Size = new System.Drawing.Size(152, 20);
            this.landLineTextBox.TabIndex = 6;
            // 
            // mobileTextBox
            // 
            this.mobileTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierEditModelBindingSource, "Mobile", true));
            this.mobileTextBox.Location = new System.Drawing.Point(101, 84);
            this.mobileTextBox.Name = "mobileTextBox";
            this.mobileTextBox.Size = new System.Drawing.Size(102, 20);
            this.mobileTextBox.TabIndex = 7;
            // 
            // shortNameTextBox
            // 
            this.shortNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierEditModelBindingSource, "ShortName", true));
            this.shortNameTextBox.Location = new System.Drawing.Point(353, 22);
            this.shortNameTextBox.Name = "shortNameTextBox";
            this.shortNameTextBox.Size = new System.Drawing.Size(152, 20);
            this.shortNameTextBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PaymentDaysTextBox);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(this.comBox_DefaultBankID);
            this.groupBox1.Controls.Add(accountNoLabel);
            this.groupBox1.Controls.Add(this.accountNoTextBox);
            this.groupBox1.Controls.Add(defaultBankIDLabel);
            this.groupBox1.Controls.Add(mobileLabel);
            this.groupBox1.Controls.Add(this.emailTextBox);
            this.groupBox1.Controls.Add(this.activeCheckBox);
            this.groupBox1.Controls.Add(emailLabel);
            this.groupBox1.Controls.Add(this.shortNameTextBox);
            this.groupBox1.Controls.Add(addressLabel);
            this.groupBox1.Controls.Add(this.mobileTextBox);
            this.groupBox1.Controls.Add(this.addressTextBox);
            this.groupBox1.Controls.Add(this.landLineTextBox);
            this.groupBox1.Controls.Add(businessNameLabel);
            this.groupBox1.Controls.Add(landLineLabel);
            this.groupBox1.Controls.Add(this.businessNameTextBox);
            this.groupBox1.Controls.Add(this.contactPersonTextBox);
            this.groupBox1.Controls.Add(businessTypeLabel);
            this.groupBox1.Controls.Add(contactPersonLabel);
            this.groupBox1.Controls.Add(this.businessTypeTextBox);
            this.groupBox1.Location = new System.Drawing.Point(10, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1046, 136);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New/Edit Supplier";
            // 
            // comBox_DefaultBankID
            // 
            this.comBox_DefaultBankID.DataSource = this.bankBindingSource;
            this.comBox_DefaultBankID.DisplayMember = "ShortName";
            this.comBox_DefaultBankID.FormattingEnabled = true;
            this.comBox_DefaultBankID.Location = new System.Drawing.Point(647, 84);
            this.comBox_DefaultBankID.Name = "comBox_DefaultBankID";
            this.comBox_DefaultBankID.Size = new System.Drawing.Size(132, 21);
            this.comBox_DefaultBankID.TabIndex = 9;
            this.comBox_DefaultBankID.ValueMember = "ID";
            // 
            // bankBindingSource
            // 
            this.bankBindingSource.DataSource = typeof(DevFstPOSSuite.Models.Bank);
            // 
            // accountNoTextBox
            // 
            this.accountNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierEditModelBindingSource, "AccountNo", true));
            this.accountNoTextBox.Location = new System.Drawing.Point(881, 84);
            this.accountNoTextBox.Name = "accountNoTextBox";
            this.accountNoTextBox.Size = new System.Drawing.Size(152, 20);
            this.accountNoTextBox.TabIndex = 10;
            // 
            // SaveBtn
            // 
            this.SaveBtn.ActiveControl = null;
            this.SaveBtn.AutoSize = true;
            this.SaveBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.SaveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBtn.Location = new System.Drawing.Point(166, 8);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(52, 62);
            this.SaveBtn.TabIndex = 21;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SaveBtn.TileImage = global::DevFstPOSSuite.Properties.Resources.save_form_record32;
            this.SaveBtn.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SaveBtn.UseSelectable = true;
            this.SaveBtn.UseTileImage = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.suppliersListGrid);
            this.groupBox2.Location = new System.Drawing.Point(10, 273);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1046, 329);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Supplier(s) List";
            // 
            // suppliersListGrid
            // 
            this.suppliersListGrid.AllowUserToAddRows = false;
            this.suppliersListGrid.AllowUserToDeleteRows = false;
            this.suppliersListGrid.AllowUserToResizeRows = false;
            this.suppliersListGrid.AutoGenerateColumns = false;
            this.suppliersListGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.suppliersListGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.suppliersListGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.suppliersListGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.suppliersListGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.suppliersListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suppliersListGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.Delete,
            this.Edit,
            this.businessNameDataGridViewTextBoxColumn,
            this.shortNameDataGridViewTextBoxColumn,
            this.businessTypeDataGridViewTextBoxColumn,
            this.contactPersonDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.landLineDataGridViewTextBoxColumn,
            this.mobileDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.defaultBankIDDataGridViewTextBoxColumn,
            this.accountNoDataGridViewTextBoxColumn,
            this.PaymentDays,
            this.activeDataGridViewCheckBoxColumn});
            this.suppliersListGrid.DataSource = this.supplierModelBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.suppliersListGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.suppliersListGrid.EnableHeadersVisualStyles = false;
            this.suppliersListGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.suppliersListGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.suppliersListGrid.Location = new System.Drawing.Point(7, 19);
            this.suppliersListGrid.Name = "suppliersListGrid";
            this.suppliersListGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.suppliersListGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.suppliersListGrid.RowHeadersVisible = false;
            this.suppliersListGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suppliersListGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.suppliersListGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.suppliersListGrid.Size = new System.Drawing.Size(1026, 302);
            this.suppliersListGrid.TabIndex = 0;
            this.suppliersListGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.suppliersListGrid_CellContentClick);
            // 
            // supplierModelBindingSource
            // 
            this.supplierModelBindingSource.DataSource = typeof(DevFstPOSSuite.Models.SupplierModel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(20, 17);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(64, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Filter Text";
            // 
            // filterApplyBtn
            // 
            this.filterApplyBtn.BackgroundImage = global::DevFstPOSSuite.Properties.Resources.Search_btn_resize;
            this.filterApplyBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.filterApplyBtn.Location = new System.Drawing.Point(508, 12);
            this.filterApplyBtn.Name = "filterApplyBtn";
            this.filterApplyBtn.Size = new System.Drawing.Size(51, 29);
            this.filterApplyBtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.filterApplyBtn.TabIndex = 1;
            this.filterApplyBtn.UseSelectable = true;
            this.filterApplyBtn.UseStyleColors = true;
            this.filterApplyBtn.Click += new System.EventHandler(this.filterApplyBtn_Click);
            // 
            // filterTxtBox
            // 
            this.filterTxtBox.Lines = new string[0];
            this.filterTxtBox.Location = new System.Drawing.Point(90, 15);
            this.filterTxtBox.MaxLength = 32767;
            this.filterTxtBox.Name = "filterTxtBox";
            this.filterTxtBox.PasswordChar = '\0';
            this.filterTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.filterTxtBox.SelectedText = "";
            this.filterTxtBox.Size = new System.Drawing.Size(410, 23);
            this.filterTxtBox.TabIndex = 0;
            this.filterTxtBox.UseSelectable = true;
            this.filterTxtBox.Click += new System.EventHandler(this.filterTxtBox_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.metroLabel1);
            this.groupBox3.Controls.Add(this.filterApplyBtn);
            this.groupBox3.Controls.Add(this.filterTxtBox);
            this.groupBox3.Location = new System.Drawing.Point(10, 218);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(569, 47);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filter Record(s)";
            // 
            // resetRecord
            // 
            this.resetRecord.ActiveControl = null;
            this.resetRecord.AutoSize = true;
            this.resetRecord.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.resetRecord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetRecord.Location = new System.Drawing.Point(111, 8);
            this.resetRecord.Name = "resetRecord";
            this.resetRecord.Size = new System.Drawing.Size(52, 62);
            this.resetRecord.TabIndex = 29;
            this.resetRecord.Text = "Reset";
            this.resetRecord.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.resetRecord.TileImage = ((System.Drawing.Image)(resources.GetObject("resetRecord.TileImage")));
            this.resetRecord.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.resetRecord.UseSelectable = true;
            this.resetRecord.UseTileImage = true;
            this.resetRecord.Click += new System.EventHandler(this.resetRecord_Click);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(13, 110);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(78, 13);
            label2.TabIndex = 22;
            label2.Text = "Payment Days:";
            // 
            // PaymentDaysTextBox
            // 
            this.PaymentDaysTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierEditModelBindingSource, "PaymentDays", true));
            this.PaymentDaysTextBox.Location = new System.Drawing.Point(101, 110);
            this.PaymentDaysTextBox.Name = "PaymentDaysTextBox";
            this.PaymentDaysTextBox.Size = new System.Drawing.Size(102, 20);
            this.PaymentDaysTextBox.TabIndex = 11;
            this.PaymentDaysTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.Image = global::DevFstPOSSuite.Properties.Resources.delete_record;
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Delete.Width = 20;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "";
            this.Edit.Image = global::DevFstPOSSuite.Properties.Resources.application_form_edit;
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Edit.Width = 30;
            // 
            // businessNameDataGridViewTextBoxColumn
            // 
            this.businessNameDataGridViewTextBoxColumn.DataPropertyName = "BusinessName";
            this.businessNameDataGridViewTextBoxColumn.HeaderText = "BusinessName";
            this.businessNameDataGridViewTextBoxColumn.Name = "businessNameDataGridViewTextBoxColumn";
            this.businessNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.businessNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // shortNameDataGridViewTextBoxColumn
            // 
            this.shortNameDataGridViewTextBoxColumn.DataPropertyName = "ShortName";
            this.shortNameDataGridViewTextBoxColumn.HeaderText = "ShortName";
            this.shortNameDataGridViewTextBoxColumn.Name = "shortNameDataGridViewTextBoxColumn";
            this.shortNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // businessTypeDataGridViewTextBoxColumn
            // 
            this.businessTypeDataGridViewTextBoxColumn.DataPropertyName = "BusinessType";
            this.businessTypeDataGridViewTextBoxColumn.HeaderText = "BusinessType";
            this.businessTypeDataGridViewTextBoxColumn.Name = "businessTypeDataGridViewTextBoxColumn";
            this.businessTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactPersonDataGridViewTextBoxColumn
            // 
            this.contactPersonDataGridViewTextBoxColumn.DataPropertyName = "ContactPerson";
            this.contactPersonDataGridViewTextBoxColumn.HeaderText = "ContactPerson";
            this.contactPersonDataGridViewTextBoxColumn.Name = "contactPersonDataGridViewTextBoxColumn";
            this.contactPersonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Width = 300;
            // 
            // landLineDataGridViewTextBoxColumn
            // 
            this.landLineDataGridViewTextBoxColumn.DataPropertyName = "LandLine";
            this.landLineDataGridViewTextBoxColumn.HeaderText = "LandLine";
            this.landLineDataGridViewTextBoxColumn.Name = "landLineDataGridViewTextBoxColumn";
            this.landLineDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobileDataGridViewTextBoxColumn
            // 
            this.mobileDataGridViewTextBoxColumn.DataPropertyName = "Mobile";
            this.mobileDataGridViewTextBoxColumn.HeaderText = "Mobile";
            this.mobileDataGridViewTextBoxColumn.Name = "mobileDataGridViewTextBoxColumn";
            this.mobileDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 150;
            // 
            // defaultBankIDDataGridViewTextBoxColumn
            // 
            this.defaultBankIDDataGridViewTextBoxColumn.DataPropertyName = "DefaultBankID";
            this.defaultBankIDDataGridViewTextBoxColumn.DataSource = this.bankBindingSource;
            this.defaultBankIDDataGridViewTextBoxColumn.DisplayMember = "ShortName";
            this.defaultBankIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.defaultBankIDDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.defaultBankIDDataGridViewTextBoxColumn.HeaderText = "DefaultBank";
            this.defaultBankIDDataGridViewTextBoxColumn.Name = "defaultBankIDDataGridViewTextBoxColumn";
            this.defaultBankIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.defaultBankIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.defaultBankIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.defaultBankIDDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // accountNoDataGridViewTextBoxColumn
            // 
            this.accountNoDataGridViewTextBoxColumn.DataPropertyName = "AccountNo";
            this.accountNoDataGridViewTextBoxColumn.HeaderText = "AccountNo";
            this.accountNoDataGridViewTextBoxColumn.Name = "accountNoDataGridViewTextBoxColumn";
            this.accountNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // PaymentDays
            // 
            this.PaymentDays.DataPropertyName = "PaymentDays";
            this.PaymentDays.HeaderText = "PaymentDays";
            this.PaymentDays.Name = "PaymentDays";
            this.PaymentDays.ReadOnly = true;
            // 
            // activeDataGridViewCheckBoxColumn
            // 
            this.activeDataGridViewCheckBoxColumn.DataPropertyName = "Active";
            this.activeDataGridViewCheckBoxColumn.HeaderText = "Active";
            this.activeDataGridViewCheckBoxColumn.Name = "activeDataGridViewCheckBoxColumn";
            this.activeDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 600);
            this.Controls.Add(this.resetRecord);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(shortNameLabel);
            this.Controls.Add(this.groupBox1);
            this.Name = "Supplier";
            this.Resizable = false;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Supplier";
            this.Load += new System.EventHandler(this.Supplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.supplierEditModelBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bankBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.suppliersListGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierModelBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource supplierEditModelBindingSource;
        private System.Windows.Forms.CheckBox activeCheckBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox businessNameTextBox;
        private System.Windows.Forms.TextBox businessTypeTextBox;
        private System.Windows.Forms.TextBox contactPersonTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox landLineTextBox;
        private System.Windows.Forms.TextBox mobileTextBox;
        private System.Windows.Forms.TextBox shortNameTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTile SaveBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comBox_DefaultBankID;
        private System.Windows.Forms.TextBox accountNoTextBox;
        private System.Windows.Forms.BindingSource bankBindingSource;
        private MetroFramework.Controls.MetroGrid suppliersListGrid;
        private System.Windows.Forms.BindingSource supplierModelBindingSource;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton filterApplyBtn;
        private MetroFramework.Controls.MetroTextBox filterTxtBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroTile resetRecord;
        private System.Windows.Forms.TextBox PaymentDaysTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn businessNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shortNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn businessTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactPersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn landLineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn defaultBankIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentDays;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn;
    }
}