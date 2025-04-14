using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem.Task3_ArraysAndDS
{
    public class ParcelTracker
    {
        private string[] trackingHistory;  // Array to store tracking history

        public ParcelTracker()
        {
            // Sample tracking history (location updates of the parcel)
            trackingHistory = new string[]
            {
            "Warehouse - Delhi",  // Initial location of parcel
            "Dispatched - Delhi",  // Parcel dispatched from Delhi
            "Arrived - Jaipur Hub",  // Parcel arrived at Jaipur hub
            "In Transit - Udaipur",  // Parcel in transit to Udaipur
            "Delivered - Udaipur"  // Parcel delivered at Udaipur
            };
        }

        // Method to display the entire tracking history
        public void DisplayTrackingHistory()
        {
            Console.WriteLine("Parcel Tracking History:");
            // Iterate over tracking history and print each update
            foreach (string location in trackingHistory)
            {
                Console.WriteLine("- " + location);  // Display each tracking update
            }
        }
    }
}