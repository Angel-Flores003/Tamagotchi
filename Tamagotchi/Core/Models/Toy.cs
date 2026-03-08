using System;
using Tamagotchi.Core.Enums;

namespace Tamagotchi.Core.Models
{
    public class Toy : AItem
    {
        public TypeToy Toys { get; set; }
        public Toy(string name, TypeItem typeitem, TypeToy toy) : base(name, typeitem)
        {
            Toys = toy;
        }

        public override void Behavior()
        {
            throw new NotImplementedException();
        }
    }
}