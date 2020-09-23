using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HelloWorld
{
    class Player
    {
        
        private Item _placeholder;
        private int _gold;
        private Item[] _inventory;
        public Player()
        {
            _placeholder.name = "Empty Slot";
            _gold = 100;
            for (int i = 0; i < _inventory.Length; i++)
            {
                _inventory[i] = _placeholder;
            }
        }
        public Player(int goldVal, int inventorySize)
        {
            _placeholder.name = "Empty Slot";
            _gold = goldVal;
            _inventory = new Item[inventorySize];
            for (int i = 0; i < inventorySize; i++)
            {
                _inventory[i] = _placeholder;
            }
        }
        public int GetGold()
        {
            return _gold;
        }
        public void GetInventory()
        {
            Console.Clear();
            Console.WriteLine("Players inventory");
            for (int i = 0; i < _inventory.Length; i++)
            {
                Console.WriteLine(_inventory[i].name);
            }
        }
        public void Buy(Item item, int InventoryIndex)
        {
            _gold -= item.cost;
            Console.WriteLine("You just bought " + item.name + " for " + item.cost + " gold!");
            Console.WriteLine("Press any key to return to shop");
            _inventory[InventoryIndex] = item;
            Console.ReadKey();
            Console.Clear();
        }
    }
}
