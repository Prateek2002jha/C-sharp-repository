using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //values type int, float , char, enum , struct
            // zero is default value for value type 
            // value types are immutable 
            Int32 number;
            //reference
            string name = "C Sharp";

            Console.WriteLine(name);

            // change the value of name
            string coursename = name;
            coursename = "Python";
            Console.WriteLine(coursename);

            Console.ReadKey();

           

        }
    }
}
