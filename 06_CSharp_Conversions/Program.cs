using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_CSharp_Conversions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*------------------------------CASE 1---------------------------*/
            double result = 10 / 3;

            double goodResult = 10f / 3;


            double goodResult2 = 10.0 / 3;
            double goodResult3 = 10 / 3.0;

            /*------------------------------CASE 2---------------------------*/
            int x = 10;

            // won't compile
            // string y = (string) x;

            object xAsObject = (object)x;

            int xAgain = (int)xAsObject;

            /*------------------------------CASE 3---------------------------*/
            string xAsPossibleString = xAsObject as string;

            if (xAsPossibleString != null)
            {

            }

            /*------------------------------CASE 4---------------------------*/
            if (xAsObject is string castedToString)
            {
                Console.WriteLine(castedToString.Length);
            }
            /*------------------------------CASE 5---------------------------*/
            string xAsString = (string)xAsObject;

            /*------------------------------CASE 6---------------------------*/

            int y = 10;
            object yAsObject = y;

            double yAsDouble = (double) yAsObject;
            double yAsDoubleGood = (double)(int) yAsObject;

            /*------------------------------CASE 7---------------------------*/

            // int y = "sdada";
        }
    }
}
