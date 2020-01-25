using System;

namespace stringGamems
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            int num1 = 4;
            int num2 = 56;
            int num3 = 789;
            Console.WriteLine("My name is Yusuf" + "Hanafy");
            Console.WriteLine("number 1 is {0}", num1);
            Console.WriteLine("number 2 is {0}", num2);
            Console.WriteLine("number 3 is {0}", num3);

            Console.WriteLine("My name is Yusuf" + "Hanafy");

            //first number in the {} is what varible to put and the second number is the number of spaces.
            Console.WriteLine("first {0,50}, second {1,20} ", num1, num2);

            Console.ReadLine();
        }


    }
}
