using System.Data;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        string connectionString =
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;"
            + "Integrated Security=true";

        string queryString =
            "SELECT ProductID, SUM(UnitPrice * Quantity) AS TotalSales FROM [Order Details] GROUP BY ProductID";

        DataTable dataTable = new DataTable();

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(queryString, connection);
                adapter.Fill(dataTable);

                Console.WriteLine("ProductID\tTotalSales");
                Console.WriteLine("----------------------------");
                foreach (DataRow row in dataTable.Rows)
                {
                    Console.WriteLine(row["ProductID"]+"\t\t"+row["TotalSales"]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}