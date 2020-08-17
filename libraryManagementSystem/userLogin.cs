using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace libraryManagementSystem
{
    public partial class userLogin : UserControl
    {
        //SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DBLibrary;Integrated Security=True"); //path from app config
        string strCon = System.Configuration.ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        //string con = System.Configuration.ConfigurationManager.ConnectionStrings["con"].ConnectionString;
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
            string namebx = textBox2.Text;
            string passwordbx = textBox1.Text;

            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into admin (username, password) values(@a, @b)", con);
            cmd.Parameters.AddWithValue("@a", namebx);
            cmd.Parameters.AddWithValue("@b", passwordbx);

            cmd.ExecuteNonQuery();
            MessageBox.Show("recorde has been submitted");
            con.Close();
            textBox2.Text = "";
            textBox1.Text = "";
            
        }
    }

    internal class ConfigurationManager
    {
    }
}
