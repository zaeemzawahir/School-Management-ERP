//namespace School_Management_ERP
//{
//    partial class User_Account
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.label1 = new System.Windows.Forms.Label();
//            this.label2 = new System.Windows.Forms.Label();
//            this.label3 = new System.Windows.Forms.Label();
//            this.label4 = new System.Windows.Forms.Label();
//            this.txtAccessLevel = new System.Windows.Forms.Label();
//            this.txtUname = new System.Windows.Forms.TextBox();
//            this.txtPassword = new System.Windows.Forms.TextBox();
//            this.btnCreate = new MetroFramework.Controls.MetroButton();
//            this.btnView = new MetroFramework.Controls.MetroButton();
//            this.btnUpdate = new MetroFramework.Controls.MetroButton();
//            this.btnDelete = new MetroFramework.Controls.MetroButton();
//            this.cmbActiveStat = new MetroFramework.Controls.MetroComboBox();
//            this.cmbAccessLevel = new MetroFramework.Controls.MetroComboBox();
//            this.txtEmpID = new System.Windows.Forms.TextBox();
//            this.SuspendLayout();
//            // 
//            // label1
//            // 
//            this.label1.AutoSize = true;
//            this.label1.BackColor = System.Drawing.Color.Transparent;
//            this.label1.ForeColor = System.Drawing.Color.White;
//            this.label1.Location = new System.Drawing.Point(52, 83);
//            this.label1.Name = "label1";
//            this.label1.Size = new System.Drawing.Size(67, 13);
//            this.label1.TabIndex = 0;
//            this.label1.Text = "Employee ID";
//            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
//            // 
//            // label2
//            // 
//            this.label2.AutoSize = true;
//            this.label2.BackColor = System.Drawing.Color.Transparent;
//            this.label2.ForeColor = System.Drawing.Color.White;
//            this.label2.Location = new System.Drawing.Point(52, 121);
//            this.label2.Name = "label2";
//            this.label2.Size = new System.Drawing.Size(55, 13);
//            this.label2.TabIndex = 1;
//            this.label2.Text = "Username";
//            // 
//            // label3
//            // 
//            this.label3.AutoSize = true;
//            this.label3.BackColor = System.Drawing.Color.Transparent;
//            this.label3.ForeColor = System.Drawing.Color.White;
//            this.label3.Location = new System.Drawing.Point(52, 159);
//            this.label3.Name = "label3";
//            this.label3.Size = new System.Drawing.Size(53, 13);
//            this.label3.TabIndex = 2;
//            this.label3.Text = "Password";
//            // 
//            // label4
//            // 
//            this.label4.AutoSize = true;
//            this.label4.BackColor = System.Drawing.Color.Transparent;
//            this.label4.ForeColor = System.Drawing.Color.White;
//            this.label4.Location = new System.Drawing.Point(52, 197);
//            this.label4.Name = "label4";
//            this.label4.Size = new System.Drawing.Size(70, 13);
//            this.label4.TabIndex = 3;
//            this.label4.Text = "Active Status";
//            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
//            // 
//            // txtAccessLevel
//            // 
//            this.txtAccessLevel.AutoSize = true;
//            this.txtAccessLevel.BackColor = System.Drawing.Color.Transparent;
//            this.txtAccessLevel.ForeColor = System.Drawing.Color.White;
//            this.txtAccessLevel.Location = new System.Drawing.Point(52, 235);
//            this.txtAccessLevel.Name = "txtAccessLevel";
//            this.txtAccessLevel.Size = new System.Drawing.Size(71, 13);
//            this.txtAccessLevel.TabIndex = 4;
//            this.txtAccessLevel.Text = "Access Level";
//            // 
//            // txtUname
//            // 
//            this.txtUname.Location = new System.Drawing.Point(163, 118);
//            this.txtUname.Name = "txtUname";
//            this.txtUname.Size = new System.Drawing.Size(159, 20);
//            this.txtUname.TabIndex = 6;
//            // 
//            // txtPassword
//            // 
//            this.txtPassword.Location = new System.Drawing.Point(163, 156);
//            this.txtPassword.Name = "txtPassword";
//            this.txtPassword.Size = new System.Drawing.Size(159, 20);
//            this.txtPassword.TabIndex = 7;
//            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
//            // 
//            // btnCreate
//            // 
//            this.btnCreate.Location = new System.Drawing.Point(367, 80);
//            this.btnCreate.Name = "btnCreate";
//            this.btnCreate.Size = new System.Drawing.Size(99, 25);
//            this.btnCreate.TabIndex = 16;
//            this.btnCreate.Text = "Create";
//            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
//            // 
//            // btnView
//            // 
//            this.btnView.Location = new System.Drawing.Point(367, 116);
//            this.btnView.Name = "btnView";
//            this.btnView.Size = new System.Drawing.Size(99, 25);
//            this.btnView.TabIndex = 17;
//            this.btnView.Text = "View";
//            this.btnView.Click += new System.EventHandler(this.btnView_Click);
//            // 
//            // btnUpdate
//            // 
//            this.btnUpdate.Location = new System.Drawing.Point(367, 152);
//            this.btnUpdate.Name = "btnUpdate";
//            this.btnUpdate.Size = new System.Drawing.Size(99, 25);
//            this.btnUpdate.TabIndex = 18;
//            this.btnUpdate.Text = "Update";
//            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
//            // 
//            // btnDelete
//            // 
//            this.btnDelete.Location = new System.Drawing.Point(367, 188);
//            this.btnDelete.Name = "btnDelete";
//            this.btnDelete.Size = new System.Drawing.Size(99, 25);
//            this.btnDelete.TabIndex = 19;
//            this.btnDelete.Text = "Delete";
//            // 
//            // cmbActiveStat
//            // 
//            this.cmbActiveStat.FormattingEnabled = true;
//            this.cmbActiveStat.ItemHeight = 23;
//            this.cmbActiveStat.Items.AddRange(new object[] {
//            "Active",
//            "Suspended"});
//            this.cmbActiveStat.Location = new System.Drawing.Point(163, 188);
//            this.cmbActiveStat.Name = "cmbActiveStat";
//            this.cmbActiveStat.Size = new System.Drawing.Size(159, 29);
//            this.cmbActiveStat.TabIndex = 20;
//            // 
//            // cmbAccessLevel
//            // 
//            this.cmbAccessLevel.FormattingEnabled = true;
//            this.cmbAccessLevel.ItemHeight = 23;
//            this.cmbAccessLevel.Items.AddRange(new object[] {
//            "Super Admin",
//            "Principal",
//            "Management",
//            "Head Clerk",
//            "Librarian",
//            "Inventory Manager",
//            "Clerk"});
//            this.cmbAccessLevel.Location = new System.Drawing.Point(163, 223);
//            this.cmbAccessLevel.Name = "cmbAccessLevel";
//            this.cmbAccessLevel.Size = new System.Drawing.Size(159, 29);
//            this.cmbAccessLevel.TabIndex = 21;
//            // 
//            // txtEmpID
//            // 
//            this.txtEmpID.Location = new System.Drawing.Point(163, 84);
//            this.txtEmpID.Name = "txtEmpID";
//            this.txtEmpID.Size = new System.Drawing.Size(159, 20);
//            this.txtEmpID.TabIndex = 1;
//            this.txtEmpID.TabStop = false;
//            this.txtEmpID.TextChanged += new System.EventHandler(this.txtEmpID_TextChanged);
//            // 
//            // User_Account
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
//            this.ClientSize = new System.Drawing.Size(510, 331);
//            this.Controls.Add(this.txtEmpID);
//            this.Controls.Add(this.cmbAccessLevel);
//            this.Controls.Add(this.cmbActiveStat);
//            this.Controls.Add(this.btnDelete);
//            this.Controls.Add(this.btnUpdate);
//            this.Controls.Add(this.btnView);
//            this.Controls.Add(this.btnCreate);
//            this.Controls.Add(this.txtPassword);
//            this.Controls.Add(this.txtUname);
//            this.Controls.Add(this.txtAccessLevel);
//            this.Controls.Add(this.label4);
//            this.Controls.Add(this.label3);
//            this.Controls.Add(this.label2);
//            this.Controls.Add(this.label1);
//            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
//            this.Name = "User_Account";
//            this.Style = MetroFramework.MetroColorStyle.White;
//            this.Text = "User_Account";
//            this.Theme = MetroFramework.MetroThemeStyle.Dark;
//            this.Load += new System.EventHandler(this.User_Account_Load);
//            this.ResumeLayout(false);
//            this.PerformLayout();

//        }

//        #endregion

//        private System.Windows.Forms.Label label1;
//        private System.Windows.Forms.Label label2;
//        private System.Windows.Forms.Label label3;
//        private System.Windows.Forms.Label label4;
//        private System.Windows.Forms.Label txtAccessLevel;
//        private System.Windows.Forms.TextBox txtUname;
//        private System.Windows.Forms.TextBox txtPassword;
       
//        private System.Windows.Forms.TextBox txtEmpID;
//    }
//}