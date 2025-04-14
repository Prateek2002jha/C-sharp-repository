using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem.Task4_StringsArraysFunctions
{

//    13. Calculate Shipping Costs: Develop a function that calculates the shipping cost based on the distance
//between two locations and the weight of the parcel.You can use string inputs for the source and
//destination addresses.


    class ShippingCostCalculator
    {
        // Simulates distance between locations using dummy values (in kilometers)
        private int GetDistance(string source, string destination)
        {
            // Just a basic mockup using string lengths (not realistic, just for logic simulation)
            return Math.Abs(source.Length - destination.Length) * 10 + 50;
        }

        // Calculates shipping cost based on distance and weight
        public double CalculateShippingCost(string source, string destination, double weightKg)
        {
            int distance = GetDistance(source.ToLower(), destination.ToLower());

            double baseRate = 5.0; // base rate in $
            double costPerKm = 0.1; // cost per km per kg

            return baseRate + (distance * costPerKm * weightKg);
        }
    }
}
