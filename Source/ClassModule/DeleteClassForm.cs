using StudentAttendanceManagementSystem.Tools;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentAttendanceManagementSystem.ClassModule
{
    public partial class DeleteClassForm : Form
    {
        public DeleteClassForm()
        {
            InitializeComponent();
        }

        private void btn_finish_add_Click(object sender, EventArgs e)
        {
            if (DBTools.is_record_exist_in_database("classes_table", "class_code", tb_subject_code_delete.Text))
            {
                if (tb_subject_code_delete.Text != "")
                {
                    try
                    {
                        string class_code = this.tb_subject_code_delete.Text;
                        // string MyConnection2 = "Data Source=LAPTOP-T2HJFRJU\\SQLEXPRESS;Initial Catalog=StudentAttendanceManagementSystemDB;Integrated Security=True";
                        string Query = "delete from classes_table where class_code ='" + class_code + "';";
                        SqlConnection MyConn2 = new SqlConnection(DBTools.get_connection_string());
                        SqlCommand MyCommand2 = new SqlCommand(Query, MyConn2);
                        SqlDataReader MyReader2;
                        MyConn2.Open();
                        MyReader2 = MyCommand2.ExecuteReader();
                        MessageBox.Show(this.tb_subject_code_delete.Text + " class deleted successfully!");
                        while (MyReader2.Read())
                        {
                        }
                        MyConn2.Close();

                        delete_class_table(class_code);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    Console.WriteLine("Deleting class successful...");
                }
                else
                {
                    MessageBox.Show("Class code to be deleted is empty!", "Deleting class failed!");
                    Console.Write("Deleting class failed...");
                }
            }
            else
            {
                MessageBox.Show("Class doesn't exist in database.", "Failed!");
            }
            Hide();
        }

        private void delete_class_table(string class_code)
        {
            string connection_string = DBTools.get_connection_string();
            string table_name = "class_" + class_code;

            DeleteTable(table_name, connection_string);
        }


        private void DeleteTable(string tableName, string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = $"DROP TABLE IF EXISTS {tableName}";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        private void gb_add_class_Enter(object sender, EventArgs e)
        {

        }
    }
}
