using System;
using Tamagotchi.Core.Enums;

namespace Tamagotchi.Core.Models
{
    public class Medicine : AItem
    {
        public TypeMedicine Medic { get; set; }
        public Medicine(string name, TypeItem typeitem, TypeMedicine medicine) : base(name, typeitem)
        {
            Medic = medicine;
        }

        public override void Behavior()
        {
            throw new NotImplementedException();
        }
    }
}