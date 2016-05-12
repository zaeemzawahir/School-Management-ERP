using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace School_Management_ERP
{
    public partial class AddBook : MetroForm
    {
        DBConnection cs = new DBConnection();
        SqlConnection conn = null;

        public AddBook()
        {
            InitializeComponent();
        }

        private void txtTitle_GotFocus(object sender, EventArgs e)
        {
            newID();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveBook();
            ShowPieChart();
        }

        //---

        private void newID()
        {
            conn = new SqlConnection(cs.DBconn);

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select BookID from Book", conn);
                SqlDataReader dreader = cmd.ExecuteReader();
                if (dreader.HasRows == true)
                {
                    string BookID = "";
                    while (dreader.Read())
                    {
                        BookID = dreader["BookID"].ToString();
                    }
                    int num = int.Parse(BookID.Substring(1).ToString());
                    if (num < 9)
                        txtBookID.Text = "B000" + (num + 1);
                    else if (num < 99)
                        txtBookID.Text = "B00" + (num + 1);
                    else if (num < 999)
                        txtBookID.Text = "B0" + (num + 1);
                    else
                        txtBookID.Text = "B" + (num + 1);
                }
                else
                {
                    txtBookID.Text = "B0001";
                }
                dreader.Close();
                dreader.Dispose();
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

        private void Clear()
        {
            txtBookID.Clear();
            txtTitle.Clear();
            txtEdition.Clear();
            txtAuthor.Clear();
            cmbCategory.SelectedIndex = -1;

        }

        private void saveBook()
        {
            if (txtTitle.Text == "")
            {
                MessageBox.Show("Book Title field cannot be empty", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTitle.Focus();
            }
            else
            {
                //open database connection
                try
                {
                    conn = new SqlConnection(cs.DBconn);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Insert into Book(BookID,Author,Edition,Category,Title) values (@BookID,@Author,@Edition,@Category,@Title)", conn);
                    cmd.Parameters.Add("@BookID", SqlDbType.Char).Value = txtBookID.Text.Trim();
                    cmd.Parameters.Add("@Author", SqlDbType.VarChar).Value = txtAuthor.Text.Trim();
                    cmd.Parameters.Add("@Edition", SqlDbType.VarChar).Value = txtEdition.Text.Trim();
                    cmd.Parameters.Add("@Category", SqlDbType.VarChar).Value = cmbCategory.Text.Trim();
                    cmd.Parameters.Add("@Title", SqlDbType.VarChar).Value = txtTitle.Text.Trim();
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    Clear();
                    txtTitle.Focus();
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

        private void AddBook_Load(object sender, EventArgs e)
        {

              if(GlobalAccess.AccessLevel =="Management Staff")
            {
                btnSave.Enabled = false;
            }
            ShowPieChart();

        }

        private void ShowPieChart()
        {
            conn = new SqlConnection(cs.DBconn);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            da.SelectCommand = new SqlCommand("Select Category, Count(*) AS Count FROM Book GROUP BY Category", conn);
            da.Fill(ds, "FooTable");
            dt = ds.Tables["FooTable"];
            chart2.DataSource = dt;

            chart2.Series["Default"].XValueMember = "Category";
            //set the member columns of the chart data source used to data bind to the X-values of the series

            chart2.Series["Default"].YValueMembers = "Count";
            //chart2.Titles.Add("Book Availability");
            
            //string []x=new string[dt.Rows.Count];
            //int [] y = new int[dt.Rows.Count];
            //for(int i=0;i<dt.Rows.Count;i++)
            //{
            //x[i] = dt.Rows[i][0].ToString();
            //y[i] = Convert.ToInt32(dt.Rows[i][1]);
            //}
            //chart1.Series[0].Points.DataBindXY(x,y);
            //}


            //chart1.Series["PieSeries"].Points.DataBindXY(dv, "Category", dv, "Quantity");

            // Set series members names for the X and Y values
            //chart1.Series["PieSeries"].XValueMember = "Category";
            //chart1.Series["PieSeries"].YValueMembers = int.Parse("Quantity");

            //string[] x = new string[dt.Rows.Count];
            //int[] y = new int[dt.Rows.Count];
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    x[i] = dt.Rows[i][0].ToString();
            //    y[i] = Convert.ToInt32(dt.Rows[i][1]);
            //}
            //chart1.Series[0].Points.DataBindXY(x, y);

            //chart1.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = true;
            //chart1.Legends[0].Enabled = true;
            //foreach (DataRow dataRow in dt.Rows)
            //{
            //    chartPie.Series.Add("Series");
            //    chartPie.Series["Series"].YValueMembers = dataRow["Quantity"].ToString();
            //    chartPie.Series["Series"].XValueMember = dataRow["Category"].ToString();
            //}
            //chartPie.Series.Add("Series2");
            //chart1.DataBind();
        }

        private void lnkClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }
    }
}
