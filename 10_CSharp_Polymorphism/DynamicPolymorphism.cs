using System;

namespace _010_CSharp_Polymorphism
{
    public class DynamicPolymorphism : DynamicPolymorphismBase
    {
        public override int Add(int a, int b)
        {
            return a + b;
        }

        public new void Print()
        {
            Console.WriteLine("DynamicPolymorphism");
        }
    }
}