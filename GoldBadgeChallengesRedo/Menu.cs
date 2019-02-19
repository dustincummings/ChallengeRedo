using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldBadgeChallengesRedo
{
    class Menu
    {
        public int MealNumber { get; set; }
        public string Ingredient { get; set; }
        public string Description { get; set; }
        public string MealName { get; set; }
        public decimal Price { get; set; }

        public Menu(int mealNumber, string mealName, string ingredient, string description, decimal price)
        {
            this.MealNumber = mealNumber;
            this.MealName = mealName;
            this.Ingredient = ingredient;
            this.Description = description;
            this.Price = price;
        }
        public Menu() { }
    }
}
