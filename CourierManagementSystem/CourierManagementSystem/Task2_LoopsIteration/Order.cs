using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem.Task2_LoopsIteration
{    // define an order class to represent customer orders

    public class Order
   {
    public int OrderId { get; set; } // unique number for the order
    public string CustomerEmail { get; set; } // the customer's email address
    public string Status { get; set; }// current delivery status
    public string Item { get; set; } // the item being ordered

    // Override ToString() to nicely print order details
    public override string ToString()
    {
        return $"OrderId: {OrderId}, Item: {Item}, Status: {Status}";
    }
}

// OrderViewer class to handle order display logic
public class OrderViewer
{
    private List<Order> orders; // List to store sample order data its private

    public OrderViewer()
    {
        // Initialize the sample order data
        orders = new List<Order>
            {
                new Order { OrderId = 1, CustomerEmail = "prat@gmail.com", Item = "Phone", Status = "Delivered" },
                new Order { OrderId = 2, CustomerEmail = "soyeb@gmail.com", Item = "Laptop", Status = "In Transit" },
                new Order { OrderId = 3, CustomerEmail = "john@egmail.com", Item = "Charger", Status = "Delivered" },
                new Order { OrderId = 4, CustomerEmail = "prithiv@gmail.com", Item = "Tablet", Status = "Processing" },
            };
    }

    // Method to display all orders for a specific customer
    public void DisplayOrdersForCustomer(string customerEmail)
    {
        bool found = false;// found trakcs whether any orders matched the email

        Console.WriteLine($"Orders for {customerEmail}:");//takes email as input

        // Iterate over all orders using a for loop
        for (int i = 0; i < orders.Count; i++)
        {
            // Match customer's email (case-insensitive)
            if (orders[i].CustomerEmail.Equals(customerEmail, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(orders[i]); // Print matching order
                found = true;
            }
        }

        // Show a message if no orders found for the customer
        if (!found)
        {
            Console.WriteLine("No orders found for this customer.");
        }
    }
}
}
