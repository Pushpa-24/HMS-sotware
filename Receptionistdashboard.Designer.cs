namespace GuestEaseHMS
{
    partial class Receptionistdashboard
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
            System.Windows.Forms.PictureBox pictureBox4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receptionistdashboard));
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.custdetailsbtn = new System.Windows.Forms.Button();
            this.custregisterbtn = new System.Windows.Forms.Button();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.billingbtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.reservationdetbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = System.Drawing.Color.White;
            pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            pictureBox4.Location = new System.Drawing.Point(128, 49);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(43, 37);
            pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 17;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(458, 49);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(43, 37);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 18;
            this.pictureBox5.TabStop = false;
            // 
            // custdetailsbtn
            // 
            this.custdetailsbtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.custdetailsbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.custdetailsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.custdetailsbtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custdetailsbtn.ForeColor = System.Drawing.Color.Black;
            this.custdetailsbtn.Location = new System.Drawing.Point(497, 51);
            this.custdetailsbtn.Name = "custdetailsbtn";
            this.custdetailsbtn.Size = new System.Drawing.Size(233, 37);
            this.custdetailsbtn.TabIndex = 16;
            this.custdetailsbtn.Text = "Customer Details";
            this.custdetailsbtn.UseMnemonic = false;
            this.custdetailsbtn.UseVisualStyleBackColor = false;
            this.custdetailsbtn.Click += new System.EventHandler(this.custdetailsbtn_Click);
            // 
            // custregisterbtn
            // 
            this.custregisterbtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.custregisterbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.custregisterbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.custregisterbtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custregisterbtn.ForeColor = System.Drawing.Color.Black;
            this.custregisterbtn.Location = new System.Drawing.Point(168, 49);
            this.custregisterbtn.Name = "custregisterbtn";
            this.custregisterbtn.Size = new System.Drawing.Size(253, 37);
            this.custregisterbtn.TabIndex = 11;
            this.custregisterbtn.Text = "Customer Registration";
            this.custregisterbtn.UseMnemonic = false;
            this.custregisterbtn.UseVisualStyleBackColor = false;
            this.custregisterbtn.Click += new System.EventHandler(this.registerbtn_Click);
            // 
            // logoutbtn
            // 
            this.logoutbtn.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.logoutbtn.ForeColor = System.Drawing.Color.Red;
            this.logoutbtn.Location = new System.Drawing.Point(1146, 646);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(116, 42);
            this.logoutbtn.TabIndex = 15;
            this.logoutbtn.Text = "Log Out";
            this.logoutbtn.UseVisualStyleBackColor = true;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Controls.Add(this.custregisterbtn);
            this.panel3.Controls.Add(this.pictureBox6);
            this.panel3.Controls.Add(this.billingbtn);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.reservationdetbtn);
            this.panel3.Controls.Add(this.pictureBox5);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.custdetailsbtn);
            this.panel3.Controls.Add(pictureBox4);
            this.panel3.Location = new System.Drawing.Point(29, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1248, 115);
            this.panel3.TabIndex = 12;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(1064, 51);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(43, 37);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 22;
            this.pictureBox6.TabStop = false;
            // 
            // billingbtn
            // 
            this.billingbtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.billingbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.billingbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.billingbtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billingbtn.ForeColor = System.Drawing.Color.Black;
            this.billingbtn.Location = new System.Drawing.Point(1104, 51);
            this.billingbtn.Name = "billingbtn";
            this.billingbtn.Size = new System.Drawing.Size(129, 39);
            this.billingbtn.TabIndex = 21;
            this.billingbtn.Text = "Checkout";
            this.billingbtn.UseMnemonic = false;
            this.billingbtn.UseVisualStyleBackColor = false;
            this.billingbtn.Click += new System.EventHandler(this.billingbtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(758, 49);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // reservationdetbtn
            // 
            this.reservationdetbtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.reservationdetbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reservationdetbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reservationdetbtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationdetbtn.ForeColor = System.Drawing.Color.Black;
            this.reservationdetbtn.Location = new System.Drawing.Point(798, 50);
            this.reservationdetbtn.Name = "reservationdetbtn";
            this.reservationdetbtn.Size = new System.Drawing.Size(248, 37);
            this.reservationdetbtn.TabIndex = 19;
            this.reservationdetbtn.Text = "Reservation Details";
            this.reservationdetbtn.UseMnemonic = false;
            this.reservationdetbtn.UseVisualStyleBackColor = false;
            this.reservationdetbtn.Click += new System.EventHandler(this.reservationdetbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 98);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Black;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Location = new System.Drawing.Point(26, 637);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(1248, 53);
            this.pictureBox7.TabIndex = 16;
            this.pictureBox7.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(26, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1248, 514);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Receptionistdashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1321, 726);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.logoutbtn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox7);
            this.Name = "Receptionistdashboard";
            this.Text = "Receptionistdashboard";
            ((System.ComponentModel.ISupportInitialize)(pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button custdetailsbtn;
        private System.Windows.Forms.Button custregisterbtn;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button billingbtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button reservationdetbtn;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Panel panel1;
    }
}