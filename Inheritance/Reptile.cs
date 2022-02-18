using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile() 
        {
            BreathesAir = true;
            Legs = 4;
            HasTail = true;
            CanSwim = false;

        }

        public bool IsColdBlooded { get; set; } = true;
        public string Movement { get; set; } = "Slither";
        public bool HasScales { get; set; } = true;
        public bool HasForkedTongue { get; set;}

        public void PrintDetails() 
        {
            Console.WriteLine($"{GetType().Name}");
            Console.WriteLine($" Is Cold Blooded?:{IsColdBlooded}");
            Console.WriteLine($" Has Forked Tongue: {HasForkedTongue}");
            Console.WriteLine($"# of Legs: {Legs}");
            Console.WriteLine($"Swim?: {CanSwim}");
        }

    }
}
