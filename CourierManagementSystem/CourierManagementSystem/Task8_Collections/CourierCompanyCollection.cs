using CourierManagementSystem.Task5_OOP;
using System;
using System.Collections.Generic;

namespace CourierManagementSystem.Task8_Collections
{
    public class CourierCompanyCollection
    {
        public string CompanyName { get; set; }
        public List<Courier> CourierDetails { get; set; }
        public List<Employee> EmployeeDetails { get; set; }
        public List<Location> LocationDetails { get; set; }

        // Default constructor
        public CourierCompanyCollection()
        {
            CourierDetails = new List<Courier>();
            EmployeeDetails = new List<Employee>();
            LocationDetails = new List<Location>();
        }

        // Constructor with company name
        public CourierCompanyCollection(string companyName)
        {
            CompanyName = companyName;
            CourierDetails = new List<Courier>();
            EmployeeDetails = new List<Employee>();
            LocationDetails = new List<Location>();
        }

        // Method to add a courier to the list
        public void AddCourier(Courier courier)
        {
            CourierDetails.Add(courier);
        }

        // Method to remove a courier from the list
        public bool RemoveCourier(Courier courier)
        {
            return CourierDetails.Remove(courier);
        }

        // Method to add an employee to the list
        public void AddEmployee(Employee employee)
        {
            EmployeeDetails.Add(employee);
        }

        // Method to remove an employee from the list
        public bool RemoveEmployee(Employee employee)
        {
            return EmployeeDetails.Remove(employee);
        }

        // Method to add a location to the list
        public void AddLocation(Location location)
        {
            LocationDetails.Add(location);
        }

        // Method to remove a location from the list
        public bool RemoveLocation(Location location)
        {
            return LocationDetails.Remove(location);
        }
    }
}
