using System;

namespace HW3
{
    class MainClass
    {
        public static void Main(string[] args)

        {
            /*
             * My Code below:
             */
            bool youngTrue = false;
            bool oldTrue = false;
            Console.WriteLine("Are you younger then 21?");
            string young = Console.ReadLine();

            Console.WriteLine("Are you older then 60?");
            string old = Console.ReadLine();

            if ((young == "Yes") || (young == "yes")){
                youngTrue = true;
            }

            if ((old == "Yes") || (old == "yes"))
            {
                oldTrue = true;
            }


            if (youngTrue == true) {
                Console.WriteLine("You are young");
            }


            else if (oldTrue == true){
                Console.WriteLine("You are old");
            }

            else
            {
                Console.WriteLine("You are middle aged.");
            }

            Console.ReadLine();

            /*Teacher's Code:
            Console.WriteLine("are you younger than 21? Enter true or false");
            bool areYoung = Convert.ToBoolean(Console.ReadLine());


            Console.WriteLine("are you older than 60?");
            bool areOld = Convert.ToBoolean(Console.ReadLine());

            if (areYoung)
            {
                Console.WriteLine("You are young");
            }


            if (areOld)
            {
                Console.WriteLine("You are old");
            }


            if (areYoung == false && areOld == false)
            {
                Console.WriteLine("You are in the middle");
            }

            Console.ReadLine();
            */
        }
    }
}
