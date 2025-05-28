using System;
using System.Data.SqlClient;

class UpdateEmployeeTitle
{
    static void Main()
    {
        string connectionString =
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;" +
            "Integrated Security=true";

        Console.Write("Enter Employee ID: ");
        int employeeId = int.Parse(Console.ReadLine());

        Console.Write("Enter new Title: ");
        string newTitle = Console.ReadLine();

        string updateQuery = "UPDATE Employees SET Title = @Title WHERE EmployeeID = @EmployeeID";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(updateQuery, connection);

            // Add parameters using AddWithValue
            command.Parameters.AddWithValue("@Title", newTitle);
            command.Parameters.AddWithValue("@EmployeeID", employeeId);

            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                    Console.WriteLine("Employee title updated successfully.");
                else
                    Console.WriteLine("No employee found with the given ID.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.ReadLine();
        }
    }
}