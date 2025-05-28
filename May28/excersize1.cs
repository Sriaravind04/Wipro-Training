using System;
using System.Data.SqlClient;

class CustomerDetails
{
    static void Main()
    {
        string connectionString =
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;"
            + "Integrated Security=true";

        string queryString =
            "SELECT * FROM dbo.Customers";

        //Create and open the connection in a using block.This
        using (SqlConnection connection = new SqlConnection(connectionString))
        {

            //create the command and parameter objects.
            SqlCommand command = new SqlCommand(queryString, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                Console.WriteLine("CustomerID\t\tCompanyName\t\tCountry");
                Console.WriteLine("-------------------------------------------------------");
                while (reader.Read())
                {

                    string CustomerID = reader["CustomerID"].ToString();
                    string CompanyName = reader["CompanyName"].ToString();
                    string Country = reader["Country"].ToString();

                    Console.WriteLine($"{CustomerID,-15} {CompanyName,-35} {Country,-20}");
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