using System;
using System.Collections.Generic;
using System.Text;

namespace favoriteThings.Things
{
    public class Wine
    {
        // Properties
        public string Name { get; set; }
        public string Color { get; set; }
        public int Alcohol { get; set; }

        //Methods
        public void Legs()
        {
            if (Alcohol > 15 )
            {
                Console.WriteLine($"This strong {Color} {Name} is {Alcohol}% ABV");
            }
            else
            {
                Console.WriteLine($"This {Color} {Name} has a normal {Alcohol}% ABV");
            }
            
        }
    }
}
