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

        public static void ForExample1()
        {
            List<int> numbers = new List<int> { 100, 2, 36, 4, 57, 6, 79, 8, 9, 104 };
            List<int> secondNum = new List<int>();
            //use a for loop to get only the second elements
            for (int i = 1; i < numbers.Count ; i = i+2)
            {
                secondNum.Add(numbers[i]);
            }
            Console.WriteLine("Second Numbers from the list are: {0}",string.Join(",",secondNum));
        }

        // Output: Second Numbers from the list are: 2,4,6,8,10

        public static void ForExample2()
        {
            Console.WriteLine("Enter one integer number:");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int count = 1; count <= number; count++)
            {
                Console.WriteLine(count);
            }

        }
        //Output for input 3 : 1 2 3

        public static void ForExample3()
        {
            for (int i = 1; i <= 2; i++) //Outer For Loop
            {
                Console.WriteLine($"Outer For Loop : {i}");
                for (int j = 1; j <= 5; j++) //Inner For Loop
                {
                    Console.Write($"{j}");
                }
                Console.WriteLine();
            }
        }
        /*Output:
            Outer For Loop : 1
            12345
            Outer For Loop : 2
            12345
        */

        public static void ForExample4()
        {
            int number, i;
            number = 13;
            for (i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    break;
                }

            }
            if (i == number && number >= 2)
            {
                Console.WriteLine($"{number} is a Prime Number");
            }

            else
            {
                Console.WriteLine($"{number} is not a Prime Number");
            }
        }
        //Output: 13 is a Prime Number
    }
}
