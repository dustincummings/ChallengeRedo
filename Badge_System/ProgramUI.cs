using System;
using System.Collections.Generic;

namespace Badge_System
{
    public class ProgramUI
    {
        List<string> _newDoor = new List<string>();
        BadgeRepo _badgeRepo = new BadgeRepo();
        Badge _newBadge = new Badge();
        Dictionary<int, List<string>> _newBadgeDictionary = new Dictionary<int, List<string>>();

        public void Run()
        {

            List<string> doorSetOne = new List<string>() { "a1", "b2", };
            List<string> doorSetTwo = new List<string>() { "c5", "b6", };

            Badge badgeOne = new Badge(123, doorSetOne);
            Badge badgeTwo = new Badge(321, doorSetTwo);

            _badgeRepo.AddBadgeToDictionay(badgeOne);
            _badgeRepo.AddBadgeToDictionay(badgeTwo);

            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("Welcome Security Admin, What action would you like to take?" +
                    "\n\t1. Create New Badge" +
                    "\n\t2. Add Door Access to Existing Badge" +
                    "\n\t3. Remove All Door Access From a an Existing Badge" +
                    "\n\t4. Show All Badges in the System" +
                    "\n\t5. Exit Program");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        CreateNewBadge();
                        break;
                    case 2:
                        UpdateBadge();
                        break;
                    case 3:
                        break;
                    case 4:
                        ShowAllBadges();
                        break;
                    case 5:
                        break;
                    default:
                        break;
                }

            }
        }
        public void CreateNewBadge()
        {
            Console.Clear();
            Console.WriteLine("Please enter ID number!");
            _newBadge.BadgeId = int.Parse(Console.ReadLine());
            _newBadge.DoorList = AddDoor();
            _badgeRepo.AddBadgeToDictionay(_newBadge);
        }
        public List<string> AddDoor()
        {
            var doorList = new List<string>();

            bool addingDoor = true;
            while (addingDoor)
            {
                Console.WriteLine("Please enter in door you would like to give access to. (A1, B2, C3, etc..)");
                _newDoor.Add(Console.ReadLine().ToUpper());
                Console.Clear();
                Console.WriteLine("Are there more doors to add? y/n");
                string reponse = Console.ReadLine().ToLower();
                if (reponse == "y")
                    addingDoor = true;
                else if (reponse != "y")
                    addingDoor = false;
            }
            return doorList;
        }
        public void UpdateBadge()
        {
            Console.Clear();
            Dictionary<int, List<string>> badges = _badgeRepo.GetBadgeList();

            Console.WriteLine($"Please type in the number of the badge that you would like to update" +
                $"\n\n Badge#");

            foreach (KeyValuePair<int, List<string>> key in _badgeRepo.GetBadgeList())
            {
                Console.WriteLine($" {key.Key}");
            }
            int input = int.Parse(Console.ReadLine());
            if (badges.ContainsKey(input))
            {
                
                Console.WriteLine($"How would you like to update {_newBadgeDictionary.Keys}:" +
                "\n\t1. Add Door Access to Badge" +
                "\n\t2. Remove Door Access from Badge" +
                "\n\t3. Return to Main Menu");
            }
            Console.WriteLine("How would you like to update this badge:" +
                "\n\t1. Add Door Access to Badge" +
                "\n\t2. Remove Door Access from Badge" +
                "\n\t3. Return to Main Menu");
            //int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    AddDoor();
                    break;
                case 2:
                    RemoveDoor();
                    break;

                default:
                    break;
            }
        }
        public List<string> RemoveDoor()
        {
            //_badgeRepo.GetBadge();
            var doorList = new List<string>();



            bool addingDoor = true;
            while (addingDoor)
            {
                Console.WriteLine("Please enter in door you would like to give access to. (A1, B2, C3, etc..)");
                _newDoor.Add(Console.ReadLine().ToUpper());
                Console.Clear();
                Console.WriteLine("Are there more doors to add? y/n");
                string reponse = Console.ReadLine().ToLower();
                if (reponse == "y")
                    addingDoor = true;
                else if (reponse != "y")
                    addingDoor = false;
            }
            return doorList;
        }

        public void ShowAllBadges()
        {
            Console.Clear();

            foreach (KeyValuePair<int, List<string>> key in _badgeRepo.GetBadgeList())
            {
                string doorList = "";
                foreach (string value in key.Value)
                {
                    doorList += value + ",";
                }
                Console.WriteLine($"Badge # {key.Key} has access to these doors: {doorList.ToUpper()}");
            }
            Console.ReadLine();
        }

    }
}