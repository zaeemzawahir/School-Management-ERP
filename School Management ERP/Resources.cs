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
    public partial class Resources : MetroForm
    {
        DBConnection cs = new DBConnection();
        SqlConnection conn = null;
        public Resources()
        {
            InitializeComponent();
        }

        private void Resources_Load(object sender, EventArgs e)
        {
            gridData();
            btnUpdate.Enabled = false;
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCategoryName.Text != "")
            {
                Save();
                gridData();
            }
            else
            {
                MetroMessageBox.Show(this, "Name field cannot be empty. Please enter a valid name for resource", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void newID()
        {
            try
            {
                conn = new SqlConnection(cs.DBconn);
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select ResourceID from Resource", conn);
                SqlDataReader dreader = cmd.ExecuteReader();
                if (dreader.HasRows == true)
                {
                    string EmpID = "";
                    while (dreader.Read())
                    {
                        EmpID = dreader["ResourceID"].ToString();
                    }
                    dreader.Close();
                    int num = int.Parse(EmpID.Substring(1).ToString());
                    if (num < 9)
                        txtResourceID.Text = "R000" + (num + 1);
                    else if (num < 99)
                        txtResourceID.Text = "R00" + (num + 1);
                    else if (num < 999)
                        txtResourceID.Text = "R0" + (num + 1);
                    else
                        txtResourceID.Text = "R" + (num + 1);
                }
                else
                {
                    txtResourceID.Text = "R0001";
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

        private void txtCategoryName_GotFocus(object sender, EventArgs e)
        {
            newID();

        }

        private void Clear()
        {
            txtCategoryName.Clear();
            txtResourceID.Clear();
            txtCategoryName.Focus();
            btnUpdate.Enabled = false;
            btnSave.Enabled = true;

        }

        private void Save()
        {
            try
            {
                conn = new SqlConnection(cs.DBconn);
                conn.Open();
                SqlCommand cmd = new SqlCommand("Insert Resource(ResourceID,Category) values (@ResourceID,@Category)", conn);
                cmd.Parameters.Add("@ResourceID", SqlDbType.Char).Value = txtResourceID.Text.Trim();
                cmd.Parameters.Add("@Category", SqlDbType.Char).Value = txtCategoryName.Text.Trim();
                cmd.ExecuteNonQuery();
                Clear();

            }

            catch
            { }
        }


        private void gridData()
        {
            try
            {
                conn = new SqlConnection(cs.DBconn);
                conn.Open();
                SqlDataAdapter resource = new SqlDataAdapter("Select ResourceID as [Resource ID], Category as [Resource Category] From Resource", conn);

                DataTable resourceData = new DataTable();
                resource.Fill(resourceData);
                dataGridView1.DataSource = resourceData;


            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
            }



        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateDetails();

        }

        private void updateDetails()
        {
            SqlCommand cmd = new SqlCommand("UPDATE  Rersource SET Category=Category Where ResourceID=@ResourceID", conn);
            cmd.Parameters.Add("@ResourceID", SqlDbType.Char).Value = txtResourceID.Text.Trim();
            cmd.Parameters.Add("@Category", SqlDbType.Char).Value = txtCategoryName.Text.Trim();
            cmd.ExecuteNonQuery();
            Clear();
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;

            i = dataGridView1.SelectedCells[0].RowIndex;

            txtResourceID.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtCategoryName.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
        }

        private void txtResourceID_TextChanged(object sender, EventArgs e)
        {
            conn = new SqlConnection(cs.DBconn);
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("Select ResourceID from Resource Where ResourceID=@ResourceID", conn);
                cmd.Parameters.Add("@ResourceID", SqlDbType.Char).Value = txtResourceID.Text.Trim();
                SqlDataReader dreader = cmd.ExecuteReader();
                if (dreader.HasRows == false)
                {
                    btnSave.Enabled = true;
                }
                else
                {
                    btnUpdate.Enabled = true;
                    btnSave.Enabled = false;
                }
                dreader.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtCategoryName_TextChanged(object sender, EventArgs e)
        {
            conn = new SqlConnection(cs.DBconn);
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("Select Category from Resource Where Category=@Category", conn);
                cmd.Parameters.Add("@Category", SqlDbType.Char).Value = txtCategoryName.Text.Trim();
                SqlDataReader dreader = cmd.ExecuteReader();
                if (dreader.HasRows == true)
                {
                    MetroMessageBox.Show(this, txtCategoryName.Text + " category you are trying to create already exists in record", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnSave.Enabled = false;
                }
                else
                {
                    btnSave.Enabled = true;
                }

                dreader.Close();
            }

            catch
            {
            }
        }

        private void lnkClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

