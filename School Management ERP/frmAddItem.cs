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
    public partial class Add_Items : MetroForm
    {
        DBConnection cs = new DBConnection();
        SqlConnection conn = null;
        public Add_Items()
        {
            InitializeComponent();
        }


        private void txtName_TextChanged(object sender, EventArgs e)
        {
            category();
            LocationValue();

        }

        private void txtName_GotFocus(object sender, EventArgs e)
        {
            newID();

        }

        private void newID()
        {
            try
            {
                conn = new SqlConnection(cs.DBconn);
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select ItemID from Items", conn);
                SqlDataReader dreader = cmd.ExecuteReader();
                if (dreader.HasRows == true)
                {
                    string EmpID = "";
                    while (dreader.Read())
                    {
                        EmpID = dreader["ItemID"].ToString();
                    }
                    dreader.Close();
                    int num = int.Parse(EmpID.Substring(1).ToString());
                    if (num < 9)
                        txtItemID.Text = "I000" + (num + 1);
                    else if (num < 99)
                        txtItemID.Text = "I00" + (num + 1);
                    else if (num < 999)
                        txtItemID.Text = "I0" + (num + 1);
                    else
                        txtItemID.Text = "I" + (num + 1);
                }
                else
                {
                    txtItemID.Text = "I0001";
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

        private void save()
        {
            conn = new SqlConnection(cs.DBconn);
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("Insert into Items(ItemID,Name,ResourceID,Status,LocationID) Values (@ItemID,@Name,@ResourceID,@Status,@LocationID)", conn);
                cmd.Parameters.Add("@ItemID", SqlDbType.Char).Value = txtItemID.Text.Trim();
                cmd.Parameters.Add("@Name", SqlDbType.Char).Value = txtName.Text.Trim();
                cmd.Parameters.Add("@LocationID", SqlDbType.Char).Value = cmbLocation.SelectedValue.ToString().Trim();
                cmd.Parameters.Add("@ResourceID", SqlDbType.VarChar).Value = cmbCategory.SelectedValue.ToString().Trim();
                cmd.Parameters.Add("@Status", SqlDbType.VarChar).Value = "Available";
           
                cmd.ExecuteNonQuery();
                MessageBox.Show("Succes");
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        private void category()
        {
            conn = new SqlConnection(cs.DBconn);
            conn.Open();
            try
            {
                string query = "Select Category, ResourceID from Resource";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);

                DataSet ds = new DataSet();
                da.Fill(ds, "Resource");
                cmbCategory.DisplayMember = "Category";
                cmbCategory.ValueMember = "ResourceID";

                cmbCategory.DataSource = ds.Tables["Resource"];
            }
            catch (Exception ex)
            {
                // write exception info to log or anything else
                MessageBox.Show("Error occured!");
            }
            finally
            {
                conn.Close();
            }
        }
        private void LocationValue()
        {
            conn = new SqlConnection(cs.DBconn);
            conn.Open();
            try
            {
                string query = "Select LocationName, LocationID from Location";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);

                DataSet ds = new DataSet();
                da.Fill(ds, "Location");
                cmbLocation.DisplayMember = "LocationName";
                cmbLocation.ValueMember = "LocationID";
                cmbLocation.DataSource = ds.Tables["Location"];
            }
            catch (Exception ex)
            {
                // write exception info to log or anything else
                MessageBox.Show("Error occured!");
            }
            finally
            { conn.Close(); }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            save();
        }

        private void Add_Items_Load(object sender, EventArgs e)
        {

        }

        private void lnkClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
