using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Learning_2023
{

    class Test
    {
        const int Size = 10000000;

        public static void PerformanceCheck()
        {
            
            double[] data = new double[Size];
            //using a random number generator
            Random rng = new Random();

            //storing all the random number generated in the data array
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = rng.NextDouble();
            }

            //adding all the random numbers generated
            double correctSum = data.Sum();

            int k = 0;
            List<long> for_values = new List<long>();
            List<long> foreach_values = new List<long>();
            while (k <10)
            { 

                Stopwatch sw = Stopwatch.StartNew();
           
                    double sum = 0;
                    for (int j = 0; j < data.Length; j++)
                    {
                        sum += data[j];
                    }

                    //sum is same as adding all the random numbers generated
                    if (Math.Abs(sum - correctSum) > 0.1)
                    {
                        Console.WriteLine("Summation failed");
                        return;
                    }
           
                sw.Stop();
                Console.WriteLine("For loop: {0}", sw.ElapsedMilliseconds);
                for_values.Add(sw.ElapsedMilliseconds);

                sw = Stopwatch.StartNew();
            
                    double sum_each = 0;
                    foreach (double d in data)
                    {
                    sum_each += d;
                    }
                    if (Math.Abs(sum - correctSum) > 0.1)
                    {
                        Console.WriteLine("Summation failed");
                        return;
                    }
           
                sw.Stop();
                Console.WriteLine("Foreach loop: {0}", sw.ElapsedMilliseconds);
                foreach_values.Add(sw.ElapsedMilliseconds);
                k += 1;
            }
            Console.WriteLine("Average of for loop is {0}", for_values.Average());
            Console.WriteLine("Average of foreach loop is {0}", foreach_values.Average());
        }

    }
}

/*output
For loop: 57
Foreach loop: 52
For loop: 50
Foreach loop: 52
For loop: 56
Foreach loop: 52
For loop: 46
Foreach loop: 51
For loop: 54
Foreach loop: 54
For loop: 50
Foreach loop: 53
For loop: 52
Foreach loop: 67
For loop: 64
Foreach loop: 57
For loop: 53
Foreach loop: 59
For loop: 64
Foreach loop: 64
Average of for loop is 54.6
Average of foreach loop is 56.1
 */
