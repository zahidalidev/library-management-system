namespace libraryManagementSystem
{
    partial class books
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(books));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.bGetDetail = new System.Windows.Forms.Button();
            this.bDescriptionad = new System.Windows.Forms.Label();
            this.bPrice = new System.Windows.Forms.TextBox();
            this.bGenre = new System.Windows.Forms.TextBox();
            this.bTitle = new System.Windows.Forms.TextBox();
            this.bDescription = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.bPublisher = new System.Windows.Forms.Label();
            this.bPriceasa = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bStockansba = new System.Windows.Forms.Label();
            this.bGenreajsh = new System.Windows.Forms.Label();
            this.bTitlejah = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bEditionajs = new System.Windows.Forms.Label();
            this.bAuthorasjha = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.bEdition = new System.Windows.Forms.TextBox();
            this.deleteBook = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dBLibraryDataSet = new libraryManagementSystem.DBLibraryDataSet();
            this.autherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autherTableAdapter = new libraryManagementSystem.DBLibraryDataSetTableAdapters.autherTableAdapter();
            this.dBLibraryDataSet1 = new libraryManagementSystem.DBLibraryDataSet1();
            this.autherBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.autherTableAdapter1 = new libraryManagementSystem.DBLibraryDataSet1TableAdapters.autherTableAdapter();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dBLibraryDataSet2 = new libraryManagementSystem.DBLibraryDataSet2();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.bStock1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.updateBookOriginal = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBLibraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBLibraryDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autherBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBLibraryDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-67, -15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1616, 142);
            this.panel1.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(441, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(858, 63);
            this.label3.TabIndex = 1;
            this.label3.Text = "Manage Books (Add, Update or Delete)";
            // 
            // bGetDetail
            // 
            this.bGetDetail.BackColor = System.Drawing.Color.Green;
            this.bGetDetail.FlatAppearance.BorderSize = 0;
            this.bGetDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bGetDetail.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold);
            this.bGetDetail.ForeColor = System.Drawing.SystemColors.Control;
            this.bGetDetail.Location = new System.Drawing.Point(804, 264);
            this.bGetDetail.Name = "bGetDetail";
            this.bGetDetail.Size = new System.Drawing.Size(150, 48);
            this.bGetDetail.TabIndex = 46;
            this.bGetDetail.Text = "Get Details";
            this.bGetDetail.UseVisualStyleBackColor = false;
            this.bGetDetail.Click += new System.EventHandler(this.addBook_Click);
            // 
            // bDescriptionad
            // 
            this.bDescriptionad.AutoSize = true;
            this.bDescriptionad.Font = new System.Drawing.Font("Franklin Gothic Medium", 13F);
            this.bDescriptionad.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.bDescriptionad.Location = new System.Drawing.Point(145, 726);
            this.bDescriptionad.Name = "bDescriptionad";
            this.bDescriptionad.Size = new System.Drawing.Size(141, 33);
            this.bDescriptionad.TabIndex = 44;
            this.bDescriptionad.Text = "Description";
            // 
            // bPrice
            // 
            this.bPrice.BackColor = System.Drawing.SystemColors.Control;
            this.bPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bPrice.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPrice.Location = new System.Drawing.Point(573, 453);
            this.bPrice.Name = "bPrice";
            this.bPrice.Size = new System.Drawing.Size(329, 27);
            this.bPrice.TabIndex = 42;
            // 
            // bGenre
            // 
            this.bGenre.BackColor = System.Drawing.SystemColors.Control;
            this.bGenre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bGenre.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bGenre.Location = new System.Drawing.Point(161, 453);
            this.bGenre.Name = "bGenre";
            this.bGenre.Size = new System.Drawing.Size(332, 27);
            this.bGenre.TabIndex = 38;
            // 
            // bTitle
            // 
            this.bTitle.BackColor = System.Drawing.SystemColors.Control;
            this.bTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bTitle.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTitle.Location = new System.Drawing.Point(1010, 280);
            this.bTitle.Name = "bTitle";
            this.bTitle.Size = new System.Drawing.Size(343, 27);
            this.bTitle.TabIndex = 41;
            this.bTitle.TextChanged += new System.EventHandler(this.upEmail_TextChanged);
            // 
            // bDescription
            // 
            this.bDescription.BackColor = System.Drawing.SystemColors.Control;
            this.bDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bDescription.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDescription.Location = new System.Drawing.Point(151, 774);
            this.bDescription.Name = "bDescription";
            this.bDescription.Size = new System.Drawing.Size(1208, 27);
            this.bDescription.TabIndex = 36;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel9.Location = new System.Drawing.Point(1010, 629);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(350, 1);
            this.panel9.TabIndex = 33;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel7.Location = new System.Drawing.Point(573, 485);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(350, 1);
            this.panel7.TabIndex = 32;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Location = new System.Drawing.Point(151, 806);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1208, 1);
            this.panel3.TabIndex = 34;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel6.Location = new System.Drawing.Point(161, 485);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(358, 1);
            this.panel6.TabIndex = 28;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel8.Location = new System.Drawing.Point(1010, 485);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(350, 1);
            this.panel8.TabIndex = 31;
            // 
            // bPublisher
            // 
            this.bPublisher.AutoSize = true;
            this.bPublisher.Font = new System.Drawing.Font("Franklin Gothic Medium", 13F);
            this.bPublisher.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.bPublisher.Location = new System.Drawing.Point(1004, 550);
            this.bPublisher.Name = "bPublisher";
            this.bPublisher.Size = new System.Drawing.Size(196, 33);
            this.bPublisher.TabIndex = 25;
            this.bPublisher.Text = "Select Publisher";
            // 
            // bPriceasa
            // 
            this.bPriceasa.AutoSize = true;
            this.bPriceasa.Font = new System.Drawing.Font("Franklin Gothic Medium", 13F);
            this.bPriceasa.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.bPriceasa.Location = new System.Drawing.Point(567, 406);
            this.bPriceasa.Name = "bPriceasa";
            this.bPriceasa.Size = new System.Drawing.Size(72, 33);
            this.bPriceasa.TabIndex = 24;
            this.bPriceasa.Text = "Price";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Location = new System.Drawing.Point(1010, 312);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(343, 1);
            this.panel2.TabIndex = 29;
            // 
            // bStockansba
            // 
            this.bStockansba.AutoSize = true;
            this.bStockansba.Font = new System.Drawing.Font("Franklin Gothic Medium", 13F);
            this.bStockansba.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.bStockansba.Location = new System.Drawing.Point(1004, 406);
            this.bStockansba.Name = "bStockansba";
            this.bStockansba.Size = new System.Drawing.Size(78, 33);
            this.bStockansba.TabIndex = 23;
            this.bStockansba.Text = "Stock";
            // 
            // bGenreajsh
            // 
            this.bGenreajsh.AutoSize = true;
            this.bGenreajsh.Font = new System.Drawing.Font("Franklin Gothic Medium", 13F);
            this.bGenreajsh.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.bGenreajsh.Location = new System.Drawing.Point(155, 406);
            this.bGenreajsh.Name = "bGenreajsh";
            this.bGenreajsh.Size = new System.Drawing.Size(83, 33);
            this.bGenreajsh.TabIndex = 22;
            this.bGenreajsh.Text = "Genre";
            // 
            // bTitlejah
            // 
            this.bTitlejah.AutoSize = true;
            this.bTitlejah.Font = new System.Drawing.Font("Franklin Gothic Medium", 13F);
            this.bTitlejah.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.bTitlejah.Location = new System.Drawing.Point(1004, 235);
            this.bTitlejah.Name = "bTitlejah";
            this.bTitlejah.Size = new System.Drawing.Size(62, 33);
            this.bTitlejah.TabIndex = 21;
            this.bTitlejah.Text = "Title";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox1.Location = new System.Drawing.Point(152, 155);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(385, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 49);
            this.button1.TabIndex = 48;
            this.button1.Text = "Upload Photo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bEditionajs
            // 
            this.bEditionajs.AutoSize = true;
            this.bEditionajs.Font = new System.Drawing.Font("Franklin Gothic Medium", 13F);
            this.bEditionajs.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.bEditionajs.Location = new System.Drawing.Point(155, 550);
            this.bEditionajs.Name = "bEditionajs";
            this.bEditionajs.Size = new System.Drawing.Size(91, 33);
            this.bEditionajs.TabIndex = 22;
            this.bEditionajs.Text = "Edition";
            // 
            // bAuthorasjha
            // 
            this.bAuthorasjha.AutoSize = true;
            this.bAuthorasjha.Font = new System.Drawing.Font("Franklin Gothic Medium", 13F);
            this.bAuthorasjha.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.bAuthorasjha.Location = new System.Drawing.Point(567, 550);
            this.bAuthorasjha.Name = "bAuthorasjha";
            this.bAuthorasjha.Size = new System.Drawing.Size(166, 33);
            this.bAuthorasjha.TabIndex = 24;
            this.bAuthorasjha.Text = "Select Author";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel10.Location = new System.Drawing.Point(161, 629);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(358, 1);
            this.panel10.TabIndex = 28;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel11.Location = new System.Drawing.Point(573, 629);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(350, 1);
            this.panel11.TabIndex = 32;
            // 
            // bEdition
            // 
            this.bEdition.BackColor = System.Drawing.SystemColors.Control;
            this.bEdition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bEdition.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEdition.Location = new System.Drawing.Point(161, 597);
            this.bEdition.Name = "bEdition";
            this.bEdition.Size = new System.Drawing.Size(332, 27);
            this.bEdition.TabIndex = 38;
            // 
            // deleteBook
            // 
            this.deleteBook.BackColor = System.Drawing.Color.Maroon;
            this.deleteBook.FlatAppearance.BorderSize = 0;
            this.deleteBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBook.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBook.ForeColor = System.Drawing.SystemColors.Control;
            this.deleteBook.Location = new System.Drawing.Point(927, 865);
            this.deleteBook.Name = "deleteBook";
            this.deleteBook.Size = new System.Drawing.Size(159, 50);
            this.deleteBook.TabIndex = 46;
            this.deleteBook.Text = "Delete";
            this.deleteBook.UseVisualStyleBackColor = false;
            this.deleteBook.Click += new System.EventHandler(this.deleteBook_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 13F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(610, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 33);
            this.label1.TabIndex = 21;
            this.label1.Text = "Book ID";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Location = new System.Drawing.Point(616, 310);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(158, 1);
            this.panel4.TabIndex = 29;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Control;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(616, 278);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(158, 27);
            this.textBox5.TabIndex = 41;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(457, 865);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 50);
            this.button2.TabIndex = 46;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.updateBook_Click);
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
            // autherTableAdapter1
            // 
            this.autherTableAdapter1.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.AllowDrop = true;
            this.comboBox1.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.autherBindingSource1, "authorID", true));
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(574, 593);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(347, 28);
            this.comboBox1.TabIndex = 49;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dBLibraryDataSet2
            // 
            this.dBLibraryDataSet2.DataSetName = "DBLibraryDataSet2";
            this.dBLibraryDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.AllowDrop = true;
            this.comboBox2.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(1010, 594);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(349, 28);
            this.comboBox2.TabIndex = 49;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // bStock1
            // 
            this.bStock1.BackColor = System.Drawing.SystemColors.Control;
            this.bStock1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bStock1.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bStock1.Location = new System.Drawing.Point(1010, 452);
            this.bStock1.Name = "bStock1";
            this.bStock1.Size = new System.Drawing.Size(329, 27);
            this.bStock1.TabIndex = 42;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Maroon;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(804, 199);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 49);
            this.button3.TabIndex = 50;
            this.button3.Text = "Clear Fields";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // updateBookOriginal
            // 
            this.updateBookOriginal.BackColor = System.Drawing.Color.Navy;
            this.updateBookOriginal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBookOriginal.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold);
            this.updateBookOriginal.ForeColor = System.Drawing.Color.White;
            this.updateBookOriginal.Location = new System.Drawing.Point(695, 862);
            this.updateBookOriginal.Name = "updateBookOriginal";
            this.updateBookOriginal.Size = new System.Drawing.Size(159, 57);
            this.updateBookOriginal.TabIndex = 51;
            this.updateBookOriginal.Text = "Update";
            this.updateBookOriginal.UseVisualStyleBackColor = false;
            this.updateBookOriginal.Click += new System.EventHandler(this.updateBookOriginal_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Maroon;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(1365, 144);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 40);
            this.button4.TabIndex = 111;
            this.button4.Text = "Referesh";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.updateBookOriginal);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.deleteBook);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bGetDetail);
            this.Controls.Add(this.bDescriptionad);
            this.Controls.Add(this.bEdition);
            this.Controls.Add(this.bStock1);
            this.Controls.Add(this.bPrice);
            this.Controls.Add(this.bGenre);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.bTitle);
            this.Controls.Add(this.bDescription);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.bAuthorasjha);
            this.Controls.Add(this.bPublisher);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.bPriceasa);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bEditionajs);
            this.Controls.Add(this.bStockansba);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bGenreajsh);
            this.Controls.Add(this.bTitlejah);
            this.Name = "books";
            this.Size = new System.Drawing.Size(1528, 2095);
            this.Load += new System.EventHandler(this.books_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBLibraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBLibraryDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autherBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBLibraryDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bGetDetail;
        private System.Windows.Forms.Label bDescriptionad;
        private System.Windows.Forms.TextBox bPrice;
        private System.Windows.Forms.TextBox bTitle;
        private System.Windows.Forms.TextBox bDescription;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label bPublisher;
        private System.Windows.Forms.Label bPriceasa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label bStockansba;
        private System.Windows.Forms.Label bGenreajsh;
        private System.Windows.Forms.Label bTitlejah;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label bEditionajs;
        private System.Windows.Forms.Label bAuthorasjha;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox bEdition;
        private System.Windows.Forms.Button deleteBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox bGenre;
        private System.Windows.Forms.BindingSource autherBindingSource;
        private DBLibraryDataSet dBLibraryDataSet;
        private DBLibraryDataSetTableAdapters.autherTableAdapter autherTableAdapter;
        private System.Windows.Forms.BindingSource autherBindingSource1;
        private DBLibraryDataSet1 dBLibraryDataSet1;
        private DBLibraryDataSet1TableAdapters.autherTableAdapter autherTableAdapter1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private DBLibraryDataSet2 dBLibraryDataSet2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox bStock1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button updateBookOriginal;
        private System.Windows.Forms.Button button4;
    }
}
