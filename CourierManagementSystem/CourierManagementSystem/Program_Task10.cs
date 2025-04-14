using System;
using System.Collections.Generic;
using CourierManagementSystem.Task5_OOP;  // Importing the object-oriented classes (Courier, Employee, etc.)
using CourierManagementSystem.Task10_DbConnection;  // Importing the classes for database interaction

namespace CourierManagementSystem
{
    // Main program class for testing CourierServiceDb and EmployeeRepository functionality
    class Program_Task10
    {
        // Entry point of the program
        static void Main(string[] args)
        {
            // Create an instance of CourierServiceDb to interact with the database for couriers
            CourierServiceDb courierService = new CourierServiceDb();

            // 1. Insert a new courier into the database
            Courier newCourier = new Courier
            {
                SenderName = "Prateek Jha",  // Sender's name
                SenderAddress = "123 Street, Pune, India",  // Sender's address
                ReceiverName = "Mihir Jha",  // Receiver's name
                ReceiverAddress = "456 Avenue, Pune, India",  // Receiver's address
                Weight = 5.0,  // Weight of the parcel in kg
                Status = "In Transit",  // Initial status of the courier
                TrackingNumber = "TRACK12346",  // Unique tracking number
                DeliveryDate = DateTime.Now.AddDays(7),  // Delivery date set to 7 days from the current date
                UserId = 2  // ID of the user associated with the courier (could be customer ID)
            };

            // Call the InsertCourier method from CourierServiceDb to add the courier to the database
            courierService.InsertCourier(newCourier);
            // Inform the user that the courier was added successfully
            Console.WriteLine("Courier inserted successfully!");

            // 2. Update the status of a specific courier (status of courier with ID 1 is updated to "Delivered")
            courierService.UpdateCourierStatus(1, "Delivered");
            // Inform the user that the courier's status was updated
            Console.WriteLine("Courier status updated to 'Delivered'!");

            // 3. Retrieve the delivery history for a specific tracking number
            var history = courierService.GetDeliveryHistory("TRACK12345");
            Console.WriteLine("Delivery History for tracking number 'TRACK12345':");
            // Loop through the delivery history and display the details of each courier
            foreach (var courier in history)
            {
                Console.WriteLine($"Courier ID: {courier.CourierID}, Status: {courier.Status}, Delivery Date: {courier.DeliveryDate}");
            }

            // 4. Retrieve the shipment status report for a specific date range
            var shipmentReport = courierService.GetShipmentStatusReport(DateTime.Now.AddDays(-10), DateTime.Now.AddDays(10));
            Console.WriteLine("Shipment Status Report:");
            // Loop through the shipment status report and display the details of each courier within the specified date range
            foreach (var courier in shipmentReport)
            {
                Console.WriteLine($"Courier ID: {courier.CourierID}, Status: {courier.Status}, Delivery Date: {courier.DeliveryDate}");
            }

            // Test the EmployeeRepository functionality

            // Create an instance of EmployeeRepository to interact with employee data in the database
            EmployeeRepository employeeRepository = new EmployeeRepository();

            // 5. Add a new employee to the database
            Employee newEmployee = new Employee
            {
                EmployeeName = "Aarya Patil",  // Employee's name
                Email = "aaryapatil@gmail.com",  // Employee's email address
                ContactNumber = "123445443",  // Employee's contact number
                Role = "Courier Dealer",  // Employee's role within the company
                Salary = 900000  // Employee's salary
            };

            // Call the AddEmployee method from EmployeeRepository to add the new employee to the database
            employeeRepository.AddEmployee(newEmployee);
            // Inform the user that the employee was added successfully
            Console.WriteLine("Employee added successfully!");

            // 6. Retrieve and display all employees in the company
            var employees = employeeRepository.GetAllEmployees();
            Console.WriteLine("Employee List:");
            // Loop through the list of employees and display their details
            foreach (var employee in employees)
            {
                Console.WriteLine($"Employee ID: {employee.EmployeeID}, Name: {employee.EmployeeName}, Role: {employee.Role}");
            }

            // Wait for user input before closing the console window
            Console.ReadKey();
        }
    }
}
