using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyOutings1
{
    class OutingRepo
    {
        List<Outing> _outingsList = new List<Outing>();

        public void AddOutingToList(Outing outing)
        {
            _outingsList.Add(outing);
        }
        public List<Outing> ViewListOfOutings()
        {
            return _outingsList;
        }
        public decimal CalculateTotalCost()
        {
            decimal total = 0;
            foreach (Outing o in _outingsList)
            {
                total += o.CostPerOuting;
            }
            return total;
        }
        public decimal CalculateCostByType(OutingType type)
        {
            decimal typeTotal = 0;
            foreach (Outing t in _outingsList)
            {
                if (type == t.Type)
                typeTotal += t.CostPerOuting;
            }
            return typeTotal;
        }

    }
}
