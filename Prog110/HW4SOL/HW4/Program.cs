using System;

namespace HW4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            decimal totalPrice = 0.00m;

            Console.WriteLine("What kind of pizza would you like, S, M, L? (Small, Medium, Large)");
            string pizzaSize = Console.ReadLine();

            if (pizzaSize == "s" || pizzaSize == "S") {
                Console.WriteLine("You selected small, that would be $5.00");
                totalPrice += 5.00m;
                Console.WriteLine("How many toppings would you like, 0, 1, or 2?");
                string numberOfToppings = Console.ReadLine();
                if (numberOfToppings == "0" || numberOfToppings == "zero" || numberOfToppings == "Zero")
                {
                    totalPrice += totalPrice * .10m;
                    Console.WriteLine("Thank you for your order, it will be done shortly, Including 10 % tax, you total bill is: $" + totalPrice);
                }
                else if (numberOfToppings == "1" || numberOfToppings == "one" || numberOfToppings == "One")
                {
                    totalPrice += 1.00m;
                    totalPrice += totalPrice * .10m;
                    Console.WriteLine("Thank you for your order, it will be done shortly, Including 10 % tax, you total bill is: $" + totalPrice);
                }
                else if (numberOfToppings == "2" || numberOfToppings == "two" || numberOfToppings == "Two")
                {
                    totalPrice += 1.50m;
                    totalPrice += totalPrice * .10m;
                    Console.WriteLine("Thank you for your order, it will be done shortly, Including 10 % tax, you total bill is: $" + totalPrice);
                }
            }
            else if (pizzaSize == "m" || pizzaSize == "M")
            {
                Console.WriteLine("You selected medium, that would be $7.00");
                totalPrice += 7.00m;
                Console.WriteLine("How many toppings would you like, 0, 1, or 2?");
                string numberOfToppings = Console.ReadLine();
                if (numberOfToppings == "0" || numberOfToppings == "zero" || numberOfToppings == "Zero")
                {
                    totalPrice += totalPrice * .10m;
                    Console.WriteLine("Thank you for your order, it will be done shortly, Including 10 % tax, you total bill is: $" + totalPrice);
                }
                else if (numberOfToppings == "1" || numberOfToppings == "one" || numberOfToppings == "One")
                {
                    totalPrice += 1.00m;
                    totalPrice += totalPrice * .10m;
                    Console.WriteLine("Thank you for your order, it will be done shortly, Including 10 % tax, you total bill is: $" + totalPrice);
                }
                else if (numberOfToppings == "2" || numberOfToppings == "two" || numberOfToppings == "Two")
                {
                    totalPrice += 1.50m;
                    totalPrice += totalPrice * .10m;
                    Console.WriteLine("Thank you for your order, it will be done shortly, Including 10 % tax, you total bill is: $" + totalPrice);
                }
            }
            else if (pizzaSize == "l" || pizzaSize == "L")
            {
                Console.WriteLine("You selected large, that would be $9.00");
                totalPrice += 9.00m;
                Console.WriteLine("How many toppings would you like, 0, 1, or 2?");
                string numberOfToppings = Console.ReadLine();
                if (numberOfToppings == "0" || numberOfToppings == "zero" || numberOfToppings == "Zero")
                {
                    totalPrice += totalPrice * .10m;
                    Console.WriteLine("Thank you for your order, it will be done shortly, Including 10 % tax, you total bill is: $" + totalPrice);
                }
                else if (numberOfToppings == "1" || numberOfToppings == "one" || numberOfToppings == "One")
                {
                    totalPrice += 1.00m;
                    totalPrice += totalPrice * .10m;
                    Console.WriteLine("Thank you for your order, it will be done shortly, Including 10 % tax, you total bill is: $" + totalPrice);
                }
                else if (numberOfToppings == "2" || numberOfToppings == "two" || numberOfToppings == "Two")
                {
                    totalPrice += 1.50m;
                    totalPrice += totalPrice * .10m;
                    Console.WriteLine("Thank you for your order, it will be done shortly, Including 10 % tax, you total bill is: $" + totalPrice);
                }
            }

            Console.ReadLine();
        }
    }
}
