using CourierManagementSystem.Task8_Collections;
using CourierManagementSystem.Task6_Services;
using System;
using System.Collections.Generic;
using System.Linq;
using CourierManagementSystem.Task5_OOP;  // Assuming Courier class is here

namespace CourierManagementSystem.Task8_Collections
{
    // Implementation of ICourierUserService using collections
    public class CourierUserServiceCollectionImpl : ICourierUserService
    {
        // A reference to the CourierCompanyCollection that holds company data
        protected CourierCompanyCollection companyObj;

        // Constructor to initialize the CourierCompanyCollection
        public CourierUserServiceCollectionImpl()
        {
            // Creating a new company with the name "MyCourierCompany"
            companyObj = new CourierCompanyCollection("MyCourierCompany");
        }

        // Method to place a new courier order
        public string PlaceOrder(Courier courierObj)
        {
            // Add the new courier to the company list (simulating order placement)
            companyObj.CourierDetails.Add(courierObj);
            // Return the tracking number for the new courier order
            return courierObj.TrackingNumber;
        }

        // Method to get the current status of a courier based on its tracking number
        public string GetOrderStatus(string trackingNumber)
        {
            // Search for the courier using the tracking number in the list of couriers
            var courier = companyObj.CourierDetails.FirstOrDefault(c => c.TrackingNumber == trackingNumber);
            // Return the status if found, otherwise a message saying "Tracking number not found."
            return courier != null ? courier.Status : "Tracking number not found.";
        }

        // Method to cancel a courier order using the tracking number
        public bool CancelOrder(string trackingNumber)
        {
            // Find the courier using the tracking number
            var courier = companyObj.CourierDetails.FirstOrDefault(c => c.TrackingNumber == trackingNumber);
            if (courier != null)
            {
                // Remove the courier from the list if found
                companyObj.CourierDetails.Remove(courier);
                return true;  // Return true indicating the order was successfully canceled
            }
            return false;  // Return false if the order was not found
        }

        // Method to get all orders assigned to a specific courier staff member
        public List<Courier> GetAssignedOrders(int courierStaffId)
        {
            // Filter the list of couriers based on the AssignedEmployeeId
            return companyObj.CourierDetails.Where(c => c.AssignedEmployeeId == courierStaffId).ToList();
        }
    }
}
