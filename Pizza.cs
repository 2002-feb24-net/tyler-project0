using System.Collections.Generic;

namespace Project0_2
{
    public class Pizza : Product, IAddChoices
    {
        public Pizza()
        {
            Name = "Pizza";
            ProductChoices();
        }
        
        public Dictionary<string,double> ProductChoices()
        {
            Choices.Add("Pepperoni", 12);
            Choices.Add("Cheese", 11);
            Choices.Add("Supreme", 13);

            return Choices;
        }
    }
}