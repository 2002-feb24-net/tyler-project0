using System;
using System.Collections.Generic;

namespace Project0_2
{
    public abstract class Product
    {
        //private string _name;
        //private Dictionary<string, double> _choices;
        public string Name { get; set; }
        public Dictionary<string, double> Choices { get; set; } = new Dictionary<string, double>();
        public void Border(string message)
        {
            int a  = 0;
            for (a = 0; a < message.Length + 2; a++)
            {
                Console.Write("-");
            }
        }

        public void Intro()
        {
            string message = "Welcome to the {0} page.";

            System.Console.WriteLine(message, Name);
            Border(message);
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine("Below is a list of every kind of {0}s we sell and their corresponding prices:", Name);
        }

        public void DisiplayChoices()
        {
            Console.Write("Type ");
            foreach(var item in  Choices)
            {
                Console.Write("'" + item.Key + "' ");
            }
            System.Console.WriteLine();
        }

        public void DisplayChoicesAndPrices()
        {
            System.Console.WriteLine();
            foreach (var item in Choices)
            {
                System.Console.WriteLine($"{item.Key} {Name} {item.Value.ToString("C2")}");
            }
        }

        public void GroupMethod()
        {
            Intro();
            


        }
    }
}