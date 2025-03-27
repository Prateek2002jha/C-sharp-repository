using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingAndUnboxingApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //converting value to reference type is boxing:
            Int32 boxValue = 789;

            object boxValue2 = boxValue;

            Console.WriteLine(boxValue2);




            //Converting reference to value type is unboxing

            Int32 unboxValue =(Int32)boxValue2;

            Console.WriteLine("After explicit conversion to unbox value" + unboxValue);

            unboxValue = Convert.ToInt32(boxValue32);
            Console.WriteLine("Conversion of unbox value to box value")
        }
    }
}
