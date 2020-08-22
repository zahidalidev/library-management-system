using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace libraryManagementSystem
{
    public partial class bookIssue : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DBLibrary;Integrated Security=True");

        public bookIssue()
        {
            InitializeComponent();
        }

        private void bookIssue_Load(object sender, EventArgs e)
        {
            loadMemBookIssue();
        }

        public void loadMemBookIssue()
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
                //showing author id
                showMemberID();

                //showing Author Name
                showBookID();

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
        public void showMemberID()
        {
            SqlCommand cmd = new SqlCommand("select memberID from memberbookissue", con);
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

                    label.Location = new System.Drawing.Point(655, 242 + 40 * i);
                    label.Name = "memebrid" + i.ToString();
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
        public void showBookID()
        {
            SqlCommand cmd = new SqlCommand("select bookID from memberbookissue", con);
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

                    label.Location = new System.Drawing.Point(820, 242 + 40 * i);
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

        private void mGetDetail_Click(object sender, System.EventArgs e)
        {
            try
            {
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                //getting IDs from fields
                string memberID = memID.Text.Trim();
                string BookID = bookID.Text.Trim();

                //getting member name and book title from database
                SqlCommand cmd = new SqlCommand("Select m.fullname, b.name from member m JOIN memberBookIssue mb on m.memberID = mb.memberID JOIN book b on b.bookID = mb.bookID where mb.bookID = @bookID and mb.memberID = @memberID", con);
                cmd.Parameters.AddWithValue("@memberID", memberID);
                cmd.Parameters.AddWithValue("@bookID", BookID);

                //data adapter and data tabel
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if(dt.Rows.Count == 0)
                {
                    throw new Exception("Invalid details, No member has book with Issue with the given ID");
                }

                //filling values to the text Boxes
                memName.Text = dt.Rows[0][0].ToString();
                BookTitle.Text = dt.Rows[0][1].ToString();

                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Getting Values",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void memID_TextChanged(object sender, System.EventArgs e)
        {

        }

        //issue book
        private void issueBook_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                //getting values from text boxes
                string memberid = memID.Text.Trim();
                string bookid = bookID.Text.Trim();

                //checking member with the given id exist
                checkMemberID(memberid);

                //checking book with the given id exist
                checkBookID(bookid);

                //decrement cuurent Stock in database
                int newStock = 0;
                SqlCommand stcmd = new SqlCommand("select currentStock from book where bookID = @bookID", con);
                stcmd.Parameters.AddWithValue("@bookID", bookid);
                SqlDataAdapter da = new SqlDataAdapter(stcmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                int oldStock = int.Parse(dt.Rows[0][0].ToString());
                
                //cheking current stock
                if(oldStock == 0)
                {
                    throw new Exception("Book is out of Stock");
                }
                newStock = oldStock - 1;

                //updating Current stock in book table
                SqlCommand boCmd = new SqlCommand("UPDATE book set currentStock = @newStock where bookID = @bID", con);
                boCmd.Parameters.AddWithValue("@newStock", newStock);
                boCmd.Parameters.AddWithValue("@bID", bookid);
                boCmd.ExecuteNonQuery();


                //insertin values in memberbookIssue table in the database
                SqlCommand cmd = new SqlCommand("insert into memberbookissue values(@memberid, @bookid)", con);
                cmd.Parameters.AddWithValue("@memberid", memberid);
                cmd.Parameters.AddWithValue("@bookid", bookid);
                cmd.ExecuteNonQuery();

                //Successfull
                MessageBox.Show("Book Issued Successfully", "Issued",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                //refereshing book issue details
                loadMemBookIssue();

                //closing Connection
                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Issue book error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //retutn book
        private void returnBook_Click(object sender, EventArgs e)
        {
            try
            {
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                //getting values from text boxes
                string memberid = memID.Text.Trim();
                string bookid = bookID.Text.Trim();

                //checking member with the given id exist
                checkMemberID(memberid);

                //checking book with the given id exist
                checkBookID(bookid);


                //Increment cuurent Stock in database
                int newStock = 0;
                SqlCommand stcmd = new SqlCommand("select currentStock, totalStock from book where bookID = @bookID", con);
                stcmd.Parameters.AddWithValue("@bookID", bookid);
                SqlDataAdapter da = new SqlDataAdapter(stcmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                int oldStock = int.Parse(dt.Rows[0][0].ToString());
                int totalStock = int.Parse(dt.Rows[0][1].ToString());
                //cheking current stock
                if (oldStock >= totalStock)
                {
                    throw new Exception("No book to return from this member");
                }

                newStock = oldStock + 1;

                //updating Current stock in book table
                SqlCommand boCmd = new SqlCommand("UPDATE book set currentStock = @newStock where bookID = @bID", con);
                boCmd.Parameters.AddWithValue("@newStock", newStock);
                boCmd.Parameters.AddWithValue("@bID", bookid);
                boCmd.ExecuteNonQuery();


                //deleting values from memberbookIssue table in the database
                SqlCommand cmd = new SqlCommand("delete TOP(1) from memberbookissue where memberID = @memberid and bookID = @bookid", con);
                cmd.Parameters.AddWithValue("@memberid", memberid);
                cmd.Parameters.AddWithValue("@bookid", bookid);
                cmd.ExecuteNonQuery();

                //
                MessageBox.Show("Book returned Successfully", "Returned",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                //refereshing book issue details
                loadMemBookIssue();

                //closing Connection
                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Deleting book error",
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

            if(dt.Rows.Count == 0)
            {
                throw new Exception("Member with the given ID does not exist");
            }
        }

        public void checkBookID(string bookid)
        {
            SqlCommand cmd = new SqlCommand("select * from book where bookID = @bookid", con);
            cmd.Parameters.AddWithValue("@bookid", bookid);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                throw new Exception("Book with the given ID does not exist");
            }
        }
    }
}
