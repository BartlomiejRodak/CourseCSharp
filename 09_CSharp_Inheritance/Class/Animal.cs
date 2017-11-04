namespace _09_CSharp_Inheritance.Class
{
    // we can inherit only from one class
    public class Animal : AnimalBase /*, AnimalSecondBase*/
    {
        public void Test()
        {
            // public property
            var name = Name;

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