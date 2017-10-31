using System;

namespace _08_CSharp_Interfaces
{
    public class Cat : IAnimal
    {
        public void Cry()
        {
            Console.WriteLine("Meow");
        }

        public int Speed()
        {
            return 10;
        }
    }
}