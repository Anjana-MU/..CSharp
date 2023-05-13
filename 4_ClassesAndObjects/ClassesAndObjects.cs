using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_2023
{
    public class Person
    {
        //Fields
        private string name;

        //Property
        public string Name {
            get { return this.name; }
            set { this.name = value; }
        }

        // Constructor that takes no arguments:
        public Person()
        {
            Name = "Ctor1_Name";
        }

        // Constructor that takes one argument:
        public Person(string p_name)
        {
            Name = p_name;
        }
       

        // Method that overrides the base class (System.Object) implementation.
        public override string ToString()
        {
            return Name+'A';
        }
    }
    class TestPerson
    {
        static void Main()
        {
            // Call the constructor that has no parameters.
            var person1 = new Person();
            Console.WriteLine(person1.Name);

            // Call the constructor that has one parameter.
            var person2 = new Person("Ctor2_Name");
            Console.WriteLine(person2.Name);

            // Get the string representation of the person2 instance.
            Console.WriteLine(person2.ToString());
        }
    }
 
}
