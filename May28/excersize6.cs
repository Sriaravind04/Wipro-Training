using System;
using System.Data.SqlClient;

class JoinOrdersAndCustomers
{
    static void Main()
    {
        string connectionString =
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;" +
            "Integrated Security=true";

        string joinQuery = @"
            SELECT o.OrderID, c.CompanyName, o.OrderDate
            FROM Orders o
            INNER JOIN Customers c ON o.CustomerID = c.CustomerID";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(joinQuery, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                Console.WriteLine("OrderID\t\tCompany Name\t\tOrder Date");
                Console.WriteLine("------------------------------------------------------------");

                while (reader.Read())
                {
                    int orderId = Convert.ToInt32(reader["OrderID"]);
                    string companyName = reader["CompanyName"].ToString();
                    DateTime orderDate = Convert.ToDateTime(reader["OrderDate"]);

                    Console.WriteLine($"{orderId,-12} {companyName,-20} {orderDate.ToShortDateString()}");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.ReadLine();
        }
    }
}