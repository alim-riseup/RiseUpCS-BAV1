using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayProgress
{
    class Program
    {

        class Example
        {
            public static int i; // one time
            public int X;
            public static int[] ArrayStaticResult = new int[15]; // 0-14
        }

        static int[] SampleFunction()
        {
            var example = new Example();
            // int i = 0;

            var arrayResult = new int[2];

            Example.i++;
            example.X++;
            // i++

            arrayResult[0] = Example.i;
            arrayResult[1] = example.X;

            return arrayResult; // 1
        }

        static int[] SampleFunction2()
        {
            var example = new Example();
            // int i = 0;

            var arrayResult = Example.ArrayStaticResult;

            // i++

            arrayResult[Example.i++] = Example.i;
            arrayResult[Example.i++] = example.X;


            // Example.i++; // 0, 1, 2, 3 ,s tatic
            example.X++; // variable, 1

            return arrayResult; // 1
        }

        static void PrintArray(int[] array)
        {
            Console.WriteLine($"Printing a new array:");

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"[{i}] : {array[i]}");
            }
        }

        static void Main(string[] args)
        {
            //PrintArray(SampleFunction2());
            //PrintArray(SampleFunction2());
            //PrintArray(SampleFunction2());
            //PrintArray(SampleFunction2());

            //var stringExmaple = new StringExample();

            //stringExmaple.HasStringTest();

            var recursionExample = new RecursionExample();

            recursionExample.FactorialCallTest();

            Console.ReadLine();
        }
    }
}
