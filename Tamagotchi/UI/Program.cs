using System;
using System.Net.WebSockets;
using Tamagotchi.Core.Models;
using Tamagotchi.Tools;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main()
    {
        Starting();
    }
    public static void Starting()
    {
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine("Starting aplication .");
            Thread.Sleep(700);
            Console.Clear(); 
            Console.WriteLine("Starting aplication ..");
            Thread.Sleep(700);
            Console.Clear(); 
            Console.WriteLine("Starting aplication ...");
            Thread.Sleep(700);
            Console.Clear();
        }
        ShowMenu();
    }
    public static void ShowMenu()
    {
        int option, selectpet;
        Console.Clear();
        Console.WriteLine("╔════════════════════════════════╗");
        Console.WriteLine("║            Main Menu           ║");
        Console.WriteLine("║                                ║");
        Console.WriteLine("║    1. Load Player              ║");
        Console.WriteLine("║    2. New Player               ║");
        Console.WriteLine("╚════════════════════════════════╝");
        option = Utils.ValidateOption(1, 2);
        switch (option)
        {
            case 1:
                Console.Clear();
                Console.WriteLine("Not players yet\n");
                Console.WriteLine("Press any key to go back");
                Console.ReadKey();
                ShowMenu();
                break;
            case 2:
                Console.Clear();
                Player player = Utils.NewPlayer();
                Console.Clear();
                Console.WriteLine("╔════════════════════════════════╗");
                Console.WriteLine("║    Select your new pet:        ║");
                Console.WriteLine("║                                ║");
                Console.WriteLine("║ 1. Cat                         ║");
                Console.WriteLine("║ 2. Dog                         ║");
                Console.WriteLine("║ 3. Chick                       ║");
                Console.WriteLine("╚════════════════════════════════╝");
                selectpet = Utils.ValidateOption(1, 3);
                Console.Clear();
                switch (selectpet)
                {
                    case 1:
                        Cat garfield = Utils.NewCat();
                        player.Pet = garfield;
                        break;
                    case 2:
                        Dog clifford = Utils.NewDog();
                        player.Pet = clifford;
                        break;
                    case 3:
                        Chick piolin = Utils.NewChick();
                        player.Pet = piolin;
                        break;
                }
                PetInfo(player);
                break;
        }
    }
    public static void PetInfo(Player player)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        int option;

        Console.Clear();
        Console.WriteLine("╔════════════════════════════════╗");
        Console.WriteLine("║            TAMAGOTCHI          ║");
        Console.WriteLine("║                                ║");
        Console.WriteLine($"║ Name: {player.Pet.Name}                      ║");
        Console.WriteLine($"║ Type: {player.Pet.Typepet}                      ║");
        Console.WriteLine($"║ DateOfBirth: {player.Pet.Birthdate:dd/MM/yyyy}        ║");
        Console.WriteLine("╚════════════════════════════════╝");
        Console.WriteLine();
        player.Pet.TypeState = Utils.CalculateState(player.Pet);
        Console.WriteLine(player.Pet.State(player.Pet.TypeState));
        Console.WriteLine($"Hunger: {Utils.DrawBar(player.Pet.Stats.Hunger)}");
        Console.WriteLine($"Energy: {Utils.DrawBar(player.Pet.Stats.Energy)}");
        Console.WriteLine($"Health: {Utils.DrawBar(player.Pet.Stats.Health)}");
        Console.WriteLine();
        Console.WriteLine(" 1. Eat");
        Console.WriteLine(" 2. Sleep");
        Console.WriteLine(" 3. Play");
        Console.WriteLine(" 4. Inventory");
        Console.WriteLine(" 5. Exit");
        option = Utils.ValidateOption(1, 5);
        switch (option)
        {
            case 1:
                Eat(player);
                break;
            case 2:
                Sleep(player);
                break;
            case 3:
                Play(player);
                break;
            case 4:
                Inventory(player);
                break;
            case 5:
                Console.WriteLine("End of the program");
                break;
        }
    }
    public static void Eat(Player player)
    {
        int food;

        Console.Clear();
        Console.WriteLine("╔════════════════════════════════╗");
        Console.WriteLine("║    What to feed it?            ║");
        Console.WriteLine("║                                ║");
        Console.WriteLine($"║ 1. {player.Inventory[0].Name}                        ║");
        Console.WriteLine($"║ 2. {player.Inventory[1].Name}                       ║");
        Console.WriteLine($"║ 3. {player.Inventory[2].Name}                       ║");
        Console.WriteLine($"║ 4. {player.Inventory[3].Name}                        ║");
        Console.WriteLine("╚════════════════════════════════╝");
        food = Utils.ValidateOption(1, 4);
        Console.Clear();
        if (!Utils.IsSick(player.Pet) && food == 2)
        {
            Console.WriteLine("Your pet has dead");   
        }
        else
        {
            player.Pet.isEating();
            Console.WriteLine($"Your {player.Pet.Typepet} eat {player.Inventory[food - 1].Name}");
            Console.ReadKey();
            switch (food)
            {
                case 1:
                    player.Pet.Stats.Hunger += 30;
                    break;
                case 2:
                    player.Pet.Stats.Hunger += 10;
                    break;
                case 3:
                    player.Pet.Stats.Hunger += 20;
                    break;
                case 4:
                    player.Pet.Stats.Hunger += 25;
                    break;
            }
            PetInfo(player);
        }
    }
    public static void Sleep(Player player)
    {
        Console.Clear();
        player.Pet.isSleeping();
        player.Pet.Stats.Energy += 30;
        player.Pet.Stats.Hunger -= 10;
        if (player.Pet.Stats.Energy >= 100) player.Pet.Stats.Energy = 100;
        Console.WriteLine($"Your {player.Pet.Typepet} is resting");
        Console.WriteLine(player.Pet.State(player.Pet.TypeState));
        Console.ReadKey();

        PetInfo(player);
    }
    public static void Play(Player player)
    {
        int toy;
        Random random = new Random();

        Console.Clear();
        Console.WriteLine("╔════════════════════════════════╗");
        Console.WriteLine("║    What to feed it?            ║");
        Console.WriteLine("║                                ║");
        Console.WriteLine($"║ 1. {player.Inventory[4].Name}                        ║");
        Console.WriteLine($"║ 2. {player.Inventory[5].Name}                   ║");
        Console.WriteLine($"║ 3. {player.Inventory[6].Name}                       ║");
        Console.WriteLine($"║ 4. {player.Inventory[7].Name}                ║");
        Console.WriteLine($"║ 5. {player.Inventory[8].Name}                        ║");
        Console.WriteLine("╚════════════════════════════════╝");
        toy = Utils.ValidateOption(1, 5);
        Console.Clear();
        if (random.Next(0, 101) <= 30 && player.Pet.TypeState == Tamagotchi.Core.Enums.TypeState.Angry)
        {
            Console.WriteLine("😠 La teva mascota està enfadada amb tu!");
            Thread.Sleep(1000);
            PetInfo(player);
        }
        if (random.Next(0, 101) <= 20 && player.Pet.TypeState == Tamagotchi.Core.Enums.TypeState.Sad)
        {
            Console.WriteLine("😭 La teva mascota està molt trista T-T");
            Thread.Sleep(1000);
            PetInfo(player);
        }
        player.Pet.isPlaying();
        Thread.Sleep(1000);
        Console.WriteLine($"Your {player.Pet.Typepet} played with a {player.Inventory[toy + 3].Name}");
        Console.ReadKey();
        player.Pet.Stats.Energy -= random.Next(0, 51);
        player.Pet.Stats.Hunger -= random.Next(0, 41);

        PetInfo(player);
    }
    public static void OpenInventory(Player player)
    {
        int option;

        Console.Clear();
        for (int i = 0; i < player.Inventory.Length; i++) //Capacity
        {
            Console.WriteLine($"{i + 1}: {player.Inventory[i].Name}");
        }
        Console.WriteLine($"{player.Inventory.Length + 1}: Exit"); //Capacity
        option = Utils.ValidateOption(1, 13);
        switch (option)
        {
            case <= 3://comida
                player.Pet.isEating();
                Console.WriteLine($"Your {player.Pet.Typepet} eat {player.Inventory[option]}");
                break;
            case <= 8://juegos
                player.Pet.isPlaying();
                Console.WriteLine($"Your {player.Pet.Typepet} played with a {player.Inventory[option]}");
                Thread.Sleep(700);
                break;
            case <= 12://medicinas
                Console.WriteLine($"You use {player.Inventory[option]} on your {player.Pet.Typepet}");
                break;
            case 13:
                break;
        }
        PetInfo(player);
    }
    public static void Inventory(Player player)
    {
        int option, delete;

        Console.Clear();
        Console.WriteLine("╔════════════════════════════════╗");
        Console.WriteLine("║            INVENTORY           ║");
        Console.WriteLine("║                                ║");
        Console.WriteLine("║ 1. Use item                    ║");
        Console.WriteLine("║ 2. Add Item                    ║");
        Console.WriteLine("║ 3. Delete Item                 ║");
        Console.WriteLine("╚════════════════════════════════╝");
        option = Utils.ValidateOption(1, 3);
        switch (option)
        {
            case 1:
                OpenInventory(player);
                break;
            case 2:
                Utils.AddItem(player);
                break;
            case 3:
                Console.Clear();
                for (int i = 0; i < player.Inventory.Length; i++) //Capacity
                {
                    Console.WriteLine($"{i + 1}: {player.Inventory[i].Name}");
                }
                Console.WriteLine("Select one to delete");
                delete = Utils.ValidateOption(1, player.Inventory.Length); //Capacity
                player.DeleteItem(player, delete);
                break;
        }
    }
}