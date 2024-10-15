namespace DevFstPOSSuite.Windowforms
{
    partial class SMSCampaignfrm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.receipientListDataGridView = new MetroFramework.Controls.MetroGrid();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnContactSearch = new MetroFramework.Controls.MetroButton();
            this.btnAddContact = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSendingBar = new System.Windows.Forms.Label();
            this.sendingProgressBar = new System.Windows.Forms.ProgressBar();
            this.lblMessLen = new System.Windows.Forms.Label();
            this.btnSendSMS = new MetroFramework.Controls.MetroButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CampaignMessageTextBox = new MetroFramework.Controls.MetroTextBox();
            this.CampaignNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.removeContract = new System.Windows.Forms.DataGridViewImageColumn();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.contactNoTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSMSCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblRecCount = new System.Windows.Forms.Label();
            this.contactNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.campaignRecipientModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receipientListDataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.campaignRecipientModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 524);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recipient(s) Section";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblRecCount);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.metroButton2);
            this.groupBox4.Controls.Add(this.receipientListDataGridView);
            this.groupBox4.Location = new System.Drawing.Point(7, 100);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(233, 419);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Recipient(s) List";
            // 
            // receipientListDataGridView
            // 
            this.receipientListDataGridView.AllowUserToAddRows = false;
            this.receipientListDataGridView.AllowUserToOrderColumns = true;
            this.receipientListDataGridView.AllowUserToResizeRows = false;
            this.receipientListDataGridView.AutoGenerateColumns = false;
            this.receipientListDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.receipientListDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.receipientListDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.receipientListDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.receipientListDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.receipientListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.receipientListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.removeContract,
            this.contactNoDataGridViewTextBoxColumn});
            this.receipientListDataGridView.DataSource = this.campaignRecipientModelBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.receipientListDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.receipientListDataGridView.EnableHeadersVisualStyles = false;
            this.receipientListDataGridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.receipientListDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.receipientListDataGridView.Location = new System.Drawing.Point(8, 19);
            this.receipientListDataGridView.Name = "receipientListDataGridView";
            this.receipientListDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.receipientListDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.receipientListDataGridView.RowHeadersVisible = false;
            this.receipientListDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.receipientListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.receipientListDataGridView.Size = new System.Drawing.Size(219, 346);
            this.receipientListDataGridView.TabIndex = 2;
            this.receipientListDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.receipientListDataGridView_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.contactNoTextBox);
            this.groupBox3.Controls.Add(this.btnContactSearch);
            this.groupBox3.Controls.Add(this.btnAddContact);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(6, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(234, 75);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add Recipient Contact#";
            // 
            // btnContactSearch
            // 
            this.btnContactSearch.BackgroundImage = global::DevFstPOSSuite.Properties.Resources.contact_list;
            this.btnContactSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnContactSearch.DisplayFocus = true;
            this.btnContactSearch.Location = new System.Drawing.Point(192, 11);
            this.btnContactSearch.Name = "btnContactSearch";
            this.btnContactSearch.Size = new System.Drawing.Size(36, 36);
            this.btnContactSearch.TabIndex = 10;
            this.btnContactSearch.UseSelectable = true;
            this.btnContactSearch.Click += new System.EventHandler(this.btnContactSearch_Click);
            // 
            // btnAddContact
            // 
            this.btnAddContact.BackgroundImage = global::DevFstPOSSuite.Properties.Resources.add_item;
            this.btnAddContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddContact.DisplayFocus = true;
            this.btnAddContact.Location = new System.Drawing.Point(153, 11);
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Size = new System.Drawing.Size(36, 36);
            this.btnAddContact.TabIndex = 9;
            this.btnAddContact.UseSelectable = true;
            this.btnAddContact.Click += new System.EventHandler(this.btnAddContact_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(5, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Like 03009234123 without Cnty. Code";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSMSCount);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblSendingBar);
            this.groupBox2.Controls.Add(this.sendingProgressBar);
            this.groupBox2.Controls.Add(this.lblMessLen);
            this.groupBox2.Controls.Add(this.btnSendSMS);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.CampaignMessageTextBox);
            this.groupBox2.Controls.Add(this.CampaignNameTextBox);
            this.groupBox2.Location = new System.Drawing.Point(261, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 334);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Campaign Section";
            // 
            // lblSendingBar
            // 
            this.lblSendingBar.AutoSize = true;
            this.lblSendingBar.ForeColor = System.Drawing.Color.Teal;
            this.lblSendingBar.Location = new System.Drawing.Point(133, 314);
            this.lblSendingBar.Name = "lblSendingBar";
            this.lblSendingBar.Size = new System.Drawing.Size(95, 13);
            this.lblSendingBar.TabIndex = 13;
            this.lblSendingBar.Text = "Waiting to Send....";
            // 
            // sendingProgressBar
            // 
            this.sendingProgressBar.Location = new System.Drawing.Point(89, 268);
            this.sendingProgressBar.Name = "sendingProgressBar";
            this.sendingProgressBar.Size = new System.Drawing.Size(178, 41);
            this.sendingProgressBar.TabIndex = 12;
            // 
            // lblMessLen
            // 
            this.lblMessLen.AutoSize = true;
            this.lblMessLen.ForeColor = System.Drawing.Color.Blue;
            this.lblMessLen.Location = new System.Drawing.Point(91, 246);
            this.lblMessLen.Name = "lblMessLen";
            this.lblMessLen.Size = new System.Drawing.Size(13, 13);
            this.lblMessLen.TabIndex = 11;
            this.lblMessLen.Text = "0";
            // 
            // btnSendSMS
            // 
            this.btnSendSMS.BackgroundImage = global::DevFstPOSSuite.Properties.Resources.send_message;
            this.btnSendSMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSendSMS.DisplayFocus = true;
            this.btnSendSMS.Location = new System.Drawing.Point(321, 246);
            this.btnSendSMS.Name = "btnSendSMS";
            this.btnSendSMS.Size = new System.Drawing.Size(77, 53);
            this.btnSendSMS.TabIndex = 10;
            this.btnSendSMS.UseSelectable = true;
            this.btnSendSMS.Click += new System.EventHandler(this.btnSendSMS_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(5, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Campaign Message";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Campaign Name";
            // 
            // CampaignMessageTextBox
            // 
            this.CampaignMessageTextBox.Lines = new string[0];
            this.CampaignMessageTextBox.Location = new System.Drawing.Point(6, 83);
            this.CampaignMessageTextBox.MaxLength = 300;
            this.CampaignMessageTextBox.Multiline = true;
            this.CampaignMessageTextBox.Name = "CampaignMessageTextBox";
            this.CampaignMessageTextBox.PasswordChar = '\0';
            this.CampaignMessageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CampaignMessageTextBox.SelectedText = "";
            this.CampaignMessageTextBox.Size = new System.Drawing.Size(392, 157);
            this.CampaignMessageTextBox.TabIndex = 3;
            this.CampaignMessageTextBox.UseSelectable = true;
            this.CampaignMessageTextBox.TextChanged += new System.EventHandler(this.CampaignMessageTextBox_TextChanged);
            this.CampaignMessageTextBox.Click += new System.EventHandler(this.CampaignMessageTextBox_Click);
            // 
            // CampaignNameTextBox
            // 
            this.CampaignNameTextBox.Lines = new string[0];
            this.CampaignNameTextBox.Location = new System.Drawing.Point(6, 36);
            this.CampaignNameTextBox.MaxLength = 100;
            this.CampaignNameTextBox.Name = "CampaignNameTextBox";
            this.CampaignNameTextBox.PasswordChar = '\0';
            this.CampaignNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CampaignNameTextBox.SelectedText = "";
            this.CampaignNameTextBox.Size = new System.Drawing.Size(392, 23);
            this.CampaignNameTextBox.TabIndex = 2;
            this.CampaignNameTextBox.UseSelectable = true;
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.Send);
            // 
            // removeContract
            // 
            this.removeContract.HeaderText = "";
            this.removeContract.Image = global::DevFstPOSSuite.Properties.Resources.delete_record;
            this.removeContract.Name = "removeContract";
            this.removeContract.Width = 40;
            // 
            // metroButton2
            // 
            this.metroButton2.BackgroundImage = global::DevFstPOSSuite.Properties.Resources.edit_undo;
            this.metroButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroButton2.Location = new System.Drawing.Point(147, 371);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(80, 38);
            this.metroButton2.TabIndex = 19;
            this.metroButton2.Text = "Reset";
            this.metroButton2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroButton2.UseCustomForeColor = true;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // contactNoTextBox
            // 
            this.contactNoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactNoTextBox.Location = new System.Drawing.Point(9, 19);
            this.contactNoTextBox.Mask = "###########";
            this.contactNoTextBox.Name = "contactNoTextBox";
            this.contactNoTextBox.Size = new System.Drawing.Size(139, 22);
            this.contactNoTextBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(5, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Message Length:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(118, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "SMS Count:";
            // 
            // lblSMSCount
            // 
            this.lblSMSCount.AutoSize = true;
            this.lblSMSCount.ForeColor = System.Drawing.Color.Blue;
            this.lblSMSCount.Location = new System.Drawing.Point(179, 246);
            this.lblSMSCount.Name = "lblSMSCount";
            this.lblSMSCount.Size = new System.Drawing.Size(13, 13);
            this.lblSMSCount.TabIndex = 16;
            this.lblSMSCount.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(8, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Recipient(s):";
            // 
            // lblRecCount
            // 
            this.lblRecCount.AutoSize = true;
            this.lblRecCount.ForeColor = System.Drawing.Color.Blue;
            this.lblRecCount.Location = new System.Drawing.Point(71, 372);
            this.lblRecCount.Name = "lblRecCount";
            this.lblRecCount.Size = new System.Drawing.Size(13, 13);
            this.lblRecCount.TabIndex = 21;
            this.lblRecCount.Text = "0";
            // 
            // contactNoDataGridViewTextBoxColumn
            // 
            this.contactNoDataGridViewTextBoxColumn.DataPropertyName = "ContactNo";
            this.contactNoDataGridViewTextBoxColumn.HeaderText = "ContactNo";
            this.contactNoDataGridViewTextBoxColumn.Name = "contactNoDataGridViewTextBoxColumn";
            this.contactNoDataGridViewTextBoxColumn.Width = 170;
            // 
            // campaignRecipientModelBindingSource
            // 
            this.campaignRecipientModelBindingSource.DataSource = typeof(DevFstPOSSuite.Models.CampaignRecipientModel);
            // 
            // SMSCampaignfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 582);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SMSCampaignfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SMS Campaign";
            this.Load += new System.EventHandler(this.SMSCampaign_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receipientListDataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.campaignRecipientModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton btnContactSearch;
        private MetroFramework.Controls.MetroButton btnAddContact;
        private MetroFramework.Controls.MetroButton btnSendSMS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox CampaignMessageTextBox;
        private MetroFramework.Controls.MetroTextBox CampaignNameTextBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroGrid receipientListDataGridView;
        private System.Windows.Forms.Label lblMessLen;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ProgressBar sendingProgressBar;
        private System.Windows.Forms.Label lblSendingBar;
        private System.Windows.Forms.BindingSource campaignRecipientModelBindingSource;
        private System.Windows.Forms.DataGridViewImageColumn removeContract;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNoDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.MaskedTextBox contactNoTextBox;
        private System.Windows.Forms.Label lblSMSCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRecCount;
        private System.Windows.Forms.Label label6;
    }
}