using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;


namespace School_Management_ERP
{
    public partial class UserAccont : MetroForm
    {
        DBConnection cs = new DBConnection();
        SqlConnection conn = null;
        public UserAccont()
        {
            InitializeComponent();
        }

        private void UserAccont_Load(object sender, System.EventArgs e)
        {

        }
        public void Clear()
        {
            txtEmpID.Clear();
            txtPassword.Clear();
            txtName.Clear();
            txtAccess.Clear();
            txtUname.Clear();
            cmbActiveStat.SelectedIndex = -1;
           

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            try
            {
                conn = new SqlConnection(cs.DBconn);
                conn.Open();
                SqlCommand cmd = new SqlCommand("select Employee.EmpID , Employee.Name,Employee.Mobile, employeeLogin.Username, employeeLogin.ActiveStat, Employee.Category From Employee LEFT JOIN employeeLogin on Employee.EmpID=employeeLogin.EmpID  where Employee.EmpID='" + txtEmpID.Text + "'", conn);
                SqlDataReader dreader = cmd.ExecuteReader();

                if (dreader.HasRows == true)
                {
                    while (dreader.Read())
                    {
                        txtEmpID.Text = dreader["EmpID"].ToString();

                        txtName.Text = dreader["Name"].ToString();
                        cmbActiveStat.Text = dreader["ActiveStat"].ToString();
                        txtPassword.Text = dreader["Mobile"].ToString().Substring(6);
                        txtAccess.Text = dreader["staffCategory"].ToString();
                        if (dreader["Username"] == DBNull.Value) 
                        {
                            btnCreate.Text = "Update";
                        }
                        else
                        {
                            txtUname.Text = dreader["Username"].ToString();
                        }
                    }
                   
                    dreader.Close();
                    conn.Close();
                    MetroMessageBox.Show(this,"Record already exist and will be loaded to screen now, use update option to update existing records.", "Existing record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }
              
                    
                }
            }
            catch (Exception excep)
            {

                MessageBox.Show(excep.Message.ToString(), "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                conn.Close();


            }
        }


try
            {
                conn = new SqlConnection(cs.DBconn);
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from StaffLogin where EmpID='" + txtEmpID.Text + "'", conn);
                SqlDataReader dreader = cmd.ExecuteReader();

                if (dreader.HasRows == true)
                {
                    while (dreader.Read())
                    {
                        txtEmpID.Text = dreader["EmpID"].ToString();
                        txtUname.Text = dreader["Username"].ToString();
                        cmbActiveStat.Text = dreader["ActiveStat"].ToString();
                        txtPassword.Enabled = false;
                        cmbAccessLevel.Text = dreader["staffCategory"].ToString();

                    }
                    dreader.Close();
                    conn.Close();
                    MessageBox.Show("Record already exist and will be loaded to screen now, use update option to update existing records.", "Existing record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnUpdate.Enabled = true;
                    btnUpdate.Focus();
                    txtPassword.Enabled = true;
                }
                else
                {
                    conn = new SqlConnection(cs.DBconn);
                    conn.Open();
                    SqlCommand subcmd = new SqlCommand("Insert into StaffLogin (EmpID,Username,Pass,ActiveStat,staffCategory)values(@EmpID,@Username,@Pass,@ActiveStat,@staffCategory)", conn);
                    subcmd.Parameters.Add("@EmpID", SqlDbType.Char).Value = txtEmpID.Text.Trim();
                    subcmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = txtUname.Text.Trim();
                    subcmd.Parameters.Add("@Pass", SqlDbType.VarChar).Value = txtPassword.Text.Trim();
                    subcmd.Parameters.Add("@ActiveStat", SqlDbType.VarChar).Value = cmbActiveStat.Text.Trim();
                    subcmd.Parameters.Add("@staffCategory", SqlDbType.VarChar).Value = cmbAccessLevel.Text.Trim();

                    subcmd.ExecuteNonQuery();
                    subcmd.Parameters.Clear();
                    conn.Close();
                    MessageBox.Show("User account created", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
            }
            catch (Exception excep)
            {

                MessageBox.Show(excep.Message.ToString(), "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                conn.Close();


            }
        private void txtAccess_Click(object sender, EventArgs e)
        {

        }

    }

}