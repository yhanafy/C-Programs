using System;

namespace Grade
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What is your grade point average for High School?");
            decimal grade = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("What was your admission score?");
            decimal score = Convert.ToDecimal(Console.ReadLine());



            if ((grade >= 3.0m && score >= 60) || (grade < 3.0m && score >= 80)) {
                Console.WriteLine("Congarts, you are accepted :P");

            }
            else
            {
                Console.WriteLine("Sorry, you are rejectd :(");
            }
            Console.ReadLine();
    }
    }
}
