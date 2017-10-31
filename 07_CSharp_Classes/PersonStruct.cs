using System;

namespace _07_CSharp_Classes
{
    public struct PersonStruct
    {
        private readonly string name;
        private readonly string surname;

        //public PersonStruct()
        //{
        //    this.name = "Jon";
        //    this.surname = "Doe";
        //}
        public PersonStruct(string name)
        {
            this.name = name;
            this.surname = "";
        }
        public PersonStruct(string name, string surname)
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