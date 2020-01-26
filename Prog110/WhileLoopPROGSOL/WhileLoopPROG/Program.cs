
/*This Program asks the user to enter a word over and over.
 When the user is done, my program will write out the longest word of all the words they entered.
 */


using System;

namespace WhileLoopPROG
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Ask the user to enter the first word, 
            Console.WriteLine("Please enter a word: ");
            string word = Console.ReadLine();
            string currentWinner = "";

            while (word != "end")
            {
                int numLetter = word.Length;
                int finalnum = currentWinner.Length;
                if (numLetter > finalnum)
                {
                    currentWinner = word;
                }
                Console.WriteLine("Please enter a word:        Type 'end' to quit. ");
                word = Console.ReadLine();
            }
               
            Console.WriteLine(currentWinner);
            Console.ReadLine();
        }
    }
}
