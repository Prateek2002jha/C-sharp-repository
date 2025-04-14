using System;
using System.Collections.Generic;
using CourierManagementSystem.Task5_OOP;  // For Courier and CourierCompany classes
using CourierManagementSystem.Task6_Services; // For ICourierUserService interface

namespace CourierManagementSystem.Task9_ServiceImpl
{
    // Implementation of ICourierUserService interface
    public class CourierUserServiceImpl : ICourierUserService
    {
        // Protected member to access the CourierCompany object
        protected CourierCompany companyObj = new CourierCompany();

        // Method to place an order for a courier and generate a unique tracking number
        public string PlaceOrder(Courier courierObj)
        {
            // Generate a random tracking number for the courier
            string trackingNumber = "TRK" + new Random().Next(1000, 9999);
            courierObj.TrackingNumber = trackingNumber; // Assign the generated tracking number to the courier
            courierObj.Status = "Yet to Transit"; // Set the initial status of the courier
            companyObj.AddCourier(courierObj); // Add the courier to the company
            return trackingNumber; // Return the tracking number
        }

        // Method to get the current status of a courier based on the tracking number
        public string GetOrderStatus(string trackingNumber)
        {
            // Iterate through all couriers in the company to find the one with the matching tracking number
            foreach (var c in companyObj.GetCouriers())
            {
                if (c != null && c.TrackingNumber == trackingNumber)
                    return c.Status; // Return the status of the courier if found
            }
            return "Tracking Number Not Found"; // Return an error message if courier is not found
        }

        // Method to cancel an order by removing the courier with the given tracking number
        public bool CancelOrder(string trackingNumber)
        {
            return companyObj.RemoveCourier(trackingNumber); // Call the company object to remove the courier
        }

        // Method to get all orders assigned to a specific courier staff by their ID
        public List<Courier> GetAssignedOrders(int courierStaffId)
        {
            List<Courier> assigned = new List<Courier>(); // List to hold assigned couriers
            // Iterate through all couriers and add the ones with the matching courier staff ID to the list
            foreach (var c in companyObj.GetCouriers())
            {
                if (c != null && c.UserId == courierStaffId)
                    assigned.Add(c);
            }
            return assigned; // Return the list of assigned couriers
        }
    }
}
