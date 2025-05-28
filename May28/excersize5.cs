using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

class Program1
{
    static void DeleteProduct(string productID)
    {
        string connectionString =
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;"
            + "Integrated Security=true";

        string deleteQuery = "DELETE FROM Products WHERE ProductID = @productID";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(deleteQuery, connection);
            command.Parameters.AddWithValue("@productID", productID);

            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                Console.WriteLine(rowsAffected > 0 ? "Product deleted successfully!" : "Deletion failed.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }

    static void Main()
    {
        Console.WriteLine("Enter the product ID: ");
        string productID= Console.ReadLine();
        DeleteProduct(productID);
    }
}