using favoriteThings.Things;
using System;

namespace favoriteThings
{
    class Program
    {
        public static void Main(string[] args)
        {
            var meal1 = new CookingBase
            {
                MealType = "Dinner",
                IsHealthy = false,
                Calories = 1560,
            };
            var meal2 = new CookingBase
            {
                MealType = "Breakfast",
                IsHealthy = true,
                
            };
            var garden1 = new GardeningBase
            {
                Type = "Fruit Garden",
                Location = "Indoors",
            };
            var garden2 = new GardeningBase
            {
                Type = "Veggie Garden",
                Location = "Outdoors",
            };
            var music1 = new MusicBase
            {
                Genre = "Hair Metal",
                Volume = 11,
            };
            var music2 = new MusicBase
            {
                Genre = "Shoegaze",
                Volume = 8,
            };
            var wine1 = new Wine
            {
                Name = "Rioja",
                Color = "Red",
                Alcohol = 20,
            };
            var wine2 = new Wine
            {
                Name = "Chardonnay",
                Color = "White",
                Alcohol = 11,
            };
            meal1.MakeDinner();
            meal2.MakeDinner();
            garden1.Growing();
            garden2.Growing();
            music1.Loud();
            music2.Loud();
            wine1.WineLegs();
            wine2.WineLegs();
        }
    }
}
