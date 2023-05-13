using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_2023
{
    abstract class AbstractClassExamples
    {
        //can have abstract properties
        public abstract int MyProperty { get; set; }
       
        //can have constructors
        public AbstractClassExamples()
        {
            Console.WriteLine("Constructor");
        }

        //can have abstract method
        public abstract void Method1();

        //can have non-abstarct methods, it is wring to define virtual or static methods
        public void Method2()
        {
        }
    }

    class Dervied1 : AbstractClassExamples
    {
        public override int MyProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        //Class that is dervied from abstract class need to implement all abstarct methods and properties
        public override void Method1()
        {
            throw new NotImplementedException();
        }

        
    }

    abstract class Shape
    {
        public abstract int GetArea();
    }

    class Square : Shape
    {
        public int _side;

        public Square(int n) => _side = n;
        public override int GetArea()
        {
            return (_side * _side);
        }
    }
    /*
    Input:  Square sq = new Square(10);
            Console.WriteLine($"Area of square  = {sq.GetArea()}");

    Output: Area of Square = 100;
    */

}
