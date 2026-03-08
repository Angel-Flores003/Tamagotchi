using System;
using Tamagotchi.Core.Enums;

namespace Tamagotchi.Core.Models
{
    public class Dog : APet
    {
        public Dog(string name, TypeState typesatate, Stats stats, TypePet typepet, bool isalive = true) : base(name, typesatate, stats, typepet, isalive) { }
        public override void isEating()
        {
            Console.WriteLine(@"
         / \__
        (    @\___
         /         O
        /   (_____/   🥩 🥩 🥩 
        /_____/   U
");
            Thread.Sleep(700);
            Console.Clear();
            Console.WriteLine(@"
         / \__
        (    @\___
         /         O
        /   (_____/  🥩 🥩 
        /_____/   U
");
            Thread.Sleep(700);
            Console.Clear();
            Console.WriteLine(@"
         / \__
        (    @\___
         /         O
        /   (_____/ 🥩
        /_____/   U
");
            Thread.Sleep(700);
            Console.Clear();
            Console.WriteLine(@"
         / \__
        (    @\___
         /         O
        /   (_____/
        /_____/   U
");
            Thread.Sleep(700);
        }
        public override void isPlaying()
        {
            Console.WriteLine(@"
         / \__
        (    @\___
         /         O  ⚽  ⚽
        /   (_____/     ⚽
        /_____/   U
");
        }
        public override void isSleeping()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(@"
         / \__
        (    -\___   z
         /         O
        /   (_____/
        /_____/   U
");
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine(@"
         / \__
        (    -\___   zZ
         /         O
        /   (_____/
        /_____/   U
");
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine(@"
         / \__
        (    -\___    Z
         /         O
        /   (_____/
        /_____/   U
");
                Thread.Sleep(500);
                Console.Clear();
            }
        }
        public override string State(TypeState typestate)
        {
            return typestate switch
            {
                TypeState.Happy => @"
         / \__
        (    ^\___
         /         O
        /   (_____/
        /_____/   U
",
                TypeState.Sad => @" 
          / \__
        (    ╥\___
         /         O
        /   (_____/
        /_____/   
",
                TypeState.Angry => @" 
           / \__
        (    ಠ\___
         /         O
        /   (_____/
        /_____/   U
",
                TypeState.Tired => @" 
          / \__
        (    -\___   zZ
         /         O
        /   (_____/
        /_____/   U
",
                TypeState.Sick => @"
           / \__
        (    X\___
         /         O
        /   (_____/
        /_____/   
"
            };
        }
    }
}