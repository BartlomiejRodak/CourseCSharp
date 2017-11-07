namespace _09_CSharp_Inheritance.Struct
{
    // won't compile
    public struct AnimalStruct /*: AnimalStructBase*/ : IDog
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

        public void Bite()
        {
            throw new System.NotImplementedException();
        }
    }
}