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
            var turtleExample = new Turtle();
            turtleExample.SayHello();
            var speedResult = turtleExample.Speed();

            var dogExample = new Dog();
            dogExample.SayHello();
            speedResult = dogExample.Speed();

            var catExample = new Cat();
            catExample.SayHello();
            speedResult = catExample.Speed();

            var printerHelper = new AnimalInformationPrinterBad();
            
            //we want to pass class and print information
            printerHelper.Print(turtleExample);
            printerHelper.Print(dogExample);
            printerHelper.Print(catExample);

            /*------------------------------CASE 2---------------------------*/
            IAnimal turtle = new Turtle();
            turtle.SayHello();
            var speed = turtle.Speed();


            IAnimal dog = new Dog();
            dog.SayHello();
            speed = dog.Speed();


            IAnimal cat = new Cat();
            cat.SayHello();
            speed = cat.Speed();

            /*------------------------------CASE 3---------------------------*/
            var printer = new AnimalInformationPrinter();

            // we can generalize calls
            printer.Print(turtle);
            printer.Print(dog);
            printer.Print(cat);
        }
    }
}
