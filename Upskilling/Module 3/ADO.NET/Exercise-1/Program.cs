using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace ADONETExercises
{
    // Exercise 1: Database Connection and Data Retrieval
    class Program
    {
        static void Main()
        {
            string connectionString = "Server=localhost;Database=students;Uid=root;Pwd=password;";
            
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    Console.WriteLine("Connected to database successfully!");

                    // Retrieve data
                    string query = "SELECT * FROM Students";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Console.WriteLine($"ID: {reader["StudentID"]}, Name: {reader["Name"]}, Email: {reader["Email"]}");
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}