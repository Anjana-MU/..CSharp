using System;
using System.Collections.Generic;

namespace Employee
{
    class Employee
    {
        public int ID;
        public string Name;
        public int Age;
        
        private static int count = 0;
        private static int Curr_ID = 0;

        static List<string> Names;
        static int Oldest_Emp_Age;

        //constructor which takes two parameters
        public Employee(string Name, int Age)
        {
            Curr_ID = count++;
            this.Name = Name;
            this.Age = Age;
            this.ID = Curr_ID;
        }

        //constructor which takes three parameters
        public Employee(int ID, string Name, int Age) 
        {
            count++;
            this.ID = ID;
            this.Name = Name;
            this.Age = Age;
        }

        public static void Print_All_Emp_Names(List<Employee> employees)
        {
            Console.WriteLine("Total number of employees are : {0}",count);
            foreach (var emp in employees)
            {
                Console.WriteLine("Employee ID is {0}, Name is {1} and Age is {2}",emp.ID,emp.Name,emp.Age);
            }
            
        }

        public void Print_Info()
        {
            
        }

        public void Get_Tax()
        {

        }

    }

    /*output:
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("E1",25));            
            employees.Add(new Employee(8,"EI1", 30));        
            employees.Add(new Employee("E2", 26));
            employees.Add(new Employee(81, "EI2", 30));
            employees.Add(new Employee("E3", 26));

            Employee.Print_All_Emp_Names(employees);


            Total number of employees are : 5
            Employee ID is 0, Name is E1 and Age is 25
            Employee ID is 8, Name is EI1 and Age is 30
            Employee ID is 2, Name is E2 and Age is 26
            Employee ID is 81, Name is EI2 and Age is 30
            Employee ID is 4, Name is E3 and Age is 26
     */
}
