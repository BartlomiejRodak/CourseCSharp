using System;

namespace _09_CSharp_Inheritance.Class
{
    public class AnimalBase
    {
        public string Name { get; set; } = "Animal";

        protected int Legs { get; set; } = 0;

        public void SayHello()
        {
            Console.WriteLine("Grrr....");
        }

        internal void SayHelloInternal()
        {
            Console.WriteLine("Somthing");
        }

        protected int Speed()
        {
            return 0;
        }

        private bool IsMammal()
        {
            return false;
        }
    }
}