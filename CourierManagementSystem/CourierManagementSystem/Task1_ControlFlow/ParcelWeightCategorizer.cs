using System;

namespace CourierManagementSystem.Task1_ControlFlow
{
    // Class responsible for categorizing the parcel based on its weight
    class ParcelWeightCategorizer
    {
        // Method to categorize the weight into Light, Medium, or Heavy
        public void CategorizeWeight(double weight)
        {
            string category; // To hold the result category

            // Switch-case to check weight categories
            switch (weight)
            {
                case double n when (n < 0):
                    category = "Invalid weight"; // Negative weights are not valid
                    break;

                case double n when (n < 2):
                    category = "Light"; // Less than 2 kg
                    break;

                case double n when (n < 5):
                    category = "Medium"; // Between 2 kg and 5 kg
                    break;

                default:
                    category = "Heavy"; // 5 kg and above
                    break;
            }

            // Output the category of the parcel
            Console.WriteLine($"The parcel is categorized as: {category}");
        }
    }
}
