using System;
using System.Collections.Generic;
using System.Linq;
using CourierManagementSystem.Task5_OOP;  // For Employee and Courier classes
using CourierManagementSystem.Task6_Services; // For ICourierAdminService interface

namespace CourierManagementSystem.Task9_ServiceImpl
{
    // CourierAdminServiceImpl class that implements ICourierAdminService interface
    // It inherits from CourierUserServiceImpl to access user-level functionality
    public class CourierAdminServiceImpl : CourierUserServiceImpl, ICourierAdminService
    {
        // Method to remove a courier from the company's list using the tracking number
        public void RemoveCourier(string trackingNumber)
        {
            // Attempting to find the courier in the CourierDetails list by tracking number
            Courier courierToRemove = companyObj.CourierDetails
                .FirstOrDefault(c => c.TrackingNumber == trackingNumber);

            // If courier is found, remove it from the list and display a success message
            if (courierToRemove != null)
            {
                companyObj.CourierDetails.Remove(courierToRemove);
                Console.WriteLine($"Courier with tracking number {trackingNumber} removed.");
            }
            else
            {
                // If courier not found, display an error message
                Console.WriteLine($"Courier with tracking number {trackingNumber} not found.");
            }
        }

        // Method to view and display all couriers in the company's list
        public void ViewAllCouriers()
        {
            Console.WriteLine("----- All Couriers -----");
            // Looping through all couriers in CourierDetails and displaying each one
            foreach (var courier in companyObj.CourierDetails)
            {
                Console.WriteLine(courier);
            }
        }

        // Method to add a new courier staff member (employee) to the company
        public int AddCourierStaff(Employee employee)
        {
            // Adding the new employee to the EmployeeDetails list
            companyObj.EmployeeDetails.Add(employee);
            Console.WriteLine($"New employee added: {employee.EmployeeName} (ID: {employee.EmployeeID})");

            // Returning 1 to indicate success (or any meaningful status code)
            return 1;
        }
    }
}
