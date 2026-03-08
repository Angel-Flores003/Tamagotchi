using System;
using Tamagotchi.Core.Enums;
using Tamagotchi.Core.Interfaces;

namespace Tamagotchi.Core.Models
{
    public abstract class APet : IEat, IPlay, ISleep
    {
        public string Name { get; set; }
        public TypeState TypeState { get; set; }//estado emocional
        public Stats Stats { get; set; }//hp, ...
        public bool isAlive { get; set; }
        public TypePet Typepet { get; set; }
        public DateTime Birthdate { get; set; }
        public APet(string name, TypeState typesatate, Stats stats, TypePet typepet, bool isalive = true)
        {
            Name = name;
            TypeState = typesatate;
            Stats = stats;
            Typepet = typepet;
            isAlive = isalive;
            Birthdate = DateTime.Now;
        }
        public abstract void isEating();

        public abstract void isPlaying();

        public abstract void isSleeping();
        public abstract string State(TypeState typestate);
    }
}