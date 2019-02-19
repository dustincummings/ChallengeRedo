using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldBadgeChallengesRedo
{
    public class ProgramUI
    {
        MenuRepo _menuRepo = new MenuRepo();
        public void Run()
        {
            Menu hamburger = new Menu(1, "Hamburger", "hamburger and bun", "1/4 pound hamburger", 4.00m);
            Menu chickenSandwhich = new Menu(2, "Chicken Sandwhich", "chicken breast and bun", "Crispy Chicken Sandwhich", 5.00m);

            _menuRepo.AddToList(hamburger);
            _menuRepo.AddToList(chickenSandwhich);

            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("Choose an action:"+
                    "\n\t1. Create new Menu Item" +
                    "\n\t2. List entire Menu" +
                    "\n\t3. Remove Menu Item" +
                    "\n\t4. Exit");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1: 
                        CreateItem();
                        break;
                    case 2: 
                        PrintMenu();
                        break;
                    case 3: 
                        RemoveItem();
                        break;
                    case 4: 
                        isRunning = false;
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Please choose a valid option!!");
                        Console.ReadLine();
                        break;
                }
            }
        }

        private void RemoveItem()
        {
            Console.Clear();
            List<Menu> menu = _menuRepo.GetMenu();

            Console.WriteLine("\n Please type in the number of the menu item that you would like to remove.");
            foreach(Menu item in menu)
                Console.WriteLine($"{item.MealNumber}\t{item.MealName}");

            var removedItem = int.Parse(Console.ReadLine());
            foreach (Menu item in menu)
            {
                if (removedItem == item.MealNumber)
                {
                    _menuRepo.RemoveFromList(item);
                    break;
                }
            }
        }

        private void PrintMenu()
        {
            Console.Clear();
            List<Menu> menu = _menuRepo.GetMenu();

            foreach (Menu item in menu)
                Console.WriteLine($"{item.MealNumber}\t{item.MealName}\t{item.Ingredient}\t{item.Description}\t{item.Price:C}");

            Console.ReadLine();
        }

        private void CreateItem()
        {
            Console.Clear();
            Menu newMenuItem = new Menu();

            Console.WriteLine("What is the number for this menu item?");
            newMenuItem.MealNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("\nWhat is the name of this menu item?");
            newMenuItem.MealName = Console.ReadLine();
            Console.WriteLine("\nWrite a brief description of this menu item!");
            newMenuItem.Description = Console.ReadLine();
            Console.WriteLine("\nList all of the ingredients of this menu item.");
            newMenuItem.Ingredient = Console.ReadLine();
            Console.WriteLine("\nHow much would you like to charge for this menu item?");
            newMenuItem.Price = decimal.Parse(Console.ReadLine());

            _menuRepo.AddToList(newMenuItem);
        }
    }
}
