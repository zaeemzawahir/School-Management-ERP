namespace School_Management_ERP
{
    partial class Add_Items
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Items));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtItemID = new MetroFramework.Controls.MetroTextBox();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.cmbCategory = new MetroFramework.Controls.MetroComboBox();
            this.btnSave = new MetroFramework.Controls.MetroLink();
            this.lnkClose = new MetroFramework.Controls.MetroLink();
            this.cmbLocation = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(46, 79);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(51, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Item ID";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(46, 115);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(45, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Name";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(46, 152);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(121, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Resource Category";
            // 
            // txtItemID
            // 
            // 
            // 
            // 
            this.txtItemID.CustomButton.Image = null;
            this.txtItemID.CustomButton.Location = new System.Drawing.Point(119, 1);
            this.txtItemID.CustomButton.Name = "";
            this.txtItemID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtItemID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtItemID.CustomButton.TabIndex = 1;
            this.txtItemID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtItemID.CustomButton.UseSelectable = true;
            this.txtItemID.CustomButton.Visible = false;
            this.txtItemID.Lines = new string[0];
            this.txtItemID.Location = new System.Drawing.Point(216, 75);
            this.txtItemID.MaxLength = 32767;
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.PasswordChar = '\0';
            this.txtItemID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtItemID.SelectedText = "";
            this.txtItemID.SelectionLength = 0;
            this.txtItemID.SelectionStart = 0;
            this.txtItemID.Size = new System.Drawing.Size(141, 23);
            this.txtItemID.TabIndex = 3;
            this.txtItemID.UseSelectable = true;
            this.txtItemID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtItemID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(119, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(216, 112);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.Size = new System.Drawing.Size(141, 23);
            this.txtName.TabIndex = 4;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtName.GotFocus += new System.EventHandler(this.txtName_GotFocus);
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.ItemHeight = 23;
            this.cmbCategory.Location = new System.Drawing.Point(216, 153);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(141, 29);
            this.cmbCategory.TabIndex = 5;
            this.cmbCategory.UseSelectable = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Image = global::School_Management_ERP.Properties.Resources.save8;
            this.btnSave.ImageSize = 32;
            this.btnSave.Location = new System.Drawing.Point(371, 15);
            this.btnSave.Name = "btnSave";
            this.btnSave.NoFocusImage = global::School_Management_ERP.Properties.Resources.Save_No_Focus;
            this.btnSave.Size = new System.Drawing.Size(42, 39);
            this.btnSave.TabIndex = 185;
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
            this.lnkClose.Location = new System.Drawing.Point(436, 15);
            this.lnkClose.Name = "lnkClose";
            this.lnkClose.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lnkClose.NoFocusImage")));
            this.lnkClose.Size = new System.Drawing.Size(42, 39);
            this.lnkClose.TabIndex = 186;
            this.lnkClose.UseSelectable = true;
            this.lnkClose.Click += new System.EventHandler(this.lnkClose_Click);
            // 
            // cmbLocation
            // 
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.ItemHeight = 23;
            this.cmbLocation.Location = new System.Drawing.Point(216, 199);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(141, 29);
            this.cmbLocation.TabIndex = 188;
            this.cmbLocation.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(46, 200);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(58, 19);
            this.metroLabel4.TabIndex = 187;
            this.metroLabel4.Text = "Location";
            // 
            // Add_Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 239);
            this.Controls.Add(this.cmbLocation);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.lnkClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtItemID);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Add_Items";
            this.Text = "Add_Items";
            this.Load += new System.EventHandler(this.Add_Items_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtItemID;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroComboBox cmbCategory;
        private MetroFramework.Controls.MetroLink btnSave;
        private MetroFramework.Controls.MetroLink lnkClose;
        private MetroFramework.Controls.MetroComboBox cmbLocation;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}