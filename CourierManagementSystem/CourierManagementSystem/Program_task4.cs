using CourierManagementSystem.Task2_LoopsIteration;
using CourierManagementSystem.Task4_StringsArraysFunctions;
using CourierManagementSystem.Task5_OOP;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;
using static CourierManagementSystem.Task4_StringsArraysFunctions.PasswordGenerator1;

namespace CourierManagementSystem
{



//    Task 4: Strings,2d Arrays, user defined functions,Hashmap 
//9. Parcel Tracking: Create a program that allows users to input a parcel tracking number.Store the
//tracking number and Status in 2d String Array. Initialize the array with values.Then, simulate the
//tracking process by displaying messages like "Parcel in transit," "Parcel out for delivery," or "Parcel 
//delivered" based on the tracking number's status. 
//10. Customer Data Validation: Write a function which takes 2 parameters, data-denotes the data and
//detail-denotes if it is name addtress or phone number.Validate customer information based on
//    following critirea.Ensure that names contain only letters and are properly capitalized, addresses do not
//    contain special characters, and phone numbers follow a specific format (e.g., ###-###-####). 
//11. Address Formatting: Develop a function that takes an address as input (street, city, state, zip code)
//and formats it correctly, including capitalizing the first letter of each word and properly formatting the
//zip code. 
//12. Order Confirmation Email: Create a program that generates an order confirmation email.The email
//should include details such as the customer's name, order number, delivery address, and expected 
//delivery date. 
//13. Calculate Shipping Costs: Develop a function that calculates the shipping cost based on the distance
//between two locations and the weight of the parcel.You can use string inputs for the source and
//destination addresses.
//14. Password Generator: Create a function that generates secure passwords for courier system
//accounts.Ensure the passwords contain a mix of uppercase letters, lowercase letters, numbers, and
//special characters.
//15. Find Similar Addresses: Implement a function that finds similar addresses in the system. This can be
//useful for identifying duplicate customer entries or optimizing delivery routes.Use string functions to
//implement this.
    class Program_task4
    {

        static void Main(string[] args)
        {

            //9th usage method of ParcelTrackingSystem
            ParcelTrackingSystem tracker = new ParcelTrackingSystem();

            Console.Write("Enter your tracking number: ");
            string userInput = Console.ReadLine();

            tracker.TrackParcel(userInput);





            //10th usage method of CustomerValidator
            CustomerValidator validator = new CustomerValidator();

            Console.Write("Enter detail type (name/address/phone): ");
            string type = Console.ReadLine();

            Console.Write("Enter the data to validate: ");
            string input = Console.ReadLine();

            bool result = validator.Validate(input, type);

            if (result)
            {
                Console.WriteLine("✅ Valid " + type);
            }
            else
            {
                Console.WriteLine("❌ Invalid " + type);
            }




            // 11th usage method of AddressFormatter
            AddressFormatter formatter = new AddressFormatter();

            Console.Write("Enter Street: ");
            string street = Console.ReadLine();

            Console.Write("Enter City: ");
            string city = Console.ReadLine();

            Console.Write("Enter State: ");
            string state = Console.ReadLine();

            Console.Write("Enter Zip Code: ");
            string zip = Console.ReadLine();

            string formattedAddress = formatter.FormatAddress(street, city, state, zip);
            Console.WriteLine("Formatted Address:");
            Console.WriteLine(formattedAddress);





            // 12th usage method of OrderConfirmationEmail

            OrderConfirmationEmail emailGenerator = new OrderConfirmationEmail();

            Console.Write("Enter Customer Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Order Number: ");
            string orderNum = Console.ReadLine();

            Console.Write("Enter Delivery Address: ");
            string address = Console.ReadLine();

            Console.Write("Enter Expected Delivery Date (yyyy-mm-dd): ");
            DateTime deliveryDate = DateTime.Parse(Console.ReadLine());

            string emailContent = emailGenerator.GenerateEmail(name, orderNum, address, deliveryDate);
            Console.WriteLine("\nGenerated Confirmation Email:");
            Console.WriteLine("----------------------------------");
            Console.WriteLine(emailContent);
            Console.WriteLine("----------------------------------");






            //13th usage method of ShippingCostCalculator
            ShippingCostCalculator costCalc = new ShippingCostCalculator();

            Console.Write("Enter Source Address: ");
            string source = Console.ReadLine();

            Console.Write("Enter Destination Address: ");
            string destination = Console.ReadLine();

            Console.Write("Enter Parcel Weight (kg): ");
            double weight = double.Parse(Console.ReadLine());

            double shippingCost = costCalc.CalculateShippingCost(source, destination, weight);
            Console.WriteLine($"Estimated Shipping Cost: ${shippingCost:F2}");







            // 14th usage method of PasswordGenerator
            PasswordGenerator generator = new PasswordGenerator();

            Console.Write("Enter desired password length: ");
            int length = int.Parse(Console.ReadLine());

            try
            {
                string newPassword = generator.GenerateSecurePassword(length);
                Console.WriteLine("Generated Password: " + newPassword);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }





            //15 usage of AddressSimilarityChecker

            List<string> addressList = new List<string>
{
             "123 Loni kalbhor, Pune",
              "Beturkar St, Kalyan",
              "khadakpada, Kalyan",
               "Rosalie, Pune",
                "khadakwasla, Pune"
};

            AddressSimilarityChecker checker = new AddressSimilarityChecker();
            checker.FindSimilarAddresses(addressList);

        }
    }
}
