using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace libraryManagementSystem
{

    public partial class viewBooks : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DBLibrary;Integrated Security=True");
        public viewBooks()
        {
            InitializeComponent();
        }

        private void viewBooks_Load(object sender, System.EventArgs e)
        {
            //openning connection if it is close
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            try
            {
                //showing image
                showImage();
            }
            catch (Exception)
            {

            }

            try
            {
                //openning connection if it is close
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                //showing image
                //showImage();

                //showing Book ID
                showBookID();

                //showing book title
                showBookTitle();

                //showing description
                showDescription();

                //showing Genre
                showGenre();

                //showing edition
                showEdition();

                //show price
                showPrice();

                //showing author
                showAuthor();

                //showing publisher
                showPublisher();

                //closing connection
                con.Close();

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "books Error at Loading", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void showPublisher()
        {
            SqlCommand cmd = new SqlCommand("select p.fullname from book b JOIN publisher p on b.publisherID = p.publisherID", con);
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

                    label.Location = new System.Drawing.Point(525, 192 + 140 * i);
                    //label.TabIndex = 0 + i;
                    label.Name = "publisherBook" + i.ToString();
                    //label.ForeColor = SystemColors.WindowFrame;
                    label.ForeColor = Color.Black;
                    label.BackColor = System.Drawing.Color.Transparent;
                    //label.BorderStyle = BorderStyle.Fixed3D;
                    label.Size = new System.Drawing.Size(130, 20);
                    label.Text = "PUBLISHER: " + field1;
                    label.Font = new Font("Franklin Gothic Medium", 10);
                    this.Controls.Add(label);
                    i++;
                }
            }
        }

        public void showAuthor()
        {
            SqlCommand cmd = new SqlCommand("select a.fullname from book b JOIN auther a on b.authorID = a.authorID", con);
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

                    label.Location = new System.Drawing.Point(395, 192 + 140 * i);
                    //label.TabIndex = 0 + i;
                    label.Name = "authorBook" + i.ToString();
                    //label.ForeColor = SystemColors.WindowFrame;
                    label.ForeColor = Color.Black;
                    label.BackColor = System.Drawing.Color.Transparent;
                    //label.BorderStyle = BorderStyle.Fixed3D;
                    label.Size = new System.Drawing.Size(130, 20);
                    label.Text = "Author: " + field1;
                    label.Font = new Font("Franklin Gothic Medium", 10);
                    this.Controls.Add(label);
                    i++;
                }
            }
        }

        public void showPrice()
        {
            SqlCommand cmd = new SqlCommand("select price from book", con);
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

                    label.Location = new System.Drawing.Point(265, 192 + 140 * i);
                    //label.TabIndex = 0 + i;
                    label.Name = "oriceBook" + i.ToString();
                    //label.ForeColor = SystemColors.WindowFrame;
                    label.ForeColor = Color.Black;
                    label.BackColor = System.Drawing.Color.Transparent;
                    //label.BorderStyle = BorderStyle.Fixed3D;
                    label.Size = new System.Drawing.Size(130, 20);
                    label.Text = "PRICE: " + field1;
                    label.Font = new Font("Franklin Gothic Medium", 10);
                    this.Controls.Add(label);
                    i++;
                }
            }
        }

        public void showEdition()
        {
            SqlCommand cmd = new SqlCommand("select edition from book", con);
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

                    label.Location = new System.Drawing.Point(765, 162 + 140 * i);
                    //label.TabIndex = 0 + i;
                    label.Name = "editionBook" + i.ToString();
                    //label.ForeColor = SystemColors.WindowFrame;
                    label.ForeColor = Color.Black;
                    label.BackColor = System.Drawing.Color.Transparent;
                    //label.BorderStyle = BorderStyle.Fixed3D;
                    label.Size = new System.Drawing.Size(100, 20);
                    label.Text = "EDITION: " + field1;
                    label.Font = new Font("Franklin Gothic Medium", 10);
                    this.Controls.Add(label);
                    i++;
                }
            }

        }

        public void showGenre()
        {
            SqlCommand cmd = new SqlCommand("select genre from book", con);
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

                    label.Location = new System.Drawing.Point(615, 162 + 140 * i);
                    //label.TabIndex = 0 + i;
                    label.Name = "genreB" + i.ToString();
                    //label.ForeColor = SystemColors.WindowFrame;
                    label.ForeColor = Color.Black;
                    label.BackColor = System.Drawing.Color.Transparent;
                    //label.BorderStyle = BorderStyle.Fixed3D;
                    label.Size = new System.Drawing.Size(150, 20);
                    label.Text = "GENRE: " + field1;
                    label.Font = new Font("Franklin Gothic Medium", 10);
                    this.Controls.Add(label);
                    i++;
                }
            }
            
        }

        public void showDescription()
        {
            SqlCommand cmd = new SqlCommand("select description from book", con);
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

                    label.Location = new System.Drawing.Point(265, 222 + 140 * i);
                    label.TabIndex = 0 + i;
                    label.Name = "descriptionBook" + i;
                    //label.ForeColor = SystemColors.WindowFrame;
                    label.ForeColor = Color.Black;
                    label.BackColor = System.Drawing.Color.Transparent;
                    //label.Padding = new Padding(-10);
                    label.Size = new System.Drawing.Size(1000, 50);
                    label.Text = "DESCRIPTION: " + field1;
                    label.Font = new Font("Franklin Gothic Medium", 10);
                    this.Controls.Add(label);
                    i++;

                }
            }
        }

        public void showBookTitle()
        {
            SqlCommand cmd = new SqlCommand("select name from book", con);
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

                    label.Location = new System.Drawing.Point(365, 162 + 140 * i);
                    //label.TabIndex = 0 + i;
                    label.Name = "nameB" + i.ToString();
                    //label.ForeColor = SystemColors.WindowFrame;
                    label.ForeColor = Color.Black;
                    label.BackColor = System.Drawing.Color.Transparent;
                    //label.BorderStyle = BorderStyle.Fixed3D;
                    label.Size = new System.Drawing.Size(250, 20);
                    label.Text = "TITLE: " + field1;
                    label.Font = new Font("Franklin Gothic Medium", 10);
                    this.Controls.Add(label);
                    i++;
                }
            }
        }
        public void showBookID()
        {
            SqlCommand cmd = new SqlCommand("select bookID from book", con);
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

                    label.Location = new System.Drawing.Point(265, 162 + 140 * i);
                    //label.TabIndex = 0 + i;
                    label.Name = "bookID" + i.ToString();
                    //label.ForeColor = SystemColors.WindowFrame;
                    label.ForeColor = Color.Black;
                    label.BackColor = System.Drawing.Color.Transparent;
                    //label.BorderStyle = BorderStyle.Fixed3D;
                    label.Size = new System.Drawing.Size(100, 20);
                    label.Text = "BOOK ID: " + field1;
                    label.Font = new Font("Franklin Gothic Medium", 10);
                    this.Controls.Add(label);
                    i++;
                }
            }
        }

        public void showImage()
        {
            SqlCommand imgCmd = new SqlCommand("select bookImage from book", con);
            SqlDataAdapter imgDa = new SqlDataAdapter(imgCmd);
            DataTable imgDt = new DataTable();
            imgDa.Fill(imgDt);

            //showing image from colunm bookImage
            int i = 0;
            foreach (DataRow dtRow in imgDt.Rows)
            {
                foreach (DataColumn dc in imgDt.Columns)
                {
                    var field1 = dtRow[dc].ToString();
                    PictureBox pictBox = new PictureBox();

                    pictBox.Location = new System.Drawing.Point(150, 152 + 140 * i);
                    pictBox.Name = "pictBox" + i.ToString();
                    pictBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictBox.Size = new System.Drawing.Size(100, 100);
                    pictBox.TabIndex = 0 + i;
                    pictBox.Image = new Bitmap(field1);
                    this.Controls.Add(pictBox);
                    i++;
                }
            }
        }

        private void sfDataGrid2_Click(object sender, System.EventArgs e)
        {

        }

        private void fillToolStripButton_Click(object sender, System.EventArgs e)
        {
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void aAdd_Click(object sender, EventArgs e)
        {
            //refereshing page
            Controls.Clear();
            InitializeComponent();

            try
            {
                //openning connection if it is close
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                //showing image
                showImage();

                //showing Book ID
                showBookID();

                //showing book title
                showBookTitle();

                //showing description
                showDescription();

                //showing Genre
                showGenre();

                //showing edition
                showEdition();

                //show price
                showPrice();

                //showing author
                showAuthor();

                //showing publisher
                showPublisher();

                //closing connection
                con.Close();

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "books Error at Refreshing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
