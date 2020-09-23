using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Shop
    {
        private int _gold;
        private string[] ShopIndex;
        public Shop()
        {
            _gold = 100;
            string[] ShopIndex = new string[3];
        }
        public Shop(int goldVal, int inventorySize)
        {
            _gold = goldVal;
            Item[] ShopIndex = new Item[inventorySize];
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
