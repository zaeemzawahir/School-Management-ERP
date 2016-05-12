using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
namespace School_Management_ERP
{
    public partial class frmViewBook : MetroForm
    {
        DBConnection cs = new DBConnection();
        SqlConnection conn = null;
        public frmViewBook()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateBook();
        }

        private void updateBook()
        {
            try
            {
                conn = new SqlConnection(cs.DBconn);
                conn.Open();
                SqlCommand updatecmd = new SqlCommand("UPDATE Book SET Author=@Author, Edition=@Edition, Category=@Category, Title=@Title where BookID= @BookID", conn);
                updatecmd.Parameters.Add("@BookID", SqlDbType.Char).Value = txtBookID.Text.Trim();
                updatecmd.Parameters.Add("@Author", SqlDbType.VarChar).Value = txtAuthor.Text.Trim();
                updatecmd.Parameters.Add("@Edition", SqlDbType.VarChar).Value = txtEdition.Text.Trim();
                updatecmd.Parameters.Add("@Category", SqlDbType.VarChar).Value = cmbCategory.Text.Trim();
                updatecmd.Parameters.Add("@Title", SqlDbType.VarChar).Value = txtTitle.Text.Trim();
                updatecmd.ExecuteNonQuery();

                updatecmd.Parameters.Clear();
                MessageBox.Show("Record updated", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gridData();
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
        private void Clear()
        {
            txtBookID.Clear();
            txtTitle.Clear();
            txtEdition.Clear();
            txtAuthor.Clear();
            cmbCategory.SelectedIndex = -1;
        }

        private void gridData()
        {
            try
            {
                conn = new SqlConnection(cs.DBconn);
                conn.Open();
                SqlDataAdapter book = new SqlDataAdapter("Select BookID AS 'Book ID', Title, Category, Edition, Author from Book", conn);
                DataTable bookData = new DataTable();
                book.Fill(bookData);
                dataGridView1.DataSource = bookData;
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

        private void frmViewBook_Shown(object sender, EventArgs e)
        {
            gridData();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i;
                i = dataGridView1.SelectedCells[0].RowIndex;
                txtBookID.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                txtTitle.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                cmbCategory.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                txtEdition.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                txtAuthor.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            }
            catch { }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            if (cmbSearch.Text == "Book ID")
            {
                bs.Filter = "BookID like '%" + txtSearch.Text + "%'";
                dataGridView1.DataSource = bs;
            }
            else if (cmbSearch.Text == "Title")
            {
                bs.Filter = "Title like '%" + txtSearch.Text + "%'";
                dataGridView1.DataSource = bs;
            }
            else if (cmbSearch.Text == "Author")
            {
                bs.Filter = "Author like '%" + txtSearch.Text + "%'";
                dataGridView1.DataSource = bs;
            }
            else if (cmbSearch.Text == "Category")
            {
                bs.Filter = "Category like '%" + txtSearch.Text + "%'";
                dataGridView1.DataSource = bs;
            }
        }

        private void frmViewBook_Load(object sender, EventArgs e)
        {
        }

        private void lnkClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}