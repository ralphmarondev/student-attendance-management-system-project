namespace StudentAttendanceManagementSystem
{
    partial class AttendanceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendanceForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_default_column = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_default_row = new System.Windows.Forms.ComboBox();
            this.cb_date = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_class = new System.Windows.Forms.ComboBox();
            this.lbl_class = new System.Windows.Forms.Label();
            this.cb_school_year = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cb_semester = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cb_department = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_college = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttons_panel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_present = new System.Windows.Forms.Button();
            this.btn_view = new System.Windows.Forms.Button();
            this.dgv_classes_lists = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_classes_lists)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(237)))));
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.cb_date);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cb_class);
            this.panel2.Controls.Add(this.lbl_class);
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
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1261, 179);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cb_default_column);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cb_default_row);
            this.groupBox1.Location = new System.Drawing.Point(935, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 133);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DEFAULTS:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 9F);
            this.label4.Location = new System.Drawing.Point(163, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "COLUMN:";
            // 
            // cb_default_column
            // 
            this.cb_default_column.FormattingEnabled = true;
            this.cb_default_column.Location = new System.Drawing.Point(166, 58);
            this.cb_default_column.Name = "cb_default_column";
            this.cb_default_column.Size = new System.Drawing.Size(121, 28);
            this.cb_default_column.TabIndex = 16;
            this.cb_default_column.Text = "8";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 9F);
            this.label3.Location = new System.Drawing.Point(23, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "ROW:";
            // 
            // cb_default_row
            // 
            this.cb_default_row.FormattingEnabled = true;
            this.cb_default_row.Location = new System.Drawing.Point(26, 58);
            this.cb_default_row.Name = "cb_default_row";
            this.cb_default_row.Size = new System.Drawing.Size(121, 28);
            this.cb_default_row.TabIndex = 14;
            this.cb_default_row.Text = "8";
            // 
            // cb_date
            // 
            this.cb_date.FormattingEnabled = true;
            this.cb_date.Items.AddRange(new object[] {
            "test123"});
            this.cb_date.Location = new System.Drawing.Point(694, 11);
            this.cb_date.Margin = new System.Windows.Forms.Padding(4);
            this.cb_date.Name = "cb_date";
            this.cb_date.Size = new System.Drawing.Size(196, 28);
            this.cb_date.TabIndex = 24;
            this.cb_date.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(596, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Date:";
            // 
            // cb_class
            // 
            this.cb_class.FormattingEnabled = true;
            this.cb_class.Items.AddRange(new object[] {
            "test123"});
            this.cb_class.Location = new System.Drawing.Point(601, 51);
            this.cb_class.Margin = new System.Windows.Forms.Padding(4);
            this.cb_class.Name = "cb_class";
            this.cb_class.Size = new System.Drawing.Size(196, 28);
            this.cb_class.TabIndex = 19;
            // 
            // lbl_class
            // 
            this.lbl_class.AutoSize = true;
            this.lbl_class.BackColor = System.Drawing.Color.Transparent;
            this.lbl_class.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_class.Location = new System.Drawing.Point(596, 22);
            this.lbl_class.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_class.Name = "lbl_class";
            this.lbl_class.Size = new System.Drawing.Size(62, 17);
            this.lbl_class.TabIndex = 20;
            this.lbl_class.Text = "Class:";
            // 
            // cb_school_year
            // 
            this.cb_school_year.FormattingEnabled = true;
            this.cb_school_year.Items.AddRange(new object[] {
            "2022-2023",
            "2023-2024",
            "2024-2025",
            "2025-2026",
            "2026-2027",
            "2027-2028",
            "2028-2029"});
            this.cb_school_year.Location = new System.Drawing.Point(322, 121);
            this.cb_school_year.Margin = new System.Windows.Forms.Padding(4);
            this.cb_school_year.Name = "cb_school_year";
            this.cb_school_year.Size = new System.Drawing.Size(196, 28);
            this.cb_school_year.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(318, 92);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 17);
            this.label12.TabIndex = 18;
            this.label12.Text = "School Year:";
            // 
            // cb_semester
            // 
            this.cb_semester.FormattingEnabled = true;
            this.cb_semester.Items.AddRange(new object[] {
            "FIRST SEMESTER",
            "SECOND SEMESTER"});
            this.cb_semester.Location = new System.Drawing.Point(55, 121);
            this.cb_semester.Margin = new System.Windows.Forms.Padding(4);
            this.cb_semester.Name = "cb_semester";
            this.cb_semester.Size = new System.Drawing.Size(196, 28);
            this.cb_semester.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(50, 92);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 17);
            this.label11.TabIndex = 16;
            this.label11.Text = "Semester:";
            // 
            // cb_department
            // 
            this.cb_department.FormattingEnabled = true;
            this.cb_department.Items.AddRange(new object[] {
            "BSCPE",
            "BSCE",
            "BSEE",
            "BSCHEM"});
            this.cb_department.Location = new System.Drawing.Point(320, 51);
            this.cb_department.Margin = new System.Windows.Forms.Padding(4);
            this.cb_department.Name = "cb_department";
            this.cb_department.Size = new System.Drawing.Size(196, 28);
            this.cb_department.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Department:";
            // 
            // cb_college
            // 
            this.cb_college.FormattingEnabled = true;
            this.cb_college.Items.AddRange(new object[] {
            "COEA",
            "CPAD",
            "CAS",
            "CHK"});
            this.cb_college.Location = new System.Drawing.Point(54, 51);
            this.cb_college.Margin = new System.Windows.Forms.Padding(4);
            this.cb_college.Name = "cb_college";
            this.cb_college.Size = new System.Drawing.Size(196, 28);
            this.cb_college.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "College:";
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.Transparent;
            this.btn_refresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_refresh.BackgroundImage")));
            this.btn_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.Location = new System.Drawing.Point(648, 15);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(153, 48);
            this.btn_refresh.TabIndex = 21;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttons_panel);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.dgv_classes_lists);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 178);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1261, 502);
            this.panel1.TabIndex = 4;
            // 
            // buttons_panel
            // 
            this.buttons_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(249)))));
            this.buttons_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttons_panel.Location = new System.Drawing.Point(0, 0);
            this.buttons_panel.Name = "buttons_panel";
            this.buttons_panel.Size = new System.Drawing.Size(1261, 417);
            this.buttons_panel.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(237)))));
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Controls.Add(this.btn_back);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.btn_refresh);
            this.panel3.Controls.Add(this.btn_present);
            this.panel3.Controls.Add(this.btn_view);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 417);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1261, 85);
            this.panel3.TabIndex = 3;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_back.BackgroundImage")));
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(1087, 15);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(153, 48);
            this.btn_back.TabIndex = 6;
            this.btn_back.Text = "BACK";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(330, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 48);
            this.button1.TabIndex = 5;
            this.button1.Text = "UPDATE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(489, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 48);
            this.button2.TabIndex = 4;
            this.button2.Text = "DELETE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_present
            // 
            this.btn_present.BackColor = System.Drawing.Color.Transparent;
            this.btn_present.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_present.BackgroundImage")));
            this.btn_present.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_present.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_present.Location = new System.Drawing.Point(12, 15);
            this.btn_present.Name = "btn_present";
            this.btn_present.Size = new System.Drawing.Size(153, 48);
            this.btn_present.TabIndex = 3;
            this.btn_present.Text = "FINISH";
            this.btn_present.UseVisualStyleBackColor = false;
            this.btn_present.Click += new System.EventHandler(this.btn_present_Click);
            // 
            // btn_view
            // 
            this.btn_view.BackColor = System.Drawing.Color.Transparent;
            this.btn_view.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_view.BackgroundImage")));
            this.btn_view.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view.Location = new System.Drawing.Point(171, 15);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(153, 48);
            this.btn_view.TabIndex = 2;
            this.btn_view.Text = "VIEW";
            this.btn_view.UseVisualStyleBackColor = false;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // dgv_classes_lists
            // 
            this.dgv_classes_lists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_classes_lists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_classes_lists.Location = new System.Drawing.Point(0, 0);
            this.dgv_classes_lists.Name = "dgv_classes_lists";
            this.dgv_classes_lists.RowHeadersWidth = 51;
            this.dgv_classes_lists.RowTemplate.Height = 24;
            this.dgv_classes_lists.Size = new System.Drawing.Size(1261, 502);
            this.dgv_classes_lists.TabIndex = 1;
            this.dgv_classes_lists.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(601, 121);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(286, 27);
            this.dateTimePicker1.TabIndex = 27;
            // 
            // AttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 680);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AttendanceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AttendanceForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AttendanceForm_FormClosed);
            this.Load += new System.EventHandler(this.AttendanceForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_classes_lists)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cb_class;
        private System.Windows.Forms.Label lbl_class;
        private System.Windows.Forms.ComboBox cb_school_year;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cb_semester;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cb_department;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_college;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.DataGridView dgv_classes_lists;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.Button btn_present;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cb_date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel buttons_panel;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_default_column;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_default_row;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}