using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.Runtime.Remoting.Messaging;
using System.Data;

namespace libraryManagementSystem
{
    public partial class userLogin : UserControl
    {
        //string strCon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DBLibrary;Integrated Security=True"); //path from app config
        public userLogin()
        {
            InitializeComponent();
        }

        private void userLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                //SqlConnection con = new SqlConnection(strCon);
                //opening connection
                con.Open();

                //values from the input feilds
                string email = textBox2.Text;
                string password = textBox1.Text;

                //query to the databse
                SqlCommand cmd = new SqlCommand("select * from member where email = '"+ email.Trim() +"' and " +
                                                 "password = '"+ password.Trim() +"'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                //user not exist
                if(dt.Rows.Count == 0)
                {
                    MessageBox.Show("email or password is incorrect", "login Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                //user exist
                else
                {
                    string dtEmail = dt.Rows[0][2].ToString();

                    MessageBox.Show("Login Successful", "Hi " + dtEmail,
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
    }

}
