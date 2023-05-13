using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_2023
{
    class BaseClass
    {
        public virtual void Show()
        {
            Console.WriteLine("In base class");
        }
        //If you want to override a method, then the modifier needs to be virtual
    }

    class ChildClass1 : BaseClass
    {
        public override void Show()
        {
            Console.WriteLine("In child class");
        }
        //ChildClass1 cc = new ChildClass1();
       //cc.Show();
       //Output: In child class
    }

    class ChildClass2 : BaseClass
    {
        public override void Show()
        {
            base.Show();
            Console.WriteLine("In child class");
        }
        //ChildClass2 cc = new ChildClass2();
        //cc.Show();
        //Output: In base class In child class
    }
}
