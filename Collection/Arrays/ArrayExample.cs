using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_2023
{
    class ArrayExamples
    {

        //single dimension array
        public static void SingleDimArray()
        {
            int[] intarray = new int[5];
            //array values are initialized to its types default value, for int it is 0 and for string as it is a reference type it is null
            string[] weekDays2 = { "Sun", "Mon", "Tue", "Wednes", "Thurs", "Fri", "Satur" };

            Console.WriteLine("Today is {0}day", weekDays2[0]);
        }

        public static void twoDimArray()
        {
            int[,] twodim = new int[2, 3] { { 1, 3, 4 }, { 1, 2, 3 } };
            Console.WriteLine("The second elemnt of second row is {0}", twodim[1, 1]);

        }

        public static void threeDimArray()
        {
            //the first rank in a 3-D array specifies how many 2-d arrays are present
            int[,,] threedim = new int[2, 2, 3] { { { 1, 2, 3 }, { 3, 4, 5 } },
                { { 1, 2, 3 }, { 3, 4, 5 } } };

            Console.WriteLine("The second element of second row is {0}", threedim[0, 1, 1]);
        }

        public static void ArraySortExample()
        {
            string[] names = {"A", "Z" ,"B", "a" };

            Array.Sort(names);

            Console.WriteLine(string.Join(", ", names)); //output a, A, B, Z
        }
    }
}
