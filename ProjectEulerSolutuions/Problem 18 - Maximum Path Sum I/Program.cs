using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_18___Maximum_Path_Sum_I
{
    class Program
    {

        static int[][] numbers = new int[15][]{
            new int[]{75},
            new int[]{95, 64},
            new int[]{17, 47, 82},
            new int[]{18, 35, 87, 10},
            new int[]{20, 04, 82, 47, 65},
            new int[]{19, 01, 23, 75, 03, 34},
            new int[]{88, 02, 77, 73, 07, 63, 67},
            new int[]{99, 65, 04, 28, 06, 16, 70, 92},
            new int[]{41, 41, 26, 56, 83, 40, 80, 70, 33},
            new int[]{41, 48, 72, 33, 47, 32, 37, 16, 94, 29},
            new int[]{53, 71, 44, 65, 25, 43, 91, 52, 97, 51, 14},
            new int[]{70, 11, 33, 28, 77, 73, 17, 78, 39, 68, 17, 57},
            new int[]{91, 71, 52, 38, 17, 14, 91, 43, 58, 50, 27, 29, 48},
            new int[]{63, 66, 04, 68, 89, 53, 67, 30, 73, 16, 69, 87, 40, 31},
            new int[]{04, 62, 98, 27, 23, 09, 70, 98, 73, 93, 38, 53, 60, 04, 23}
        };

        static void Main(string[] args){
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine("Highest number is {0}", RecursiveSearch(0, 0, 0));
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
            Console.Read();
        }

        static int RecursiveSearch(int level, int x, int carryOver){
            if (level < 14)
                return carryOver + numbers[level][x] + Math.Max(RecursiveSearch(level + 1, x, carryOver), RecursiveSearch(level + 1, x + 1, carryOver));
            else{
                return carryOver + numbers[level][x];
            }
        }
    }
}
