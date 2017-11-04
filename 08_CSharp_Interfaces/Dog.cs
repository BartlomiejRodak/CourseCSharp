using System;

namespace _08_CSharp_Interfaces
{
    public class Dog : IAnimal
    {
        public void SayHello()
        {
            Console.WriteLine("Hau");
        }

        public int Speed()
        {
            return 20;
        }
    }
}