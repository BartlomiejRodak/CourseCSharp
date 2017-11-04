using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_CSharp_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            /*------------------------------CASE 1---------------------------*/
            //int[] Foo;
            //Foo = new int[5];

            //Foo[0] = 100;
            //Foo[1] = 1000;
            //Foo[2] = 10000;
            //Foo[3] = 100000;
            //Foo[4] = 1000000;

            //Console.WriteLine(Foo[4]);



            /*------------------------------CASE 2---------------------------*/
            //char[] Foo = new char[5];

            //Foo[0] = 'H';
            //Foo[1] = 'e';
            //Foo[2] = 'l';
            //Foo[3] = 'l';
            //Foo[4] = 'o';


            /*------------------------------CASE 3---------------------------*/
            //char[] Foo = new char[5] { 'H', 'e', 'l', 'l', 'o' };

            //Console.WriteLine(Foo[4]);


            /*------------------------------CASE 4---------------------------*/
            //string[,] Foo = new string[7, 2];
            //Foo[0, 0] = "Pn";
            //Foo[1, 0] = "Wt";
            //Foo[2, 0] = "Śr";
            //Foo[3, 0] = "Czw";
            //Foo[4, 0] = "Pt";
            //Foo[5, 0] = "So";
            //Foo[6, 0] = "Nd";

            //Foo[0, 1] = "Mon";
            //Foo[1, 1] = "Tue";
            //Foo[2, 1] = "Wed";
            //Foo[3, 1] = "Thu";
            //Foo[4, 1] = "Fri";
            //Foo[5, 1] = "Sat";
            //Foo[6, 1] = "Sun";


            /*------------------------------CASE 5---------------------------*/
            //string[] Foo = new string[7];

            //Foo[0] = "Pn";
            //Foo[1] = "Wt";
            //Foo[2] = "Śr";
            //Foo[3] = "Czw";
            //Foo[4] = "Pt";
            //Foo[5] = "So";
            //Foo[6] = "Nd";

            //foreach (string Bar in Foo)
            //{
            //    Console.WriteLine(Bar);
            //}

            /*------------------------------CASE 5A---------------------------*/
            //The same:


            //for (int i = 0; i < Foo.Length; i++)
            //{
            //    Foo[i] = "Foo";
            //    Console.WriteLine(Foo[i]);
            //}

            /*------------------------------CASE 6---------------------------*/
            //string Bar = "Test";
            //foreach (string Bar in Foo)
            //{
            //    Console.WriteLine(Bar);
            //}



            /*------------------------------CASE 7---------------------------*/
            //int[][] Foo = new int[2][];

            //Foo[0] = new int[50];
            //Foo[1] = new int[1000];

            //// assigning values to element 26 of array 1
            //Foo[0][25] = 122;
            //// assigning values to element 1000 of array 2
            //Foo[1][999] = 12;



            /*------------------------------CASE 8---------------------------*/
            //Stack MyStack = new Stack();

            //for (int i = 0; i < 20; i++)
            //{
            //    MyStack.Push("Position nr " + i);
            //}
            //Console.WriteLine("Last element: " + MyStack.Peek());
            //Console.WriteLine("Deleted element: " + MyStack.Pop());



            /*------------------------------CASE 9---------------------------*/
            //Queue MyQueue = new Queue();

            //for (int i = 0; i < 20; i++)
            //{
            //    MyQueue.Enqueue("Position nr " + i);
            //}
            //Console.WriteLine("First element: " + MyQueue.Peek());
            //Console.WriteLine("Deleted element: " + MyQueue.Dequeue());
            //Console.WriteLine();


            /*------------------------------CASE 10---------------------------*/
            //List<int> Foo = new List<int>();

            //Foo.Add(10);
            //Foo.Add(100);
            //Foo.Add(10000);

            //for (int i = 0; i < Foo.Count; i++)
            //{
            //    Console.WriteLine("Index: {0} value: {1}", i, Foo[i]);
            //}



            /*------------------------------CASE 11---------------------------*/
            //Dictionary<string, string> MyDictionary = new Dictionary<string, string>();
            //MyDictionary["Key1"] = "Value1";
            //MyDictionary["Key2"] = "Value2";

            Console.ReadKey();
        }
    }
}
