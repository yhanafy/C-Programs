using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WritingOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3 ways of doing the same thing.

            string firstLine = "The floating point number ";
            double secondLine = 42.8765;
            string thirdLine = " rounded to a whole number is ";
            int fourthLine = 43;

            // write it out a line at a time
            Console.WriteLine(firstLine);
            Console.WriteLine(secondLine);
            Console.WriteLine(thirdLine);
            Console.WriteLine(fourthLine);
            Console.ReadLine();

            // Or as one line using the Console.Write and the Console.WriteLine methods
            Console.Write(firstLine);
            Console.Write(secondLine);
            Console.Write(thirdLine);
            Console.WriteLine(fourthLine);
            Console.ReadLine();

            // Or better, using format strings
            Console.WriteLine("The floating point number {0} rounded to a whole number is {1}", secondLine, fourthLine);
            Console.ReadLine();
        }
    }
}
