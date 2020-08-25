using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace libraryManagementSystem
{

    public partial class Form1 : Form
    {
    
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DBLibrary;Integrated Security=True"); //path from app config
        
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            sideHome.Height = button8.Height;
            sideHome.Top = button8.Top;
            viewBooks1.Show();
            viewBooks1.BringToFront();

            //label of name
            button1.Visible = false;
            //login
            button2.Visible = true;
            //signup
            button10.Visible = true;
            //author
            button11.Visible = false;
            //publisher
            button12.Visible = false;
            //book manager
            button13.Visible = false;
            //book issue
            button14.Visible = false;
            //manage user
            button15.Visible = false;
            //logout
            button16.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sideHome.Height = button2.Height;
            sideHome.Top = button2.Top;
            this.BringToFront();

            viewBooks1.SendToBack();
            signup1.SendToBack();
            userProfile1.Hide();
            signup1.Hide();
            manageUser1.SendToBack();
            authorManage1.SendToBack();
            publisherManage1.SendToBack();
            books1.SendToBack();
            bookIssue1.SendToBack();
            userProfile1.SendToBack();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            sideHome.Height = button8.Height;
            sideHome.Top = button8.Top;
            viewBooks1.Show();
            viewBooks1.BringToFront();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            sideHome.Height = button10.Height;
            sideHome.Top = button10.Top;

            viewBooks1.SendToBack();
            viewBooks1.Hide();

            signup1.Show();
            signup1.BringToFront();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            sideHome.Height = button15.Height;
            sideHome.Top = button15.Top;
            manageUser1.BringToFront();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            sideHome.Height = button11.Height;
            sideHome.Top = button11.Top;
            authorManage1.BringToFront();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            sideHome.Height = button12.Height;
            sideHome.Top = button12.Top;
            publisherManage1.BringToFront();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            sideHome.Height = button13.Height;
            sideHome.Top = button13.Top;
            books1.BringToFront();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            sideHome.Height = button14.Height;
            sideHome.Top = button14.Top;
            bookIssue1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sideHome.Height = button1.Height;
            sideHome.Top = button1.Top;
            viewBooks1.Hide();
            viewBooks1.SendToBack();
            userProfile1.Show();
            userProfile1.BringToFront();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            sideHome.Height = button16.Height;
            sideHome.Top = button16.Top;
            //refereshing page
            Form1_Load(sender, e);
        }

        private void adminLogin1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userLogin1_Load(object sender, EventArgs e)
        {
            
        }

        private void manageUser1_Load(object sender, EventArgs e)
        {
        }

        private void userLogin1_Load_1(object sender, EventArgs e)
        {
            
        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                //SqlConnection con = new SqlConnection(strCon);

                //opening connection if it is close
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                //values from the input feilds
                string email = textBox2.Text.Trim();
                string password = textBox1.Text.Trim();


                //query to the databse /cheking admin 
                SqlCommand aCmd = new SqlCommand("select * from admin where email = @email and password = @password", con);
                aCmd.Parameters.AddWithValue("@email", email);
                aCmd.Parameters.AddWithValue("@password", password);

                SqlDataAdapter aDa = new SqlDataAdapter(aCmd);
                DataTable aDt = new DataTable();
                aDa.Fill(aDt);

                if (aDt.Rows.Count != 0)
                {
                    sideHome.Height = button8.Height;
                    sideHome.Top = button8.Top;
                    viewBooks1.BringToFront();

                    //label of name
                    button1.Enabled = false;
                    button1.Visible = true;
                    button1.Text = "Hi Admin";
                    //login
                    button2.Visible = false;
                    //signup
                    button10.Visible = false;
                    //author
                    button11.Visible = true;
                    //publisher
                    button12.Visible = true;
                    //book manager
                    button13.Visible = true;
                    //book issue
                    button14.Visible = true;
                    //manage user
                    button15.Visible = true;
                    //logout
                    button16.Visible = true;


                    MessageBox.Show("Hi Admin", "Login Successful",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //query to the databse /checking user
                    SqlCommand cmd = new SqlCommand("select * from member where email = @email and password = @password", con);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    //user not exist
                    if (dt.Rows.Count == 0)
                    {
                        throw new Exception("email or password is incorrect");
                    }

                    //user exist
                    else
                    {
                        string dtEmail = dt.Rows[0][2].ToString();

                        sideHome.Height = button8.Height;
                        sideHome.Top = button8.Top;
                        viewBooks1.BringToFront();

                        //label of name
                        button1.Enabled = true;
                        button1.Visible = true;
                        button1.Text = dtEmail;
                        //login
                        button2.Visible = false;
                        //signup
                        button10.Visible = false;
                        //author
                        button11.Visible = false;
                        //publisher
                        button12.Visible = false;
                        //book manager
                        button13.Visible = false;
                        //book issue
                        button14.Visible = false;
                        //manage user
                        button15.Visible = false;
                        //logout
                        button16.Visible = true;

                        MessageBox.Show("Login Successful", "Hi " + dtEmail,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                //closing connection
                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "login Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
