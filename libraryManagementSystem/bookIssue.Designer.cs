namespace libraryManagementSystem
{
    partial class bookIssue
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bookIssue));
            this.label4 = new System.Windows.Forms.Label();
            this.returnBook = new System.Windows.Forms.Button();
            this.issueBook = new System.Windows.Forms.Button();
            this.mGetDetail = new System.Windows.Forms.Button();
            this.memName = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.memID = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bGenreajsh = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dBLibraryDataSet = new libraryManagementSystem.DBLibraryDataSet();
            this.autherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autherTableAdapter = new libraryManagementSystem.DBLibraryDataSetTableAdapters.autherTableAdapter();
            this.autherTableAdapter1 = new libraryManagementSystem.DBLibraryDataSet1TableAdapters.autherTableAdapter();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.dBLibraryDataSet1 = new libraryManagementSystem.DBLibraryDataSet1();
            this.autherBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dBLibraryDataSet2 = new libraryManagementSystem.DBLibraryDataSet2();
            this.label2 = new System.Windows.Forms.Label();
            this.BookTitle = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bookID = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.previousPage = new System.Windows.Forms.Button();
            this.nextPage = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dBLibraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBLibraryDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autherBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBLibraryDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F);
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(1205, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 38);
            this.label4.TabIndex = 87;
            this.label4.Text = "Book ID";
            // 
            // returnBook
            // 
            this.returnBook.BackColor = System.Drawing.Color.Maroon;
            this.returnBook.FlatAppearance.BorderSize = 0;
            this.returnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnBook.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBook.ForeColor = System.Drawing.SystemColors.Control;
            this.returnBook.Location = new System.Drawing.Point(494, 723);
            this.returnBook.Name = "returnBook";
            this.returnBook.Size = new System.Drawing.Size(212, 50);
            this.returnBook.TabIndex = 98;
            this.returnBook.Text = "Return Book";
            this.returnBook.UseVisualStyleBackColor = false;
            this.returnBook.Click += new System.EventHandler(this.returnBook_Click);
            // 
            // issueBook
            // 
            this.issueBook.BackColor = System.Drawing.Color.Green;
            this.issueBook.FlatAppearance.BorderSize = 0;
            this.issueBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.issueBook.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueBook.ForeColor = System.Drawing.SystemColors.Control;
            this.issueBook.Location = new System.Drawing.Point(227, 723);
            this.issueBook.Name = "issueBook";
            this.issueBook.Size = new System.Drawing.Size(212, 50);
            this.issueBook.TabIndex = 97;
            this.issueBook.Text = "Issue Book";
            this.issueBook.UseVisualStyleBackColor = false;
            this.issueBook.Click += new System.EventHandler(this.issueBook_Click);
            // 
            // mGetDetail
            // 
            this.mGetDetail.BackColor = System.Drawing.Color.Green;
            this.mGetDetail.FlatAppearance.BorderSize = 0;
            this.mGetDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mGetDetail.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold);
            this.mGetDetail.ForeColor = System.Drawing.SystemColors.Control;
            this.mGetDetail.Location = new System.Drawing.Point(624, 294);
            this.mGetDetail.Name = "mGetDetail";
            this.mGetDetail.Size = new System.Drawing.Size(150, 48);
            this.mGetDetail.TabIndex = 96;
            this.mGetDetail.Text = "Get Details";
            this.mGetDetail.UseVisualStyleBackColor = false;
            this.mGetDetail.Click += new System.EventHandler(this.mGetDetail_Click);
            // 
            // memName
            // 
            this.memName.BackColor = System.Drawing.SystemColors.Control;
            this.memName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.memName.Enabled = false;
            this.memName.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memName.Location = new System.Drawing.Point(187, 457);
            this.memName.Name = "memName";
            this.memName.Size = new System.Drawing.Size(332, 27);
            this.memName.TabIndex = 94;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Location = new System.Drawing.Point(187, 341);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(168, 1);
            this.panel4.TabIndex = 93;
            // 
            // memID
            // 
            this.memID.BackColor = System.Drawing.SystemColors.Control;
            this.memID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.memID.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memID.Location = new System.Drawing.Point(187, 309);
            this.memID.Name = "memID";
            this.memID.Size = new System.Drawing.Size(168, 27);
            this.memID.TabIndex = 95;
            this.memID.TextChanged += new System.EventHandler(this.memID_TextChanged);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel6.Location = new System.Drawing.Point(187, 489);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(358, 1);
            this.panel6.TabIndex = 92;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 13F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(181, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 33);
            this.label1.TabIndex = 89;
            this.label1.Text = "Member ID";
            // 
            // bGenreajsh
            // 
            this.bGenreajsh.AutoSize = true;
            this.bGenreajsh.Font = new System.Drawing.Font("Franklin Gothic Medium", 13F);
            this.bGenreajsh.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.bGenreajsh.Location = new System.Drawing.Point(181, 410);
            this.bGenreajsh.Name = "bGenreajsh";
            this.bGenreajsh.Size = new System.Drawing.Size(185, 33);
            this.bGenreajsh.TabIndex = 90;
            this.bGenreajsh.Text = "Member Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(521, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(509, 63);
            this.label3.TabIndex = 1;
            this.label3.Text = "Issue Book to Member";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-26, -11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1702, 142);
            this.panel1.TabIndex = 91;
            // 
            // dBLibraryDataSet
            // 
            this.dBLibraryDataSet.DataSetName = "DBLibraryDataSet";
            this.dBLibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // autherBindingSource
            // 
            this.autherBindingSource.DataMember = "auther";
            this.autherBindingSource.DataSource = this.dBLibraryDataSet;
            // 
            // autherTableAdapter
            // 
            this.autherTableAdapter.ClearBeforeFill = true;
            // 
            // autherTableAdapter1
            // 
            this.autherTableAdapter1.ClearBeforeFill = true;
            // 
            // dBLibraryDataSet1
            // 
            this.dBLibraryDataSet1.DataSetName = "DBLibraryDataSet1";
            this.dBLibraryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // autherBindingSource1
            // 
            this.autherBindingSource1.DataMember = "auther";
            this.autherBindingSource1.DataSource = this.dBLibraryDataSet1;
            // 
            // dBLibraryDataSet2
            // 
            this.dBLibraryDataSet2.DataSetName = "DBLibraryDataSet2";
            this.dBLibraryDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F);
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(924, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 38);
            this.label2.TabIndex = 88;
            this.label2.Text = "Member ID";
            // 
            // BookTitle
            // 
            this.BookTitle.BackColor = System.Drawing.SystemColors.Control;
            this.BookTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BookTitle.Enabled = false;
            this.BookTitle.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookTitle.Location = new System.Drawing.Point(187, 616);
            this.BookTitle.Name = "BookTitle";
            this.BookTitle.Size = new System.Drawing.Size(332, 27);
            this.BookTitle.TabIndex = 104;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Location = new System.Drawing.Point(415, 341);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(168, 1);
            this.panel2.TabIndex = 103;
            // 
            // bookID
            // 
            this.bookID.BackColor = System.Drawing.SystemColors.Control;
            this.bookID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bookID.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookID.Location = new System.Drawing.Point(415, 309);
            this.bookID.Name = "bookID";
            this.bookID.Size = new System.Drawing.Size(168, 27);
            this.bookID.TabIndex = 105;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Location = new System.Drawing.Point(187, 648);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(358, 1);
            this.panel3.TabIndex = 102;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 13F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(409, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 33);
            this.label5.TabIndex = 100;
            this.label5.Text = "Book ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 13F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Location = new System.Drawing.Point(181, 569);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 33);
            this.label6.TabIndex = 101;
            this.label6.Text = "Book Title";
            // 
            // previousPage
            // 
            this.previousPage.BackColor = System.Drawing.Color.Gray;
            this.previousPage.FlatAppearance.BorderSize = 0;
            this.previousPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previousPage.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousPage.ForeColor = System.Drawing.SystemColors.Control;
            this.previousPage.Location = new System.Drawing.Point(981, 791);
            this.previousPage.Name = "previousPage";
            this.previousPage.Size = new System.Drawing.Size(91, 50);
            this.previousPage.TabIndex = 107;
            this.previousPage.Text = "<<";
            this.previousPage.UseVisualStyleBackColor = false;
            this.previousPage.Click += new System.EventHandler(this.previousPage_Click);
            // 
            // nextPage
            // 
            this.nextPage.BackColor = System.Drawing.Color.Gray;
            this.nextPage.FlatAppearance.BorderSize = 0;
            this.nextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextPage.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextPage.ForeColor = System.Drawing.SystemColors.Control;
            this.nextPage.Location = new System.Drawing.Point(1199, 791);
            this.nextPage.Name = "nextPage";
            this.nextPage.Size = new System.Drawing.Size(91, 50);
            this.nextPage.TabIndex = 106;
            this.nextPage.Text = ">>";
            this.nextPage.UseVisualStyleBackColor = false;
            this.nextPage.Click += new System.EventHandler(this.nextPage_Click);
            // 
            // bookIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.previousPage);
            this.Controls.Add(this.nextPage);
            this.Controls.Add(this.BookTitle);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bookID);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.returnBook);
            this.Controls.Add(this.issueBook);
            this.Controls.Add(this.mGetDetail);
            this.Controls.Add(this.memName);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.memID);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bGenreajsh);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Name = "bookIssue";
            this.Size = new System.Drawing.Size(1528, 2095);
            this.Load += new System.EventHandler(this.bookIssue_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dBLibraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBLibraryDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autherBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBLibraryDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button returnBook;
        private System.Windows.Forms.Button issueBook;
        private System.Windows.Forms.Button mGetDetail;
        private System.Windows.Forms.TextBox memName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox memID;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label bGenreajsh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private DBLibraryDataSet dBLibraryDataSet;
        private System.Windows.Forms.BindingSource autherBindingSource;
        private DBLibraryDataSetTableAdapters.autherTableAdapter autherTableAdapter;
        private DBLibraryDataSet1TableAdapters.autherTableAdapter autherTableAdapter1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private DBLibraryDataSet1 dBLibraryDataSet1;
        private System.Windows.Forms.BindingSource autherBindingSource1;
        private DBLibraryDataSet2 dBLibraryDataSet2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BookTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox bookID;
        public System.Windows.Forms.Button previousPage;
        public System.Windows.Forms.Button nextPage;
    }
}
