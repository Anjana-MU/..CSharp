using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_2023
{
    class LINQExamples
    {
        public static void TESTLINQ()
        {
            int[] scores = { 10, 20, 30, 100, 110 };

            IEnumerable<int> scoreQuery =
            from score in scores
            where score > 80
            select score;

           
            foreach (int i in scoreQuery)
            {
                Console.Write(i + " ");
            }
        }
    }
}
