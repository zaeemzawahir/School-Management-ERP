namespace School_Management_ERP
{
    internal class DBConnection
    {
        public string DBconn = System.Configuration.ConfigurationManager.AppSettings["constr"].ToString();
    }
}