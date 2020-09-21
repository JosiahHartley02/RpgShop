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
        bool _gameOver = false;
        private Shop _shop = new Shop(0, 3);



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
            char input = '9';
            while (input != '1' && input != '2' && input != '3' && input != '4' && _gameOver == false)
            {
                input = Console.ReadKey().KeyChar;
                switch (input)
                {
                    case '1':
                        if (_shop.Sell(_player, _gem))
                        {
                            Console.WriteLine("Where would you like to store your newly bought gem?");
                            PrintInventory(_player);
                            Console.WriteLine("Which space would you like to store your item?");
                            char storageinputchar = ' ';
                            int storageinput = 9;
                            while (storageinputchar != '1' && storageinputchar != '2' && storageinputchar != '3')
                            {
                                storageinputchar = Console.ReadKey().KeyChar;                                
                                if (storageinputchar == '1')
                                {
                                    storageinput = 1;
                                }
                                if (storageinputchar == '2')
                                {
                                    storageinput = 2;
                                }
                                if (storageinputchar == '3')
                                {
                                    storageinput = 3;
                                }
                                else
                                    Console.WriteLine("Error please select a valid option");
                            }
                            _player.Buy(_gem, storageinput);
                        }
                        else
                        {
                            Console.WriteLine("Sorry no can do");
                        }
                        break;

                    case '2':
                        if (_shop.Sell(_player, _sheild))
                        {
                            Console.WriteLine("Where would you like to store your newly bought gem?");
                            PrintInventory(_player);
                            Console.WriteLine("Which space would you like to store your item?");
                            char storageinputchar = ' ';
                            int storageinput = 9;
                            while (storageinputchar != '1' && storageinputchar != '2' && storageinputchar != '3')
                            {
                                storageinputchar = Console.ReadKey().KeyChar;
                                if (storageinputchar == '1')
                                {
                                    storageinput = 1;
                                }
                                if (storageinputchar == '2')
                                {
                                    storageinput = 2;
                                }
                                if (storageinputchar == '3')
                                {
                                    storageinput = 3;
                                }
                                else
                                    Console.WriteLine("Error please select a valid option");
                            }
                            _player.Buy(_sheild, storageinput);
                        }
                        else
                        {
                            Console.WriteLine("Sorry no can do");
                        }
                        break;
                    case '3':
                        if (_shop.Sell(_player, _arrow))
                        {
                            Console.WriteLine("Where would you like to store your newly bought gem?");
                            PrintInventory(_player);
                            Console.WriteLine("Which space would you like to store your item?");
                            char storageinputchar = ' ';
                            int storageinput = 9;
                            while (storageinputchar != '1' && storageinputchar != '2' && storageinputchar != '3')
                            {
                                storageinputchar = Console.ReadKey().KeyChar;
                                if (storageinputchar == '1')
                                {
                                    storageinput = 1;
                                }
                                if (storageinputchar == '2')
                                {
                                    storageinput = 2;
                                }
                                if (storageinputchar == '3')
                                {
                                    storageinput = 3;
                                }
                                else
                                    Console.WriteLine("Error please select a valid option");
                            }
                            _player.Buy(_arrow, storageinput);
                        }
                        else
                        {
                            Console.WriteLine("Sorry no can do");
                        }
                        break;
                    case '4':
                        _gameOver = true;
                        break;
                    default:
                        Console.WriteLine("Error please select a valid input");
                        break;
                }
            }
        }
        public void PrintInventory(Player player)
        {
            player.GetInventory();
        }
    }
}

