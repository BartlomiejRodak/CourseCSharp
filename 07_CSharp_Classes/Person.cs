using System;
using System.CodeDom;

namespace _07_CSharp_Classes
{
    public class Person
    {
        private readonly string name;
        private readonly string surname;

        public Person()
        {
            this.name = "Jon";
            this.surname = "Doe";
        }
        public Person(string name)
        {
            this.name = name;
        }
        public Person(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public void IntroduceYourself()
        {
            Console.WriteLine($"{this.name} {this.surname}");
        }
    }
}