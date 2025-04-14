using System;
using System.Data.SqlClient;
using System.Configuration;

namespace CourierManagementSystem.Task10_DbConnection
{
    public static class ConnectionUtil
    {
        // Static variable to hold the connection object
        private static SqlConnection _connection;

        // Static method to get the connection object
        public static SqlConnection GetConnection()
        {
            if (_connection == null)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["CourierDB"].ConnectionString;
                _connection = new SqlConnection(connectionString);
            }
            return _connection;
        }
    }
}
