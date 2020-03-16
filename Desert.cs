using System.Collections.Generic;

namespace Project0_2
{
    public class Desert : Product, IAddChoices
    {
        public Desert()
        {
            Name = "Drinks";
            ProductChoices();
        }

        public Dictionary<string,double> ProductChoices()
        {
            Choices.Add("Mini Sweet Rolls", 5.99);
            Choices.Add("Cinnamon Rolls", 4.99);
            Choices.Add("Brownie", 6.99);
            Choices.Add("Icing Dip", .79);

            return Choices;
        }
    }
}