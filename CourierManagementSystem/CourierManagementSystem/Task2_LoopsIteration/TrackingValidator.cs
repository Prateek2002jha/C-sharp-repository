using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem.Task2_LoopsIteration
{
    class TrackingValidator
    {

        // List of valid tracking IDs
        private List<string> validTrackingIds = new List<string>
        {
            "1001",
            "1002",
            "1003",
            "1004"
        };

        // Method to validate user input using a while loop
        public void ValidateTrackingId()
        {
            string input;
            bool isValid = false;

            Console.WriteLine("=== Tracking ID Validator ===");

            // Keep prompting until valid input is received
            while (!isValid)// runs till isValid becomes true
            {
                Console.Write("Enter your Tracking ID: ");
                input = Console.ReadLine();

                // Check if input matches any valid tracking ID (case-insensitive)
                foreach (var id in validTrackingIds)
                {
                    if (id.Equals(input, StringComparison.OrdinalIgnoreCase))
                    {
                        isValid = true;
                        break;
                    }
                }

                if (!isValid)
                {
                    Console.WriteLine("Invalid Tracking ID. Please try again.\n");
                }
            }

            Console.WriteLine("Tracking ID validated successfully!");
        }
    }
}
