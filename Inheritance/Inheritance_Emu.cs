using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_2023
{
    abstract class Shapes
    {
        protected int x;
        protected int y;

        public int X { get { return this.x; } set { this.x = value; } }

        public int Y { get { return this.y; } set { this.y = value; } }

        //method that need does not enable overriding in derived class
        public void moveTo(int newx, int newy)
        {
            this.x = newx;
            this.y = newy;
            Console.WriteLine("Non virtual base class method");
        }

        //can be overriden
        public virtual void Draw()
        {
            Console.WriteLine("Virtual Draw method of BASE class");
        }     
        
        //Sealed methods cannot be overriden in the derived class
        public virtual int GetArea()
        {
            Console.WriteLine("Virtual GetArea method of BASE class");
            return x * y;
        }

        //if you want to make it mandatory for a derived class to reimplement base class method then declare that class as abstract
        public abstract void GetCoordinates();

    }

    class Triangle : Shapes
    {
        public override void GetCoordinates()
        {
            Console.WriteLine("In Triangle class");
        }

        //we are trying to ovveride a method which was not marked as virtual, you get the following error.
        //cannot override inherited member 'Shapes.moveTo(int, int)' because it is not marked virtual, abstract, or override 
        //public override void moveTo(int newx, int newy)
        //{
        //    Console.WriteLine("Cannot ovverride method from base class which is not marked as virtual");
        //}


        /*If the base method is not declared as virtual and you try to use the same method name in virtual class
         * you will actually get a compiler warning telling you that you are trying to hide this base method
         */
        //The below code implicilty implements what 'new' does i.e hide the base class implementation
        public void moveTo(int newx, int newy)
        {
            X = newx;
            Y = newy;
            Console.WriteLine("Derived class"); 
        }

        /*output
            Triangle tri = new Triangle();
            tri.moveTo(10, 20);                -- Derived class
            Shapes shptri = new Triangle();
            shptri.moveTo(30, 40);             -- Non virtual base class method
        */
    }

    class Circle : Shapes
    {
        //Not overriding a virtual method
        //Draw() method is a virtual method in the base class, it is not necessary to override all the virtual methods
        //When a method is declared as virtual and its not ovveriden in derived class then the virtual implementation is supressed
        //and base class method is called
        //When a method is declared virtual during runtime, it checks for the ovverride implementation

        /* output
            Circle ci = new Circle();
            ci.Draw();  -- Virtual Draw method of base class
        */
        public override void GetCoordinates()
        {
            Console.WriteLine("In Circle class");
        }
    }

    class Figure : Shapes
    {
        public sealed override int GetArea()
        {
            return base.GetArea();
        }

        public override void GetCoordinates()
        {
            Console.WriteLine("In Figure class");
        }
    }

    class Rectangle : Figure
    {
        //public override int GetArea()
        //{

        //}

        //the above method gives the error that you cannot ovveride GetArea method as it is sealed

        //You can access the sealed methods in dervied class but you cannot override it
    }

    class Hexagon : Shapes
    {
        //Method hiding with NEW keyword

        private int a = 9;
        private int b = 9;

        public override void Draw()
        {
            Console.WriteLine("Virtual Draw method of DERIVED class");
        }

        public new int GetArea()
        {
            Console.WriteLine("Virtual GetArea method of DERIVED class");
            return a * b;
        }

        public override void GetCoordinates()
        {
            Console.WriteLine("In Hexagon class");
        }


        /*Output
            Hexagon hex = new Hexagon();
            hex.GetArea(); -- Virtual GetArea method of DERIVED class
            hex.Draw(); -- Virtual Draw method of DERIVED class

            Shapes shp = new Hexagon();
            shp.GetArea(); -- Virtual GetArea method of BASE class    
        //as you can see in the above statement the base class GetArea method is called as new hides base class implementation
            shp.Draw(); -- Virtual Draw method of DERIVED class
        */
    }

    //class Pentagon : Shapes
    //{
    //    //Here we are not implementating the abstract method, hence the error
    //    //'Pentagon' does not implement inherited abstract member 'Shapes.GetCoordinates()'	
    //}
    
    
     class Quad : Shapes
    {
        //here we will cast a derived class to a base class and then call the DRAW method which is present in both base and derived class
        //we are trying to understand which class method would be called in this case
        public override void GetCoordinates()
        {
            Console.WriteLine("In Quad class");
        }

        public override void Draw()
        {
            Console.WriteLine("Virtual Draw method of DERIVED class");
        }

        public new int GetArea()
        {
            Console.WriteLine("Virtual GetArea method of DERIVED class");
            return 100;
        }

        /*output:
            Quad qd = new Quad();
            //casting a derived class object to a base class object
            var a = (Shapes)qd;
            a.Draw();  //--Virtual Draw method of DERIVED class
            a.GetArea(); //--Virtual GetArea method of BASE class

            Console.WriteLine("#######");

            Shapes sh = new Quad();
            sh.Draw(); //--Virtual Draw method of DERIVED class
            sh.GetArea(); //--Virtual GetArea method of BASE class
        */
        // As you can see above, even if you cast a derived class object to base class the override method always points to
        //derived class whereas the new keyword hides the implementation of base class
    }

}
