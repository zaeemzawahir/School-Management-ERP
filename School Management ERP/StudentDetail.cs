using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace School_Management_ERP
{
    public partial class StudentDetail : MetroForm
    {
        DBConnection cs = new DBConnection();
        SqlConnection conn = null;


        public StudentDetail()
        {
            InitializeComponent();

            timer1.Interval = 300 * 1;              // Timer will tick every second
            timer1.Enabled = true;
        }

        private void StudentDetail_Load(object sender, EventArgs e)
        {
            datePickerBox.Visible = false;

        }

        private void StudentDetail_Shown(object sender, EventArgs e)
        {

            timer1.Start();


        }


        //Loading infromation into gridview
        private void gridData()
        {
            try
            {
                conn = new SqlConnection(cs.DBconn);
                conn.Open();
                SqlDataAdapter book = new SqlDataAdapter("Select StudentID as 'Student ID',DateofAdmission AS 'Date of Admission',Name,Gender,DOB as 'Date of Birth', Address, City, NIC AS 'National ID',ContactNo as 'Telephone',Nationality,Religion,guardianName AS 'Guardian Name' ,guardianContact as 'Guardian''s Telephone', olAdmissionNo AS 'O/L Admission', olYear as 'O/L Year' from Student", conn);
                DataTable studentData = new DataTable();
                book.Fill(studentData);
                dataGridView1.DataSource = studentData;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }




         private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;


            if (cmbSearch.Text == "Student ID")
            {
                bs.Filter = "[Student ID] like '%" + txtSearch.Text + "%'";
                dataGridView1.DataSource = bs;
            }
            else if (cmbSearch.Text == "Name")
            {
                bs.Filter = "Name like '%" + txtSearch.Text + "%'";
                dataGridView1.DataSource = bs;
            }
            else if (cmbSearch.Text == "Guardian Name")
            {
                bs.Filter = "[Guardian Name] like '%" + txtSearch.Text + "%'";
                dataGridView1.DataSource = bs;
            }
            else if (cmbSearch.Text == "City")
            {
                bs.Filter = "City like '%" + txtSearch.Text + "%'";
                dataGridView1.DataSource = bs;
            }
            else if (cmbSearch.Text == "National Identity")
            {
                bs.Filter = "[National ID] like '%" + txtSearch.Text + "%'";
                dataGridView1.DataSource = bs;
            }

        }

        //Search Function Codes


        //Displaying date picker when Date of Admission is Selected
       private void cmbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSearch.Text == "Date of Admission")
            {
                datePickerBox.Visible = true;
                txtSearch.Visible = false;
            }
            else if ((cmbSearch.Text == "") || (cmbSearch.Text != "Date of Admission"))
            {
                datePickerBox.Visible = false;
                txtSearch.Visible = true;
            }
        }
        // filter data in gridview according to date
        private void fromDate_ValueChnged(object sender, EventArgs e)
        {
            try
            {
                dateSearch();
            }
            catch (Exception)
            {

                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progress.Visible = false;
            gridData();
            timer1.Stop();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string value = "";
                //initialize data grid view selected cell index
                int i;
                i = dataGridView1.SelectedCells[0].RowIndex;

                txtAdmissionNo.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                dtDateOfAdmission.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                txtName.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                value = dataGridView1.Rows[i].Cells[3].Value.ToString();
                if (value == rdMale.Text)
                {
                    rdMale.Checked = true;
                }
                else
                {
                    rdFemale.Checked = true;
                }
                dtDob.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                txtAddress.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
                txtCity.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
                txtNic.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
                txtContactNo.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
                txtNationality.Text = dataGridView1.Rows[i].Cells[9].Value.ToString();
                cmbReligion.Text = dataGridView1.Rows[i].Cells[10].Value.ToString();
                txtGuardianName.Text = dataGridView1.Rows[i].Cells[11].Value.ToString();
                txtGuardianContactNo.Text = dataGridView1.Rows[i].Cells[12].Value.ToString();
            }
            catch
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


      

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            validate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteRecord();
        }

        private void studentUpdate()
        {

            try
            { 
                 conn = new SqlConnection(cs.DBconn);
                conn.Open();

                string value = "";
                bool isChecked = rdMale.Checked;
                if (isChecked)
                {
                    value = rdMale.Text.Trim(); ;
                }
                else
                {
                    value = rdFemale.Text.Trim(); ;
                }

               
                SqlCommand cmd = new SqlCommand("UPDATE [dbo].Student SET StudentID=@StudentID,[Name]=@Name,DateofAdmission=@DateofAdmission,Gender=@Gender,DOB=@DOB,Address=@Address," +
                "City=@City,NIC=@NIC,ContactNo=@ContactNo,Nationality=@Nationality,Religion=@Religion,guardianName=@guardianName,guardianContact=@guardianContact WHERE StudentID=@StudentID", conn);
                cmd.Parameters.Add("@StudentID", SqlDbType.Char).Value = txtAdmissionNo.Text.Trim();
                cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = txtName.Text.Trim();
                cmd.Parameters.Add("@DateofAdmission", SqlDbType.Date).Value = dtDateOfAdmission.Text.Trim();
                cmd.Parameters.Add("@Gender", SqlDbType.VarChar).Value = value;
                cmd.Parameters.Add("@DOB", SqlDbType.Date).Value = dtDob.Text.Trim();
                cmd.Parameters.Add("@City", SqlDbType.VarChar).Value = txtCity.Text.Trim();
                cmd.Parameters.Add("@Address", SqlDbType.VarChar).Value = txtAddress.Text.Trim();
                cmd.Parameters.Add("@NIC", SqlDbType.VarChar).Value = txtNic.Text.Trim();
                cmd.Parameters.Add("@ContactNo", SqlDbType.VarChar).Value = txtContactNo.Text.Trim();
                cmd.Parameters.Add("@Nationality", SqlDbType.VarChar).Value = txtNationality.Text.Trim();
                cmd.Parameters.Add("@Religion", SqlDbType.VarChar).Value = cmbReligion.Text.Trim();
                cmd.Parameters.Add("@guardianName", SqlDbType.VarChar).Value = txtGuardianName.Text.Trim();
                cmd.Parameters.Add("@guardianContact", SqlDbType.VarChar).Value = txtGuardianContactNo.Text.Trim();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                gridData();
                MetroMessageBox.Show(this,"Zaeem");

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        private void validate()
        {
            if (txtContactNo.Text != "")
            {
                if (txtContactNo.Text.Length < 10 || txtContactNo.Text.Length > 16)
                {
                    MetroMessageBox.Show(this, "Contact Number should be between 10 to 16 digits", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if (txtNic.Text != "")
            {
                Regex pattern = new Regex(@"^[0-9]{9}[vVxX]");
                if (pattern.IsMatch(txtNic.Text))
                {
                    studentUpdate();
                }
                else if (pattern.IsMatch(txtNic.Text) == false)
                {
                    MetroMessageBox.Show(this, "Input format error. Please enter using correct NIC number format", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }


            }

            else
            {
                studentUpdate();
            }
        }

        private void deleteRecord()
        {
            conn = new SqlConnection(cs.DBconn);
            conn.Open();
            if (txtAdmissionNo.Text == "")
            {
                MetroMessageBox.Show(this, "No records selected. Double click on the record you need to delete first", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Delete From Student Where [StudentID]=@StudentID", conn);
                    cmd.Parameters.Add("@StudentID", SqlDbType.Char).Value = txtAdmissionNo.Text.Trim();
                    if (DialogResult.Yes == MetroMessageBox.Show(this, "Are sure you want to delete Student belonging to Student ID " + txtAdmissionNo.Text.ToString() + "'", "Confirm action", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        cmd.ExecuteNonQuery();
                        gridData();
                    }
                    else
                    {
                        dataGridView1.Focus();
                    }
                }
                catch
                {
                    MetroMessageBox.Show(this, "No records found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                finally
                {
                    conn.Close();
                }
            }
        }
        private void dateSearch()
        {
           
                BindingSource bs = new BindingSource();
                bs.DataSource = dataGridView1.DataSource;
                bs.Filter = "[Date of Admission] >= '" + fromDate.Value.ToShortDateString() + "' AND [Date of Admission] <= '" + toDate.Value.ToShortDateString() + "'";
                dataGridView1.DataSource = bs;
            
           
        }

        private void fromDate_ValueChanged(object sender, EventArgs e)
        {

            try
            {
                dateSearch();
            }
            catch (Exception)
            {

                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void Religion_Click(object sender, EventArgs e)
        {

        }

        private void txtAddress_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtGuardianContactNo_Click(object sender, EventArgs e)
        {

        }

        private void lnkClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void datePickerBox_Enter(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_Click(object sender, EventArgs e)
        {

        }

        private void dtDateOfAdmission_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtAdmissionNo_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel12_Click(object sender, EventArgs e)
        {

        }

        private void txtContactNo_Click(object sender, EventArgs e)
        {

        }

        private void txtCity_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel11_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel10_Click(object sender, EventArgs e)
        {

        }

        private void txtGuardianName_Click(object sender, EventArgs e)
        {

        }

        private void cmbReligion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tNationality_Click(object sender, EventArgs e)
        {

        }

        private void txtNationality_Click(object sender, EventArgs e)
        {

        }

        private void txtNic_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel9_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel8_Click(object sender, EventArgs e)
        {

        }

        private void dtDob_ValueChanged(object sender, EventArgs e)
        {

        }

        private void rdFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Gender_Click(object sender, EventArgs e)
        {

        }

        private void txtName_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void progress_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

    }
}

