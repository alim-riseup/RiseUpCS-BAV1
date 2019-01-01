using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayProgress
{
    class Program
    {
        static void PrintHelloWorld()
        {
            Console.WriteLine("Hello World");
        }

        static void Print(string parameter1, string paramter2)
        {
            Console.WriteLine(parameter1 + " " + paramter2);
        }

        static double SumOf(int x , double y)
        {
            return x + y;
        }

        static double SumOf2AddWithX(ref int x, double y = 3)
        {
            x = x + 2;
            return x + y;
        }

        static int SumWithParameters(params int[] parameters)
        {
            int i = 0;
            var sumResult = 0;

            for (i = 0; IsParameterConditionOkay(i, parameters.Length); i++)
            {
                var item = parameters[i]; // 0,1,2...
                sumResult = sumResult + item;
            }

            return sumResult;
        }

        static bool IsParameterConditionOkay(int currentIndex, int length)
        {
            return currentIndex < length;
        }

        static int ToInt(double x)
        {
            return (int) x;
        }

        static void Main(string[] args)
        {
            // PrintHelloWorld();

            Print("Hello", "World");

            var sumOfOneTwo = SumOf(1, 2);
            var toInt = ToInt(sumOfOneTwo);

            var numberToString = sumOfOneTwo.ToString();

            Print("1 + 2 =", numberToString);

            var summingExample = SumWithParameters(1, 2 , 3, 4, 5 , 6);

            Print("SumWithParameters(1, 2 , 3, 4, 5 , 6) =", summingExample.ToString());
            int w = 2;

            Print("w =", w.ToString());
            var someNumber = SumOf2AddWithX(ref w); // this x is get cloned.
            Print("SumOf2AddWithX(2, 3) =", someNumber.ToString());
            Print("w =", w.ToString());

            int[] wArray;

            CreateArray(out wArray);


            Console.ReadLine();
        }

        private static void CreateArray(out int[] wArray)
        {
            wArray = new int[10];            
        }
    }
}
