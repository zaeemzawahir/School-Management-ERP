using System;
using System.Windows.Forms;

namespace School_Management_ERP.UserControls
{
    public partial class UserControlTest1 : UserControl
    {
        public UserControlTest1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }
    }
}