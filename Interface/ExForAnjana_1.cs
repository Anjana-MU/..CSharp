using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_2023
{
    interface IDrawable
    {
        //only declaration in method, should be implemented in the class using it
        public void Draw();

        //method with default implementation
        public void moveTo()
        {
            Console.WriteLine("Interface moveTo");
        }

        //interface can have static implementation
        public static void Pen()
        {
            Console.WriteLine("Interface Pen");
        }
        
    }

    interface IPaint
    {
        public void Draw();
    }

    class Rectangles : IDrawable
    {
        public void Draw()
        {
            Console.WriteLine("Drawing Rectangle");
        }

        //method with default implementation may or may not be implemented. 
        //if not implemented in derived class then it cannot be accessed
        public void moveTo()
        {
            Console.WriteLine("Rectangle moveTo");
        }

       
    }

    /*output
            Rectangles rect = new Rectangles();
            rect.Draw(); -- Drawing Rectangle
            //if moveTo was not implemented in the derived class then the below line would give error
            rect.moveTo(); -- Rectangle moveTo
            IDrawable d = new Rectangles();
            d.Draw(); -- Drawing Rectangle
            d.moveTo(); -- Rectangle moveTo
            IDrawable.Pen(); -- Interface Pen
     */


    //-----------------------------------------------------------------------------------------

    //Explicit Interface Implementation

    public class Circles : IDrawable, IPaint
    {
        // If a class is implementing two interfaces and both have same method name and signature, to call a different implementation
        // depending on which interface is in use, you can implement an interface member explicitly.

        //An explicit interface implementation is a class member that is only called through the specified interface.
        //Name the class member by prefixing it with the name of the interface and a period in the derived class.

        void IDrawable.Draw()
        {
            Console.WriteLine("IDrawable draw");
        }

        void IPaint.Draw()
        {
            Console.WriteLine("IPaint draw");
        }
    }

    /*output
            Circles cir = new Circles();
            //using reference variable of interface
            IDrawable id = cir;
            id.Draw();  -- IDrawable draw
            IPaint ip = cir;
            ip.Draw(); -- IPaint draw
     */
}
