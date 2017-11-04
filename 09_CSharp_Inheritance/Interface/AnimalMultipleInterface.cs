using _09_CSharp_Inheritance.Class;

namespace _09_CSharp_Inheritance.Interface
{
    public class AnimalMultipleInterface :  AnimalBase, IAnimal, IMammal
    {
        public void Cry()
        {
            throw new System.NotImplementedException();
        }

        public int Speed()
        {
            throw new System.NotImplementedException();
        }

        public bool IsMammal()
        {
            throw new System.NotImplementedException();
        }
    }

    // order does matter
    //public class AnimalWontCompile : IAnimal, IMammal, AnimalBase
    //{
        
    //}
}