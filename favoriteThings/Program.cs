using favoriteThings.Things;
using System;

namespace favoriteThings
{
    class Program
    {
        public static void Main(string[] args)
        {
            var meal1 = new Cooking
            {
                MealType = "Dinner",
                IsHealthy = false,
                Calories = 1560,
            };
            var meal2 = new Cooking
            {
                MealType = "Breakfast",
                IsHealthy = true,
                
            };
            var garden1 = new Gardening
            {
                Type = "Fruit Garden",
                Location = "Indoors",
            };
            var garden2 = new Gardening
            {
                Type = "Veggie Garden",
                Location = "Outdoors",
            };
            var music1 = new Music
            {
                Genre = "Hair Metal",
                Volume = 11,
            };
            var music2 = new Music
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
            wine1.Legs();
            wine2.Legs();
        }
    }
}
