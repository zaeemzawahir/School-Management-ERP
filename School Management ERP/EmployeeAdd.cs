using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace School_Management_ERP
{
    public partial class EmployeeAdd : MetroForm
    {
        private DBConnection cs = new DBConnection();
        private SqlConnection conn = null;

        public EmployeeAdd()
        {
            InitializeComponent();
        }

        private void EmployeeAdd_Load(object sender, EventArgs e)
        {
            txtName.Focus();
            if (GlobalAccess.AccessLevel == "Management Staff")
            {
               cmbCategory.Items.Remove("Principal");
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            validate();
        }

        private void txtName_GotFocus(object sender, EventArgs e)
        {
            newID();
        }

        //Custom Functions

        private void validate()
        {
            if (txtName.Text == "" || txtMobile.Text == "" || txtEducation.Text == "" || txtCity.Text == ""
                || txtNic.Text == "" || txtLandline.Text == "" || cmbDepartment.SelectedIndex < -1 || cmbDepartment.SelectedIndex < -1
              || txtAddress.Text == "" || dtDob.Value == DateTime.Now.Date)
            {
                MessageBox.Show(this, "All field are required", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           if (txtMobile.Text != "")
            {
                if (txtMobile.Text.Length < 10 || txtMobile.Text.Length > 16)
                {
                    MetroMessageBox.Show(this, "Mobile Number should be between 10 to 16 digits", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (txtNic.Text != "")
                {
                    Regex pattern = new Regex(@"^[0-9]{9}[vVxX]");
                    if (pattern.IsMatch(txtNic.Text))
                    {
                        save();
                    }
                    else if (pattern.IsMatch(txtNic.Text) == false)
                    {
                        MetroMessageBox.Show(this, "Input format error. Please enter using correct NIC number format", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
            }

           

        }

        private void save()
        {
            try
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
                SqlCommand cmd = new SqlCommand("EmployeeInsert", conn);
                cmd.CommandType = CommandType.StoredProcedure;
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
                MessageBox.Show("Completed");
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

        private void newID()
        {
            try
            {
                conn = new SqlConnection(cs.DBconn);
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select EmpID from Employee", conn);
                SqlDataReader dreader = cmd.ExecuteReader();
                if (dreader.HasRows == true)
                {
                    string EmpID = "";
                    while (dreader.Read())
                    {
                        EmpID = dreader["EmpID"].ToString();
                    }
                    dreader.Close();
                    int num = int.Parse(EmpID.Substring(1).ToString());
                    if (num < 9)
                        txtEmployeeID.Text = "E000" + (num + 1);
                    else if (num < 99)
                        txtEmployeeID.Text = "E00" + (num + 1);
                    else if (num < 999)
                        txtEmployeeID.Text = "E0" + (num + 1);
                    else
                        txtEmployeeID.Text = "E" + (num + 1);
                }
                else
                {
                    txtEmployeeID.Text = "E0001";
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

        private void lnkClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EmployeeAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (txtName.Text != "" || txtAddress.Text != "")
            {
                if (DialogResult.Yes == MetroMessageBox.Show(this, "Did close by mistake? If the windows will not close and you can continue your work", "Exit Window", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    e.Cancel = true;
                    this.Focus();
                }
                
            }
        }

   
    }

}