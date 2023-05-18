using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_2023
{
    class Equals_check
    {
        //"==" compares the reference identity and Equals() method compares only content
        public static void checkEquals()
        {
            int x = 5;
            int y = Convert.ToByte(x); //5
            //string x = "hello";
            //string y = new string(x.ToCharArray()); //"hello"
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

        //--------------------------------------------------------------------------------------------------

        public static void testOperator()
        {
            string s1 = "a";
            string s2 = "a";
            Console.WriteLine(s1 == s2);//True

            Console.WriteLine("Because the values of s1 and s2 are same they point to same reference :{0}",object.ReferenceEquals(s1, s2));// True
        }

        //In the above code one would claim that == should be false as == checks for references and s1 and s2 are two
        //different references, but that's not true due to string interning. s1 and s2 are references to the same object.

        public static void testOperator_1()
        {
            string a = new string('x', 1);
            string b = new string('x', 1);
            Console.WriteLine(a == b); // Uses string's implementation, prints True

            object c = a;
            object d = b;
            Console.WriteLine(c == d); // Reference identity comparison, prints False
        }

        //-------------------------------------------------------------------------------------------------------

        //== and ReferenceEquals both test for references but ReferenceEquals cannot be used for reference types
        public static void testOperator_2()
        {
            var s1 = "Blue";
            //Using a StringBuilder we get two different string instances with the same value.
            var sb = new StringBuilder("Bl");
            sb.Append("ue");
            var s2 = sb.ToString();

            //Even though == checks for reference, string is an exception and values are checked
            Console.WriteLine(s1 == s2); // True
            //We see the reference of both the objects is different
            Console.WriteLine(object.ReferenceEquals(s1, s2)); // False

            //WARNING : Possible unintended reference comparison; to get a value comparison, cast the left hand side to type ‘string’.
            object o1 = s1;
            //Since object type has been introduced, references are checked
            Console.WriteLine(o1 == s2); // False
            Console.WriteLine(s2 == o1); // False
        }

        //------------------------------------------------------------------------------------------------------

        public static void testEquals()
        {
            var s1 = "Blue";
            //Using a StringBuilder we get two different string instances with the same value.
            var sb = new StringBuilder("Bl");
            sb.Append("ue");
            var s2 = sb.ToString();

            object o1 = s1;
            
            Console.WriteLine(s2.Equals(o1)); // True
            Console.WriteLine(o1.Equals(s2)); // True
            Console.WriteLine(object.ReferenceEquals(s2, o1)); // False

            object o2 = s2;
            Console.WriteLine();
            //Here the values of both the objects are same, the reference if different
            //So, we can conculde that Equals check for data equality even for string
            Console.WriteLine(o1.Equals(o2));//True
            Console.WriteLine(ReferenceEquals(o1, o2)); // False

        }


        public static void testEquals_1()
        {
            var A = new test(1, 2, 3); 
            var B = A;
            var C = new test(1, 2, 3);

            Console.WriteLine(A == B);//True
            Console.WriteLine(A.Equals(B));//True
            Console.WriteLine(ReferenceEquals(A, B)); // True

            Console.WriteLine();
            Console.WriteLine(C == B);//False
            Console.WriteLine(C.Equals(B));//False
            Console.WriteLine(ReferenceEquals(C, B)); // False
        }

        class test
        {
            public test(int a , int b, int c)
            {

            }
        }

    }
  
}
