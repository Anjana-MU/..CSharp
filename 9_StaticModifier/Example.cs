using System;

namespace Learning_2023
{
    //all the members of static class are static
    //Error: cannot declare instance member in static class
    public static class TemperatureConverter
    {
        //static field variables are allowed
        static double temp;

        //Error: Access modifiers are not allowed on static constructors
        //Error: A static constructor must be parameterless (because they are automatically executed only one)
        //public static TemperatureConverter(int temp)
        static TemperatureConverter()
        {
            temp = 0;
        }

        //static methods only operate on the input parameter given
        public static double CelsiusToFahrenheit(string temperatureCelsius)
        {
            // Convert argument to double for calculations.
            double celsius = Double.Parse(temperatureCelsius);

            // Convert Celsius to Fahrenheit.
            double fahrenheit = (celsius * 9 / 5) + 32;

            //a single copy of the static value is stored. 
            //if you try to access the temp value outside this method you can see that the value you can see that it wouldn't be 0
            temp = fahrenheit;           

            return fahrenheit;
        }

        public static double FahrenheitToCelsius(string temperatureFahrenheit)
        {

            //static method variables are not allowed
            //Error: the modifier static is not valid for this item
            //static int myInt;

            // Convert argument to double for calculations.
            double fahrenheit = Double.Parse(temperatureFahrenheit);

            // Convert Fahrenheit to Celsius.
            double celsius = (fahrenheit - 32) * 5 / 9;


            Console.WriteLine("Static field variable temp value after assigning it to fahrenheit value but a different method is :{0}", temp);


            return celsius;
        }
    }


    /*Output:
             static void Main(string[] args)
        {
            //non-static variables are allowed inside a static method
            double F , C = 0;

            Console.WriteLine("From Celsius to Fahrenheit");                                     -- From Celsius to Fahrenheit
            //static members are accessed using the classname followed by the member name
            //no object is needed
            F = TemperatureConverter.CelsiusToFahrenheit("20");
            Console.WriteLine("Temperature in Fahrenheit: {0}", F);                              -- Temperature in Fahrenheit: 68


            Console.WriteLine("From Fahrenheit to Celsius");                     -- From Fahrenheit to Celsius
            C = TemperatureConverter.FahrenheitToCelsius("20");                  -- Static field variable temp value after assigning it to fahrenheit value but a different method is :68
            Console.WriteLine("Temperature in Celsius: {0}", C);                 -- Temperature in Celsius: -6.666666666666667
        }
    */


}
