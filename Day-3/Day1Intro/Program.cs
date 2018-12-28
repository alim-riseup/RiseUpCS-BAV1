using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * 1. Analysis
             * 2. Algorithom
             * 3. Flow Chart
             * 4. Code Writing
             * 5. Debugging
             * 6. Maintainance / Testing
             * 7. Deploying
             * */

            var condition1 = true && false || true; // T (Sub, Riz)
            var condition2 = true && false && true && true || false; // F (Emra, Shemonthi, Maruf, Saruj)
            var condition3 = (true && false) ||
                (false && true) ||
                (true && true); // True (Saruj, Himel, Marful, Rizan, EMran)

            var condition4 = condition1 && condition3 || true; // T(Emran, Maruf...)

            // If
            //var message = "Provide 2 words with pipes (windows|programfiles):";
            //Console.WriteLine(message);
            //var input = Console.ReadLine();

            //// validate with various (regex -> regular expression)
            //var splitedTexts = input.Split('|');

            //if (splitedTexts.Length != 2)
            //{
            //    var message2 = "User has entered wrong input. You should provide 2 words with pipes (windows|programfiles)";

            //    Console.WriteLine(message);
            //    Console.WriteLine("Waiting to proceed (press enter).");
            //    Console.ReadLine();

            //    // closing
            //    // return; // vondro
            //    throw new Exception(message); // alert
            //}

            //var windowsDirectoryPath = $@"c:\{splitedTexts.FirstOrDefault()}";
            //var programFilesPath = $@"c:\{splitedTexts.LastOrDefault()}";

            //var isWindowsDriveExist = Directory.Exists(windowsDirectoryPath);
            //var isProgramFilesDriveExist = Directory.Exists(programFilesPath);

            //var isWindowsAndProgramFilesDriveExist = isWindowsDriveExist &&
            //                                         isProgramFilesDriveExist;

            //if (isWindowsDriveExist)
            //{
            //    Console.WriteLine($"We have found {windowsDirectoryPath}.");
            //}

            //if (isProgramFilesDriveExist)
            //{
            //    Console.WriteLine($"We have found {programFilesPath}.");
            //}

            //if (isWindowsAndProgramFilesDriveExist)
            //{
            //    Console.WriteLine("Found Windows and Program Files folder in C drive.");
            //}
            //else
            //{
            //    Console.WriteLine("Not Found Windows and Program Files folder in C drive.");
            //}

            int x = 1;
            int y = 5;

            if (x != 1)
            {
                Console.WriteLine("x != 1");
            }
            else if (x == 1 && y == 5)
            {
                Console.WriteLine("x == 1 and y == 5");
            }
            else
            {

            }

            if (x == 1)
            {
                Console.WriteLine("x == 1");
            }

            int x2 = 5; // user input
            switch (x2)
            {
                case 1:
                case 2:
                    Console.WriteLine(2);
                    break;
                default:
                    break;
            }

            //for (var i = 4; i <= 4; i++)
            //{
            //    Console.WriteLine(i);
            //    i--;
            //}

            for (var i = 4; i != 4; i--)
            {
                Console.WriteLine(i);
            }

            while (true)
            {
                ////
            }

            do
            {
                // runs first time regardless of the condition
                // Condition determines to run next and other times.
            }
            while (true);

            Console.WriteLine("Hello World");

            Console.ReadKey();
        }
    }
}
