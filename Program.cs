using System;
using System.Collections.Generic;

namespace Project0_2
{
    class Program
    {
        static void Main(string[] args)
        { 
            Prompt();
            productsWeSell();

            var pizza1 = new Pizza();
            
            pizza1.Intro();
            pizza1.ProductChoices();
            pizza1.DisiplayChoices();
            pizza1.DisplayChoicesAndPrices();z
        }

        static void Prompt()
        {
            System.Console.WriteLine("Welcome to the Pizza Planet Console Application!");
            System.Console.WriteLine("-------------------------------------------------");
            System.Console.WriteLine();
            System.Console.WriteLine("Press the corresponding to go the page.");
            System.Console.WriteLine("We sell: ");
            System.Console.WriteLine();
        }

        static string[] productsWeSell()
        {
            string[] items = {"Pizza", "Wings", "Drinks", "Sides", "Exit"};
            int a = 0;

            for (a = 1; a <= items.Length; a++)
            {
                Console.WriteLine(a + ". " + items[a - 1]);
            }
            System.Console.WriteLine();

            return items;
        }

        public static int UserDecides()
        {
            System.Console.WriteLine();
            Console.Write("Which one would you like");
            int userInput = int.Parse(Console.ReadLine());


            return userInput;
        }
    }
}
