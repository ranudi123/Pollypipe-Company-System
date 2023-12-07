namespace PollypipeDB
{
    partial class staff
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
            this.btnlogout = new System.Windows.Forms.Button();
            this.btninstallation = new System.Windows.Forms.Button();
            this.btnequipements = new System.Windows.Forms.Button();
            this.btncustomer = new System.Windows.Forms.Button();
            this.btnstaff = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.stafftypecb = new System.Windows.Forms.ComboBox();
            this.staffdgv = new System.Windows.Forms.DataGridView();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btninsert = new System.Windows.Forms.Button();
            this.txtstafftelno = new System.Windows.Forms.TextBox();
            this.txtstaffname = new System.Windows.Forms.TextBox();
            this.txtstaffid = new System.Windows.Forms.TextBox();
            this.stafftelno = new System.Windows.Forms.Label();
            this.staffname = new System.Windows.Forms.Label();
            this.stafftype = new System.Windows.Forms.Label();
            this.staffid = new System.Windows.Forms.Label();
            this.staffdetails = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffdgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.SeaGreen;
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnlogout.Location = new System.Drawing.Point(95, 565);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(136, 60);
            this.btnlogout.TabIndex = 51;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btninstallation
            // 
            this.btninstallation.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btninstallation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninstallation.Location = new System.Drawing.Point(139, 437);
            this.btninstallation.Name = "btninstallation";
            this.btninstallation.Size = new System.Drawing.Size(171, 73);
            this.btninstallation.TabIndex = 46;
            this.btninstallation.Text = "Installation Management";
            this.btninstallation.UseVisualStyleBackColor = true;
            this.btninstallation.Click += new System.EventHandler(this.btninstallation_Click);
            // 
            // btnequipements
            // 
            this.btnequipements.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnequipements.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnequipements.Location = new System.Drawing.Point(153, 307);
            this.btnequipements.Name = "btnequipements";
            this.btnequipements.Size = new System.Drawing.Size(161, 60);
            this.btnequipements.TabIndex = 45;
            this.btnequipements.Text = "Equipements";
            this.btnequipements.UseVisualStyleBackColor = true;
            this.btnequipements.Click += new System.EventHandler(this.btnequipements_Click);
            // 
            // btncustomer
            // 
            this.btncustomer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btncustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncustomer.Location = new System.Drawing.Point(153, 184);
            this.btncustomer.Name = "btncustomer";
            this.btncustomer.Size = new System.Drawing.Size(132, 60);
            this.btncustomer.TabIndex = 44;
            this.btncustomer.Text = "Customer";
            this.btncustomer.UseVisualStyleBackColor = true;
            this.btncustomer.Click += new System.EventHandler(this.btncustomer_Click);
            // 
            // btnstaff
            // 
            this.btnstaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstaff.Location = new System.Drawing.Point(153, 74);
            this.btnstaff.Name = "btnstaff";
            this.btnstaff.Size = new System.Drawing.Size(132, 60);
            this.btnstaff.TabIndex = 43;
            this.btnstaff.Text = "Staff";
            this.btnstaff.UseVisualStyleBackColor = true;
            this.btnstaff.Click += new System.EventHandler(this.btnstaff_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.stafftypecb);
            this.panel1.Controls.Add(this.staffdgv);
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.btninsert);
            this.panel1.Controls.Add(this.txtstafftelno);
            this.panel1.Controls.Add(this.txtstaffname);
            this.panel1.Controls.Add(this.txtstaffid);
            this.panel1.Controls.Add(this.stafftelno);
            this.panel1.Controls.Add(this.staffname);
            this.panel1.Controls.Add(this.stafftype);
            this.panel1.Controls.Add(this.staffid);
            this.panel1.Controls.Add(this.staffdetails);
            this.panel1.Location = new System.Drawing.Point(320, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 526);
            this.panel1.TabIndex = 42;
            // 
            // stafftypecb
            // 
            this.stafftypecb.FormattingEnabled = true;
            this.stafftypecb.Items.AddRange(new object[] {
            "plumber",
            "installation Manager",
            "Aquatics installer",
            "Brick Layer"});
            this.stafftypecb.Location = new System.Drawing.Point(206, 171);
            this.stafftypecb.Name = "stafftypecb";
            this.stafftypecb.Size = new System.Drawing.Size(145, 24);
            this.stafftypecb.TabIndex = 25;
            this.stafftypecb.SelectedIndexChanged += new System.EventHandler(this.stafftypecb_SelectedIndexChanged);
            // 
            // staffdgv
            // 
            this.staffdgv.AllowUserToAddRows = false;
            this.staffdgv.AllowUserToDeleteRows = false;
            this.staffdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staffdgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.staffdgv.Location = new System.Drawing.Point(362, 107);
            this.staffdgv.Name = "staffdgv";
            this.staffdgv.ReadOnly = true;
            this.staffdgv.RowHeadersWidth = 51;
            this.staffdgv.RowTemplate.Height = 24;
            this.staffdgv.Size = new System.Drawing.Size(467, 348);
            this.staffdgv.TabIndex = 24;
            this.staffdgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.staffdgv_CellContentClick);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(154, 414);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(104, 41);
            this.btndelete.TabIndex = 23;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(221, 353);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(104, 41);
            this.btnupdate.TabIndex = 22;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btninsert
            // 
            this.btninsert.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btninsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsert.Location = new System.Drawing.Point(79, 353);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(104, 41);
            this.btninsert.TabIndex = 21;
            this.btninsert.Text = "Insert";
            this.btninsert.UseVisualStyleBackColor = false;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // txtstafftelno
            // 
            this.txtstafftelno.Location = new System.Drawing.Point(206, 285);
            this.txtstafftelno.Name = "txtstafftelno";
            this.txtstafftelno.Size = new System.Drawing.Size(145, 22);
            this.txtstafftelno.TabIndex = 19;
            // 
            // txtstaffname
            // 
            this.txtstaffname.Location = new System.Drawing.Point(206, 232);
            this.txtstaffname.Name = "txtstaffname";
            this.txtstaffname.Size = new System.Drawing.Size(145, 22);
            this.txtstaffname.TabIndex = 18;
            // 
            // txtstaffid
            // 
            this.txtstaffid.Location = new System.Drawing.Point(206, 107);
            this.txtstaffid.Name = "txtstaffid";
            this.txtstaffid.Size = new System.Drawing.Size(145, 22);
            this.txtstaffid.TabIndex = 17;
            // 
            // stafftelno
            // 
            this.stafftelno.AutoSize = true;
            this.stafftelno.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.stafftelno.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stafftelno.Location = new System.Drawing.Point(4, 282);
            this.stafftelno.Name = "stafftelno";
            this.stafftelno.Size = new System.Drawing.Size(131, 25);
            this.stafftelno.TabIndex = 16;
            this.stafftelno.Text = "Staff Tel No";
            // 
            // staffname
            // 
            this.staffname.AutoSize = true;
            this.staffname.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.staffname.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffname.Location = new System.Drawing.Point(3, 232);
            this.staffname.Name = "staffname";
            this.staffname.Size = new System.Drawing.Size(126, 25);
            this.staffname.TabIndex = 15;
            this.staffname.Text = "Staff Name\r\n";
            // 
            // stafftype
            // 
            this.stafftype.AutoSize = true;
            this.stafftype.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.stafftype.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stafftype.Location = new System.Drawing.Point(9, 171);
            this.stafftype.Name = "stafftype";
            this.stafftype.Size = new System.Drawing.Size(115, 25);
            this.stafftype.TabIndex = 14;
            this.stafftype.Text = "Staff Type\r\n";
            // 
            // staffid
            // 
            this.staffid.AutoSize = true;
            this.staffid.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.staffid.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffid.Location = new System.Drawing.Point(9, 107);
            this.staffid.Name = "staffid";
            this.staffid.Size = new System.Drawing.Size(93, 25);
            this.staffid.TabIndex = 13;
            this.staffid.Text = "Staff ID";
            // 
            // staffdetails
            // 
            this.staffdetails.AutoSize = true;
            this.staffdetails.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.staffdetails.Font = new System.Drawing.Font("Stencil", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffdetails.Location = new System.Drawing.Point(282, 20);
            this.staffdetails.Name = "staffdetails";
            this.staffdetails.Size = new System.Drawing.Size(263, 39);
            this.staffdetails.TabIndex = 12;
            this.staffdetails.Text = "Staff Details";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::PollypipeDB.Properties.Resources._37114;
            this.pictureBox4.Location = new System.Drawing.Point(22, 428);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(111, 107);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 50;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PollypipeDB.Properties.Resources.settings5_116147;
            this.pictureBox3.Location = new System.Drawing.Point(22, 287);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(111, 107);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 49;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::PollypipeDB.Properties.Resources.Customer_PNG_Photos;
            this.pictureBox5.Location = new System.Drawing.Point(22, 163);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(111, 107);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 48;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::PollypipeDB.Properties.Resources.staff;
            this.pictureBox6.Location = new System.Drawing.Point(22, 34);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(111, 111);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 47;
            this.pictureBox6.TabStop = false;
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.Red;
            this.close.Location = new System.Drawing.Point(1153, 9);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(31, 29);
            this.close.TabIndex = 52;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "staff id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "staff type";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "staff name";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "staff tel no";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1196, 675);
            this.Controls.Add(this.close);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.btninstallation);
            this.Controls.Add(this.btnequipements);
            this.Controls.Add(this.btncustomer);
            this.Controls.Add(this.btnstaff);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "staff";
            this.Load += new System.EventHandler(this.staff_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffdgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button btninstallation;
        private System.Windows.Forms.Button btnequipements;
        private System.Windows.Forms.Button btncustomer;
        private System.Windows.Forms.Button btnstaff;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView staffdgv;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.TextBox txtstafftelno;
        private System.Windows.Forms.TextBox txtstaffname;
        private System.Windows.Forms.TextBox txtstaffid;
        private System.Windows.Forms.Label stafftelno;
        private System.Windows.Forms.Label staffname;
        private System.Windows.Forms.Label stafftype;
        private System.Windows.Forms.Label staffid;
        private System.Windows.Forms.Label staffdetails;
        private System.Windows.Forms.ComboBox stafftypecb;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}