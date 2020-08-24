using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace libraryManagementSystem
{
    public partial class manageUser : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DBLibrary;Integrated Security=True");
        
        public manageUser()
        {
            InitializeComponent();
        }

        int offsetVlaue = 0;
        private void manageUser_Load(object sender, System.EventArgs e)
        {
            loadMembers();
        }

        public void loadMembers()
        {
            //refereshing page
            Controls.Clear();
            InitializeComponent();

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            try
            {
                //showing member id
                showMemberID();

                //showing member Name
                showFullName();

                //showing contact number
                showContact();

                //showing member Email
                showEmail();

                //closing connection
                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Loading Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //showing email
        public void showEmail()
        {
            SqlCommand cmd = new SqlCommand("select email from member ORDER BY memberID OFFSET @offsetValye ROWS FETCH NEXT 6 ROWS ONLY", con);
            cmd.Parameters.AddWithValue("@offsetValye", offsetVlaue);

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

                    label.Location = new System.Drawing.Point(850, 242 + 40 * i);
                    label.Name = "useremail" + i.ToString();
                    label.ForeColor = Color.Black;
                    label.BackColor = System.Drawing.Color.Transparent;
                    label.Size = new System.Drawing.Size(150, 20);
                    label.Text = field1;
                    label.Font = new Font("Franklin Gothic Medium", 10);
                    this.Controls.Add(label);
                    i++;
                }
            }
        }

        //showing contact number
        public void showContact()
        {
            SqlCommand cmd = new SqlCommand("select mobileNumber from member ORDER BY memberID OFFSET @offsetValye ROWS FETCH NEXT 6 ROWS ONLY", con);
            cmd.Parameters.AddWithValue("@offsetValye", offsetVlaue);

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

                    label.Location = new System.Drawing.Point(650, 242 + 40 * i);
                    label.Name = "mobilenumberuser" + i.ToString();
                    label.ForeColor = Color.Black;
                    label.BackColor = System.Drawing.Color.Transparent;
                    label.Size = new System.Drawing.Size(150, 20);
                    label.Text = field1;
                    label.Font = new Font("Franklin Gothic Medium", 10);
                    this.Controls.Add(label);
                    i++;
                }
            }
        }

        //showing User name
        public void showFullName()
        {
            SqlCommand cmd = new SqlCommand("select fullname from member ORDER BY memberID OFFSET @offsetValye ROWS FETCH NEXT 6 ROWS ONLY", con);
            cmd.Parameters.AddWithValue("@offsetValye", offsetVlaue);

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

                    label.Location = new System.Drawing.Point(460, 242 + 40 * i);
                    label.Name = "membername" + i.ToString();
                    label.ForeColor = Color.Black;
                    label.BackColor = System.Drawing.Color.Transparent;
                    label.Size = new System.Drawing.Size(150, 20);
                    label.Text = field1;
                    label.Font = new Font("Franklin Gothic Medium", 10);
                    this.Controls.Add(label);
                    i++;
                }
            }
        }

        //showing member id
        public void showMemberID()
        {
            SqlCommand cmd = new SqlCommand("select memberID from member ORDER BY memberID OFFSET @offsetValye ROWS FETCH NEXT 6 ROWS ONLY", con);
            cmd.Parameters.AddWithValue("@offsetValye", offsetVlaue);

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

                    label.Location = new System.Drawing.Point(335, 242 + 40 * i);
                    label.Name = "memebrid_" + i.ToString();
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

        //deleting Account of member
        private void returnBook_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

               
                //getting values from text boxes
                string memberid = memID.Text.Trim();

                //checking member with the given id exist
                checkMemberID(memberid);

                //checking member with the given id in memberbookissue table exist
                checkBookMemberID(memberid);

                //deleting values from memberbookIssue table in the database
                SqlCommand cmd = new SqlCommand("delete from member where memberID = @memberid", con);
                cmd.Parameters.AddWithValue("@memberid", memberid);
                cmd.ExecuteNonQuery();
              
                //Successfull
                MessageBox.Show("Member deleted Successfully", "Successfull",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                //refereshing book issue details
                loadMembers();

                //closing Connection
                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Deleting Member error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void checkMemberID(string memberid)
        {
            SqlCommand cmd = new SqlCommand("select * from member where memberID = @memberID", con);
            cmd.Parameters.AddWithValue("@memberID", memberid);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                throw new Exception("Member with the given ID does not exist");
            }
        }

        //cheking member id in memberbookissue table
        public void checkBookMemberID(string memberid)
        {
            SqlCommand cmd = new SqlCommand("select * from memberbookissue where memberID = @memberID", con);
            cmd.Parameters.AddWithValue("@memberID", memberid);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count != 0)
            {
                throw new Exception("This member has some books to return, Cannot delete account");
            }
        }

        private void previousPage_Click(object sender, EventArgs e)
        {
            if (offsetVlaue > 0)
            {
                offsetVlaue = offsetVlaue - 6;

                //refereshing page
                loadMembers();
            }
        }

        private void nextPage_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select memberID from member", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                string tableLength = dt.Rows.Count.ToString();
                int length = int.Parse(tableLength);

                if (offsetVlaue < length - 6)
                {
                    offsetVlaue = offsetVlaue + 6;

                    //refereshing page
                    loadMembers();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Pagination Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
