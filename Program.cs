using System;

namespace Project0_2
{
    class Program
    {
        static void Main(string[] args)
        { 
            // string userin = "";
            // var customer1 = new Customer();
            Prompt();
            // Console.Write("Are you a new customer : (y/n)");
            // Console.ReadLine();
            
            // if(userin == "y")
            // {
            //     customer1.NewCustomer();
            // }
            // else
            // {
            //     customer1.UserNameAndPass();
            // }

            
            

            productsWeSell();
            UserDecides();
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
            string[] items = {"Pizza", "Wings", "Drinks", "Sides", "Deserts", "Exit"};
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
            Console.Write("Which one would you like: ");
            int userInput = int.Parse(Console.ReadLine());

            switch(userInput)
            {
                case 1:
                    var pizza1 = new Pizza();
                    pizza1.GroupMethod();
                break; 
                case 2:
                    var wings1 = new Wings();
                    wings1.GroupMethod();
                break;
                case 3:
                    var drinks1 = new Drinks();
                    drinks1.GroupMethod();
                    break;
                case 4:
                    var sides1 = new Sides();
                    sides1.GroupMethod();
                    break;
                case 5:
                    var deserts1 = new Desert();
                    deserts1.GroupMethod();
                    break;
                case 6:
                    Console.WriteLine("Good-bye");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Sorry didn't catch that. Try again.");
                    UserDecides();
                    break;
            }


            return userInput;
        }
    }
}
