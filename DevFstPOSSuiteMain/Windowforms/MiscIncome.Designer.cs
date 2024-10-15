namespace DevFstPOSSuite.Windowforms
{
    partial class MiscIncome
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
            System.Windows.Forms.Label incomeTypeLabel;
            System.Windows.Forms.Label postingAmountLabel;
            System.Windows.Forms.Label postingDateLabel;
            System.Windows.Forms.Label referenceLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiscIncome));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_AdjustedInPOS = new System.Windows.Forms.CheckBox();
            this.pOIncomeEditModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox_IncomeType = new System.Windows.Forms.ComboBox();
            this.pOIncomeTypeModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postingDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.postingAmountTextBox = new System.Windows.Forms.TextBox();
            this.referenceTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pOIncomeModelDataGridView = new MetroFramework.Controls.MetroGrid();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdjustedInPOS = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOIncomeModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resetRecord = new MetroFramework.Controls.MetroTile();
            this.SaveBtn = new MetroFramework.Controls.MetroTile();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.filterApplyBtn = new MetroFramework.Controls.MetroButton();
            incomeTypeLabel = new System.Windows.Forms.Label();
            postingAmountLabel = new System.Windows.Forms.Label();
            postingDateLabel = new System.Windows.Forms.Label();
            referenceLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pOIncomeEditModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOIncomeTypeModelBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pOIncomeModelDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOIncomeModelBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // incomeTypeLabel
            // 
            incomeTypeLabel.AutoSize = true;
            incomeTypeLabel.Location = new System.Drawing.Point(238, 23);
            incomeTypeLabel.Name = "incomeTypeLabel";
            incomeTypeLabel.Size = new System.Drawing.Size(38, 13);
            incomeTypeLabel.TabIndex = 4;
            incomeTypeLabel.Text = "*Type:";
            // 
            // postingAmountLabel
            // 
            postingAmountLabel.AutoSize = true;
            postingAmountLabel.Location = new System.Drawing.Point(440, 23);
            postingAmountLabel.Name = "postingAmountLabel";
            postingAmountLabel.Size = new System.Drawing.Size(88, 13);
            postingAmountLabel.TabIndex = 10;
            postingAmountLabel.Text = "*Posting Amount:";
            // 
            // postingDateLabel
            // 
            postingDateLabel.AutoSize = true;
            postingDateLabel.Location = new System.Drawing.Point(6, 23);
            postingDateLabel.Name = "postingDateLabel";
            postingDateLabel.Size = new System.Drawing.Size(75, 13);
            postingDateLabel.TabIndex = 12;
            postingDateLabel.Text = "*Posting Date:";
            // 
            // referenceLabel
            // 
            referenceLabel.AutoSize = true;
            referenceLabel.Location = new System.Drawing.Point(6, 47);
            referenceLabel.Name = "referenceLabel";
            referenceLabel.Size = new System.Drawing.Size(60, 13);
            referenceLabel.TabIndex = 14;
            referenceLabel.Text = "Reference:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(653, 20);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(88, 13);
            label1.TabIndex = 16;
            label1.Text = "Adjusted In POS:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.checkBox_AdjustedInPOS);
            this.groupBox1.Controls.Add(this.comboBox_IncomeType);
            this.groupBox1.Controls.Add(this.postingDateDateTimePicker);
            this.groupBox1.Controls.Add(postingDateLabel);
            this.groupBox1.Controls.Add(incomeTypeLabel);
            this.groupBox1.Controls.Add(postingAmountLabel);
            this.groupBox1.Controls.Add(this.postingAmountTextBox);
            this.groupBox1.Controls.Add(this.referenceTextBox);
            this.groupBox1.Controls.Add(referenceLabel);
            this.groupBox1.Location = new System.Drawing.Point(14, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/Edit Income/Loss";
            // 
            // checkBox_AdjustedInPOS
            // 
            this.checkBox_AdjustedInPOS.AutoSize = true;
            this.checkBox_AdjustedInPOS.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.pOIncomeEditModelBindingSource, "AdjustedInPOS", true));
            this.checkBox_AdjustedInPOS.Location = new System.Drawing.Point(747, 20);
            this.checkBox_AdjustedInPOS.Name = "checkBox_AdjustedInPOS";
            this.checkBox_AdjustedInPOS.Size = new System.Drawing.Size(15, 14);
            this.checkBox_AdjustedInPOS.TabIndex = 15;
            this.checkBox_AdjustedInPOS.UseVisualStyleBackColor = true;
            // 
            // pOIncomeEditModelBindingSource
            // 
            this.pOIncomeEditModelBindingSource.DataSource = typeof(DevFstPOSSuite.Models.POIncomeEditModel);
            // 
            // comboBox_IncomeType
            // 
            this.comboBox_IncomeType.DataSource = this.pOIncomeTypeModelBindingSource;
            this.comboBox_IncomeType.DisplayMember = "Name";
            this.comboBox_IncomeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_IncomeType.FormattingEnabled = true;
            this.comboBox_IncomeType.Location = new System.Drawing.Point(274, 17);
            this.comboBox_IncomeType.Name = "comboBox_IncomeType";
            this.comboBox_IncomeType.Size = new System.Drawing.Size(155, 21);
            this.comboBox_IncomeType.TabIndex = 1;
            this.comboBox_IncomeType.ValueMember = "ID";
            // 
            // pOIncomeTypeModelBindingSource
            // 
            this.pOIncomeTypeModelBindingSource.DataSource = typeof(DevFstPOSSuite.Models.POIncomeTypeModel);
            // 
            // postingDateDateTimePicker
            // 
            this.postingDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pOIncomeEditModelBindingSource, "PostingDate", true));
            this.postingDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.postingDateDateTimePicker.Location = new System.Drawing.Point(83, 17);
            this.postingDateDateTimePicker.Name = "postingDateDateTimePicker";
            this.postingDateDateTimePicker.Size = new System.Drawing.Size(133, 20);
            this.postingDateDateTimePicker.TabIndex = 0;
            // 
            // postingAmountTextBox
            // 
            this.postingAmountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pOIncomeEditModelBindingSource, "PostingAmount", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.postingAmountTextBox.Location = new System.Drawing.Point(534, 17);
            this.postingAmountTextBox.Name = "postingAmountTextBox";
            this.postingAmountTextBox.Size = new System.Drawing.Size(108, 20);
            this.postingAmountTextBox.TabIndex = 2;
            this.postingAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // referenceTextBox
            // 
            this.referenceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pOIncomeEditModelBindingSource, "Reference", true));
            this.referenceTextBox.Location = new System.Drawing.Point(83, 44);
            this.referenceTextBox.Name = "referenceTextBox";
            this.referenceTextBox.Size = new System.Drawing.Size(679, 20);
            this.referenceTextBox.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pOIncomeModelDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(14, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(762, 361);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Income List";
            // 
            // pOIncomeModelDataGridView
            // 
            this.pOIncomeModelDataGridView.AllowUserToAddRows = false;
            this.pOIncomeModelDataGridView.AllowUserToDeleteRows = false;
            this.pOIncomeModelDataGridView.AllowUserToResizeRows = false;
            this.pOIncomeModelDataGridView.AutoGenerateColumns = false;
            this.pOIncomeModelDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pOIncomeModelDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pOIncomeModelDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.pOIncomeModelDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pOIncomeModelDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.pOIncomeModelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pOIncomeModelDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete,
            this.Edit,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.AdjustedInPOS,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.pOIncomeModelDataGridView.DataSource = this.pOIncomeModelBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.pOIncomeModelDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.pOIncomeModelDataGridView.EnableHeadersVisualStyles = false;
            this.pOIncomeModelDataGridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.pOIncomeModelDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pOIncomeModelDataGridView.Location = new System.Drawing.Point(15, 19);
            this.pOIncomeModelDataGridView.Name = "pOIncomeModelDataGridView";
            this.pOIncomeModelDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pOIncomeModelDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.pOIncomeModelDataGridView.RowHeadersVisible = false;
            this.pOIncomeModelDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.pOIncomeModelDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pOIncomeModelDataGridView.Size = new System.Drawing.Size(736, 327);
            this.pOIncomeModelDataGridView.TabIndex = 0;
            this.pOIncomeModelDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pOIncomeModelDataGridView_CellContentClick);
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.Image = global::DevFstPOSSuite.Properties.Resources.delete_record;
            this.Delete.Name = "Delete";
            this.Delete.Width = 25;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "";
            this.Edit.Image = global::DevFstPOSSuite.Properties.Resources.application_form_edit;
            this.Edit.Name = "Edit";
            this.Edit.Width = 30;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PostingDate";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn2.HeaderText = "PostingDate";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IncomeType";
            this.dataGridViewTextBoxColumn3.DataSource = this.pOIncomeTypeModelBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "Name";
            this.dataGridViewTextBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewTextBoxColumn3.HeaderText = "Type";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "ID";
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PostingAmount";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn4.HeaderText = "PostingAmount";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // AdjustedInPOS
            // 
            this.AdjustedInPOS.DataPropertyName = "AdjustedInPOS";
            this.AdjustedInPOS.HeaderText = "AdjustedInPOS";
            this.AdjustedInPOS.Name = "AdjustedInPOS";
            this.AdjustedInPOS.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Reference";
            this.dataGridViewTextBoxColumn5.HeaderText = "Reference";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 250;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CreatedBy";
            this.dataGridViewTextBoxColumn6.HeaderText = "CreatedBy";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "LastUpdatedDate";
            this.dataGridViewTextBoxColumn7.HeaderText = "LastUpdatedDate";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "LastUpdatedBy";
            this.dataGridViewTextBoxColumn8.HeaderText = "LastUpdatedBy";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // pOIncomeModelBindingSource
            // 
            this.pOIncomeModelBindingSource.DataSource = typeof(DevFstPOSSuite.Models.POIncomeModel);
            // 
            // resetRecord
            // 
            this.resetRecord.ActiveControl = null;
            this.resetRecord.AutoSize = true;
            this.resetRecord.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.resetRecord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetRecord.Location = new System.Drawing.Point(213, 16);
            this.resetRecord.Name = "resetRecord";
            this.resetRecord.Size = new System.Drawing.Size(52, 62);
            this.resetRecord.TabIndex = 11;
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
            this.SaveBtn.Location = new System.Drawing.Point(268, 16);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(52, 62);
            this.SaveBtn.TabIndex = 4;
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
            this.groupBox3.Location = new System.Drawing.Point(14, 172);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(389, 47);
            this.groupBox3.TabIndex = 33;
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
            // MiscIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 603);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.resetRecord);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MiscIncome";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Misc. Income/Loss";
            this.Load += new System.EventHandler(this.MiscIncome_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pOIncomeEditModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOIncomeTypeModelBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pOIncomeModelDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOIncomeModelBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTile resetRecord;
        private MetroFramework.Controls.MetroTile SaveBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton filterApplyBtn;
        private System.Windows.Forms.DateTimePicker postingDateDateTimePicker;
        private System.Windows.Forms.BindingSource pOIncomeEditModelBindingSource;
        private System.Windows.Forms.TextBox postingAmountTextBox;
        private System.Windows.Forms.TextBox referenceTextBox;
       // private System.Windows.Forms.DataGridView pOIncomeModelDataGridView;
        private MetroFramework.Controls.MetroGrid pOIncomeModelDataGridView;
        private System.Windows.Forms.BindingSource pOIncomeTypeModelBindingSource;
        private System.Windows.Forms.BindingSource pOIncomeModelBindingSource;
        private System.Windows.Forms.ComboBox comboBox_IncomeType;
        private System.Windows.Forms.CheckBox checkBox_AdjustedInPOS;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AdjustedInPOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}