using System;
using System.Collections.Generic;
using CourierManagementSystem.Task5_OOP;
using CourierManagementSystem.Task6_Services;
using CourierManagementSystem.Task8_Collections;
using CourierManagementSystem.Task9_ServiceImpl;

namespace CourierManagementSystem
{
    class Program_Task9
    {
        static void Main()
        {
            // Create user and admin service objects
            CourierUserServiceImpl userService = new CourierUserServiceImpl();
            CourierAdminServiceImpl adminService = new CourierAdminServiceImpl();

            // Adding employees with user input
            Console.WriteLine("Adding employees...");

            // Employee 1
            Console.WriteLine("Enter Employee 1 details:");
            Console.Write("Employee ID: ");
            int empId1 = int.Parse(Console.ReadLine());
            Console.Write("Employee Name: ");
            string empName1 = Console.ReadLine();
            Console.Write("Employee Email: ");
            string empEmail1 = Console.ReadLine();
            Console.Write("Employee Phone: ");
            string empPhone1 = Console.ReadLine();
            Console.Write("Employee Position: ");
            string empPosition1 = Console.ReadLine();
            Console.Write("Employee Salary: ");
            double empSalary1 = double.Parse(Console.ReadLine());  // Salary is now double

            adminService.AddCourierStaff(new Employee(empId1, empName1, empEmail1, empPhone1, empPosition1, empSalary1));

            // Employee 2
            Console.WriteLine("Enter Employee 2 details:");
            Console.Write("Employee ID: ");
            int empId2 = int.Parse(Console.ReadLine());
            Console.Write("Employee Name: ");
            string empName2 = Console.ReadLine();
            Console.Write("Employee Email: ");
            string empEmail2 = Console.ReadLine();
            Console.Write("Employee Phone: ");
            string empPhone2 = Console.ReadLine();
            Console.Write("Employee Position: ");
            string empPosition2 = Console.ReadLine();
            Console.Write("Employee Salary: ");
            double empSalary2 = double.Parse(Console.ReadLine());  // Salary is now double

            adminService.AddCourierStaff(new Employee(empId2, empName2, empEmail2, empPhone2, empPosition2, empSalary2));

            // Placing courier orders with user input
            Console.WriteLine("Placing couriers...");

            // Courier 1
            Console.WriteLine("Enter details for Courier 1:");
            Console.Write("Sender Name: ");
            string senderName1 = Console.ReadLine();
            Console.Write("Sender Address: ");
            string senderAddress1 = Console.ReadLine();
            Console.Write("Receiver Name: ");
            string receiverName1 = Console.ReadLine();
            Console.Write("Receiver Address: ");
            string receiverAddress1 = Console.ReadLine();
            Console.Write("Courier Weight (in kg): ");
            double weight1 = double.Parse(Console.ReadLine());  // Corrected to double

            Console.Write("Estimated Delivery Date (yyyy-mm-dd): ");
            DateTime deliveryDate1 = DateTime.Parse(Console.ReadLine());

            userService.PlaceOrder(new Courier(empId1, senderName1, senderAddress1, receiverName1, receiverAddress1, weight1, "Pending", "TRK101", deliveryDate1, empId1));

            // Courier 2
            Console.WriteLine("Enter details for Courier 2:");
            Console.Write("Sender Name: ");
            string senderName2 = Console.ReadLine();
            Console.Write("Sender Address: ");
            string senderAddress2 = Console.ReadLine();
            Console.Write("Receiver Name: ");
            string receiverName2 = Console.ReadLine();
            Console.Write("Receiver Address: ");
            string receiverAddress2 = Console.ReadLine();
            Console.Write("Courier Weight (in kg): ");
            double weight2 = double.Parse(Console.ReadLine());  // Corrected to double

            Console.Write("Estimated Delivery Date (yyyy-mm-dd): ");
            DateTime deliveryDate2 = DateTime.Parse(Console.ReadLine());

            userService.PlaceOrder(new Courier(empId2, senderName2, senderAddress2, receiverName2, receiverAddress2, weight2, "Shipped", "TRK102", deliveryDate2, empId2));

            // Get assigned orders for an employee (user input)
            Console.Write("Enter Employee ID to view assigned orders: ");
            int empIdForOrders = int.Parse(Console.ReadLine());

            Console.WriteLine($"Assigned orders for employee ID {empIdForOrders}:");
            List<Courier> assignedOrders = userService.GetAssignedOrders(empIdForOrders);
            foreach (var order in assignedOrders)
            {
                Console.WriteLine(order);
            }

            Console.ReadLine();  // Wait for user input before closing
        }
    }
}
