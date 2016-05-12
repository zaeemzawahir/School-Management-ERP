using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MetroFramework;
using MetroFramework.Forms;
using System.Security.Cryptography;

namespace School_Management_ERP
{
    public partial class frmUser : MetroForm
    {
        DBConnection cs = new DBConnection();
        SqlConnection conn = null;

       

        public frmUser()
        {
            InitializeComponent();
        }
         
    

        private void frmUser_Load(object sender, EventArgs e)
        {
            gridData();
        }

       
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtEmpID.Text.Length < 5 || txtEmpID.Text == "" || txtName.Text == "")
            {
                if (DialogResult.OK == MetroMessageBox.Show(this, "Please enter an Employee ID to proceed further", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)) 
                {
                    txtEmpID.Focus(); 
                }
              
            }
            else
            {
                saveAccount();
            }

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtEmpID.Text.Length < 5 || txtEmpID.Text == "" || txtName.Text=="")
            {
                if (DialogResult.OK == MetroMessageBox.Show(this, "Please enter an Employee ID to proceed further", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information))
                {
                    txtEmpID.Focus();
                }
              
            }
            else
            {
                updateAccount();
                
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
             conn = new SqlConnection(cs.DBconn);

             try
             {
                 if (txtName.Text!=""  || btnSave.Enabled==false)
                 conn.Open();
                 SqlCommand cmd = new SqlCommand("Delete EmpID FROM Employee Where EmpID=@EmpID", conn);
                 cmd.Parameters.Add("@EmpID", SqlDbType.Char).Value = txtEmpID.Text.Trim();
                 if (DialogResult.Yes == MetroMessageBox.Show(this, "Do you want to delete this user account", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                 {
                     cmd.ExecuteNonQuery();
                 }
               

             }
             catch
             {
             }
        }
        private void lnkClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        //Create functions
        private void gridData()
        { 
            conn = new SqlConnection(cs.DBconn);

            try
            {
                conn.Open();
                conn = new SqlConnection(cs.DBconn);
                conn.Open();
                SqlDataAdapter accountList = new SqlDataAdapter("userAccountList", conn);
                DataTable userData = new DataTable();
                accountList.Fill(userData);
                dataGridView1.DataSource = userData;
            }
            catch
            { 
            
            }
            finally
            {
                conn.Close();
            }
        
        }

        private void getInfromation()
        {
            conn = new SqlConnection(cs.DBconn);

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("empLogin", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@EmpID", SqlDbType.Char).Value = txtEmpID.Text.Trim();
                SqlDataReader dreader = cmd.ExecuteReader();
                if (dreader.HasRows == true)
                {
                    while (dreader.Read())
                    {
                        string mobile;
                        txtName.Text = dreader["Name"].ToString();
                        txtAccess.Text = dreader["Category"].ToString();
                        mobile= dreader["Mobile"].ToString();
                        txtPassword.Text = mobile.Substring(mobile.Length -6);
                        if (dreader["Username"] != DBNull.Value)
                        {
                            txtUname.Enabled = false;
                            txtUname.Text = dreader["Username"].ToString();
                            cmbActiveStat.Text= dreader["ActiveStat"].ToString();
                            btnSave.Enabled = false;
                        }
                        else
                        {
                            btnUpdate.Enabled = false;
                            
                        }
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

        private void saveAccount()
        {
            conn = new SqlConnection(cs.DBconn);
            try
            {
                string pass = ConverterHash.Encrypt(txtPassword.Text.Trim());

              
                conn.Open();
                SqlCommand cmd = new SqlCommand("Insert into employeeLogin (EmpID,Username,Pass,ActiveStat,AccessLevel)values(@EmpID,@Username,@Pass,@ActiveStat,@AccessLevel)", conn);
                cmd.Parameters.Add("@EmpID", SqlDbType.Char).Value = txtEmpID.Text.Trim();
                cmd.Parameters.Add("@UserName", SqlDbType.VarChar).Value = txtUname.Text.Trim();
                cmd.Parameters.Add("@ActiveStat", SqlDbType.VarChar).Value = cmbActiveStat.Text.Trim();
                cmd.Parameters.Add("@Pass", SqlDbType.VarChar).Value = pass;
                cmd.Parameters.Add("@AccessLevel", SqlDbType.VarChar).Value = txtAccess.Text.Trim();
                if (DialogResult.Yes == MetroMessageBox.Show(this, "Do you want to create an account for user " + txtName.Text.ToString() + "", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
                {
                    cmd.ExecuteNonQuery();
                    Clear();
                    gridData();
                }
                else
                {
                    txtEmpID.Focus();
                }

            }
            catch
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }
        private void updateAccount()
        {
              conn = new SqlConnection(cs.DBconn);
              try
              {
                 
                  conn.Open();
                  SqlCommand cmd = new SqlCommand("UPDATE employeeLogin SET Username=@Username,Pass=@Pass,ActiveStat=@ActiveStat,AccessLevel=@AccessLevel WHERE EmpID=@EmpID", conn);
                  cmd.Parameters.Add("@EmpID", SqlDbType.Char).Value = txtEmpID.Text.Trim();
                  cmd.Parameters.Add("@UserName", SqlDbType.VarChar).Value = txtUname.Text.Trim();
                  cmd.Parameters.Add("@ActiveStat", SqlDbType.VarChar).Value = cmbActiveStat.Text.Trim();
                  cmd.Parameters.Add("@Pass", SqlDbType.VarChar).Value = txtPassword.Text.Trim();
                  cmd.Parameters.Add("@AccessLevel", SqlDbType.VarChar).Value = txtAccess.Text.Trim();

                  if (DialogResult.Yes == MetroMessageBox.Show(this, "This will update user account of "+txtName.Text.ToString()+" and password will be set to default one, which will be the last 6 digit of the user's mobile number", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
                  {
                      cmd.ExecuteNonQuery();
                      Clear();
                      gridData();
                  }
                  else
                  {
                      txtEmpID.Focus();
                  }
           
          
              }
              catch
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
            txtEmpID.Clear();
            fieldClear();
            
        }
        private void fieldClear()
        {
            txtName.Clear();
            txtPassword.Clear();
            txtAccess.Clear();
            txtUname.Clear();
            cmbActiveStat.SelectedIndex = -1;
            txtEmpID.Focus();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            txtUname.Enabled = true;
        }
        private void txtEmpID_TextChanged(object sender, EventArgs e)
        {
            if (txtEmpID.MaxLength == txtEmpID.Text.Length)
            {
                getInfromation();
            }
            else
            {
                fieldClear();
            }
        }

       

        private void txtUname_TextChanged(object sender, EventArgs e)
        {
            conn = new SqlConnection(cs.DBconn);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select Username from employeeLogin Where Username=@Username", conn);
                cmd.Parameters.Add("@Username", SqlDbType.Char).Value = txtUname.Text.Trim();
                SqlDataReader dreader = cmd.ExecuteReader();
                if (dreader.HasRows == true && (txtUname.Enabled == true))
                {
                    MetroMessageBox.Show(this, "Username not available. Please choose another username", "Information", MessageBoxButtons.OK);
                    btnUpdate.Enabled = false;
                    btnSave.Enabled = false;
                }
                else if (((dreader.HasRows) == false) && (txtUname.Enabled == true))
                {
                    btnSave.Enabled = true;
                }
            }

            catch
            { }
            finally { }
        }
    }
}
