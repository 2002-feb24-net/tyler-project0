using System.Collections.Generic;

namespace Project0_2
{
    public class Drinks : Product, IAddChoices
    {
        public Drinks()
        {
            Name = "Drinks";
            ProductChoices();
        }

        public Dictionary<string,double> ProductChoices()
        {
            Choices.Add("Pepsi", 1.99);
            Choices.Add("Sprite", 1.99);
            Choices.Add("Dr. Pepper", 1.99);
            Choices.Add("Root Beer", 2.99);

            return Choices;
        }
    }
}