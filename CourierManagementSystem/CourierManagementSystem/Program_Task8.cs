using System;
using System.Collections.Generic;
using CourierManagementSystem.Task8_Collections;  // For CourierCompanyCollection and CourierUserServiceCollectionImpl
using CourierManagementSystem.Task5_OOP;  // For Courier class
using CourierManagementSystem.Task6_Services;  // For ICourierUserService interface

namespace CourierManagementSystem
{
    // Task 8: Collections
    // Scope: ArrayList/Hashmap
    // Task: Improve the Courier Management System by using collections:
    // 1. Create a new model named CourierCompanyCollection in the entity package replacing the Array of
    //    Objects with List to accommodate dynamic updates in the CourierCompany class
    // 2. Create a new implementation class CourierUserServiceCollectionImpl class in the package dao 
    //    which implements ICourierUserService interface and holds a variable named companyObj of type CourierCompanyCollection

    class Program_Task8
    {
        static void Main(string[] args)
        {
            // Instantiate the service which implements ICourierUserService
            ICourierUserService service = new CourierUserServiceCollectionImpl();

            // Input the Courier details from the user
            Console.Write("Enter Courier ID: ");
            int courierId = int.Parse(Console.ReadLine());

            Console.Write("Enter Sender Name: ");
            string senderName = Console.ReadLine();

            Console.Write("Enter Sender Address: ");
            string senderAddress = Console.ReadLine();

            Console.Write("Enter Receiver Name: ");
            string receiverName = Console.ReadLine();

            Console.Write("Enter Receiver Address: ");
            string receiverAddress = Console.ReadLine();

            Console.Write("Enter Weight of Courier: ");
            double weight = double.Parse(Console.ReadLine());

            Console.Write("Enter Status of Courier: ");
            string status = Console.ReadLine();

            Console.Write("Enter Tracking Number: ");
            string trackingNumber = Console.ReadLine();

            Console.Write("Enter Estimated Delivery Date (YYYY-MM-DD): ");
            DateTime estimatedDeliveryDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter Assigned Employee ID: ");
            int employeeId = int.Parse(Console.ReadLine());

            // Create a new Courier object using the user input
            Courier courier = new Courier(
                courierId,                  // Courier ID
                senderName,                 // Sender Name
                senderAddress,              // Sender Address
                receiverName,               // Receiver Name
                receiverAddress,            // Receiver Address
                weight,                     // Weight of the courier
                status,                     // Status of the courier
                trackingNumber,             // Tracking number
                estimatedDeliveryDate,      // Estimated delivery date
                employeeId                  // Assigned employee ID
            );

            // Place the courier order and capture the tracking number
            string placedTrackingNumber = service.PlaceOrder(courier);
            // Output the tracking number to the console
            Console.WriteLine($"Courier placed with tracking number: {placedTrackingNumber}");

            // Fetch the current status of the courier using the tracking number
            string orderStatus = service.GetOrderStatus(placedTrackingNumber);
            // Output the courier's status to the console
            Console.WriteLine($"Courier status: {orderStatus}");

            // Output a message indicating the start of assigned orders listing
            Console.WriteLine("All orders for courier staff ID 101:");

            // Get all orders assigned to courier staff with ID 101
            var assignedOrders = service.GetAssignedOrders(101);

            // Iterate through the assigned orders and print them to the console
            foreach (var order in assignedOrders)
            {
                Console.WriteLine(order);
            }
        }
    }
}
