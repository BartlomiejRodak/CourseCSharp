using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_CSharp_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // C# functions placed inside classes are called methods.
            //Because C # doesn't allow to declare functions outside the class, all functions are methods.

            Console.ReadKey();
        }

        /*------------------------------CASE 1---------------------------*/
        //void Bar()
        //{
        //}

        //Bar();


        /*------------------------------CASE 2---------------------------*/
        //int Bar()
        //{
        //    return 2; // it will return 2;
        //    Console.WriteLine("This code will not be executed");
        //}

        //int value = Bar();


        /*------------------------------CASE 3---------------------------*/
        //void Bar()
        //{
        //    return;
        //    Console.WriteLine("This code will not be executed");
        //}


        /*------------------------------CASE 4---------------------------*/
        //double KmToMile(double Km)
        //{
        //    return ((Km * 1000) / 1609.344);
        //}


        /*------------------------------CASE 5---------------------------*/
        //static int Multiple(int X, int Y)
        //{
        //    return X * Y;
        //}

        /*------------------------------CASE 6---------------------------*/
        //static int field1;
        //int field2;

        //static public int Bar()
        //{
        //    return field1 = 10;
        //    field2 = 10; // <-- error
        //}



        ////////////////TODO:////////////////////
        //Create method that will display even numbers on the console in the range between 1 - 20 inclusive.
    }
}
