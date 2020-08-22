namespace libraryManagementSystem
{
    partial class authorManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(authorManage));
            this.aUpdate = new System.Windows.Forms.Button();
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
            this.aDelete = new System.Windows.Forms.Button();
            this.aAdd = new System.Windows.Forms.Button();
            this.aGetDetail = new System.Windows.Forms.Button();
            this.aName = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bGenreajsh = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dBLibraryDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autherBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBLibraryDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBLibraryDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // aUpdate
            // 
            this.aUpdate.BackColor = System.Drawing.Color.Navy;
            this.aUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aUpdate.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold);
            this.aUpdate.ForeColor = System.Drawing.Color.White;
            this.aUpdate.Location = new System.Drawing.Point(365, 625);
            this.aUpdate.Name = "aUpdate";
            this.aUpdate.Size = new System.Drawing.Size(159, 57);
            this.aUpdate.TabIndex = 86;
            this.aUpdate.Text = "Update";
            this.aUpdate.UseVisualStyleBackColor = false;
            this.aUpdate.Click += new System.EventHandler(this.aUpdate_Click);
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
            this.panel1.Location = new System.Drawing.Point(-13, -12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1616, 142);
            this.panel1.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(367, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(869, 63);
            this.label3.TabIndex = 1;
            this.label3.Text = "Manage Author (Add, Update or Delete)";
            // 
            // aDelete
            // 
            this.aDelete.BackColor = System.Drawing.Color.Maroon;
            this.aDelete.FlatAppearance.BorderSize = 0;
            this.aDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aDelete.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.aDelete.Location = new System.Drawing.Point(552, 628);
            this.aDelete.Name = "aDelete";
            this.aDelete.Size = new System.Drawing.Size(159, 50);
            this.aDelete.TabIndex = 80;
            this.aDelete.Text = "Delete";
            this.aDelete.UseVisualStyleBackColor = false;
            this.aDelete.Click += new System.EventHandler(this.aDelete_Click);
            // 
            // aAdd
            // 
            this.aAdd.BackColor = System.Drawing.Color.Green;
            this.aAdd.FlatAppearance.BorderSize = 0;
            this.aAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aAdd.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.aAdd.Location = new System.Drawing.Point(178, 628);
            this.aAdd.Name = "aAdd";
            this.aAdd.Size = new System.Drawing.Size(159, 50);
            this.aAdd.TabIndex = 79;
            this.aAdd.Text = "Add";
            this.aAdd.UseVisualStyleBackColor = false;
            this.aAdd.Click += new System.EventHandler(this.aAdd_Click);
            // 
            // aGetDetail
            // 
            this.aGetDetail.BackColor = System.Drawing.Color.Green;
            this.aGetDetail.FlatAppearance.BorderSize = 0;
            this.aGetDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aGetDetail.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold);
            this.aGetDetail.ForeColor = System.Drawing.SystemColors.Control;
            this.aGetDetail.Location = new System.Drawing.Point(467, 295);
            this.aGetDetail.Name = "aGetDetail";
            this.aGetDetail.Size = new System.Drawing.Size(150, 48);
            this.aGetDetail.TabIndex = 78;
            this.aGetDetail.Text = "Get Details";
            this.aGetDetail.UseVisualStyleBackColor = false;
            this.aGetDetail.Click += new System.EventHandler(this.aGetDetail_Click);
            // 
            // aName
            // 
            this.aName.BackColor = System.Drawing.SystemColors.Control;
            this.aName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aName.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aName.Location = new System.Drawing.Point(259, 484);
            this.aName.Name = "aName";
            this.aName.Size = new System.Drawing.Size(332, 27);
            this.aName.TabIndex = 72;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Location = new System.Drawing.Point(268, 342);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(168, 1);
            this.panel4.TabIndex = 63;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Control;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(268, 310);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(168, 27);
            this.textBox5.TabIndex = 74;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel6.Location = new System.Drawing.Point(259, 516);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(358, 1);
            this.panel6.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 13F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(262, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 33);
            this.label1.TabIndex = 53;
            this.label1.Text = "Author ID";
            // 
            // bGenreajsh
            // 
            this.bGenreajsh.AutoSize = true;
            this.bGenreajsh.Font = new System.Drawing.Font("Franklin Gothic Medium", 13F);
            this.bGenreajsh.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.bGenreajsh.Location = new System.Drawing.Point(253, 437);
            this.bGenreajsh.Name = "bGenreajsh";
            this.bGenreajsh.Size = new System.Drawing.Size(83, 33);
            this.bGenreajsh.TabIndex = 55;
            this.bGenreajsh.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F);
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(882, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "AUTHOR ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F);
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(1111, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 38);
            this.label4.TabIndex = 1;
            this.label4.Text = "AUTHOR NAME";
            // 
            // authorManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.aUpdate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.aDelete);
            this.Controls.Add(this.aAdd);
            this.Controls.Add(this.aGetDetail);
            this.Controls.Add(this.aName);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bGenreajsh);
            this.Name = "authorManage";
            this.Size = new System.Drawing.Size(1528, 2095);
            this.Load += new System.EventHandler(this.authorManage_Load);
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

        private System.Windows.Forms.Button aUpdate;
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
        private System.Windows.Forms.Button aDelete;
        private System.Windows.Forms.Button aAdd;
        private System.Windows.Forms.Button aGetDetail;
        private System.Windows.Forms.TextBox aName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label bGenreajsh;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}
