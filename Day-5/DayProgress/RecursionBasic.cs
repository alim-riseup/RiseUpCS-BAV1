using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayProgress
{
    class RecursionExample
    {
        /// <summary>
        /// Test Mirroring ("ama", "hello", "TyIyT")
        /// Write a function to get all the files inside sub directories
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public int FactorialExample(int i)
        {
            if (i <= 0)
            {
                return 1;
            }

            return i * (FactorialExample(i - 1));
        }

        public void FactorialCallTest()
        {
            var i5 = FactorialExample(5);


            return;
        }
    }
}
