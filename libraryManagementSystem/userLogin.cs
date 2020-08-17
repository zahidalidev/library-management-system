using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace libraryManagementSystem
{
    public partial class userLogin : UserControl
    {
        //string strCon = System.Configuration.ConfigurationManager.ConnectionStrings["con"].ConnectionString;
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
            //string namebx = textBox2.Text;
            //string passwordbx = textBox1.Text;

            //SqlConnection con = new SqlConnection(strCon);
            //con.Open();
            //SqlCommand cmd = new SqlCommand("insert into admin (username, password) values(@a, @b)", con);
            //cmd.Parameters.AddWithValue("@a", namebx);
            //cmd.Parameters.AddWithValue("@b", passwordbx);

            //cmd.ExecuteNonQuery();
            //MessageBox.Show("recorde has been submitted");
            //con.Close();
            //textBox2.Text = "";
            //textBox1.Text = "";

        }
    }

}
