using CourierManagementSystem.Task5_OOP;
using System;
using System.Collections.Generic;

namespace CourierManagementSystem
{
    class Program_Task5
    {
        static void Main()
        {
            // Creating a few User objects
            User user1 = new User(101L, "Aarav Patel", "aarav.patel@email.com", "password123", "+91 9876543210", "123, ABC Street, Mumbai");
            User user2 = new User(102L, "Priya Sharma", "priya.sharma@email.com", "password123", "+91 9876543211", "456, DEF Lane, Pune");

            // Creating a few Location objects
            Location location1 = new Location(1L, "Mumbai", "123, ABC Street, Mumbai");
            Location location2 = new Location(2L, "Pune", "456, DEF Lane, Pune");

            // Creating a few Employee objects
            Employee emp1 = new Employee(1L, "Ravi Kumar", "ravi.kumar@email.com", "+91 9876543200", "Delivery Manager", 60000);
            Employee emp2 = new Employee(2L, "Neha Gupta", "neha.gupta@email.com", "+91 9876543201", "Courier", 40000);

            // Creating a CourierCompany
            List<Courier> couriers = new List<Courier>();
            List<Employee> employees = new List<Employee> { emp1, emp2 };
            List<Location> locations = new List<Location> { location1, location2 };
            CourierCompany company = new CourierCompany("XYZ Courier", couriers, employees, locations);

            // Creating a few Courier objects
            Courier courier1 = new Courier(201L, "Rajesh Kumar", "5, XYZ Road, Delhi", "Priya Sharma", "456, DEF Lane, Pune", 10.5, "In Transit", "TRACK12345", DateTime.Now.AddDays(3), user1.UserID);
            Courier courier2 = new Courier(202L, "Suresh Patel", "12, PQR Street, Delhi", "Aarav Patel", "789, GHI Road, Mumbai", 5.0, "Delivered", "TRACK12346", DateTime.Now.AddDays(2), user2.UserID);

            // Adding couriers to the CourierCompany
            company.AddCourier(courier1);
            company.AddCourier(courier2);

            // Displaying details
            Console.WriteLine("Courier Company Details:");
            Console.WriteLine(company.ToString());
            Console.WriteLine("\nCouriers:");
            foreach (var courier in company.GetCouriers())
            {
                Console.WriteLine(courier.ToString());
            }

            // Removing a courier by tracking number
            string trackingNumberToRemove = "TRACK12345";
            if (company.RemoveCourier(trackingNumberToRemove))
            {
                Console.WriteLine($"\nCourier with tracking number {trackingNumberToRemove} has been removed.");
            }
            else
            {
                Console.WriteLine($"\nCourier with tracking number {trackingNumberToRemove} not found.");
            }

            // Displaying the updated couriers list
            Console.WriteLine("\nUpdated Couriers List:");
            foreach (var courier in company.GetCouriers())
            {
                Console.WriteLine(courier.ToString());
            }

            Console.ReadKey();
        }
    }
}
