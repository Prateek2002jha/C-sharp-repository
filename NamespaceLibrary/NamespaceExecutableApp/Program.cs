using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancialCalculation;
using Calculation;
using MathematicalCalculations;

namespace NamespaceExecutableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 100;
            //fully qualitfied name of class -class name with namespace
            FinancialCalculation.Math mathObject = new FinancialCalculation.Math();
            NamespaceLibrary.Math mathFunc = new NamespaceLibrary.Math();
            Calculation.Math math = new Calculation.Math();


            Console.WriteLine(math);
            Console.WriteLine(mathFunc);
            Console.WriteLine(mathObject);








        }
    }
}
