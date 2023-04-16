using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_2023
{
    class ForLoop
    {
        public static void ForLoopExplanation()
        {
            int i;
            int j = 3;
            for (i = 0, Console.WriteLine($"Start: i={i}, j={j}"); i < j; i++, j--, Console.WriteLine($"Step: i={i}, j={j}"))
            {
                //
            }
            // Output:
            // Start: i=0, j=3
            // Step: i=1, j=2
            // Step: i=2, j=1
            //With the above output you can verify that:
            //Initialization is executed once before the execution of the code block
            //Condition needs to return a boolean expression, and block of code is executed if it is true
            //Increment: Is executed after the block of code is executed
        }



    }
}
