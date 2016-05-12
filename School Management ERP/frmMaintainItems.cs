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
    public partial class frmMaintainItems : MetroForm
    {
        DBConnection cs = new DBConnection();
        SqlConnection conn = null;
        public frmMaintainItems()
        {
            InitializeComponent();
        }

        private void frmMaintainItems_Load(object sender, EventArgs e)
        {
            gridData();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            category();
            LocationValue();
        }

        private void gridData()
        {
            conn = new SqlConnection(cs.DBconn);
            conn.Open();
            try
            {
                conn = new SqlConnection(cs.DBconn);
                conn.Open();
                SqlDataAdapter book = new SqlDataAdapter("ResourceList", conn);

                DataTable employeeData = new DataTable();
                book.Fill(employeeData);
                dataGridView1.DataSource = employeeData;

            }
            catch
            {

            }
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
           
                //initialize data grid view selected cell index
                int i;
                i = dataGridView1.SelectedCells[0].RowIndex;

                cmbLocation.SelectedValue = dataGridView1.Rows[i].Cells[0].Value.ToString();
                cmbCategory.SelectedValue = dataGridView1.Rows[i].Cells[1].Value.ToString();
                txtItemID.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
              
               txtName.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
               cmbStatus.SelectedValue = dataGridView1.Rows[i].Cells[4].Value.ToString();
                txtRemarks.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
                cmbActivity.SelectedValue = dataGridView1.Rows[i].Cells[6].Value.ToString();
                     }
            catch
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void lnkClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateItem();
            gridData();
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
             catch
             {

             }
             finally
             {
                 conn.Close();
             }
         }

        private void updateItem()
        {
            conn = new SqlConnection(cs.DBconn);

            try
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand("Update  Items SET Name=@Name,ResourceID=@ResourceID,TypeOfActivity=@Activity,Remarks=@Remarks,Status=@Status,LocationID=@LocationID WHERE ItemID=@ItemID", conn);
                cmd.Parameters.Add("@ItemID", SqlDbType.Char).Value = txtItemID.Text.Trim();

                cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = txtName.Text.Trim();
                cmd.Parameters.Add("@ResourceID", SqlDbType.Char).Value =  cmbCategory.SelectedValue.ToString().Trim();
                cmd.Parameters.Add("@LocationID", SqlDbType.Char).Value = cmbLocation.SelectedValue.ToString().Trim();
                cmd.Parameters.Add("@Remarks", SqlDbType.Text).Value = txtRemarks.Text.Trim();
                cmd.Parameters.Add("@Activity", SqlDbType.Char).Value = cmbActivity.SelectedIndex.ToString().Trim();
                cmd.Parameters.Add("@Status", SqlDbType.VarChar).Value = cmbStatus.SelectedIndex.ToString().Trim();
                cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
           
            finally
            { conn.Close(); }
        }
    }
}
