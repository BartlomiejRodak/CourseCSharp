using System;

namespace _010_CSharp_Polymorphism
{
    public class DynamicPolymorphismBase
    {
        public virtual int Add(int a, int b)
        {
            return 0;
        }

        public void Print()
        {
            Console.WriteLine("Base");
        }
    }
}