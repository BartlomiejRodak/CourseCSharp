using System;

namespace _08_CSharp_Interfaces
{
    public class Turtle : IAnimal
    {
        public void Cry()
        {
            Console.WriteLine("somthing :)");
        }

        public int Speed()
        {
            return 1;
        }
    }
}