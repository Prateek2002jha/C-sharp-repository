using CourierManagementSystem.Task1;
using CourierManagementSystem.Task1_ControlFlow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// This is for Task 1
//            Task 1: Control Flow Statements 
//1. Write a program that checks whether a given order is delivered or not based on its status (e.g., 
//"Processing," "Delivered," "Cancelled"). Use if-else statements for this. 
//© Hexaware Technologies Limited. All rights www.hexaware.com
//2. Implement a switch-case statement to categorize parcels based on their weight into "Light," 
//"Medium," or "Heavy." 
//3. Implement User Authentication 1. Create a login system for employees and customers using Java 
//control flow statements. 
//4. Implement Courier Assignment Logic 1. Develop a mechanism to assign couriers to shipments based 
//on predefined criteria (e.g., proximity, load capacity) using loops. 
namespace CourierManagementSystem
{
    // Main class that runs all the implemented tasks for Task 1: Control Flow Statements
    class Program_Task1
    {
        static void Main(string[] args)
        {
            // This program checks if an order is delivered or not, categorizes parcels by weight,
            // implements user authentication, and assigns couriers to shipments.

            // Example usage of the OrderStatusChecker class:
            // This class checks the status of an order based on the input (delivered, processing, cancelled).
            var checker = new CourierManagementSystem.Task1_ControlFlow.OrderStatusChecker();

            Console.Write("Enter order status: ");
            string inputStatus = Console.ReadLine();

            // Check the status of the order (uses if-else statements)
            checker.CheckStatus(inputStatus);

            // Example usage of the ParcelWeightCategorizer class:
            // This class categorizes the parcel weight into Light, Medium, or Heavy based on predefined weight ranges.
            ParcelWeightCategorizer categorizer = new ParcelWeightCategorizer();
            categorizer.CategorizeWeight(3.5); // Example weight for categorization (Medium)

            // Example usage of the UserAuthenticator class:
            // This class implements a login system for employees and customers using hardcoded credentials.
            UserAuthenticator authenticator = new UserAuthenticator();
            authenticator.AuthenticateUser();

            // Example usage of the CourierAssigner class:
            // This class assigns a courier to a parcel based on its weight, using a loop to check for capacity.
            CourierAssigner.AssignCourier();

            // Wait for user input to keep the console open
            Console.ReadKey();
        }
    }
}
