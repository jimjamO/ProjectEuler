using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Text.RegularExpressions;

namespace Problem_206___Concealed_Square
{
    class Program
    {

        static void Main(string[] args){
            //Find the unique positive integer whose square has the form 1_2_3_4_5_6_7_8_9_0,
            //where each “_” is a single digit.

            BigInteger maxNumber = 1929394959697989990;
            BigInteger minNumber = 1020304050607080900;

            BigInteger workingNumber = 0;
            BigInteger min = 0, previousInt = 2, currentInt = 2;

            bool correctAnswer;

            while (true){
                currentInt *= 12;
                workingNumber = BigInteger.Pow(currentInt, 2);

                if (workingNumber >= minNumber){
                    break;
                }else{
                    min = BigInteger.Max(currentInt, min);
                    previousInt = currentInt;
                }

                Console.WriteLine("Finding Min: {0}", previousInt);
            }

            min = previousInt;
            currentInt = 0;
            Console.WriteLine("Minimum value found: {0}^2 = {1}", min, BigInteger.Pow(min, 2));

            while (true) {
                currentInt += 1;
                workingNumber = BigInteger.Pow(min + currentInt, 2);

                correctAnswer = Regex.IsMatch(workingNumber.ToString(), "^1.2.3.4.5.6.7.8.9.0$");

                if (correctAnswer){
                    Console.WriteLine("Correct answer!!!! {0}^2 = {1}", (min + currentInt), workingNumber);
                    break;
                }else {
                    if (currentInt % 100000 == 0){
                        Console.WriteLine("Incorrect:\t{0}", workingNumber);
                        Console.WriteLine("\t\t1_2_3_4_5_6_7_8_9_0");
                    }
                }
            }
            
            Console.Read();
        }
    }
}
