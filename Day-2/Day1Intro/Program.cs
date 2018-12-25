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


            char variableChar1 = 'a';
            char variableChar2 = 'b';

            // Good practice, naming convention, good and proper naming for your variables and methods and everything.
            bool isVaraiableChar1EqualToA = variableChar1 == 'a';
            bool isVaraiableChar2EqualToB = variableChar1 == 'b';

            bool conditionCheckChar1AndChar2IsAAndBRespectivly = isVaraiableChar1EqualToA &&
                                                                 isVaraiableChar2EqualToB;

            bool eitherConditionCheck = isVaraiableChar1EqualToA ||
                                        isVaraiableChar2EqualToB;
            bool trueCondition = eitherConditionCheck;
            bool falseCondition = false;


            bool notOperatorExample = !falseCondition;

            int a = 122;
            int b = 222;
            // +, -, /, *
            a = a * b;
            // ++, --
            a = a + 1; // a++;

            ++a; //a++
            --a;
            a--;
            // /,*,+,- (BODMAS)
            int w2 = a++ - --a + ++a;
            // int u2 *= a + b;
            

            char temp = variableChar1;
            variableChar1 = variableChar2;
            variableChar2 = temp;

            string strExample = "my address";
            short shortType1 = 12;
            int intType1 = 32;
            Int64 longType = 13201283011382012;
            long longTypeDirect = 222;

            x = 555 * 32;

            bool condition = true;

            //condition = 


            longTypeDirect = intType1; // casting (implict casting)

            intType1 = shortType1; // casting (implict casting)
            shortType1 = (short) intType1; // casting (explict casting)
            strExample = intType1.ToString(); // casting (explict casting)
            // .toString()
            const int x2 = 5;

            var myNewIntVar = "12";


            var variableName = 223;
            dynamic dynamicDatatype = "dwwddwwd";
            var ywiu = "wddwd";
            object www = "dwwddw";
            object number = 1234;
            dynamicDatatype = 12;

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
