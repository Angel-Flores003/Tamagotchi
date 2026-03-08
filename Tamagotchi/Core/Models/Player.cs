using System;

namespace Tamagotchi.Core.Models
{
    public class Player
    {
        public string Name { get; set; }
        public AItem[] Inventory {get; set; }//List<AItem>
        public APet Pet { get; set; }
        public Player(string name, AItem[] item, APet pet)//List<AItem>
        {
            Name = name;
            Inventory = item;
            Pet = pet;
        }
        public void KeepObject() { }
        public void AddItem() { }
        public void DeleteItem(Player player, int id)
        {
            int index = 0;

            //player.Inventory.RemoveAt(id - 1);
            Player player1 = new Player("paco", null, null);
            for (int i = 0; i < player.Inventory.Length; i++)
            {
                if (player.Inventory[i] != player.Inventory[id])
                {
                    player1.Inventory[index] = player.Inventory[i];
                    index++;
                }
            }
            player.Inventory = player1.Inventory;
            Console.WriteLine("Objet deleted from the inventory.");
        }
        public void UseItem() { }
        public void SaveGame() { }
    }
}