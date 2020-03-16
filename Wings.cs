using System.Collections.Generic;

namespace Project0_2
{
    public class Wings : Product, IAddChoices
    {
        public Wings()
        {
            Name = "Wing";
            ProductChoices();
        }

        public Dictionary<string,double> ProductChoices()
        {
            Choices.Add("Tradional", 7.39);
            Choices.Add("Breaded Bone-Out", 7.5);
            Choices.Add("Dip", .79);

            return Choices;
        }
    }
}