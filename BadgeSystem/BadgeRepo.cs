using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadgeSystem
{
    class BadgeRepo
    {
        List<string> _doorList = new List<string>();
        Dictionary<int, List<string>> _badgeDictionary = new Dictionary<int, List<string>>();


        public void AddDoorToList(string door)
        {
            _doorList.Add(door);
        }
        public void RemoveDoorFromList(string door)
        {
            _doorList.Remove(door);
        }
        public void AddBadgeToDictionay(Badge badge)
        {
            _badgeDictionary.Add(badge.BadgeId, badge.DoorList);
        }
        public Dictionary<int, List<string>> GetBadgeList()
        {
            return _badgeDictionary;
        }
        public Badge GetBadge(Badge badge)
        {
            _badgeDictionary.ContainsKey(badge.BadgeId);
            return badge;
        }
    }
}
