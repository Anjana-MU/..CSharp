using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_2023
{
    //single inheritance: a single dervied class inherits from the base class
    public class Animals
    {
       
        public void Eat()
        {
            Console.WriteLine("Animal is eating");
        }
    }

    public class Dog : Animals
    {        
        public void Bark()
        {
            Console.WriteLine("Dog is barking");
        }
    }

    /*
     * Input:
       Dog dog = new Dog();
       dog.Eat();
       dog.Bark();
     * Output:
       Animal is eating
       Dog is barking
     */
    // From the above output we see that we are able to access the Eat() method of the animal base class in our dog derived class


    //multi-level inheritance: dervied class inherits from base class and in turn that dervied class is a base class for another class
    class Mammal : Animals
    {
        public void Run()
        {
            Console.WriteLine("Mammal is running");
        }
    }
    //above the derived class mammal is inheriting from the base class animal
    //below the class is derived from mammal hence making mammal a base class

    class Horse : Mammal
    {
        public void Gallop()
        {
            Console.WriteLine("Horse gallops");
        }
    }

    /*  Horse horse = new Horse();
        horse.Eat();  -- Animal is eating
        horse.Run();  -- Mammal is running
        horse.Gallop(); -- Horse gallops
     */

    //In our horse class we can access the methods from both Mammal and Animal base classes

    //Hieriarchial inheritance: base class is inherited by multiple dervied classes
    class Bird
    {
        public void Fly()
        {
            Console.WriteLine("Bird is flying.");
        }
    }

    class Eagle : Bird
    {
        public void Hunt()
        {
            Console.WriteLine("Eagle is hunting.");
        }
    }

    class Penguin : Bird
    {
        public void Swim()
        {
            Console.WriteLine("Penguin is swimming.");
        }
    }

    /*
     *      Penguin pg = new Penguin();
            pg.Fly(); -- Bird is flying.
            pg.Swim(); -- Penguin is swimming.
     */

    //multiple inheritance : Need interface to achieve this(has a relationship)
    //Derived class cannot inherit from multiple base classes

    interface SportStudent
    {
        public void Studentname()
        {
            Console.WriteLine("Student1");
        }
    }

    class Student : Mammal , SportStudent
    {
        public void Studentname()
        {
            Console.WriteLine("InterfaceStudent1");
        }
    }

    /*
     * Student std = new Student();
        std.Studentname(); -- InterfaceStudent1
         std.Run(); -- Mammal is running

     */
}
