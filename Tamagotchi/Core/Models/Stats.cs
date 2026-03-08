using System;

namespace Tamagotchi.Core.Models
{
    public class Stats
    {
        private int hunger;
        private int energy;

        public int Hunger
        {
            get => hunger;
            set => hunger = Math.Max(0, value);
        }

        public int Energy
        {
            get => energy;
            set => energy = Math.Max(0, value);
        }
        public int Health => Math.Clamp((Hunger + Energy) / 2, 0, 100);
        public Stats()
        {
            Hunger = 100;
            Energy = 100;
        }
    }
}