namespace School_Management_ERP
{
    partial class frmStudentMemReg
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentMemReg));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new MetroFramework.Controls.MetroGrid();
            this.btnLocked = new MetroFramework.Controls.MetroLink();
            this.btnRegister = new MetroFramework.Controls.MetroLink();
            this.btnDelete = new MetroFramework.Controls.MetroLink();
            this.lnkClose = new MetroFramework.Controls.MetroLink();
            this.btnUnlock = new MetroFramework.Controls.MetroLink();
            this.lblStatus = new MetroFramework.Controls.MetroTile();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtAdmissionNo = new MetroFramework.Controls.MetroTextBox();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.Name = new MetroFramework.Controls.MetroLabel();
            this.Gender = new MetroFramework.Controls.MetroLabel();
            this.rdMale = new MetroFramework.Controls.MetroRadioButton();
            this.rdFemale = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.dtDob = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtAddress = new MetroFramework.Controls.MetroTextBox();
            this.txtContactNo = new MetroFramework.Controls.MetroTextBox();
            this.txtSearchField = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.btnClear = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(20, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1038, 591);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1032, 572);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnLocked
            // 
            this.btnLocked.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLocked.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLocked.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnLocked.Image = global::School_Management_ERP.Properties.Resources.locked59;
            this.btnLocked.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLocked.ImageSize = 32;
            this.btnLocked.Location = new System.Drawing.Point(716, 18);
            this.btnLocked.Name = "btnLocked";
            this.btnLocked.NoFocusImage = global::School_Management_ERP.Properties.Resources.locked59__1_;
            this.btnLocked.Size = new System.Drawing.Size(70, 56);
            this.btnLocked.TabIndex = 183;
            this.btnLocked.Text = "Suspend";
            this.btnLocked.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLocked.UseSelectable = true;
            this.btnLocked.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRegister.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnRegister.Image = global::School_Management_ERP.Properties.Resources.save8;
            this.btnRegister.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRegister.ImageSize = 32;
            this.btnRegister.Location = new System.Drawing.Point(856, 18);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.NoFocusImage = global::School_Management_ERP.Properties.Resources.Save_No_Focus;
            this.btnRegister.Size = new System.Drawing.Size(70, 56);
            this.btnRegister.TabIndex = 182;
            this.btnRegister.Text = "Register";
            this.btnRegister.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegister.UseSelectable = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDelete.Image = global::School_Management_ERP.Properties.Resources.garbage12__1_;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.ImageSize = 32;
            this.btnDelete.Location = new System.Drawing.Point(926, 18);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.NoFocusImage = global::School_Management_ERP.Properties.Resources.garbage12;
            this.btnDelete.Size = new System.Drawing.Size(70, 56);
            this.btnDelete.TabIndex = 181;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.UseSelectable = true;
            // 
            // lnkClose
            // 
            this.lnkClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.lnkClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.lnkClose.Image = ((System.Drawing.Image)(resources.GetObject("lnkClose.Image")));
            this.lnkClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnkClose.ImageSize = 32;
            this.lnkClose.Location = new System.Drawing.Point(996, 18);
            this.lnkClose.Name = "lnkClose";
            this.lnkClose.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lnkClose.NoFocusImage")));
            this.lnkClose.Size = new System.Drawing.Size(70, 56);
            this.lnkClose.TabIndex = 180;
            this.lnkClose.Text = "Back";
            this.lnkClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnkClose.UseSelectable = true;
            this.lnkClose.Click += new System.EventHandler(this.lnkClose_Click);
            // 
            // btnUnlock
            // 
            this.btnUnlock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnlock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUnlock.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnUnlock.Image = global::School_Management_ERP.Properties.Resources.lock83__1_;
            this.btnUnlock.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUnlock.ImageSize = 32;
            this.btnUnlock.Location = new System.Drawing.Point(786, 18);
            this.btnUnlock.Name = "btnUnlock";
            this.btnUnlock.NoFocusImage = global::School_Management_ERP.Properties.Resources.lock83;
            this.btnUnlock.Size = new System.Drawing.Size(70, 56);
            this.btnUnlock.TabIndex = 184;
            this.btnUnlock.Text = "Activate";
            this.btnUnlock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUnlock.UseSelectable = true;
            this.btnUnlock.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.ActiveControl = null;
            this.lblStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblStatus.Location = new System.Drawing.Point(862, 548);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(135, 32);
            this.lblStatus.Style = MetroFramework.MetroColorStyle.Green;
            this.lblStatus.TabIndex = 225;
            this.lblStatus.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStatus.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.lblStatus.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.lblStatus.UseSelectable = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.Location = new System.Drawing.Point(715, 508);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(176, 25);
            this.metroLabel9.TabIndex = 230;
            this.metroLabel9.Text = "Membership Status";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(715, 208);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(69, 19);
            this.metroLabel3.TabIndex = 210;
            this.metroLabel3.Text = "Student ID";
            // 
            // txtAdmissionNo
            // 
            // 
            // 
            // 
            this.txtAdmissionNo.CustomButton.Image = null;
            this.txtAdmissionNo.CustomButton.Location = new System.Drawing.Point(113, 1);
            this.txtAdmissionNo.CustomButton.Name = "";
            this.txtAdmissionNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAdmissionNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAdmissionNo.CustomButton.TabIndex = 1;
            this.txtAdmissionNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAdmissionNo.CustomButton.UseSelectable = true;
            this.txtAdmissionNo.CustomButton.Visible = false;
            this.txtAdmissionNo.Enabled = false;
            this.txtAdmissionNo.Lines = new string[0];
            this.txtAdmissionNo.Location = new System.Drawing.Point(831, 208);
            this.txtAdmissionNo.MaxLength = 32767;
            this.txtAdmissionNo.Name = "txtAdmissionNo";
            this.txtAdmissionNo.PasswordChar = '\0';
            this.txtAdmissionNo.ReadOnly = true;
            this.txtAdmissionNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAdmissionNo.SelectedText = "";
            this.txtAdmissionNo.SelectionLength = 0;
            this.txtAdmissionNo.SelectionStart = 0;
            this.txtAdmissionNo.Size = new System.Drawing.Size(135, 23);
            this.txtAdmissionNo.TabIndex = 211;
            this.txtAdmissionNo.UseSelectable = true;
            this.txtAdmissionNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAdmissionNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(195, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Enabled = false;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(831, 247);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.Size = new System.Drawing.Size(217, 23);
            this.txtName.TabIndex = 212;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(715, 251);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(47, 19);
            this.Name.TabIndex = 213;
            this.Name.Text = "library";
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Location = new System.Drawing.Point(715, 288);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(52, 19);
            this.Gender.TabIndex = 214;
            this.Gender.Text = "Gender";
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Enabled = false;
            this.rdMale.Location = new System.Drawing.Point(831, 288);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(49, 15);
            this.rdMale.TabIndex = 215;
            this.rdMale.Text = "Male";
            this.rdMale.UseSelectable = true;
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Enabled = false;
            this.rdFemale.Location = new System.Drawing.Point(910, 288);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(61, 15);
            this.rdFemale.TabIndex = 216;
            this.rdFemale.Text = "Female";
            this.rdFemale.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(715, 463);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(107, 19);
            this.metroLabel5.TabIndex = 219;
            this.metroLabel5.Text = "Contact Number";
            // 
            // dtDob
            // 
            this.dtDob.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlText;
            this.dtDob.Enabled = false;
            this.dtDob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDob.Location = new System.Drawing.Point(831, 313);
            this.dtDob.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtDob.Name = "dtDob";
            this.dtDob.Size = new System.Drawing.Size(103, 29);
            this.dtDob.TabIndex = 217;
            this.dtDob.Value = new System.DateTime(2015, 11, 17, 0, 0, 0, 0);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(715, 323);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(84, 19);
            this.metroLabel8.TabIndex = 218;
            this.metroLabel8.Text = "Date of Birth";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(715, 404);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(56, 19);
            this.metroLabel7.TabIndex = 221;
            this.metroLabel7.Text = "Address";
            // 
            // txtAddress
            // 
            // 
            // 
            // 
            this.txtAddress.CustomButton.Image = null;
            this.txtAddress.CustomButton.Location = new System.Drawing.Point(161, 1);
            this.txtAddress.CustomButton.Name = "";
            this.txtAddress.CustomButton.Size = new System.Drawing.Size(55, 55);
            this.txtAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddress.CustomButton.TabIndex = 1;
            this.txtAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddress.CustomButton.UseSelectable = true;
            this.txtAddress.CustomButton.Visible = false;
            this.txtAddress.Enabled = false;
            this.txtAddress.Lines = new string[0];
            this.txtAddress.Location = new System.Drawing.Point(831, 400);
            this.txtAddress.MaxLength = 32767;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddress.SelectedText = "";
            this.txtAddress.SelectionLength = 0;
            this.txtAddress.SelectionStart = 0;
            this.txtAddress.Size = new System.Drawing.Size(217, 57);
            this.txtAddress.TabIndex = 220;
            this.txtAddress.UseSelectable = true;
            this.txtAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtContactNo
            // 
            // 
            // 
            // 
            this.txtContactNo.CustomButton.Image = null;
            this.txtContactNo.CustomButton.Location = new System.Drawing.Point(195, 1);
            this.txtContactNo.CustomButton.Name = "";
            this.txtContactNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtContactNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtContactNo.CustomButton.TabIndex = 1;
            this.txtContactNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtContactNo.CustomButton.UseSelectable = true;
            this.txtContactNo.CustomButton.Visible = false;
            this.txtContactNo.Enabled = false;
            this.txtContactNo.Lines = new string[0];
            this.txtContactNo.Location = new System.Drawing.Point(831, 463);
            this.txtContactNo.MaxLength = 32767;
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.PasswordChar = '\0';
            this.txtContactNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtContactNo.SelectedText = "";
            this.txtContactNo.SelectionLength = 0;
            this.txtContactNo.SelectionStart = 0;
            this.txtContactNo.Size = new System.Drawing.Size(217, 23);
            this.txtContactNo.TabIndex = 222;
            this.txtContactNo.UseSelectable = true;
            this.txtContactNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtContactNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSearchField
            // 
            // 
            // 
            // 
            this.txtSearchField.CustomButton.Image = null;
            this.txtSearchField.CustomButton.Location = new System.Drawing.Point(113, 1);
            this.txtSearchField.CustomButton.Name = "";
            this.txtSearchField.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearchField.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchField.CustomButton.TabIndex = 1;
            this.txtSearchField.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchField.CustomButton.UseSelectable = true;
            this.txtSearchField.CustomButton.Visible = false;
            this.txtSearchField.Lines = new string[0];
            this.txtSearchField.Location = new System.Drawing.Point(836, 134);
            this.txtSearchField.MaxLength = 32767;
            this.txtSearchField.Name = "txtSearchField";
            this.txtSearchField.PasswordChar = '\0';
            this.txtSearchField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchField.SelectedText = "";
            this.txtSearchField.SelectionLength = 0;
            this.txtSearchField.SelectionStart = 0;
            this.txtSearchField.Size = new System.Drawing.Size(135, 23);
            this.txtSearchField.TabIndex = 223;
            this.txtSearchField.UseSelectable = true;
            this.txtSearchField.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearchField.TextChanged += new System.EventHandler(this.txtSearchField_TextChanged);
            this.txtSearchField.Enter += new System.EventHandler(this.txtSearchField_GotFocus);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(715, 134);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(103, 19);
            this.metroLabel1.TabIndex = 224;
            this.metroLabel1.Text = "Enter Student ID";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(704, 88);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(141, 25);
            this.metroLabel2.TabIndex = 226;
            this.metroLabel2.Text = "Search Student";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(704, 171);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(181, 25);
            this.metroLabel4.TabIndex = 227;
            this.metroLabel4.Text = "Official Information";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(704, 359);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(185, 25);
            this.metroLabel6.TabIndex = 228;
            this.metroLabel6.Text = "Contact Information";
            // 
            // btnClear
            // 
            this.btnClear.Image = null;
            this.btnClear.Location = new System.Drawing.Point(979, 134);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 229;
            this.btnClear.Text = "Clear";
            this.btnClear.UseSelectable = true;
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // frmStudentMemReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 666);
            this.ControlBox = false;
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtSearchField);
            this.Controls.Add(this.txtContactNo);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.dtDob);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.rdFemale);
            this.Controls.Add(this.rdMale);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtAdmissionNo);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.btnUnlock);
            this.Controls.Add(this.btnLocked);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lnkClose);
            this.Controls.Add(this.groupBox1);
            //this.Name = "frmStudentMemReg";
            this.Text = "Student Registration";
            this.Load += new System.EventHandler(this.LibraryMemberReg_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLink btnDelete;
        private MetroFramework.Controls.MetroLink lnkClose;
        private MetroFramework.Controls.MetroLink btnRegister;
        private MetroFramework.Controls.MetroGrid dataGridView1;
        private MetroFramework.Controls.MetroLink btnLocked;
        private MetroFramework.Controls.MetroLink btnUnlock;
        private MetroFramework.Controls.MetroTile lblStatus;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtAdmissionNo;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroLabel Name;
        private MetroFramework.Controls.MetroLabel Gender;
        private MetroFramework.Controls.MetroRadioButton rdMale;
        private MetroFramework.Controls.MetroRadioButton rdFemale;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroDateTime dtDob;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtAddress;
        private MetroFramework.Controls.MetroTextBox txtContactNo;
        private MetroFramework.Controls.MetroTextBox txtSearchField;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnClear;

    }
}