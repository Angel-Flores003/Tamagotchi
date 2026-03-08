using System;
using Tamagotchi.Core.Enums;

namespace Tamagotchi.Core.Models
{
    public class FoodStuff : AItem
    {
        public TypeFood Foods { get; set; }
        public FoodStuff(string name, TypeItem typeitem, TypeFood foods) : base(name, typeitem)
        {
            Foods = foods;
        }

        public override void Behavior()
        {
            throw new NotImplementedException();
        }
    }
}