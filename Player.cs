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
            Console.WriteLine("Players inventory");
            for (int i = 0; i < _inventory.Length; i++)
            {
                Console.WriteLine(_inventory[i]);
            }
            Console.WriteLine("Press any key to return to shop");
            Console.ReadKey();
            Console.Clear();
        }
        public void Buy(string nameVal, int costVal)
        {
            if (_gold >= costVal)
            {
                _gold -= costVal;
                Console.WriteLine("You just bought " + nameVal + " for " + costVal + " gold!");
                Console.WriteLine("Press any key to return to shop");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                int i = _gold;
                int j = costVal;
                int k = 0;
                i -= j = k;
                Console.WriteLine("Terribly sorry but you are " + k + " gold too short, please get them bands up, and dont hit me up when I make it");
                Console.WriteLine("Press any key to return to shop");
                Console.ReadKey();
            }
        }
    }
}
