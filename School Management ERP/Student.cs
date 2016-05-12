using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using System.Text.RegularExpressions;
namespace School_Management_ERP
{
    public partial class frmStudent : MetroForm
    {
        private DBConnection cs = new DBConnection();
        private SqlConnection conn = null;

        public frmStudent()
        {
            InitializeComponent();
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {

            txtName.Focus();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
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
                   
                  if (pattern.IsMatch(txtNic.Text) == false)
                    {
                        MetroMessageBox.Show(this, "Input format error. Please enter using correct NIC number format", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }


                }

                else
                {
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
                    conn = new SqlConnection(cs.DBconn);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Insert into Student(StudentID,Name,DateofAdmission,Gender,DOB,Address,City,NIC,ContactNo,Nationality,Religion,guardianName,guardianContact) values (@StudentID,@Name,@DateofAdmission,@Gender,@DOB,@City,@Address,@NIC,@ContactNo,@Nationality,@Religion,@guardianName,@guardianContact)", conn);
                    cmd.Parameters.Add("@StudentID", SqlDbType.Char).Value = txtAdmissionNo.Text.Trim();
                    cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = txtName.Text.Trim();
                    cmd.Parameters.Add("@DateofAdmission", SqlDbType.Date).Value = dtDateOfAdmission.Text.Trim();
                    cmd.Parameters.Add("@Gender", SqlDbType.VarChar).Value = value;
                    cmd.Parameters.Add("@DOB", SqlDbType.Date).Value = dtDob.Text.Trim();
                    cmd.Parameters.Add("@Address", SqlDbType.VarChar).Value = txtAddress.Text.Trim();

                    cmd.Parameters.Add("@City", SqlDbType.VarChar).Value = txtAddress.Text.Trim();
                    cmd.Parameters.Add("@NIC", SqlDbType.VarChar).Value = txtNic.Text.Trim();
                    cmd.Parameters.Add("@ContactNo", SqlDbType.VarChar).Value = txtContactNo.Text.Trim();
                    cmd.Parameters.Add("@Nationality", SqlDbType.VarChar).Value = txtNationality.Text.Trim();
                    cmd.Parameters.Add("@Religion", SqlDbType.VarChar).Value = cmbReligion.Text.Trim();
                    cmd.Parameters.Add("@guardianName", SqlDbType.VarChar).Value = txtGuardianName.Text.Trim();
                    cmd.Parameters.Add("@guardianContact", SqlDbType.VarChar).Value = txtGuardianContactNo.Text.Trim();
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    Clear();
                    MetroMessageBox.Show(this, "Student information saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void Clear()
        {
            txtName.Clear();
            txtAddress.Clear();
            txtContactNo.Clear();
            txtCity.Clear();
            txtGuardianContactNo.Clear();
            txtGuardianName.Clear();
            txtNationality.Clear();
            txtNic.Clear();
            dtDateOfAdmission.Value = DateTime.Now.Date;
            dtDob.Value = DateTime.Now.Date;
            txtName.Focus();
        }

        private void txtName_GotFocus(object sender, EventArgs e)
        {
            newID();
        }

        private void newID()
        {
            try
            {
                int ID;
            
                conn = new SqlConnection(cs.DBconn);
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT TOP 1 StudentID FROM  Student ORDER BY StudentID DESC", conn);
                SqlDataReader dreader = cmd.ExecuteReader();
                
                if (dreader.Read())
                {                
                string val = dreader["StudentID"].ToString();
                if (val == "")
                {
                    txtAdmissionNo.Text = "1";
                }
                else
                {
                    ID = Convert.ToInt32(dreader["StudentID"].ToString());
                    ID = ID + 1;
                    txtAdmissionNo.Text = ID.ToString();
                }
                dreader.Close();
                }
            
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                
                conn.Close();
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void lnkClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

      
    }
    }
