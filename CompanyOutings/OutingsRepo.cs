using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyOutings
{
    class OutingsRepo
    {
        List<Outings> list = new List<Outings>();
        public void AddOutingtolist(Outings outing)
        {
            list.Add(outing);
        }

    }
}
