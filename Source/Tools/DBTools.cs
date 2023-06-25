using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace StudentAttendanceManagementSystem.Tools
{
    public class DBTools
    {
        private static string computer_name = ReadFile("my_server.txt");
        // change this depending on the name of the server installed in your computer!!
        // TODO: later, save the connection string in a file then the program will just read it
        //  this will avoid the recompilation of the program in different computer for having different names.
        private static string connection_string = "Data Source= " + computer_name + "\\SQLEXPRESS;Initial Catalog=StudentAttendanceManagementSystemDB;Integrated Security=True";

        // default type for creating column in database
        private static string default_type = "NVARCHAR(50)";





        #region GETTERS
        /// <summary>
        /// this will return the connection string, defined on the top of this file
        /// </summary>
        public static string get_connection_string()
        {
            return connection_string;
        }

        /// <summary>
        /// this will return the default type 'nvarchar(50)'
        /// </summary>
        public static string get_default_type()
        {
            return default_type;
        }
        #endregion

        #region READ, WRITE, TO A FILE [experimental]
        // Create a new file
        public static void CreateFile(string filePath)
        {
            try
            {
                // Create a file at the specified path
                using (FileStream fs = File.Create(filePath))
                {
                    // Optionally, you can write content to the file immediately after creating it
                    byte[] content = System.Text.Encoding.UTF8.GetBytes("Hello there, Ralph Maron Eda is here!");
                    fs.Write(content, 0, content.Length);
                }

                Console.WriteLine("File created successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error creating file: " + ex.Message);
            }
        }

        // Read the contents of a file
        public static string ReadFile(string filePath)
        {
            string content = "";
            try
            {
                // Read all the text from the file
                content = File.ReadAllText(filePath);

                Console.WriteLine("File content: " + content);
                // MessageBox.Show("File content:\n" + content);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading file: " + ex.Message);
                MessageBox.Show("Error reading file: " + ex.Message);
            }
            return content;
        }

        // Write content to a file
        public static void WriteToFile(string filePath, string content)
        {
            try
            {
                // Write the specified content to the file, overwriting any existing content
                File.WriteAllText(filePath, content);

                Console.WriteLine("Content written to file successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error writing to file: " + ex.Message);
            }
        }

        // Delete a file
        public static void DeleteFile(string filePath)
        {
            try
            {
                // Delete the file if it exists
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                    Console.WriteLine("File deleted successfully!");
                }
                else
                {
                    Console.WriteLine("File does not exist.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deleting file: " + ex.Message);
            }
        }
        #endregion

        #region TESTING PURPOSES
        public string table_name = "test123";
        #endregion

        #region OTHER TOOLS

        /// <summary>
        /// for attendance form
        /// </summary>
        public static void IncrementAndInsertValue(string column_name, string table_name, string column_to_be_updated, List<string> recordIds_absent)
        {
            List<int> incremented_values_to_be_inserted = new List<int>();

            int incremented_value;
            SqlConnection connection = new SqlConnection(get_connection_string());

            if (column_to_be_updated.ToLower().Equals("total_absents"))
            {
                //MessageBox.Show("Updating total absents");
                Console.WriteLine("Updating total absents...");
                try
                {
                    connection.Open();

                    // Retrieve the value from the database
                    string selectQuery = "SELECT " + column_to_be_updated + " FROM " + table_name + " WHERE " + column_name + " = 'Absent' AND id_number = @id;";
                    SqlCommand selectCommand = new SqlCommand(selectQuery, connection);

                    MessageBox.Show("INserting the values [count of absents] in a list");
                    foreach (var id in recordIds_absent)
                    {
                        incremented_value = 0;
                        selectCommand.Parameters.Clear();
                        //string currentValue = selectCommand.ExecuteScalar().ToString();
                        int currentValue = int.Parse(selectCommand.ExecuteScalar().ToString());
                        // Increment the value
                        incremented_value = currentValue + 1;//int.Parse(currentValue) + 1;
                        incremented_values_to_be_inserted.Add(incremented_value);
                        currentValue = 0;
                        #region comment
                        // Convert the incremented value back to a string
                        // string newValue = incrementedValue.ToString();
                        //newValue = "2".ToString();
                        //MessageBox.Show("Updating.. after incrementing value");
                        //// Insert the updated value back into the database
                        //string updateQuery = "UPDATE " + table_name + " SET " + column_to_be_updated + " = @newValue " + " WHERE " + column_name + " = 'Absent' AND id_number = @id;";
                        //SqlCommand updateCommand = new SqlCommand(updateQuery, connection);


                        //updateCommand.Parameters.AddWithValue("@newValue", incremented_value);
                        //updateCommand.Parameters.AddWithValue("@id", id);
                        //updateCommand.ExecuteNonQuery();
                        //updateCommand.Parameters.Clear();
                        #endregion
                        // MessageBox.Show(incremented_value.ToString());
                        Console.WriteLine(incremented_value.ToString());

                    }
                    Console.WriteLine("Done...");
                    Console.WriteLine("Updating count of absents in database...");
                    //MessageBox.Show("Done");
                    //MessageBox.Show("Updating count of absents in db");

                    updating_absents_count_in_db(recordIds_absent, incremented_values_to_be_inserted, table_name, column_name, column_to_be_updated);

                    //MessageBox.Show("Absent count updated successfully!");
                    Console.WriteLine("Absent count updated successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error incrementing absents and inserting value: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            #region else if
            //else if (column_to_be_updated.ToLower().Equals("total_presents"))
            //{
            //    MessageBox.Show("Updating total presents");
            //    try
            //    {
            //        connection.Open();
            //        foreach (var id_present in recordIds_present)
            //        {
            //            incremented_value = 0;
            //            // Retrieve the value from the database
            //            string selectQuery = "SELECT " + column_to_be_updated + " FROM " + table_name + " WHERE " + column_name + " = 'Present'  AND id_number = @id;";
            //            SqlCommand selectCommand = new SqlCommand(selectQuery, connection);
            //            //string currentValue = selectCommand.ExecuteScalar().ToString();

            //            selectCommand.Parameters.Clear();
            //            selectCommand.Parameters.AddWithValue("@id", id_present);

            //            int currentValue = int.Parse(selectCommand.ExecuteScalar().ToString());
            //            // Increment the value
            //            incremented_value = currentValue + 1;//int.Parse(currentValue) + 1;
            //            currentValue = 0;
            //            // Convert the incremented value back to a string
            //            // string newValue = incrementedValue.ToString();
            //            //newValue = "2".ToString();

            //            // Insert the updated value back into the database
            //            string updateQuery = "UPDATE " + table_name + " SET " + column_to_be_updated + " = @newValue " + " WHERE " + column_name + " = 'Present' AND id_number = @id;";
            //            SqlCommand updateCommand = new SqlCommand(updateQuery, connection);

            //            updateCommand.Parameters.AddWithValue("@newValue", incremented_value);
            //            updateCommand.Parameters.AddWithValue("@id", id_present);
            //            updateCommand.ExecuteNonQuery();
            //            updateCommand.Parameters.Clear();
            //        }

            //        MessageBox.Show("Present count updated successfully!");
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Error incrementing presents and inserting value: " + ex.Message);
            //    }
            //    finally
            //    {
            //        incremented_value = 0;
            //        connection.Close();
            //    }
            //}
            #endregion
        }

        private static void updating_absents_count_in_db(List<string> recordIds, List<int> values_to_be_inserted, string table_name, string column_name, string column_name_to_be_updated)
        {
            // string connectionString = "Data Source=LAPTOP-T2HJFRJU\\SQLEXPRESS;Initial Catalog=StudentAttendanceManagementSystemDB;Integrated Security=True";
            SqlConnection connection = new SqlConnection(get_connection_string());

            try
            {
                connection.Open();

                string query = "UPDATE " + table_name + " SET " + column_name + " = @value WHERE " + column_name_to_be_updated + " = @id;";
                SqlCommand command = new SqlCommand(query, connection);

                //for (int i = 0; i < recordIds.Count; i++)
                //{
                //    command.Parameters.Clear();
                //    command.Parameters.AddWithValue("@value", values_to_be_inserted.ElementAt(i));
                //    command.Parameters.AddWithValue("@id", recordIds.ElementAt(i));
                //    //DBTools.IncrementAndInsert(table_name, column_name, id);
                //    command.ExecuteNonQuery();
                //}

                int i = 0;
                foreach (var id in recordIds)
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@value", values_to_be_inserted[i]);
                    command.Parameters.AddWithValue("@id", id);
                    i++;
                    //DBTools.IncrementAndInsert(table_name, column_name, id);
                    command.ExecuteNonQuery();
                }

                //foreach (var id in recordIds)
                //{
                //    command.Parameters.Clear();
                //    command.Parameters.AddWithValue("@value", value);
                //    command.Parameters.AddWithValue("@id", id);
                //    //DBTools.IncrementAndInsert(table_name, column_name, id);
                //    command.ExecuteNonQuery();
                //}

                MessageBox.Show("Value inserted in records successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting value in records: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }




        /// <summary>
        /// this is used in attendance form
        /// </summary>
        public static void IncrementAndInsert(string table_name, string column_name, string id_number)
        {
            SqlConnection connection = new SqlConnection(get_connection_string());

            try
            {
                connection.Open();

                // Retrieve the value from the database
                string selectQuery = "SELECT " + column_name + " FROM " + table_name + " WHERE id_number = @id;";
                SqlCommand selectCommand = new SqlCommand(selectQuery, connection);
                selectCommand.Parameters.AddWithValue("@id", id_number);
                int currentValue = Convert.ToInt32(selectCommand.ExecuteScalar());

                // Increment the retrieved value by 1
                int incrementedValue = currentValue + 1;

                // Update the database with the incremented value
                string updateQuery = "UPDATE " + table_name + " SET " + column_name + " = @incrementedValue WHERE id_number = @id;";
                SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                updateCommand.Parameters.AddWithValue("@incrementedValue", incrementedValue);
                updateCommand.Parameters.AddWithValue("@id", id_number);
                updateCommand.ExecuteNonQuery();

                MessageBox.Show("Value incremented and updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error incrementing value: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }


        #endregion


        #region Attendance Form tools

        public static string get_current_date()
        {
            DateTime currentDate = DateTime.Now;
            string current_date = currentDate.ToString("yyyy_MM_dd");

            return current_date;
        }
        #endregion


        #region Setting the top 3 classes to be putted on dashboard form
        public static void set_top_three_classes_to_be_putted_on_dashboard_form()
        {
            /// TODO: Let the user set the top 3 classes
        }
        #endregion


        #region Class Tools
        /// <summary>
        /// Date: 2023-06-06 
        /// Author: Maron
        /// 
        /// Select the given column from the given table.
        /// this is used as auto fill [in update class and update student]
        /// </summary>
        public static string get_data_from_database(string table_name, string column_name, string id_number)
        {
            string data = "Maron";
            SqlConnection conn = new SqlConnection(DBTools.get_connection_string());

            try
            {
                conn.Open();
                // tb_name.Text = DBTools.get_data_from_database(table_name, column_name, id_number);
                //string table_name = "class_" + cb_class.Text;
                //string column_name = "first_name";
                //string id_number = tb_id_number.Text;
                string query = "SELECT " + column_name + " FROM " + table_name + " WHERE id_number = " + id_number;
                SqlCommand cmd = new SqlCommand(query, conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        int column_index = reader.GetOrdinal(column_name);
                        while (reader.Read())
                        {
                            string column_value = reader.GetString(column_index);
                            data = column_value;
                            //MessageBox.Show(column_value);
                            Console.WriteLine(column_value);
                            return data;
                            //break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No data found!");
                    }
                }
                //MessageBox.Show("Done");
                Console.WriteLine("Done...");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Message: " + ex.Message);
            }
            return data;
        }

        #endregion


        public static bool is_record_exist_in_database(string table_name, string column_name, string value)
        {
            // Create the MySqlConnection object
            using (SqlConnection connection = new SqlConnection(DBTools.get_connection_string()))
            {
                try
                {
                    connection.Open();

                    // Prepare the SQL query
                    string query = "SELECT COUNT(*) FROM " + table_name + " WHERE " + column_name + " = @value"; // Replace with your table and column names
                    SqlCommand command = new SqlCommand(query, connection);

                    // Set the parameter value
                    command.Parameters.AddWithValue("@value", value); // Replace with the value you want to search

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


        public static bool is_column_exists_in_table_database(string table_name, string column_name)
        {
            Console.WriteLine("Checking if column exists in database...");
            Console.WriteLine("Table Name: " + table_name);
            Console.WriteLine("Column Name: " + column_name);
            // Create the SqlConnection object
            using (SqlConnection connection = new SqlConnection(get_connection_string()))
            {
                Console.WriteLine("Connection string: " + get_connection_string());
                try
                {
                    connection.Open();

                    // string tableName = "YourTable"; // Replace with the table name you want to check
                    //string columnName = "YourColumn"; // Replace with the column name you want to check

                    // Prepare the SQL query
                    string query = "SELECT COUNT(*) FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = @tableName AND COLUMN_NAME = @columnName";
                    SqlCommand command = new SqlCommand(query, connection);

                    // Set the parameter values
                    command.Parameters.AddWithValue("@tableName", table_name);
                    command.Parameters.AddWithValue("@columnName", column_name);

                    // Execute the query and get the result
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    // Check if the column exists
                    if (count > 0)
                    {
                        Console.WriteLine("The column exists in the table.");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("The column does not exist in the table.");
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
                Console.WriteLine("Done...");
                return false;
            }

        }

        public static bool is_table_empty(string table_name)
        {
            Console.WriteLine("Checking if table is empty!");
            try
            {

                using (SqlConnection connection = new SqlConnection(get_connection_string()))
                {
                    connection.Open();

                    // Create a SQL command to count the rows in the table
                    string query = $"SELECT COUNT(*) FROM {table_name}";
                    SqlCommand command = new SqlCommand(query, connection);

                    // Execute the query and get the result
                    int row_count = (int)command.ExecuteScalar();

                    // Check if the table is empty
                    if (row_count == 0)
                    {
                        Console.WriteLine("The table is empty.");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("The table is not empty.");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            Console.WriteLine("Done...");
            return false;
        }

    }
}
