using CourierManagementSystem.Task2_LoopsIteration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem
{
    class Program_task2
    {

//        Task 2: Loops and Iteration 
//5. Write a Java program that uses a for loop to display all the orders for a specific customer.
//6. Implement a while loop to track the real-time location of a courier until it reaches its destination.


        public static void Main (string[] args)
        {
            // execution for Order class
            Console.WriteLine("=== Task 2: Loops and Iteration ===\n");

            // Create an instance of OrderViewer
            OrderViewer viewer = new OrderViewer();

            // Prompt the user to enter a customer email
            Console.Write("Enter customer email to view their orders: ");
            string email = Console.ReadLine();

            // Call method to display orders for the entered customer
            viewer.DisplayOrdersForCustomer(email);



            Console.WriteLine("=== Task 2 - Program 2: While Loop for Tracking ID Validation ===\n");

            TrackingValidator validator = new TrackingValidator();
            validator.ValidateTrackingId(); // Start validation process
        }
    }
}
