using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_CSharp_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            /*------------------------------CASE 1---------------------------*/
            IAnimal turtle = new Turtle();
            turtle.Cry();
            var speed = turtle.Speed();


            IAnimal dog = new Dog();
            dog.Cry();
            speed = dog.Speed();


            IAnimal cat = new Cat();
            cat.Cry();
            speed = cat.Speed();

            /*------------------------------CASE 2---------------------------*/
            var printer = new AnimalInformationPrinter();

            // we can generalize calls
            printer.Print(turtle);
            printer.Print(dog);
            printer.Print(cat);
        }
    }
}
