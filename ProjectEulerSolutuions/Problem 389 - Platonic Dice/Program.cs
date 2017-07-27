using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_389___Platonic_Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            //An unbiased single 4 - sided die is thrown and its value, T, is noted.
            //T unbiased 6 - sided dice are thrown and their scores are added together. The sum, C, is noted.
            //C unbiased 8 - sided dice are thrown and their scores are added together. The sum, O, is noted.
            //O unbiased 12 - sided dice are thrown and their scores are added together. The sum, D, is noted.
            //D unbiased 20 - sided dice are thrown and their scores are added together. The sum, I, is noted.
            //Find the variance of I, and give your answer rounded to 4 decimal places.
            
            Dictionary<int, int> tList = new Dictionary<int, int>();
            tList.Add(1, 1);
            tList.Add(2, 1);
            tList.Add(3, 1);
            tList.Add(4, 1);

            Dictionary<int, int> cList = new Dictionary<int, int>();
            foreach (KeyValuePair<int, int> tVal in tList)
            {
                RollXNumberOfYSidedDie(tVal.Key, 6, tVal.Value);
                CombineIntDictionaries(ref cList, ref results);
            }

            Dictionary<int, int> oList = new Dictionary<int, int>();
            foreach (KeyValuePair<int, int> cVal in cList)
            {
                RollXNumberOfYSidedDie(cVal.Key, 8, cVal.Value);
                CombineIntDictionaries(ref oList, ref results);
            }


            //Console.WriteLine("2");
            //foreach (KeyValuePair<int, int> cVal in cList)
            //{

            //}
            //Dictionary<int, int> oList = RollXNumberOfYSidedDie(cVal.Key, 8, cVal.Value);
            //Console.WriteLine("3");
            //foreach (KeyValuePair<int, int> oVal in oList)
            //{

            //}
            //Dictionary<int, int> dList = RollXNumberOfYSidedDie(oVal.Key, 12, oVal.Value);
            //Console.WriteLine("4");
            //foreach (KeyValuePair<int, int> dVal in dList)
            //{

            //}
            //Dictionary<int, int> iList = RollXNumberOfYSidedDie(dVal.Key, 20, dVal.Value);
            //Console.WriteLine("5");
            //foreach (KeyValuePair<int, int> iVal in iList)
            //{

            //}
            //Console.WriteLine(iVal);


            Console.WriteLine("------------------Finished!");
            Console.Read();
        }

        static void CombineIntDictionaries(ref Dictionary<int, int> a, ref Dictionary<int, int> b){
            foreach (KeyValuePair<int, int> val in b) 
                if (a.ContainsKey(val.Key))
                    a[val.Key] += val.Value;
                else
                    a.Add(val.Key, val.Value);

            b.Clear();
        }

        static int x, y, sum;
        static readonly List<int> rolls = new List<int>();
        static Dictionary<int, int> results = new Dictionary<int, int>();

        static void RollXNumberOfYSidedDie(int numberOfRolls, int sidesOfDie, int multiplier)
        {
            rolls.Clear();

            for (int a = 0; a < numberOfRolls; a++)
                rolls.Add(1);
            
            while(true) {
                for (y = 1; y <= sidesOfDie; y++){
                    rolls[numberOfRolls - 1] = y;
                    sum = rolls.Sum();
                    if (results.ContainsKey(sum))
                        results[sum] += multiplier;
                    else
                        results.Add(sum, multiplier);
                }
                 
                if (sum == (sidesOfDie * numberOfRolls))
                    break;

                x = numberOfRolls - 1;
                do
                {
                    rolls[x] = 1;
                } while (x > 0 && rolls[--x] == sidesOfDie);

                if (x >= 0)
                    rolls[x] += 1;
            }
        }
    }

}
