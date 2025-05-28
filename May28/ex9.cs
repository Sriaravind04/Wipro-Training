using System;
using System.Data;
using System.Data.SqlClient;

class DisconnectedProductsExample
{
    static void Main()
    {
        string connectionString = 
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;" +
            "Integrated Security=true";

        string query = "SELECT ProductID, ProductName, UnitsInStock FROM Products";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataSet dataSet = new DataSet();

            try
            {
                adapter.Fill(dataSet, "Products");

                DataTable productsTable = dataSet.Tables["Products"];

                Console.WriteLine("ProductID\tProduct Name\t\tUnits In Stock");
                Console.WriteLine("---------------------------------------------------");

                foreach (DataRow row in productsTable.Rows)
                {
                    int unitsInStock = Convert.ToInt32(row["UnitsInStock"]);

                    if (unitsInStock > 20)
                    {
                        int productId = Convert.ToInt32(row["ProductID"]);
                        string productName = row["ProductName"].ToString();

                        Console.WriteLine($"{productId,-10} {productName,-25} {unitsInStock}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.ReadLine();
        }
    }
}