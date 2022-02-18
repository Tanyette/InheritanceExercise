using System;


namespace Inheritance
{
    public class Bird: Animal
    {
        public Bird() //Constructor
        {
            BreathesAir = true;
            Legs = 2;
            HasTail = true;
            CanSwim = false;
        }

        public bool CanFly { get; set; }
        public bool HasFeathers { get; set; } = true;
        public bool CanSing { get; set;}
        public bool BuildsNest { get; set; }

        public void PrintDetails() 
        {
            Console.WriteLine($"{GetType().Name}");
            Console.WriteLine($"Can Fly?: {CanFly}");
            Console.WriteLine($"Specialty: {CanSing}");
            Console.WriteLine($"# of Legs: {Legs}");
            Console.WriteLine($"Swim?: {CanSwim}");
        }
    }
}
