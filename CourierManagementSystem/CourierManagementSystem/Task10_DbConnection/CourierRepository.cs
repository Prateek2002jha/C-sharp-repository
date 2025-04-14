using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CourierManagementSystem.Task5_OOP; // This namespace contains the Courier class
using CourierManagementSystem.Task10_DbConnection; // Ensure this namespace contains ConnectionUtil

namespace CourierManagementSystem.Task10_DbConnection
{
    // CourierRepository class handles database interactions related to Couriers.
    public class CourierRepository
    {
        private readonly SqlConnection _connection; // The database connection is stored in this field

        // Constructor initializes the database connection using the ConnectionUtil class
        public CourierRepository()
        {
            _connection = ConnectionUtil.GetConnection(); // Make sure your class & method use PascalCase
        }

        // Adds a new Courier record to the database
        public void AddCourier(Courier courier)
        {
            // Define the SQL query to insert a new courier record into the Couriers table
            using (SqlCommand cmd = new SqlCommand(@"INSERT INTO Couriers 
                (SenderName, SenderAddress, ReceiverName, ReceiverAddress, Weight, Status, TrackingNumber, DeliveryDate, UserId)
                VALUES (@SenderName, @SenderAddress, @ReceiverName, @ReceiverAddress, @Weight, @Status, @TrackingNumber, @DeliveryDate, @UserId)", _connection))
            {
                // Adding parameters to avoid SQL injection
                cmd.Parameters.AddWithValue("@SenderName", courier.SenderName);
                cmd.Parameters.AddWithValue("@SenderAddress", courier.SenderAddress);
                cmd.Parameters.AddWithValue("@ReceiverName", courier.ReceiverName);
                cmd.Parameters.AddWithValue("@ReceiverAddress", courier.ReceiverAddress);
                cmd.Parameters.AddWithValue("@Weight", courier.Weight);
                cmd.Parameters.AddWithValue("@Status", courier.Status);
                cmd.Parameters.AddWithValue("@TrackingNumber", courier.TrackingNumber);
                cmd.Parameters.AddWithValue("@DeliveryDate", courier.DeliveryDate);
                cmd.Parameters.AddWithValue("@UserId", courier.UserId);

                // Open the connection, execute the query, and close the connection
                _connection.Open();
                cmd.ExecuteNonQuery(); // Executes the insert query
                _connection.Close(); // Close the connection after execution
            }
        }

        // Retrieves all the Courier records from the database
        public List<Courier> GetAllCouriers()
        {
            List<Courier> couriers = new List<Courier>(); // List to hold the retrieved couriers

            // Define the SQL query to select all records from the Couriers table
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Couriers", _connection))
            {
                _connection.Open(); // Open the connection to the database
                SqlDataReader reader = cmd.ExecuteReader(); // Execute the query and get a data reader

                // Loop through all records in the data reader
                while (reader.Read())
                {
                    // Create a new Courier object for each row in the database
                    Courier courier = new Courier
                    {
                        CourierID = Convert.ToInt32(reader["CourierID"]),
                        SenderName = reader["SenderName"].ToString(),
                        SenderAddress = reader["SenderAddress"].ToString(),
                        ReceiverName = reader["ReceiverName"].ToString(),
                        ReceiverAddress = reader["ReceiverAddress"].ToString(),
                        Weight = Convert.ToDouble(reader["Weight"]),
                        Status = reader["Status"].ToString(),
                        TrackingNumber = reader["TrackingNumber"].ToString(),
                        DeliveryDate = Convert.ToDateTime(reader["DeliveryDate"]),
                        UserId = Convert.ToInt32(reader["UserId"])
                    };

                    // Add the newly created courier to the list
                    couriers.Add(courier);
                }

                _connection.Close(); // Close the connection after reading all data
            }

            // Return the list of all couriers
            return couriers;
        }
    }
}
