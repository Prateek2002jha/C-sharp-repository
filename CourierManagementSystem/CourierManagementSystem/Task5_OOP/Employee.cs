using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem.Task5_OOP
{
    public class Employee
    {
        // Private fields
        private long employeeID; // Unique identifier for the employee
        private string employeeName; // Name of the employee
        private string email; // Email address of the employee
        private string contactNumber; // Contact number of the employee
        private string role; // Role of the employee (e.g., Manager, Driver, etc.)
        private double salary; // Employee salary

        // Default constructor
        public Employee() { }

        // Parameterized constructor to initialize all fields
        public Employee(long employeeID, string employeeName, string email, string contactNumber, string role, double salary)
        {
            this.employeeID = employeeID;
            this.employeeName = employeeName;
            this.email = email;
            this.contactNumber = contactNumber;
            this.role = role;
            this.salary = salary;
        }

        // Getters and Setters for the fields
        public long EmployeeID { get => employeeID; set => employeeID = value; }
        public string EmployeeName { get => employeeName; set => employeeName = value; }
        public string Email { get => email; set => email = value; }
        public string ContactNumber { get => contactNumber; set => contactNumber = value; }
        public string Role { get => role; set => role = value; }
        public double Salary { get => salary; set => salary = value; }

        // ToString method to return a summary of employee details
        public override string ToString()
        {
            return $"EmployeeID: {employeeID}, Name: {employeeName}, Role: {role}, Email: {email}";
        }
    }

}
