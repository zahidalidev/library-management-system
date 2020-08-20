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

namespace libraryManagementSystem
{
    public partial class books : UserControl
    {
        public books()
        {
            InitializeComponent();
        }

        private void books_Load(object sender, System.EventArgs e)
        {

        }

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
                MessageBox.Show("Image name is invalid try another name or image", error.Message, 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void addBook_Click(object sender, EventArgs e)
        {

        }

        private void updateBook_Click(object sender, EventArgs e)
        {

        }

        private void deleteBook_Click(object sender, EventArgs e)
        {

        }
    }
}
