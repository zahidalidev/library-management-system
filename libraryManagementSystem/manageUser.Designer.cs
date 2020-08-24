namespace libraryManagementSystem
{
    partial class manageUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manageUser));
            this.label2 = new System.Windows.Forms.Label();
            this.dBLibraryDataSet2 = new libraryManagementSystem.DBLibraryDataSet2();
            this.autherBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dBLibraryDataSet1 = new libraryManagementSystem.DBLibraryDataSet1();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.autherTableAdapter1 = new libraryManagementSystem.DBLibraryDataSet1TableAdapters.autherTableAdapter();
            this.autherTableAdapter = new libraryManagementSystem.DBLibraryDataSetTableAdapters.autherTableAdapter();
            this.autherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBLibraryDataSet = new libraryManagementSystem.DBLibraryDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.returnBook = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.memID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.previousPage = new System.Windows.Forms.Button();
            this.nextPage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dBLibraryDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autherBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBLibraryDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBLibraryDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F);
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(449, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 38);
            this.label2.TabIndex = 107;
            this.label2.Text = "Member ID";
            // 
            // dBLibraryDataSet2
            // 
            this.dBLibraryDataSet2.DataSetName = "DBLibraryDataSet2";
            this.dBLibraryDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // autherBindingSource1
            // 
            this.autherBindingSource1.DataMember = "auther";
            this.autherBindingSource1.DataSource = this.dBLibraryDataSet1;
            // 
            // dBLibraryDataSet1
            // 
            this.dBLibraryDataSet1.DataSetName = "DBLibraryDataSet1";
            this.dBLibraryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // autherTableAdapter1
            // 
            this.autherTableAdapter1.ClearBeforeFill = true;
            // 
            // autherTableAdapter
            // 
            this.autherTableAdapter.ClearBeforeFill = true;
            // 
            // autherBindingSource
            // 
            this.autherBindingSource.DataMember = "auther";
            this.autherBindingSource.DataSource = this.dBLibraryDataSet;
            // 
            // dBLibraryDataSet
            // 
            this.dBLibraryDataSet.DataSetName = "DBLibraryDataSet";
            this.dBLibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-79, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1753, 142);
            this.panel1.TabIndex = 110;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(605, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(332, 63);
            this.label3.TabIndex = 1;
            this.label3.Text = "Manage Users";
            // 
            // returnBook
            // 
            this.returnBook.BackColor = System.Drawing.Color.Maroon;
            this.returnBook.FlatAppearance.BorderSize = 0;
            this.returnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnBook.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBook.ForeColor = System.Drawing.SystemColors.Control;
            this.returnBook.Location = new System.Drawing.Point(118, 493);
            this.returnBook.Name = "returnBook";
            this.returnBook.Size = new System.Drawing.Size(235, 50);
            this.returnBook.TabIndex = 117;
            this.returnBook.Text = "Delete Account";
            this.returnBook.UseVisualStyleBackColor = false;
            this.returnBook.Click += new System.EventHandler(this.returnBook_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Location = new System.Drawing.Point(154, 431);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(168, 1);
            this.panel4.TabIndex = 112;
            // 
            // memID
            // 
            this.memID.BackColor = System.Drawing.SystemColors.Control;
            this.memID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.memID.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memID.Location = new System.Drawing.Point(154, 399);
            this.memID.Name = "memID";
            this.memID.Size = new System.Drawing.Size(168, 27);
            this.memID.TabIndex = 114;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 13F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(148, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 33);
            this.label1.TabIndex = 108;
            this.label1.Text = "Member ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F);
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(680, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 38);
            this.label4.TabIndex = 106;
            this.label4.Text = "Full Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F);
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(1301, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 38);
            this.label5.TabIndex = 106;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F);
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(947, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 38);
            this.label6.TabIndex = 107;
            this.label6.Text = "Contact Number";
            // 
            // previousPage
            // 
            this.previousPage.BackColor = System.Drawing.Color.Gray;
            this.previousPage.FlatAppearance.BorderSize = 0;
            this.previousPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previousPage.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousPage.ForeColor = System.Drawing.SystemColors.Control;
            this.previousPage.Location = new System.Drawing.Point(760, 852);
            this.previousPage.Name = "previousPage";
            this.previousPage.Size = new System.Drawing.Size(91, 50);
            this.previousPage.TabIndex = 119;
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
            this.nextPage.Location = new System.Drawing.Point(978, 852);
            this.nextPage.Name = "nextPage";
            this.nextPage.Size = new System.Drawing.Size(91, 50);
            this.nextPage.TabIndex = 118;
            this.nextPage.Text = ">>";
            this.nextPage.UseVisualStyleBackColor = false;
            this.nextPage.Click += new System.EventHandler(this.nextPage_Click);
            // 
            // manageUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.previousPage);
            this.Controls.Add(this.nextPage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.returnBook);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.memID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "manageUser";
            this.Size = new System.Drawing.Size(1528, 2095);
            this.Load += new System.EventHandler(this.manageUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBLibraryDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autherBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBLibraryDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBLibraryDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private DBLibraryDataSet2 dBLibraryDataSet2;
        private System.Windows.Forms.BindingSource autherBindingSource1;
        private DBLibraryDataSet1 dBLibraryDataSet1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private DBLibraryDataSet1TableAdapters.autherTableAdapter autherTableAdapter1;
        private DBLibraryDataSetTableAdapters.autherTableAdapter autherTableAdapter;
        private System.Windows.Forms.BindingSource autherBindingSource;
        private DBLibraryDataSet dBLibraryDataSet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button returnBook;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox memID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button previousPage;
        public System.Windows.Forms.Button nextPage;
    }
}
