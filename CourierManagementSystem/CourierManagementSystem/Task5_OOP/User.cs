using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem.Task5_OOP
{
    class User
    {
        // Private fields
        private long userID; // Unique identifier for the user
        private string userName; // User's name
        private string email; // User's email
        private string password; // User's password (for authentication)
        private string contactNumber; // User's contact number
        private string address; // User's address

        // Default constructor
        public User() { }

        // Parameterized constructor to initialize all fields
        public User(long userID, string userName, string email, string password, string contactNumber, string address)
        {
            this.userID = userID;
            this.userName = userName;
            this.email = email;
            this.password = password;
            this.contactNumber = contactNumber;
            this.address = address;
        }

        // Getters and Setters for all fields
        public long UserID { get => userID; set => userID = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string ContactNumber { get => contactNumber; set => contactNumber = value; }
        public string Address { get => address; set => address = value; }

        // ToString method to return a summary of user details
        public override string ToString()
        {
            return $"UserID: {userID}, Name: {userName}, Email: {email}, Contact: {contactNumber}, Address: {address}";
        }
    }

}
