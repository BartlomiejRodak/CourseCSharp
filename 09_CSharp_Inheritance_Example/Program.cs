using System.Collections.Generic;
using _09_CSharp_Inheritance_Example.WithInterfaces;
using _09_CSharp_Inheritance_Example.WithInterfaces.Implementation;

namespace _09_CSharp_Inheritance_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student()
            {
                City = "Wroclaw",
                Name = "a",
                Age = 20,
                AverageGrades = 6,
                Faculty = "W4"
            };

            /*------------------------------CASE 1---------------------------*/
            var monolith = new WithoutInterfaces.EdukacjaCl();
            var result = monolith.CanEnrollToCourse(student);


            /*------------------------------CASE 2---------------------------*/
            var validators = new List<IStudentValidator>()
            {
                new AgeValidator(),
                new CityValidator(),
                new NameValidator()
            };
            var edukacja = new WithInterfaces.EdukacjaCl(validators);

            var result1 = edukacja.CanEnrollToCourse(student);

            /*------------------------------CASE 3---------------------------*/
            // add validators for Faculty and AverageGrades
            // validator should allow only students from W4, W5 and W6
            // validator should allow only students that have AverageGrades higher than 2.0 but less than 5.5
            // add these conditions to WithoutInterfaces.EdukacjaCl
        }
    }
}
