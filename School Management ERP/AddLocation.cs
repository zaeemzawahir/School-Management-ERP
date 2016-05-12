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
    public partial class AddLocation : MetroForm
    {
        public AddLocation()
        {
            InitializeComponent();
        }
        private DBConnection cs = new DBConnection();
        private SqlConnection conn = null;

        private void AddLocation_Load(object sender, EventArgs e)
        {
            gridData();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            saveLocation();
        }

        private void saveLocation()
       {
           if (txtLocationName.Text == "")
           {
               MetroMessageBox.Show(AddLocation.ActiveForm,"Book Title field cannot be empty", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
               txtLocationName.Focus();
           }
            
           else if(txtEmpID.Text=="")
           {
             MetroMessageBox.Show(this,"New location Cannot be created without being assigned to an employee", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
           }
           else if (txtEmpName.Text == "")
           {
               MetroMessageBox.Show(this, "Please enter a correct Employee ID", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           else
           {
               //open database connection
               try
               {
                   conn = new SqlConnection(cs.DBconn);
                   conn.Open();
                   SqlCommand cmd = new SqlCommand("Insert Location(LocationID,LocationName,EmpID) values (@LocationID,@LocationName,@EmpID)", conn);
                   cmd.Parameters.Add("@LocationID", SqlDbType.Char).Value = txtLocationID.Text.Trim();
                   cmd.Parameters.Add("@LocationName", SqlDbType.VarChar).Value = txtLocationName.Text.Trim();
                   cmd.Parameters.Add("@EmpID", SqlDbType.VarChar).Value = txtEmpID.Text.Trim();
                   cmd.ExecuteNonQuery();
                   cmd.Parameters.Clear();
                   txtLocationName.Focus();
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i;
                i = dataGridView1.SelectedCells[0].RowIndex;
                txtLocationID.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                txtLocationName.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                txtEmpID.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                txtEmpName.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            }
            catch { }
        }

        private void LoadEmpName()
        {
            try
            {
                conn = new SqlConnection(cs.DBconn);
                conn.Open();
                if (txtEmpID.Text.Length == txtEmpID.MaxLength)
                {
                    
                    SqlCommand cmd = new SqlCommand("Select Name from Employee  Where EmpID=@EmpID", conn);
                    cmd.Parameters.Add("@EmpID", SqlDbType.Char).Value = txtEmpID.Text.Trim();

                    //where 
                    SqlDataReader dreader = cmd.ExecuteReader();
                    if (dreader.HasRows == true)
                    {
                        while (dreader.Read())
                        {

                            txtEmpName.Text = dreader["Name"].ToString();

                        }
                        dreader.Close();

                    }
                }
                else
                {
                    txtEmpName.Clear();
                
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

       

        private void txtEmpID_TextChanged(object sender, EventArgs e)
        {
            if (txtEmpID.Text != "")
            { LoadEmpName();
            }
          

        }

        private void gridData()
        {
            conn = new SqlConnection(cs.DBconn);
            conn.Open();
            SqlDataAdapter book = new SqlDataAdapter("LocationDetails", conn);

            DataTable LocationData = new DataTable();
            book.Fill(LocationData);
            dataGridView1.DataSource = LocationData;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtLocationName.Text == "")
            {
                MetroMessageBox.Show(AddLocation.ActiveForm, "Book Title field cannot be empty", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLocationName.Focus();
            }

            else if (txtEmpID.Text == "")
            {
                MetroMessageBox.Show(this, "New location Cannot be created without being assigned to an employee", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (txtEmpName.Text == "")
            {
                MetroMessageBox.Show(this, "Please enter a correct Employee ID", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //open database connection
                try
                {
                    conn = new SqlConnection(cs.DBconn);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Update  Location SET LocationName=@LocationName, EmpID=@EmpID Where  LocationID=@LocationID", conn);
                    cmd.Parameters.Add("@LocationID", SqlDbType.Char).Value = txtLocationID.Text.Trim();
                    cmd.Parameters.Add("@LocationName", SqlDbType.VarChar).Value = txtLocationName.Text.Trim();
                    cmd.Parameters.Add("@EmpID", SqlDbType.VarChar).Value = txtEmpID.Text.Trim();
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    txtLocationName.Focus();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(cs.DBconn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Delete  Location  Where  LocationID=@LocationID", conn);
            cmd.Parameters.Add("@LocationID", SqlDbType.Char).Value = txtLocationID.Text.Trim();
         
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            txtLocationName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveLocation();
        }

        private void lnkClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
       
    }

}
