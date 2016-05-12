using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MetroFramework.Forms;
using MetroFramework;
namespace School_Management_ERP
{
    public partial class frmPassword : MetroForm
    {
        
         private DBConnection cs = new DBConnection();
         private SqlConnection conn = null;
         string username;
            
        public frmPassword()
        {
            InitializeComponent();
            
        }

        private void frmPassword_Load(object sender, EventArgs e)
        {
          
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "")
            {
                if (txtNewPass.Text == txtPass.Text)
                {
                    Passwordvalidate();
                }
                else
                {
                    MetroMessageBox.Show(this, "Please check whether you enetered correct password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MetroMessageBox.Show(this, "Username cannot be empty", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
       
        }

        private void updatePass()
        {
            try
            {
                conn = new SqlConnection(cs.DBconn);
                conn.Open();
                SqlCommand cmd = new SqlCommand("Update employeeLogin SET Pass=@Pass Where Username=@Username", conn);

                cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = txtUsername.Text.Trim();

                
                string pass = ConverterHash.Encrypt(txtPass.Text.Trim());
                cmd.Parameters.Add("@Pass", SqlDbType.VarChar).Value = pass;

                cmd.ExecuteNonQuery();
                Clear();
                MetroMessageBox.Show(this, "Password changed sucessully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch(Exception)
            {
                MetroMessageBox.Show(this, "Database error", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw;


            }

            finally
            {
                conn.Close();
            }
        }

        private void Clear()
        {
            txtNewPass.Clear();
            txtoPass.Clear();
            txtPass.Clear();
            txtUsername.Clear();
                 
        }
        private void Passwordvalidate()
        {
            try
            {

                conn = new SqlConnection(cs.DBconn);
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select Pass From employeeLogin   Where Username=@Username", conn);

                cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = txtUsername.Text.Trim();

                string pass = ConverterHash.Encrypt(txtoPass.Text);

                SqlDataReader dreader = cmd.ExecuteReader();
                if (dreader.HasRows == true)
                {
                    while (dreader.Read())
                    {
                        if (pass == dreader["Pass"].ToString())
                        {
                            updatePass();
                        }

                        else
                        {
                            MetroMessageBox.Show(this, "Database error", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dreader.Close();
                        }
                 

                    }
                }
            }
            catch(Exception)
            {
                throw;
            }
        }
       
    }

}
