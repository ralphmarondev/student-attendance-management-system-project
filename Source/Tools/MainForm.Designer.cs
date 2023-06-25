namespace StudentAttendanceManagementSystem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.gb_login = new System.Windows.Forms.GroupBox();
            this.Show = new System.Windows.Forms.Button();
            this.Hide = new System.Windows.Forms.Button();
            this.btn_login_as_guest = new System.Windows.Forms.Button();
            this.link_lbl_forgot_password = new System.Windows.Forms.LinkLabel();
            this.lbl_password = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gb_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_login
            // 
            this.gb_login.BackColor = System.Drawing.Color.Transparent;
            this.gb_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gb_login.BackgroundImage")));
            this.gb_login.Controls.Add(this.Show);
            this.gb_login.Controls.Add(this.Hide);
            this.gb_login.Controls.Add(this.btn_login_as_guest);
            this.gb_login.Controls.Add(this.link_lbl_forgot_password);
            this.gb_login.Controls.Add(this.lbl_password);
            this.gb_login.Controls.Add(this.tb_password);
            this.gb_login.Controls.Add(this.lbl_username);
            this.gb_login.Controls.Add(this.tb_username);
            this.gb_login.Controls.Add(this.btn_login);
            this.gb_login.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_login.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.gb_login.Location = new System.Drawing.Point(354, 139);
            this.gb_login.Name = "gb_login";
            this.gb_login.Size = new System.Drawing.Size(431, 379);
            this.gb_login.TabIndex = 2;
            this.gb_login.TabStop = false;
            // 
            // Show
            // 
            this.Show.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Show.Image = ((System.Drawing.Image)(resources.GetObject("Show.Image")));
            this.Show.Location = new System.Drawing.Point(375, 174);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(28, 26);
            this.Show.TabIndex = 7;
            this.Show.UseVisualStyleBackColor = false;
            this.Show.Click += new System.EventHandler(this.button2_Click);
            // 
            // Hide
            // 
            this.Hide.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Hide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Hide.ForeColor = System.Drawing.Color.Transparent;
            this.Hide.Image = ((System.Drawing.Image)(resources.GetObject("Hide.Image")));
            this.Hide.Location = new System.Drawing.Point(375, 174);
            this.Hide.Name = "Hide";
            this.Hide.Size = new System.Drawing.Size(28, 26);
            this.Hide.TabIndex = 8;
            this.Hide.UseVisualStyleBackColor = false;
            this.Hide.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_login_as_guest
            // 
            this.btn_login_as_guest.BackColor = System.Drawing.Color.White;
            this.btn_login_as_guest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login_as_guest.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login_as_guest.Location = new System.Drawing.Point(30, 327);
            this.btn_login_as_guest.Name = "btn_login_as_guest";
            this.btn_login_as_guest.Size = new System.Drawing.Size(122, 29);
            this.btn_login_as_guest.TabIndex = 3;
            this.btn_login_as_guest.Text = "Login as Guest";
            this.btn_login_as_guest.UseVisualStyleBackColor = false;
            this.btn_login_as_guest.Click += new System.EventHandler(this.btn_login_as_guest_Click);
            // 
            // link_lbl_forgot_password
            // 
            this.link_lbl_forgot_password.AutoSize = true;
            this.link_lbl_forgot_password.Cursor = System.Windows.Forms.Cursors.Hand;
            this.link_lbl_forgot_password.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_lbl_forgot_password.Location = new System.Drawing.Point(284, 203);
            this.link_lbl_forgot_password.Name = "link_lbl_forgot_password";
            this.link_lbl_forgot_password.Size = new System.Drawing.Size(152, 17);
            this.link_lbl_forgot_password.TabIndex = 5;
            this.link_lbl_forgot_password.TabStop = true;
            this.link_lbl_forgot_password.Text = "Forgot Password?";
            this.link_lbl_forgot_password.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_lbl_forgot_password_LinkClicked);
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(26, 149);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(118, 23);
            this.lbl_password.TabIndex = 3;
            this.lbl_password.Text = "Password:";
            // 
            // tb_password
            // 
            this.tb_password.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_password.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(30, 174);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(373, 30);
            this.tb_password.TabIndex = 4;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(26, 57);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(118, 23);
            this.lbl_username.TabIndex = 1;
            this.lbl_username.Text = "Username:";
            // 
            // tb_username
            // 
            this.tb_username.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_username.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.Location = new System.Drawing.Point(30, 82);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(374, 30);
            this.tb_username.TabIndex = 2;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(122, 221);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(187, 38);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "LOGIN";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            this.btn_login.MouseEnter += new System.EventHandler(this.btn_login_MouseEnter);
            this.btn_login.MouseLeave += new System.EventHandler(this.btn_login_MouseLeave);
            this.btn_login.MouseHover += new System.EventHandler(this.btn_login_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(838, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 249);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox2.Location = new System.Drawing.Point(-165, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(527, 416);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-86, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(467, 191);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1111, 596);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gb_login);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gb_login.ResumeLayout(false);
            this.gb_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_login;
        private System.Windows.Forms.LinkLabel link_lbl_forgot_password;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_login_as_guest;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Show;
        private System.Windows.Forms.Button Hide;
    }
}

