using System;
using Tamagotchi.Core.Enums;

namespace Tamagotchi.Core.Models
{
    public abstract class AItem
    {
        public string Name { get; set; }
        public TypeItem TypeItem { get; set; }
        public AItem(string name, TypeItem typeitem)
        {
            Name = name;
            TypeItem = typeitem;
        }
        public abstract void Behavior();
    }
}