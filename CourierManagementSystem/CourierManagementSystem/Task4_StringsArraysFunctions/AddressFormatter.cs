using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem.Task4_StringsArraysFunctions
{
    class AddressFormatter
    {

//        11. Address Formatting: Develop a function that takes an address as input(street, city, state, zip code)
//and formats it correctly, including capitalizing the first letter of each word and properly formatting the
//zip code.
        // Function to format address
        public string FormatAddress(string street, string city, string state, string zipCode)
        {
            // Capitalize each word (title case)
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;

            street = textInfo.ToTitleCase(street.ToLower());
            city = textInfo.ToTitleCase(city.ToLower());
            state = textInfo.ToTitleCase(state.ToLower());

            // Format zip code to ensure it's 6 digits
            if (zipCode.Length < 6)
            {
                zipCode = zipCode.PadLeft(6, '0'); // Pad with 0 if less than 5 digits
            }

            // Final formatted address string
            return $"{street}, {city}, {state} - {zipCode}";
        }
    }
}
