using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace School_Management_ERP
{
    public partial class bookIssueReturn : MetroForm
    {
        private SqlConnection conn = null;
        private DBConnection cs = new DBConnection();

        private DateTime CurrentDate = DateTime.Now.Date;
        private DateTime IssueDate = DateTime.Now.Date;
        private DateTime ReturnDate = DateTime.Now.AddDays(15);
        private int Days;

        public bookIssueReturn()
        {
            InitializeComponent();
        }

        private void bookIssueReturn_Load(object sender, EventArgs e)
        {
            lblToday.Text = CurrentDate.ToShortDateString();
            lblIssueDate.Text = IssueDate.ToShortDateString();

            lblDueDate.Text = ReturnDate.ToShortDateString();
            Days = (ReturnDate - IssueDate).Days;
            txtDays.Text = Days.ToString();

            //defining visibility of labels in form

            btnReturn.Visible = false;
            lblRenewHeader.Visible = false;
            lblRenewal.Visible = false;
            lblFine.Visible = false;
            lblLkr.Visible = false; ;
            pnlEmpSearch.Visible = false;
            pnlEmployee.Visible = false;
        }

        private void txtSearchBook_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchBook.Text.Length != txtSearchBook.MaxLength)
            {
                BookClear();
            }
            if (txtSearchBook.Text != "")
            {
                bookSearch();
            }
            
        }

        ///ssss
        ///
        private void bookSearch()
        {
            try
            {
                conn = new SqlConnection(cs.DBconn);


                conn.Open();
                SqlCommand cmd = new SqlCommand("Select BookID, Title, Author FROM  Book Where BookID=@BookID", conn);
                cmd.Parameters.Add("@BookID", SqlDbType.Char).Value = txtSearchBook.Text.Trim();
                SqlDataReader dreader = cmd.ExecuteReader();
                if (dreader.HasRows == true)
                {
                    while (dreader.Read())
                    {
                        txtBookID.Text = dreader["BookID"].ToString();
                        txtAuthor.Text = dreader["Author"].ToString();
                        txtTitle.Text = dreader["Title"].ToString();
                    }
                }

            }
            catch (Exception e)
            {
                MetroMessageBox.Show(this, e.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally
            {
                conn.Close();
            }
        }


        private void studentSearch()
        {
            try
            {
                conn = new SqlConnection(cs.DBconn);

                string stat;
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Student.StudentID , Student.Name, libStudentMember.MemberShipStatus from Student join libStudentMember on Student.StudentID = libStudentMember.StudentID Where Student.StudentID=@StudentID ", conn);
                cmd.Parameters.Add("@StudentID", SqlDbType.Char).Value = txtSearchStudent.Text.Trim();
                SqlDataReader dreader = cmd.ExecuteReader();
                if (dreader.HasRows == true)
                {
                    while (dreader.Read())
                    {
                        txtStudentID.Text = dreader["StudentID"].ToString();
                        txtStudentName.Text = dreader["Name"].ToString();
                        stat = dreader["MemberShipStatus"].ToString();
                        if (stat == "Inactive")
                        {
                            MetroMessageBox.Show(this, "User account is Suspended. Please activate it to continue", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            btnIssue.Enabled = false;
                            btnChangeDueDate.Enabled = false;
                            btnReturn.Enabled = false;
                        }
                        else
                        {
                            btnIssue.Enabled = true;
                            btnChangeDueDate.Enabled = true;
                            btnReturn.Enabled = true;
                        }
                    }
                }

            }
            catch (Exception e)
            {
                MetroMessageBox.Show(this, e.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        private void studentRenew()
        {
            if (txtBookID.Text.Length == 5)
            {
                try
                {
                    conn = new SqlConnection(cs.DBconn);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT BorrowDate,DueDate,ReturnDate from BookIssueReturn where BookID=@BookID and StudentID=@StudentID", conn);
                    cmd.Parameters.Add("@BookID", SqlDbType.Char).Value = txtBookID.Text.Trim();
                    cmd.Parameters.Add("@StudentID", SqlDbType.Char).Value = txtStudentID.Text.Trim();

                    SqlDataReader dreader = cmd.ExecuteReader();
                    if (dreader.HasRows == true)
                    {
                        while (dreader.Read())
                        {
                            lblIssueDate.Text = ((DateTime)dreader["BorrowDate"]).ToString("MM/dd/yyyy");

                            lblDueDate.Text = ((DateTime)dreader["DueDate"]).ToString("MM/dd/yyyy");

                            if (dreader["ReturnDate"] == DBNull.Value)
                            {
                                btnIssue.Text = "Renew";

                                //Making controls visible for the Renewal function
                                lblRenewHeader.Visible = true;
                                lblRenewal.Visible = true;
                                btnReturn.Visible = true;
                                lblFine.Visible = true;
                                btnChangeDueDate.Enabled = false;
                                renewDate();

                                Fine();
                            }
                        }

                        dreader.Close();
                    }
                    else
                    {
                        conn.Close();

                        checkAvailability();
                    }
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, ex.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                finally
                {
                }
            }
        }

        private void employeeSeach()
        {
            try
            {
                conn = new SqlConnection(cs.DBconn);
                if (txtEmpSearchID.Text.Length == 5)
                {
                    string stat;
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT Employee.EmpID , Employee.Name, libEmployeeMember.MemberShipStatus from Employee join libEmployeeMember on Employee.EmpID = libEmployeeMember.EmpID Where Employee.EmpID=@EmpID ", conn);
                    cmd.Parameters.Add("@EmpID", SqlDbType.Char).Value = txtEmpSearchID.Text.Trim();
                    SqlDataReader dreader = cmd.ExecuteReader();
                    if (dreader.HasRows == true)
                    {
                        while (dreader.Read())
                        {
                            txtEmpID.Text = dreader["EmpID"].ToString();
                            txtEmpName.Text = dreader["Name"].ToString();
                            stat = dreader["MemberShipStatus"].ToString();
                            if (stat == "Inactive")
                            {
                                MetroMessageBox.Show(this, "User account is Suspended. Please activate it to continue", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                btnIssue.Enabled = false;
                                btnChangeDueDate.Enabled = false;
                                btnReturn.Enabled = false;
                            }
                            else
                            {
                                btnIssue.Enabled = true;
                                btnChangeDueDate.Enabled = true;
                                btnReturn.Enabled = true;
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MetroMessageBox.Show(this, e.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        private void empBookRenew()
        {
            if (txtEmpID.Text.Length == 5)
            {
                try
                {
                    conn = new SqlConnection(cs.DBconn);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT BorrowDate,DueDate,ReturnDate from BookIssueReturn where BookID=@BookID and EmpID=@EmpID", conn);
                    cmd.Parameters.Add("@BookID", SqlDbType.Char).Value = txtBookID.Text.Trim();
                    cmd.Parameters.Add("@EmpID", SqlDbType.Char).Value = txtEmpID.Text.Trim();

                    SqlDataReader dreader = cmd.ExecuteReader();
                    if (dreader.HasRows == true)
                    {
                        while (dreader.Read())
                        {
                            lblIssueDate.Text = ((DateTime)dreader["BorrowDate"]).ToString("MM/dd/yyyy");

                            lblDueDate.Text = ((DateTime)dreader["DueDate"]).ToString("MM/dd/yyyy");

                            if (dreader["ReturnDate"] == DBNull.Value)
                            {
                                btnIssue.Text = "Renew";

                                //Making controls visible for the Renewal function
                                lblRenewHeader.Visible = true;
                                lblRenewal.Visible = true;
                                btnReturn.Visible = true;
                                lblFine.Visible = true;
                                btnChangeDueDate.Enabled = false;
                                renewDate();

                                Fine();
                            }
                        }

                        dreader.Close();
                    }
                    else
                    {
                        conn.Close();

                        checkAvailability();
                    }
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, ex.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void renewOrReturnBook()
        {
            if (pnlEmployee.Visible == true)
            {
                empBookRenew();
            }
            else
            {
                studentRenew();
            }
        }

        private void checkAvailability()
        {
            if (txtSearchBook.Text.Length == 5)
            {
                try
                {
                    conn = new SqlConnection(cs.DBconn);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT BookIssueReturn.ReturnDate from BookIssueReturn where BookID=@BookID", conn);
                    cmd.Parameters.Add("@BookID", SqlDbType.Char).Value = txtSearchBook.Text.Trim();
                    SqlDataReader dreader = cmd.ExecuteReader();
                    if (dreader.HasRows == true)
                    {
                        while (dreader.Read())
                        {
                            if (dreader["ReturnDate"] == DBNull.Value)
                            {
                                DialogResult DialogResult;
                                if (DialogResult.OK == MetroMessageBox.Show(this, "Book Not available", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information))
                                {
                                    txtSearchBook.Focus();
                                    btnIssue.Enabled = false;
                                }
                            }
                        }
                    }
                }
                catch (Exception e)
                {
              
                    MetroMessageBox.Show(this, e.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void bookIssue()
        {
            try
            {
                conn = new SqlConnection(cs.DBconn);
                conn.Open();

                if (pnlEmployee.Visible == true)
                {
                    SqlCommand cmd = new SqlCommand("issueBookEmployee", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@BookID", SqlDbType.Char).Value = txtBookID.Text.Trim();
                    cmd.Parameters.Add("@EmpID", SqlDbType.Char).Value = txtEmpID.Text.Trim();
                    cmd.Parameters.Add("@BorrowDate", SqlDbType.Date).Value = lblIssueDate.Text.Trim();
                    cmd.Parameters.Add("@DueDate", SqlDbType.Date).Value = lblDueDate.Text.Trim();

                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    Clear();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("issueBookStudent", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@BookID", SqlDbType.Char).Value = txtBookID.Text.Trim();
                    cmd.Parameters.Add("@StudentID", SqlDbType.Char).Value = txtStudentID.Text.Trim();
                    cmd.Parameters.Add("@BorrowDate", SqlDbType.Date).Value = lblIssueDate.Text.Trim();
                    cmd.Parameters.Add("@DueDate", SqlDbType.Date).Value = lblDueDate.Text.Trim();
                    cmd.ExecuteNonQuery();
                    MetroMessageBox.Show(this, "Book Issued", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Clear();
                }
            }
            catch (Exception e)
            {
                MetroMessageBox.Show(this, e.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        private void Renew()
        {
            if (pnlEmployee.Visible == true)
            {
                try
                {
                    conn = new SqlConnection(cs.DBconn);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE BookIssueReturn SET DueDate=@DueDate Where EmpID=@EmpID and BookID=@BookID", conn);
                    cmd.Parameters.Add("@BookID", SqlDbType.Char).Value = txtBookID.Text.Trim();
                    cmd.Parameters.Add("@EmpID", SqlDbType.Char).Value = txtEmpID.Text.Trim();
                    cmd.Parameters.Add("@DueDate", SqlDbType.Date).Value = lblDueDate.Text.Trim();
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    BookClear();
                    txtSearchBook.Clear();
                    MetroMessageBox.Show(this, "Book renewed succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, ex.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
            }
            else
            {
                try
                {
                    conn = new SqlConnection(cs.DBconn);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE BookIssueReturn SET DueDate=@DueDate Where StudentID=@StudentID and BookID=@BookID", conn);
                    cmd.Parameters.Add("@BookID", SqlDbType.Char).Value = txtBookID.Text.Trim();
                    cmd.Parameters.Add("@StudentID", SqlDbType.Char).Value = txtStudentID.Text.Trim();
                    cmd.Parameters.Add("@DueDate", SqlDbType.Date).Value = lblDueDate.Text.Trim();
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();

                    MetroMessageBox.Show(this, "Book renewed succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BookClear();
                }
                catch (Exception e)
                {
                    MetroMessageBox.Show(this, e.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    throw;
                }
            }
        }

        private void Fine()
        {
            lblLkr.Visible = true;
            string S = lblDueDate.Text;
            int fine = 5;
            DateTime dtCurrDate;

            dtCurrDate = DateTime.ParseExact(S, "MM/dd/yyyy", null);

            int Due = (CurrentDate - dtCurrDate).Days;

            if (Due > 0)
            {
                int totalFine = Due * fine;
                lblFine.Text = totalFine.ToString();
            }
            else
            {
                int val = 0;
                lblFine.Text = val.ToString();
                lblLkr.Text = "";
            }
        }

        private void Clear()
        {
            BookClear();
            BorrowerClear();
            txtSearchStudent.Clear();
            txtEmpSearchID.Clear();
            txtSearchBook.Clear();
            lblDueDate.Text = ReturnDate.ToString("MM/dd/yy");
            txtDays.Text = Days.ToString();
        }

        private void BookClear()
        {
            btnChangeDueDate.Enabled = true;
            txtBookID.Clear();
            txtAuthor.Clear();
            txtTitle.Clear();
            lblIssueDate.Text = IssueDate.ToShortDateString();
            lblDueDate.Text = ReturnDate.ToShortDateString();
            lblFine.Text = "";
            lblRenewal.Visible = false;
            lblRenewHeader.Visible = false;
            lblLkr.Visible = false;
            btnIssue.Text = "Issue";
            btnIssue.Enabled=true;
            btnReturn.Visible = false;
        }

        private void BorrowerClear()
        {


            txtStudentID.Clear();
            txtStudentName.Clear();
            txtEmpID.Clear();
            txtEmpName.Clear();
            Days = (ReturnDate - IssueDate).Days;
        }

        private void btnChangeDueDate_Click(object sender, EventArgs e)
        {   if(txtDays.Text ==Days.ToString())
            {
                MetroMessageBox.Show(this,"Due day hasn't been changed. Please enter a greater value than the defualt 15 days","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
             }
else{
            
            txtDays.Enabled = true;
            int Day, newDay;
            Day = int.Parse(txtDays.Text);
            ReturnDate = IssueDate.AddDays(Day);
            newDay = (ReturnDate - IssueDate).Days;
         lblDueDate.Text=   ReturnDate.ToString("MM/dd/yyyy");
            MetroMessageBox.Show(this, "Due date chaned till " + ReturnDate.ToString("MM/dd/yyyy") + "", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }}

        private void btnReturn_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(cs.DBconn);
                conn.Open();

                if (pnlEmployee.Visible == true)
                {
                    int value = int.Parse(lblFine.Text);

                    Fine();
                    SqlCommand cmd = new SqlCommand("Update  BookIssueReturn SET ReturnDate=@ReturnDate, SET Fine=@Fine Where EmpID=@EmpID and BookID=@BookID and ReturnDate IS NULL", conn);
                    cmd.Parameters.Add("@BookID", SqlDbType.Char).Value = txtBookID.Text.Trim();
                    cmd.Parameters.Add("@EmpID", SqlDbType.Char).Value = txtEmpID.Text.Trim();
                    cmd.Parameters.Add("@ReturnDate", SqlDbType.Date).Value = CurrentDate.ToString();
                    cmd.Parameters.Add("Fine", SqlDbType.Int).Value = value;
                    MetroMessageBox.Show(this, "Book returned", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtSearchBook.Clear();
                    txtSearchStudent.Clear();
                    cmd.ExecuteNonQuery();
                    Clear();
                }
                else
                {
                    Fine();
                    int value = int.Parse(lblFine.Text);
                    SqlCommand cmd = new SqlCommand("Update  BookIssueReturn SET ReturnDate=@ReturnDate, Fine=@Fine Where StudentID=@StudentID and BookID=@BookID", conn);
                    cmd.Parameters.Add("@BookID", SqlDbType.Char).Value = txtBookID.Text.Trim();
                    cmd.Parameters.Add("@StudentID", SqlDbType.Char).Value = txtStudentID.Text.Trim();
                    cmd.Parameters.Add("@ReturnDate", SqlDbType.Date).Value = CurrentDate.ToString();
                    cmd.Parameters.Add("Fine", SqlDbType.Int).Value = value;
                    MetroMessageBox.Show(this, "Book returned", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtSearchBook.Clear();
                    txtSearchStudent.Clear();
                    cmd.ExecuteNonQuery();
                    BookClear();
                    BorrowerClear();
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void renewDate()
        {
            if ((lblRenewHeader.Visible == true) && (lblRenewal.Visible == true))
            {
               DateTime dtCurrDate, RenewDate;

               string S = lblDueDate.Text;

                dtCurrDate = DateTime.ParseExact(S, "MM/dd/yyyy", null);
                
                

                int renew = 15;

                RenewDate = dtCurrDate.AddDays(renew);
                Days = (dtCurrDate - RenewDate).Days;

                lblRenewal.Text = RenewDate.ToString("dd/MM/yyyy");
            }
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (btnIssue.Text == "Renew")
            {
                Renew();
                Clear();
                btnIssue.Text = "Issue";
            }
            else
            {
                bookIssue();

                Clear();
            }
        }

        private void txtBookID_TextChanged(object sender, EventArgs e)
        {
            renewOrReturnBook();
        }

        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void txtEmpSearchID_TextChanged(object sender, EventArgs e)
        {
            if (txtEmpSearchID.Text.Length != txtEmpSearchID.MaxLength)
            {
                BorrowerClear();
            }
            if (txtEmpSearchID.Text != "")
            {
                employeeSeach();
            }

            
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            pnlEmployee.Visible = true;
            pnlEmpSearch.Visible = true;
            txtSearchStudent.Visible = false;
            txtEmpSearchID.Focus();
            txtSearchBook.TabIndex = 2;
            txtDays.TabIndex = 3;
            btnChangeDueDate.TabIndex = 4;
            btnIssue.TabIndex = 5;
            btnReturn.TabIndex = 6;
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            pnlEmployee.Visible = false;
            pnlEmpSearch.Visible = false;
            txtSearchStudent.Visible = true;
        }

        private void txtSearchBook_SizeChanged(object sender, EventArgs e)
        {
         
            Clear();
        }



        private void txtSearchStudent_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchStudent.Text.Length != txtSearchStudent.MaxLength)
            {
                BorrowerClear();
            }
            if (txtSearchStudent.Text != "")
            {
                studentSearch();
            }


        }

        private void lnkClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}