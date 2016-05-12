namespace School_Management_ERP
{
    partial class frmStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudent));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtDateOfAdmission = new MetroFramework.Controls.MetroDateTime();
            this.txtAdmissionNo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnSave = new MetroFramework.Controls.MetroLink();
            this.lnkClose = new MetroFramework.Controls.MetroLink();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.metroLabel1);
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
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(23, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(925, 287);
            this.groupBox2.TabIndex = 164;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personal Infromation";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(28, 25);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 19);
            this.metroLabel1.TabIndex = 197;
            this.metroLabel1.Text = "Name";
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
            this.txtContactNo.Lines = new string[0];
            this.txtContactNo.Location = new System.Drawing.Point(582, 180);
            this.txtContactNo.MaxLength = 32767;
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.PasswordChar = '\0';
            this.txtContactNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtContactNo.SelectedText = "";
            this.txtContactNo.SelectionLength = 0;
            this.txtContactNo.SelectionStart = 0;
            this.txtContactNo.Size = new System.Drawing.Size(217, 23);
            this.txtContactNo.TabIndex = 10;
            this.txtContactNo.UseSelectable = true;
            this.txtContactNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtContactNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCity
            // 
            // 
            // 
            // 
            this.txtCity.CustomButton.Image = null;
            this.txtCity.CustomButton.Location = new System.Drawing.Point(195, 1);
            this.txtCity.CustomButton.Name = "";
            this.txtCity.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCity.CustomButton.TabIndex = 1;
            this.txtCity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCity.CustomButton.UseSelectable = true;
            this.txtCity.CustomButton.Visible = false;
            this.txtCity.Lines = new string[0];
            this.txtCity.Location = new System.Drawing.Point(582, 141);
            this.txtCity.MaxLength = 32767;
            this.txtCity.Name = "txtCity";
            this.txtCity.PasswordChar = '\0';
            this.txtCity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCity.SelectedText = "";
            this.txtCity.SelectionLength = 0;
            this.txtCity.SelectionStart = 0;
            this.txtCity.Size = new System.Drawing.Size(217, 23);
            this.txtCity.TabIndex = 9;
            this.txtCity.UseSelectable = true;
            this.txtCity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAddress
            // 
            // 
            // 
            // 
            this.txtAddress.CustomButton.Image = null;
            this.txtAddress.CustomButton.Location = new System.Drawing.Point(149, 2);
            this.txtAddress.CustomButton.Name = "";
            this.txtAddress.CustomButton.Size = new System.Drawing.Size(65, 65);
            this.txtAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddress.CustomButton.TabIndex = 1;
            this.txtAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddress.CustomButton.UseSelectable = true;
            this.txtAddress.CustomButton.Visible = false;
            this.txtAddress.Lines = new string[0];
            this.txtAddress.Location = new System.Drawing.Point(181, 141);
            this.txtAddress.MaxLength = 32767;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddress.SelectedText = "";
            this.txtAddress.SelectionLength = 0;
            this.txtAddress.SelectionStart = 0;
            this.txtAddress.Size = new System.Drawing.Size(217, 70);
            this.txtAddress.TabIndex = 8;
            this.txtAddress.UseSelectable = true;
            this.txtAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(426, 182);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(107, 19);
            this.metroLabel5.TabIndex = 191;
            this.metroLabel5.Text = "Contact Number";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(426, 143);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(31, 19);
            this.metroLabel6.TabIndex = 194;
            this.metroLabel6.Text = "City";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(28, 148);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(56, 19);
            this.metroLabel7.TabIndex = 195;
            this.metroLabel7.Text = "Address";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(426, 221);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(111, 19);
            this.metroLabel11.TabIndex = 190;
            this.metroLabel11.Text = "Guardian Contact";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(28, 223);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(102, 19);
            this.metroLabel10.TabIndex = 189;
            this.metroLabel10.Text = "Guardian Name";
            // 
            // txtGuardianName
            // 
            // 
            // 
            // 
            this.txtGuardianName.CustomButton.Image = null;
            this.txtGuardianName.CustomButton.Location = new System.Drawing.Point(195, 1);
            this.txtGuardianName.CustomButton.Name = "";
            this.txtGuardianName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtGuardianName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGuardianName.CustomButton.TabIndex = 1;
            this.txtGuardianName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGuardianName.CustomButton.UseSelectable = true;
            this.txtGuardianName.CustomButton.Visible = false;
            this.txtGuardianName.Lines = new string[0];
            this.txtGuardianName.Location = new System.Drawing.Point(181, 221);
            this.txtGuardianName.MaxLength = 32767;
            this.txtGuardianName.Name = "txtGuardianName";
            this.txtGuardianName.PasswordChar = '\0';
            this.txtGuardianName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGuardianName.SelectedText = "";
            this.txtGuardianName.SelectionLength = 0;
            this.txtGuardianName.SelectionStart = 0;
            this.txtGuardianName.Size = new System.Drawing.Size(217, 23);
            this.txtGuardianName.TabIndex = 11;
            this.txtGuardianName.UseSelectable = true;
            this.txtGuardianName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGuardianName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtGuardianContactNo
            // 
            // 
            // 
            // 
            this.txtGuardianContactNo.CustomButton.Image = null;
            this.txtGuardianContactNo.CustomButton.Location = new System.Drawing.Point(195, 1);
            this.txtGuardianContactNo.CustomButton.Name = "";
            this.txtGuardianContactNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtGuardianContactNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGuardianContactNo.CustomButton.TabIndex = 1;
            this.txtGuardianContactNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGuardianContactNo.CustomButton.UseSelectable = true;
            this.txtGuardianContactNo.CustomButton.Visible = false;
            this.txtGuardianContactNo.Lines = new string[0];
            this.txtGuardianContactNo.Location = new System.Drawing.Point(582, 219);
            this.txtGuardianContactNo.MaxLength = 32767;
            this.txtGuardianContactNo.Name = "txtGuardianContactNo";
            this.txtGuardianContactNo.PasswordChar = '\0';
            this.txtGuardianContactNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGuardianContactNo.SelectedText = "";
            this.txtGuardianContactNo.SelectionLength = 0;
            this.txtGuardianContactNo.SelectionStart = 0;
            this.txtGuardianContactNo.Size = new System.Drawing.Size(217, 23);
            this.txtGuardianContactNo.TabIndex = 12;
            this.txtGuardianContactNo.UseSelectable = true;
            this.txtGuardianContactNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGuardianContactNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Religion
            // 
            this.Religion.AutoSize = true;
            this.Religion.Location = new System.Drawing.Point(28, 107);
            this.Religion.Name = "Religion";
            this.Religion.Size = new System.Drawing.Size(56, 19);
            this.Religion.TabIndex = 186;
            this.Religion.Text = "Religion";
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
            this.cmbReligion.Location = new System.Drawing.Point(181, 102);
            this.cmbReligion.Name = "cmbReligion";
            this.cmbReligion.Size = new System.Drawing.Size(217, 29);
            this.cmbReligion.TabIndex = 6;
            this.cmbReligion.UseSelectable = true;
            // 
            // tNationality
            // 
            this.tNationality.AutoSize = true;
            this.tNationality.Location = new System.Drawing.Point(426, 104);
            this.tNationality.Name = "tNationality";
            this.tNationality.Size = new System.Drawing.Size(71, 19);
            this.tNationality.TabIndex = 184;
            this.tNationality.Text = "Nationality";
            // 
            // txtNationality
            // 
            // 
            // 
            // 
            this.txtNationality.CustomButton.Image = null;
            this.txtNationality.CustomButton.Location = new System.Drawing.Point(195, 1);
            this.txtNationality.CustomButton.Name = "";
            this.txtNationality.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNationality.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNationality.CustomButton.TabIndex = 1;
            this.txtNationality.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNationality.CustomButton.UseSelectable = true;
            this.txtNationality.CustomButton.Visible = false;
            this.txtNationality.Lines = new string[0];
            this.txtNationality.Location = new System.Drawing.Point(582, 102);
            this.txtNationality.MaxLength = 32767;
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.PasswordChar = '\0';
            this.txtNationality.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNationality.SelectedText = "";
            this.txtNationality.SelectionLength = 0;
            this.txtNationality.SelectionStart = 0;
            this.txtNationality.Size = new System.Drawing.Size(217, 23);
            this.txtNationality.TabIndex = 7;
            this.txtNationality.UseSelectable = true;
            this.txtNationality.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNationality.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNic
            // 
            // 
            // 
            // 
            this.txtNic.CustomButton.Image = null;
            this.txtNic.CustomButton.Location = new System.Drawing.Point(195, 1);
            this.txtNic.CustomButton.Name = "";
            this.txtNic.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNic.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNic.CustomButton.TabIndex = 1;
            this.txtNic.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNic.CustomButton.UseSelectable = true;
            this.txtNic.CustomButton.Visible = false;
            this.txtNic.Lines = new string[0];
            this.txtNic.Location = new System.Drawing.Point(582, 63);
            this.txtNic.MaxLength = 32767;
            this.txtNic.Name = "txtNic";
            this.txtNic.PasswordChar = '\0';
            this.txtNic.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNic.SelectedText = "";
            this.txtNic.SelectionLength = 0;
            this.txtNic.SelectionStart = 0;
            this.txtNic.Size = new System.Drawing.Size(217, 23);
            this.txtNic.TabIndex = 5;
            this.txtNic.UseSelectable = true;
            this.txtNic.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNic.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(426, 65);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(74, 19);
            this.metroLabel9.TabIndex = 182;
            this.metroLabel9.Text = "National ID";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(426, 23);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(84, 19);
            this.metroLabel8.TabIndex = 176;
            this.metroLabel8.Text = "Date of Birth";
            // 
            // dtDob
            // 
            this.dtDob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDob.Location = new System.Drawing.Point(582, 18);
            this.dtDob.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtDob.Name = "dtDob";
            this.dtDob.Size = new System.Drawing.Size(103, 29);
            this.dtDob.TabIndex = 2;
            this.dtDob.Value = new System.DateTime(2015, 11, 17, 0, 0, 0, 0);
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Location = new System.Drawing.Point(260, 63);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(61, 15);
            this.rdFemale.TabIndex = 4;
            this.rdFemale.Text = "Female";
            this.rdFemale.UseSelectable = true;
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Location = new System.Drawing.Point(181, 63);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(49, 15);
            this.rdMale.TabIndex = 3;
            this.rdMale.Text = "Male";
            this.rdMale.UseSelectable = true;
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Location = new System.Drawing.Point(28, 61);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(52, 19);
            this.Gender.TabIndex = 179;
            this.Gender.Text = "Gender";
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
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(181, 18);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.Size = new System.Drawing.Size(217, 23);
            this.txtName.TabIndex = 1;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtName.Enter += new System.EventHandler(this.txtName_GotFocus);
            this.txtName.GotFocus += new System.EventHandler(this.txtName_GotFocus);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtDateOfAdmission);
            this.groupBox3.Controls.Add(this.txtAdmissionNo);
            this.groupBox3.Controls.Add(this.metroLabel4);
            this.groupBox3.Controls.Add(this.metroLabel3);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(23, 84);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(925, 41);
            this.groupBox3.TabIndex = 163;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Official Information";
            // 
            // dtDateOfAdmission
            // 
            this.dtDateOfAdmission.Enabled = false;
            this.dtDateOfAdmission.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDateOfAdmission.Location = new System.Drawing.Point(582, 13);
            this.dtDateOfAdmission.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtDateOfAdmission.Name = "dtDateOfAdmission";
            this.dtDateOfAdmission.Size = new System.Drawing.Size(103, 29);
            this.dtDateOfAdmission.TabIndex = 85;
            this.dtDateOfAdmission.Value = new System.DateTime(2015, 11, 17, 0, 0, 0, 0);
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
            this.txtAdmissionNo.Location = new System.Drawing.Point(181, 13);
            this.txtAdmissionNo.MaxLength = 32767;
            this.txtAdmissionNo.Name = "txtAdmissionNo";
            this.txtAdmissionNo.PasswordChar = '\0';
            this.txtAdmissionNo.ReadOnly = true;
            this.txtAdmissionNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAdmissionNo.SelectedText = "";
            this.txtAdmissionNo.SelectionLength = 0;
            this.txtAdmissionNo.SelectionStart = 0;
            this.txtAdmissionNo.Size = new System.Drawing.Size(135, 23);
            this.txtAdmissionNo.TabIndex = 200;
            this.txtAdmissionNo.UseSelectable = true;
            this.txtAdmissionNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAdmissionNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(426, 18);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(116, 19);
            this.metroLabel4.TabIndex = 1;
            this.metroLabel4.Text = "Date of Admission";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(28, 15);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(69, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Student ID";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Image = global::School_Management_ERP.Properties.Resources.save8;
            this.btnSave.ImageSize = 32;
            this.btnSave.Location = new System.Drawing.Point(842, 24);
            this.btnSave.Name = "btnSave";
            this.btnSave.NoFocusImage = global::School_Management_ERP.Properties.Resources.Save_No_Focus;
            this.btnSave.Size = new System.Drawing.Size(42, 39);
            this.btnSave.TabIndex = 179;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lnkClose
            // 
            this.lnkClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.lnkClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.lnkClose.Image = ((System.Drawing.Image)(resources.GetObject("lnkClose.Image")));
            this.lnkClose.ImageSize = 32;
            this.lnkClose.Location = new System.Drawing.Point(906, 24);
            this.lnkClose.Name = "lnkClose";
            this.lnkClose.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lnkClose.NoFocusImage")));
            this.lnkClose.Size = new System.Drawing.Size(42, 39);
            this.lnkClose.TabIndex = 178;
            this.lnkClose.UseSelectable = true;
            this.lnkClose.Click += new System.EventHandler(this.lnkClose_Click);
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 446);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lnkClose);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmStudent";
            this.Resizable = false;
            this.Text = "Enroll Student";
            this.Load += new System.EventHandler(this.frmStudent_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroDateTime dtDateOfAdmission;
        private MetroFramework.Controls.MetroTextBox txtAdmissionNo;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLink btnSave;
        private MetroFramework.Controls.MetroLink lnkClose;
        private MetroFramework.Controls.MetroLabel metroLabel1;


    }
}