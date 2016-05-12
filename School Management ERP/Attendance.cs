using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using System.Drawing;
using System.Xml;
namespace School_Management_ERP
{
    public partial class frmAttendance : MetroForm
    {
        private DBConnection cs = new DBConnection();
        private SqlConnection conn = null;

        public frmAttendance()
        {
            InitializeComponent();
        }
        private void Clear()
        {
            txtName.Clear();
            txtEmpID.Clear();
            txtEmpID.Focus();
            btnEnter.Enabled = false;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string EmpID = txtEmpID.Text.Trim();
            if (txtEmpID.Text != "")
            {
                try
                {
                    conn = new SqlConnection(cs.DBconn);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("TimeAttendance", conn);
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("EmpID", EmpID);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MetroMessageBox.Show(this, "Thank you " + txtName.Text + " Time has been enterd", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                        conn.Close();
                    }

                }

                catch
                {
                    MetroMessageBox.Show(this, "Database");
                }
            }
        }

        private void frmAttendance_Load(object sender, EventArgs e)
        {
            lblDisplayTime.Text = DateTime.Now.ToString();
            btnEnter.Enabled = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblDisplayTime.ForeColor = Color.Red;
            lblDisplayTime.Text = DateTime.Now.ToString();
        }

        private void txtEmpID_TextChanged(object sender, EventArgs e)
        {
            if (txtEmpID.Text.Length == 5)
            {
                try
                {
                    conn = new SqlConnection(cs.DBconn);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Select Name From Employee Where EmpID=@EmpID", conn);
                    cmd.Parameters.Add("@EmpID", SqlDbType.Char).Value = txtEmpID.Text;
                    SqlDataReader dReader = cmd.ExecuteReader();
                    if(dReader.HasRows==true)
                    {
                        while (dReader.Read())
                        {
                            txtName.Text= dReader["Name"].ToString();
                        }
                        dReader.Close();

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

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                btnEnter.Enabled = true;
            }
            else {
                btnEnter.Enabled = false;
            
            }
        }

        private void axShockwaveFlash2_Enter(object sender, EventArgs e)
        {

        }

        private void metroTextButton1_Click(object sender, EventArgs e)
        {


        }

        private void lnkClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

       
