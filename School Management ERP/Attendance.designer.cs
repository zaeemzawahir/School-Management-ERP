namespace School_Management_ERP
{
    partial class frmAttendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAttendance));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.txtEmpID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lblDisplayTime = new MetroFramework.Controls.MetroLabel();
            this.btnEnter = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lnkClose = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Enabled = false;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(289, 107);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.Size = new System.Drawing.Size(155, 23);
            this.txtName.TabIndex = 12;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtEmpID
            // 
            // 
            // 
            // 
            this.txtEmpID.CustomButton.Image = null;
            this.txtEmpID.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.txtEmpID.CustomButton.Name = "";
            this.txtEmpID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmpID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmpID.CustomButton.TabIndex = 1;
            this.txtEmpID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmpID.CustomButton.UseSelectable = true;
            this.txtEmpID.CustomButton.Visible = false;
            this.txtEmpID.Lines = new string[0];
            this.txtEmpID.Location = new System.Drawing.Point(289, 67);
            this.txtEmpID.MaxLength = 32767;
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.PasswordChar = '\0';
            this.txtEmpID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmpID.SelectedText = "";
            this.txtEmpID.SelectionLength = 0;
            this.txtEmpID.SelectionStart = 0;
            this.txtEmpID.Size = new System.Drawing.Size(155, 23);
            this.txtEmpID.TabIndex = 1;
            this.txtEmpID.UseSelectable = true;
            this.txtEmpID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmpID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmpID.TextChanged += new System.EventHandler(this.txtEmpID_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(153, 109);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 19);
            this.metroLabel1.TabIndex = 14;
            this.metroLabel1.Text = "Name";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(153, 69);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(83, 19);
            this.metroLabel2.TabIndex = 15;
            this.metroLabel2.Text = "Employee ID";
            // 
            // lblDisplayTime
            // 
            this.lblDisplayTime.AutoSize = true;
            this.lblDisplayTime.ForeColor = System.Drawing.Color.Crimson;
            this.lblDisplayTime.Location = new System.Drawing.Point(289, 149);
            this.lblDisplayTime.Name = "lblDisplayTime";
            this.lblDisplayTime.Size = new System.Drawing.Size(86, 19);
            this.lblDisplayTime.TabIndex = 16;
            this.lblDisplayTime.Text = "Current Time";
            // 
            // btnEnter
            // 
            this.btnEnter.Image = null;
            this.btnEnter.Location = new System.Drawing.Point(247, 213);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(102, 28);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "Mark Time";
            this.btnEnter.UseSelectable = true;
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(153, 149);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(86, 19);
            this.metroLabel3.TabIndex = 17;
            this.metroLabel3.Text = "Current Time";
            // 
            // lnkClose
            // 
            this.lnkClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.lnkClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.lnkClose.Image = ((System.Drawing.Image)(resources.GetObject("lnkClose.Image")));
            this.lnkClose.ImageSize = 32;
            this.lnkClose.Location = new System.Drawing.Point(516, 17);
            this.lnkClose.Name = "lnkClose";
            this.lnkClose.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lnkClose.NoFocusImage")));
            this.lnkClose.Size = new System.Drawing.Size(48, 42);
            this.lnkClose.TabIndex = 183;
            this.lnkClose.UseSelectable = true;
            this.lnkClose.Click += new System.EventHandler(this.lnkClose_Click);
            // 
            // frmAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 292);
            this.Controls.Add(this.lnkClose);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lblDisplayTime);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.txtName);
            this.Name = "frmAttendance";
            this.Text = "Staff Attendance";
            this.Load += new System.EventHandler(this.frmAttendance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroTextBox txtEmpID;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel lblDisplayTime;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnEnter;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLink lnkClose;
    }
}