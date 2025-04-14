using System;

namespace CourierManagementSystem.Task1_ControlFlow
{
    // Class to check and display the status of a courier order
    class OrderStatusChecker
    {
        // Method to check status based on input string
        public void CheckStatus(string status)
        {
            // Compares input with different status options (case-insensitive)
            if (status.Equals("delivered", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("The order has been delivered.");
            }
            else if (status.Equals("processing", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("The order is still being processed.");
            }
            else if (status.Equals("cancelled", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("The order has been cancelled.");
            }
            else
            {
                // If the input doesn't match any known status
                Console.WriteLine("Invalid status. Please check again.");
            }
        }
    }
}
