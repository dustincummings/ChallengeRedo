using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldBadgeChallengesRedo
{
    class MenuRepo
    {
        List<Menu> _menuList = new List<Menu>();

        public void AddToList(Menu item)
        {
            _menuList.Add(item);
        }
        public void RemoveFromList(Menu item)
        {
            _menuList.Remove(item);
        }
        public List<Menu> GetMenu()
        {
            return _menuList;
        }
    }
}
