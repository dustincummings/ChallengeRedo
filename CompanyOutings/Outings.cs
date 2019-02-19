using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyOutings
{
     enum OutingType { Golf =1 , Bowling, Park, Concert, Other}

    class Outings
    {
        public OutingType Type { get; set; }
        public int NumPeopleAttended { get; set; }
        public DateTime DateOfEvent { get; set; }
        public decimal CostPerPerson { get; set; }
        public decimal TotalCost { get; set; }


        public Outings(OutingType type, int numPeopleAttended, DateTime dateOfEvent, decimal costPerPerson,  decimal totalCost)
        {
            this.Type = type;
            this.NumPeopleAttended = numPeopleAttended;
            this.DateOfEvent = dateOfEvent;
            this.CostPerPerson = costPerPerson;
            this.TotalCost = totalCost;
        }
        public Outings() { }
    }
}
