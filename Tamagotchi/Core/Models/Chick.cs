using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi.Core.Enums;

namespace Tamagotchi.Core.Models
{
    public class Chick : APet
    {
        public Chick(string name, TypeState typesatate, Stats stats, TypePet typepet, bool isalive = true) : base(name, typesatate, stats, typepet, isalive) { }
        public override void isEating()
        {
            Console.WriteLine(@"
          \\
          ('>   🌽 🌽 🌽
       \\_//)
        \_/_)
         _|_
");
            Thread.Sleep(700);
            Console.Clear();
            Console.WriteLine(@"
          \\
          ('>  🌽 🌽
       \\_//)
        \_/_)
         _|_
");
            Thread.Sleep(700);
            Console.Clear();
            Console.WriteLine(@" 
          \\
          ('> 🌽
       \\_//)
        \_/_)
         _|_
");
            Thread.Sleep(700);
            Console.Clear();
            Console.WriteLine(@" 
          \\
          ('> 
       \\_//)
        \_/_)
         _|_
");
            Thread.Sleep(700);
        }
        public override void isPlaying()
        {
            Console.WriteLine(@"
          \\
          ('> 🧶  ⚽
       \\_//)   🌽
        \_/_)
         _|_
");
        }
        public override void isSleeping()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(@"
          \\
          (-> z
       \\_//)
        \_/_)
         _|_
");
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine(@"
          \\
          (-> zZ
       \\_//)
        \_/_)
         _|_
");
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine(@"
          \\
          (->  Z
       \\_//)
        \_/_)
         _|_
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
          \\
          (^> 
       \\_//)
        \_/_)
         _|_
",
                TypeState.Sad => @" 
          \\
          (╥> 
       \\_//)
        \_/_)
         _|_
",
                TypeState.Angry => @" 
          \\
          (ಠ> 
       \\_//)
        \_/_)
         _|_
",
                TypeState.Tired => @"
          \\
          (-> zZ
       \\_//)
        \_/_)
         _|_
",
                TypeState.Sick => @"
          \\
          (X> 
       \\_//)
        \_/_)
         _|_
"
            };
        }
    }
}