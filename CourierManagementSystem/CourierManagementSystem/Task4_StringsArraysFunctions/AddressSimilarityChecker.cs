using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem.Task4_StringsArraysFunctions
{


//    15. Find Similar Addresses: Implement a function that finds similar addresses in the system.This can be
//useful for identifying duplicate customer entries or optimizing delivery routes.Use string functions to
//implement this.
    class AddressSimilarityChecker
    {

        // Method to find and print similar addresses
        public void FindSimilarAddresses(List<string> addresses)
        {
            bool foundSimilar = false;

            Console.WriteLine("Checking for similar addresses...\n");

            for (int i = 0; i < addresses.Count; i++)// outer look
            {
                for (int j = i + 1; j < addresses.Count; j++) // inner loop
                {
                    if (AreAddressesSimilar(addresses[i], addresses[j]))
                    {
                        Console.WriteLine($"Possible duplicates:\n- {addresses[i]}\n- {addresses[j]}\n");
                        foundSimilar = true;
                    }
                }
            }

            if (!foundSimilar)
            {
                Console.WriteLine("No similar addresses found.");
            }
        }

        // Very basic similarity logic using lowercase match and substring check
        private bool AreAddressesSimilar(string addr1, string addr2)
        {
            addr1 = addr1.ToLower().Replace(" ", "");
            addr2 = addr2.ToLower().Replace(" ", "");

            int matchCount = 0;

            // Count how many characters are matching
            foreach (char c in addr1)
            {
                if (addr2.Contains(c)) matchCount++;
            }

            // Consider similar if >70% characters match
            double similarity = (double)matchCount / Math.Max(addr1.Length, addr2.Length);

            return similarity >= 0.7;
        }
    }
}
