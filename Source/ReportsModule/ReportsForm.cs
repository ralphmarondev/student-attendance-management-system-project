using StudentAttendanceManagementSystem.DashBoardModule;
using StudentAttendanceManagementSystem.Tools;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentAttendanceManagementSystem.ReportsModule
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

        // constructor for passing data
        public ReportsForm(string college, string department, string semester, string school_year, string class_enrolled)
        {
            InitializeComponent();

            cb_class.Text = class_enrolled;
            cb_college.Text = college;
            cb_department.Text = department;
            cb_semester.Text = semester;
            cb_school_year.Text = school_year;
            refresh();
        }

        private void ReportsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DashBoardForm df = new DashBoardForm();

            df.Show();
            Hide();
        }

        private void btn_refresh_Click(object sender, System.EventArgs e)
        {
            //string table_name = "class_" + cb_class.Text;
            //try
            //{
            //    //Display query
            //    string Query = "select * from " + table_name + ";";
            //    SqlConnection MyConn2 = new SqlConnection(DBTools.get_connection_string());
            //    SqlCommand MyCommand2 = new SqlCommand(Query, MyConn2);
            //    //  MyConn2.Open();
            //    //For offline connection we weill use  MySqlDataAdapter class.
            //    SqlDataAdapter MyAdapter = new SqlDataAdapter();
            //    MyAdapter.SelectCommand = MyCommand2;
            //    DataTable dTable = new DataTable();
            //    MyAdapter.Fill(dTable);
            //    dataGridView1.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.
            //                                       // MyConn2.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            refresh();
        }

        private void refresh()
        {
            string table_name = "class_" + cb_class.Text;
            try
            {
                //Display query
                string Query = "select * from " + table_name + ";";
                SqlConnection MyConn2 = new SqlConnection(DBTools.get_connection_string());
                SqlCommand MyCommand2 = new SqlCommand(Query, MyConn2);
                //  MyConn2.Open();
                //For offline connection we weill use  MySqlDataAdapter class.
                SqlDataAdapter MyAdapter = new SqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.
                                                   // MyConn2.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            btn_refresh_Click(sender, e);
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            //// TODO: Implement this!!
            //MessageBox.Show("Coming soon!");
            DashBoardForm df = new DashBoardForm();

            df.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string table_name = "class_" + cb_class.Text;

            ViewAttendanceForm v = new ViewAttendanceForm(table_name);

            v.Show();
        }

        private void btn_view_remarks_Click(object sender, EventArgs e)
        {
            string class_code = cb_class.Text;
            StudentEligibleForDropOutForm sd = new StudentEligibleForDropOutForm(class_code);

            sd.Show();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string id_number = tb_id_number_search.Text;
            string table_name = "class_" + cb_class.Text;

            searh_data(id_number, table_name);

        }

        private void searh_data(string id_number, string table_name)
        {
            try
            {
                string query = "SELECT * FROM " + table_name + " WHERE id_number = '" + id_number + "';";
                SqlConnection conn = new SqlConnection(DBTools.get_connection_string());
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                adapter.Fill(dt);
                dataGridView1.DataSource = dt;


            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

        }

    }
}
