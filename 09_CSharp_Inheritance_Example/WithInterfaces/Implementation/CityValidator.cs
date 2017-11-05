namespace _09_CSharp_Inheritance_Example.WithInterfaces.Implementation
{
    public class CityValidator : IStudentValidator
    {
        public bool Validate(Student student)
        {
            return student.City == "Wroclaw";
        }
    }
}