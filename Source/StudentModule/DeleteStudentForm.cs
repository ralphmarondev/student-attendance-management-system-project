using StudentAttendanceManagementSystem.Tools;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentAttendanceManagementSystem.StudentModule
{
    public partial class DeleteStudentForm : Form
    {
        private string table_name;
        public DeleteStudentForm()
        {
            InitializeComponent();
        }

        public DeleteStudentForm(string table_name)
        {
            InitializeComponent();
            this.table_name = table_name;
        }

        private void btn_finish_Click(object sender, EventArgs e)
        {
            if (tb_id_number.Text != "")
            {
                if (is_student_exist_in_class_database())
                {
                    try
                    {
                        string Query = "delete from " + table_name + " where id_number ='" + this.tb_id_number.Text + "';";
                        SqlConnection MyConn2 = new SqlConnection(DBTools.get_connection_string());
                        SqlCommand MyCommand2 = new SqlCommand(Query, MyConn2);
                        SqlDataReader MyReader2;
                        MyConn2.Open();
                        MyReader2 = MyCommand2.ExecuteReader();
                        MessageBox.Show(this.tb_id_number.Text + " deleted from database successfully!");
                        while (MyReader2.Read())
                        {
                        }
                        MyConn2.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("No such student in database.", "Failed!");
                }
            }
            else
            {
                MessageBox.Show("No ID number specified.", "Deleting student failed!");
            }
            Hide();
        }


        private bool is_student_exist_in_class_database()
        {
            // Create the MySqlConnection object
            using (SqlConnection connection = new SqlConnection(DBTools.get_connection_string()))
            {
                try
                {
                    connection.Open();

                    // Prepare the SQL query
                    string query = "SELECT COUNT(*) FROM " + table_name + " WHERE id_number = @value"; // Replace with your table and column names
                    SqlCommand command = new SqlCommand(query, connection);

                    // Set the parameter value
                    command.Parameters.AddWithValue("@value", tb_id_number.Text); // Replace with the value you want to search

                    // Execute the query and get the result
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    // Check if the record exists
                    if (count > 0)
                    {
                        Console.WriteLine("The record already exists in the database.");
                        return true;
                    }
                    else
                    {
                        // Add the record to the database
                        // ...
                        Console.WriteLine("The record does not exist in the database and can be added.");
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
                return false;
            }
        }


        private void DeleteStudentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
