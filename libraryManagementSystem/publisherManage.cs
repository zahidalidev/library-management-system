using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace libraryManagementSystem
{
    public partial class publisherManage : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DBLibrary;Integrated Security=True");

        public publisherManage()
        {
            InitializeComponent();
        }

        int offsetVlaue = 0;
        private void publisherManage_Load(object sender, System.EventArgs e)
        {
            loadPublishers();
        }

        public void loadPublishers()
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
                //showing publisher id
                showPublisherID();

                //showing publisher Name
                showPublisherName();

                //closing connection
                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Loading Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void showPublisherName()
        {
            SqlCommand cmd = new SqlCommand("select fullname from publisher ORDER BY publisherID OFFSET @offsetValye ROWS FETCH NEXT 6 ROWS ONLY", con);
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

                    label.Location = new System.Drawing.Point(775, 242 + 40 * i);
                    //label.TabIndex = 0 + i;
                    label.Name = "publisherName" + i.ToString();
                    //label.ForeColor = SystemColors.WindowFrame;
                    label.ForeColor = Color.Black;
                    label.BackColor = System.Drawing.Color.Transparent;
               
                    label.Size = new System.Drawing.Size(200, 20);
                    label.Text = field1;
                    label.Font = new Font("Franklin Gothic Medium", 10);
                    this.Controls.Add(label);
                    i++;
                }
            }
        }

        public void showPublisherID()
        {
            SqlCommand cmd = new SqlCommand("select publisherID from publisher ORDER BY publisherID OFFSET @offsetValye ROWS FETCH NEXT 6 ROWS ONLY", con);
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

                    label.Location = new System.Drawing.Point(605, 242 + 40 * i);
                    //label.TabIndex = 0 + i;
                    label.Name = "publisherID" + i.ToString();
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

        //filling details
        private void aGetDetail_Click(object sender, EventArgs e)
        {
            try
            {
                //openning connection if it is close
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                string publisherID = textBox5.Text.Trim();
                SqlCommand cmdAID = new SqlCommand("Select * from publisher where publisherID = @publisherID", con);
                cmdAID.Parameters.AddWithValue("@publisherID", publisherID);

                SqlDataAdapter da = new SqlDataAdapter(cmdAID);
                DataTable dt = new DataTable();
                da.Fill(dt);

                //if book does not exist try publisher one
                if (dt.Rows.Count == 0)
                {
                    throw new Exception("Publisher with the given ID does not Exist try another one");
                }

                //filling input feilds
                aName.Text = dt.Rows[0][1].ToString();

                //closing connection
                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Invalid publisher ID",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //adding Publisher
        private void aAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                //checking publisher
                checkPublisher();

                //---------------------- adding Publisher in the database

                //values from the fields
                string fullname = aName.Text.Trim();

                //inserting publisher data
                SqlCommand boCmd = new SqlCommand("insert into publisher values(@fullname)", con);
                boCmd.Parameters.AddWithValue("@fullname", fullname);

                boCmd.ExecuteNonQuery();

                //clearing fields
                clearFields();

                //closing connection
                con.Close();

                //refereshing publisher details
                loadPublishers();

                //successfull
                MessageBox.Show("Publisher added successfully", "Successfull",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Invalid Publisher details",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //updatin Publisher
        private void aUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                //checking publisher
                checkPublisher();

                //cheking publisher ID
                checkPublisherID();

                //---------------------- Updating Publisher in the database

                //values from the fields
                string fullname = aName.Text.Trim();
                string publisherID = textBox5.Text.Trim();

                //Updating publisher data
                SqlCommand boCmd = new SqlCommand("UPDATE publisher set fullname = @fullname where publisherID = @publisherID", con);
                boCmd.Parameters.AddWithValue("@fullname", fullname);
                boCmd.Parameters.AddWithValue("@publisherID", publisherID);

                boCmd.ExecuteNonQuery();

                //clearing fields
                clearFields();

                //closing connection
                con.Close();

                //refreshing publisher details
                loadPublishers();

                //successfull
                MessageBox.Show("Publisher updated successfully", "Successfull",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Invalid Publisher details",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //deleting publisher
        private void aDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                //cheking publisher ID
                checkPublisherID();

                //---------------------- Deleting Publisher from the database

                //values from the fields
                string publisherID = textBox5.Text.Trim();

                //deleting publisher data
                SqlCommand boCmd = new SqlCommand("delete from publisher where publisherID = @publisherID", con);
                boCmd.Parameters.AddWithValue("@publisherID", publisherID);

                boCmd.ExecuteNonQuery();

                //clearing fields
                clearFields();

                //closing connection
                con.Close();

                //refersginf publisher details
                loadPublishers();

                //successfull
                MessageBox.Show("Publisher Deleted successfully", "Successfull",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("This Publisher have some books, Publisher cannot be deleted, Delete Books First", "Invalid Publisher details",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //clearing fields
        public void clearFields()
        {
            aName.Text = "";
        }


        //cheking Publisher ID
        public void checkPublisherID()
        {
            //getting auther names from database
            SqlCommand auCmd = new SqlCommand("select * from publisher where publisherID = @publisherID", con);
            auCmd.Parameters.AddWithValue("@publisherID", textBox5.Text.Trim());
            SqlDataAdapter auDa = new SqlDataAdapter(auCmd);
            DataTable auDt = new DataTable();
            auDa.Fill(auDt);

            //throwing exeption if author name does not exist
            if (auDt.Rows.Count == 0)
            {
                throw new Exception("Publisher with the given ID does not Exist");
            }

        }

        //cheking Publisher name
        public void checkPublisher()
        {
            //getting auther names from database
            SqlCommand auCmd = new SqlCommand("select fullname from publisher where fullname = @fullname", con);
            auCmd.Parameters.AddWithValue("@fullname", aName.Text.Trim());
            SqlDataAdapter auDa = new SqlDataAdapter(auCmd);
            DataTable auDt = new DataTable();
            auDa.Fill(auDt);

            //throwing exeption if author name does not exist
            if (auDt.Rows.Count != 0)
            {
                throw new Exception("Publisher Name Already Exist");
            }

        }

        private void previousPage_Click(object sender, EventArgs e)
        {
            if (offsetVlaue > 0)
            {
                offsetVlaue = offsetVlaue - 6;

                //refereshing page
                loadPublishers();
            }
        }

        private void nextPage_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select publisherID from publisher", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                string tableLength = dt.Rows.Count.ToString();
                int length = int.Parse(tableLength);

                if (offsetVlaue < length - 6)
                {
                    offsetVlaue = offsetVlaue + 6;

                    //refereshing page
                    loadPublishers();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Pagination Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
