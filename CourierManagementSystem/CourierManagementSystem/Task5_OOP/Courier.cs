using System;

namespace CourierManagementSystem.Task5_OOP
{
    public class Courier
    {
        // Private fields (encapsulation)
        private long courierID;          // Unique identifier for the courier
        private string senderName;      // Name of the sender
        private string senderAddress;   // Address of the sender
        private string receiverName;    // Name of the receiver
        private string receiverAddress; // Address of the receiver
        private double weight;          // Weight of the courier item
        private string status;          // Status of the courier (e.g., In Transit, Delivered)
        private string trackingNumber;  // Tracking number for the courier
        private DateTime deliveryDate;  // Expected or actual delivery date
        private long userId;             // ID of the user related to this courier
        public int AssignedEmployeeId { get; set; }
        // Default constructor
        // Initializes an empty courier object
        public Courier() { }

        // Parameterized constructor
        // Allows setting all fields at once when creating a new Courier object
        public Courier(long courierID, string senderName, string senderAddress, string receiverName,
                       string receiverAddress, double weight, string status, string trackingNumber,
                       DateTime deliveryDate, long userId)
        {
            this.courierID = courierID;
            this.senderName = senderName;
            this.senderAddress = senderAddress;
            this.receiverName = receiverName;
            this.receiverAddress = receiverAddress;
            this.weight = weight;
            this.status = status;
            this.trackingNumber = trackingNumber;
            this.deliveryDate = deliveryDate;
            this.userId = userId;
        }

        // Getters and Setters (Encapsulation)
        public long CourierID { get => courierID; set => courierID = value; }
        public string SenderName { get => senderName; set => senderName = value; }
        public string SenderAddress { get => senderAddress; set => senderAddress = value; }
        public string ReceiverName { get => receiverName; set => receiverName = value; }
        public string ReceiverAddress { get => receiverAddress; set => receiverAddress = value; }
        public double Weight { get => weight; set => weight = value; }
        public string Status { get => status; set => status = value; }
        public string TrackingNumber { get => trackingNumber; set => trackingNumber = value; }
        public DateTime DeliveryDate { get => deliveryDate; set => deliveryDate = value; }
        public long UserId { get => userId; set => userId = value; }

        // ToString override
        // Provides a string representation of the Courier object, focusing on essential information
        public override string ToString()
        {
            return $"CourierID: {courierID}, Sender: {senderName}, Receiver: {receiverName}, Status: {status}, Tracking #: {trackingNumber}";
        }
    }
}
