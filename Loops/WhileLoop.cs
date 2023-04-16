using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_2023
{
    class WhileLoop
    {  
        public static void CheckWhile()           
        {
            int i = 0;
            while (true)
            {
                Console.WriteLine("i = {0}",i);
                i++;
                if(i>10)
                {
                    break;
                }
            }
        }
    }
}
