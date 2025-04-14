using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem.Task3_ArraysAndDS
{
    public class Courier
    {
        public string Name { get; set; }  // Courier's name
        public string Location { get; set; }  // Courier's location
        public bool IsAvailable { get; set; }  // Availability status of the courier

        // Override ToString method to display courier information for nice
        // formatting when the Courier object is called upon
        public override string ToString()
        {
            return $"Name: {Name}, Location: {Location}, Available: {IsAvailable}";

        }
    }

    // CourierFinder class to handle courier search functionality
    public class CourierFinder// it is also called as helper class for courier
    {
        private Courier[] couriers;  // Array to store couriers

        public CourierFinder()
        {
            // Initialize the sample array of couriers with their data
            couriers = new Courier[]
            {
            new Courier { Name = "Ravi", Location = "Delhi", IsAvailable = false },  // Courier Ravi is not available
            new Courier { Name = "Ankit", Location = "Jaipur", IsAvailable = true },  // Courier Ankit is available
            new Courier { Name = "Sneha", Location = "Udaipur", IsAvailable = true }  // Courier Sneha is available
            }; // here ravi is not available and ankit and sneha are availabe
        }

        // Method to find the first available courier in the list
        public Courier FindNearestAvailableCourier()
        {
            // Iterate over the couriers and return the first available one
            foreach (Courier courier in couriers)
            {
                if (courier.IsAvailable)
                    return courier;  // Return the first available courier
            }

            return null;  // Return null if no courier is available
        }
    }
}
