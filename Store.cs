using System.Collections.Generic;
namespace Project0_2
{
    public class Store
    {
        public string Name { get; set; }
        public List<Store> ListOfstore {get; set;} = new List<Store>();
        
    }
}