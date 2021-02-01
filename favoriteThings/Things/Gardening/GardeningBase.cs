using System;
using System.Collections.Generic;
using System.Text;

namespace favoriteThings.Things
{
    public class GardeningBase
    {
        //Properties
        public string Type { get; set; }
        public string Location { get; set; }

        //Methods
        public void Growing()
        {
            if(Location == "Outdoors")
            {
                Console.WriteLine($"This {Type} is {Location}");
            }
            else if(Location == "Indoors")
            {
                Console.WriteLine($"This {Type} is {Location}");
            }
            
        }
    }
}
