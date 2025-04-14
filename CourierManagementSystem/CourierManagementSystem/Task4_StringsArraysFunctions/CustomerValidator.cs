using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CourierManagementSystem.Task4_StringsArraysFunctions
{

//    10. Customer Data Validation: Write a function which takes 2 parameters, data-denotes the data and
//detail-denotes if it is name addtress or phone number.Validate customer information based on
//following critirea.Ensure that names contain only letters and are properly capitalized, addresses do not
//contain special characters, and phone numbers follow a specific format(e.g., ###-###-####). 
    class CustomerValidator
    {
        // This method validates data based on its type: name, address, or phone number
        public bool Validate(string data, string detailType)
        {
            switch (detailType.ToLower())
            {
                case "name":
                    // Name should only contain letters and spaces, and be capitalized
                    return Regex.IsMatch(data, @"^[A-Z][a-z]+(?: [A-Z][a-z]+)*$");

                case "address":
                    // Address should not contain special characters (only letters, numbers, commas, and spaces allowed)
                    return Regex.IsMatch(data, @"^[a-zA-Z0-9\s,]+$");

                case "phone":
                    // Phone format should be ###-###-####
                    return Regex.IsMatch(data, @"^\d{3}-\d{3}-\d{4}$");

                default:
                    Console.WriteLine("Invalid detail type. Use 'name', 'address', or 'phone'.");
                    return false;
            }
        }
    }
}
