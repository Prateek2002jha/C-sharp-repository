using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem.Task4_StringsArraysFunctions
{

//    9. Parcel Tracking: Create a program that allows users to input a parcel tracking number.Store the 
//    tracking number and Status in 2d String Array.Initialize the array with values. Then, simulate the
//    tracking process by displaying messages like "Parcel in transit," "Parcel out for delivery," or "Parcel 
//delivered" based on the tracking number's status. 
    public class ParcelTrackingSystem
    {
        // 2D string array to store tracking number and parcel status
        private string[,] trackingData = new string[,]
        {
            { "P123", "In Transit" },
            { "P456", "Out for Delivery" },
            { "P789", "Delivered" },
            { "P321", "In Transit" },
        };

        // Method to track parcel based on tracking number input
        public void TrackParcel(string trackingNumber)
        {
            bool found = false;

            // Loop through each row in the 2D array
            for (int i = 0; i < trackingData.GetLength(0); i++)
            {
                // If tracking number matches
                if (trackingData[i, 0].Equals(trackingNumber, StringComparison.OrdinalIgnoreCase))
                {
                    string status = trackingData[i, 1];
                    Console.WriteLine($"Tracking Number: {trackingNumber} ➤ Status: {status}");

                    // Simulate message based on status
                    switch (status.ToLower())
                    {
                        case "in transit":
                            Console.WriteLine("Your parcel is on the way.");
                            break;
                        case "out for delivery":
                            Console.WriteLine("Your parcel is out for delivery and will arrive soon.");
                            break;
                        case "delivered":
                            Console.WriteLine("Your parcel has been delivered.");
                            break;
                        default:
                            Console.WriteLine("Status unknown.");
                            break;
                    }

                    found = true;
                    break;
                }
            }

            // If no tracking number matches
            if (!found)
            {
                Console.WriteLine("Tracking number not found.");
            }
        }
    }
}
