using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem.Task5_OOP
{
    public class CourierCompany
    {
        // Private fields
        private string companyName; // The name of the courier company
        private List<Courier> courierDetails; // List to store Courier objects
        private List<Employee> employeeDetails; // List to store Employee objects
        private List<Location> locationDetails; // List to store Location objects

        // Default constructor
        public CourierCompany()
        {
            courierDetails = new List<Courier>(); // Initializing the lists when a new company object is created
            
            employeeDetails = new List<Employee>();
            locationDetails = new List<Location>();
            // ensureds that you don't get a NUllReferenceException when adding to lists later
        }

        // Parameterized constructor to initialize all fields
        public CourierCompany(string companyName, List<Courier> courierDetails, List<Employee> employeeDetails, List<Location> locationDetails)
        {
            this.companyName = companyName;// allows creating CourierCompany object with all values(name+alllists) initiazlied at once
            this.courierDetails = courierDetails;
            this.employeeDetails = employeeDetails;
            this.locationDetails = locationDetails; // this keyword is used to assingn the parameter values to the current object's fields.

        }

        // Getters and Setters for all private fields
        public string CompanyName { get => companyName; set => companyName = value; }
        public List<Courier> CourierDetails { get => courierDetails; set => courierDetails = value; }
        public List<Employee> EmployeeDetails { get => employeeDetails; set => employeeDetails = value; }
        public List<Location> LocationDetails { get => locationDetails; set => locationDetails = value; }

        // ToString method to get a summary of the company details
        public override string ToString()
        {
            return $"Courier Company: {companyName}, Couriers: {courierDetails.Count}, Employees: {employeeDetails.Count}, Locations: {locationDetails.Count}";
        }

        // Add a courier to the list of couriers
        public void AddCourier(Courier c)
        {
            courierDetails.Add(c); // Adds the given courier object to the list
        }

        // Get all couriers
        public List<Courier> GetCouriers()
        {
            return courierDetails; // Returns the list of couriers
        }

        // Remove a courier by tracking number
        public bool RemoveCourier(string trackingNumber)
        {
            var courierToRemove = courierDetails.FirstOrDefault(c => c.TrackingNumber == trackingNumber);
            if (courierToRemove != null)
            {
                courierDetails.Remove(courierToRemove); // Removes the courier from the list
                return true;
            }
            return false; // Returns false if courier with the tracking number is not found
        }
    }

}
