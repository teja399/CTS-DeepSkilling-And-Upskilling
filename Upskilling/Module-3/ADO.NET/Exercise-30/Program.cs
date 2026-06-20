using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        string connectionString =
            "Server=localhost;Database=TestDB;Trusted_Connection=True;TrustServerCertificate=True;";

        using SqlConnection connection =
            new SqlConnection(connectionString);

        connection.Open();

        // INSERT
        SqlCommand insertCommand =
            new SqlCommand(
                "INSERT INTO Employees(Name) VALUES('Deepika')",
                connection);

        insertCommand.ExecuteNonQuery();

        // READ
        SqlCommand selectCommand =
            new SqlCommand(
                "SELECT * FROM Employees",
                connection);

        SqlDataReader reader =
            selectCommand.ExecuteReader();

        while (reader.Read())
        {
            Console.WriteLine(
                $"{reader["Id"]} - {reader["Name"]}");
        }

        reader.Close();

        // UPDATE
        SqlCommand updateCommand =
            new SqlCommand(
                "UPDATE Employees SET Name='Deepika Reddy' WHERE Name='Deepika'",
                connection);

        updateCommand.ExecuteNonQuery();

        // DELETE
        SqlCommand deleteCommand =
            new SqlCommand(
                "DELETE FROM Employees WHERE Name='Deepika Reddy'",
                connection);

        deleteCommand.ExecuteNonQuery();

        connection.Close();
    }
}
