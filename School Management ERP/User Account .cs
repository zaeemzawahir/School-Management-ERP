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
		private string username, pass;
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
					if (username == unameData.Rows[0]["Username"].ToString())
					{
                        //Retreiving all datas from table
						SqlDataAdapter login = new SqlDataAdapter("Select * from employeeLogin where Username='" + username + "'", conn);
						DataTable loginData = new DataTable();
						login.Fill(loginData);
						String EmpID;
                        //validating pass word
						if (pass == "")
						{
							MessageBox.Show("SS");
						}

						else if (pass == loginData.Rows[0]["Pass"].ToString())
						{
							MessageBox.Show("Success");
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
									MessageBox.Show("Password is the default one. Last six digit of your mobile number. Please change it to a custom one to continue");
								}
								else if (pass != mobilehashed)
								{
                                    // access level validation

                                    //super admin access
									if (loginData.Rows[0]["AccessLevel"].ToString() == "Super Admin")
									{
										GlobalAccess.AccessLevel = loginData.Rows[0]["AccessLevel"].ToString();
										frmMain test = new frmMain();
										test.Show();
									}
									else if (loginData.Rows[0]["AccessLevel"].ToString() == "Principal")
									{
										GlobalAccess.AccessLevel = loginData.Rows[0]["AccessLevel"].ToString();
										frmMain test = new frmMain();

										test.Show();
									}
									else if (loginData.Rows[0]["AccessLevel"].ToString() == "Management Staff")
									{
										GlobalAccess.AccessLevel = loginData.Rows[0]["AccessLevel"].ToString();
										frmMain test = new frmMain();
										test.Show();
									}
									else if (loginData.Rows[0]["AccessLevel"].ToString() == "Head Clerk")
									{
										GlobalAccess.AccessLevel = loginData.Rows[0]["AccessLevel"].ToString();
										frmMain test = new frmMain();
										test.Show();
									}
									else if (loginData.Rows[0]["AccessLevel"].ToString() == "Clerk")
									{
										GlobalAccess.AccessLevel = loginData.Rows[0]["AccessLevel"].ToString();
										frmMain test = new frmMain();
										test.Show();
									}
									else if (loginData.Rows[0]["AccessLevel"].ToString() == "Librarian")
									{
										GlobalAccess.AccessLevel = loginData.Rows[0]["AccessLevel"].ToString();
										frmMain test = new frmMain();
										test.Show();
									}
									else if (loginData.Rows[0]["AccessLevel"].ToString() == "Inventory Manager")
									{
										GlobalAccess.AccessLevel = loginData.Rows[0]["AccessLevel"].ToString();
										frmMain test = new frmMain();
										test.Show();
									}
									else
									{
										MessageBox.Show("User account not setup properly");
									}
								}
							}
                             // if account is deactive
							else
							{
								MessageBox.Show("Account is blocked contact admin");
							}
						}
                           //password not valid
						else
						{
							++processed;

							if (processed == 1)
							{
								MetroMessageBox.Show(this,"Invalid username or password","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
							}
							else if (processed == 2)
							{
								MetroMessageBox.Show(this,"Invalid username or password","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);

							}
							else if (processed == 3)
							{
								SqlCommand update = new SqlCommand("Update employeeLogin SET ActiveStat='2' where Username='" + username + "'", conn);
								update.ExecuteNonQuery();
							 MetroMessageBox.Show(this,"Account blocked","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);

							}
						}
					}
					else
					{
						if (txtPassword.Text == "")
						{
							MetroMessageBox.Show("Password field cannot be empty");
							txtUserName.Focus();
						}
					}
				}
				else
				{
					MetroMessageBox.Show(this, "Message box cannot be null", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
					txtUserName.Focus();
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

		private void frmLogin_Load(object sender, EventArgs e)
		{
		}

		private void button1_Click(object sender, EventArgs e)
		{
			frmMain main = new frmMain();
			main.Show();
			this.Hide();
		}
	}
}