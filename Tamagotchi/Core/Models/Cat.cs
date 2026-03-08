using System;
using Tamagotchi.Core.Enums;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tamagotchi.Core.Models
{
    public class Cat : APet
    {
        public Cat(string name, TypeState typesatate, Stats stats, TypePet typepet, bool isalive = true) : base(name, typesatate, stats, typepet, isalive) { }

        public override void isEating()
        {
            Console.WriteLine(@"
          /\_/\      
         ( º‿º )   🐟 🐟 🐟
        /       \    
       |         |   
        \__/\___/  
");
            Thread.Sleep(700);
            Console.Clear();
            Console.WriteLine(@"
          /\_/\      
         ( º‿º )  🐟 🐟
        /       \    
       |         |   
        \__/\___/  
");
            Thread.Sleep(700);
            Console.Clear();
            Console.WriteLine(@"
          /\_/\      
         ( º‿º ) 🐟
        /       \    
       |         |   
        \__/\___/  
");
            Thread.Sleep(700);
            Console.Clear();
            Console.WriteLine(@"
          /\_/\      
         ( º‿º )  
        /       \    
       |         |   
        \__/\___/  
");
            Thread.Sleep(700);
        }
        public override void isPlaying()
        {
            Console.WriteLine(@"
          /\_/\     
         ( º‿º )  🧶 🧶
        /       \   🧶 
       |         |   
        \__/\___/ 
");
        }
        public override void isSleeping()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(@"
          /\_/\      
         ( -_- ) z  
        /       \    
       |         |   
        \__/\___/ 
");
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine(@"
          /\_/\      
         ( -_- ) zZ  
        /       \    
       |         |   
        \__/\___/ 
");
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine(@"
          /\_/\      
         ( -_- )  Z  
        /       \    
       |         |   
        \__/\___/ 
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
          /\_/\      
         ( ^‿^ )     
        /       \    
       |         |   
        \__/\___/  
",
                TypeState.Sad => @"
          /\_/\      
         ( ╥﹏╥ )     
        /       \    
       |         |   
        \__/\___/  
",
                TypeState.Angry => @"
          /\_/\      
         ( ಠ_ಠ )     
        /       \    
       |         |   
        \__/\___/ 
",
                TypeState.Tired => @"
          /\_/\      
         ( -_- ) zZ  
        /       \    
       |         |   
        \__/\___/ 
",
                TypeState.Sick => @"
          /\_/\      
         ( x_x )     
        /       \    
       |   +--+  |   
        \__/\___/
"
            };
        }
    }
}