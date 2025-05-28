using System;
using System.Data.SqlClient;

class OrderSearch
{
    static string connectionString =
        "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;" +
        "Integrated Security=true";

    static void Main()
    {
        Console.Write("Enter Customer ID to search orders: ");
        string customerId = Console.ReadLine();

        GetOrdersByCustomer(customerId);

        Console.ReadLine();
    }

    static void GetOrdersByCustomer(string customerId)
    {
        string query = "SELECT OrderID, OrderDate, ShipCountry FROM Orders WHERE CustomerID = @customerId";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(query, connection);

            // Add parameter safely
            command.Parameters.AddWithValue("@customerId", customerId);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                Console.WriteLine("{0,-10} {1,-20} {2,-20}", "OrderID", "OrderDate", "ShipCountry");
                Console.WriteLine("-----------------------------------------------------------");

                if (!reader.HasRows)
                {
                    Console.WriteLine("No orders found for Customer ID: " + customerId);
                }

                while (reader.Read())
                {
                    int orderId = (int)reader["OrderID"];
                    DateTime orderDate = (DateTime)reader["OrderDate"];
                    string shipCountry = reader["ShipCountry"].ToString();

                    Console.WriteLine("{0,-10} {1,-20:yyyy-MM-dd} {2,-20}", orderId, orderDate, shipCountry);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}