using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadgeSystem
{
    class Badge
    {
        public int BadgeId { get; set; }
        public List<string> DoorList { get; set; }

        public Badge(int badgeId, List<string> doorlist)
        {
            this.BadgeId = badgeId;
            this.DoorList = doorlist;
        }
        public Badge() { }

    }
}
