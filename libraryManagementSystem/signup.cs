using System.Windows.Forms;
using System.Configuration;
using System;
using System.Data.SqlClient;
using System.Data;

namespace libraryManagementSystem
{
    public partial class signup : UserControl
    {
        //connection string from app.config
        //string strCon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DBLibrary;Integrated Security=True");

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
            //SqlConnection con = new SqlConnection(strCon);
            
            //openning connection if it is close
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            try
            {
                string password = upPassword.Text.Trim();
                string fullname = upFullName.Text.Trim();
                string mobileNumber = textBox2.Text.Trim();
                string email = upEmail.Text.Trim();
                string streetAdrress = upStreet.Text.Trim();
                string city = textBox4.Text.Trim();
                string state = upState.Text.Trim();
                string IDCardNumber = upCnic.Text.Trim();

                //start transaction
                SqlCommand tra = new SqlCommand("begin tran", con);
                tra.ExecuteNonQuery();

                //cheking the user already exist or not
                SqlCommand cmd4 = new SqlCommand("select * from member where email = @email", con);
                cmd4.Parameters.AddWithValue("@email", email);
                SqlDataAdapter da4 = new SqlDataAdapter(cmd4);
                DataTable dt4 = new DataTable();
                da4.Fill(dt4);

                if(dt4.Rows.Count == 0){
                    //insertin values in member table
                    SqlCommand cmd = new SqlCommand("insert into member values( @password, @fullname, "+
                        "@mobileNumber, @email, @IDCardNumber)", con);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@fullname", fullname);
                    cmd.Parameters.AddWithValue("@mobileNumber", mobileNumber);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@IDCardNumber", IDCardNumber);
                    cmd.ExecuteNonQuery();

                    //getting memberID of above user from the last row of the table because latest memberID will be there
                    SqlCommand cmd2 = new SqlCommand("select memberID from member order by memberID desc", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd2);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    string memberID = dt.Rows[0][0].ToString();

                    //inserting the member address of above table
                    SqlCommand cmd3 = new SqlCommand("insert into memberAddress values (@memberID, @streetAdrress, @city, @state)", con);
                    cmd3.Parameters.AddWithValue("@memberID", memberID);
                    cmd3.Parameters.AddWithValue("@streetAdrress", streetAdrress);
                    cmd3.Parameters.AddWithValue("@city", city);
                    cmd3.Parameters.AddWithValue("@state", state);
                    cmd3.ExecuteNonQuery();

                    //commit transaction
                    SqlCommand commit = new SqlCommand("commit", con);
                    commit.ExecuteNonQuery();

                    //close connection
                    con.Close();

                    MessageBox.Show("Sign Up Successfull", "Hi " + fullname,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("User already Exist try to login", "Sign Up Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            catch (Exception error)
            {
                //rollback transaction
                SqlCommand roll = new SqlCommand("rollback", con);
                roll.ExecuteNonQuery();

                //close connection
                con.Close();

                //showing exception
                MessageBox.Show(error.Message, "Sign Up Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
