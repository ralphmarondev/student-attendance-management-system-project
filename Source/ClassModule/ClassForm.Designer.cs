namespace StudentAttendanceManagementSystem.ClassModule
{
    partial class ClassForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassForm));
            this.btn_search_class = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_class_code_search = new System.Windows.Forms.Label();
            this.tb_class_code_search = new System.Windows.Forms.TextBox();
            this.btn_add_class = new System.Windows.Forms.Button();
            this.btn_update_class = new System.Windows.Forms.Button();
            this.btn_delete_class = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_show_classes = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_search_class
            // 
            this.btn_search_class.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search_class.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search_class.Location = new System.Drawing.Point(667, 13);
            this.btn_search_class.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search_class.Name = "btn_search_class";
            this.btn_search_class.Size = new System.Drawing.Size(173, 45);
            this.btn_search_class.TabIndex = 9;
            this.btn_search_class.Text = "Search Class";
            this.btn_search_class.UseVisualStyleBackColor = true;
            this.btn_search_class.Click += new System.EventHandler(this.btn_search_class_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(237)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.lbl_class_code_search);
            this.panel1.Controls.Add(this.tb_class_code_search);
            this.panel1.Controls.Add(this.btn_search_class);
            this.panel1.Location = new System.Drawing.Point(265, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 82);
            this.panel1.TabIndex = 22;
            // 
            // lbl_class_code_search
            // 
            this.lbl_class_code_search.AutoSize = true;
            this.lbl_class_code_search.BackColor = System.Drawing.Color.Transparent;
            this.lbl_class_code_search.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_class_code_search.Location = new System.Drawing.Point(476, 13);
            this.lbl_class_code_search.Name = "lbl_class_code_search";
            this.lbl_class_code_search.Size = new System.Drawing.Size(131, 22);
            this.lbl_class_code_search.TabIndex = 11;
            this.lbl_class_code_search.Text = "Class Code:";
            // 
            // tb_class_code_search
            // 
            this.tb_class_code_search.Location = new System.Drawing.Point(480, 31);
            this.tb_class_code_search.Name = "tb_class_code_search";
            this.tb_class_code_search.Size = new System.Drawing.Size(180, 27);
            this.tb_class_code_search.TabIndex = 10;
            this.tb_class_code_search.TextChanged += new System.EventHandler(this.tb_class_code_search_TextChanged);
            // 
            // btn_add_class
            // 
            this.btn_add_class.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_add_class.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_class.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_class.Location = new System.Drawing.Point(22, 22);
            this.btn_add_class.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add_class.Name = "btn_add_class";
            this.btn_add_class.Size = new System.Drawing.Size(226, 45);
            this.btn_add_class.TabIndex = 0;
            this.btn_add_class.Text = "Add Class";
            this.btn_add_class.UseVisualStyleBackColor = false;
            this.btn_add_class.Click += new System.EventHandler(this.btn_add_class_Click);
            // 
            // btn_update_class
            // 
            this.btn_update_class.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_update_class.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update_class.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_class.Location = new System.Drawing.Point(22, 77);
            this.btn_update_class.Margin = new System.Windows.Forms.Padding(4);
            this.btn_update_class.Name = "btn_update_class";
            this.btn_update_class.Size = new System.Drawing.Size(226, 45);
            this.btn_update_class.TabIndex = 7;
            this.btn_update_class.Text = "Update Class";
            this.btn_update_class.UseVisualStyleBackColor = false;
            this.btn_update_class.Click += new System.EventHandler(this.btn_update_class_Click);
            // 
            // btn_delete_class
            // 
            this.btn_delete_class.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_delete_class.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete_class.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_class.Location = new System.Drawing.Point(22, 181);
            this.btn_delete_class.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete_class.Name = "btn_delete_class";
            this.btn_delete_class.Size = new System.Drawing.Size(226, 45);
            this.btn_delete_class.TabIndex = 8;
            this.btn_delete_class.Text = "Delete Class";
            this.btn_delete_class.UseVisualStyleBackColor = false;
            this.btn_delete_class.Click += new System.EventHandler(this.btn_delete_class_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(22, 569);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(226, 45);
            this.btn_back.TabIndex = 9;
            this.btn_back.Text = "BACK";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(227)))), ((int)(((byte)(240)))));
            this.panel3.Controls.Add(this.btn_show_classes);
            this.panel3.Controls.Add(this.btn_back);
            this.panel3.Controls.Add(this.btn_delete_class);
            this.panel3.Controls.Add(this.btn_add_class);
            this.panel3.Controls.Add(this.btn_update_class);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(265, 626);
            this.panel3.TabIndex = 0;
            // 
            // btn_show_classes
            // 
            this.btn_show_classes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_show_classes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_show_classes.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show_classes.Location = new System.Drawing.Point(22, 129);
            this.btn_show_classes.Name = "btn_show_classes";
            this.btn_show_classes.Size = new System.Drawing.Size(226, 45);
            this.btn_show_classes.TabIndex = 10;
            this.btn_show_classes.Text = "REFRESH";
            this.btn_show_classes.UseVisualStyleBackColor = false;
            this.btn_show_classes.Click += new System.EventHandler(this.btn_show_classes_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.flowLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowLayoutPanel1.BackgroundImage")));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(856, 549);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(265, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(856, 549);
            this.panel2.TabIndex = 23;
            // 
            // ClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 626);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ClassForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClassForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClassForm_FormClosed);
            this.Load += new System.EventHandler(this.ClassForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_search_class;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_class_code_search;
        private System.Windows.Forms.Label lbl_class_code_search;
        private System.Windows.Forms.Button btn_add_class;
        private System.Windows.Forms.Button btn_update_class;
        private System.Windows.Forms.Button btn_delete_class;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_show_classes;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
    }
}