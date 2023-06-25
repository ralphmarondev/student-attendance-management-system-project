namespace StudentAttendanceManagementSystem.GuestUserModules.GuestReportsModule
{
    partial class GuestReportsForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuestReportsForm));
            this.btn_view_remarks = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_id_number_search = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_view_remarks
            // 
            this.btn_view_remarks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_view_remarks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_view_remarks.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view_remarks.Location = new System.Drawing.Point(449, 638);
            this.btn_view_remarks.Name = "btn_view_remarks";
            this.btn_view_remarks.Size = new System.Drawing.Size(233, 45);
            this.btn_view_remarks.TabIndex = 30;
            this.btn_view_remarks.Text = "VIEW REMARKS";
            this.btn_view_remarks.UseVisualStyleBackColor = false;
            this.btn_view_remarks.Click += new System.EventHandler(this.btn_view_remarks_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_refresh.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.Location = new System.Drawing.Point(31, 638);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(173, 45);
            this.btn_refresh.TabIndex = 27;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(956, 638);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(173, 45);
            this.btn_back.TabIndex = 28;
            this.btn_back.Text = "BACK";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(249)))));
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(31, 196);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1098, 414);
            this.dataGridView1.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(210, 638);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 45);
            this.button1.TabIndex = 29;
            this.button1.Text = "VIEW ATTENDANCE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.btn_search);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tb_id_number_search);
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
            this.panel2.Size = new System.Drawing.Size(1161, 171);
            this.panel2.TabIndex = 26;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Transparent;
            this.btn_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_search.BackgroundImage")));
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(778, 119);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(82, 27);
            this.btn_search.TabIndex = 25;
            this.btn_search.Text = "SEARCH";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(598, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 22);
            this.label2.TabIndex = 24;
            this.label2.Text = "ID Number:";
            // 
            // tb_id_number_search
            // 
            this.tb_id_number_search.Location = new System.Drawing.Point(601, 121);
            this.tb_id_number_search.Name = "tb_id_number_search";
            this.tb_id_number_search.Size = new System.Drawing.Size(171, 27);
            this.tb_id_number_search.TabIndex = 23;
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
            this.lbl_class.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_class.Location = new System.Drawing.Point(596, 22);
            this.lbl_class.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_class.Name = "lbl_class";
            this.lbl_class.Size = new System.Drawing.Size(76, 22);
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
            this.label12.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(318, 92);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 22);
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
            this.label11.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(50, 92);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 22);
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
            this.label1.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 22);
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
            this.label5.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "College:";
            // 
            // GuestReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 700);
            this.Controls.Add(this.btn_view_remarks);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GuestReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuestReportsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GuestReportsForm_FormClosed);
            this.Load += new System.EventHandler(this.GuestReportsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_view_remarks;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_id_number_search;
        private System.Windows.Forms.ComboBox cb_class;
        private System.Windows.Forms.Label lbl_class;
        private System.Windows.Forms.ComboBox cb_school_year;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cb_semester;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cb_department;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_college;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
    }
}