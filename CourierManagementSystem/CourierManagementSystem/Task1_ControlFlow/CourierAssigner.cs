using System;
using System.Collections.Generic;

namespace CourierManagementSystem.Task1
{
    // This class is responsible for assigning a courier based on parcel weight using basic control flow
    public class CourierAssigner
    {
        public static void AssignCourier()
        {
            // Create a sample list of couriers with their names and carrying capacities
            var couriers = new List<Courier>
            {
                new Courier { Name = "Ravi", Capacity = 10 },  // Ravi can carry up to 10kg
                new Courier { Name = "Arjun", Capacity = 5 },  // Arjun can carry up to 5kg
                new Courier { Name = "Pooja", Capacity = 8 }   // Pooja can carry up to 8kg
            };

            Console.WriteLine("Enter parcel weight:");
            double parcelWeight = Convert.ToDouble(Console.ReadLine());  // Take parcel weight from user input

            bool assigned = false;  // Track if any courier is assigned

            // Loop through the list of couriers
            foreach (var courier in couriers)
            {
                // If courier has enough capacity to carry the parcel
                if (courier.Capacity >= parcelWeight)
                {
                    Console.WriteLine($"Courier '{courier.Name}' assigned to deliver the parcel.");
                    assigned = true;
                    break;  // Exit loop once courier is assigned
                }
            }

            // If no courier found with enough capacity
            if (!assigned)
            {
                Console.WriteLine("No available courier with enough capacity to deliver the parcel.");
            }
        }

        // Inner class representing a Courier with Name and Capacity properties
        private class Courier
        {
            public string Name { get; set; }
            public double Capacity { get; set; } // Maximum parcel weight they can carry
        }
    }
}
