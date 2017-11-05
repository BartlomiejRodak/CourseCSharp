using System.Collections.Generic;
using System.Linq;

namespace _09_CSharp_Inheritance_Example.WithInterfaces
{
    public class EdukacjaCl
    {
        private List<IStudentValidator> validators;

        public EdukacjaCl(List<IStudentValidator> validators)
        {
            this.validators = validators;
        }

        public bool CanEnrollToCourse(Student student)
        {
            return validators.All(validator => validator.Validate(student));
        }
    }
}