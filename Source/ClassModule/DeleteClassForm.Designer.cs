namespace StudentAttendanceManagementSystem.ClassModule
{
    partial class DeleteClassForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteClassForm));
            this.gb_add_class = new System.Windows.Forms.GroupBox();
            this.btn_finish_add = new System.Windows.Forms.Button();
            this.tb_subject_name_add = new System.Windows.Forms.TextBox();
            this.lbl_subject_name_add = new System.Windows.Forms.Label();
            this.tb_subject_code_delete = new System.Windows.Forms.TextBox();
            this.lbl_subject_code_add = new System.Windows.Forms.Label();
            this.gb_add_class.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_add_class
            // 
            this.gb_add_class.BackColor = System.Drawing.Color.LightCyan;
            this.gb_add_class.Controls.Add(this.btn_finish_add);
            this.gb_add_class.Controls.Add(this.tb_subject_name_add);
            this.gb_add_class.Controls.Add(this.lbl_subject_name_add);
            this.gb_add_class.Controls.Add(this.tb_subject_code_delete);
            this.gb_add_class.Controls.Add(this.lbl_subject_code_add);
            this.gb_add_class.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_add_class.Location = new System.Drawing.Point(0, 0);
            this.gb_add_class.Name = "gb_add_class";
            this.gb_add_class.Size = new System.Drawing.Size(401, 292);
            this.gb_add_class.TabIndex = 3;
            this.gb_add_class.TabStop = false;
            this.gb_add_class.Enter += new System.EventHandler(this.gb_add_class_Enter);
            // 
            // btn_finish_add
            // 
            this.btn_finish_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_finish_add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_finish_add.BackgroundImage")));
            this.btn_finish_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_finish_add.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_finish_add.ForeColor = System.Drawing.Color.Black;
            this.btn_finish_add.Location = new System.Drawing.Point(24, 217);
            this.btn_finish_add.Name = "btn_finish_add";
            this.btn_finish_add.Size = new System.Drawing.Size(357, 52);
            this.btn_finish_add.TabIndex = 8;
            this.btn_finish_add.Text = "DELETE";
            this.btn_finish_add.UseVisualStyleBackColor = false;
            this.btn_finish_add.Click += new System.EventHandler(this.btn_finish_add_Click);
            // 
            // tb_subject_name_add
            // 
            this.tb_subject_name_add.Font = new System.Drawing.Font("Courier New", 12F);
            this.tb_subject_name_add.Location = new System.Drawing.Point(25, 157);
            this.tb_subject_name_add.Name = "tb_subject_name_add";
            this.tb_subject_name_add.Size = new System.Drawing.Size(357, 30);
            this.tb_subject_name_add.TabIndex = 3;
            // 
            // lbl_subject_name_add
            // 
            this.lbl_subject_name_add.AutoSize = true;
            this.lbl_subject_name_add.Font = new System.Drawing.Font("Courier New", 9F);
            this.lbl_subject_name_add.Location = new System.Drawing.Point(21, 125);
            this.lbl_subject_name_add.Name = "lbl_subject_name_add";
            this.lbl_subject_name_add.Size = new System.Drawing.Size(125, 17);
            this.lbl_subject_name_add.TabIndex = 2;
            this.lbl_subject_name_add.Text = "Subject Name:";
            // 
            // tb_subject_code_delete
            // 
            this.tb_subject_code_delete.Font = new System.Drawing.Font("Courier New", 12F);
            this.tb_subject_code_delete.Location = new System.Drawing.Point(25, 71);
            this.tb_subject_code_delete.Name = "tb_subject_code_delete";
            this.tb_subject_code_delete.Size = new System.Drawing.Size(357, 30);
            this.tb_subject_code_delete.TabIndex = 1;
            // 
            // lbl_subject_code_add
            // 
            this.lbl_subject_code_add.AutoSize = true;
            this.lbl_subject_code_add.Font = new System.Drawing.Font("Courier New", 9F);
            this.lbl_subject_code_add.Location = new System.Drawing.Point(21, 39);
            this.lbl_subject_code_add.Name = "lbl_subject_code_add";
            this.lbl_subject_code_add.Size = new System.Drawing.Size(125, 17);
            this.lbl_subject_code_add.TabIndex = 0;
            this.lbl_subject_code_add.Text = "Subject Code:";
            // 
            // DeleteClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 292);
            this.Controls.Add(this.gb_add_class);
            this.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DeleteClassForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteClassForm";
            this.gb_add_class.ResumeLayout(false);
            this.gb_add_class.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_add_class;
        private System.Windows.Forms.Button btn_finish_add;
        private System.Windows.Forms.TextBox tb_subject_name_add;
        private System.Windows.Forms.Label lbl_subject_name_add;
        private System.Windows.Forms.TextBox tb_subject_code_delete;
        private System.Windows.Forms.Label lbl_subject_code_add;
    }
}