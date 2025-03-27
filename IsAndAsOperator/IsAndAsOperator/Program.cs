using System;

namespace IsAndAsOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic average = 156.89F;

            Boolean inttype = average is Int32;
            bool floattype = average is float;

            Boolean stringtype = average is String;
            Boolean doubletype = average is double;

            if (inttype == true || inttype == false)
            {
                Console.WriteLine("Is Integer Type - " + inttype);
            }

            if (floattype == true || floattype == false)
            {
                Console.WriteLine("Is Float Type - " + floattype);
            }

            if (stringtype == true || stringtype == false)
            {
                Console.WriteLine("Is String Type - " + stringtype);
            }

            if (average is char)
            {
                Console.WriteLine("Is it Char Type - " + (average is char));
            }

            Console.ReadKey();
        }
    }
}
