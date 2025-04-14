using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem.Task5_OOP
{
    class Payment
    {
        // Private fields
        private long paymentID; // Unique identifier for the payment
        private long courierID; // ID of the courier related to this payment
        private double amount; // Payment amount
        private DateTime paymentDate; // Date of payment

        // Default constructor
        public Payment() { }

        // Parameterized constructor to initialize all fields
        public Payment(long paymentID, long courierID, double amount, DateTime paymentDate)
        {
            this.paymentID = paymentID;
            this.courierID = courierID;
            this.amount = amount;
            this.paymentDate = paymentDate;
        }

        // Getters and Setters for the fields
        public long PaymentID { get => paymentID; set => paymentID = value; }
        public long CourierID { get => courierID; set => courierID = value; }
        public double Amount { get => amount; set => amount = value; }
        public DateTime PaymentDate { get => paymentDate; set => paymentDate = value; }

        // ToString method to return a summary of payment details
        public override string ToString()
        {
            return $"PaymentID: {paymentID}, CourierID: {courierID}, Amount: {amount}, PaymentDate: {paymentDate.ToShortDateString()}";
        }
    }

}
