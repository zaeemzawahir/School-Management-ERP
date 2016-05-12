using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace School_Management_ERP
{
    public partial class EmployeeDetails : MetroForm
    {
        private DBConnection cs = new DBConnection();
        private SqlConnection conn = null;

        public EmployeeDetails()
        {
            InitializeComponent();
        }

        private void EmployeeDetails_Load(object sender, EventArgs e)
        {
            datePickerBox.Visible = false;

            gridData();
            if (GlobalAccess.AccessLevel == "Management Staff")
            {
                cmbCategory.Items.Remove("Principal");
            }
        }

        private void Clear()
        {
            txtAddress.Clear();
            txtCity.Clear();
            txtEmail.Clear();
            txtEmployeeID.Clear();
            txtLandline.Clear();
            txtName.Clear();
            txtNic.Clear();
            txtEmployeeID.Clear();
            txtMobile.Clear();
            cmbDepartment.SelectedIndex = -1;
            cmbDepartment.SelectedIndex = -1;
            rdFemale.Checked = false;
            rdMale.Checked = false;
            txtName.Focus();
        }

        private void gridData()
        {
            conn = new SqlConnection(cs.DBconn);
            try
            {
                conn.Open();
                SqlDataAdapter book = new SqlDataAdapter("EmployeeSelect", conn);

                DataTable employeeData = new DataTable();
                book.Fill(employeeData);
                dataGridView1.DataSource = employeeData;
               

            }
            catch
            {
            }
            finally
            {
                conn.Close();
            }
        }

        private void deleteRecord()
        {
            try
            {
                conn = new SqlConnection(cs.DBconn);
                conn.Open();
                if (txtEmployeeID.Text == "")
                {
                    MetroMessageBox.Show(this, "No records selected. Double click on the record you need to delete first", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("Delete From Employee Where [EmpID]=@EmpID", conn);
                    cmd.Parameters.Add("@EmpID", SqlDbType.Char).Value = txtEmployeeID.Text.Trim();
                    if (DialogResult.Yes == MetroMessageBox.Show(this, "Are sure you want to delete Employee belonging to Employee ID " + txtEmployeeID.Text.ToString() + "'", "Confirm action", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        cmd.ExecuteNonQuery();
                        gridData();
                    }
                    else
                    {
                        dataGridView1.Focus();
                    }
                }
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

        private void employeeUpdate()

        {
            conn = new SqlConnection(cs.DBconn);
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE [dbo].Employee SET EmpID=@EmpID,NIC=@NIC,[Name]=@Name,Address=@Address,City=@City,Gender=@Gender,DOB=@DOB," +
                   "Landline=@Landline,Mobile=@Mobile,dateJoined=@dateJoined,highestQualification=@highestQualification,Category=@Category,Email=@Email,Department=@Department WHERE EmpID=@EmpID", conn);

                string value = "";
                bool isChecked = rdMale.Checked;
                if (isChecked)
                {
                    value = rdMale.Text;
                }
                else
                {
                    value = rdFemale.Text;
                }

                cmd.Parameters.Add("@EmpID", SqlDbType.Char).Value = txtEmployeeID.Text.Trim();
                cmd.Parameters.Add("@NIC", SqlDbType.Char).Value = txtNic.Text.Trim();
                cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = txtName.Text.Trim();
                cmd.Parameters.Add("@Address", SqlDbType.VarChar).Value = txtAddress.Text.Trim();
                cmd.Parameters.Add("@City", SqlDbType.VarChar).Value = txtCity.Text.Trim();
                cmd.Parameters.Add("@Gender", SqlDbType.VarChar).Value = value;
                cmd.Parameters.Add("@DOB", SqlDbType.Date).Value = dtDob.Text.Trim();
                cmd.Parameters.Add("@Landline", SqlDbType.VarChar).Value = txtLandline.Text.Trim();
                cmd.Parameters.Add("@Mobile", SqlDbType.VarChar).Value = txtMobile.Text.Trim();
                cmd.Parameters.Add("@dateJoined", SqlDbType.Date).Value = dtJoin.Text.Trim();
                cmd.Parameters.Add("@highestQualification", SqlDbType.VarChar).Value = txtEducation.Text.Trim();
                cmd.Parameters.Add("@Category", SqlDbType.VarChar).Value = cmbCategory.Text.Trim();
                cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = txtEmail.Text.Trim();
                cmd.Parameters.Add("@Department", SqlDbType.VarChar).Value = cmbDepartment.Text.Trim();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                gridData();
         
                Clear();
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            string value;
            i = dataGridView1.SelectedCells[0].RowIndex;

            txtEmployeeID.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtNic.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtName.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtAddress.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtCity.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            value = dataGridView1.Rows[i].Cells[5].Value.ToString();
               if (value == rdMale.Text)
               {
               rdMale.Checked = true;
               }
               else
               {
               rdFemale.Checked = true;
               }
               dtDob.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
               txtLandline.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
               txtMobile.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
               dtJoin.Text = dataGridView1.Rows[i].Cells[9].Value.ToString();
               txtEducation.Text = dataGridView1.Rows[i].Cells[10].Value.ToString();
               cmbCategory.Text = dataGridView1.Rows[i].Cells[11].Value.ToString();
               txtEmail.Text = dataGridView1.Rows[i].Cells[12].Value.ToString();
               cmbDepartment.Text = dataGridView1.Rows[i].Cells[13].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            employeeUpdate();
        }

        private void lnkClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteRecord();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
            this.dataGridView1.Rows[e.RowIndex].Selected = true;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;


         if (cmbSearch.Text == "Employee ID")
            {
                bs.Filter = "[Employee ID] like '%" + txtSearch.Text + "%'";
                dataGridView1.DataSource = bs;
            }
            else if (cmbSearch.Text == "Department")
            {
                bs.Filter = "[Department] like '%" + txtSearch.Text + "%'";
                dataGridView1.DataSource = bs;
            }
          
            else if (cmbSearch.Text == "National Identity")
            {
                bs.Filter = "[National ID] like '%" + txtSearch.Text + "%'";
                dataGridView1.DataSource = bs;
            }

        }

        private void dateSearch()
        {

            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = "[Date of Admission] >= '" + fromDate.Value.ToShortDateString() + "' AND [Date of Admission] <= '" + toDate.Value.ToShortDateString() + "'";
            dataGridView1.DataSource = bs;


        }


        private void cmbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fromDate_ValueChanged(object sender, EventArgs e)
        {
            dateSearch();
        
        }
    }
}