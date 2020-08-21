using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;
using System.Data.SqlClient;
using System.Security.Policy;

namespace libraryManagementSystem
{
    public partial class books : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DBLibrary;Integrated Security=True");

        public books()
        {
            InitializeComponent();
        }

        private void books_Load(object sender, System.EventArgs e)
        {
            //openning connection if it is close
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            // filling auther and publisher comboBoxes
            try
            {
                // filing comboBox1 with author 
                fillAuthorBox();

                //filing comboBox2 with publisher
                fillPublisherBox();

                //closing connection
                con.Close();

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "dropDown box error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //getting authers name for drop Down

        }

        //selected book image location
        string dest;
        private void button1_Click(object sender, System.EventArgs e)
        {
            try
            {
                OpenFileDialog opnfd = new OpenFileDialog();
                opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";

                if (opnfd.ShowDialog() == DialogResult.OK)
                {
                    string source = opnfd.FileName;
                    dest = @"..\..\images\" + Path.GetFileName(source);
                    File.Copy(source, dest);

                    pictureBox1.Image = new Bitmap(dest);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Image name is invalid",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // get book details by ID
        private void addBook_Click(object sender, EventArgs e)
        {
            try
            {
                //openning connection if it is close
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                string bookID = textBox5.Text.Trim();
                SqlCommand cmdBID = new SqlCommand("select b.name, b.genre, b.price, b.edition, b.description, p.fullname as publisherName," +
                    " a.fullname as authorName, b.totalStock, b.bookImage from book b " +
                    "JOIN publisher p on p.publisherID = b.publisherID " +
                    "JOIN auther a on a.authorID = b.authorID " +
                    "where b.bookID = @bookID", con);
                cmdBID.Parameters.AddWithValue("@bookID", bookID);

                SqlDataAdapter da = new SqlDataAdapter(cmdBID);
                DataTable dt = new DataTable();
                da.Fill(dt);

                //if book does not exist try another one
                if(dt.Rows.Count == 0)
                {
                    throw new Exception("Book with the given ID does not Exist try another one");
                }

                //showing picture
                pictureBox1.Image = new Bitmap(dt.Rows[0][8].ToString());

                //filling input feilds
                bTitle.Text = dt.Rows[0][0].ToString();
                bGenre.Text = dt.Rows[0][1].ToString();
                bPrice.Text = dt.Rows[0][2].ToString();
                bEdition.Text = dt.Rows[0][3].ToString();
                bDescription.Text = dt.Rows[0][4].ToString();
                bStock1.Text = dt.Rows[0][7].ToString();

                //filling comboBox1 with auther names
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "authorName";

                //filling comboBox1 with auther names
                comboBox2.DataSource = dt;
                comboBox2.DisplayMember = "publisherName";

                //disabling comboBoxes
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;

                //closing connection
                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Invalid Book ID",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        //adding new book
        private void updateBook_Click(object sender, EventArgs e)
        {
            try
            {
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                //checking author
                checkAuthor();

                //checking publisher
                checkPublisher();

                //---------------------- adding book in the database

                //values from the fields
                string imagePath = dest;
                string bookeTitle = bTitle.Text.Trim();
                string bookGenre = bGenre.Text.Trim();
                string bookPrice = bPrice.Text.Trim();
                string bookEdition = bEdition.Text.Trim();
                string bookDescription = bDescription.Text.Trim();
                string bookStock = bStock1.Text.Trim();

                string bookAuthor = comboBox1.Text.Trim();
                string bookPublisher = comboBox2.Text.Trim();

                //getting author ID
                SqlCommand auCmd = new SqlCommand("select authorID from auther where fullname = @bookAuthor", con);
                auCmd.Parameters.AddWithValue("@bookAuthor", bookAuthor);
                SqlDataAdapter auDa = new SqlDataAdapter(auCmd);
                DataTable auDt = new DataTable();
                auDa.Fill(auDt);
                string bookAuthorID = auDt.Rows[0][0].ToString();

                //getting publisherID
                SqlCommand puCmd = new SqlCommand("select publisherID from publisher where fullname = @bookPublisher", con);
                puCmd.Parameters.AddWithValue("@bookPublisher", bookPublisher);
                SqlDataAdapter puDa = new SqlDataAdapter(puCmd);
                DataTable puDt = new DataTable();
                puDa.Fill(puDt);
                string bookPublisherID = puDt.Rows[0][0].ToString();

                //inserting book data
                SqlCommand boCmd = new SqlCommand("insert into book values(@bookeTitle, @bookDescription, @bookGenre," +
                    "@bookEdition, @imagePath, @bookPrice, @bookStock, @bookStock, @bookAuthorID, @bookPublisherID)", con);
                boCmd.Parameters.AddWithValue("@bookeTitle", bookeTitle);
                boCmd.Parameters.AddWithValue("@bookDescription", bookDescription);
                boCmd.Parameters.AddWithValue("@bookGenre", bookGenre);
                boCmd.Parameters.AddWithValue("@bookEdition", bookEdition);
                boCmd.Parameters.AddWithValue("@imagePath", imagePath);
                boCmd.Parameters.AddWithValue("@bookPrice", bookPrice);
                boCmd.Parameters.AddWithValue("@bookStock", bookStock);
                boCmd.Parameters.AddWithValue("@bookAuthorID", bookAuthorID);
                boCmd.Parameters.AddWithValue("@bookPublisherID", bookPublisherID);

                boCmd.ExecuteNonQuery();

                //clearing fields
                clearFields();

                //closing connection
                con.Close();

                //successfull
                MessageBox.Show("book added successfully", "Successfull",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Invalid Book details",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //updating book
        private void updateBookOriginal_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                //cheking book exist or not
                checkBookExist();


                //getting current stock
                string bookID = textBox5.Text.Trim();

                SqlCommand cuCmd = new SqlCommand("select totalStock, currentStock, bookImage from book where bookID = @bookID", con);
                cuCmd.Parameters.AddWithValue("@bookID", bookID);

                SqlDataAdapter cuDa = new SqlDataAdapter(cuCmd);
                DataTable cuDt = new DataTable();
                cuDa.Fill(cuDt);

                //---------------------- updating book in the database

                string oldTotalStock = cuDt.Rows[0][0].ToString();
                string oldCurrentStock = cuDt.Rows[0][1].ToString();

                //managing image path
                string imagePath;
                if(dest == null)
                {
                    imagePath = cuDt.Rows[0][2].ToString();
                }
                else
                {
                    imagePath = dest;
                }

                //values from the fields
                string bookeTitle = bTitle.Text.Trim();
                string bookGenre = bGenre.Text.Trim();
                string bookPrice = bPrice.Text.Trim();
                string bookEdition = bEdition.Text.Trim();
                string bookDescription = bDescription.Text.Trim();
                string bookStock = bStock1.Text.Trim();

                //managing current stock
                int stockDifference = int.Parse(bookStock) - int.Parse(oldTotalStock);
                int newCurrentStock = int.Parse(oldCurrentStock) + stockDifference;

                //inserting book data
                SqlCommand boCmd = new SqlCommand("UPDATE book SET name = @bookeTitle, description = @bookDescription, genre = @bookGenre," +
                    "edition = @bookEdition, bookImage = @imagePath, price = @bookPrice, totalStock = @bookStock, " +
                    "currentStock = @newCurrentStock where bookID = @bookID", con);

                boCmd.Parameters.AddWithValue("@bookID", bookID);
                boCmd.Parameters.AddWithValue("@bookeTitle", bookeTitle);
                boCmd.Parameters.AddWithValue("@bookDescription", bookDescription);
                boCmd.Parameters.AddWithValue("@bookGenre", bookGenre);
                boCmd.Parameters.AddWithValue("@bookEdition", bookEdition);
                boCmd.Parameters.AddWithValue("@imagePath", imagePath);
                boCmd.Parameters.AddWithValue("@bookPrice", bookPrice);
                boCmd.Parameters.AddWithValue("@bookStock", bookStock);
                boCmd.Parameters.AddWithValue("@newCurrentStock", newCurrentStock);


                boCmd.ExecuteNonQuery();

                //clearing fields
                clearFields();

                //closing connection
                con.Close();

                //successfull
                MessageBox.Show("book Updated successfully", "Successfull",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Updating book Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //clearing fields
        private void button3_Click(object sender, EventArgs e)
        {

            //clearing input fields details
            clearFields();

        }

        //deleting book
        private void deleteBook_Click(object sender, EventArgs e)
        {

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            try
            {
                //cheking book exist or not
                checkBookExist();

                //deleeting book 
                string bookID = textBox5.Text.Trim();
                SqlCommand deCmd = new SqlCommand("delete from book where bookID = @bookID", con);
                deCmd.Parameters.AddWithValue("@bookID", bookID);
                deCmd.ExecuteNonQuery();

                //clearing input fields details
                clearFields();

                MessageBox.Show("Deleted Successfullly", "Successfull",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Deleting book Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //cheking book exist or not

        }

        private void upEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
           
        }

        private void bStock_TextChanged(object sender, EventArgs e)
        {

        }

        //----------------------------------------- user define functions

        public void checkBookExist() { 
            
            string bookID = textBox5.Text.Trim();

            SqlCommand idCmd = new SqlCommand("select * from book where bookID = @bookID", con);
            idCmd.Parameters.AddWithValue("@bookID", bookID);

            SqlDataAdapter da = new SqlDataAdapter(idCmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if(dt.Rows.Count == 0)
            {
                throw new Exception("Book with the given ID does not exist");
            }
           
        }

        public void clearFields()
        {
            //openning connection if it is close
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            // clearing fields
            try
            {
                //enabling comboBoxes
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;

                //clearing picture
                pictureBox1.Image = null;

                //clearing input feilds
                bTitle.Text = "";
                bGenre.Text = "";
                bPrice.Text = "";
                bEdition.Text = "";
                bDescription.Text = "";
                bStock1.Text = "";

                // filing comboBox1 with author 
                fillAuthorBox();

                //filing comboBox2 with publisher
                fillPublisherBox();

                //closing connection
                con.Close();

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Clearing Feilds Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void fillAuthorBox()
        {
            //getting auther names from database
            SqlCommand auCmd = new SqlCommand("select fullname from auther", con);
            SqlDataAdapter auDa = new SqlDataAdapter(auCmd);
            DataTable auDt = new DataTable();
            auDa.Fill(auDt);

            //filling comboBox1 with auther names
            comboBox1.DataSource = auDt;
            comboBox1.DisplayMember = "fullname";

        }

        public void fillPublisherBox()
        {
            //getting Publisher names from database
            SqlCommand puCmd = new SqlCommand("select fullname from publisher", con);
            SqlDataAdapter puDa = new SqlDataAdapter(puCmd);
            DataTable puDt = new DataTable();
            puDa.Fill(puDt);

            //filling comboBox2 with publisher names
            comboBox2.DataSource = puDt;
            comboBox2.DisplayMember = "fullname";
        }

        public void checkAuthor()
        {
            //getting auther names from database
            SqlCommand auCmd = new SqlCommand("select fullname from auther where fullname = @fullname", con);
            auCmd.Parameters.AddWithValue("@fullname", comboBox1.Text.Trim());
            SqlDataAdapter auDa = new SqlDataAdapter(auCmd);
            DataTable auDt = new DataTable();
            auDa.Fill(auDt);

            //throwing exeption if author name does not exist
            if (auDt.Rows.Count == 0)
            {
                throw new Exception("Invalid author name");
            }

        }

        public void checkPublisher()
        {
            //getting Publisher names from database
            SqlCommand puCmd = new SqlCommand("select fullname from publisher where fullname = @fullname", con);
            puCmd.Parameters.AddWithValue("@fullname", comboBox2.Text.Trim());
            SqlDataAdapter puDa = new SqlDataAdapter(puCmd);
            DataTable puDt = new DataTable();
            puDa.Fill(puDt);

            //throwing exeption if publisher name does not exist
            if (puDt.Rows.Count == 0)
            {
                throw new Exception("Invalid Publisher name");
            }
        }

       
    }
}
