namespace _09_CSharp_Inheritance_Example.WithoutInterfaces
{
    public class EdukacjaCl
    {
        public bool CanEnrollToCourse(Student student)
        {
            return student.Age > 18 && 
                student.Name.EndsWith("a") 
                && student.City == "Wroclaw";
        }
    }
}