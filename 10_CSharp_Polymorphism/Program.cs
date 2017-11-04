using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_CSharp_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            /*------------------------------CASE 1---------------------------*/
            var staticPolymorphism = new StaticPolymorphism();
            var addingTwoNumbers = staticPolymorphism.Add(1, 1);
            var addingThreeNumbers = staticPolymorphism.Add(1, 1, 1);
            var addingFourNumbers = staticPolymorphism.Add(1, 1, 1, 1);

            /*------------------------------CASE 2---------------------------*/
            DynamicPolymorphismBase basePolymorphism = new DynamicPolymorphismBase();
            var result = basePolymorphism.Add(1, 1);

            DynamicPolymorphism dynamicPolyporphism = new DynamicPolymorphism();
            var resultFromDynamic = dynamicPolyporphism.Add(1, 1);


            DynamicPolymorphismBase dynamicPolyporphism1 = new DynamicPolymorphism();
            var resultFromDynamic1 = dynamicPolyporphism1.Add(1, 1);

            /*------------------------------CASE 3---------------------------*/
            // without virtual

            // DynamicPolymorphismBase basePolymorphism = new DynamicPolymorphismBase();
            basePolymorphism.Print();

            // DynamicPolymorphism dynamicPolyporphism = new DynamicPolymorphism();
             dynamicPolyporphism.Print();


            // DynamicPolymorphismBase dynamicPolyporphism1 = new DynamicPolymorphism();
            dynamicPolyporphism1.Print();
        }
    }
}
