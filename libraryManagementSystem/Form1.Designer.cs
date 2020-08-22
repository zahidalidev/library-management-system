namespace libraryManagementSystem
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button16 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.sideHome = new System.Windows.Forms.Panel();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.fileSystemWatcher2 = new System.IO.FileSystemWatcher();
            this.label2 = new System.Windows.Forms.Label();
            this.adminLogin1 = new libraryManagementSystem.adminLogin();
            this.signup1 = new libraryManagementSystem.signup();
            this.userLogin1 = new libraryManagementSystem.userLogin();
            this.manageUser1 = new libraryManagementSystem.manageUser();
            this.bookIssue1 = new libraryManagementSystem.bookIssue();
            this.viewBooks1 = new libraryManagementSystem.viewBooks();
            this.books1 = new libraryManagementSystem.books();
            this.authorManage1 = new libraryManagementSystem.authorManage();
            this.publisherManage1 = new libraryManagementSystem.publisherManage();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.button16);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button15);
            this.panel1.Controls.Add(this.sideHome);
            this.panel1.Controls.Add(this.button14);
            this.panel1.Controls.Add(this.button13);
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 3605);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button16
            // 
            this.button16.FlatAppearance.BorderSize = 0;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Font = new System.Drawing.Font("Franklin Gothic Medium", 11F);
            this.button16.Location = new System.Drawing.Point(12, 840);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(217, 66);
            this.button16.TabIndex = 11;
            this.button16.Text = "Admin Login";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Franklin Gothic Medium", 11F);
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(12, 122);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(217, 66);
            this.button8.TabIndex = 5;
            this.button8.Text = "vew Books";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // button15
            // 
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Franklin Gothic Medium", 11F);
            this.button15.Location = new System.Drawing.Point(12, 717);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(217, 66);
            this.button15.TabIndex = 10;
            this.button15.Text = "Manage Users";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // sideHome
            // 
            this.sideHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.sideHome.Location = new System.Drawing.Point(0, 122);
            this.sideHome.Name = "sideHome";
            this.sideHome.Size = new System.Drawing.Size(14, 66);
            this.sideHome.TabIndex = 2;
            // 
            // button14
            // 
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Franklin Gothic Medium", 11F);
            this.button14.Location = new System.Drawing.Point(12, 632);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(217, 66);
            this.button14.TabIndex = 9;
            this.button14.Text = "Book Issue";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button13
            // 
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Franklin Gothic Medium", 11F);
            this.button13.Location = new System.Drawing.Point(12, 547);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(217, 66);
            this.button13.TabIndex = 8;
            this.button13.Text = "Books Manager";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button12
            // 
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Franklin Gothic Medium", 11F);
            this.button12.Location = new System.Drawing.Point(12, 462);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(217, 66);
            this.button12.TabIndex = 7;
            this.button12.Text = "Publisher Manage";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Franklin Gothic Medium", 11F);
            this.button11.Location = new System.Drawing.Point(12, 377);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(216, 66);
            this.button11.TabIndex = 6;
            this.button11.Text = "Auther Manage";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Franklin Gothic Medium", 11F);
            this.button10.Location = new System.Drawing.Point(12, 292);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(217, 66);
            this.button10.TabIndex = 5;
            this.button10.Text = "Sign Up";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Franklin Gothic Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(217, 66);
            this.button2.TabIndex = 3;
            this.button2.Text = "User Login";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel5.Location = new System.Drawing.Point(64, 68);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(164, 10);
            this.panel5.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(31, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 61);
            this.label1.TabIndex = 2;
            this.label1.Text = "library";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Location = new System.Drawing.Point(227, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1445, 12);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // fileSystemWatcher2
            // 
            this.fileSystemWatcher2.EnableRaisingEvents = true;
            this.fileSystemWatcher2.SynchronizingObject = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(822, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "View Books";
            // 
            // adminLogin1
            // 
            this.adminLogin1.Location = new System.Drawing.Point(227, 0);
            this.adminLogin1.Name = "adminLogin1";
            this.adminLogin1.Size = new System.Drawing.Size(1514, 2095);
            this.adminLogin1.TabIndex = 14;
            // 
            // signup1
            // 
            this.signup1.Location = new System.Drawing.Point(228, 0);
            this.signup1.Name = "signup1";
            this.signup1.Size = new System.Drawing.Size(1513, 2095);
            this.signup1.TabIndex = 13;
            // 
            // userLogin1
            // 
            this.userLogin1.Location = new System.Drawing.Point(227, 0);
            this.userLogin1.Name = "userLogin1";
            this.userLogin1.Size = new System.Drawing.Size(1514, 2095);
            this.userLogin1.TabIndex = 12;
            // 
            // manageUser1
            // 
            this.manageUser1.Location = new System.Drawing.Point(228, 16);
            this.manageUser1.Name = "manageUser1";
            this.manageUser1.Size = new System.Drawing.Size(1343, 894);
            this.manageUser1.TabIndex = 10;
            // 
            // bookIssue1
            // 
            this.bookIssue1.Location = new System.Drawing.Point(228, 18);
            this.bookIssue1.Name = "bookIssue1";
            this.bookIssue1.Size = new System.Drawing.Size(1343, 894);
            this.bookIssue1.TabIndex = 9;
            // 
            // viewBooks1
            // 
            this.viewBooks1.Location = new System.Drawing.Point(227, 0);
            this.viewBooks1.Name = "viewBooks1";
            this.viewBooks1.Size = new System.Drawing.Size(1514, 3510);
            this.viewBooks1.TabIndex = 2;
            // 
            // books1
            // 
            this.books1.Location = new System.Drawing.Point(227, 0);
            this.books1.Name = "books1";
            this.books1.Size = new System.Drawing.Size(1514, 2095);
            this.books1.TabIndex = 15;
            // 
            // authorManage1
            // 
            this.authorManage1.Location = new System.Drawing.Point(228, 0);
            this.authorManage1.Name = "authorManage1";
            this.authorManage1.Size = new System.Drawing.Size(1528, 2095);
            this.authorManage1.TabIndex = 16;
            // 
            // publisherManage1
            // 
            this.publisherManage1.Location = new System.Drawing.Point(227, 0);
            this.publisherManage1.Name = "publisherManage1";
            this.publisherManage1.Size = new System.Drawing.Size(1528, 2095);
            this.publisherManage1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(0, 95);
            this.AutoScrollMinSize = new System.Drawing.Size(0, 95);
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1765, 1000);
            this.Controls.Add(this.publisherManage1);
            this.Controls.Add(this.authorManage1);
            this.Controls.Add(this.books1);
            this.Controls.Add(this.adminLogin1);
            this.Controls.Add(this.signup1);
            this.Controls.Add(this.userLogin1);
            this.Controls.Add(this.manageUser1);
            this.Controls.Add(this.bookIssue1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.viewBooks1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1765, 1000);
            this.MinimumSize = new System.Drawing.Size(1665, 1000);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel sideHome;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.IO.FileSystemWatcher fileSystemWatcher2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private bookIssue bookIssue1;
        private manageUser manageUser1;
        private userLogin userLogin1;
        private signup signup1;
        private adminLogin adminLogin1;
        private viewBooks viewBooks1;
        private books books1;
        private authorManage authorManage1;
        private publisherManage publisherManage1;
    }
}

