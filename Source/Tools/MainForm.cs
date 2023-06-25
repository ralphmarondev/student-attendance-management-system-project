using StudentAttendanceManagementSystem.DashBoardModule;
using StudentAttendanceManagementSystem.GuestUserModules;
using StudentAttendanceManagementSystem.Tools;
using System;
using System.Collections;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace StudentAttendanceManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This verifies if the username and password is on the database,
        /// if it is there, it will open DashboardForm, otherwise,
        /// it will show a message-box saying 'login failed'
        /// </summary>
        private void btn_login_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(DBTools.get_connection_string());
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * From dbo.Users where username=@username AND password=@password", conn);
            cmd.Parameters.AddWithValue("username", tb_username.Text.Trim());
            cmd.Parameters.AddWithValue("password", tb_password.Text.Trim());

            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    DashBoardForm dash_board_form = new DashBoardForm(tb_username.Text);

                    dash_board_form.Show();

                    tb_username.Clear();
                    tb_password.Clear();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username and Password doesn't match!", "Login Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    tb_username.Clear();
                    tb_password.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Username and Password doesn't match!", "Login Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tb_username.Clear();
                tb_password.Clear();
            }



        }

        private void link_lbl_forgot_password_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // if username if blank, it will display the default credentials
            if (tb_username.Text == "")
            {
                MessageBox.Show("Default Credentials:\nUsername: root\nPassword: toor\n", "HINT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                // else it will search for the username in database and show the hint,
                // registered on that username
                getting_some_data_in_database();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_as_guest_Click(object sender, EventArgs e)
        {
            GuestMainForm gm = new GuestMainForm();

            gm.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tb_password.PasswordChar == '*')
            {
                Hide.BringToFront();
                tb_password.PasswordChar = '\0';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_password.PasswordChar == '\0')
            {
                Show.BringToFront();
                tb_password.PasswordChar = '*';
            }

        }
        private ArrayList hint = new ArrayList();
        private void getting_some_data_in_database()
        {
            hint.Clear();
            string username = tb_username.Text;

            SqlConnection conn = new SqlConnection(DBTools.get_connection_string());

            try
            {
                Console.WriteLine("Getting hint for: " + username);
                conn.Open();

                string query = "SELECT hint FROM Users WHERE username like '" + username + "';";
                SqlCommand cmd = new SqlCommand(query, conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        int column_index = reader.GetOrdinal("hint");
                        while (reader.Read())
                        {
                            string column_value = reader.GetString(column_index);
                            hint.Add(column_value);
                            Console.WriteLine(column_value);
                        }
                    }
                    else
                    {
                        MessageBox.Show("User '" + username + "', is not registered!");
                    }
                }
                Console.WriteLine("Done...");

                Console.WriteLine("Hint: " + hint[0].ToString());
                MessageBox.Show("Hint for '" + username + "':\n" + hint[0].ToString());
            }
            catch (Exception ex)
            {
                // MessageBox.Show("Error: " + ex.Message);
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void btn_login_MouseHover(object sender, EventArgs e)
        {

        }

        private void btn_login_MouseLeave(object sender, EventArgs e)
        {
            btn_login.BackColor = Color.FromArgb(107, 122, 255);
        }

        private void btn_login_MouseEnter(object sender, EventArgs e)
        {
            this.btn_login.BackColor = Color.Blue;
        }
    }
}
