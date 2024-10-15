namespace DevFstPOSSuite
{
    partial class ReportFilter
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
            this.fromdatePicker = new System.Windows.Forms.DateTimePicker();
            this.fromDateLbl = new System.Windows.Forms.Label();
            this.toDatePicker = new System.Windows.Forms.DateTimePicker();
            this.toDateLbl = new System.Windows.Forms.Label();
            this.showBtn = new MetroFramework.Controls.MetroButton();
            this.POInvoiceList = new System.Windows.Forms.ComboBox();
            this.pOInventoryMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selInvlabel = new System.Windows.Forms.Label();
            this.chkAllInv = new System.Windows.Forms.CheckBox();
            this.PeriodType = new System.Windows.Forms.Label();
            this.periodList = new System.Windows.Forms.ComboBox();
            this.supplierList = new System.Windows.Forms.ComboBox();
            this.supplierModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierLbl = new System.Windows.Forms.Label();
            this.checkAllSup = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pOInventoryMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fromdatePicker
            // 
            this.fromdatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromdatePicker.Location = new System.Drawing.Point(101, 66);
            this.fromdatePicker.Name = "fromdatePicker";
            this.fromdatePicker.Size = new System.Drawing.Size(200, 20);
            this.fromdatePicker.TabIndex = 0;
            this.fromdatePicker.Value = new System.DateTime(2018, 11, 1, 0, 0, 0, 0);
            // 
            // fromDateLbl
            // 
            this.fromDateLbl.AutoSize = true;
            this.fromDateLbl.Location = new System.Drawing.Point(12, 72);
            this.fromDateLbl.Name = "fromDateLbl";
            this.fromDateLbl.Size = new System.Drawing.Size(56, 13);
            this.fromDateLbl.TabIndex = 1;
            this.fromDateLbl.Text = "From Date";
            // 
            // toDatePicker
            // 
            this.toDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toDatePicker.Location = new System.Drawing.Point(101, 119);
            this.toDatePicker.Name = "toDatePicker";
            this.toDatePicker.Size = new System.Drawing.Size(200, 20);
            this.toDatePicker.TabIndex = 2;
            this.toDatePicker.Value = new System.DateTime(2018, 11, 1, 0, 0, 0, 0);
            // 
            // toDateLbl
            // 
            this.toDateLbl.AutoSize = true;
            this.toDateLbl.Location = new System.Drawing.Point(12, 125);
            this.toDateLbl.Name = "toDateLbl";
            this.toDateLbl.Size = new System.Drawing.Size(46, 13);
            this.toDateLbl.TabIndex = 3;
            this.toDateLbl.Text = "To Date";
            // 
            // showBtn
            // 
            this.showBtn.DisplayFocus = true;
            this.showBtn.Location = new System.Drawing.Point(140, 159);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(75, 23);
            this.showBtn.TabIndex = 4;
            this.showBtn.Text = "Show";
            this.showBtn.UseSelectable = true;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // POInvoiceList
            // 
            this.POInvoiceList.DataSource = this.pOInventoryMasterBindingSource;
            this.POInvoiceList.DisplayMember = "InvoiceNo";
            this.POInvoiceList.FormattingEnabled = true;
            this.POInvoiceList.Location = new System.Drawing.Point(101, 93);
            this.POInvoiceList.Name = "POInvoiceList";
            this.POInvoiceList.Size = new System.Drawing.Size(151, 21);
            this.POInvoiceList.TabIndex = 5;
            this.POInvoiceList.ValueMember = "ID";
            this.POInvoiceList.Visible = false;
            // 
            // pOInventoryMasterBindingSource
            // 
            this.pOInventoryMasterBindingSource.DataSource = typeof(DevFstPOSSuite.DAL.POInventoryMaster);
            // 
            // selInvlabel
            // 
            this.selInvlabel.AutoSize = true;
            this.selInvlabel.Location = new System.Drawing.Point(12, 97);
            this.selInvlabel.Name = "selInvlabel";
            this.selInvlabel.Size = new System.Drawing.Size(60, 13);
            this.selInvlabel.TabIndex = 6;
            this.selInvlabel.Text = "PO Invoice";
            this.selInvlabel.Visible = false;
            // 
            // chkAllInv
            // 
            this.chkAllInv.AutoSize = true;
            this.chkAllInv.Location = new System.Drawing.Point(259, 96);
            this.chkAllInv.Name = "chkAllInv";
            this.chkAllInv.Size = new System.Drawing.Size(37, 17);
            this.chkAllInv.TabIndex = 7;
            this.chkAllInv.Text = "All";
            this.chkAllInv.UseVisualStyleBackColor = true;
            this.chkAllInv.Visible = false;
            this.chkAllInv.CheckedChanged += new System.EventHandler(this.chkAllInv_CheckedChanged);
            // 
            // PeriodType
            // 
            this.PeriodType.AutoSize = true;
            this.PeriodType.Location = new System.Drawing.Point(12, 100);
            this.PeriodType.Name = "PeriodType";
            this.PeriodType.Size = new System.Drawing.Size(70, 13);
            this.PeriodType.TabIndex = 8;
            this.PeriodType.Text = "Select Period";
            this.PeriodType.Visible = false;
            // 
            // periodList
            // 
            this.periodList.FormattingEnabled = true;
            this.periodList.Items.AddRange(new object[] {
            "This Month",
            "Last 1-Month",
            "Last 3-Months",
            "Last 6-Months",
            "Last 1-Year",
            "This Year"});
            this.periodList.Location = new System.Drawing.Point(101, 93);
            this.periodList.Name = "periodList";
            this.periodList.Size = new System.Drawing.Size(200, 21);
            this.periodList.TabIndex = 9;
            this.periodList.Visible = false;
            // 
            // supplierList
            // 
            this.supplierList.DataSource = this.supplierModelBindingSource;
            this.supplierList.DisplayMember = "ShortName";
            this.supplierList.FormattingEnabled = true;
            this.supplierList.Location = new System.Drawing.Point(101, 66);
            this.supplierList.Name = "supplierList";
            this.supplierList.Size = new System.Drawing.Size(151, 21);
            this.supplierList.TabIndex = 10;
            this.supplierList.ValueMember = "ID";
            this.supplierList.Visible = false;
            this.supplierList.SelectedIndexChanged += new System.EventHandler(this.supplierList_SelectedIndexChanged);
            // 
            // supplierModelBindingSource
            // 
            this.supplierModelBindingSource.DataSource = typeof(DevFstPOSSuite.Models.SupplierModel);
            // 
            // supplierLbl
            // 
            this.supplierLbl.AutoSize = true;
            this.supplierLbl.Location = new System.Drawing.Point(15, 71);
            this.supplierLbl.Name = "supplierLbl";
            this.supplierLbl.Size = new System.Drawing.Size(45, 13);
            this.supplierLbl.TabIndex = 11;
            this.supplierLbl.Text = "Supplier";
            this.supplierLbl.Visible = false;
            // 
            // checkAllSup
            // 
            this.checkAllSup.AutoSize = true;
            this.checkAllSup.Location = new System.Drawing.Point(259, 68);
            this.checkAllSup.Name = "checkAllSup";
            this.checkAllSup.Size = new System.Drawing.Size(37, 17);
            this.checkAllSup.TabIndex = 12;
            this.checkAllSup.Text = "All";
            this.checkAllSup.UseVisualStyleBackColor = true;
            this.checkAllSup.Visible = false;
            this.checkAllSup.CheckedChanged += new System.EventHandler(this.checkAllSup_CheckedChanged);
            // 
            // ReportFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 194);
            this.Controls.Add(this.POInvoiceList);
            this.Controls.Add(this.checkAllSup);
            this.Controls.Add(this.supplierLbl);
            this.Controls.Add(this.chkAllInv);
            this.Controls.Add(this.selInvlabel);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.toDateLbl);
            this.Controls.Add(this.fromDateLbl);
            this.Controls.Add(this.PeriodType);
            this.Controls.Add(this.supplierList);
            this.Controls.Add(this.fromdatePicker);
            this.Controls.Add(this.periodList);
            this.Controls.Add(this.toDatePicker);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReportFilter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Report Filter";
            this.Load += new System.EventHandler(this.ReportFilter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pOInventoryMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker fromdatePicker;
        private System.Windows.Forms.Label fromDateLbl;
        private System.Windows.Forms.DateTimePicker toDatePicker;
        private System.Windows.Forms.Label toDateLbl;
        //private System.Windows.Forms.Button showBtn;
        private MetroFramework.Controls.MetroButton showBtn;
        private System.Windows.Forms.ComboBox POInvoiceList;
        private System.Windows.Forms.BindingSource pOInventoryMasterBindingSource;
        private System.Windows.Forms.Label selInvlabel;
        private System.Windows.Forms.CheckBox chkAllInv;
        private System.Windows.Forms.Label PeriodType;
        private System.Windows.Forms.ComboBox periodList;
        private System.Windows.Forms.ComboBox supplierList;
        private System.Windows.Forms.Label supplierLbl;
        private System.Windows.Forms.CheckBox checkAllSup;
        private System.Windows.Forms.BindingSource supplierModelBindingSource;
    }
}