namespace DevFstPOSSuite
{
    partial class Productcs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.srhTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.productSearchModelDataGridView = new MetroFramework.Controls.MetroGrid();
            this.closebtn = new MetroFramework.Controls.MetroButton();
            this.productSearchModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShortName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockInHand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productSearchModelDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSearchModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.metroLabel1);
            this.groupBox3.Controls.Add(this.srhTxtBox);
            this.groupBox3.Location = new System.Drawing.Point(14, 63);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(721, 47);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filter Record(s)";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(8, 17);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(74, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Search Text";
            // 
            // srhTxtBox
            // 
            this.srhTxtBox.Lines = new string[0];
            this.srhTxtBox.Location = new System.Drawing.Point(100, 15);
            this.srhTxtBox.MaxLength = 32767;
            this.srhTxtBox.Name = "srhTxtBox";
            this.srhTxtBox.PasswordChar = '\0';
            this.srhTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.srhTxtBox.SelectedText = "";
            this.srhTxtBox.Size = new System.Drawing.Size(615, 23);
            this.srhTxtBox.TabIndex = 0;
            this.srhTxtBox.UseSelectable = true;
            this.srhTxtBox.TextChanged += new System.EventHandler(this.srhTxtBox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.productSearchModelDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(723, 253);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product(s) List";
            // 
            // productSearchModelDataGridView
            // 
            this.productSearchModelDataGridView.AllowUserToAddRows = false;
            this.productSearchModelDataGridView.AllowUserToDeleteRows = false;
            this.productSearchModelDataGridView.AllowUserToOrderColumns = true;
            this.productSearchModelDataGridView.AllowUserToResizeRows = false;
            this.productSearchModelDataGridView.AutoGenerateColumns = false;
            this.productSearchModelDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.productSearchModelDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.productSearchModelDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.productSearchModelDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productSearchModelDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.productSearchModelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productSearchModelDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.ShortName,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.StockInHand});
            this.productSearchModelDataGridView.DataSource = this.productSearchModelBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productSearchModelDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.productSearchModelDataGridView.EnableHeadersVisualStyles = false;
            this.productSearchModelDataGridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.productSearchModelDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.productSearchModelDataGridView.Location = new System.Drawing.Point(11, 20);
            this.productSearchModelDataGridView.Name = "productSearchModelDataGridView";
            this.productSearchModelDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productSearchModelDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.productSearchModelDataGridView.RowHeadersVisible = false;
            this.productSearchModelDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.productSearchModelDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productSearchModelDataGridView.Size = new System.Drawing.Size(706, 220);
            this.productSearchModelDataGridView.TabIndex = 1;
            this.productSearchModelDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productSearchModelDataGridView_CellDoubleClick);
            this.productSearchModelDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.productSearchModelDataGridView_KeyDown);
            this.productSearchModelDataGridView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.productSearchModelDataGridView_KeyPress);
            this.productSearchModelDataGridView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.productSearchModelDataGridView_KeyUp);
            // 
            // closebtn
            // 
            this.closebtn.BackgroundImage = global::DevFstPOSSuite.Properties.Resources.delete_record;
            this.closebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.closebtn.Location = new System.Drawing.Point(705, 11);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(30, 23);
            this.closebtn.TabIndex = 29;
            this.closebtn.UseSelectable = true;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // productSearchModelBindingSource
            // 
            this.productSearchModelBindingSource.DataSource = typeof(DevFstPOSSuite.Models.ProductSearchModel);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ProductID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ProductCode";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ShortName
            // 
            this.ShortName.DataPropertyName = "ShortName";
            this.ShortName.HeaderText = "ShortName";
            this.ShortName.Name = "ShortName";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProductName";
            this.dataGridViewTextBoxColumn2.HeaderText = "ProductName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 280;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SupplierName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Supplier";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 130;
            // 
            // StockInHand
            // 
            this.StockInHand.DataPropertyName = "StockInHand";
            this.StockInHand.HeaderText = "StockInHand";
            this.StockInHand.Name = "StockInHand";
            this.StockInHand.ReadOnly = true;
            this.StockInHand.Width = 80;
            // 
            // Productcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 380);
            this.ControlBox = false;
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Productcs";
            this.Resizable = false;
            this.ShowIcon = false;
            this.Text = "Product Search";
            this.Load += new System.EventHandler(this.Productcs_Load);
            this.Shown += new System.EventHandler(this.Productcs_Shown);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productSearchModelDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSearchModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        // private System.Windows.Forms.DataGridView productMasterDataGridView;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox srhTxtBox;
        private System.Windows.Forms.GroupBox groupBox1;
      //  private System.Windows.Forms.DataGridView productSearchModelDataGridView;
        private MetroFramework.Controls.MetroGrid productSearchModelDataGridView;
        private System.Windows.Forms.BindingSource productSearchModelBindingSource;
        private MetroFramework.Controls.MetroButton closebtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShortName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockInHand;
    }
}