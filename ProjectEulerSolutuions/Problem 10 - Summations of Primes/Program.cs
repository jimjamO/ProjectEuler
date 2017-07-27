using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Problem_10___Summations_of_Primes
{
    class Program
    {
        static void Main(string[] args)
        {

            //The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
            //Find the sum of all the primes below two million.

            List<int> primes = new List<int>();

            primes.Add(2);
            BigInteger total = 2;

            bool isPrime;
            int maxNumber = 2000000;

            for (int a = 3; a < maxNumber; a++){
                isPrime = true;
                foreach (int b in primes){
                    if (a % b == 0){
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime){
                    primes.Add(a);
                    total += a;
                    //Console.WriteLine("{0}\t\t{1}", a, total);
                }
            }

            Console.WriteLine("{0} = The sum of all the primes below {1}", total, maxNumber);
            Console.Read();
        }
    }
}
