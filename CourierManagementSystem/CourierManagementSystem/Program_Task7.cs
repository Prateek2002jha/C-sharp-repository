using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourierManagementSystem.Task7_ExceptionHandling;

namespace CourierManagementSystem
{
    class Program_Task7
    {
        // Sample data to simulate the system
        static List<string> validTrackingNumbers = new List<string> { "1001", "1002", "1003" };
        static List<int> validEmployeeIds = new List<int> { 101, 102, 103 };

        static void Main()
        {
            try
            {
                // Simulating tracking number validation
                Console.WriteLine("Enter Tracking Number to Track:");
                string trackingNumber = Console.ReadLine();
                TrackOrder(trackingNumber);  // This will throw the exception if tracking number is not found

                // Simulating employee ID validation
                Console.WriteLine("Enter Employee ID to validate:");
                int employeeId = int.Parse(Console.ReadLine());
                ValidateEmployeeId(employeeId);  // This will throw the exception if employee ID is invalid
            }
            catch (TrackingNumberNotFoundException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (InvalidEmployeeIdException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Program execution finished.");
            }
        }

        // Method to simulate tracking an order
        static void TrackOrder(string trackingNumber)
        {
            if (!validTrackingNumbers.Contains(trackingNumber))
            {
                throw new TrackingNumberNotFoundException("The tracking number you entered is not valid.");
            }

            Console.WriteLine($"Order with tracking number {trackingNumber} is in transit.");
        }

        // Method to simulate employee ID validation
        static void ValidateEmployeeId(int employeeId)
        {
            if (!validEmployeeIds.Contains(employeeId))
            {
                throw new InvalidEmployeeIdException("The employee ID you entered does not exist in the system.");
            }

            Console.WriteLine($"Employee with ID {employeeId} is valid.");
        }
    }
}
