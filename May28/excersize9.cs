using System;
using System.Data.SqlClient;

class TransactionExample
{
    static void Main()
    {
        string connectionString = 
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;" +
            "Integrated Security=true";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            SqlTransaction transaction = connection.BeginTransaction();

            try
            {
                // Insert into Orders
                string insertOrder = @"
                    INSERT INTO Orders (CustomerID, OrderDate, ShipCountry)
                    VALUES (@CustomerID, @OrderDate, @ShipCountry);
                    SELECT SCOPE_IDENTITY();"; // To get the new OrderID

                SqlCommand cmdOrder = new SqlCommand(insertOrder, connection, transaction);
                cmdOrder.Parameters.AddWithValue("@CustomerID", "ALFKI");
                cmdOrder.Parameters.AddWithValue("@OrderDate", DateTime.Now);
                cmdOrder.Parameters.AddWithValue("@ShipCountry", "Germany");

                int newOrderId = Convert.ToInt32(cmdOrder.ExecuteScalar());

                // Insert into Order Details
                string insertDetails = @"
                    INSERT INTO [Order Details] (OrderID, ProductID, UnitPrice, Quantity, Discount)
                    VALUES (@OrderID, @ProductID, @UnitPrice, @Quantity, @Discount);";

                SqlCommand cmdDetails = new SqlCommand(insertDetails, connection, transaction);
                cmdDetails.Parameters.AddWithValue("@OrderID", newOrderId);
                cmdDetails.Parameters.AddWithValue("@ProductID", 1); // Example product
                cmdDetails.Parameters.AddWithValue("@UnitPrice", 20);
                cmdDetails.Parameters.AddWithValue("@Quantity", 5);
                cmdDetails.Parameters.AddWithValue("@Discount", 0);

                cmdDetails.ExecuteNonQuery();

                // Commit transaction
                transaction.Commit();
                Console.WriteLine("Transaction completed successfully.");
            }
            catch (Exception ex)
            {
                // Rollback transaction
                transaction.Rollback();
                Console.WriteLine("Transaction failed and rolled back.");
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.ReadLine();
        }
    }
}