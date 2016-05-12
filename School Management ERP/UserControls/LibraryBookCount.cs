using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace School_Management_ERP.UserControls
{
    public partial class LibraryBookCount : UserControl
    {
        public LibraryBookCount()
        {
            InitializeComponent();
        }
       DBConnection cs = new DBConnection();
       SqlConnection conn = null;
        private void LibraryBookCount_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(cs.DBconn);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            da.SelectCommand = new SqlCommand("Select Category, Count(*) As Quantity FROM Book GROUP BY Category", conn);
            da.Fill(ds, "FooTable");
            dt = ds.Tables["FooTable"];
            chart1.DataSource = dt;

            chart1.Series["Series1"].XValueMember = "Category";
            //set the member columns of the chart data source used to data bind to the X-values of the series
            chart1.Series["Series1"].YValueMembers = "Quantity";
            chart1.Titles.Add("Salary Chart");

        }
    }
}
