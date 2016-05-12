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
    public partial class frmSubject : MetroForm
    {
        DBConnection cs = new DBConnection();
        SqlConnection conn = null;

        public frmSubject()
        {
            InitializeComponent();
        }

        private void frmSubject_Load(object sender, EventArgs e)
        {
            txtSubjectName.Focus();
            gridData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtSubjectName.Text == "")
            {
                MetroMessageBox.Show(this, "Please enter a subject Name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                saveSubject();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtSubjectName.Text == "")
            {
                MetroMessageBox.Show(this, "Please enter a subject Name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                subjectUpdate();
            }
        }
        private void txtSubjectName_GotFocus(object sender, EventArgs e)
        {
            newID();
        }
        //Custom Functions

        private void gridData()
        {
            try
            {
                conn = new SqlConnection(cs.DBconn);
                conn.Open();
                SqlDataAdapter subject = new SqlDataAdapter("Select SubjectID AS 'Subject ID', SubjectName AS 'Subject' FROM gceSubjects", conn);

                DataTable subjectData = new DataTable();
                subject.Fill(subjectData);
                dataGridView1.DataSource = subjectData;
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
        }

        private void newID()
        {
            try
            {
                conn = new SqlConnection(cs.DBconn);
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select SubjectID from gceSubjects", conn);
                SqlDataReader dreader = cmd.ExecuteReader();
                if (dreader.HasRows == true)
                {
                    string SubjectID = "";
                    while (dreader.Read())
                    {
                        SubjectID = dreader["SubjectID"].ToString();
                    }
                    dreader.Close();
                    int num = int.Parse(SubjectID.Substring(1).ToString());
                    if (num < 9)
                        txtSubjectID.Text = "S000" + (num + 1);
                    else if (num < 99)
                        txtSubjectID.Text = "S00" + (num + 1);
                    else if (num < 999)
                        txtSubjectID.Text = "S0" + (num + 1);
                    else
                        txtSubjectID.Text = "S" + (num + 1);
                }
                else
                {
                    txtSubjectID.Text = "S0001";
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

        private void saveSubject()
        {
            conn = new SqlConnection(cs.DBconn);
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("Insert into gceSubjects(SubjectID,SubjectName) Values (@SubjectID,@SubjectName)", conn);
                cmd.Parameters.Add("@SubjectID", SqlDbType.Char).Value = txtSubjectID.Text.Trim();
                cmd.Parameters.Add("@SubjectName", SqlDbType.Char).Value = txtSubjectName.Text.Trim();

                if (DialogResult.Yes== MessageBox.Show(this, "Do you want to create this subject?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    cmd.ExecuteNonQuery();
                    Clear();
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

        private void subjectUpdate()
        {

            conn = new SqlConnection(cs.DBconn);
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("Update gceSubjects SET SubjectName=@SubjectName Where SubjectID=@SubjectID", conn);
                cmd.Parameters.Add("@SubjectID", SqlDbType.Char).Value = txtSubjectID.Text.Trim();
                cmd.Parameters.Add("@SubjectName", SqlDbType.Char).Value = txtSubjectName.Text.Trim();

                if (DialogResult.Yes == MessageBox.Show(this, "Do you want to update this subject?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    cmd.ExecuteNonQuery();
                    Clear();
                 
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
        private void Clear()
        {
            txtSubjectID.Clear();
            txtSubjectName.Clear();
            txtSubjectName.Focus();
            gridData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtSubjectName.Text != "")
            {
                conn = new SqlConnection(cs.DBconn);
                conn.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("Delete From gceSubjects Where SubjectID=@SubjectID", conn);
                    cmd.Parameters.Add("@SubjectID", SqlDbType.Char).Value = txtSubjectID.Text.Trim();

                    if (DialogResult.Yes == MessageBox.Show(this, "Do you want to delete this subject?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        cmd.ExecuteNonQuery();
                        Clear();
                    }


                }
                catch
                {
                    MetroMessageBox.Show(this,"Record you are trying to delete does not exists","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.SelectedCells[0].RowIndex;

            txtSubjectID.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtSubjectName.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
   
        }

        
    }
}
