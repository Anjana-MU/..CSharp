using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_2023
{

    public class Complex
    {
        private int real;
        private int img;

        //constructor with optional parameters
        public Complex(int r = 0, int i = 0)
        {
            real = r;
            img = i;
        }


        public static Complex operator +(Complex c1, Complex c2)
        {
            Complex temp = new Complex();
            temp.real = c1.real + c2.real;
            temp.img = c1.img + c2.img;
            return temp;
        }

        //----------------------------------------------------------

        //Below we are overloading the operator + with different signature

        // Atleast one of the parameters passed must be the class type
        //public static int operator +(Complex c1, int c2) will give error
        //Error: One of the parameters of a binary operator must be the containing type.
        //Info: return type is not considered for overloading
        public static string operator +(Complex c1, int c2)
        {
            return c1.real + " + i" + c2;
        }

        public void Display()
        {
            Console.WriteLine($"{real} + i{img}");
        }

        /*
            Complex c1 = new Complex(3, 7);
            Complex c2 = new Complex(5, 2);
            Complex c3 = c1 + c2;
            c3.Display();  -- 8 + i9

            string complexval = c1 + 6; 
            Console.WriteLine(complexval);  -- 3 + i6;
         */
    }

//-----------------------------------------------------------------------------------------------------------------------------------------
    //EqualityOperator(==) and Equals() Method

    class EqualsCheck
    {

        public static void checkEquals()
        { 
            string x = "hello";
            string y = new string(x.ToCharArray()); //"hello"
            // == compares references
            //here reference is checked and its as string is a reference type both x and y point to same address
            Console.WriteLine(x == y); // True
           
           //Equals methods compares the actual values 
            Console.WriteLine(x.Equals(y)); //True

            object ox = x;
            object oy = y;
            //the object reference is different even if the values are same
            Console.WriteLine(ox == oy); // False
            Console.WriteLine(ox.Equals(oy)); //True
        }
    }
}
