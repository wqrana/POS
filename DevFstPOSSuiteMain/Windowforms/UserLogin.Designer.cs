namespace DevFstPOSSuite.Windowforms
{
    partial class UserLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLogin));
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.userTxt = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new MetroFramework.Controls.MetroLabel();
            this.pwdTxt = new MetroFramework.Controls.MetroTextBox();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.LoginBtn = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroContextMenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "User";
            // 
            // userTxt
            // 
            this.userTxt.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.userTxt.Lines = new string[0];
            this.userTxt.Location = new System.Drawing.Point(219, 91);
            this.userTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userTxt.MaxLength = 32767;
            this.userTxt.Name = "userTxt";
            this.userTxt.PasswordChar = '\0';
            this.userTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userTxt.SelectedText = "";
            this.userTxt.Size = new System.Drawing.Size(267, 31);
            this.userTxt.TabIndex = 0;
            this.userTxt.Theme = MetroFramework.MetroThemeStyle.Light;
            this.userTxt.UseSelectable = true;
            this.userTxt.UseStyleColors = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // pwdTxt
            // 
            this.pwdTxt.Lines = new string[0];
            this.pwdTxt.Location = new System.Drawing.Point(219, 135);
            this.pwdTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pwdTxt.MaxLength = 32767;
            this.pwdTxt.Name = "pwdTxt";
            this.pwdTxt.PasswordChar = '*';
            this.pwdTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pwdTxt.SelectedText = "";
            this.pwdTxt.Size = new System.Drawing.Size(267, 31);
            this.pwdTxt.TabIndex = 1;
            this.pwdTxt.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pwdTxt.UseSelectable = true;
            this.pwdTxt.UseStyleColors = true;
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.metroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(87, 28);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(86, 24);
            this.toolStripMenuItem2.Text = "1";
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.White;
            this.LoginBtn.BackgroundImage = global::DevFstPOSSuite.Properties.Resources.if_Login_73221;
            this.LoginBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LoginBtn.DisplayFocus = true;
            this.LoginBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.LoginBtn.Location = new System.Drawing.Point(231, 196);
            this.LoginBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(112, 49);
            this.LoginBtn.TabIndex = 2;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LoginBtn.UseSelectable = true;
            this.LoginBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DevFstPOSSuite.Properties.Resources.login_image1;
            this.pictureBox1.Location = new System.Drawing.Point(11, 79);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // UserLogin
            // 
            this.AcceptButton = this.LoginBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(511, 268);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.userTxt);
            this.Controls.Add(this.pwdTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "UserLogin";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "User Login";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.UserLogin_Load);
            this.Shown += new System.EventHandler(this.UserLogin_Shown);
            this.metroContextMenu1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
               
   

        private MetroFramework.Controls.MetroLabel label1;
        private MetroFramework.Controls.MetroTextBox userTxt;
        private MetroFramework.Controls.MetroLabel label2;
        private MetroFramework.Controls.MetroButton LoginBtn;
        private MetroFramework.Controls.MetroTextBox pwdTxt;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}