using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem.Task5_OOP
{
    public class Location
    {
        // Private fields
        private long locationID; // Unique identifier for the location
        private string locationName; // Name of the location (e.g., city, warehouse)
        private string address; // Address of the location

        // Default constructor
        public Location() { }

        // Parameterized constructor to initialize all fields
        public Location(long  locationID, string locationName, string address)
        {
            this.locationID = locationID;
            this.locationName = locationName;
            this.address = address;
        }

        // Getters and Setters for the fields
        public long LocationID { get => locationID; set => locationID = value; }
        public string LocationName { get => locationName; set => locationName = value; }
        public string Address { get => address; set => address = value; }

        // ToString method to return a summary of location details
        public override string ToString()
        {
            return $"LocationID: {locationID}, Name: {locationName}, Address: {address}";
        }
    }

}
