using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace libraryManagementSystem
{
    public partial class authorManage : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DBLibrary;Integrated Security=True");

        public authorManage()
        {
            InitializeComponent();
        }

        private void authorManage_Load(object sender, EventArgs e)
        {
            loadAuthors();
        }

        public void loadAuthors()
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
                showAuthorID();

                //showing Author Name
                showAuthorName();

                //closing connection
                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Loading Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void showAuthorName()
        {
            SqlCommand cmd = new SqlCommand("select fullname from auther", con);
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

                    label.Location = new System.Drawing.Point(775, 242 + 40 * i);
                    //label.TabIndex = 0 + i;
                    label.Name = "AuthorName" + i.ToString();
                    //label.ForeColor = SystemColors.WindowFrame;
                    label.ForeColor = Color.Black;
                    label.BackColor = System.Drawing.Color.Transparent;
                    //label.BorderStyle = BorderStyle.Fixed3D;
                    label.Size = new System.Drawing.Size(200, 20);
                    label.Text = field1;
                    label.Font = new Font("Franklin Gothic Medium", 10);
                    this.Controls.Add(label);
                    i++;
                }
            }
        }

        public void showAuthorID()
        {
            SqlCommand cmd = new SqlCommand("select authorID from auther", con);
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

                    label.Location = new System.Drawing.Point(635, 242 + 40 * i);
                    //label.TabIndex = 0 + i;
                    label.Name = "authorID" + i.ToString();
                    //label.ForeColor = SystemColors.WindowFrame;
                    label.ForeColor = Color.Black;
                    label.BackColor = System.Drawing.Color.Transparent;
                    //label.BorderStyle = BorderStyle.Fixed3D;
                    label.Size = new System.Drawing.Size(50, 20);
                    label.Text = field1;
                    label.Font = new Font("Franklin Gothic Medium", 10);
                    this.Controls.Add(label);
                    i++;
                }
            }
        }

        private void aGetDetail_Click(object sender, System.EventArgs e)
        {
            try
            {
                //openning connection if it is close
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                string authorID = textBox5.Text.Trim();
                SqlCommand cmdAID = new SqlCommand("Select * from auther where authorID = @authorID", con);
                cmdAID.Parameters.AddWithValue("@authorID", authorID);

                SqlDataAdapter da = new SqlDataAdapter(cmdAID);
                DataTable dt = new DataTable();
                da.Fill(dt);

                //if book does not exist try another one
                if (dt.Rows.Count == 0)
                {
                    throw new Exception("Author with the given ID does not Exist try another one");
                }

                //filling input feilds
                aName.Text = dt.Rows[0][1].ToString();
                
                //closing connection
                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Invalid Author ID",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //adding new Author
        private void aAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                //checking author
                checkAuthor();

                //---------------------- adding Author in the database

                //values from the fields
                string fullname = aName.Text.Trim();

                //inserting Author data
                SqlCommand boCmd = new SqlCommand("insert into auther values(@fullname)", con);
                boCmd.Parameters.AddWithValue("@fullname", fullname);

                boCmd.ExecuteNonQuery();

                //clearing fields
                clearFields();

                //closing connection
                con.Close();

                //refersginf author details
                loadAuthors();

                //successfull
                MessageBox.Show("Author added successfully", "Successfull",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Invalid Author details",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //updating Author
        private void aUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                //checking author
                checkAuthor();

                //cheking author ID
                checkAuthorID();

                //---------------------- Updating Author in the database

                //values from the fields
                string fullname = aName.Text.Trim();
                string authorID = textBox5.Text.Trim();

                //updating Author data
                SqlCommand boCmd = new SqlCommand("UPDATE auther set fullname = @fullname where authorID = @authorID", con);
                boCmd.Parameters.AddWithValue("@fullname", fullname);
                boCmd.Parameters.AddWithValue("@authorID", authorID);

                boCmd.ExecuteNonQuery();

                //clearing fields
                clearFields();

                //closing connection
                con.Close();

                //refreshing author details
                loadAuthors();

                //successfull
                MessageBox.Show("Author Updated successfully", "Successfull",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Invalid Author details",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //deleting Author
        private void aDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                //cheking author ID
                checkAuthorID();

                //---------------------- Deleting Author from the database

                //values from the fields
                string authorID = textBox5.Text.Trim();

                //inserting Author data
                SqlCommand boCmd = new SqlCommand("delete from auther where authorID = @authorID", con);
                boCmd.Parameters.AddWithValue("@authorID", authorID);

                boCmd.ExecuteNonQuery();

                //clearing fields
                clearFields();

                //closing connection
                con.Close();

                //refersginf author details
                loadAuthors();

                //successfull
                MessageBox.Show("Author Deleted successfully", "Successfull",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("This Author have some books, Author cannot be deleted, Delete Books First", "Invalid Author details",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //clearing fields
        public void clearFields()
        {
            aName.Text = "";
        }


        //cheking author ID
        public void checkAuthorID()
        {
            //getting auther names from database
            SqlCommand auCmd = new SqlCommand("select * from auther where authorID = @authorID", con);
            auCmd.Parameters.AddWithValue("@authorID", textBox5.Text.Trim());
            SqlDataAdapter auDa = new SqlDataAdapter(auCmd);
            DataTable auDt = new DataTable();
            auDa.Fill(auDt);

            //throwing exeption if author name does not exist
            if (auDt.Rows.Count == 0)
            {
                throw new Exception("Author with the given ID does not Exist");
            }

        }

        //cheking author name
        public void checkAuthor()
        {
            //getting auther names from database
            SqlCommand auCmd = new SqlCommand("select fullname from auther where fullname = @fullname", con);
            auCmd.Parameters.AddWithValue("@fullname", aName.Text.Trim());
            SqlDataAdapter auDa = new SqlDataAdapter(auCmd);
            DataTable auDt = new DataTable();
            auDa.Fill(auDt);

            //throwing exeption if author name does not exist
            if (auDt.Rows.Count != 0)
            {
                throw new Exception("Author Name Already Exist");
            }

        }

        
    }
}
