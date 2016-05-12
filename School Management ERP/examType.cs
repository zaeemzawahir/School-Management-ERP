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
    public partial class examType : MetroForm
    {
        DBConnection cs = new DBConnection();
        SqlConnection conn = null;
        public examType()
        {
            InitializeComponent();
        }
        private void txtExamName_GotFocus(object sender, EventArgs e)
        {
            newID();

        }
        private void examType_Load(object sender, EventArgs e)
        {
            txtExamName.Focus();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtExamName.Text == "")
            {
                MetroMessageBox.Show(this, "Please enter a exam Name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                saveexam();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtExamName.Text == "")
            {
                MetroMessageBox.Show(this, "Please enter a exam Name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                examUpdate();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtExamName.Text != "")
            {
                conn = new SqlConnection(cs.DBconn);
                conn.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("Delete From gceExam Where examID=@examID", conn);
                    cmd.Parameters.Add("@examID", SqlDbType.Char).Value = txtExamID.Text.Trim();

                    if (DialogResult.Yes == MessageBox.Show(this, "Do you want to delete this exam?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        cmd.ExecuteNonQuery();
                        Clear();
                    }


                }
                catch
                {
                    MetroMessageBox.Show(this, "Record you are trying to delete does not exists", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        private void lnkClose_Click(object sender, EventArgs e)
        {

        }


        private void newID()
        {
            try
            {
                conn = new SqlConnection(cs.DBconn);
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select examID from gceExam", conn);
                SqlDataReader dreader = cmd.ExecuteReader();
                if (dreader.HasRows == true)
                {
                    string examID = "";
                    while (dreader.Read())
                    {
                        examID = dreader["examID"].ToString();
                    }
                    dreader.Close();
                    int num = int.Parse(examID.Substring(1).ToString());
                    if (num < 9)
                        txtExamID.Text = "G000" + (num + 1);
                    else if (num < 99)
                        txtExamID.Text = "G00" + (num + 1);
                    else if (num < 999)
                        txtExamID.Text = "G0" + (num + 1);
                    else
                        txtExamID.Text = "G" + (num + 1);
                }
                else
                {
                    txtExamID.Text = "G0001";
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

        private void saveexam()
        {
            conn = new SqlConnection(cs.DBconn);
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("Insert into gceExam(examID,examType) Values (@examID,@examType)", conn);
                cmd.Parameters.Add("@examID", SqlDbType.Char).Value = txtExamID.Text.Trim();
                cmd.Parameters.Add("@examType", SqlDbType.Char).Value = txtExamName.Text.Trim();

                if (DialogResult.Yes == MessageBox.Show(this, "Do you want to create this exam?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
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

        private void examUpdate()
        {

            conn = new SqlConnection(cs.DBconn);
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("Update gceExam SET examType=@examType Where examID=@examID", conn);
                cmd.Parameters.Add("@examID", SqlDbType.Char).Value = txtExamID.Text.Trim();
                cmd.Parameters.Add("@examType", SqlDbType.Char).Value = txtExamName.Text.Trim();

                if (DialogResult.Yes == MessageBox.Show(this, "Do you want to update this exam?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
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
            txtExamID.Clear();
            txtExamName.Clear();
            txtExamName.Focus();
            gridData();
        }

       

        private void gridData()
        {
            try
            {
                conn = new SqlConnection(cs.DBconn);
                conn.Open();
                SqlDataAdapter exam = new SqlDataAdapter("Select examID AS 'Exam ID', examType AS 'exam' FROM gceExam", conn);

                DataTable examData = new DataTable();
                exam.Fill(examData);
                dataGridView1.DataSource = examData;
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.SelectedCells[0].RowIndex;

            txtExamID.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtExamName.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();

        }

      
     

      
    }
}
