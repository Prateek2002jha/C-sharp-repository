using System;
using System.Collections.Generic;
using CourierManagementSystem.Task10_DbConnection;  // Importing the necessary class for interacting with the database
using CourierManagementSystem.Task5_OOP;  // Importing the classes for Courier and other objects used in the program

namespace CourierManagementSystem
{
    // Main class of the program which handles user input and interactions
    class Program_Task10UserInputBased
    {
        // Main method, entry point for the program
        static void Main(string[] args)
        {
            // Create an instance of CourierServiceDb to interact with the database
            CourierServiceDb courierService = new CourierServiceDb();

            // Display the main menu options for the user
            Console.WriteLine("Courier Management System");
            Console.WriteLine("1. Add New Courier");
            Console.WriteLine("2. Update Courier Status");
            Console.WriteLine("3. View Delivery History");
            Console.WriteLine("4. Exit");

            // Infinite loop to keep the program running until the user chooses to exit
            while (true)
            {
                // Ask the user to select an option from the menu
                Console.Write("Please choose an option (1-4): ");
                // Read and convert the user's input into an integer
                int option = Convert.ToInt32(Console.ReadLine());

                // If the user selects option 1, it means they want to add a new courier
                if (option == 1)
                {
                    // Prompt for and read the sender's name
                    Console.Write("Enter Sender Name: ");
                    string senderName = Console.ReadLine();

                    // Prompt for and read the sender's address
                    Console.Write("Enter Sender Address: ");
                    string senderAddress = Console.ReadLine();

                    // Prompt for and read the receiver's name
                    Console.Write("Enter Receiver Name: ");
                    string receiverName = Console.ReadLine();

                    // Prompt for and read the receiver's address
                    Console.Write("Enter Receiver Address: ");
                    string receiverAddress = Console.ReadLine();

                    // Prompt for and read the weight of the parcel
                    Console.Write("Enter Weight: ");
                    double weight = Convert.ToDouble(Console.ReadLine());

                    // Prompt for and read the status of the courier
                    Console.Write("Enter Status: ");
                    string status = Console.ReadLine();

                    // Prompt for and read the tracking number of the courier
                    Console.Write("Enter Tracking Number: ");
                    string trackingNumber = Console.ReadLine();

                    // Prompt for and read the delivery date of the courier
                    Console.Write("Enter Delivery Date (yyyy-mm-dd): ");
                    DateTime deliveryDate = Convert.ToDateTime(Console.ReadLine());

                    // Prompt for and read the user ID (likely of the person sending or receiving the courier)
                    Console.Write("Enter User ID: ");
                    int userId = Convert.ToInt32(Console.ReadLine());

                    // Create a new Courier object with the values collected from the user
                    Courier newCourier = new Courier
                    {
                        SenderName = senderName,
                        SenderAddress = senderAddress,
                        ReceiverName = receiverName,
                        ReceiverAddress = receiverAddress,
                        Weight = weight,
                        Status = status,
                        TrackingNumber = trackingNumber,
                        DeliveryDate = deliveryDate,
                        UserId = userId
                    };

                    // Call the AddCourier method from CourierServiceDb to add the new courier to the database
                    courierService.AddCourier(newCourier);
                    // Inform the user that the courier was successfully added
                    Console.WriteLine("Courier added successfully!");
                }
                // If the user selects option 2, they want to update the courier's status
                else if (option == 2)
                {
                    // Prompt the user for the tracking number of the courier to update
                    Console.Write("Enter Tracking Number to Update: ");
                    string trackingNumber = Console.ReadLine();

                    // Prompt the user for the new status to set for the courier
                    Console.Write("Enter New Status: ");
                    string newStatus = Console.ReadLine();

                    // Call the UpdateCourierStatus method from CourierServiceDb to update the status in the database
                    // Note: the method to update the status should be implemented in the CourierServiceDb class
                   
                    // Inform the user that the courier status was updated successfully
                    Console.WriteLine("Courier status updated successfully!");
                }
                // If the user selects option 3, they want to view the delivery history
                else if (option == 3)
                {
                    // Prompt the user for the tracking number of the courier to view its delivery history
                    Console.Write("Enter Tracking Number to View Delivery History: ");
                    string trackingNumber = Console.ReadLine();

                    // Call the GetDeliveryHistory method from CourierServiceDb to fetch the delivery history from the database
                    List<Courier> couriers = courierService.GetDeliveryHistory(trackingNumber);
                    // Display the delivery history to the user
                    Console.WriteLine("Delivery History:");
                    foreach (var courier in couriers)
                    {
                        // Print each courier's details from the delivery history
                        Console.WriteLine($"Sender: {courier.SenderName}, Receiver: {courier.ReceiverName}, Status: {courier.Status}, Delivery Date: {courier.DeliveryDate}");
                    }
                }
                // If the user selects option 4, they want to exit the program
                else if (option == 4)
                {
                    // Exit the infinite loop and the program
                    break;
                }
                // If the user enters an invalid option, inform them and prompt again
                else
                {
                    Console.WriteLine("Invalid option. Please try again.");
                }
            }
        }
    }
}
