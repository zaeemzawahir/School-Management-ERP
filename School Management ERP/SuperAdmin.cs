using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;


namespace School_Management_ERP
{
    public partial class frmMain : MetroForm
    {
        private DBConnection cs = new DBConnection();
        private SqlConnection conn = null;
        public frmMain()
        {
            InitializeComponent();
            timer1.Interval = 300 * 1;              // Timer will tick every second
            timer1.Enabled = true;
        }

        private void FormTest_Load(object sender, EventArgs e)
        {
            showResult();
            shouEmployeeCount();
            if (GlobalAccess.AccessLevel == "Librarian")
            {
                studentToolStripMenuItem1.Enabled = false;
                curriculamToolStripMenuItem.Enabled = false;
                empToolStripMenuItem.Enabled = false;

                inventorysubToolStripMenuItem.Enabled = false;
                resourceToolStripMenuItem.Enabled = false;
                studentsubToolStripMenuItem.Enabled = false;
            }
            else if (GlobalAccess.AccessLevel == "Inventory Manager")
            {

                studentsubToolStripMenuItem.Enabled = false;
                studentToolStripMenuItem1.Enabled = false;
                curriculamToolStripMenuItem.Enabled = false;
                libraryToolStripMenuItem2.Enabled = false;
                empToolStripMenuItem.Enabled = false;
                libToolStripMenuItem1.Enabled = false;

            }
            else if (GlobalAccess.AccessLevel == "Management Staff")
            {
                inventorysubToolStripMenuItem.Enabled = false;
                resourceToolStripMenuItem.Enabled = false;
                libToolStripMenuItem1.Enabled = false;
                libraryToolStripMenuItem2.Enabled = false;
                userAccountToolStripMenuItem.Enabled = false;
            }

            else if (GlobalAccess.AccessLevel == "Clerk")
            {
                libToolStripMenuItem1.Enabled = false;
                empToolStripMenuItem.Enabled = false;
                libraryToolStripMenuItem2.Enabled = false;
                inventorysubToolStripMenuItem.Enabled = false;
                resourceToolStripMenuItem.Enabled = false;

            }

        }
        private void shouEmployeeCount()
        {
            conn = new SqlConnection(cs.DBconn);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            da.SelectCommand = new SqlCommand("Select Category, Count(*) AS Count FROM Employee GROUP BY Category  ORDER BY COUNT DESC", conn);
            da.Fill(ds, "FooTable");
            dt = ds.Tables["FooTable"];
            chart1.DataSource = dt;

            chart1.Series["Series1"].XValueMember = "Category";
            //set the member columns of the chart data source used to data bind to the X-values of the series

            chart1.Series["Series1"].YValueMembers = "Count";
            
        }

        private void showResult()
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
        }

        private void btnStudentDetails_Click(object sender, EventArgs e)
        {
            StudentDetail studentDetails = new StudentDetail();
            studentDetails.Show(this);
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            frmStudent Student = new frmStudent();
            Student.Show(this);
        }

        private void btnBookDetails_Click(object sender, EventArgs e)
        {
            frmViewBook viewBook = new frmViewBook();
            viewBook.Show(this);
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            frmStudentMemReg lib = new frmStudentMemReg();
            lib.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bookIssueReturn IssueReturn = new bookIssueReturn();
            IssueReturn.Show(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeAdd emp = new EmployeeAdd();
            emp.Show(this);
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnEmployeeDetails_Click(object sender, EventArgs e)
        {
            EmployeeAdd emp = new EmployeeAdd();
            emp.Show(this);

        }

        private void button4_Click(object sender, EventArgs e)
        {

            EmployeeDetails emp = new EmployeeDetails();
            emp.Show(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LibraryEmpMember library = new LibraryEmpMember();
            library.Show(this);
        }


        private void updateStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentDetail studentDetail = new StudentDetail();

            studentDetail.Show(this);
        }

        private void enrollStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudent addStudent = new frmStudent();

            addStudent.Show(this);
        }

        private void newEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            EmployeeAdd addEmployee = new EmployeeAdd();

            addEmployee.Show(this);

        }

        private void maintainEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeDetails employeedetails = new EmployeeDetails();
            if ((Application.OpenForms["employeedetails"]) != null)
            {
                employeedetails.Focus();
            }
            else
            {
                // Form is not open

                employeedetails.Show(this);

            }

        }

        private void attendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAttendance attendance = new frmAttendance();

            attendance.Show(this);
        }


        private void addBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBook BookAdd = new AddBook();

            BookAdd.Show(this);
        }

        private void maintainBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewBook viewBook = new frmViewBook();

            viewBook.Show(this);
        }

        private void studentToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmStudentMemReg studentReg = new frmStudentMemReg();

            studentReg.Show(this);

        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LibraryEmpMember empMember = new LibraryEmpMember();

            empMember.Show(this);
        }

        private void issueRenewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bookIssueReturn bookIssue = new bookIssueReturn();

            bookIssue.Show(this);
        }

        private void locationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddLocation Location = new AddLocation();

            Location.Show(this);
        }

        private void resourceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Resources resource = new Resources();
            resource.Show(this);
        }

        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Items addItems = new Add_Items();
            addItems.Show(this);
        }

        private void lnkClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmLogin login = new frmLogin();
          
            login.Show();
        }

        private void maintainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaintainItems maintain = new frmMaintainItems();
            maintain.Show(this);
        }

        private void userAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUser accounts = new frmUser();
            accounts.Show(this);
        }


        private void examTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            examType exam = new examType();
            exam.Show(this);
        }

        private void subjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSubject subject = new frmSubject();
            subject.Show(this);
        }

        private void oLResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOlResults olResult = new frmOlResults();
            olResult.Show(this);
        }

        private void oLResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOlResultReport frm = new frmOlResultReport();
            frm.Show(this);
        }

        private void chart3_Click(object sender, EventArgs e)
        {

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            frmPassword frm = new frmPassword();
            frm.Show(this);
        }

        private void studentToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void bookReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Book_List obj = new Book_List();
            obj.Show(this);

        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void generalListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            General_Inventory obj = new General_Inventory();
            obj.Show(this);
        }

        private void categorizedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategorizedList obj = new CategorizedList();
            obj.Show(this);
        }

        private void libraryToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void bookReportByGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fullList obj = new fullList();
            obj.Show(this);
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void resourceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

     

       

    }
}