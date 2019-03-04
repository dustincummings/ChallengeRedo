using System;
using System.Collections.Generic;
using System.Text;

namespace Badge_System
{
    public class Badge
    {
        public int BadgeId { get; set; }
        public List<string>  DoorList{ get; set; }

        public Badge(int badgeId, List<string> doorlist)
        {
            this.BadgeId = badgeId;
            this.DoorList = doorlist;
        }
        public Badge() { }
       
    }
}
