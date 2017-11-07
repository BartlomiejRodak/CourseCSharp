namespace _09_CSharp_Inheritance_Example.WithInterfaces.Implementation
{
    public class NameValidator : IStudentValidator
    {
        public bool Validate(Student student)
        {
            return student.Name.EndsWith("a");
        }
    }
}