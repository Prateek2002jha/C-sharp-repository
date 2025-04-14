using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CourierManagementSystem.Task5_OOP;  // Importing the object-oriented Courier class

namespace CourierManagementSystem.Task10_DbConnection
{
    // This class provides functionality to interact with the Courier database table
    // It allows inserting couriers, updating courier statuses, and retrieving courier information.
    public class CourierServiceDb
    {
        private SqlConnection connection;  // SQL connection object

        // Constructor initializes the connection to the database using ConnectionUtil
        public CourierServiceDb()
        {
            connection = ConnectionUtil.GetConnection();  // Get the database connection
        }

        // Insert a new courier into the database
        public void InsertCourier(Courier courier)
        {
            // SQL query to insert a new courier into the Couriers table
            string query = @"INSERT INTO Couriers (SenderName, SenderAddress, ReceiverName, ReceiverAddress, Weight, Status, TrackingNumber, DeliveryDate, UserId)
                             VALUES (@SenderName, @SenderAddress, @ReceiverName, @ReceiverAddress, @Weight, @Status, @TrackingNumber, @DeliveryDate, @UserId)";

            // Execute the query using a SqlCommand object
            using (SqlCommand cmd = new SqlCommand(query, connection))
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
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        // Add courier method - internally calls InsertCourier to insert the courier into the database
        public void AddCourier(Courier courier)
        {
            InsertCourier(courier);  // Inserts the courier data into the database
        }

        // Update the courier status based on the courier ID
        public void UpdateCourierStatus(int courierId, string status)
        {
            // SQL query to update the courier status based on courier ID
            string query = @"UPDATE Couriers SET Status = @Status WHERE CourierID = @CourierID";

            // Execute the query using a SqlCommand object
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                // Adding parameters for status and courier ID
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@CourierID", courierId);

                // Open the connection, execute the update query, and close the connection
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        // Retrieve the delivery history for a given tracking number
        public List<Courier> GetDeliveryHistory(string trackingNumber)
        {
            List<Courier> couriers = new List<Courier>();  // List to store retrieved couriers

            // SQL query to get all couriers with the specified tracking number
            string query = @"SELECT * FROM Couriers WHERE TrackingNumber = @TrackingNumber";

            // Execute the query using a SqlCommand object
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                // Adding parameter for tracking number
                cmd.Parameters.AddWithValue("@TrackingNumber", trackingNumber);

                // Open the connection, execute the query, and read the results
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                // Loop through the result set and create Courier objects
                while (reader.Read())
                {
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

                    couriers.Add(courier);  // Add each courier object to the list
                }

                // Close the connection
                connection.Close();
            }

            // Return the list of couriers with the specified tracking number
            return couriers;
        }

        // Generate a shipment status report for couriers within a specified date range
        public List<Courier> GetShipmentStatusReport(DateTime startDate, DateTime endDate)
        {
            List<Courier> couriers = new List<Courier>();  // List to store retrieved couriers

            // SQL query to get couriers with delivery dates between the specified date range
            string query = @"SELECT * FROM Couriers WHERE DeliveryDate BETWEEN @StartDate AND @EndDate";

            // Execute the query using a SqlCommand object
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                // Adding parameters for start date and end date
                cmd.Parameters.AddWithValue("@StartDate", startDate);
                cmd.Parameters.AddWithValue("@EndDate", endDate);

                // Open the connection, execute the query, and read the results
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                // Loop through the result set and create Courier objects
                while (reader.Read())
                {
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

                    couriers.Add(courier);  // Add each courier object to the list
                }

                // Close the connection
                connection.Close();
            }

            // Return the list of couriers within the specified date range
            return couriers;
        }
    }
}
