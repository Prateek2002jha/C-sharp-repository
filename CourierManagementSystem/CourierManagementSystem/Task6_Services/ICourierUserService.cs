using System;
using System.Collections.Generic;
using CourierManagementSystem.Task5_OOP; // For using the Courier class

namespace CourierManagementSystem.Task6_Services
{
    // Interface for customer-related courier operations
    public interface ICourierUserService
    {
        /// <summary>
        /// Place a new courier order.
        /// </summary>
        /// <param name="courierObj">Courier object created using user input</param>
        /// <returns>The unique tracking number of the placed order</returns>
        string PlaceOrder(Courier courierObj);

        /// <summary>
        /// Get the current status of a courier order.
        /// </summary>
        /// <param name="trackingNumber">Tracking number of the order</param>
        /// <returns>Status of the order (e.g., YetToTransit, InTransit, Delivered)</returns>
        string GetOrderStatus(string trackingNumber);

        /// <summary>
        /// Cancel a courier order.
        /// </summary>
        /// <param name="trackingNumber">Tracking number of the order</param>
        /// <returns>True if cancelled successfully, false otherwise</returns>
        bool CancelOrder(string trackingNumber);

        /// <summary>
        /// Get all courier orders assigned to a specific staff member.
        /// </summary>
        /// <param name="courierStaffId">ID of the courier staff member</param>
        /// <returns>List of assigned courier orders</returns>
        List<Courier> GetAssignedOrders(int courierStaffId);
    }
}
