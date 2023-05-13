using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_2023
{
    //Override and virtual: virtual keyword 
    class Parent
    {
        public virtual void SayHello()
        {
            Console.WriteLine("Hello from Parent class");
            Console.WriteLine();
        }
    }

    class Child : Parent
    {
        public override void SayHello()
        {
          
            Console.WriteLine("Hello from child class");

        }
    }

    /*Input:
        Parent p1 = new Parent();
        p1.SayHello();
        Child c1 = new Child();
        c1.SayHello();
        Parent p2 = new Child();
        p2.SayHello();
     *output:
        Hello from Parent class

        Hello from child class
        Hello from child class
     */


    class Parent1
    {
        public void SayHello1()
        {
            Console.WriteLine("Hello from Parent class");
            Console.WriteLine();
        }
    }

    class Child1 : Parent1
    {
        public new void SayHello1()
        {

            Console.WriteLine("Hello from child class");

        }
    }

    /*Input:
    Parent1 p1 = new Parent1();
    p1.SayHello1();
    Child1 c1 = new Child1();
    c1.SayHello1();
    Parent1 p2 = new Child1();
    p2.SayHello1();
    *output:
    Hello from Parent class

    Hello from child class
    Hello from Parent class
 */
}
