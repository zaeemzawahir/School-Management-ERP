namespace School_Management_ERP
{
    partial class LibraryEmpMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibraryEmpMember));
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.btnClear = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lblStatus = new MetroFramework.Controls.MetroTile();
            this.txtSearchField = new MetroFramework.Controls.MetroTextBox();
            this.dataGridView1 = new MetroFramework.Controls.MetroGrid();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUnlock = new MetroFramework.Controls.MetroLink();
            this.btnLocked = new MetroFramework.Controls.MetroLink();
            this.btnRegister = new MetroFramework.Controls.MetroLink();
            this.btnDelete = new MetroFramework.Controls.MetroLink();
            this.lnkClose = new MetroFramework.Controls.MetroLink();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.rdFemale = new MetroFramework.Controls.MetroRadioButton();
            this.rdMale = new MetroFramework.Controls.MetroRadioButton();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtAddress = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtMobile = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.txtEmployeeID = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.Location = new System.Drawing.Point(696, 460);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(176, 25);
            this.metroLabel9.TabIndex = 257;
            this.metroLabel9.Text = "Membership Status";
            // 
            // btnClear
            // 
            this.btnClear.Image = null;
            this.btnClear.Location = new System.Drawing.Point(978, 128);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 256;
            this.btnClear.Text = "Clear";
            this.btnClear.UseSelectable = true;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(685, 311);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(185, 25);
            this.metroLabel6.TabIndex = 255;
            this.metroLabel6.Text = "Contact Information";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(694, 165);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(181, 25);
            this.metroLabel4.TabIndex = 254;
            this.metroLabel4.Text = "Official Information";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(688, 82);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(157, 25);
            this.metroLabel2.TabIndex = 253;
            this.metroLabel2.Text = "Search Employee";
            // 
            // lblStatus
            // 
            this.lblStatus.ActiveControl = null;
            this.lblStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblStatus.Location = new System.Drawing.Point(887, 500);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(135, 32);
            this.lblStatus.Style = MetroFramework.MetroColorStyle.Green;
            this.lblStatus.TabIndex = 252;
            this.lblStatus.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStatus.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.lblStatus.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.lblStatus.UseSelectable = true;
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
            this.txtSearchField.Location = new System.Drawing.Point(837, 128);
            this.txtSearchField.MaxLength = 32767;
            this.txtSearchField.Name = "txtSearchField";
            this.txtSearchField.PasswordChar = '\0';
            this.txtSearchField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchField.SelectedText = "";
            this.txtSearchField.SelectionLength = 0;
            this.txtSearchField.SelectionStart = 0;
            this.txtSearchField.Size = new System.Drawing.Size(135, 23);
            this.txtSearchField.TabIndex = 250;
            this.txtSearchField.UseSelectable = true;
            this.txtSearchField.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearchField.TextChanged += new System.EventHandler(this.txtSearchField_TextChanged);
            this.txtSearchField.Enter += new System.EventHandler(this.txtSearchField_GotFocus);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
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
            this.dataGridView1.Size = new System.Drawing.Size(672, 572);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(4, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 591);
            this.groupBox1.TabIndex = 231;
            this.groupBox1.TabStop = false;
            // 
            // btnUnlock
            // 
            this.btnUnlock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnlock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUnlock.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnUnlock.Image = global::School_Management_ERP.Properties.Resources.lock83__1_;
            this.btnUnlock.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUnlock.ImageSize = 32;
            this.btnUnlock.Location = new System.Drawing.Point(795, 12);
            this.btnUnlock.Name = "btnUnlock";
            this.btnUnlock.NoFocusImage = global::School_Management_ERP.Properties.Resources.lock83;
            this.btnUnlock.Size = new System.Drawing.Size(70, 56);
            this.btnUnlock.TabIndex = 236;
            this.btnUnlock.Text = "Activate";
            this.btnUnlock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUnlock.UseSelectable = true;
            this.btnUnlock.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // btnLocked
            // 
            this.btnLocked.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLocked.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLocked.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnLocked.Image = global::School_Management_ERP.Properties.Resources.locked59;
            this.btnLocked.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLocked.ImageSize = 32;
            this.btnLocked.Location = new System.Drawing.Point(725, 12);
            this.btnLocked.Name = "btnLocked";
            this.btnLocked.NoFocusImage = global::School_Management_ERP.Properties.Resources.locked59__1_;
            this.btnLocked.Size = new System.Drawing.Size(70, 56);
            this.btnLocked.TabIndex = 235;
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
            this.btnRegister.Location = new System.Drawing.Point(865, 12);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.NoFocusImage = global::School_Management_ERP.Properties.Resources.Save_No_Focus;
            this.btnRegister.Size = new System.Drawing.Size(70, 56);
            this.btnRegister.TabIndex = 234;
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
            this.btnDelete.Location = new System.Drawing.Point(935, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.NoFocusImage = global::School_Management_ERP.Properties.Resources.garbage12;
            this.btnDelete.Size = new System.Drawing.Size(70, 56);
            this.btnDelete.TabIndex = 233;
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
            this.lnkClose.Location = new System.Drawing.Point(1005, 12);
            this.lnkClose.Name = "lnkClose";
            this.lnkClose.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lnkClose.NoFocusImage")));
            this.lnkClose.Size = new System.Drawing.Size(70, 56);
            this.lnkClose.TabIndex = 232;
            this.lnkClose.Text = "Back";
            this.lnkClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnkClose.UseSelectable = true;
            this.lnkClose.Click += new System.EventHandler(this.lnkClose_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(697, 128);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(117, 19);
            this.metroLabel1.TabIndex = 259;
            this.metroLabel1.Text = "Enter Employee ID";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(702, 270);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(52, 19);
            this.metroLabel3.TabIndex = 263;
            this.metroLabel3.Text = "Gender";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(702, 230);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(45, 19);
            this.metroLabel10.TabIndex = 264;
            this.metroLabel10.Text = "Name";
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Location = new System.Drawing.Point(927, 274);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(61, 15);
            this.rdFemale.TabIndex = 262;
            this.rdFemale.Text = "Female";
            this.rdFemale.UseSelectable = true;
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Location = new System.Drawing.Point(848, 274);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(49, 15);
            this.rdMale.TabIndex = 261;
            this.rdMale.Text = "Male";
            this.rdMale.UseSelectable = true;
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(198, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(848, 230);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.Size = new System.Drawing.Size(220, 23);
            this.txtName.TabIndex = 260;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(697, 350);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(94, 19);
            this.metroLabel7.TabIndex = 268;
            this.metroLabel7.Text = "Street Address";
            // 
            // txtAddress
            // 
            // 
            // 
            // 
            this.txtAddress.CustomButton.Image = null;
            this.txtAddress.CustomButton.Location = new System.Drawing.Point(160, 2);
            this.txtAddress.CustomButton.Name = "";
            this.txtAddress.CustomButton.Size = new System.Drawing.Size(57, 57);
            this.txtAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddress.CustomButton.TabIndex = 1;
            this.txtAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddress.CustomButton.UseSelectable = true;
            this.txtAddress.CustomButton.Visible = false;
            this.txtAddress.Lines = new string[0];
            this.txtAddress.Location = new System.Drawing.Point(843, 349);
            this.txtAddress.MaxLength = 50;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddress.SelectedText = "";
            this.txtAddress.SelectionLength = 0;
            this.txtAddress.SelectionStart = 0;
            this.txtAddress.Size = new System.Drawing.Size(220, 62);
            this.txtAddress.TabIndex = 267;
            this.txtAddress.UseSelectable = true;
            this.txtAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(699, 434);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(50, 19);
            this.metroLabel5.TabIndex = 270;
            this.metroLabel5.Text = "Mobile";
            // 
            // txtMobile
            // 
            // 
            // 
            // 
            this.txtMobile.CustomButton.Image = null;
            this.txtMobile.CustomButton.Location = new System.Drawing.Point(198, 1);
            this.txtMobile.CustomButton.Name = "";
            this.txtMobile.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMobile.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMobile.CustomButton.TabIndex = 1;
            this.txtMobile.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMobile.CustomButton.UseSelectable = true;
            this.txtMobile.CustomButton.Visible = false;
            this.txtMobile.Lines = new string[0];
            this.txtMobile.Location = new System.Drawing.Point(843, 434);
            this.txtMobile.MaxLength = 50;
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.PasswordChar = '\0';
            this.txtMobile.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMobile.SelectedText = "";
            this.txtMobile.SelectionLength = 0;
            this.txtMobile.SelectionStart = 0;
            this.txtMobile.Size = new System.Drawing.Size(220, 23);
            this.txtMobile.TabIndex = 269;
            this.txtMobile.UseSelectable = true;
            this.txtMobile.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMobile.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(702, 199);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(83, 19);
            this.metroLabel11.TabIndex = 271;
            this.metroLabel11.Text = "Employee ID";
            // 
            // txtEmployeeID
            // 
            // 
            // 
            // 
            this.txtEmployeeID.CustomButton.Image = null;
            this.txtEmployeeID.CustomButton.Location = new System.Drawing.Point(95, 1);
            this.txtEmployeeID.CustomButton.Name = "";
            this.txtEmployeeID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmployeeID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmployeeID.CustomButton.TabIndex = 1;
            this.txtEmployeeID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmployeeID.CustomButton.UseSelectable = true;
            this.txtEmployeeID.CustomButton.Visible = false;
            this.txtEmployeeID.Enabled = false;
            this.txtEmployeeID.Lines = new string[0];
            this.txtEmployeeID.Location = new System.Drawing.Point(848, 199);
            this.txtEmployeeID.MaxLength = 32767;
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.PasswordChar = '\0';
            this.txtEmployeeID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmployeeID.SelectedText = "";
            this.txtEmployeeID.SelectionLength = 0;
            this.txtEmployeeID.SelectionStart = 0;
            this.txtEmployeeID.Size = new System.Drawing.Size(117, 23);
            this.txtEmployeeID.TabIndex = 272;
            this.txtEmployeeID.UseSelectable = true;
            this.txtEmployeeID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmployeeID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LibraryEmpMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 671);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.rdFemale);
            this.Controls.Add(this.rdMale);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtSearchField);
            this.Controls.Add(this.btnUnlock);
            this.Controls.Add(this.btnLocked);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lnkClose);
            this.Controls.Add(this.groupBox1);
            this.Name = "LibraryEmpMember";
            this.Text = "LibraryEmpMember";
            this.Load += new System.EventHandler(this.LibraryEmpMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnClear;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTile lblStatus;
        private MetroFramework.Controls.MetroTextBox txtSearchField;
        private MetroFramework.Controls.MetroGrid dataGridView1;
        private MetroFramework.Controls.MetroLink btnUnlock;
        private MetroFramework.Controls.MetroLink btnLocked;
        private MetroFramework.Controls.MetroLink btnRegister;
        private MetroFramework.Controls.MetroLink btnDelete;
        private MetroFramework.Controls.MetroLink lnkClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroRadioButton rdFemale;
        private MetroFramework.Controls.MetroRadioButton rdMale;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtAddress;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtMobile;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox txtEmployeeID;
    }
}