using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program1
    {
     
        static void Main()
        { 
            string connectionString = "Data source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;" 
                + "Integrated Security=true";

            string queryString =
                "SELECT ContactName, City, CompanyName FROM Customers";

            using (SqlConnection connection = new SqlConnection(connectionString))
                {
                SqlCommand command = new SqlCommand(queryString, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    Console.WriteLine("{0,-25}{1,-20}{2,-40}", "ContactName", "City", "CompanyName");
                    Console.WriteLine(new String( "-----------              -----------         -----------"));

                    while (reader.Read())
                    {
                        string contactName = reader["ContactName"].ToString() ?? "";
                        string city = reader["City"].ToString() ?? "";
                        string companyName = reader["CompanyName"].ToString() ?? "";

                        Console.WriteLine("{0,-25}{1,-20}{2,-40}",contactName, city ,companyName);
                    }

                    reader.Close();
                }
                catch (Exception ex) {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

        //    Console.ReadLine();
        }
    }
}