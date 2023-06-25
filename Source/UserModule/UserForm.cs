using StudentAttendanceManagementSystem.DashBoardModule;
using StudentAttendanceManagementSystem.Tools;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentAttendanceManagementSystem.UserModule
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DashBoardForm dbf = new DashBoardForm();

            dbf.Show();
            Hide();
        }

        private void btn_add_user_Click(object sender, System.EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Hide();

            DashBoardForm dbf = new DashBoardForm();

            dbf.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_edit_user_Click(object sender, EventArgs e)
        {

        }

        // add
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                //This is my connection string i have assigned the database file address path
                string MyConnection2 = DBTools.get_connection_string();
                string Query = "insert into Users (username, password, hint) values ('" + tb_username.Text + "','" + tb_password.Text + "','" + tb_hint.Text + "');";
                //This is  MySqlConnection here i have created the object and pass my connection string.
                SqlConnection MyConn2 = new SqlConnection(MyConnection2);
                //This is command class which will handle the query and connection object.
                SqlCommand MyCommand2 = new SqlCommand(Query, MyConn2);
                SqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                MessageBox.Show("Saved Successfully!");
                while (MyReader2.Read())
                {
                }

                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in saving new user: " + ex.Message);
            }
            btn_refresh_Click(sender, e);
        }

        // edit
        private void button2_Click(object sender, EventArgs e)
        {

            Console.WriteLine("Editing users...");
            try
            {
                if (tb_password.Text != "" && tb_username.Text != "" && tb_hint.Text != "")
                {
                    update_password();
                    update_hint();
                }
                else
                {
                    MessageBox.Show("Fill up all fields.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            Console.WriteLine("Done");
            btn_refresh_Click(sender, e);
        }


        private void update_password()
        {
            try
            {
                string query = "update Users set password = '" + tb_password.Text + "' where username = '" + tb_username.Text + "';";
                SqlConnection conn = new SqlConnection(DBTools.get_connection_string());
                SqlCommand cmd = new SqlCommand(query, conn);

                Console.WriteLine("Opening connection...");
                conn.Open();
                Console.WriteLine("Done...");

                Console.WriteLine("Executing non query...");
                cmd.ExecuteNonQuery();
                Console.WriteLine("Done...");

                Console.WriteLine("Closing connection...");
                conn.Close();
                Console.WriteLine("Done...");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void update_hint()
        {
            try
            {
                string query = "update Users set hint = '" + tb_hint.Text + "' where username = '" + tb_username.Text + "';";
                SqlConnection conn = new SqlConnection(DBTools.get_connection_string());
                SqlCommand cmd = new SqlCommand(query, conn);

                Console.WriteLine("Opening connection...");
                conn.Open();
                Console.WriteLine("Done...");

                Console.WriteLine("Executing non query...");
                cmd.ExecuteNonQuery();
                Console.WriteLine("Done...");

                Console.WriteLine("Closing connection...");
                conn.Close();
                Console.WriteLine("Done...");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        // end edit

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string Query = "delete from Users where username ='" + this.tb_username.Text + "' AND password='" + this.tb_password.Text + "';";
                SqlConnection MyConn2 = new SqlConnection(DBTools.get_connection_string());
                SqlCommand MyCommand2 = new SqlCommand(Query, MyConn2);
                SqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show(this.tb_username.Text + " from users was deleted successfully!");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            btn_refresh_Click(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DashBoardForm df = new DashBoardForm();

            df.Show();
            Hide();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            string table_name = "Users";
            try
            {
                string Query = "select * from " + table_name + ";";
                SqlConnection MyConn2 = new SqlConnection(DBTools.get_connection_string());
                SqlCommand MyCommand2 = new SqlCommand(Query, MyConn2);

                SqlDataAdapter MyAdapter = new SqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView2.DataSource = dTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            btn_refresh_Click(sender, e);
        }
    }
}
