using CourierManagementSystem.Task3_ArraysAndDS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem
{


    
//        Task 3: Arrays and Data Structures
//7. Create an array to store the tracking history of a parcel, where each entry represents a location
//update.
//8. Implement a method to find the nearest available courier for a new order using an array of couriers.
    class Program_task3

    {
        static void Main(string[] args)
        {
            // 7. Display parcel tracking history
            ParcelTracker tracker = new ParcelTracker();
            tracker.DisplayTrackingHistory();

            Console.WriteLine("\n");

            // 8. Find nearest available courier
            CourierFinder finder = new CourierFinder();
            Courier nearestCourier = finder.FindNearestAvailableCourier();

            if (nearestCourier != null)
            {
                Console.WriteLine("Nearest available courier found:");
                Console.WriteLine(nearestCourier);
            }
            else
            {
                Console.WriteLine("No courier is currently available.");
            }

            Console.ReadKey();
        }

    }
}
