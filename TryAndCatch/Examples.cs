using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_2023
{
    class TryCatchThrow
    {

        public static void Exception1()
        {
            int[] array1 = { 1, 2, 3 };

            try
            {
                Console.WriteLine(array1[3]);
                //This throws an excpetion as array size is only 3
            }
            catch(IndexOutOfRangeException e)
            {
                // You can use catch to close a file before throwing an exception
                throw new IndexOutOfRangeException();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("The finally statement lets you execute code, after try...catch, regardless of the result:");
                //You can use finally to dispose an object
            }
        }

        public static void Exception2()
        {
            try
            {
                int i = 20;
                // Suspect code
                int result = i / 0;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Attempted divide by zero. {0}", ex.Message);
            }
        }
    }
}
