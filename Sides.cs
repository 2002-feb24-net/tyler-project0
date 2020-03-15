using System.Collections.Generic;

namespace Project0_2
{
    public class Sides : Product, IAddChoices
    {
        public Dictionary<string,double> ProductChoices()
        {
            Choices.Add("Stuffed Garlic Knots", 5.99);
            Choices.Add("Breadsticks", 4.99);
            Choices.Add("Cheesesticks", 5.99);
            Choices.Add("Fries", 2.99);

            return Choices;
        }
    }
}