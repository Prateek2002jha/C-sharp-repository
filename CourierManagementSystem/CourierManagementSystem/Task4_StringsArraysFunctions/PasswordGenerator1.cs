using CourierManagementSystem.Task3_ArraysAndDS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem.Task4_StringsArraysFunctions
{

    //     14. Password Generator: Create a function that generates secure passwords for courier system
    //accounts.Ensure the passwords contain a mix of uppercase letters, lowercase letters, numbers, and
    //special characters.

    class PasswordGenerator1
    {

        public class PasswordGenerator
        {
            private static readonly string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            private static readonly string lowercase = "abcdefghijklmnopqrstuvwxyz";
            private static readonly string numbers = "0123456789";
            private static readonly string specialChars = "!@#$%^&*()_-+=<>?";

            public string GenerateSecurePassword(int length = 12)
            {
                if (length < 6)
                    throw new ArgumentException("Password length should be at least 6 characters.");

                Random random = new Random();
                StringBuilder password = new StringBuilder();

                // Ensure at least one character from each group
                password.Append(uppercase[random.Next(uppercase.Length)]);
                password.Append(lowercase[random.Next(lowercase.Length)]);
                password.Append(numbers[random.Next(numbers.Length)]);
                password.Append(specialChars[random.Next(specialChars.Length)]);

                string allChars = uppercase + lowercase + numbers + specialChars;

                for (int i = 4; i < length; i++)
                {
                    password.Append(allChars[random.Next(allChars.Length)]);
                }

                // Shuffle the result to mix mandatory chars
                char[] passwordArray = password.ToString().ToCharArray();
                for (int i = 0; i < passwordArray.Length; i++)
                {
                    int j = random.Next(passwordArray.Length);
                    (passwordArray[i], passwordArray[j]) = (passwordArray[j], passwordArray[i]);
                }

                return new string(passwordArray);
            }
        }
    }
}
