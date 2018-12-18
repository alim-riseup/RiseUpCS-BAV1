using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal x = 23.4983198901381000000002M;
            // this is my first program, single line, C\C++, C#, Java, JavaScript

            /*
             * Multiline comment
             * dwqqwqdqdw
             * */

            decimal y = 10;
            y = x;

            x = 5;

            object w = 'c';
            char q = 'W';
            string strExample = "my address";
            short shortType1 = 12;
            int intType1 = 32;

            intType1 = shortType1; // casting (implict casting)
            shortType1 = (short) intType1; // casting (explict casting)
            strExample = intType1.ToString(); // casting (explict casting)
            // .toString()
            const int x2 = 5;

            var variableName = 223;
            dynamic dynamicDatatype = "dwwddwwd";
            var ywiu = "wddwd";
            object www = "dwwddw";

            /**
             * 1. Analysis
             * 2. Algorithom
             * 3. Flow Chart
             * 4. Code Writing
             * 5. Debugging
             * 6. Maintainance / Testing
             * 7. Deploying
             * */

            Console.WriteLine("Hello World");

            Console.ReadKey();
        }
    }
}
