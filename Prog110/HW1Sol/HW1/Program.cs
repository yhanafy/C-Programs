using System;

namespace HW1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Here is my first homework program!");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Please type the grade you would like.");
            string userGrade = Console.ReadLine();
            Console.WriteLine("You typed: " + userGrade);
            Console.ReadLine();
        }
    }
}
