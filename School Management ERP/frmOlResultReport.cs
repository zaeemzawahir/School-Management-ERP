using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using MetroFramework.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.CrystalReports;
namespace School_Management_ERP
{
    public partial class frmOlResultReport : MetroForm
    {
       DBConnection cs = new DBConnection();
       SqlConnection conn = null;
        
        public frmOlResultReport()
        {
            InitializeComponent();
            metroPanel1.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbSearch.SelectedIndex = 0;
            if (cmbSearch.SelectedIndex == 0)
            {
                cmbSearch.Items.Insert(0, "-Select Criteria-");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            if (cmbSearch.Text == "Student ID")
            {
                if (txtSearch.Text.Length == txtStudentID.MaxLength) 
                {
                    Search();
                }
                else
                {
                    Clear();
                }
            }
            else if (cmbSearch.Text == "National ID")
            {
                 if (txtSearch.Text.Length == txtNic.MaxLength) 
                {
                    Search();
                }
                else
                {
                    Clear();
                }
            
            }
        
        }

        private void Search()
        {
            conn = new SqlConnection(cs.DBconn);
            try
            {
                
                
                    conn.Open();
                    DataTable dt = new DataTable();
                   SqlDataAdapter da= new SqlDataAdapter();
             

                    if (cmbSearch.Text == "Student ID")
                    {
                        da.SelectCommand = new SqlCommand("Select Student.NIC, Student.olAdmissionNo,Student.StudentID, Student.Name  From Student join gceResult on gceResult.StudentID = Student.StudentID Where Student.StudentID='" + txtSearch.Text + "'", conn);
                    }
                    else if (cmbSearch.Text == "National ID")
                    {
                        da.SelectCommand = new SqlCommand("Select Student.NIC, Student.olAdmissionNo,Student.StudentID, Student.Name  From Student join gceResult on gceResult.StudentID = Student.StudentID Where Student.NIC='" + txtSearch.Text + "'", conn);
                    }
                    else if (cmbSearch.Text == "O/L Admission No")
                    {
                        da.SelectCommand = new SqlCommand("Select Student.NIC, Student.olAdmissionNo,Student.StudentID, Student.Name  From Student join gceResult on gceResult.StudentID = Student.StudentID Where Student.olAdmissionNo='" + txtSearch.Text + "'", conn);

                    }
                    da.Fill(dt);
                    if (dt.Rows.Count != 0)
                    {
                        metroPanel1.Visible = true;
                        txtName.Text = dt.Rows[0]["Name"].ToString();
                        txtNic.Text = dt.Rows[0]["NIC"].ToString();
                        txtOlAdmission.Text = dt.Rows[0]["olAdmissionNo"].ToString();
                        txtStudentID.Text = dt.Rows[0]["StudentID"].ToString();
                    }
                    else
                    {
                        MessageBox.Show(this, "S");
                    }
                }
                
                
            
            catch(Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }
          

        private void loadReport()
        {    //Create object of report
            rptOlResult objReport = new rptOlResult();

            //set database login information
            conn = new SqlConnection(cs.DBconn);
            //write formula to pass parameters to report

            //creating an object of ParameterField class
            ParameterField paramField = new ParameterField();

            //creating an object of ParameterFields class
            ParameterFields paramFields = new ParameterFields();

            //creating an object of ParameterDiscreteValue class
            ParameterDiscreteValue paramDiscreteValue = new ParameterDiscreteValue();

            //set the parameter field name  
             paramField.Name = "StudentID";
            //set the parameter value
            paramDiscreteValue.Value = txtStudentID.Text;

            //add the parameter value in the ParameterField object
            paramField.CurrentValues.Add(paramDiscreteValue);

            //add the parameter in the ParameterFields object
            paramFields.Add(paramField);

            //set the parameterfield information in the crystal report
            crystalReportViewer1.ParameterFieldInfo = paramFields;

            crystalReportViewer1.ReportSource = objReport;
        }

        private void cmbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void metroPanel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }

        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {
            loadReport();
        }

        private void Clear()
        {
            txtName.Clear();
            txtNic.Clear();
            txtOlAdmission.Clear();
            cmbSearch.SelectedIndex = 0;
            metroPanel1.Visible = false;
            
        }
    }
}