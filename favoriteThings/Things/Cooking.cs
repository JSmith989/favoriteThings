using System;
using System.Collections.Generic;
using System.Text;

namespace favoriteThings.Things
{
    public class Cooking
    {
        //Properties
        public string MealType { get; set; }
        public bool IsHealthy { get; set; } = true;
        public int Calories { get; set; }

        //Methods
        public void MakeDinner()
        {
            if(Calories > 1000)
            {
               Console.WriteLine($"This {MealType} has {Calories} calories?? DAMN");
            }
            else
            {
                Console.WriteLine($"This healthy {MealType} has {Calories} calories.");
            }
            
        }
    }
}
