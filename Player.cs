using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HelloWorld
{
    class Player
    {
        private int _gold;
        private int[] _inventory = new int[3];
        public Player()
        {
            _gold = 100;
        }
        public Player(int goldVal)
        {
            _gold = goldVal;
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
                Console.WriteLine(_inventory[i]);
            }
        }
        public void Buy(Item item, int InventoryIndex)
        {
                _gold -= item.cost;
                Console.WriteLine("You just bought " + item.name + " for " + item.cost + " gold!");
                Console.WriteLine("Press any key to return to shop");
                Console.ReadKey();
                Console.Clear();
        }
    }
}
