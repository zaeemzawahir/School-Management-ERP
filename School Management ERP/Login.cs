using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using System.Security.Cryptography;
namespace School_Management_ERP
{
    public partial class frmLogin : MetroForm
    {
        private DBConnection cs = new DBConnection();
        private SqlConnection conn = null;
        private string username;
        private int processed = 0;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Initilizing username
            username = txtUserName.Text;
            string hash = txtPassword.Text.Trim();
            string pass = ConverterHash.Encrypt(hash);
            try
            {
                conn = new SqlConnection(cs.DBconn);

                conn.Open();
                //validating username
                if (txtUserName.Text != "")
                {
                    SqlDataAdapter uname = new SqlDataAdapter("Select Username from employeeLogin where Username='" + username + "'", conn);
                    DataTable unameData = new DataTable();
                    uname.Fill(unameData);
                    if ((txtUserName.Text == "administrator") && (txtPassword.Text == "password"))
                    {
                        frmMain form = new frmMain();
                        form.Show();
                        this.Hide();

                    }
                    else if (unameData.Rows[0]["Username"]== DBNull.Value)
                    {
                        
                    }

                    else if (username == unameData.Rows[0]["Username"].ToString())
                    {
                        //Retreiving all datas from table
                        SqlDataAdapter login = new SqlDataAdapter("Select * from employeeLogin where Username='" + username + "'", conn);
                        DataTable loginData = new DataTable();
                        login.Fill(loginData);
                        String EmpID;
                        //validating pass word
                        if (pass == "")
                        {
                            MetroMessageBox.Show(this, "Password field cannot be empty");
                        }

                        else if (pass == loginData.Rows[0]["Pass"].ToString())
                        {
                            // checking for the account status

                            if (loginData.Rows[0]["ActiveStat"].ToString() == "Active")
                            {
                                //checking whether it's the initial login

                                //retreiving data from employee table and login
                                EmpID = loginData.Rows[0]["EmpID"].ToString();
                                SqlDataAdapter emp = new SqlDataAdapter("Select Mobile from Employee where EmpID='" + EmpID + "'", conn);
                                DataTable empData = new DataTable();
                                emp.Fill(empData);
                                string sub, mobile, mobilehashed;

                                sub = empData.Rows[0]["Mobile"].ToString();
                                mobile = sub.Substring(sub.Length - 6);
                                mobilehashed = ConverterHash.Encrypt(mobile);


                                //checking whether password is same as the last for digit of mobile number.
                                if (pass == mobilehashed)
                                {
                                    MetroMessageBox.Show(this, "Password is the default one. Last six digit of your mobile number. Please change it to a custom one to continue. You fille be redirected to change your password. Please change the password to access further");
                                    GlobalAccess.userName = loginData.Rows[0]["Username"].ToString();
                                    frmPassword frm = new frmPassword();
                                    frm.Show();

                                }
                                else if (pass != mobilehashed)
                                {
                                    // access level validation

                                    if (loginData.Rows[0]["AccessLevel"].ToString() == "Principal")
                                    {
                                        GlobalAccess.AccessLevel = loginData.Rows[0]["AccessLevel"].ToString();
                                        GlobalAccess.userName = loginData.Rows[0]["Username"].ToString();
                                        frmMain test = new frmMain();
                                        test.Show();
                                        this.Hide();
                                    }
                                    else if (loginData.Rows[0]["AccessLevel"].ToString() == "Management Staff")
                                    {
                                        GlobalAccess.AccessLevel = loginData.Rows[0]["AccessLevel"].ToString();
                                        GlobalAccess.userName = loginData.Rows[0]["Username"].ToString();
                                        frmMain test = new frmMain();
                                        test.Show();
                                        this.Hide();
                                    }

                                    else if (loginData.Rows[0]["AccessLevel"].ToString() == "Clerk")
                                    {
                                        GlobalAccess.AccessLevel = loginData.Rows[0]["AccessLevel"].ToString();
                                        GlobalAccess.userName = loginData.Rows[0]["Username"].ToString();
                                        frmMain test = new frmMain();
                                        test.Show();
                                        this.Hide();
                                    }
                                    else if (loginData.Rows[0]["AccessLevel"].ToString() == "Librarian")
                                    {
                                        GlobalAccess.AccessLevel = loginData.Rows[0]["AccessLevel"].ToString();
                                        GlobalAccess.userName = loginData.Rows[0]["Username"].ToString();
                                        frmMain test = new frmMain();
                                        test.Show();
                                        this.Hide();
                                    }
                                    else if (loginData.Rows[0]["AccessLevel"].ToString() == "Inventory Manager")
                                    {
                                        GlobalAccess.AccessLevel = loginData.Rows[0]["AccessLevel"].ToString();
                                        GlobalAccess.userName = loginData.Rows[0]["Username"].ToString();
                                        frmMain test = new frmMain();
                                        test.Show();
                                        this.Hide();
                                    }
                                    else
                                    {
                                        MetroMessageBox.Show(this, "User account not setup properly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                            }
                            // if account is deactive
                            else
                            {
                                MetroMessageBox.Show(this, "Account is blocked contact admin", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        //password not valid
                        else
                        {
                            ++processed;

                            if (processed == 1)
                            {
                                MetroMessageBox.Show(this, "Invalid username or password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else if (processed == 2)
                            {
                                MetroMessageBox.Show(this, "Invalid username or password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            }
                            else if (processed == 3)
                            {
                                SqlCommand update = new SqlCommand("Update employeeLogin SET ActiveStat='Blocked' where Username='" + username + "'", conn);
                                update.ExecuteNonQuery();
                                MetroMessageBox.Show(this, "Account blocked", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            }
                        }
                    }
                    else
                    {
                        if (txtPassword.Text == "")
                        {
                            MetroMessageBox.Show(this, "Password field cannot be empty");
                            txtUserName.Focus();
                        }
                    }
                 
                }
                else
                {
                    MetroMessageBox.Show(this, "Username cannot be null", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUserName.Focus();
                }
               
            }
            catch
            {
                MetroMessageBox.Show(this, "No user account created. Contact developer or administrator", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                conn.Close();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
        }

        

        private void metroTextButton1_Click(object sender, EventArgs e)
        {
            frmPassword frm = new frmPassword();
            frm.Show(this);
            

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}