using System;
using System.Collections.Generic;
using System.Text;

namespace favoriteThings.Things
{
    public class MusicBase
    {
        //Properties
        public string Genre { get; set; }
        public int Volume { get; set; }

        //Methods
        public void Loud()
        {
            if (Volume > 10)
            {
                Console.WriteLine($"THIS {Genre} IS LOUD");
            }
            else
            {
                Console.WriteLine($"Perfect volume {Genre} for your grandparents.");
            }
            
        }
    }
}
