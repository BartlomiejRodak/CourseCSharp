using System;

namespace _08_CSharp_Interfaces
{
    public class Cat : IAnimal
    {
        public void SayHello()
        {
            Console.WriteLine("Meow");
        }

        public int Speed()
        {
            return 10;
        }
    }
}