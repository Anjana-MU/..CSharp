using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_2023
{
    public class ArrayMethodExamples
    {
        public static void BinarySearchArray()
        {
            int[] numbers = new int[5] { 9, 4, 2, 7, 21 };

            //Binary search works on a sorted array. The value is compared with the middle element of the array.
            ////If equality is not found, then the half part is eliminated in which the value is not there. In the same way, the other half part is searched.
            Array.Sort(numbers);
            int found = Array.BinarySearch(numbers, 90);
            //When a method says return, it means it is not modifying the original collection
            Console.WriteLine("The position of 21 is: {0}",found);

            //Output: The position of 21 is: 4. 
        }

        public static void ResizeArray()
        {
            int[] number = { 1, 2, 3 };
            //number[3] = 5; System.IndexOutOfRangeException: 'Index was outside the bounds of the array.'
            Array.Resize(ref number, 5);
            number[3] = 5;
            Console.WriteLine(number.Length);
            //Output: 5
           
        }
    }
}
