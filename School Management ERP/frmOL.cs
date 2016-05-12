using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace School_Management_ERP
{
    public partial class frmOlResults : MetroForm
    {
        private DBConnection cs = new DBConnection();
        private SqlConnection conn = null;
        private string exam = "OL";
        private SqlDataAdapter grid;
        private DataTable data;

        public frmOlResults()
        {
            InitializeComponent();
            dataGridView1.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(dataGridView1_EditingControlShowing);

        }

        private void frmOL_Load(object sender, EventArgs e)
        {
            Subject();
            Clear();
        }

        private void Subject()
        {
            conn = new SqlConnection(cs.DBconn);
            try
            {
                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter("Select SubjectName, SubjectID from gceSubjects", conn);

                DataTable ds = new DataTable();
                da.Fill(ds);

                //declaring binding context

                cmbSubject2.BindingContext = new BindingContext();
                cmbSubject3.BindingContext = new BindingContext();
                cmbSubject4.BindingContext = new BindingContext();
                cmbSubject5.BindingContext = new BindingContext();
                cmbSubject6.BindingContext = new BindingContext();
                cmbSubject7.BindingContext = new BindingContext();
                cmbSubject8.BindingContext = new BindingContext();
                cmbSubject9.BindingContext = new BindingContext();

                //declaring display values
                cmbSubject1.DisplayMember = "SubjectName";
                cmbSubject2.DisplayMember = "SubjectName";
                cmbSubject3.DisplayMember = "SubjectName";
                cmbSubject4.DisplayMember = "SubjectName";
                cmbSubject5.DisplayMember = "SubjectName";
                cmbSubject6.DisplayMember = "SubjectName";
                cmbSubject7.DisplayMember = "SubjectName";
                cmbSubject8.DisplayMember = "SubjectName";
                cmbSubject9.DisplayMember = "SubjectName";

                //declaring Value members

                cmbSubject1.ValueMember = "SubjectID";
                cmbSubject2.ValueMember = "SubjectID";
                cmbSubject3.ValueMember = "SubjectID";
                cmbSubject4.ValueMember = "SubjectID";
                cmbSubject5.ValueMember = "SubjectID";
                cmbSubject6.ValueMember = "SubjectID";
                cmbSubject7.ValueMember = "SubjectID";
                cmbSubject8.ValueMember = "SubjectID";
                cmbSubject9.ValueMember = "SubjectID";

                //declaring datasource

                cmbSubject1.DataSource = ds;
                cmbSubject2.DataSource = ds;
                cmbSubject3.DataSource = ds;
                cmbSubject4.DataSource = ds;
                cmbSubject5.DataSource = ds;
                cmbSubject6.DataSource = ds;
                cmbSubject7.DataSource = ds;
                cmbSubject8.DataSource = ds;
                cmbSubject9.DataSource = ds;
            }
            catch
            {
                // write exception info to log or anything else
                MetroMessageBox.Show(this, "Values are unavailable because the application is unable contact the database server." +
                "Try restarting the application", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                conn.Close();
            }
        }

        private void recordExists()
        {
            conn = new SqlConnection(cs.DBconn);
            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select StudentID,SubjectID,examID from gceResult WHERE StudentID='" + txtSearchID.Text + "'and examID='" + exam + "'", conn);

                DataTable ds = new DataTable();
                da.Fill(ds);
                if (ds.Rows.Count != 0)
                {
                    MetroMessageBox.Show(this, "Record for the ID entered alread exists.You can update using the update function below", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gridData();
                    btnSave.Enabled = false;
                }
                else
                {
                    
                    btnSave.Enabled = true;
                  
                }
            }
            finally
            {
                conn.Close();
            }
        }

        private void Save()
        {
            conn = new SqlConnection(cs.DBconn);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Insert into gceResult(StudentID,SubjectID,result,examID)values" +
                 "(@StudentID,@SubjectID1,@result1,@examID),(@StudentID,@SubjectID2,@result2,@examID),(@StudentID,@SubjectID3,@result3,@examID)," +
                     "(@StudentID,@SubjectID4,@result4,@examID),(@StudentID,@SubjectID5,@result5,@examID),(@StudentID,@SubjectID6,@result6,@examID)," +
                     "(@StudentID,@SubjectID7,@result7,@examID),(@StudentID,@SubjectID8,@result8,@examID),(@StudentID,@SubjectID9,@result9,@examID)", conn);
                cmd.Parameters.Add("@StudentID", SqlDbType.Char).Value = txtSearchID.Text.Trim();

                cmd.Parameters.Add("@SubjectID1", SqlDbType.VarChar).Value = cmbSubject1.SelectedValue.ToString();
                cmd.Parameters.Add("@SubjectID2", SqlDbType.VarChar).Value = cmbSubject2.SelectedValue.ToString();
                cmd.Parameters.Add("@SubjectID3", SqlDbType.VarChar).Value = cmbSubject3.SelectedValue.ToString();
                cmd.Parameters.Add("@SubjectID4", SqlDbType.VarChar).Value = cmbSubject4.SelectedValue.ToString();
                cmd.Parameters.Add("@SubjectID5", SqlDbType.VarChar).Value = cmbSubject5.SelectedValue.ToString();
                cmd.Parameters.Add("@SubjectID6", SqlDbType.VarChar).Value = cmbSubject6.SelectedValue.ToString();
                cmd.Parameters.Add("@SubjectID7", SqlDbType.VarChar).Value = cmbSubject7.SelectedValue.ToString();
                cmd.Parameters.Add("@SubjectID8", SqlDbType.VarChar).Value = cmbSubject8.SelectedValue.ToString();
                cmd.Parameters.Add("@SubjectID9", SqlDbType.VarChar).Value = cmbSubject9.SelectedValue.ToString();

                cmd.Parameters.Add("@result1", SqlDbType.VarChar).Value = cmbResult1.Text.Trim();
                cmd.Parameters.Add("@result2", SqlDbType.VarChar).Value = cmbResult2.Text.Trim();
                cmd.Parameters.Add("@result3", SqlDbType.VarChar).Value = cmbResult3.Text.Trim();
                cmd.Parameters.Add("@result4", SqlDbType.VarChar).Value = cmbResult4.Text.Trim();
                cmd.Parameters.Add("@result5", SqlDbType.VarChar).Value = cmbResult5.Text.Trim();
                cmd.Parameters.Add("@result6", SqlDbType.VarChar).Value = cmbResult6.Text.Trim();
                cmd.Parameters.Add("@result7", SqlDbType.VarChar).Value = cmbResult7.Text.Trim();
                cmd.Parameters.Add("@result8", SqlDbType.VarChar).Value = cmbResult8.Text.Trim();
                cmd.Parameters.Add("@result9", SqlDbType.VarChar).Value = cmbResult9.Text.Trim();

                cmd.Parameters.Add("@examID", SqlDbType.Char).Value = exam;

                if (DialogResult.Yes == MetroMessageBox.Show(this,"Are you sure you want to save result for this student? The subjects selected here cannot be changed later. Although you can update the grades later" +
                    ".If you are sure about the subject selection and do not want to change click Yes", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    cmd.ExecuteNonQuery();
                }
               
             
            }
            catch
            {
                if (conn.State != ConnectionState.Open || conn.State == ConnectionState.Broken)
                {
                    MetroMessageBox.Show(this, "The application is unable contact the database server. Try restarting the application", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MetroMessageBox.Show(this, "Are you trying to save the same subject twice. Please select distinct subjects");
               
                }
            }
            finally
            {
                conn.Close();
            }
        }

        private void Clear()
        {
            cmbSubject1.SelectedIndex = -1;
            cmbSubject2.SelectedIndex = -1;
            cmbSubject3.SelectedIndex = -1;
            cmbSubject4.SelectedIndex = -1;
            cmbSubject5.SelectedIndex = -1;
            cmbSubject6.SelectedIndex = -1;
            cmbSubject7.SelectedIndex = -1;
            cmbSubject8.SelectedIndex = -1;
            cmbSubject9.SelectedIndex = -1;

            cmbResult1.SelectedIndex = -1;
            cmbResult2.SelectedIndex = -1;
            cmbResult3.SelectedIndex = -1;
            cmbResult4.SelectedIndex = -1;
            cmbResult5.SelectedIndex = -1;
            cmbResult6.SelectedIndex = -1;
            cmbResult7.SelectedIndex = -1;
            cmbResult8.SelectedIndex = -1;
            cmbResult9.SelectedIndex = -1;
        }

        private void validateCombo()
        {
            if (cmbSubject1.SelectedIndex == -1 || cmbSubject2.SelectedIndex == -1 || cmbSubject3.SelectedIndex == -1 ||
                cmbSubject4.SelectedIndex == -1 || cmbSubject5.SelectedIndex == -1 || cmbSubject6.SelectedIndex == -1 ||
                cmbSubject7.SelectedIndex == -1 || cmbSubject8.SelectedIndex == -1 || cmbSubject9.SelectedIndex == -1 ||
                cmbResult1.SelectedIndex == -1 || cmbResult2.SelectedIndex == -1 || cmbResult3.SelectedIndex == -1 ||
                cmbResult4.SelectedIndex == -1 || cmbResult5.SelectedIndex == -1 || cmbResult6.SelectedIndex == -1 ||
                cmbResult7.SelectedIndex == -1 || cmbResult8.SelectedIndex == -1 || cmbResult9.SelectedIndex == -1)
            {
                MetroMessageBox.Show(this, "To save students all 9 subjects are required", "Infomrmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Save();
            }
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {
        }

        private void txtSearchID_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchID.Text.Length == txtSearchID.MaxLength)
            {
                recordExists();
            }
            else
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
            }
        }     

        private void btnSave_Click(object sender, EventArgs e)
        {
            validateCombo();
        }

        private void gridData()
        {
            conn = new SqlConnection(cs.DBconn);
            try
            {
                conn.Open();
                grid = new SqlDataAdapter("Select gceResult.SubjectID AS 'Subject Code',gceSubjects.SubjectName AS 'Subject',gceResult.result AS 'Grade'From gceSubjects JOIN gceResult on gceResult.SubjectID=gceSubjects.SubjectID Where StudentID='" + txtSearchID.Text + "'", conn);

                data = new DataTable();
                grid.Fill(data);

                DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();

                cmb.HeaderText = "New Grade";
                cmb.Name = "cmb";

                cmb.MaxDropDownItems = 4;

                cmb.Items.Add("A");
                cmb.Items.Add("B");
                cmb.Items.Add("C");
                cmb.Items.Add("S");
                cmb.Items.Add("W");
                cmb.ReadOnly = false;

                //dataGridView1.Columns.Add("Column","Test");

                //BindingSource binding = new BindingSource(0
                dataGridView1.DataSource = data;

                dataGridView1.Columns.Add(cmb);
              dataGridView1.ReadOnly = false;

              foreach (DataGridViewColumn column in this.dataGridView1.Columns)
                {
                    column.ReadOnly = (column.Name != "cmb");
                }
                dataGridView1.Columns["cmb"].DisplayIndex = 3;
                
            
                dataGridView1.Columns["cmb"].DefaultCellStyle.ForeColor = Color.Black;
                data.AcceptChanges();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
            }
        }
        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            ComboBox combo = e.Control as ComboBox;
            if (combo != null)
            {
                combo.SelectedIndexChanged -= new EventHandler(ComboBox_SelectedIndexChanged);
                combo.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);
            }
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
              conn = new SqlConnection(cs.DBconn);
              try
              {
                  conn.Open();
                  ComboBox cb = (ComboBox)sender;
                  string item = cb.Text;
                  if (item != null)
                  {
                     

                      int i;

                      i = dataGridView1.SelectedCells[0].RowIndex;

                      SqlCommand cmd = new SqlCommand("UPDATE gceResult SET gceResult.result=@result Where gceResult.SubjectID=@SubjectID and gceResult.StudentID='" + txtSearchID.Text + "'and examID='" + exam + "'", conn);

                      cmd.Parameters.AddWithValue("@SubjectID", dataGridView1.Rows[i].Cells[0].Value.ToString());
              
                      cmd.Parameters.AddWithValue("@result", cb.Text.ToString());

                      cmd.ExecuteNonQuery();
                     
                   
                  }
              }
              catch
              {
              }
        }

    
    }
}