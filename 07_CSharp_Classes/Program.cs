using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_CSharp_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*------------------------------CASE 1---------------------------*/
            // initialize default constructor
            var human = new Human();

            /*------------------------------CASE 2---------------------------*/
            // Access modifiers
            human.SayHello();
            human.SaySomthing();

            // won't compile we cannot access this from outside
            // human.SayGoodbye();
            // human.SayWhatever();

            /*------------------------------CASE 3---------------------------*/
            // different constructors
            var defaultPerson = new Person();
            defaultPerson.IntroduceYourself();

            var personWithName = new Person("Piotr");
            personWithName.IntroduceYourself();

            var personWithNameAndSurname = new Person("Piotr", "Doe");
            personWithNameAndSurname.IntroduceYourself();

            /*------------------------------CASE 4---------------------------*/
            // different constructors in structs
            var defaultPersonStruct = new PersonStruct();
            defaultPersonStruct.IntroduceYourself();

            var personStructWithName = new PersonStruct("Piotr");
            personStructWithName.IntroduceYourself();

            var personStructWithNameAndSurname = new PersonStruct("Piotr", "Doe");
            personStructWithNameAndSurname.IntroduceYourself();

            /*------------------------------CASE 4---------------------------*/
            // static class

            StaticClass.Print("print");
        }
    }
}
