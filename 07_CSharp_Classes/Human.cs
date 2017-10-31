using System;

namespace _07_CSharp_Classes
{
    public class Human
    {
        public void SayHello()
        {
            Console.WriteLine("Hello");
        }

        internal void SaySomthing()
        {
            Console.WriteLine("Somthing");
        }

        protected void SayGoodbye()
        {
            Console.WriteLine("Goodbye");
        }
        private void SayWhatever()
        {
            Console.WriteLine("Whatever");
        }
    }
}