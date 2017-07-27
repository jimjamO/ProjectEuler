using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Problem_28___Number_Spiral_Diagonals
{
    class Program
    {
        static void Main(string[] args)
        {

            BigInteger endResult = 1;

            int size = 2;
            BigInteger count = 1;

            while (size < 1002){
                for (int a = 0; a < 4; a++){
                    count += size;
                    endResult += count;
                    Console.WriteLine(count);
                }

                size += 2;
            }

            Console.WriteLine("\nFinsished! End Result: {0}", endResult);
            Console.Read();
        }
    }
}
