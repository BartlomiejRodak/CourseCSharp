using System;

namespace _08_CSharp_Interfaces
{
    public class AnimalInformationPrinterBad
    {
        public void Print(Dog dog)
        {
            dog.SayHello();
            Console.WriteLine("Speed: " + dog.Speed());
        }

        public void Print(Cat cat)
        {
            cat.SayHello();
            Console.WriteLine("Speed: " + cat.Speed());
        }

        public void Print(Turtle turtle)
        {
            turtle.SayHello();
            Console.WriteLine("Speed: " + turtle.Speed());
        }
    }
}