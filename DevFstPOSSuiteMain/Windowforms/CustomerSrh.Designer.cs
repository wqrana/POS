namespace DevFstPOSSuite.Windowforms
{
    partial class CustomerSrh
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.srhTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.customerSearchModelDataGridView = new MetroFramework.Controls.MetroGrid();
            this.selectCust = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.btnContactSearch = new MetroFramework.Controls.MetroButton();
            this.selectAllCheckBox = new System.Windows.Forms.CheckBox();
            this.closebtn = new MetroFramework.Controls.MetroButton();
            this.contactNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shoppingWorthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerSearchModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerSearchModelDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerSearchModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // srhTxtBox
            // 
            this.srhTxtBox.Lines = new string[0];
            this.srhTxtBox.Location = new System.Drawing.Point(23, 77);
            this.srhTxtBox.MaxLength = 32767;
            this.srhTxtBox.Name = "srhTxtBox";
            this.srhTxtBox.PasswordChar = '\0';
            this.srhTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.srhTxtBox.SelectedText = "";
            this.srhTxtBox.Size = new System.Drawing.Size(424, 23);
            this.srhTxtBox.TabIndex = 0;
            this.srhTxtBox.UseSelectable = true;
            this.srhTxtBox.TextChanged += new System.EventHandler(this.srhTxtBox_TextChanged);
            this.srhTxtBox.Click += new System.EventHandler(this.srhTxtBox_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.customerSearchModelDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 261);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer(s) List";
            // 
            // customerSearchModelDataGridView
            // 
            this.customerSearchModelDataGridView.AllowUserToAddRows = false;
            this.customerSearchModelDataGridView.AllowUserToDeleteRows = false;
            this.customerSearchModelDataGridView.AllowUserToOrderColumns = true;
            this.customerSearchModelDataGridView.AllowUserToResizeRows = false;
            this.customerSearchModelDataGridView.AutoGenerateColumns = false;
            this.customerSearchModelDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.customerSearchModelDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.customerSearchModelDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.customerSearchModelDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerSearchModelDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.customerSearchModelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerSearchModelDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selectCust,
            this.contactNoDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.shoppingWorthDataGridViewTextBoxColumn});
            this.customerSearchModelDataGridView.DataSource = this.customerSearchModelBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.customerSearchModelDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.customerSearchModelDataGridView.EnableHeadersVisualStyles = false;
            this.customerSearchModelDataGridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.customerSearchModelDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.customerSearchModelDataGridView.Location = new System.Drawing.Point(11, 20);
            this.customerSearchModelDataGridView.Name = "customerSearchModelDataGridView";
            this.customerSearchModelDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerSearchModelDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.customerSearchModelDataGridView.RowHeadersVisible = false;
            this.customerSearchModelDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.customerSearchModelDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerSearchModelDataGridView.Size = new System.Drawing.Size(424, 234);
            this.customerSearchModelDataGridView.TabIndex = 1;
            // 
            // selectCust
            // 
            this.selectCust.HeaderText = "Select";
            this.selectCust.Name = "selectCust";
            this.selectCust.Width = 45;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(14, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(448, 51);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter Record(s)";
            // 
            // metroButton1
            // 
            this.metroButton1.BackgroundImage = global::DevFstPOSSuite.Properties.Resources.cancel;
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton1.DisplayFocus = true;
            this.metroButton1.Location = new System.Drawing.Point(233, 383);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(67, 36);
            this.metroButton1.TabIndex = 32;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btnContactSearch
            // 
            this.btnContactSearch.BackgroundImage = global::DevFstPOSSuite.Properties.Resources.ok;
            this.btnContactSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnContactSearch.DisplayFocus = true;
            this.btnContactSearch.Location = new System.Drawing.Point(165, 383);
            this.btnContactSearch.Name = "btnContactSearch";
            this.btnContactSearch.Size = new System.Drawing.Size(63, 36);
            this.btnContactSearch.TabIndex = 31;
            this.btnContactSearch.UseSelectable = true;
            this.btnContactSearch.Click += new System.EventHandler(this.btnContactSearch_Click);
            // 
            // selectAllCheckBox
            // 
            this.selectAllCheckBox.AutoSize = true;
            this.selectAllCheckBox.Location = new System.Drawing.Point(15, 383);
            this.selectAllCheckBox.Name = "selectAllCheckBox";
            this.selectAllCheckBox.Size = new System.Drawing.Size(70, 17);
            this.selectAllCheckBox.TabIndex = 33;
            this.selectAllCheckBox.Text = "Select All";
            this.selectAllCheckBox.UseVisualStyleBackColor = true;
            this.selectAllCheckBox.CheckedChanged += new System.EventHandler(this.selectAllCheckBox_CheckedChanged);
            // 
            // closebtn
            // 
            this.closebtn.BackgroundImage = global::DevFstPOSSuite.Properties.Resources.delete_record;
            this.closebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.closebtn.Location = new System.Drawing.Point(436, 10);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(30, 23);
            this.closebtn.TabIndex = 34;
            this.closebtn.UseSelectable = true;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // contactNoDataGridViewTextBoxColumn
            // 
            this.contactNoDataGridViewTextBoxColumn.DataPropertyName = "ContactNo";
            this.contactNoDataGridViewTextBoxColumn.HeaderText = "ContactNo";
            this.contactNoDataGridViewTextBoxColumn.Name = "contactNoDataGridViewTextBoxColumn";
            this.contactNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.contactNoDataGridViewTextBoxColumn.Width = 110;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerNameDataGridViewTextBoxColumn.Width = 170;
            // 
            // shoppingWorthDataGridViewTextBoxColumn
            // 
            this.shoppingWorthDataGridViewTextBoxColumn.DataPropertyName = "ShoppingWorth";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.shoppingWorthDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.shoppingWorthDataGridViewTextBoxColumn.HeaderText = "ShoppingWorth";
            this.shoppingWorthDataGridViewTextBoxColumn.Name = "shoppingWorthDataGridViewTextBoxColumn";
            this.shoppingWorthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerSearchModelBindingSource
            // 
            this.customerSearchModelBindingSource.DataSource = typeof(DevFstPOSSuite.Models.CustomerSearchModel);
            // 
            // CustomerSrh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 432);
            this.ControlBox = false;
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.selectAllCheckBox);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.btnContactSearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.srhTxtBox);
            this.Controls.Add(this.groupBox2);
            this.Name = "CustomerSrh";
            this.Text = "Customer Search";
            this.Load += new System.EventHandler(this.CustomerSrh_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customerSearchModelDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerSearchModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox srhTxtBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroGrid customerSearchModelDataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton btnContactSearch;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectCust;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shoppingWorthDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource customerSearchModelBindingSource;
        private System.Windows.Forms.CheckBox selectAllCheckBox;
        private MetroFramework.Controls.MetroButton closebtn;
    }
}