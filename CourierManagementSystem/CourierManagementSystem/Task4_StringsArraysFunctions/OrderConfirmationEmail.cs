using CourierManagementSystem.Task2_LoopsIteration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem.Task4_StringsArraysFunctions
{

    //    {
    //        12. Order Confirmation Email: Create a program that generates an order confirmation email.The email
    //should include details such as the customer's name, order number, delivery address, and expected 
    //delivery date.
    class OrderConfirmationEmail
    {


        // Function to generate confirmation email content
        public string GenerateEmail(string customerName, string orderNumber, string deliveryAddress, DateTime expectedDeliveryDate)
        {
            return
$@"Dear {customerName},

Thank you for your order!

Order Number: {orderNumber}
Delivery Address: {deliveryAddress}
Expected Delivery Date: {expectedDeliveryDate:dddd, dd MMMM yyyy}

If you have any questions or need to make changes to your order, please contact our support team.

Best regards,  
Courier Management Team";
        }

    }
}
