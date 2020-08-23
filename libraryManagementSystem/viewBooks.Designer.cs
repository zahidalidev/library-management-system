namespace libraryManagementSystem
{
    partial class viewBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewBooks));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.aAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1546, 114);
            this.panel1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(688, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 63);
            this.label4.TabIndex = 1;
            this.label4.Text = "Books";
            // 
            // aAdd
            // 
            this.aAdd.BackColor = System.Drawing.Color.Maroon;
            this.aAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("aAdd.BackgroundImage")));
            this.aAdd.FlatAppearance.BorderSize = 0;
            this.aAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aAdd.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.aAdd.Location = new System.Drawing.Point(1341, 139);
            this.aAdd.Name = "aAdd";
            this.aAdd.Size = new System.Drawing.Size(159, 50);
            this.aAdd.TabIndex = 80;
            this.aAdd.Text = "Referesh";
            this.aAdd.UseVisualStyleBackColor = false;
            this.aAdd.Click += new System.EventHandler(this.aAdd_Click);
            // 
            // viewBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.aAdd);
            this.Controls.Add(this.panel1);
            this.Name = "viewBooks";
            this.Size = new System.Drawing.Size(1545, 2069);
            this.Load += new System.EventHandler(this.viewBooks_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button aAdd;
    }
}
