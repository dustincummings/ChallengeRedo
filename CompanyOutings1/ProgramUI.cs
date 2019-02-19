using System;
using System.Collections.Generic;

namespace CompanyOutings1
{
    class ProgramUI
    {
        OutingRepo _outingRepo = new OutingRepo();
        Outing _outing = new Outing();

        public void Run()
        {
            Outing topGolf = new Outing(OutingType.Golf, 10, new DateTime(2019, 02, 14), 20.00m, 200.00m);
            Outing shinedown = new Outing(OutingType.Concert, 5, new DateTime(2017, 05, 16), 30.00m, 150.00m);
            Outing disneyWorld = new Outing(OutingType.AmusementPark, 3, new DateTime(2017, 06, 15), 100.00m, 300m);
            _outingRepo.AddOutingToList(topGolf);
            _outingRepo.AddOutingToList(shinedown);
            _outingRepo.AddOutingToList(disneyWorld);

            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Company Outings Page. Please choose one of the following options:" +
                    "\n\t1. See list of all of the Outings" +
                    "\n\t2. Add an Outing" +
                    "\n\t3. See the total cost of all the Outings" +
                    "\n\t4. See the total cost of an Outing type" +
                    "\n\t5. Exit Program");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        SeeListOfOutings();
                        break;
                    case 2:
                        AddOutingToList();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine($"The total cost for all of the outings is {_outingRepo.CalculateTotalCost():c}");
                        Console.ReadKey();
                        break;
                    case 4:
                        OutingCostByType();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Are you sure you want to exit the program? y/n");
                        string answer = Console.ReadLine().ToLower();
                        if (answer == "y")
                        {
                            isRunning = false;
                            Console.WriteLine("Good Bye");
                            Console.Read();
                        }
                        else
                            isRunning = true;
                        break;
                    default:
                        Console.WriteLine("We entered an invalid selection. Please choose a valid option");
                        break;
                }
            }
        }

        public void OutingCostByType()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("What outing type do you want to see the total for?" +
                    "\n\t1. Golf" +
                    "\n\t2. Bowling" +
                    "\n\t3. Amusement Park" +
                    "\n\t4. Concert" +
                    "\n\t5. Other");
                int input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        _outing.CostPerOuting = _outingRepo.CalculateCostByType(OutingType.Golf);
                        _outing.Type = OutingType.Golf;
                        isRunning = false;
                        break;
                    case 2:
                        _outing.CostPerOuting = _outingRepo.CalculateCostByType(OutingType.Bowling);
                        _outing.Type = OutingType.Bowling;
                        isRunning = false;
                        break;
                    case 3:
                        _outing.CostPerOuting = _outingRepo.CalculateCostByType(OutingType.AmusementPark);
                        _outing.Type = OutingType.AmusementPark;
                        isRunning = false;
                        break;
                    case 4:
                        _outing.CostPerOuting = _outingRepo.CalculateCostByType(OutingType.Concert);
                        _outing.Type = OutingType.Concert;
                        isRunning = false;
                        break;
                    case 5:
                        _outing.CostPerOuting = _outingRepo.CalculateCostByType(OutingType.Other);
                        _outing.Type = OutingType.Other;
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please Choose a valid option");
                        Console.ReadLine();
                        break;
                }
            }
            Console.WriteLine($"The total cost the {_outing.Type} outings is {_outing.CostPerOuting:c}");
            Console.ReadLine();
        }

        public void AddOutingToList()
        {
            Console.Clear();
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Please enter the number that corresponds with the event type:" +
                    "\n\t1. Golf" +
                    "\n\t2. Bowling" +
                    "\n\t3. Amusement Park" +
                    "\n\t4. Concert" +
                    "\n\t5. Other");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        _outing.Type = OutingType.Golf;
                        isRunning = false;
                        break;
                    case 2:
                        _outing.Type = OutingType.Bowling;
                        isRunning = false;
                        break;
                    case 3:
                        _outing.Type = OutingType.AmusementPark;
                        isRunning = false;
                        break;
                    case 4:
                        _outing.Type = OutingType.Concert;
                        isRunning = false;
                        break;
                    case 5:
                        _outing.Type = OutingType.Other;
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please Choose a valid option");
                        break;
                }
            }
                Console.WriteLine("How many people attended this outing?");
                _outing.NumOfPeople = int.Parse(Console.ReadLine());
                Console.WriteLine("What was the date of this outing? mm/dd/yyyy");
                _outing.DateOfOuting = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Do you know the total cost per person or the total cost?" +
                    "\n Please enter one of the following numbers" +
                    "\n\t1. Per Person" +
                    "\n\t2. Total for outing");
                int cost = int.Parse(Console.ReadLine());
                while (isRunning)
                    if (cost == 1)
                    {
                        Console.WriteLine("Enter in the cost person");
                        _outing.CostPerPerson = decimal.Parse(Console.ReadLine());
                        _outing.CostPerOuting = _outing.CostPerPerson * _outing.NumOfPeople;
                        isRunning = false;
                    }
                    else if (cost == 2)
                    {
                        Console.WriteLine("Enter in the total cost of outing");
                        _outing.CostPerOuting = decimal.Parse(Console.ReadLine());
                        _outing.CostPerPerson = _outing.CostPerOuting / _outing.NumOfPeople;
                        isRunning = false;
                    }
                    else
                        Console.WriteLine("Please choose a valid option");
            _outingRepo.AddOutingToList(_outing);
        }

        public void SeeListOfOutings()
        {
            Console.Clear();
            List<Outing> _outingList = _outingRepo.ViewListOfOutings();

            Console.WriteLine("Date\t Outing Type\t Number of People\t Cost Per Person\t Total Cost");
            foreach (Outing outing in _outingList)
            {
                Console.WriteLine($"{outing.DateOfOuting.ToShortDateString()}\t {outing.Type,-14}\t {outing.NumOfPeople,-6}\t {outing.CostPerPerson:c}\t {outing.CostPerOuting:c}");
            }
            Console.ReadLine();
        }
    }
}