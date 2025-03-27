using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types_ValueTypesApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //variable of type int16, int32, int 64

            Int16 mark_math = 50;
            Int32 mark_science = 75;
            Int64 mark_english = 85;

            Int64 Total_Marks= mark_math + mark_science + mark_english;
            // shows out put with writeline method on different lines
            Console.WriteLine("Output Using Writeline");
            Console.WriteLine(mark_math);
            Console.WriteLine(mark_science);
            Console.WriteLine(mark_english);
            Console.WriteLine(Total_Marks);


            //output with write method -- shows output on the same line
            Console.Write("Output Using Write");
            Console.Write(mark_math);
            Console.Write(mark_science);
            Console.Write(mark_english);

            // formatting the output with functions
            Console.WriteLine("\n Math \t Science \t English \t Total\n{0}\t{1}\t\t{2}\t\t{3}," ,
                mark_math, mark_science,mark_english,Total_Marks);

            //Formatting output using string format function
            string tableFormat = string.Format (string.Format("Math \t Science \t English \t Total\n{0}\t{1}\t\t{2}\t\t{3}",
                mark_math, mark_science, mark_english, Total_Marks));

            Console.WriteLine(tableFormat);




            Console.ReadKey();

        }
    }
}
