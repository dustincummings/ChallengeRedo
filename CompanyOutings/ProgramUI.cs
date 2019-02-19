using System;

namespace CompanyOutings
{
     class ProgramUI
    {

        OutingsRepo _outingsRepo = new OutingsRepo();
        Outings newOuting = new Outings();

        public void Run()
        {
            Outings disneyWorld = new Outings(OutingType.Park, 7, new DateTime(2017, 06, 15), 100.00m, 700.00m);
            Outings shinedown = new Outings(OutingType.Concert, 4, new DateTime(2012, 05, 30), 45.00m, 180.00m);
            Outings topGolf = new Outings(OutingType.Golf, 15, new DateTime(2019, 02, 14), 10.00m, 150.00m);
            _outingsRepo.AddOutingtolist(disneyWorld);
            _outingsRepo.AddOutingtolist(shinedown);
            _outingsRepo.AddOutingtolist(topGolf);

            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Choose a menu option:" +
                    "\n\t1. See list of all outings" +
                    "\n\t2. Add a new outing to list" +
                    "\n\t3. See cost of ALL outings" +
                    "\n\t4. See cost by outing Type" +
                    "\n\t5. Exit program");
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
                        SeeCostOfAllOutings();
                        break;
                    case 4:
                        SeeCostPerOutingType();
                        break;
                    case 5:
                        isRunning = false;
                        Console.WriteLine("You are now exiting the program");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("We entered an invalid selection. Please choose a valid option");
                        break;
                }

            }
        }
    }
}