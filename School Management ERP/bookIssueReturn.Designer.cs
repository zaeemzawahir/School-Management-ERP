namespace School_Management_ERP
{
    partial class bookIssueReturn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bookIssueReturn));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlEmployee = new MetroFramework.Controls.MetroPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEmpID = new MetroFramework.Controls.MetroTextBox();
            this.txtEmpName = new MetroFramework.Controls.MetroTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBookID = new MetroFramework.Controls.MetroTextBox();
            this.txtAuthor = new MetroFramework.Controls.MetroTextBox();
            this.txtTitle = new MetroFramework.Controls.MetroTextBox();
            this.txtStudentID = new MetroFramework.Controls.MetroTextBox();
            this.txtStudentName = new MetroFramework.Controls.MetroTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblToday = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnIssue = new MetroFramework.Controls.MetroButton();
            this.btnReturn = new MetroFramework.Controls.MetroButton();
            this.btnChangeDueDate = new MetroFramework.Controls.MetroButton();
            this.txtDays = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lblIssueDate = new MetroFramework.Controls.MetroLabel();
            this.lblDueDate = new MetroFramework.Controls.MetroLabel();
            this.fineHeader = new MetroFramework.Controls.MetroLabel();
            this.lblFine = new MetroFramework.Controls.MetroLabel();
            this.lblRenewHeader = new MetroFramework.Controls.MetroLabel();
            this.lblRenewal = new MetroFramework.Controls.MetroLabel();
            this.txtSearchStudent = new MetroFramework.Controls.MetroTextBox();
            this.txtSearchBook = new MetroFramework.Controls.MetroTextBox();
            this.lblLkr = new MetroFramework.Controls.MetroLabel();
            this.txtEmpSearchID = new MetroFramework.Controls.MetroTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEmployee = new MetroFramework.Controls.MetroLink();
            this.btnStudent = new MetroFramework.Controls.MetroLink();
            this.lnkClose = new MetroFramework.Controls.MetroLink();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.pnlEmpSearch = new MetroFramework.Controls.MetroPanel();
            this.groupBox1.SuspendLayout();
            this.pnlEmployee.SuspendLayout();
            this.pnlEmpSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnlEmployee);
            this.groupBox1.Controls.Add(this.txtBookID);
            this.groupBox1.Controls.Add(this.txtAuthor);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.txtStudentID);
            this.groupBox1.Controls.Add(this.txtStudentName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblAuthor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(56, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 221);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // pnlEmployee
            // 
            this.pnlEmployee.Controls.Add(this.label11);
            this.pnlEmployee.Controls.Add(this.txtEmpID);
            this.pnlEmployee.Controls.Add(this.txtEmpName);
            this.pnlEmployee.Controls.Add(this.label6);
            this.pnlEmployee.HorizontalScrollbarBarColor = true;
            this.pnlEmployee.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlEmployee.HorizontalScrollbarSize = 10;
            this.pnlEmployee.Location = new System.Drawing.Point(7, 76);
            this.pnlEmployee.Name = "pnlEmployee";
            this.pnlEmployee.Size = new System.Drawing.Size(518, 41);
            this.pnlEmployee.TabIndex = 97;
            this.pnlEmployee.VerticalScrollbarBarColor = true;
            this.pnlEmployee.VerticalScrollbarHighlightOnWheel = false;
            this.pnlEmployee.VerticalScrollbarSize = 10;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label11.Location = new System.Drawing.Point(204, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 17);
            this.label11.TabIndex = 98;
            this.label11.Text = "Employee Name";
            // 
            // txtEmpID
            // 
            // 
            // 
            // 
            this.txtEmpID.CustomButton.Image = null;
            this.txtEmpID.CustomButton.Location = new System.Drawing.Point(80, 1);
            this.txtEmpID.CustomButton.Name = "";
            this.txtEmpID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmpID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmpID.CustomButton.TabIndex = 1;
            this.txtEmpID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmpID.CustomButton.UseSelectable = true;
            this.txtEmpID.CustomButton.Visible = false;
            this.txtEmpID.Enabled = false;
            this.txtEmpID.Lines = new string[0];
            this.txtEmpID.Location = new System.Drawing.Point(96, 6);
            this.txtEmpID.MaxLength = 32767;
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.PasswordChar = '\0';
            this.txtEmpID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmpID.SelectedText = "";
            this.txtEmpID.SelectionLength = 0;
            this.txtEmpID.SelectionStart = 0;
            this.txtEmpID.Size = new System.Drawing.Size(102, 23);
            this.txtEmpID.TabIndex = 97;
            this.txtEmpID.UseSelectable = true;
            this.txtEmpID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmpID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtEmpName
            // 
            // 
            // 
            // 
            this.txtEmpName.CustomButton.Image = null;
            this.txtEmpName.CustomButton.Location = new System.Drawing.Point(187, 1);
            this.txtEmpName.CustomButton.Name = "";
            this.txtEmpName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmpName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmpName.CustomButton.TabIndex = 1;
            this.txtEmpName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmpName.CustomButton.UseSelectable = true;
            this.txtEmpName.CustomButton.Visible = false;
            this.txtEmpName.Enabled = false;
            this.txtEmpName.Lines = new string[0];
            this.txtEmpName.Location = new System.Drawing.Point(309, 6);
            this.txtEmpName.MaxLength = 32767;
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.PasswordChar = '\0';
            this.txtEmpName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmpName.SelectedText = "";
            this.txtEmpName.SelectionLength = 0;
            this.txtEmpName.SelectionStart = 0;
            this.txtEmpName.Size = new System.Drawing.Size(209, 23);
            this.txtEmpName.TabIndex = 96;
            this.txtEmpName.UseSelectable = true;
            this.txtEmpName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmpName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(4, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 95;
            this.label6.Text = "Employee ID";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtBookID
            // 
            // 
            // 
            // 
            this.txtBookID.CustomButton.Image = null;
            this.txtBookID.CustomButton.Location = new System.Drawing.Point(400, 1);
            this.txtBookID.CustomButton.Name = "";
            this.txtBookID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBookID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBookID.CustomButton.TabIndex = 1;
            this.txtBookID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBookID.CustomButton.UseSelectable = true;
            this.txtBookID.CustomButton.Visible = false;
            this.txtBookID.Enabled = false;
            this.txtBookID.Lines = new string[0];
            this.txtBookID.Location = new System.Drawing.Point(103, 29);
            this.txtBookID.MaxLength = 32767;
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.PasswordChar = '\0';
            this.txtBookID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBookID.SelectedText = "";
            this.txtBookID.SelectionLength = 0;
            this.txtBookID.SelectionStart = 0;
            this.txtBookID.Size = new System.Drawing.Size(422, 23);
            this.txtBookID.TabIndex = 96;
            this.txtBookID.UseSelectable = true;
            this.txtBookID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBookID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtBookID.TextChanged += new System.EventHandler(this.txtBookID_TextChanged);
            // 
            // txtAuthor
            // 
            // 
            // 
            // 
            this.txtAuthor.CustomButton.Image = null;
            this.txtAuthor.CustomButton.Location = new System.Drawing.Point(400, 1);
            this.txtAuthor.CustomButton.Name = "";
            this.txtAuthor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAuthor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAuthor.CustomButton.TabIndex = 1;
            this.txtAuthor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAuthor.CustomButton.UseSelectable = true;
            this.txtAuthor.CustomButton.Visible = false;
            this.txtAuthor.Enabled = false;
            this.txtAuthor.Lines = new string[0];
            this.txtAuthor.Location = new System.Drawing.Point(102, 171);
            this.txtAuthor.MaxLength = 32767;
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.PasswordChar = '\0';
            this.txtAuthor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAuthor.SelectedText = "";
            this.txtAuthor.SelectionLength = 0;
            this.txtAuthor.SelectionStart = 0;
            this.txtAuthor.Size = new System.Drawing.Size(422, 23);
            this.txtAuthor.TabIndex = 95;
            this.txtAuthor.UseSelectable = true;
            this.txtAuthor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAuthor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTitle
            // 
            // 
            // 
            // 
            this.txtTitle.CustomButton.Image = null;
            this.txtTitle.CustomButton.Location = new System.Drawing.Point(400, 1);
            this.txtTitle.CustomButton.Name = "";
            this.txtTitle.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTitle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTitle.CustomButton.TabIndex = 1;
            this.txtTitle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTitle.CustomButton.UseSelectable = true;
            this.txtTitle.CustomButton.Visible = false;
            this.txtTitle.Enabled = false;
            this.txtTitle.Lines = new string[0];
            this.txtTitle.Location = new System.Drawing.Point(102, 124);
            this.txtTitle.MaxLength = 32767;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.PasswordChar = '\0';
            this.txtTitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTitle.SelectedText = "";
            this.txtTitle.SelectionLength = 0;
            this.txtTitle.SelectionStart = 0;
            this.txtTitle.Size = new System.Drawing.Size(422, 23);
            this.txtTitle.TabIndex = 94;
            this.txtTitle.UseSelectable = true;
            this.txtTitle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTitle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtStudentID
            // 
            // 
            // 
            // 
            this.txtStudentID.CustomButton.Image = null;
            this.txtStudentID.CustomButton.Location = new System.Drawing.Point(80, 1);
            this.txtStudentID.CustomButton.Name = "";
            this.txtStudentID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtStudentID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStudentID.CustomButton.TabIndex = 1;
            this.txtStudentID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStudentID.CustomButton.UseSelectable = true;
            this.txtStudentID.CustomButton.Visible = false;
            this.txtStudentID.Enabled = false;
            this.txtStudentID.Lines = new string[0];
            this.txtStudentID.Location = new System.Drawing.Point(103, 79);
            this.txtStudentID.MaxLength = 32767;
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.PasswordChar = '\0';
            this.txtStudentID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStudentID.SelectedText = "";
            this.txtStudentID.SelectionLength = 0;
            this.txtStudentID.SelectionStart = 0;
            this.txtStudentID.Size = new System.Drawing.Size(102, 23);
            this.txtStudentID.TabIndex = 93;
            this.txtStudentID.UseSelectable = true;
            this.txtStudentID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStudentID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtStudentName
            // 
            // 
            // 
            // 
            this.txtStudentName.CustomButton.Image = null;
            this.txtStudentName.CustomButton.Location = new System.Drawing.Point(187, 1);
            this.txtStudentName.CustomButton.Name = "";
            this.txtStudentName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtStudentName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStudentName.CustomButton.TabIndex = 1;
            this.txtStudentName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStudentName.CustomButton.UseSelectable = true;
            this.txtStudentName.CustomButton.Visible = false;
            this.txtStudentName.Enabled = false;
            this.txtStudentName.Lines = new string[0];
            this.txtStudentName.Location = new System.Drawing.Point(316, 79);
            this.txtStudentName.MaxLength = 32767;
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.PasswordChar = '\0';
            this.txtStudentName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStudentName.SelectedText = "";
            this.txtStudentName.SelectionLength = 0;
            this.txtStudentName.SelectionStart = 0;
            this.txtStudentName.Size = new System.Drawing.Size(209, 23);
            this.txtStudentName.TabIndex = 92;
            this.txtStudentName.UseSelectable = true;
            this.txtStudentName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStudentName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(11, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 91;
            this.label5.Text = "Book ID";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(11, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 89;
            this.label1.Text = "Student ID";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblAuthor.Location = new System.Drawing.Point(11, 177);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(47, 17);
            this.lblAuthor.TabIndex = 90;
            this.lblAuthor.Text = "Author";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(211, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 85;
            this.label2.Text = "Student Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label10.Location = new System.Drawing.Point(11, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 17);
            this.label10.TabIndex = 84;
            this.label10.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(405, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 88;
            this.label3.Text = "Book ID";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(66, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 93;
            this.label4.Text = "Student ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(55, 400);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 20);
            this.label8.TabIndex = 101;
            this.label8.Text = "Days Issued for";
            // 
            // lblToday
            // 
            this.lblToday.AutoSize = true;
            this.lblToday.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToday.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblToday.Location = new System.Drawing.Point(551, 38);
            this.lblToday.Name = "lblToday";
            this.lblToday.Size = new System.Drawing.Size(47, 18);
            this.lblToday.TabIndex = 104;
            this.lblToday.Text = "Today";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label9.Location = new System.Drawing.Point(471, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 18);
            this.label9.TabIndex = 110;
            this.label9.Text = "Today";
            // 
            // btnIssue
            // 
            this.btnIssue.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnIssue.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnIssue.Location = new System.Drawing.Point(232, 449);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(88, 43);
            this.btnIssue.TabIndex = 6;
            this.btnIssue.Text = "Issue";
            this.btnIssue.UseSelectable = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnReturn.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnReturn.Location = new System.Drawing.Point(336, 449);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(88, 43);
            this.btnReturn.TabIndex = 112;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseSelectable = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnChangeDueDate
            // 
            this.btnChangeDueDate.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnChangeDueDate.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnChangeDueDate.Location = new System.Drawing.Point(303, 397);
            this.btnChangeDueDate.Name = "btnChangeDueDate";
            this.btnChangeDueDate.Size = new System.Drawing.Size(121, 26);
            this.btnChangeDueDate.TabIndex = 5;
            this.btnChangeDueDate.Text = "Change Due Date";
            this.btnChangeDueDate.UseSelectable = true;
            this.btnChangeDueDate.Click += new System.EventHandler(this.btnChangeDueDate_Click);
            // 
            // txtDays
            // 
            // 
            // 
            // 
            this.txtDays.CustomButton.Image = null;
            this.txtDays.CustomButton.Location = new System.Drawing.Point(43, 1);
            this.txtDays.CustomButton.Name = "";
            this.txtDays.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDays.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDays.CustomButton.TabIndex = 1;
            this.txtDays.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDays.CustomButton.UseSelectable = true;
            this.txtDays.CustomButton.Visible = false;
            this.txtDays.Lines = new string[0];
            this.txtDays.Location = new System.Drawing.Point(232, 399);
            this.txtDays.MaxLength = 32767;
            this.txtDays.Name = "txtDays";
            this.txtDays.PasswordChar = '\0';
            this.txtDays.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDays.SelectedText = "";
            this.txtDays.SelectionLength = 0;
            this.txtDays.SelectionStart = 0;
            this.txtDays.Size = new System.Drawing.Size(65, 23);
            this.txtDays.TabIndex = 4;
            this.txtDays.UseSelectable = true;
            this.txtDays.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDays.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(58, 361);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(67, 19);
            this.metroLabel1.TabIndex = 114;
            this.metroLabel1.Text = "Issue Date";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(280, 361);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(63, 19);
            this.metroLabel2.TabIndex = 115;
            this.metroLabel2.Text = "Due Date";
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Location = new System.Drawing.Point(139, 361);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(53, 19);
            this.lblIssueDate.TabIndex = 116;
            this.lblIssueDate.Text = "Isssued ";
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Location = new System.Drawing.Point(351, 361);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(32, 19);
            this.lblDueDate.TabIndex = 117;
            this.lblDueDate.Text = "Due";
            // 
            // fineHeader
            // 
            this.fineHeader.AutoSize = true;
            this.fineHeader.Location = new System.Drawing.Point(447, 361);
            this.fineHeader.Name = "fineHeader";
            this.fineHeader.Size = new System.Drawing.Size(33, 19);
            this.fineHeader.TabIndex = 118;
            this.fineHeader.Text = "Fine";
            // 
            // lblFine
            // 
            this.lblFine.AutoSize = true;
            this.lblFine.Location = new System.Drawing.Point(525, 361);
            this.lblFine.Name = "lblFine";
            this.lblFine.Size = new System.Drawing.Size(13, 19);
            this.lblFine.TabIndex = 119;
            this.lblFine.Text = " ";
            // 
            // lblRenewHeader
            // 
            this.lblRenewHeader.AutoSize = true;
            this.lblRenewHeader.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblRenewHeader.Location = new System.Drawing.Point(465, 404);
            this.lblRenewHeader.Name = "lblRenewHeader";
            this.lblRenewHeader.Size = new System.Drawing.Size(69, 19);
            this.lblRenewHeader.Style = MetroFramework.MetroColorStyle.Black;
            this.lblRenewHeader.TabIndex = 120;
            this.lblRenewHeader.Text = "Renew Till";
            // 
            // lblRenewal
            // 
            this.lblRenewal.AutoSize = true;
            this.lblRenewal.Location = new System.Drawing.Point(545, 404);
            this.lblRenewal.Name = "lblRenewal";
            this.lblRenewal.Size = new System.Drawing.Size(36, 19);
            this.lblRenewal.TabIndex = 121;
            this.lblRenewal.Text = "Date";
            // 
            // txtSearchStudent
            // 
            // 
            // 
            // 
            this.txtSearchStudent.CustomButton.Image = null;
            this.txtSearchStudent.CustomButton.Location = new System.Drawing.Point(80, 1);
            this.txtSearchStudent.CustomButton.Name = "";
            this.txtSearchStudent.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearchStudent.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchStudent.CustomButton.TabIndex = 1;
            this.txtSearchStudent.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchStudent.CustomButton.UseSelectable = true;
            this.txtSearchStudent.CustomButton.Visible = false;
            this.txtSearchStudent.Lines = new string[0];
            this.txtSearchStudent.Location = new System.Drawing.Point(159, 95);
            this.txtSearchStudent.MaxLength = 5;
            this.txtSearchStudent.Name = "txtSearchStudent";
            this.txtSearchStudent.PasswordChar = '\0';
            this.txtSearchStudent.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchStudent.SelectedText = "";
            this.txtSearchStudent.SelectionLength = 0;
            this.txtSearchStudent.SelectionStart = 0;
            this.txtSearchStudent.Size = new System.Drawing.Size(102, 23);
            this.txtSearchStudent.TabIndex = 0;
            this.txtSearchStudent.UseSelectable = true;
            this.txtSearchStudent.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchStudent.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearchStudent.TextChanged += new System.EventHandler(this.txtSearchStudent_TextChanged);
            // 
            // txtSearchBook
            // 
            // 
            // 
            // 
            this.txtSearchBook.CustomButton.Image = null;
            this.txtSearchBook.CustomButton.Location = new System.Drawing.Point(80, 1);
            this.txtSearchBook.CustomButton.Name = "";
            this.txtSearchBook.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearchBook.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchBook.CustomButton.TabIndex = 1;
            this.txtSearchBook.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchBook.CustomButton.UseSelectable = true;
            this.txtSearchBook.CustomButton.Visible = false;
            this.txtSearchBook.Lines = new string[0];
            this.txtSearchBook.Location = new System.Drawing.Point(496, 96);
            this.txtSearchBook.MaxLength = 5;
            this.txtSearchBook.Name = "txtSearchBook";
            this.txtSearchBook.PasswordChar = '\0';
            this.txtSearchBook.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchBook.SelectedText = "";
            this.txtSearchBook.SelectionLength = 0;
            this.txtSearchBook.SelectionStart = 0;
            this.txtSearchBook.Size = new System.Drawing.Size(102, 23);
            this.txtSearchBook.TabIndex = 2;
            this.txtSearchBook.UseSelectable = true;
            this.txtSearchBook.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchBook.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearchBook.TextChanged += new System.EventHandler(this.txtSearchBook_TextChanged);
            // 
            // lblLkr
            // 
            this.lblLkr.AutoSize = true;
            this.lblLkr.Location = new System.Drawing.Point(486, 361);
            this.lblLkr.Name = "lblLkr";
            this.lblLkr.Size = new System.Drawing.Size(33, 19);
            this.lblLkr.TabIndex = 123;
            this.lblLkr.Text = "LKR.";
            // 
            // txtEmpSearchID
            // 
            // 
            // 
            // 
            this.txtEmpSearchID.CustomButton.Image = null;
            this.txtEmpSearchID.CustomButton.Location = new System.Drawing.Point(80, 1);
            this.txtEmpSearchID.CustomButton.Name = "";
            this.txtEmpSearchID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmpSearchID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmpSearchID.CustomButton.TabIndex = 1;
            this.txtEmpSearchID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmpSearchID.CustomButton.UseSelectable = true;
            this.txtEmpSearchID.CustomButton.Visible = false;
            this.txtEmpSearchID.Lines = new string[0];
            this.txtEmpSearchID.Location = new System.Drawing.Point(96, 6);
            this.txtEmpSearchID.MaxLength = 5;
            this.txtEmpSearchID.Name = "txtEmpSearchID";
            this.txtEmpSearchID.PasswordChar = '\0';
            this.txtEmpSearchID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmpSearchID.SelectedText = "";
            this.txtEmpSearchID.SelectionLength = 0;
            this.txtEmpSearchID.SelectionStart = 0;
            this.txtEmpSearchID.Size = new System.Drawing.Size(102, 23);
            this.txtEmpSearchID.TabIndex = 1;
            this.txtEmpSearchID.UseSelectable = true;
            this.txtEmpSearchID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmpSearchID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmpSearchID.TextChanged += new System.EventHandler(this.txtEmpSearchID_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label7.Location = new System.Drawing.Point(9, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 17);
            this.label7.TabIndex = 95;
            this.label7.Text = "Employee ID";
            // 
            // btnEmployee
            // 
            this.btnEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEmployee.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEmployee.Image = global::School_Management_ERP.Properties.Resources.school84;
            this.btnEmployee.ImageSize = 32;
            this.btnEmployee.Location = new System.Drawing.Point(698, 99);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.NoFocusImage = global::School_Management_ERP.Properties.Resources.school84__1_;
            this.btnEmployee.Size = new System.Drawing.Size(67, 82);
            this.btnEmployee.TabIndex = 180;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmployee.UseSelectable = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStudent.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnStudent.Image = global::School_Management_ERP.Properties.Resources.graduate11__2_;
            this.btnStudent.ImageSize = 32;
            this.btnStudent.Location = new System.Drawing.Point(625, 99);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.NoFocusImage = global::School_Management_ERP.Properties.Resources.graduate11__1_;
            this.btnStudent.Size = new System.Drawing.Size(67, 82);
            this.btnStudent.TabIndex = 179;
            this.btnStudent.Text = "Student";
            this.btnStudent.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStudent.UseSelectable = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // lnkClose
            // 
            this.lnkClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.lnkClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.lnkClose.Image = ((System.Drawing.Image)(resources.GetObject("lnkClose.Image")));
            this.lnkClose.ImageSize = 32;
            this.lnkClose.Location = new System.Drawing.Point(797, 8);
            this.lnkClose.Name = "lnkClose";
            this.lnkClose.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lnkClose.NoFocusImage")));
            this.lnkClose.Size = new System.Drawing.Size(42, 39);
            this.lnkClose.TabIndex = 178;
            this.lnkClose.UseSelectable = true;
            this.lnkClose.Click += new System.EventHandler(this.lnkClose_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(640, 88);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(110, 25);
            this.metroLabel3.TabIndex = 182;
            this.metroLabel3.Text = "Select Mode";
            // 
            // pnlEmpSearch
            // 
            this.pnlEmpSearch.Controls.Add(this.txtEmpSearchID);
            this.pnlEmpSearch.Controls.Add(this.label7);
            this.pnlEmpSearch.HorizontalScrollbarBarColor = true;
            this.pnlEmpSearch.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlEmpSearch.HorizontalScrollbarSize = 10;
            this.pnlEmpSearch.Location = new System.Drawing.Point(59, 88);
            this.pnlEmpSearch.Name = "pnlEmpSearch";
            this.pnlEmpSearch.Size = new System.Drawing.Size(267, 35);
            this.pnlEmpSearch.TabIndex = 183;
            this.pnlEmpSearch.VerticalScrollbarBarColor = true;
            this.pnlEmpSearch.VerticalScrollbarHighlightOnWheel = false;
            this.pnlEmpSearch.VerticalScrollbarSize = 10;
            // 
            // bookIssueReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 531);
            this.Controls.Add(this.pnlEmpSearch);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.btnEmployee);
            this.Controls.Add(this.btnStudent);
            this.Controls.Add(this.lnkClose);
            this.Controls.Add(this.lblLkr);
            this.Controls.Add(this.txtSearchBook);
            this.Controls.Add(this.txtSearchStudent);
            this.Controls.Add(this.lblRenewal);
            this.Controls.Add(this.lblRenewHeader);
            this.Controls.Add(this.lblFine);
            this.Controls.Add(this.fineHeader);
            this.Controls.Add(this.lblDueDate);
            this.Controls.Add(this.lblIssueDate);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.btnChangeDueDate);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblToday);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Name = "bookIssueReturn";
            this.Text = "Issue / Return";
            this.Load += new System.EventHandler(this.bookIssueReturn_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlEmployee.ResumeLayout(false);
            this.pnlEmployee.PerformLayout();
            this.pnlEmpSearch.ResumeLayout(false);
            this.pnlEmpSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblToday;
        private System.Windows.Forms.Label label9;
        private MetroFramework.Controls.MetroTextBox txtStudentName;
        private MetroFramework.Controls.MetroTextBox txtBookID;
        private MetroFramework.Controls.MetroTextBox txtAuthor;
        private MetroFramework.Controls.MetroTextBox txtTitle;
        private MetroFramework.Controls.MetroTextBox txtStudentID;
        private MetroFramework.Controls.MetroButton btnIssue;
        private MetroFramework.Controls.MetroButton btnReturn;
        private MetroFramework.Controls.MetroButton btnChangeDueDate;
        private MetroFramework.Controls.MetroTextBox txtDays;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel lblIssueDate;
        private MetroFramework.Controls.MetroLabel lblDueDate;
        private MetroFramework.Controls.MetroLabel fineHeader;
        private MetroFramework.Controls.MetroLabel lblFine;
        private MetroFramework.Controls.MetroLabel lblRenewHeader;
        private MetroFramework.Controls.MetroLabel lblRenewal;
        private MetroFramework.Controls.MetroTextBox txtSearchStudent;
        private MetroFramework.Controls.MetroTextBox txtSearchBook;
        private MetroFramework.Controls.MetroLabel lblLkr;
        private MetroFramework.Controls.MetroPanel pnlEmployee;
        private MetroFramework.Controls.MetroTextBox txtEmpID;
        private MetroFramework.Controls.MetroTextBox txtEmpName;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroTextBox txtEmpSearchID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private MetroFramework.Controls.MetroLink btnStudent;
        private MetroFramework.Controls.MetroLink lnkClose;
        private MetroFramework.Controls.MetroLink btnEmployee;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroPanel pnlEmpSearch;

    }
}