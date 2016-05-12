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
namespace School_Management_ERP
{
    public partial class frmStudenOlREg : MetroForm
    {
        DBConnection cs = new DBConnection();
        SqlConnection conn = null;
        public frmStudenOlREg()
        {
            InitializeComponent();
        }

        private void frmStudenOlREg_Load(object sender, EventArgs e)
        {

        }

   

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtAdmissionNo.Text==""||txtOLAdmissioNo.Text==""||txtYear.Text=="")
            {
                MetroMessageBox.Show(this,"Fields cannot be empty","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                studentUpdate();
            }

        }

        private void studentUpdate()
        {

            try
            {
                conn = new SqlConnection(cs.DBconn);
                conn.Open();


                SqlCommand cmd = new SqlCommand("UPDATE [dbo].Student SET olYear=@olYear, olAdmissionNo=@olAdmissionNo WHERE StudentID=@StudentID", conn);
                cmd.Parameters.Add("@StudentID", SqlDbType.Char).Value = txtAdmissionNo.Text.Trim();
                cmd.Parameters.Add("@olYear", SqlDbType.Date).Value = txtYear.Text.Trim();
                cmd.Parameters.Add("@olAdmissionNo", SqlDbType.Date).Value = txtOLAdmissioNo.Text.Trim();
            
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                
                MetroMessageBox.Show(this, "Record sucessfully added");

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
        txtYear.Clear();
        txtOLAdmissioNo.Clear();
        txtAdmissionNo.Clear();
        txtName.Clear();
    }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAdmissionNo_TextChanged(object sender, EventArgs e)
        {
              try
            {
                conn = new SqlConnection(cs.DBconn);
                conn.Open();


                SqlCommand cmd = new SqlCommand("Select Name from Student WHERE StudentID=@StudentID", conn);
                cmd.Parameters.Add("@StudentID", SqlDbType.Char).Value = txtAdmissionNo.Text.Trim();
                SqlDataReader dreader = cmd.ExecuteReader();
                if (dreader.HasRows == true)
                {
                    txtName.Text = dreader["Name"].ToString(); 
                }

                dreader.Close();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                
                MetroMessageBox.Show(this, "Record sucessfully added");

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
        }

    }

