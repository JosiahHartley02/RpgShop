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
        private Player _player = new Player(100, 3);
        //declare shop with 3 inventory slots
        bool _gameOver = false;
        private Shop _shop = new Shop(0,3);
        Item[] shopInventory = new Item[3];



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
            shopInventory[0] = _gem;
            shopInventory[1] = _sheild;
            shopInventory[2] = _arrow;
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
            Console.WriteLine("1. " + _gem.name);
            Console.WriteLine("2. " + _sheild.name);
            Console.WriteLine("3. " + _arrow.name);
            Console.WriteLine("4. Leave");
            Console.WriteLine("5. Open Inventory");
            char input = '9';
            while (input != '1' && input != '2' && input != '3' && input != '4' && _gameOver == false && input != '5')
            {
                input = Console.ReadKey().KeyChar;
                switch (input)
                {
                    case '1':
                        if (_shop.Sell(_player, _gem))
                        {
                            //need to voidify some of this code, lots of repeats
                            //i actually dont know if this works tbh
                            //i cant think today drained me
                            PrintInventory(_player);
                            Console.WriteLine("Which space would you like to store your item?");
                            StoreItem(_player, _gem);
                        }
                        else
                        {
                            Console.WriteLine("Sorry but it appears that your drip is lacking");
                            Console.ReadKey();
                        }
                        break;

                    case '2':
                        if (_shop.Sell(_player, _sheild))
                        {
                            PrintInventory(_player);
                            Console.WriteLine("Which space would you like to store your item?");
                            StoreItem(_player, _sheild);
                        }
                        else
                        {
                            Console.WriteLine("Sorry but it appears that your drip is lacking");
                            Console.ReadKey();
                        }
                        break;
                    case '3':
                        if (_shop.Sell(_player, _arrow))
                        {
                            PrintInventory(_player);
                            Console.WriteLine("Which space would you like to store your item?");
                            StoreItem(_player, _arrow);
                        }
                        else
                        {
                            Console.WriteLine("Sorry but it appears that your drip is lacking");
                            Console.ReadKey();
                        }
                        break;
                    case '4':
                        _gameOver = true;
                        break;
                    case '5':
                        PrintInventory(_player);
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
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
        public void StoreItem(Player player, Item itemName)
        {
            char storageinputchar = ' ';
            int storageinput = 9;
            while (storageinputchar != '1' && storageinputchar != '2' && storageinputchar != '3')
            {
                storageinputchar = Console.ReadKey().KeyChar;
                if (storageinputchar == '1')
                {
                    storageinput = 0;
                }
                else if (storageinputchar == '2')
                {
                    storageinput = 1;
                }
                else if (storageinputchar == '3')
                {
                    storageinput = 2;
                }
                else
                {
                    Console.WriteLine("Error please select a valid option");
                }
            }
            player.Buy(itemName, storageinput);
        }
        
    }
}