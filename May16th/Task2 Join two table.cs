using System;
using System.Data.SqlClient;




class Program2
{
    static void Main()
    {

        string connectionString =
                    "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;"
                    + "Integrated Security=true";

        string queryString = @"
            SELECT o.OrderID, c.ContactName, c.CompanyName, o.OrderDate
             FROM Orders o
             JOIN Customers c ON o.CustomerID = c.CustomerID";




        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(queryString, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                Console.WriteLine("{0,-25} {1,-20} {2,-40} {3,-60}", "OrderID", "Contact Name", "Company Name", "OrderDate");
                Console.WriteLine(new string('=', 90));

                while (reader.Read())
                {
                    Console.WriteLine("{0,-25} {1,-20} {2,-40} {3,-80:yyyy-MM-dd}",
                        reader["OrderID"], reader["ContactName"], reader["CompanyName"], reader["OrderDate"]);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}