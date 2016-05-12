namespace School_Management_ERP
{
    partial class StudentDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentDetail));
            this.datePickerBox = new System.Windows.Forms.GroupBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.toDate = new MetroFramework.Controls.MetroDateTime();
            this.fromDate = new MetroFramework.Controls.MetroDateTime();
            this.cmbSearch = new MetroFramework.Controls.MetroComboBox();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtDateOfAdmission = new MetroFramework.Controls.MetroDateTime();
            this.txtAdmissionNo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.txtContactNo = new MetroFramework.Controls.MetroTextBox();
            this.txtCity = new MetroFramework.Controls.MetroTextBox();
            this.txtAddress = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txtGuardianName = new MetroFramework.Controls.MetroTextBox();
            this.txtGuardianContactNo = new MetroFramework.Controls.MetroTextBox();
            this.Religion = new MetroFramework.Controls.MetroLabel();
            this.cmbReligion = new MetroFramework.Controls.MetroComboBox();
            this.tNationality = new MetroFramework.Controls.MetroLabel();
            this.txtNationality = new MetroFramework.Controls.MetroTextBox();
            this.txtNic = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.dtDob = new MetroFramework.Controls.MetroDateTime();
            this.rdFemale = new MetroFramework.Controls.MetroRadioButton();
            this.rdMale = new MetroFramework.Controls.MetroRadioButton();
            this.Gender = new MetroFramework.Controls.MetroLabel();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.dataGridView1 = new MetroFramework.Controls.MetroGrid();
            this.progress = new MetroFramework.Controls.MetroProgressSpinner();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new MetroFramework.Controls.MetroLink();
            this.btnDelete = new MetroFramework.Controls.MetroLink();
            this.lnkClose = new MetroFramework.Controls.MetroLink();
            this.datePickerBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // datePickerBox
            // 
            this.datePickerBox.Controls.Add(this.metroLabel2);
            this.datePickerBox.Controls.Add(this.metroLabel1);
            this.datePickerBox.Controls.Add(this.toDate);
            this.datePickerBox.Controls.Add(this.fromDate);
            this.datePickerBox.Location = new System.Drawing.Point(229, 62);
            this.datePickerBox.Name = "datePickerBox";
            this.datePickerBox.Size = new System.Drawing.Size(337, 51);
            this.datePickerBox.TabIndex = 89;
            this.datePickerBox.TabStop = false;
            this.datePickerBox.Enter += new System.EventHandler(this.datePickerBox_Enter);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(187, 19);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(22, 19);
            this.metroLabel2.TabIndex = 86;
            this.metroLabel2.Text = "To";
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 19);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(41, 19);
            this.metroLabel1.TabIndex = 85;
            this.metroLabel1.Text = "From";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // toDate
            // 
            this.toDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toDate.Location = new System.Drawing.Point(223, 14);
            this.toDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.toDate.Name = "toDate";
            this.toDate.Size = new System.Drawing.Size(103, 29);
            this.toDate.TabIndex = 84;
            this.toDate.Value = new System.DateTime(2015, 11, 17, 0, 0, 0, 0);
            this.toDate.ValueChanged += new System.EventHandler(this.fromDate_ValueChnged);
            // 
            // fromDate
            // 
            this.fromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromDate.Location = new System.Drawing.Point(70, 14);
            this.fromDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.fromDate.Name = "fromDate";
            this.fromDate.Size = new System.Drawing.Size(103, 29);
            this.fromDate.TabIndex = 64;
            this.fromDate.Value = new System.DateTime(2015, 11, 17, 0, 0, 0, 0);
            this.fromDate.ValueChanged += new System.EventHandler(this.fromDate_ValueChanged);
            // 
            // cmbSearch
            // 
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.ItemHeight = 23;
            this.cmbSearch.Items.AddRange(new object[] {
            "Student ID",
            "City",
            "Guardian Name ",
            "National Identity",
            "Date of Admission"});
            this.cmbSearch.Location = new System.Drawing.Point(24, 75);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(178, 29);
            this.cmbSearch.TabIndex = 91;
            this.cmbSearch.UseSelectable = true;
            this.cmbSearch.SelectedIndexChanged += new System.EventHandler(this.cmbSearch_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(89, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(229, 90);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.Size = new System.Drawing.Size(111, 23);
            this.txtSearch.TabIndex = 90;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtDateOfAdmission);
            this.groupBox2.Controls.Add(this.txtAdmissionNo);
            this.groupBox2.Controls.Add(this.metroLabel4);
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Controls.Add(this.metroLabel12);
            this.groupBox2.Controls.Add(this.txtContactNo);
            this.groupBox2.Controls.Add(this.txtCity);
            this.groupBox2.Controls.Add(this.txtAddress);
            this.groupBox2.Controls.Add(this.metroLabel5);
            this.groupBox2.Controls.Add(this.metroLabel6);
            this.groupBox2.Controls.Add(this.metroLabel7);
            this.groupBox2.Controls.Add(this.metroLabel11);
            this.groupBox2.Controls.Add(this.metroLabel10);
            this.groupBox2.Controls.Add(this.txtGuardianName);
            this.groupBox2.Controls.Add(this.txtGuardianContactNo);
            this.groupBox2.Controls.Add(this.Religion);
            this.groupBox2.Controls.Add(this.cmbReligion);
            this.groupBox2.Controls.Add(this.tNationality);
            this.groupBox2.Controls.Add(this.txtNationality);
            this.groupBox2.Controls.Add(this.txtNic);
            this.groupBox2.Controls.Add(this.metroLabel9);
            this.groupBox2.Controls.Add(this.metroLabel8);
            this.groupBox2.Controls.Add(this.dtDob);
            this.groupBox2.Controls.Add(this.rdFemale);
            this.groupBox2.Controls.Add(this.rdMale);
            this.groupBox2.Controls.Add(this.Gender);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Location = new System.Drawing.Point(23, 351);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1029, 241);
            this.groupBox2.TabIndex = 162;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personal Infromation";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dtDateOfAdmission
            // 
            this.dtDateOfAdmission.Enabled = false;
            this.dtDateOfAdmission.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDateOfAdmission.Location = new System.Drawing.Point(476, 20);
            this.dtDateOfAdmission.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtDateOfAdmission.Name = "dtDateOfAdmission";
            this.dtDateOfAdmission.Size = new System.Drawing.Size(103, 29);
            this.dtDateOfAdmission.TabIndex = 201;
            this.dtDateOfAdmission.Value = new System.DateTime(2015, 11, 17, 0, 0, 0, 0);
            this.dtDateOfAdmission.ValueChanged += new System.EventHandler(this.dtDateOfAdmission_ValueChanged);
            // 
            // txtAdmissionNo
            // 
            // 
            // 
            // 
            this.txtAdmissionNo.CustomButton.Image = null;
            this.txtAdmissionNo.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtAdmissionNo.CustomButton.Name = "";
            this.txtAdmissionNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAdmissionNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAdmissionNo.CustomButton.TabIndex = 1;
            this.txtAdmissionNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAdmissionNo.CustomButton.UseSelectable = true;
            this.txtAdmissionNo.CustomButton.Visible = false;
            this.txtAdmissionNo.Lines = new string[0];
            this.txtAdmissionNo.Location = new System.Drawing.Point(117, 18);
            this.txtAdmissionNo.MaxLength = 32767;
            this.txtAdmissionNo.Name = "txtAdmissionNo";
            this.txtAdmissionNo.PasswordChar = '\0';
            this.txtAdmissionNo.ReadOnly = true;
            this.txtAdmissionNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAdmissionNo.SelectedText = "";
            this.txtAdmissionNo.SelectionLength = 0;
            this.txtAdmissionNo.SelectionStart = 0;
            this.txtAdmissionNo.Size = new System.Drawing.Size(200, 23);
            this.txtAdmissionNo.TabIndex = 200;
            this.txtAdmissionNo.UseSelectable = true;
            this.txtAdmissionNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAdmissionNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtAdmissionNo.Click += new System.EventHandler(this.txtAdmissionNo_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(334, 19);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(116, 19);
            this.metroLabel4.TabIndex = 199;
            this.metroLabel4.Text = "Date of Admission";
            this.metroLabel4.Click += new System.EventHandler(this.metroLabel4_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(6, 19);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(69, 19);
            this.metroLabel3.TabIndex = 198;
            this.metroLabel3.Text = "Student ID";
            this.metroLabel3.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(6, 62);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(45, 19);
            this.metroLabel12.TabIndex = 197;
            this.metroLabel12.Text = "Name";
            this.metroLabel12.Click += new System.EventHandler(this.metroLabel12_Click);
            // 
            // txtContactNo
            // 
            // 
            // 
            // 
            this.txtContactNo.CustomButton.Image = null;
            this.txtContactNo.CustomButton.Location = new System.Drawing.Point(169, 1);
            this.txtContactNo.CustomButton.Name = "";
            this.txtContactNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtContactNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtContactNo.CustomButton.TabIndex = 1;
            this.txtContactNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtContactNo.CustomButton.UseSelectable = true;
            this.txtContactNo.CustomButton.Visible = false;
            this.txtContactNo.Lines = new string[0];
            this.txtContactNo.Location = new System.Drawing.Point(810, 65);
            this.txtContactNo.MaxLength = 32767;
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.PasswordChar = '\0';
            this.txtContactNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtContactNo.SelectedText = "";
            this.txtContactNo.SelectionLength = 0;
            this.txtContactNo.SelectionStart = 0;
            this.txtContactNo.Size = new System.Drawing.Size(191, 23);
            this.txtContactNo.TabIndex = 196;
            this.txtContactNo.UseSelectable = true;
            this.txtContactNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtContactNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtContactNo.Click += new System.EventHandler(this.txtContactNo_Click);
            // 
            // txtCity
            // 
            // 
            // 
            // 
            this.txtCity.CustomButton.Image = null;
            this.txtCity.CustomButton.Location = new System.Drawing.Point(146, 1);
            this.txtCity.CustomButton.Name = "";
            this.txtCity.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCity.CustomButton.TabIndex = 1;
            this.txtCity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCity.CustomButton.UseSelectable = true;
            this.txtCity.CustomButton.Visible = false;
            this.txtCity.Lines = new string[0];
            this.txtCity.Location = new System.Drawing.Point(476, 110);
            this.txtCity.MaxLength = 32767;
            this.txtCity.Name = "txtCity";
            this.txtCity.PasswordChar = '\0';
            this.txtCity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCity.SelectedText = "";
            this.txtCity.SelectionLength = 0;
            this.txtCity.SelectionStart = 0;
            this.txtCity.Size = new System.Drawing.Size(168, 23);
            this.txtCity.TabIndex = 192;
            this.txtCity.UseSelectable = true;
            this.txtCity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCity.Click += new System.EventHandler(this.txtCity_Click);
            // 
            // txtAddress
            // 
            // 
            // 
            // 
            this.txtAddress.CustomButton.Image = null;
            this.txtAddress.CustomButton.Location = new System.Drawing.Point(134, 1);
            this.txtAddress.CustomButton.Name = "";
            this.txtAddress.CustomButton.Size = new System.Drawing.Size(65, 65);
            this.txtAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddress.CustomButton.TabIndex = 1;
            this.txtAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddress.CustomButton.UseSelectable = true;
            this.txtAddress.CustomButton.Visible = false;
            this.txtAddress.Lines = new string[0];
            this.txtAddress.Location = new System.Drawing.Point(117, 96);
            this.txtAddress.MaxLength = 32767;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddress.SelectedText = "";
            this.txtAddress.SelectionLength = 0;
            this.txtAddress.SelectionStart = 0;
            this.txtAddress.Size = new System.Drawing.Size(200, 67);
            this.txtAddress.TabIndex = 193;
            this.txtAddress.UseSelectable = true;
            this.txtAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtAddress.Click += new System.EventHandler(this.txtAddress_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(685, 65);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(107, 19);
            this.metroLabel5.TabIndex = 191;
            this.metroLabel5.Text = "Contact Number";
            this.metroLabel5.Click += new System.EventHandler(this.metroLabel5_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(334, 109);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(31, 19);
            this.metroLabel6.TabIndex = 194;
            this.metroLabel6.Text = "City";
            this.metroLabel6.Click += new System.EventHandler(this.metroLabel6_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(6, 105);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(56, 19);
            this.metroLabel7.TabIndex = 195;
            this.metroLabel7.Text = "Address";
            this.metroLabel7.Click += new System.EventHandler(this.metroLabel7_Click);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(336, 190);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(111, 19);
            this.metroLabel11.TabIndex = 190;
            this.metroLabel11.Text = "Guardian Contact";
            this.metroLabel11.Click += new System.EventHandler(this.metroLabel11_Click);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(6, 186);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(102, 19);
            this.metroLabel10.TabIndex = 189;
            this.metroLabel10.Text = "Guardian Name";
            this.metroLabel10.Click += new System.EventHandler(this.metroLabel10_Click);
            // 
            // txtGuardianName
            // 
            // 
            // 
            // 
            this.txtGuardianName.CustomButton.Image = null;
            this.txtGuardianName.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtGuardianName.CustomButton.Name = "";
            this.txtGuardianName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtGuardianName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGuardianName.CustomButton.TabIndex = 1;
            this.txtGuardianName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGuardianName.CustomButton.UseSelectable = true;
            this.txtGuardianName.CustomButton.Visible = false;
            this.txtGuardianName.Lines = new string[0];
            this.txtGuardianName.Location = new System.Drawing.Point(117, 186);
            this.txtGuardianName.MaxLength = 32767;
            this.txtGuardianName.Name = "txtGuardianName";
            this.txtGuardianName.PasswordChar = '\0';
            this.txtGuardianName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGuardianName.SelectedText = "";
            this.txtGuardianName.SelectionLength = 0;
            this.txtGuardianName.SelectionStart = 0;
            this.txtGuardianName.Size = new System.Drawing.Size(200, 23);
            this.txtGuardianName.TabIndex = 188;
            this.txtGuardianName.UseSelectable = true;
            this.txtGuardianName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGuardianName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtGuardianName.Click += new System.EventHandler(this.txtGuardianName_Click);
            // 
            // txtGuardianContactNo
            // 
            // 
            // 
            // 
            this.txtGuardianContactNo.CustomButton.Image = null;
            this.txtGuardianContactNo.CustomButton.Location = new System.Drawing.Point(146, 1);
            this.txtGuardianContactNo.CustomButton.Name = "";
            this.txtGuardianContactNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtGuardianContactNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGuardianContactNo.CustomButton.TabIndex = 1;
            this.txtGuardianContactNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGuardianContactNo.CustomButton.UseSelectable = true;
            this.txtGuardianContactNo.CustomButton.Visible = false;
            this.txtGuardianContactNo.Lines = new string[0];
            this.txtGuardianContactNo.Location = new System.Drawing.Point(476, 186);
            this.txtGuardianContactNo.MaxLength = 32767;
            this.txtGuardianContactNo.Name = "txtGuardianContactNo";
            this.txtGuardianContactNo.PasswordChar = '\0';
            this.txtGuardianContactNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGuardianContactNo.SelectedText = "";
            this.txtGuardianContactNo.SelectionLength = 0;
            this.txtGuardianContactNo.SelectionStart = 0;
            this.txtGuardianContactNo.Size = new System.Drawing.Size(168, 23);
            this.txtGuardianContactNo.TabIndex = 187;
            this.txtGuardianContactNo.UseSelectable = true;
            this.txtGuardianContactNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGuardianContactNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtGuardianContactNo.Click += new System.EventHandler(this.txtGuardianContactNo_Click);
            // 
            // Religion
            // 
            this.Religion.AutoSize = true;
            this.Religion.Location = new System.Drawing.Point(685, 151);
            this.Religion.Name = "Religion";
            this.Religion.Size = new System.Drawing.Size(56, 19);
            this.Religion.TabIndex = 186;
            this.Religion.Text = "Religion";
            this.Religion.Click += new System.EventHandler(this.Religion_Click);
            // 
            // cmbReligion
            // 
            this.cmbReligion.FormattingEnabled = true;
            this.cmbReligion.ItemHeight = 23;
            this.cmbReligion.Items.AddRange(new object[] {
            "HINDUISM",
            "ISLAM ",
            "CHRISTIANITY",
            "BUDDHISM ",
            "JAINISM "});
            this.cmbReligion.Location = new System.Drawing.Point(810, 143);
            this.cmbReligion.Name = "cmbReligion";
            this.cmbReligion.Size = new System.Drawing.Size(191, 29);
            this.cmbReligion.TabIndex = 185;
            this.cmbReligion.UseSelectable = true;
            this.cmbReligion.SelectedIndexChanged += new System.EventHandler(this.cmbReligion_SelectedIndexChanged);
            // 
            // tNationality
            // 
            this.tNationality.AutoSize = true;
            this.tNationality.Location = new System.Drawing.Point(685, 108);
            this.tNationality.Name = "tNationality";
            this.tNationality.Size = new System.Drawing.Size(71, 19);
            this.tNationality.TabIndex = 184;
            this.tNationality.Text = "Nationality";
            this.tNationality.Click += new System.EventHandler(this.tNationality_Click);
            // 
            // txtNationality
            // 
            // 
            // 
            // 
            this.txtNationality.CustomButton.Image = null;
            this.txtNationality.CustomButton.Location = new System.Drawing.Point(169, 1);
            this.txtNationality.CustomButton.Name = "";
            this.txtNationality.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNationality.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNationality.CustomButton.TabIndex = 1;
            this.txtNationality.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNationality.CustomButton.UseSelectable = true;
            this.txtNationality.CustomButton.Visible = false;
            this.txtNationality.Lines = new string[0];
            this.txtNationality.Location = new System.Drawing.Point(810, 109);
            this.txtNationality.MaxLength = 32767;
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.PasswordChar = '\0';
            this.txtNationality.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNationality.SelectedText = "";
            this.txtNationality.SelectionLength = 0;
            this.txtNationality.SelectionStart = 0;
            this.txtNationality.Size = new System.Drawing.Size(191, 23);
            this.txtNationality.TabIndex = 183;
            this.txtNationality.UseSelectable = true;
            this.txtNationality.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNationality.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNationality.Click += new System.EventHandler(this.txtNationality_Click);
            // 
            // txtNic
            // 
            // 
            // 
            // 
            this.txtNic.CustomButton.Image = null;
            this.txtNic.CustomButton.Location = new System.Drawing.Point(146, 1);
            this.txtNic.CustomButton.Name = "";
            this.txtNic.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNic.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNic.CustomButton.TabIndex = 1;
            this.txtNic.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNic.CustomButton.UseSelectable = true;
            this.txtNic.CustomButton.Visible = false;
            this.txtNic.Lines = new string[0];
            this.txtNic.Location = new System.Drawing.Point(476, 149);
            this.txtNic.MaxLength = 32767;
            this.txtNic.Name = "txtNic";
            this.txtNic.PasswordChar = '\0';
            this.txtNic.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNic.SelectedText = "";
            this.txtNic.SelectionLength = 0;
            this.txtNic.SelectionStart = 0;
            this.txtNic.Size = new System.Drawing.Size(168, 23);
            this.txtNic.TabIndex = 178;
            this.txtNic.UseSelectable = true;
            this.txtNic.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNic.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNic.Click += new System.EventHandler(this.txtNic_Click);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(334, 148);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(74, 19);
            this.metroLabel9.TabIndex = 182;
            this.metroLabel9.Text = "National ID";
            this.metroLabel9.Click += new System.EventHandler(this.metroLabel9_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(334, 64);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(84, 19);
            this.metroLabel8.TabIndex = 176;
            this.metroLabel8.Text = "Date of Birth";
            this.metroLabel8.Click += new System.EventHandler(this.metroLabel8_Click);
            // 
            // dtDob
            // 
            this.dtDob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDob.Location = new System.Drawing.Point(476, 65);
            this.dtDob.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtDob.Name = "dtDob";
            this.dtDob.Size = new System.Drawing.Size(103, 29);
            this.dtDob.TabIndex = 175;
            this.dtDob.Value = new System.DateTime(2015, 11, 17, 0, 0, 0, 0);
            this.dtDob.ValueChanged += new System.EventHandler(this.dtDob_ValueChanged);
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Location = new System.Drawing.Point(893, 19);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(61, 15);
            this.rdFemale.TabIndex = 181;
            this.rdFemale.Text = "Female";
            this.rdFemale.UseSelectable = true;
            this.rdFemale.CheckedChanged += new System.EventHandler(this.rdFemale_CheckedChanged);
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Location = new System.Drawing.Point(810, 19);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(49, 15);
            this.rdMale.TabIndex = 180;
            this.rdMale.Text = "Male";
            this.rdMale.UseSelectable = true;
            this.rdMale.CheckedChanged += new System.EventHandler(this.rdMale_CheckedChanged);
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Location = new System.Drawing.Point(685, 15);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(52, 19);
            this.Gender.TabIndex = 179;
            this.Gender.Text = "Gender";
            this.Gender.Click += new System.EventHandler(this.Gender_Click);
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(117, 57);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.Size = new System.Drawing.Size(200, 23);
            this.txtName.TabIndex = 174;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtName.Click += new System.EventHandler(this.txtName_Click);
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
            this.dataGridView1.Size = new System.Drawing.Size(1026, 206);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(506, 109);
            this.progress.Maximum = 100;
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(20, 38);
            this.progress.Style = MetroFramework.MetroColorStyle.Lime;
            this.progress.TabIndex = 93;
            this.progress.UseSelectable = true;
            this.progress.Click += new System.EventHandler(this.progress_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progress);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(20, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1032, 225);
            this.groupBox1.TabIndex = 92;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnUpdate.Image = global::School_Management_ERP.Properties.Resources.update24__2_;
            this.btnUpdate.ImageSize = 32;
            this.btnUpdate.Location = new System.Drawing.Point(854, 28);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.NoFocusImage = global::School_Management_ERP.Properties.Resources.update241;
            this.btnUpdate.Size = new System.Drawing.Size(48, 42);
            this.btnUpdate.TabIndex = 179;
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDelete.Image = global::School_Management_ERP.Properties.Resources.garbage12__1_;
            this.btnDelete.ImageSize = 32;
            this.btnDelete.Location = new System.Drawing.Point(929, 28);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.NoFocusImage = global::School_Management_ERP.Properties.Resources.garbage12;
            this.btnDelete.Size = new System.Drawing.Size(48, 42);
            this.btnDelete.TabIndex = 178;
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lnkClose
            // 
            this.lnkClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.lnkClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.lnkClose.Image = ((System.Drawing.Image)(resources.GetObject("lnkClose.Image")));
            this.lnkClose.ImageSize = 32;
            this.lnkClose.Location = new System.Drawing.Point(1004, 28);
            this.lnkClose.Name = "lnkClose";
            this.lnkClose.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lnkClose.NoFocusImage")));
            this.lnkClose.Size = new System.Drawing.Size(48, 42);
            this.lnkClose.TabIndex = 177;
            this.lnkClose.UseSelectable = true;
            this.lnkClose.Click += new System.EventHandler(this.lnkClose_Click);
            // 
            // StudentDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 615);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lnkClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.datePickerBox);
            this.Controls.Add(this.cmbSearch);
            this.Controls.Add(this.txtSearch);
            this.Name = "StudentDetail";
            this.Text = "Student Details";
            this.Load += new System.EventHandler(this.StudentDetail_Load);
            this.Shown += new System.EventHandler(this.StudentDetail_Shown);
            this.datePickerBox.ResumeLayout(false);
            this.datePickerBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox datePickerBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime toDate;
        private MetroFramework.Controls.MetroDateTime fromDate;
        private MetroFramework.Controls.MetroComboBox cmbSearch;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTextBox txtContactNo;
        private MetroFramework.Controls.MetroTextBox txtCity;
        private MetroFramework.Controls.MetroTextBox txtAddress;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox txtGuardianName;
        private MetroFramework.Controls.MetroTextBox txtGuardianContactNo;
        private MetroFramework.Controls.MetroLabel Religion;
        private MetroFramework.Controls.MetroComboBox cmbReligion;
        private MetroFramework.Controls.MetroLabel tNationality;
        private MetroFramework.Controls.MetroTextBox txtNationality;
        private MetroFramework.Controls.MetroTextBox txtNic;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroDateTime dtDob;
        private MetroFramework.Controls.MetroRadioButton rdFemale;
        private MetroFramework.Controls.MetroRadioButton rdMale;
        private MetroFramework.Controls.MetroLabel Gender;
       
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroLink btnUpdate;
        private MetroFramework.Controls.MetroLink btnDelete;
        private MetroFramework.Controls.MetroLink lnkClose;
        private MetroFramework.Controls.MetroDateTime dtDateOfAdmission;
        private MetroFramework.Controls.MetroTextBox txtAdmissionNo;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroGrid dataGridView1;
        private MetroFramework.Controls.MetroProgressSpinner progress;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}