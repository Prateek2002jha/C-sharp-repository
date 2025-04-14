using System;

namespace CourierManagementSystem.Task1_ControlFlow
{
    class UserAuthenticator
    {
        // Method to authenticate a user based on hardcoded credentials
        public void AuthenticateUser()
        {
            // Prompt user to enter username
            Console.Write("Enter Username: ");
            string username = Console.ReadLine();

            // Prompt user to enter password
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            // Hardcoded credentials for demo (can be replaced with DB-based validation later)
            string validUsername = "admin";
            string validPassword = "password123";

            // Check if entered credentials match the valid ones
            if (username == validUsername && password == validPassword)
            {
                Console.WriteLine("Login Successful. Welcome, " + username + "!");
            }
            else
            {
                Console.WriteLine("Invalid username or password. Please try again.");
            }
        }
    }
}
