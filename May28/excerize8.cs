using System.Data;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        string connectionString =
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;"
            + "Integrated Security=true";

        Console.Write("Enter Customer ID: ");
        string customerID = Console.ReadLine();

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand cmd = new SqlCommand("CustOrderHist", connection); //CustOrderHis - Buitlt-in Stored Procedure
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CustomerID", customerID);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                Console.WriteLine("Product Name\tTotal Orders");
                Console.WriteLine("---------------------------");
                while (reader.Read())
                {
                    Console.WriteLine($"{reader["ProductName"]}\t{reader["Total"]}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}