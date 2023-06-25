using StudentAttendanceManagementSystem.Tools;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentAttendanceManagementSystem.ReportsModule
{
    public partial class StudentEligibleForDropOutForm : Form
    {
        private string class_code;
        public StudentEligibleForDropOutForm()
        {
            InitializeComponent();
        }

        public StudentEligibleForDropOutForm(string class_code)
        {
            InitializeComponent();
            this.class_code = class_code;
            cb_class_code.Text = class_code;
            refresh();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btn_warning_Click(object sender, EventArgs e)
        {
            string class_code = cb_class_code.Text;
            string table_name = "class_" + class_code;

            try
            {
                Console.WriteLine("Getting students with 'warning' status");
                dataGridView1.ClearSelection();
                string conn = DBTools.get_connection_string();

                using (SqlConnection connection = new SqlConnection(conn))
                {
                    string query = "select id_number, last_name, first_name, status from " + table_name + " where status  = 'WARNING'";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
                Console.WriteLine("Done");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void btn_drop_Click(object sender, EventArgs e)
        {
            string class_code = cb_class_code.Text;
            string table_name = "class_" + class_code;

            try
            {
                Console.WriteLine("Getting students with 'Drop' status");
                dataGridView1.ClearSelection();
                string conn = DBTools.get_connection_string();

                using (SqlConnection connection = new SqlConnection(conn))
                {
                    string query = "select id_number, last_name, first_name, status from " + table_name + " where status  = 'DROP'";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
                Console.WriteLine("Done");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon... Print");
        }

        private void StudentEligibleForDropOutForm_Load(object sender, EventArgs e)
        {
            // setting the class code to the passed class code
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void refresh()
        {
            string class_code = cb_class_code.Text;
            string table_name = "class_" + class_code;

            try
            {
                Console.WriteLine("Getting all students regardless of status");
                string conn = DBTools.get_connection_string();

                using (SqlConnection connection = new SqlConnection(conn))
                {
                    string query = "select id_number, last_name, first_name, status from " + table_name;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
                Console.WriteLine("Done");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void btn_good_Click(object sender, EventArgs e)
        {
            string class_code = cb_class_code.Text;
            string table_name = "class_" + class_code;

            try
            {
                Console.WriteLine("Getting students with 'warning' status");
                dataGridView1.ClearSelection();
                string conn = DBTools.get_connection_string();

                using (SqlConnection connection = new SqlConnection(conn))
                {
                    string query = "select id_number, last_name, first_name, status from " + table_name + " where status  = 'GOOD'";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
                Console.WriteLine("Done");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
