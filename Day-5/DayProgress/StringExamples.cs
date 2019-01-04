using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayProgress
{
    class StringExample
    {
        public void HasStringTest()
        {
            var stringArray = new string[3] { "hello", "hello World", "not make sense" };

            var isHelloExist = HasString(stringArray, "hello");

            var isHelloXExist = HasString(stringArray, "helloX");
            var isHellOXExist = HasString(stringArray, "hellO");
            var isHellOIgnoreCaseExist = HasString(stringArray, "hellO" , StringComparison.OrdinalIgnoreCase);

            var indexOfOW = "Hello World".IndexOf("o W", StringComparison.OrdinalIgnoreCase) > -1;
            var subStringOf = "Hello World".Substring(4, 5);

            var result = string.Join("-Joiner-", stringArray);


            return;

        }



        public bool HasString(string[] sourceArray,
                       string exist,
                       StringComparison stringComparison = StringComparison.Ordinal)
        {
            var isArrayEmpty = sourceArray == null || 
                          sourceArray.Length == 0;

            var isGivenEntryIsEmpty = string.IsNullOrWhiteSpace(exist);

            var isEmpty = isArrayEmpty || isGivenEntryIsEmpty;

            if (isEmpty)
            {
                return false;
            }

            for (int i = 0; i < sourceArray.Length; i++)
            {
                var currentItem = sourceArray[i];
                var isEquals = exist.Equals(currentItem, stringComparison);

                if (isEquals)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
