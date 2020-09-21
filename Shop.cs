using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Shop
    {
        private int _gold;
        private int[] ShopIndex;
        public Shop()
        {
            _gold = 100;
            int[] ShopIndex = new int[3];
        }
        public Shop(int goldVal, int invSize)
        {
            _gold = goldVal;
            int[] ShopIndex = new int[invSize];
        }
        public bool Sell(Player player, Item item)
        {
            if (player.GetGold() >= item.cost)
                return true;
            else
                return false;

        }
    }
}
