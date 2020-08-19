using System.Windows.Forms;
using System.Configuration;
using System;
using System.Data.SqlClient;

namespace libraryManagementSystem
{
    public partial class signup : UserControl
    {
        string strCon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        public signup()
        {
            InitializeComponent();
        }

        private void signup_Load(object sender, System.EventArgs e)
        {

        }

        private void label3_Click(object sender, System.EventArgs e)
        {

        }

        private void label8_Click(object sender, System.EventArgs e)
        {

        }

        private void loginButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strCon);
                con.Open();

                string password = upPassword.Text.Trim();
                string fullname = upFullName.Text.Trim();
                string mobileNumber = textBox2.Text.Trim();
                string email = upEmail.Text.Trim();
                string streetAdrress = upStreet.Text.Trim();
                string city = textBox4.Text.Trim();
                string state = upState.Text.Trim();
                string IDCardNumber = upCnic.Text.Trim();


            }
            catch (Exception error)
            {

            }
        }
    }
}
