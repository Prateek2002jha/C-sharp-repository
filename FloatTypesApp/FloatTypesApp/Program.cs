using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatTypesApp
{
    class Program
    {
        static void Main(string[] args)
        {

            float number = 123.15F;
            double number2 = 5689.26D;
            decimal number3 = 123456.789M;

            // processs to convert string to float is called as parsing
            

           


            // parsing using convert clas
            string numberFloat = Console.ReadLine();
            number = Convert.ToSingle(numberFloat);
           
            // parsing using parse method
            string numberdouble = Console.ReadLine();
            number2 = Double.Parse(numberdouble);

            string numberdecimal = Console.ReadLine();
            number3 = Decimal.Parse(numberdecimal);

            int number5= Int16.Parse(Console.ReadLine());
            Int32 number6 = Int32.Parse(Console.ReadLine());
            Int64 number7 = Convert.ToInt64(Console.ReadLine());

            //Parsing string

            Console.WriteLine(number);
             Console.WriteLine(number2);
             Console.WriteLine(number3);

            Console.ReadKey(); 
        }
    }
}
