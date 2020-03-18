using System;
using System.Collections.Generic;

namespace Project0_2
{
    public class Customer
    {

        //Make if else statement if they want to save their list or not
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street {get; set;}
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public string PhoneNum { get; set; }
        public string Email {get; set;}
        public int UID {get; set;} = 12345679;
        public Dictionary<string, double> CustOrder { get; set; } = new Dictionary<string, double>();
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Password2 { get; set; }

        public void NewCustomer()
        {
            Console.Write("Please enter your first name: ");
            FirstName = Console.ReadLine();
            System.Console.WriteLine();
            Console.Write($"OK, {FirstName}, now enter your last name: ");
            LastName = Console.ReadLine();
            Console.WriteLine();
            Console.Write("What is your street address? ");
            Street = Console.ReadLine();
            System.Console.WriteLine();
            System.Console.Write("What is your state? ");
            State = Console.ReadLine();
            System.Console.WriteLine();
            Console.Write("What is your zip code? ");
            ZipCode = int.Parse(Console.ReadLine());
            System.Console.WriteLine();
            Console.Write("What is your Phone number");
            PhoneNum = Console.ReadLine();
            System.Console.WriteLine();
            Console.Write("What is your email address");
            Email = Console.ReadLine();
            UID++;

            PrintInfo();
            System.Console.WriteLine("Great now setup a Username and Password");
            UserNameAndPass();
            CustOrder.Add("cheese", 10);
        }

        public void PrintInfo()
        {
            System.Console.WriteLine();
            Console.WriteLine("Just to verify");
            Console.WriteLine($"Your name is {FirstName} {LastName}");
            Console.WriteLine($"Your address is {Street} {City}, {State} {ZipCode}");
            System.Console.WriteLine($"Your phone number is {PhoneNum} and your email is {Email}");
            System.Console.WriteLine();
            System.Console.WriteLine("Is this information corret? (y/n) ");
            string yOrN = Console.ReadLine();
            if(yOrN == "n")
            {
                System.Console.WriteLine("Sorry to hear that. Let's do it again");
                NewCustomer();
            }
            else
            {
                System.Console.WriteLine("Well, great! Welcome to Pizza Planet!");
            }
        }

        public void UserNameAndPass()
        {
            Console.Write("Enter your username: ");
            UserName = Console.ReadLine();
            System.Console.WriteLine();
            CheckPassword();
            
        }

        public void CheckPassword()
        {
            Console.Write("Enter your password: ");
            Password = Console.ReadLine();
            System.Console.WriteLine();
            Console.Write("Verify your password again: ");
            Password2 = Console.ReadLine();

            if(Password != Password2)
            {
                System.Console.WriteLine("Sorry, your password didn't match. Try again");
                CheckPassword();
            }
        }
    }
}