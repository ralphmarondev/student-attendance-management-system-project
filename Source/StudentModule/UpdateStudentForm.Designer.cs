namespace StudentAttendanceManagementSystem.StudentModule
{
    partial class UpdateStudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateStudentForm));
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cb_class = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_school_year = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cb_semester = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cb_department = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_college = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.tb_last_name = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_name_of_guardian = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_id_number = new System.Windows.Forms.TextBox();
            this.tb_contact_number = new System.Windows.Forms.TextBox();
            this.tb_first_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "College:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(237)))));
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.cb_class);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.cb_school_year);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.cb_semester);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.cb_department);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cb_college);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(830, 161);
            this.panel2.TabIndex = 6;
            // 
            // cb_class
            // 
            this.cb_class.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cb_class.FormattingEnabled = true;
            this.cb_class.Items.AddRange(new object[] {
            "test123"});
            this.cb_class.Location = new System.Drawing.Point(452, 41);
            this.cb_class.Name = "cb_class";
            this.cb_class.Size = new System.Drawing.Size(158, 28);
            this.cb_class.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(448, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 22);
            this.label8.TabIndex = 22;
            this.label8.Text = "Class:";
            // 
            // cb_school_year
            // 
            this.cb_school_year.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cb_school_year.FormattingEnabled = true;
            this.cb_school_year.Items.AddRange(new object[] {
            "2022-2023",
            "2023-2024",
            "2024-2025",
            "2025-2026",
            "2026-2027",
            "2027-2028",
            "2028-2029"});
            this.cb_school_year.Location = new System.Drawing.Point(258, 113);
            this.cb_school_year.Name = "cb_school_year";
            this.cb_school_year.Size = new System.Drawing.Size(158, 28);
            this.cb_school_year.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(254, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 22);
            this.label12.TabIndex = 18;
            this.label12.Text = "School Year:";
            // 
            // cb_semester
            // 
            this.cb_semester.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cb_semester.FormattingEnabled = true;
            this.cb_semester.Items.AddRange(new object[] {
            "FIRST SEMESTER",
            "SECOND SEMESTER"});
            this.cb_semester.Location = new System.Drawing.Point(44, 113);
            this.cb_semester.Name = "cb_semester";
            this.cb_semester.Size = new System.Drawing.Size(158, 28);
            this.cb_semester.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(40, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 22);
            this.label11.TabIndex = 16;
            this.label11.Text = "Semester:";
            // 
            // cb_department
            // 
            this.cb_department.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cb_department.FormattingEnabled = true;
            this.cb_department.Items.AddRange(new object[] {
            "BSCPE",
            "BSCE",
            "BSEE",
            "BSCHEM"});
            this.cb_department.Location = new System.Drawing.Point(256, 41);
            this.cb_department.Name = "cb_department";
            this.cb_department.Size = new System.Drawing.Size(158, 28);
            this.cb_department.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "Department:";
            // 
            // cb_college
            // 
            this.cb_college.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cb_college.FormattingEnabled = true;
            this.cb_college.Items.AddRange(new object[] {
            "COEA",
            "CPAD",
            "CAS",
            "CHK"});
            this.cb_college.Location = new System.Drawing.Point(43, 41);
            this.cb_college.Name = "cb_college";
            this.cb_college.Size = new System.Drawing.Size(158, 28);
            this.cb_college.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.tb_last_name);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lbl_email);
            this.groupBox1.Controls.Add(this.tb_email);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tb_name_of_guardian);
            this.groupBox1.Controls.Add(this.btn_update);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_id_number);
            this.groupBox1.Controls.Add(this.tb_contact_number);
            this.groupBox1.Controls.Add(this.tb_first_name);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_address);
            this.groupBox1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(58, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(724, 405);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Information:";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Transparent;
            this.btn_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_search.BackgroundImage")));
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.Location = new System.Drawing.Point(233, 58);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(99, 29);
            this.btn_search.TabIndex = 23;
            this.btn_search.Text = "SEARCH";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // tb_last_name
            // 
            this.tb_last_name.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_last_name.Location = new System.Drawing.Point(49, 199);
            this.tb_last_name.Name = "tb_last_name";
            this.tb_last_name.Size = new System.Drawing.Size(283, 30);
            this.tb_last_name.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(45, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 23);
            this.label9.TabIndex = 15;
            this.label9.Text = "Last Name:";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.BackColor = System.Drawing.Color.Transparent;
            this.lbl_email.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(361, 108);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(82, 23);
            this.lbl_email.TabIndex = 13;
            this.lbl_email.Text = "Email:";
            // 
            // tb_email
            // 
            this.tb_email.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_email.Location = new System.Drawing.Point(365, 131);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(283, 30);
            this.tb_email.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(361, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Name of Guardian:";
            // 
            // tb_name_of_guardian
            // 
            this.tb_name_of_guardian.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_name_of_guardian.Location = new System.Drawing.Point(365, 264);
            this.tb_name_of_guardian.Name = "tb_name_of_guardian";
            this.tb_name_of_guardian.Size = new System.Drawing.Size(283, 30);
            this.tb_name_of_guardian.TabIndex = 10;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Transparent;
            this.btn_update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_update.BackgroundImage")));
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(51, 338);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(597, 43);
            this.btn_update.TabIndex = 9;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_finish_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(361, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "Contact Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID Number:";
            // 
            // tb_id_number
            // 
            this.tb_id_number.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_id_number.Location = new System.Drawing.Point(49, 60);
            this.tb_id_number.Name = "tb_id_number";
            this.tb_id_number.Size = new System.Drawing.Size(177, 30);
            this.tb_id_number.TabIndex = 1;
            // 
            // tb_contact_number
            // 
            this.tb_contact_number.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_contact_number.Location = new System.Drawing.Point(365, 196);
            this.tb_contact_number.Name = "tb_contact_number";
            this.tb_contact_number.Size = new System.Drawing.Size(283, 30);
            this.tb_contact_number.TabIndex = 7;
            // 
            // tb_first_name
            // 
            this.tb_first_name.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_first_name.Location = new System.Drawing.Point(49, 131);
            this.tb_first_name.Name = "tb_first_name";
            this.tb_first_name.Size = new System.Drawing.Size(283, 30);
            this.tb_first_name.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Address:";
            // 
            // tb_address
            // 
            this.tb_address.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_address.Location = new System.Drawing.Point(49, 265);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(283, 30);
            this.tb_address.TabIndex = 5;
            // 
            // UpdateStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(227)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(830, 631);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UpdateStudentForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateStudentForm";
            this.Load += new System.EventHandler(this.UpdateStudentForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cb_school_year;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cb_semester;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cb_department;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_college;
        private System.Windows.Forms.ComboBox cb_class;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_last_name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_name_of_guardian;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_id_number;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_contact_number;
        private System.Windows.Forms.TextBox tb_first_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_search;
    }
}