using System;
using System.Numerics;
using Tamagotchi.Core.Enums;
using Tamagotchi.Core.Models;

namespace Tamagotchi.Tools
{
    public class Utils
    {
        public static Player NewPlayer()
        {
            string name;
            AItem[] inventory = LoadInventory();//List<AItem>

            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Player player = new Player(name, inventory, null);

            return player;
            
        }
        public static AItem[] LoadInventory()//List<AItem>
        {
            AItem[] listItems = new AItem[13];//List<AItem>  List<AItem>(13)
            FoodStuff meal = new("meal", TypeItem.FoodStuff, TypeFood.Meal);
            FoodStuff snack = new("snack", TypeItem.FoodStuff, TypeFood.Snack);
            FoodStuff water = new("water", TypeItem.FoodStuff, TypeFood.Water);
            FoodStuff soda = new("soda", TypeItem.FoodStuff, TypeFood.Soda);
            Toy ball = new("ball", TypeItem.Toy, TypeToy.Ball);
            Toy teddybear = new("teddybear", TypeItem.Toy, TypeToy.TeddyBear);
            Toy laser = new("laser", TypeItem.Toy, TypeToy.Laser);
            Toy cardboardbox = new("cardboardbox", TypeItem.Toy, TypeToy.CardboardBox);
            Toy rope = new("rope", TypeItem.Toy, TypeToy.Rope);
            Medicine paracetamol = new("paracetamol", TypeItem.Medicine, TypeMedicine.Paracetamol);
            Medicine nolotil = new("nolotil", TypeItem.Medicine, TypeMedicine.Nolotil);
            Medicine ibuprofeno = new("ibuprofeno", TypeItem.Medicine, TypeMedicine.Ibuprofeno);
            Medicine syringe = new("syringe", TypeItem.Medicine, TypeMedicine.Syringe);
            listItems[0] = meal; //listItems.Add(meal);
            listItems[1] = snack; //listItems.Add(snack);
            listItems[2] = water; //listItems.Add(water);
            listItems[3] = soda; //listItems.Add(soda);
            listItems[4] = ball; //listItems.Add(ball);
            listItems[5] = teddybear; //listItems.Add(teddybear);
            listItems[6] = laser; //listItems.Add(laser);
            listItems[7] = cardboardbox; //listItems.Add(cardboardbox);
            listItems[8] = rope; //listItems.Add(rope);
            listItems[9] = paracetamol; //listItems.Add(paracetamol);
            listItems[10] = nolotil; //listItems.Add(nolotil);
            listItems[11] = ibuprofeno; //listItems.Add(ibuprofeno);
            listItems[12] = syringe; //listItems.Add(syringe);

            return listItems;
        }
        public static Cat NewCat()
        {
            string name;
            Stats stats = new Stats();
            
            Console.Write("Enter the name of the cat: ");
            name = Console.ReadLine();
            Cat garfield = new Cat(name, Core.Enums.TypeState.Happy, stats, Core.Enums.TypePet.Cat);

            return garfield;
        }
        public static Dog NewDog()
        {
            string name;
            Stats stats = new Stats();
            
            Console.Write("Enter the name of the dog: ");
            name = Console.ReadLine();
            Dog clifford = new Dog(name, Core.Enums.TypeState.Happy, stats, Core.Enums.TypePet.Dog);

            return clifford;
        }
        public static Chick NewChick()
        {
            string name;
            Stats stats = new Stats();
            
            Console.Write("Enter the name of the chick: ");
            name = Console.ReadLine();
            Chick piolin = new Chick(name, Core.Enums.TypeState.Happy, stats, Core.Enums.TypePet.Chick);

            return piolin;
        }
        public static int ValidateOption(int min, int max)
        {
            int option;

            while (!int.TryParse(Console.ReadLine(), out option) || (option < min || option > max))
            {
                Console.Write("Invalid option. Enter a valid number: ");
            }

            return option;
        }
        public static string DrawBar(int value)
        {
            int totalBlocks = 20;
            int filledBlocks = value * totalBlocks / 100;

            return "[" +
                   new string('#', filledBlocks) +
                   new string('-', totalBlocks - filledBlocks) +
                   $"] {value}%";
        }
        public static TypeState CalculateState(APet pet)
        {
            if (pet.Stats.Health <= 20) return TypeState.Sick;
            if (pet.Stats.Energy <= 50) return TypeState.Tired;
            if (pet.Stats.Hunger <= 50) return TypeState.Angry;
            if (pet.Stats.Health <= 50) return TypeState.Sad;
            return TypeState.Happy;
        }
        public static bool IsSick(APet pet)
        {
            if (pet.Stats.Health <= 20) return false;
            return true;
        }
        public static void AddItem(Player player)
        {
            int option;
            string name;
            //AItem aux = null;

            //AItem[] aux = new AItem
            Player player1 = new Player("paco", null, null);

            Console.Clear();
            Console.WriteLine("╔════════════════════════════════╗");
            Console.WriteLine("║            New Item            ║");
            Console.WriteLine("║                                ║");
            Console.WriteLine("║ 1. FoodStuff                   ║");
            Console.WriteLine("║ 2. Toy                         ║");
            Console.WriteLine("║ 3. Medicine                    ║");
            Console.WriteLine("╚════════════════════════════════╝");
            option = ValidateOption(1, 3);
            Console.Write("Enter the name:");
            name = Console.ReadLine();
            switch (option)
            {
                case 1:
                    FoodStuff foodStuff = new FoodStuff(name, TypeItem.FoodStuff, TypeFood.Meal);
                    break;
                case 2:
                    Toy toy = new Toy(name, TypeItem.Toy, TypeToy.Ball);
                    break;
                case 3:
                    Medicine medicine = new Medicine(name, TypeItem.Medicine, TypeMedicine.Paracetamol);
                    break;
            }
            //if (aux != null)
                //player.Inventory.Add(aux);
            
        }
    }
}