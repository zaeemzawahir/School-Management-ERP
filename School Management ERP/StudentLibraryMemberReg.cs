using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using System.Drawing;


namespace School_Management_ERP
{
    public partial class frmStudentMemReg :MetroForm 
    {
        private SqlConnection conn = null;
        private DBConnection cs = new DBConnection();
        string value;

        public frmStudentMemReg()
        {
            InitializeComponent();
        }  
        

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            registerMember();
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            memberUpdate();
        }

        private void Clear()
        {
            txtAddress.Clear();
            txtAdmissionNo.Clear();
            txtContactNo.Clear();
            txtName.Clear();
            txtSearchField.Clear();
            rdFemale.Checked = false;
            rdMale.Checked = false;
            lblStatus.Visible = false;
            btnLocked.Enabled = false;
            btnUnlock.Enabled=false;
            btnRegister.Enabled = true;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnRegister.Enabled = false;
            
            try

            {
                //initialize data grid view selected cell index
                int i;
                i = dataGridView1.SelectedCells[0].RowIndex;

                txtAdmissionNo.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                txtName.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                value = dataGridView1.Rows[i].Cells[2].Value.ToString();
                if (value == rdMale.Text)
                {
                    rdMale.Checked = true;
                }
                else
                {
                    rdFemale.Checked = true;
                }
                txtAddress.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                txtContactNo.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                lblStatus.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();

                lblStatus.Visible = true;
                if (lblStatus.Text == "Active")
                {
                    btnLocked.Enabled = true;
                }
                else if (lblStatus.Text == "Inactive")
                {
                    btnUnlock.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridData()
        {
            try
            {
                conn = new SqlConnection(cs.DBconn);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand("LibraryStudentSearch", conn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable bookData = new DataTable();
                da.Fill(bookData);
                dataGridView1.DataSource = bookData;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void LibraryMemberReg_Load(object sender, EventArgs e)
        {
            btnLocked.Enabled = false;
            btnUnlock.Enabled = false;
            gridData();
           
        }

        private void registerMember()
        {
            try
            {
                conn = new SqlConnection(cs.DBconn);
                conn.Open();
                SqlCommand cmd = new SqlCommand("Insert into libStudentMember(StudentID,MemberShipStatus) values (@StudentID,@MemberShipStatus)", conn);
                cmd.Parameters.Add("@StudentID", SqlDbType.Char).Value = txtAdmissionNo.Text.Trim();
                cmd.Parameters.Add("@MemberShipStatus", SqlDbType.VarChar).Value = "Active";

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

        //-
        private void search()
        {
            if (txtSearchField.Text.Length==5)
            {
                conn = new SqlConnection(cs.DBconn);
                conn.Open();
                SqlCommand cmd = new SqlCommand("LibraryMemeberReg", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@StudentID", SqlDbType.Char).Value = txtSearchField.Text.Trim();
                SqlDataReader dreader = cmd.ExecuteReader();
                if (dreader.HasRows == true)
                {
                   
                    while (dreader.Read())
                    {
                        txtAdmissionNo.Text = dreader["Student ID"].ToString();
                        txtName.Text = dreader["Name"].ToString();
                        txtContactNo.Text = dreader["Telephone"].ToString();
                        value = dreader["Gender"].ToString();
                        if (value == rdMale.Text)
                        {
                            rdMale.Checked = true;
                        }
                        else
                        {
                            rdFemale.Checked = true;
                        }
                        txtAddress.Text = dreader["Address"].ToString();

                        if (dreader["MemberShipStatus"] == DBNull.Value)
                        {
                            btnRegister.Visible = true;
                            btnLocked.Enabled = false;
                            btnUnlock.Enabled = false;
                            lblStatus.Visible = false;
                            lblStatus.Text = "Active";
                        }
                        else
                        {
                            lblStatus.Text = dreader["MemberShipStatus"].ToString();
                            btnRegister.Enabled = false;
                            
                            lblStatus.Visible = true;
                            if (lblStatus.Text == "Active")
                            {
                                btnLocked.Enabled = true;
                                btnLocked.Focus();
                            }
                            else if (lblStatus.Text == "Inactive")
                            {
                                btnUnlock.Enabled = true;
                                btnUnlock.Focus();
                            }
                        }
                    }

                    dreader.Close();
                }
            }
        }

     

        //-----
        private void txtSearchField_GotFocus(object sender, EventArgs e)
        {
            btnRegister.Visible = true;
            btnLocked.Enabled = false;
            btnUnlock.Enabled = false;
            Clear();
        }

        private void txtSearchField_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void memberUpdate()
        {
            try
            {
                string Status;
                if (btnUnlock.Enabled==true)
                {
                    Status = "Active";
                    if (txtAdmissionNo.Text == "")
                    {
                        MessageBox.Show("Select a record from the table by double clicking on it", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        conn = new SqlConnection(cs.DBconn);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("updateLibStudentMember", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@StudentID", SqlDbType.Char).Value = txtAdmissionNo.Text.Trim();
                        cmd.Parameters.Add("@MemberShipStatus", SqlDbType.Char).Value = Status.Trim();

                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                        gridData();
                        Clear();
                    }
                }
                else if (btnLocked.Enabled==true)
                {
                    Status = "Inactive";
                    if (txtAdmissionNo.Text == "")
                    {
                        MessageBox.Show("Select a record from the table by double clicking on it", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        conn = new SqlConnection(cs.DBconn);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("updateLibStudentMember", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@StudentID", SqlDbType.Char).Value = txtAdmissionNo.Text.Trim();
                        cmd.Parameters.Add("@MemberShipStatus", SqlDbType.Char).Value = Status.Trim();

                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                        gridData();
                        Clear();
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

    

        private void lnkClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearchField_Click(object sender, EventArgs e)
        {

        }

      
    }
}