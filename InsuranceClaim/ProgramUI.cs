using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceClaim
{
    class ProgramUI
    {
        ClaimRepo _claimRepo = new ClaimRepo();
        Queue<Claim> _claimQueue = new Queue<Claim>();

        public void Run()
        {
            Claim home = new Claim(1, "home", "fire", 1500.00m, "12/20/2018", "12/21/2018", true);
            Claim auto = new Claim(2, "auto", "accident", 200.00m, "12/20/2017", "4/20/2018", false);

            _claimRepo.AddClaimToQueue(home);
            _claimRepo.AddClaimToQueue(auto);

            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();

                Console.WriteLine("Please choose a menu option" +
                    "\n1. See all of the claims in the queue." +
                    "\n2. Take care of the next claim in the queue" +
                    "\n3. Enter in a new claim" +
                    "\n4. Exit");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        ShowClaimsInQueue();
                        break;
                    case 2:
                        RemoveClaimFromQueue();
                        break;
                    case 3:
                        AddClaimToQueue();
                        break;
                    case 4:
                        isRunning = false;
                        Console.WriteLine("You are now exiting out of the program. Good Bye!!");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("You did not enter in a valid option. Please reenter your option");
                        break;
                }
            }
        }

        private void ShowClaimsInQueue()
        {
            _claimQueue = _claimRepo.ShowClaimsQueue();
            Console.Clear();

            Console.WriteLine("Claim ID# \t Claim Type \t Description of Claim\t Claim Amount \t Date of Incident \t Date of Claim \t Is Claim Valid");
            foreach (Claim claim in _claimQueue)
            {
                Console.WriteLine($"{claim.ClaimID} \t {claim.ClaimType} \t {claim.Description} \t {claim.ClaimAmount:c2} \t {claim.DateOfIncident} \t {claim.DateOfClaim} \t {claim.IsVaild}");
            }
            Console.ReadLine();
        }

        private void RemoveClaimFromQueue()
        {
            _claimQueue = _claimRepo.ShowClaimsQueue();
            Console.Clear();
            Console.WriteLine("The next claim in the queue is:");
            Console.WriteLine($"{_claimQueue.Peek()}");

            Console.WriteLine("Would you like to handle this claim? (y/n)");
            string handleClaim = Console.ReadLine().ToLower();
            if (handleClaim == "y")
                _claimRepo.RemoveClaim();

        }

        private void AddClaimToQueue()
        {
            Claim claim = new Claim();

            Console.Clear();
            Console.WriteLine("What is the claim ID number for this claim?");
            claim.ClaimID = int.Parse(Console.ReadLine());
            Console.WriteLine("What type of claim is this claim?");
            claim.ClaimType = Console.ReadLine();
            Console.WriteLine("Please give a description of this claim.");
            claim.Description = Console.ReadLine();
            Console.WriteLine("How much is the claim for?");
            claim.ClaimAmount = decimal.Parse(Console.ReadLine());
            Console.WriteLine("On what date did this claim take place? mm/dd/yyyy");
            claim.DateOfIncident = Console.ReadLine();
            Console.WriteLine("On what date was this claim reported? mm/dd/yyyy");
            claim.DateOfClaim = Console.ReadLine();
            claim.IsVaild = _claimRepo.GetBoolan(claim);

            _claimRepo.AddClaimToQueue(claim);
        }
    }
}
