using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libraryManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            sideHome.Height = button8.Height;
            sideHome.Top = button8.Top;
            viewBooks1.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            userLogin1.BringToFront();
        }
       
        private void button8_Click_1(object sender, EventArgs e)
        {
            sideHome.Height = button8.Height;
            sideHome.Top = button8.Top;
            viewBooks1.BringToFront();
        }
    }
}
