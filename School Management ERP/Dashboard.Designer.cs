namespace School_Management_ERP
{
    partial class Dashboard
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
            this.button1 = new System.Windows.Forms.Button();
            this.Books = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Lend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 69);
            this.button1.TabIndex = 0;
            this.button1.Text = "Attendance";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Books
            // 
            this.Books.Location = new System.Drawing.Point(27, 172);
            this.Books.Name = "Books";
            this.Books.Size = new System.Drawing.Size(153, 69);
            this.Books.TabIndex = 1;
            this.Books.Text = "Book";
            this.Books.UseVisualStyleBackColor = true;
            this.Books.Click += new System.EventHandler(this.Books_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Library";
            // 
            // Lend
            // 
            this.Lend.Location = new System.Drawing.Point(232, 172);
            this.Lend.Name = "Lend";
            this.Lend.Size = new System.Drawing.Size(153, 69);
            this.Lend.TabIndex = 3;
            this.Lend.Text = "Lend";
            this.Lend.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 406);
            this.Controls.Add(this.Lend);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Books);
            this.Controls.Add(this.button1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Books;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Lend;
    }
}