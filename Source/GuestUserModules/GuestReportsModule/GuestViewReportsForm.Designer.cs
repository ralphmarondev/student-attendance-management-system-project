namespace StudentAttendanceManagementSystem.GuestUserModules.GuestReportsModule
{
    partial class GuestViewReportsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuestViewReportsForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.cb_class_code = new System.Windows.Forms.ComboBox();
            this.lbl_class_code = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_good = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_drop = new System.Windows.Forms.Button();
            this.btn_warning = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(237)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.btn_refresh);
            this.panel1.Controls.Add(this.cb_class_code);
            this.panel1.Controls.Add(this.lbl_class_code);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 71);
            this.panel1.TabIndex = 8;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_refresh.Location = new System.Drawing.Point(613, 12);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(114, 48);
            this.btn_refresh.TabIndex = 2;
            this.btn_refresh.Text = "REFRESH";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // cb_class_code
            // 
            this.cb_class_code.FormattingEnabled = true;
            this.cb_class_code.Location = new System.Drawing.Point(422, 32);
            this.cb_class_code.Name = "cb_class_code";
            this.cb_class_code.Size = new System.Drawing.Size(176, 28);
            this.cb_class_code.TabIndex = 1;
            // 
            // lbl_class_code
            // 
            this.lbl_class_code.AutoSize = true;
            this.lbl_class_code.BackColor = System.Drawing.Color.Transparent;
            this.lbl_class_code.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_class_code.Location = new System.Drawing.Point(418, 9);
            this.lbl_class_code.Name = "lbl_class_code";
            this.lbl_class_code.Size = new System.Drawing.Size(131, 22);
            this.lbl_class_code.TabIndex = 0;
            this.lbl_class_code.Text = "CLASS CODE:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(237)))));
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.btn_good);
            this.panel2.Controls.Add(this.btn_close);
            this.panel2.Controls.Add(this.btn_drop);
            this.panel2.Controls.Add(this.btn_warning);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 470);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(751, 100);
            this.panel2.TabIndex = 9;
            // 
            // btn_good
            // 
            this.btn_good.BackColor = System.Drawing.Color.Silver;
            this.btn_good.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_good.BackgroundImage")));
            this.btn_good.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_good.Location = new System.Drawing.Point(277, 29);
            this.btn_good.Name = "btn_good";
            this.btn_good.Size = new System.Drawing.Size(126, 42);
            this.btn_good.TabIndex = 7;
            this.btn_good.Text = "GOOD";
            this.btn_good.UseVisualStyleBackColor = false;
            this.btn_good.Click += new System.EventHandler(this.btn_good_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Location = new System.Drawing.Point(601, 29);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(126, 42);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "CLOSE";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_drop
            // 
            this.btn_drop.BackColor = System.Drawing.Color.Silver;
            this.btn_drop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_drop.BackgroundImage")));
            this.btn_drop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_drop.Location = new System.Drawing.Point(145, 29);
            this.btn_drop.Name = "btn_drop";
            this.btn_drop.Size = new System.Drawing.Size(126, 42);
            this.btn_drop.TabIndex = 5;
            this.btn_drop.Text = "DROP";
            this.btn_drop.UseVisualStyleBackColor = false;
            this.btn_drop.Click += new System.EventHandler(this.btn_drop_Click);
            // 
            // btn_warning
            // 
            this.btn_warning.BackColor = System.Drawing.Color.Silver;
            this.btn_warning.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_warning.BackgroundImage")));
            this.btn_warning.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_warning.Location = new System.Drawing.Point(12, 29);
            this.btn_warning.Name = "btn_warning";
            this.btn_warning.Size = new System.Drawing.Size(127, 42);
            this.btn_warning.TabIndex = 4;
            this.btn_warning.Text = "WARNING";
            this.btn_warning.UseVisualStyleBackColor = false;
            this.btn_warning.Click += new System.EventHandler(this.btn_warning_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(134, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(476, 367);
            this.dataGridView1.TabIndex = 0;
            // 
            // GuestViewReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 570);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GuestViewReportsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuestViewReportsForm";
            this.Load += new System.EventHandler(this.GuestViewReportsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.ComboBox cb_class_code;
        private System.Windows.Forms.Label lbl_class_code;
        private System.Windows.Forms.Button btn_drop;
        private System.Windows.Forms.Button btn_warning;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_good;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}