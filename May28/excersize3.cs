using System;

using System.Data.SqlClient;

class InsertProduct
{
    static void Main()
    {
        string connectionString =
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;" +
            "Integrated Security=true";

        string insertQuery = @"
            INSERT INTO Products (ProductName, SupplierID, CategoryID, UnitPrice)
            VALUES (@ProductName, @SupplierID, @CategoryID, @UnitPrice)";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(insertQuery, connection);

            // Add parameters
            command.Parameters.AddWithValue("@ProductName", "Test Product");
            command.Parameters.AddWithValue("@SupplierID", 1);
            command.Parameters.AddWithValue("@CategoryID", 1);
            command.Parameters.AddWithValue("@UnitPrice", 25);

            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                    Console.WriteLine("Product inserted successfully.");
                else
                    Console.WriteLine("Insert failed.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.ReadLine();
        }
    }
}