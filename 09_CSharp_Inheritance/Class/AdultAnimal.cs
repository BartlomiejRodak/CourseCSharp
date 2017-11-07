namespace _09_CSharp_Inheritance.Class
{
    public class AdultAnimal : Animal
    {
        public void TestAdult()
        {
            // the same rules

            // public property
            var name = base.Name;

            // protected property

            var legs = Legs;
            // public
            SayHello();

            //internal
            SayHelloInternal();

            //protected
            var speed = Speed();

            // private
            // var isMammal = IsMammal();
        }
    }
}