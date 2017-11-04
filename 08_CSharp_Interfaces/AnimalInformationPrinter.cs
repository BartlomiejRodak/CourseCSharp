using System;

namespace _08_CSharp_Interfaces
{
    public class AnimalInformationPrinter
    {
        public void Print(IAnimal animal)
        {
            animal.SayHello();
            Console.WriteLine("Speed: " + animal.Speed());
        }
    }
}