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

        private void button10_Click(object sender, EventArgs e)
        {
            sideHome.Height = button10.Height;
            sideHome.Top = button10.Top;
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

        private void button16_Click(object sender, EventArgs e)
        {
            sideHome.Height = button16.Height;
            sideHome.Top = button16.Top;
            adminLogin1.BringToFront();
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
    }
}
