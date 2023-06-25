namespace StudentAttendanceManagementSystem.DashBoardModule
{
    partial class DashBoardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoardForm));
            this.btn_class_form = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_reports = new System.Windows.Forms.Button();
            this.btn_users = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_attendance_form = new System.Windows.Forms.Button();
            this.btn_student_form = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_username = new System.Windows.Forms.Label();
            this.panel_top_three_classes = new System.Windows.Forms.Panel();
            this.panel_for_notifications = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_class_form
            // 
            this.btn_class_form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_class_form.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_class_form.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_class_form.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_class_form.Location = new System.Drawing.Point(13, 259);
            this.btn_class_form.Margin = new System.Windows.Forms.Padding(4);
            this.btn_class_form.Name = "btn_class_form";
            this.btn_class_form.Size = new System.Drawing.Size(210, 46);
            this.btn_class_form.TabIndex = 0;
            this.btn_class_form.Text = "CLASS";
            this.btn_class_form.UseVisualStyleBackColor = false;
            this.btn_class_form.Click += new System.EventHandler(this.btn_class_form_Click);
            this.btn_class_form.MouseEnter += new System.EventHandler(this.btn_class_form_MouseEnter);
            this.btn_class_form.MouseLeave += new System.EventHandler(this.btn_class_form_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btn_reports);
            this.panel1.Controls.Add(this.btn_users);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_attendance_form);
            this.panel1.Controls.Add(this.btn_student_form);
            this.panel1.Controls.Add(this.btn_class_form);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 626);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(215, 138);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btn_reports
            // 
            this.btn_reports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_reports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reports.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reports.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_reports.Location = new System.Drawing.Point(13, 313);
            this.btn_reports.Margin = new System.Windows.Forms.Padding(4);
            this.btn_reports.Name = "btn_reports";
            this.btn_reports.Size = new System.Drawing.Size(210, 46);
            this.btn_reports.TabIndex = 5;
            this.btn_reports.Text = "REPORTS";
            this.btn_reports.UseVisualStyleBackColor = false;
            this.btn_reports.Click += new System.EventHandler(this.btn_reports_Click);
            this.btn_reports.MouseEnter += new System.EventHandler(this.btn_reports_MouseEnter);
            this.btn_reports.MouseLeave += new System.EventHandler(this.btn_reports_MouseLeave);
            // 
            // btn_users
            // 
            this.btn_users.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_users.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_users.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_users.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_users.Location = new System.Drawing.Point(13, 367);
            this.btn_users.Margin = new System.Windows.Forms.Padding(4);
            this.btn_users.Name = "btn_users";
            this.btn_users.Size = new System.Drawing.Size(210, 46);
            this.btn_users.TabIndex = 4;
            this.btn_users.Text = "USERS";
            this.btn_users.UseVisualStyleBackColor = false;
            this.btn_users.Click += new System.EventHandler(this.btn_users_Click);
            this.btn_users.MouseEnter += new System.EventHandler(this.btn_users_MouseEnter);
            this.btn_users.MouseLeave += new System.EventHandler(this.btn_users_MouseLeave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Courier New", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(13, 567);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "LOGOUT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // btn_attendance_form
            // 
            this.btn_attendance_form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_attendance_form.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_attendance_form.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_attendance_form.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_attendance_form.Location = new System.Drawing.Point(13, 151);
            this.btn_attendance_form.Margin = new System.Windows.Forms.Padding(4);
            this.btn_attendance_form.Name = "btn_attendance_form";
            this.btn_attendance_form.Size = new System.Drawing.Size(210, 46);
            this.btn_attendance_form.TabIndex = 2;
            this.btn_attendance_form.Text = "ATTENDANCE";
            this.btn_attendance_form.UseVisualStyleBackColor = false;
            this.btn_attendance_form.Click += new System.EventHandler(this.btn_attendance_form_Click);
            this.btn_attendance_form.MouseEnter += new System.EventHandler(this.btn_attendance_form_MouseEnter);
            this.btn_attendance_form.MouseLeave += new System.EventHandler(this.btn_attendance_form_MouseLeave);
            // 
            // btn_student_form
            // 
            this.btn_student_form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_student_form.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_student_form.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_student_form.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_student_form.Location = new System.Drawing.Point(13, 205);
            this.btn_student_form.Margin = new System.Windows.Forms.Padding(4);
            this.btn_student_form.Name = "btn_student_form";
            this.btn_student_form.Size = new System.Drawing.Size(210, 46);
            this.btn_student_form.TabIndex = 1;
            this.btn_student_form.Text = "STUDENTS";
            this.btn_student_form.UseVisualStyleBackColor = false;
            this.btn_student_form.Click += new System.EventHandler(this.btn_student_form_Click);
            this.btn_student_form.MouseEnter += new System.EventHandler(this.btn_student_form_MouseEnter);
            this.btn_student_form.MouseLeave += new System.EventHandler(this.btn_student_form_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.lbl_username);
            this.panel2.Location = new System.Drawing.Point(234, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(887, 51);
            this.panel2.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Location = new System.Drawing.Point(614, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(261, 27);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.BackColor = System.Drawing.Color.Transparent;
            this.lbl_username.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_username.Location = new System.Drawing.Point(8, 12);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(278, 27);
            this.lbl_username.TabIndex = 0;
            this.lbl_username.Text = "USER: ADMINISTRATOR";
            this.lbl_username.Click += new System.EventHandler(this.lbl_username_Click);
            this.lbl_username.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            // 
            // panel_top_three_classes
            // 
            this.panel_top_three_classes.AutoScroll = true;
            this.panel_top_three_classes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel_top_three_classes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_top_three_classes.BackgroundImage")));
            this.panel_top_three_classes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_top_three_classes.Location = new System.Drawing.Point(234, 50);
            this.panel_top_three_classes.Margin = new System.Windows.Forms.Padding(10);
            this.panel_top_three_classes.Name = "panel_top_three_classes";
            this.panel_top_three_classes.Size = new System.Drawing.Size(887, 39);
            this.panel_top_three_classes.TabIndex = 9;
            this.panel_top_three_classes.Visible = false;
            this.panel_top_three_classes.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_top_three_classes_Paint);
            // 
            // panel_for_notifications
            // 
            this.panel_for_notifications.AutoScroll = true;
            this.panel_for_notifications.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_for_notifications.Location = new System.Drawing.Point(234, 89);
            this.panel_for_notifications.Name = "panel_for_notifications";
            this.panel_for_notifications.Size = new System.Drawing.Size(887, 537);
            this.panel_for_notifications.TabIndex = 8;
            // 
            // DashBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 626);
            this.Controls.Add(this.panel_top_three_classes);
            this.Controls.Add(this.panel_for_notifications);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DashBoardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoardForm";
            this.Load += new System.EventHandler(this.DashBoardForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_class_form;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_attendance_form;
        private System.Windows.Forms.Button btn_student_form;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Button btn_reports;
        private System.Windows.Forms.Button btn_users;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel_top_three_classes;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel_for_notifications;
    }
}