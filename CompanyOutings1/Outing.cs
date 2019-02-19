using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyOutings1
{
    enum OutingType { Golf = 1, Bowling, AmusementPark, Concert, Other }
    class Outing
    {
        public OutingType Type { get; set; }
        public int NumOfPeople { get; set; }
        public DateTime DateOfOuting { get; set; }
        public decimal CostPerPerson { get; set; }
        public decimal CostPerOuting { get; set; }

        public Outing(OutingType type, int numOfPeople, DateTime dateOfOuting, decimal costPerPerson, decimal costPerOuting)
        {
            this.Type = type;
            this.NumOfPeople = numOfPeople;
            this.DateOfOuting = dateOfOuting;
            this.CostPerPerson = costPerPerson;
            this.CostPerOuting = costPerOuting;
        }
        public Outing() { }
    }
}
