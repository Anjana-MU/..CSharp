using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_2023
{
    public class MethodExamples
    {
        public int x;

        public static void NoReturnType1()
        {
            Console.WriteLine("Method with void return type. Can be used to show some information");
        }

        public static void NoReturnType2(string name)
        {
            Console.WriteLine("Hello {0}!", name);
        }

        public static bool ReturnTypeBool(List<string> inputList)
        {
           return inputList.Count == 5 ? true : false; 
        }
        //Output: True
        //bool output;
        //List<string> ist = new List<string> { "a", "v", "a", "h", "g" };
        //output = MethodExamples.ReturnTypeBool(ist);
        // Console.WriteLine(output);

        //value types can be passed as reference with the 'ref' keyword
        //To use a ref parameter, both the method definition and the calling method must explicitly use the ref keyword

        public static int ValueAsRef(ref int number)
        {
            int changed_number = number + 10;
            return changed_number;
        }
        //Output: 16
        //int output;
        //int number = 6;
        //output = MethodExamples.ValueAsRef(ref number);
        //Console.WriteLine(output);


        public static string MultipleConditions(Dictionary<int, string> studentDetails)
        {
            foreach (var item in studentDetails.Keys)
            {
                if (item == 32)
                { return studentDetails[32]; } // if this is true, execution will not go below this.

                if (item == 47)
                { return studentDetails[47]; } // if this is true, execution will not go below this.
            }  

            return "Nothing Happened";

            //Output: ThirtyTwo
            //string output;
            ///Dictionary<int, string> studentDetails = new Dictionary<int, string>();
            //studentDetails.Add(32, "ThirtyTwo");
            //studentDetails.Add(47, "Forty-Seven");
            //studentDetails.Add(0, "zero");
           // output = MethodExamples.MultipleConditions(studentDetails);
            //Console.WriteLine(output);
        }

        public static void RefTypeAsRef(ref int[] arrayitems)
        {
            Array.Reverse(arrayitems);
        }
        // output: Initial array items3,4,5
        //        Changed array items 5,4,3
        /*
         * int[] arrayitems = { 3, 4, 5 };
            Console.WriteLine("Initial array items {0}", string.Join(",",arrayitems));
            MethodExamples.RefTypeAsRef(ref arrayitems);
            Console.WriteLine("Changed array items {0}", string.Join(",", arrayitems));
         */

        public static void SampleOutMethod(out int i) => i = 5;
        //Output: 5
        // int i;
       // MethodExamples.SampleOutMethod(out i);
          //  Console.WriteLine(i);

        public static void MethodOverloadingEx(ref int i)
        {
            i = i + 5;
            Console.WriteLine("Method with ref argument {0}", i);
        }

        public static void MethodOverloadingEx(int j)
        {
            j = j + 5;
            Console.WriteLine("Method without ref {0}", j);
        }

       //Method with ref argument 10
       //10
       // Method without ref 10
       //5

    }
}
