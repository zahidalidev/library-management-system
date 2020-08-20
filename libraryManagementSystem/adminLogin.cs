using System.Windows.Forms;
using System;
using System.Data.SqlClient;
using System;
using System.Configuration;
using System.Runtime.Remoting.Messaging;
using System.Data;

namespace libraryManagementSystem
{
    public partial class adminLogin : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DBLibrary;Integrated Security=True"); //path from app config

        public adminLogin()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, System.EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, System.EventArgs e)
        {

        }

        private void loginButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                //SqlConnection con = new SqlConnection(strCon);
                //opening connection
                con.Open();

                //values from the input feilds
                string username = textBox2.Text;
                string password = textBox1.Text;

                //query to the databse
                SqlCommand cmd = new SqlCommand("select * from admin where username = '" + username.Trim() + "' and " +
                                                 "password = '" + password.Trim() + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                //user not exist
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("email or password is incorrect", "login Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                //user exist
                else
                {
                    string dtUsername = dt.Rows[0][1].ToString();

                    MessageBox.Show("Login Successful", "Hi " + dtUsername,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                //closing connection
                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "login Error",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void adminLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
