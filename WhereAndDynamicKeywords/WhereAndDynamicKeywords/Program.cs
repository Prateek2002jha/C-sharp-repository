using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhereAndDynamicKeywords
{
    class Program
    {
        static void Main(string[] args)
        {

            var variableValue= 156.15F;
            

            Console.WriteLine("Type of Variable  " + variableValue.GetType());
            dynamic dynamicValue = 789;

            Console.WriteLine("Type of Variable  " + dynamicValue.GetType());
            Console.ReadKey(); 
        }
    }
}
