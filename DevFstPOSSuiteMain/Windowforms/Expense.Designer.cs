namespace DevFstPOSSuite
{
    partial class Expense
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
            System.Windows.Forms.Label adjustedDateLabel;
            System.Windows.Forms.Label expenseAmountLabel;
            System.Windows.Forms.Label expenseDateLabel;
            System.Windows.Forms.Label expenseDescLabel;
            System.Windows.Forms.Label expenseTypeLabel;
            System.Windows.Forms.Label remarksLabel;
            System.Windows.Forms.Label statusLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Expense));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.resetRecord = new MetroFramework.Controls.MetroTile();
            this.SaveBtn = new MetroFramework.Controls.MetroTile();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.filterApplyBtn = new MetroFramework.Controls.MetroButton();
            this.adjustedDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.expenseEditModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.expenseDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.expenseDescTextBox = new System.Windows.Forms.TextBox();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.remarksTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.expenseAmountTextBox = new System.Windows.Forms.TextBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxExpenseType = new System.Windows.Forms.ComboBox();
            this.expenseModelDataGridView = new MetroFramework.Controls.MetroGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expenseModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            adjustedDateLabel = new System.Windows.Forms.Label();
            expenseAmountLabel = new System.Windows.Forms.Label();
            expenseDateLabel = new System.Windows.Forms.Label();
            expenseDescLabel = new System.Windows.Forms.Label();
            expenseTypeLabel = new System.Windows.Forms.Label();
            remarksLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expenseEditModelBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expenseModelDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // adjustedDateLabel
            // 
            adjustedDateLabel.AutoSize = true;
            adjustedDateLabel.Location = new System.Drawing.Point(536, 122);
            adjustedDateLabel.Name = "adjustedDateLabel";
            adjustedDateLabel.Size = new System.Drawing.Size(77, 13);
            adjustedDateLabel.TabIndex = 32;
            adjustedDateLabel.Text = "Adjusted Date:";
            // 
            // expenseAmountLabel
            // 
            expenseAmountLabel.AutoSize = true;
            expenseAmountLabel.Location = new System.Drawing.Point(17, 122);
            expenseAmountLabel.Name = "expenseAmountLabel";
            expenseAmountLabel.Size = new System.Drawing.Size(94, 13);
            expenseAmountLabel.TabIndex = 34;
            expenseAmountLabel.Text = "*Expense Amount:";
            // 
            // expenseDateLabel
            // 
            expenseDateLabel.AutoSize = true;
            expenseDateLabel.Location = new System.Drawing.Point(17, 97);
            expenseDateLabel.Name = "expenseDateLabel";
            expenseDateLabel.Size = new System.Drawing.Size(81, 13);
            expenseDateLabel.TabIndex = 36;
            expenseDateLabel.Text = "*Expense Date:";
            // 
            // expenseDescLabel
            // 
            expenseDescLabel.AutoSize = true;
            expenseDescLabel.Location = new System.Drawing.Point(534, 96);
            expenseDescLabel.Name = "expenseDescLabel";
            expenseDescLabel.Size = new System.Drawing.Size(78, 13);
            expenseDescLabel.TabIndex = 38;
            expenseDescLabel.Text = "Expense Detail";
            // 
            // expenseTypeLabel
            // 
            expenseTypeLabel.AutoSize = true;
            expenseTypeLabel.Location = new System.Drawing.Point(283, 96);
            expenseTypeLabel.Name = "expenseTypeLabel";
            expenseTypeLabel.Size = new System.Drawing.Size(82, 13);
            expenseTypeLabel.TabIndex = 40;
            expenseTypeLabel.Text = "*Expense Type:";
            // 
            // remarksLabel
            // 
            remarksLabel.AutoSize = true;
            remarksLabel.Location = new System.Drawing.Point(17, 148);
            remarksLabel.Name = "remarksLabel";
            remarksLabel.Size = new System.Drawing.Size(52, 13);
            remarksLabel.TabIndex = 44;
            remarksLabel.Text = "Remarks:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(288, 122);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(44, 13);
            statusLabel.TabIndex = 46;
            statusLabel.Text = "*Status:";
            // 
            // resetRecord
            // 
            this.resetRecord.ActiveControl = null;
            this.resetRecord.AutoSize = true;
            this.resetRecord.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.resetRecord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetRecord.Location = new System.Drawing.Point(115, 11);
            this.resetRecord.Name = "resetRecord";
            this.resetRecord.Size = new System.Drawing.Size(52, 62);
            this.resetRecord.TabIndex = 9;
            this.resetRecord.Text = "Reset";
            this.resetRecord.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.resetRecord.TileImage = ((System.Drawing.Image)(resources.GetObject("resetRecord.TileImage")));
            this.resetRecord.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.resetRecord.UseSelectable = true;
            this.resetRecord.UseTileImage = true;
            this.resetRecord.Click += new System.EventHandler(this.resetRecord_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.ActiveControl = null;
            this.SaveBtn.AutoSize = true;
            this.SaveBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.SaveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBtn.Location = new System.Drawing.Point(169, 11);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(52, 62);
            this.SaveBtn.TabIndex = 8;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SaveBtn.TileImage = global::DevFstPOSSuite.Properties.Resources.save_form_record32;
            this.SaveBtn.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SaveBtn.UseSelectable = true;
            this.SaveBtn.UseTileImage = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dateTimePickerTo);
            this.groupBox3.Controls.Add(this.metroLabel2);
            this.groupBox3.Controls.Add(this.dateTimePickerFrom);
            this.groupBox3.Controls.Add(this.metroLabel1);
            this.groupBox3.Controls.Add(this.filterApplyBtn);
            this.groupBox3.Location = new System.Drawing.Point(17, 190);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(389, 47);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filter Record(s)";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTo.Location = new System.Drawing.Point(210, 17);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(105, 20);
            this.dateTimePickerTo.TabIndex = 12;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(182, 16);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(22, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "To";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(68, 17);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(97, 20);
            this.dateTimePickerFrom.TabIndex = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(20, 17);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(41, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "From";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // filterApplyBtn
            // 
            this.filterApplyBtn.BackgroundImage = global::DevFstPOSSuite.Properties.Resources.Search_btn_resize;
            this.filterApplyBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.filterApplyBtn.Location = new System.Drawing.Point(329, 13);
            this.filterApplyBtn.Name = "filterApplyBtn";
            this.filterApplyBtn.Size = new System.Drawing.Size(50, 26);
            this.filterApplyBtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.filterApplyBtn.TabIndex = 13;
            this.filterApplyBtn.UseSelectable = true;
            this.filterApplyBtn.UseStyleColors = true;
            this.filterApplyBtn.Click += new System.EventHandler(this.filterApplyBtn_Click);
            // 
            // adjustedDateDateTimePicker
            // 
            this.adjustedDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.expenseEditModelBindingSource, "AdjustedDate", true));
            this.adjustedDateDateTimePicker.Enabled = false;
            this.adjustedDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.adjustedDateDateTimePicker.Location = new System.Drawing.Point(630, 119);
            this.adjustedDateDateTimePicker.Name = "adjustedDateDateTimePicker";
            this.adjustedDateDateTimePicker.Size = new System.Drawing.Size(198, 20);
            this.adjustedDateDateTimePicker.TabIndex = 6;
            this.adjustedDateDateTimePicker.Value = new System.DateTime(2018, 11, 6, 0, 0, 0, 0);
            this.adjustedDateDateTimePicker.ValueChanged += new System.EventHandler(this.adjustedDateDateTimePicker_ValueChanged);
            // 
            // expenseEditModelBindingSource
            // 
            this.expenseEditModelBindingSource.DataSource = typeof(DevFstPOSSuite.Models.ExpenseEditModel);
            // 
            // expenseDateDateTimePicker
            // 
            this.expenseDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.expenseEditModelBindingSource, "ExpenseDate", true));
            this.expenseDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.expenseDateDateTimePicker.Location = new System.Drawing.Point(113, 93);
            this.expenseDateDateTimePicker.Name = "expenseDateDateTimePicker";
            this.expenseDateDateTimePicker.Size = new System.Drawing.Size(162, 20);
            this.expenseDateDateTimePicker.TabIndex = 1;
            // 
            // expenseDescTextBox
            // 
            this.expenseDescTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expenseEditModelBindingSource, "ExpenseDesc", true));
            this.expenseDescTextBox.Location = new System.Drawing.Point(630, 93);
            this.expenseDescTextBox.Name = "expenseDescTextBox";
            this.expenseDescTextBox.Size = new System.Drawing.Size(434, 20);
            this.expenseDescTextBox.TabIndex = 3;
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expenseEditModelBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(307, 35);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(99, 20);
            this.iDTextBox.TabIndex = 43;
            this.iDTextBox.Visible = false;
            // 
            // remarksTextBox
            // 
            this.remarksTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expenseEditModelBindingSource, "Remarks", true));
            this.remarksTextBox.Location = new System.Drawing.Point(113, 146);
            this.remarksTextBox.Name = "remarksTextBox";
            this.remarksTextBox.Size = new System.Drawing.Size(951, 20);
            this.remarksTextBox.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.expenseAmountTextBox);
            this.groupBox1.Controls.Add(this.comboBoxStatus);
            this.groupBox1.Controls.Add(this.comboBoxExpenseType);
            this.groupBox1.Location = new System.Drawing.Point(15, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1059, 104);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/Edit Expense";
            // 
            // expenseAmountTextBox
            // 
            this.expenseAmountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expenseEditModelBindingSource, "ExpenseAmount", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.expenseAmountTextBox.Location = new System.Drawing.Point(98, 45);
            this.expenseAmountTextBox.MaxLength = 15;
            this.expenseAmountTextBox.Name = "expenseAmountTextBox";
            this.expenseAmountTextBox.Size = new System.Drawing.Size(162, 20);
            this.expenseAmountTextBox.TabIndex = 4;
            this.expenseAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.expenseAmountTextBox.TextChanged += new System.EventHandler(this.expenseAmountTextBox_TextChanged);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Pending",
            "Adjusted"});
            this.comboBoxStatus.Location = new System.Drawing.Point(352, 44);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(148, 21);
            this.comboBoxStatus.TabIndex = 5;
            this.comboBoxStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxStatus_SelectedIndexChanged);
            // 
            // comboBoxExpenseType
            // 
            this.comboBoxExpenseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExpenseType.FormattingEnabled = true;
            this.comboBoxExpenseType.Items.AddRange(new object[] {
            "Rent",
            "Salary",
            "UtilityBill",
            "Fuel",
            "Transport",
            "Entertainment",
            "Others"});
            this.comboBoxExpenseType.Location = new System.Drawing.Point(352, 18);
            this.comboBoxExpenseType.Name = "comboBoxExpenseType";
            this.comboBoxExpenseType.Size = new System.Drawing.Size(148, 21);
            this.comboBoxExpenseType.TabIndex = 2;
            // 
            // expenseModelDataGridView
            // 
            this.expenseModelDataGridView.AllowUserToAddRows = false;
            this.expenseModelDataGridView.AllowUserToDeleteRows = false;
            this.expenseModelDataGridView.AllowUserToOrderColumns = true;
            this.expenseModelDataGridView.AllowUserToResizeRows = false;
            this.expenseModelDataGridView.AutoGenerateColumns = false;
            this.expenseModelDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.expenseModelDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.expenseModelDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.expenseModelDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.expenseModelDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.expenseModelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.expenseModelDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Delete,
            this.Edit,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.expenseModelDataGridView.DataSource = this.expenseModelBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.expenseModelDataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.expenseModelDataGridView.EnableHeadersVisualStyles = false;
            this.expenseModelDataGridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.expenseModelDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.expenseModelDataGridView.Location = new System.Drawing.Point(23, 263);
            this.expenseModelDataGridView.Name = "expenseModelDataGridView";
            this.expenseModelDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.expenseModelDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.expenseModelDataGridView.RowHeadersVisible = false;
            this.expenseModelDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.expenseModelDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.expenseModelDataGridView.Size = new System.Drawing.Size(1041, 338);
            this.expenseModelDataGridView.TabIndex = 48;
            this.expenseModelDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.expenseModelDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.Image = global::DevFstPOSSuite.Properties.Resources.delete_record;
            this.Delete.Name = "Delete";
            this.Delete.Width = 20;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "";
            this.Edit.Image = global::DevFstPOSSuite.Properties.Resources.application_form_edit;
            this.Edit.Name = "Edit";
            this.Edit.Width = 25;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ExpenseDate";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn2.HeaderText = "ExpenseDate";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ExpenseType";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn3.HeaderText = "ExpenseType";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ExpenseDesc";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn4.HeaderText = "Expense Detail";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 250;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ExpenseAmount";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn5.HeaderText = "Expense Amount";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Remarks";
            this.dataGridViewTextBoxColumn6.HeaderText = "Remarks";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 200;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Status";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn7.HeaderText = "Status";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "AdjustedDate";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle7.Format = "d";
            dataGridViewCellStyle7.NullValue = null;
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn8.HeaderText = "AdjustedDate";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // expenseModelBindingSource
            // 
            this.expenseModelBindingSource.DataSource = typeof(DevFstPOSSuite.Models.ExpenseModel);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(17, 244);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1057, 373);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Expense(s) List";
            // 
            // Expense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 624);
            this.Controls.Add(this.expenseModelDataGridView);
            this.Controls.Add(adjustedDateLabel);
            this.Controls.Add(this.adjustedDateDateTimePicker);
            this.Controls.Add(expenseAmountLabel);
            this.Controls.Add(expenseDateLabel);
            this.Controls.Add(this.expenseDateDateTimePicker);
            this.Controls.Add(expenseDescLabel);
            this.Controls.Add(this.expenseDescTextBox);
            this.Controls.Add(expenseTypeLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(remarksLabel);
            this.Controls.Add(this.remarksTextBox);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.resetRecord);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Expense";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Expense";
            this.Load += new System.EventHandler(this.Expense_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expenseEditModelBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expenseModelDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile resetRecord;
        private MetroFramework.Controls.MetroTile SaveBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton filterApplyBtn;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.BindingSource expenseEditModelBindingSource;
        private System.Windows.Forms.DateTimePicker adjustedDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker expenseDateDateTimePicker;
        private System.Windows.Forms.TextBox expenseDescTextBox;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox remarksTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource expenseModelBindingSource;
       // private System.Windows.Forms.DataGridView expenseModelDataGridView;
        private MetroFramework.Controls.MetroGrid expenseModelDataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.ComboBox comboBoxExpenseType;
        private System.Windows.Forms.TextBox expenseAmountTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;

     




    }
}