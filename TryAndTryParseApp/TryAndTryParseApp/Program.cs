using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryAndTryParseApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //differentiating Parse and Try parse methods


            //Parse method

            Console.WriteLine("Input value for int32");

            Int32 number = Int32.Parse(Console.ReadLine());

            //Using try parse method
            // if conversion done successfully trypase will return true and store the result in the out parameter
            // if conversion fails it will return false and store 0 in the out parameter
            Int64 result;
            bool number2= Int64.TryParse(Console.ReadLine(), out result);

            if (number2 == true)
            {
                Console.WriteLine(number2);
                
            }
            else
            {
                Console.WriteLine("No Input pr");
            }

        }
    }
}
