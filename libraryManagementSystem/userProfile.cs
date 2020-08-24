using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace libraryManagementSystem
{
    public partial class userProfile : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DBLibrary;Integrated Security=True");

        public userProfile()
        {
            InitializeComponent();
        }

        string memberID2 = "";
        int offsetVlaue = 0;
        private void userProfile_Load(object sender, EventArgs e)
        {
            
        }


        //loading data
        public void loadMembersBooks()
        {
            ////refereshing page
            //Controls.Clear();
            //InitializeComponent();

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            try
            {
                //showing author id
                showBookID();

                //showing Author Name
                showBookName();

                //closing connection
                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Loading Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //showing member ID
        public void showBookID()
        {
            SqlCommand cmd = new SqlCommand("select bookID from memberbookissue where memberID = @memberID ORDER BY bookID OFFSET @offsetVlaue ROWS FETCH NEXT 6 ROWS ONLY", con);
            cmd.Parameters.AddWithValue("@offsetVlaue", offsetVlaue);
            cmd.Parameters.AddWithValue("@memberID", memberID2);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            //showing image from colunm bookImage
            int i = 0;
            foreach (DataRow dtRow in dt.Rows)
            {
                foreach (DataColumn dc in dt.Columns)
                {
                    var field1 = dtRow[dc].ToString();
                    Label label = new Label();

                    label.BringToFront();
                    label.Location = new System.Drawing.Point(660, 242 + 40 * i);
                    label.Name = "memebbookrid" + i.ToString();
                    label.ForeColor = Color.Black;
                    label.BackColor = System.Drawing.Color.Transparent;
                    label.Size = new System.Drawing.Size(80, 20);
                    label.Text = field1;
                    label.Font = new Font("Franklin Gothic Medium", 10);
                    this.Controls.Add(label);
                    i++;
                }
            }
        }

        //showing book ID
        public void showBookName()
        {
            SqlCommand cmd = new SqlCommand("select b.name from memberbookissue mb JOIN book b on b.bookID = mb.bookID where memberID = @memberID ORDER BY mb.bookID OFFSET @offsetVlaue ROWS FETCH NEXT 6 ROWS ONLY", con);
            cmd.Parameters.AddWithValue("@offsetVlaue", offsetVlaue);
            cmd.Parameters.AddWithValue("@memberID", memberID2);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            //showing image from colunm bookImage
            int i = 0;
            foreach (DataRow dtRow in dt.Rows)
            {
                foreach (DataColumn dc in dt.Columns)
                {
                    var field1 = dtRow[dc].ToString();
                    Label label = new Label();

                    label.BringToFront();
                    label.Location = new System.Drawing.Point(840, 242 + 40 * i);
                    label.Name = "bookid" + i.ToString();
                    label.ForeColor = Color.Black;
                    label.BackColor = System.Drawing.Color.Transparent;
                    label.Size = new System.Drawing.Size(80, 20);
                    label.Text = field1;
                    label.Font = new Font("Franklin Gothic Medium", 10);
                    this.Controls.Add(label);
                    i++;
                }
            }
        }

        private void updateProfileButton_Click(object sender, EventArgs e)
        {
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
                string memberID = userIDI.Text.Trim();
                //start transaction
                SqlCommand tra = new SqlCommand("begin tran", con);
                tra.ExecuteNonQuery();

                //cheking the user already exist or not
                SqlCommand cmd4 = new SqlCommand("select * from member where email = @email and memberID = @memberID", con);
                cmd4.Parameters.AddWithValue("@email", email);
                cmd4.Parameters.AddWithValue("@memberID", memberID);

                SqlDataAdapter da4 = new SqlDataAdapter(cmd4);
                DataTable dt4 = new DataTable();
                da4.Fill(dt4);

                if (dt4.Rows.Count == 1)
                {
                    //Updating values in member table
                    SqlCommand cmd = new SqlCommand("Update member Set password = @password, fullname = @fullname, " +
                        "mobileNumber = @mobileNumber where email = @email and memberID = @memberID", con);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@fullname", fullname);
                    cmd.Parameters.AddWithValue("@mobileNumber", mobileNumber);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@memberID", memberID);

                    cmd.ExecuteNonQuery();

                    //Updating the member address of above table
                    SqlCommand cmd3 = new SqlCommand("Update memberAddress SET streetAddress = @streetAdrress, city = @city, state = @state where memberID = @memberID", con);
                    cmd3.Parameters.AddWithValue("@memberID", memberID);
                    cmd3.Parameters.AddWithValue("@streetAdrress", streetAdrress);
                    cmd3.Parameters.AddWithValue("@city", city);
                    cmd3.Parameters.AddWithValue("@state", state);
                    cmd3.ExecuteNonQuery();

                    //commit transaction
                    SqlCommand commit = new SqlCommand("commit", con);
                    commit.ExecuteNonQuery();

                    //enabling email button
                    upEmail.Enabled = true;

                    //close connection
                    con.Close();

                    MessageBox.Show("Updated Successfull", "Successfull",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Invalid Details", "Updating Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            catch (Exception error)
            {
                //openning connection if it is close
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

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

        //getting and filling details into the form
        private void aAdd_Click(object sender, EventArgs e)
        {
            //openning connection if it is close
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            try
            {
                string email = upEmail.Text.Trim();
                string password = upPassword.Text.Trim();

                //inserting the member address of above table
                SqlCommand cmd3 = new SqlCommand("select fullname, mobileNumber, IDCardNumber, streetAddress, city, state, m.memberID from member m JOIN memberAddress mA on m.memberID = mA.memberID where email = @email and password = @password", con);
                cmd3.Parameters.AddWithValue("@email", email);
                cmd3.Parameters.AddWithValue("@password", password);

                SqlDataAdapter da = new SqlDataAdapter(cmd3);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if(dt.Rows.Count == 0) {
                    throw new Exception("email or password id incorrect");
                }else if(dt.Rows.Count == 1)
                {
                    upEmail.Enabled = false;

                    upFullName.Text = dt.Rows[0][0].ToString();
                    textBox2.Text = dt.Rows[0][1].ToString();
                    upCnic.Text = dt.Rows[0][2].ToString();
                    upStreet.Text = dt.Rows[0][3].ToString();
                    textBox4.Text = dt.Rows[0][4].ToString();
                    upState.Text = dt.Rows[0][5].ToString();
                    userIDI.Text = dt.Rows[0][6].ToString();
                    memberID2 = dt.Rows[0][6].ToString();

                    loadMembersBooks();
                }

                //close connection
                con.Close();
            }
            catch (Exception error)
            {
                //showing exception
                MessageBox.Show(error.Message, "Getting Details Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void previousPage_Click(object sender, EventArgs e)
        {
            if (offsetVlaue > 0)
            {
                offsetVlaue = offsetVlaue - 6;


                //refereshing page
                Controls.Clear();
                InitializeComponent();
                loadMembersBooks();
            }
        }

        private void nextPage_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select bookID from memberbookissue where memberID = @memberID", con);
                cmd.Parameters.AddWithValue("@memberID", memberID2);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                string tableLength = dt.Rows.Count.ToString();
                int length = int.Parse(tableLength);

                if (offsetVlaue < length - 6)
                {
                    offsetVlaue = offsetVlaue + 6;

                    //refereshing page
                    Controls.Clear();
                    InitializeComponent();
                    loadMembersBooks();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Pagination Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}
