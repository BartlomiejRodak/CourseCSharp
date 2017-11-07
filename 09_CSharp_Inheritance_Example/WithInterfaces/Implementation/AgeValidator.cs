namespace _09_CSharp_Inheritance_Example.WithInterfaces.Implementation
{
    public class AgeValidator : IStudentValidator
    {
        public bool Validate(Student student)
        {
            return student.Age > 18;
        }
    }
}