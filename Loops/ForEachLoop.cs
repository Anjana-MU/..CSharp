using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_2023
{
    class ForEachExamples
    {

        public static void ForEachExample1()
        {
            int[] Marks = { 115, 135, 105, 116, 122 };
            Console.Write("Marks :");
            foreach (int mark in Marks)
            {
                Console.Write($" {mark}");
            }
            Console.WriteLine();
            int Highest_Mark = Maximum(Marks);
            Console.WriteLine("The Highest Mark is " + Highest_Mark);
        }

        public static int Maximum(int[] Marks)
        {
            int maxSoFar = Marks[0];
            // for each loop 
            foreach (int mark in Marks)
            {
                if (mark > maxSoFar)
                {
                    maxSoFar = mark;
                }
            }
            return maxSoFar;
        }

        //output: Marks : 115 135 105 116 122
        //The Highest Mark is 135
    }
}
