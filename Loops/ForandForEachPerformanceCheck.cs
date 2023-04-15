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
        }
    }
}
