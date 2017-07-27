using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Problem_31___Coin_Sums
{
    class Program
    {
        

        static void Main(string[] args)
        {

            List<int[]> results = new List<int[]>();
            Int64 numberOfTimes = 0;

            for (int vPounds = 0; vPounds <= 2; vPounds++) {
                if (vPounds == 2) {
                    numberOfTimes++;
                    results.Add(new int[7] { vPounds, 0, 0, 0, 0, 0, 0 });
                    break;
                }
                for (int vFiftys = 0; vFiftys <= 4; vFiftys++) {
                    if (2.0f.Equals((vPounds * 1.0f) + (0.5f * vFiftys))){
                        numberOfTimes++;
                        results.Add(new int[7] { vPounds, vFiftys, 0, 0, 0, 0, 0 });
                        break;
                    }
                    for (int vTwentys = 0; vTwentys <= 10; vTwentys++){
                        if (2.0f.Equals((vPounds * 1.0f) + (0.5f * vFiftys) + (0.2f * vTwentys))){
                            numberOfTimes++;
                            results.Add(new int[7] { vPounds, vFiftys, vTwentys, 0, 0, 0, 0 });
                            break;
                        }
                        for (int vTens = 0; vTens <= 20; vTens++){
                            if (2.0f.Equals((vPounds * 1.0f) + (0.5f * vFiftys) + (0.2f * vTwentys) + (0.1f * vTens))){
                                numberOfTimes++;
                                results.Add(new int[7] { vPounds, vFiftys, vTwentys, vTens, 0, 0, 0 });
                                break;
                            }
                            for (int vFives = 0; vFives <= 40; vFives++){
                                if (2.0f.Equals((vPounds * 1.0f) + (0.5f * vFiftys) + (0.2f * vTwentys) + (0.1f * vTens) + (0.05f * vFives))){
                                    numberOfTimes++;
                                    results.Add(new int[7] { vPounds, vFiftys, vTwentys, vTens, vFives, 0, 0 });
                                    break;
                                }
                                for (int vTwos = 0; vTwos <= 100; vTwos++){
                                    if (2.0f.Equals((vPounds * 1.0f) + (0.5f * vFiftys) + (0.2f * vTwentys) + (0.1f * vTens) + (0.05f * vFives) + (0.02f * vTwos))){
                                        numberOfTimes++;
                                        results.Add(new int[7] { vPounds, vFiftys, vTwentys, vTens, vFives, vTwos, 0 });
                                        break;
                                    }
                                    for (int vOnes = 0; vOnes <= 200; vOnes++){
                                        if (2.0f.Equals((vPounds * 1.0f) + (0.5f * vFiftys) + (0.2f * vTwentys) + (0.1f * vTens) + (0.05f * vFives) + (0.02f * vTwos) + (0.01f * vOnes))){
                                            numberOfTimes++;
                                            results.Add(new int[7] { vPounds, vFiftys, vTwentys, vTens, vFives, vTwos, vOnes });
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine("There are {0} number of ways to make £2 from the coins: £1, 50p, 20p, 10p, 5p, 2p, and 1p\nThese ways are:\n", numberOfTimes);
            Console.Read();

            foreach (int[] r in results){
                for (int a = 0; a < 7; a++)
                    Console.Write(r[a] + ",\t");
                Console.Write("\n");
            }

            Console.Read();
        }
    }
}
