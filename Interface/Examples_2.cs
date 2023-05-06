using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_2023
{

    //An interface can implement another interface
    interface ITestInterface1
    {
        void Add(int num1, int num2);
    }
    interface ITestInterface2 : ITestInterface1
    {
        void Sub(int num1, int num2);
    }
    public class ImplementationClass1 : ITestInterface1
    {
        //Implement only the Add method
        public void Add(int num1, int num2)
        {
            Console.WriteLine($"Sum of {num1} and {num2} is {num1 + num2}");
        }
    }
    public class ImplementationClass2 : ITestInterface2
    {
        //Implement Both Add and Sub method
        public void Add(int num1, int num2)
        {
            Console.WriteLine($"Sum of {num1} and {num2} is {num1 + num2}");
        }
        public void Sub(int num1, int num2)
        {
            Console.WriteLine($"Sub of {num1} and {num2} is {num1 - num2}");
        }
    }

    /*output
            ImplementationClass1 imp1 = new ImplementationClass1();
            imp1.Add(10, 20); -- Sum of 10 and 20 is 30
            //imp1.sub(6, 3); not possible as interface 1 does not implement sub
            ImplementationClass2 imp2 = new ImplementationClass2();
            imp2.Add(30, 40); --Sum of 30 and 40 is 70
            imp2.Sub(6, 3); -- Sub of 6 and 3 is 3
     */
}
