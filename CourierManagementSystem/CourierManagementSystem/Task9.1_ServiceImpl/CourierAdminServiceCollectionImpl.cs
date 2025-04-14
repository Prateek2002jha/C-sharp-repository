using System;
using System.Collections.Generic;
using CourierManagementSystem.Task5_OOP;  // For Employee and Courier classes
using CourierManagementSystem.Task6_Services; // For ICourierAdminService interface
using CourierManagementSystem.Task8_Collections; // For CourierCompanyCollection and CourierUserServiceCollectionImpl classes

namespace CourierManagementSystem.Task9_ServiceImplCollection
{
    // CourierAdminServiceCollectionImpl class that implements the ICourierAdminService interface
    // It inherits from CourierUserServiceCollectionImpl to access user-level functionality
    public class CourierAdminServiceCollectionImpl : CourierUserServiceCollectionImpl, ICourierAdminService
    {
        // Constructor that initializes companyObj (a CourierCompanyCollection object)
        public CourierAdminServiceCollectionImpl()
        {
            // Initializing the companyObj to hold courier and employee data
            companyObj = new CourierCompanyCollection(); // Accessing protected member from base class
        }

        // Method to add a new employee (Courier Staff)
        public int AddCourierStaff(Employee employee)
        {
            // Adding the employee to the EmployeeDetails list in companyObj
            companyObj.EmployeeDetails.Add(employee);

            // Outputting a success message to the console
            Console.WriteLine($"Employee {employee.EmployeeName} (ID: {employee.EmployeeID}) added successfully.");

            // Returning 1 to indicate success (you can change this return value as needed)
            return 1;
        }

        // Method to remove a courier based on the tracking number
        public bool RemoveCourier(string trackingNumber)
        {
            // Finding the courier with the given tracking number in the CourierDetails list
            Courier courierToRemove = companyObj.CourierDetails.Find(c => c.TrackingNumber == trackingNumber);

            // If the courier is found, remove it from the list
            if (courierToRemove != null)
            {
                companyObj.CourierDetails.Remove(courierToRemove);

                // Outputting a success message to the console
                Console.WriteLine($"Courier with Tracking Number {trackingNumber} removed.");
                return true; // Return true to indicate successful removal
            }

            // If the courier was not found, output an error message
            Console.WriteLine($"Courier with Tracking Number {trackingNumber} not found.");
            return false; // Return false to indicate failure
        }

        // Method to retrieve all the employees in the company
        public List<Employee> GetAllEmployees()
        {
            // Returning the list of all employees from the EmployeeDetails in companyObj
            return companyObj.EmployeeDetails;
        }

        // Method to retrieve all the couriers in the company
        public List<Courier> GetAllCouriers()
        {
            // Returning the list of all couriers from the CourierDetails in companyObj
            return companyObj.CourierDetails;
        }
    }
}
