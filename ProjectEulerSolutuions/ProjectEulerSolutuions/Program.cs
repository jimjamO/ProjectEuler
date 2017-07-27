using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1___Multiples_of_3_and_5
{
    class Program
    {
        static void Main(string[] args){
            //If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9.The sum of these multiples is 23.
            //Find the sum of all the multiples of 3 or 5 below 1000.

            int finalSum1 = 0;
            int finalSum2 = 0;

            for (int tempNum = 3; tempNum < 1000; tempNum += 3){
                if(tempNum % 5 != 0)
                    finalSum1 += tempNum;
            }

            for (int tempNum = 5; tempNum < 1000; tempNum += 5)
            {
                finalSum2 += tempNum;
            }

            Console.WriteLine("Final Sum = {0}", finalSum1 + finalSum2);
            Console.Read();
        }
    }
}
