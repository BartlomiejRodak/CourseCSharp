using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _09_CSharp_Inheritance.Class;

namespace _09_CSharp_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            /*------------------------------CASE 1---------------------------*/
            var animal = new AnimalMultipleInterface();

            animal.Test();

            // public in base
            animal.SayHello();

            // internal in base
            animal.SayHelloInternal();

            // protected in base won't compile
            // animal.Speed();

            /*------------------------------CASE 2---------------------------*/
            var adultAnimal = new AdultAnimal();

            adultAnimal.TestAdult();

            // public in base
            adultAnimal.SayHello();

            // internal in base
            adultAnimal.SayHelloInternal();

            // protected in base won't compile
            // animal.Speed();
        }
    }
}
