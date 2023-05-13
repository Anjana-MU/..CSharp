using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_2023
{

    public class MyObject
    {
        public int SimpleInt { get; set; }
    }

    public class ListExample
    {

        public static void CreateList()
        {
            List<int> studentMarks = new List<int>{ 10, 20, 30 };
            List<string> stdNames = new List<string> { };
            stdNames.Add("Rocky");
            stdNames.Add("Leo");
            stdNames.Add("Trigga");

           
            List<string> copyList = new List<string>(stdNames).ToList();
            Console.WriteLine("Copied list before modification {0}", string.Join(',',copyList));
            stdNames[0] = "Shiro";
            Console.WriteLine("Standard name list after modification {0}", string.Join(',', stdNames));
            Console.WriteLine("Copied list after modification {0}", string.Join(',', copyList));


          
            List<int> copyList_marks = new List<int>(studentMarks).ToList();
            Console.WriteLine("Copied list before modification {0}", string.Join(',', copyList_marks));
            studentMarks[0] = 100;
            Console.WriteLine("Standard name list after modification {0}", string.Join(',', studentMarks));
            Console.WriteLine("Copied  list after modification {0}", string.Join(',', copyList_marks));
        }
        
        /* Output
        Copied list before modification Rocky,Leo,Trigga
        Standard name list after modification Shiro,Leo,Trigga
        Copied list after modification Rocky,Leo,Trigga
        Copied list before modification 10,20,30
        Standard name list after modification 100,20,30
        Copied  list after modification 10,20,30
         */

        public static void ShallowCopyExample1()
        {
            var orig = new List<MyObject>() { new MyObject() { SimpleInt = 0 } };
            Console.WriteLine("orig: {0}", orig[0].SimpleInt);
            var newval = new List<MyObject> (orig);
            Console.WriteLine("newval: {0}", newval[0].SimpleInt);
            newval[0].SimpleInt = 5;
            Console.WriteLine("newvalmodified: {0}", newval[0].SimpleInt);
            Console.WriteLine("origvalmodified: {0}", orig[0].SimpleInt);
        }

        /*
            orig: 0
            newval: 0
            newvalmodified: 5
            origvalmodified: 5
         */

        public static void ShallowCopyExample2()
        {
            var orig = new List<string>() {"abc","def"};
            Console.WriteLine("orig: {0}", orig[0]);
            var newval = new List<string>(orig);
            Console.WriteLine("newval: {0}", newval[0]);
            newval[0] = "hij:";
            Console.WriteLine("newvalmodified: {0}", newval[0]);
            Console.WriteLine("origvalmodified: {0}", orig[0]);

            /*output
              orig: abc
              newval: abc
              newvalmodified: hij:
              origvalmodified: abc
            */
        }




    }
}
