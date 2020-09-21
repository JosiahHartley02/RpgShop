using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    //can not be in class game to be able to be used in other classes regardless of publicity
    struct Item
    {
        public int cost;
        public string name;
    }
    class Game
    {        
        //struct items called
        private Item _arrow;
        private Item _sheild;
        private Item _gem;
        //declare player with 100 gold
        private Player _player = new Player(100);
        //declare shop with 3 inventory slots
        private Shop _shop = new Shop(3);
        bool _gameOver = false;
        


        //Run the game
        public void Run()
        {
            Start();
            while (_gameOver == false)
            {
                Update();
            }
            End();
        }


        //Performed once when the game begins
        //used to initialize certain things
        public void Start()
        {
            InitItems();
        }

        //Repeated until the game ends
        public void Update()
        {
            Console.Clear();
            Console.WriteLine("                                                   Player Gold " + _player.GetGold());
            OpenShopMenu();
        }

        //Performed once when the game ends
        public void End()
        {
            Console.WriteLine("Thank you, please shop again!");
        }
        private void InitItems()
        {
            _gem.cost = 25;
            _gem.name = "Gem of create gem";
            _sheild.cost = 25;
            _sheild.name = "Sheild of deflect all";
            _arrow.cost = 25;
            _arrow.name = "Baby Seaking Arrow";
        }
        public void OpenShopMenu()
        {
            Console.WriteLine("Hello traveler, see anything you like?");
            Console.WriteLine("1. Gem");
            Console.WriteLine("2. Sheild");
            Console.WriteLine("3. Arrow");
            Console.WriteLine("4. Leave");
            char input = Console.ReadKey().KeyChar;
            while (input != '1' && input != '2' && input != '3' && input != '4')
            {
                switch(input)
                {
                    case '1':
                        
                    case '2':
                    case '3':
                    case '4':
                    default:
                        Console.WriteLine("Error please select a valid input");
                        break;
                }
            }
        }
       
    }
}

