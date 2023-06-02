using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_2023.Enemurable
{
    public enum Gender
    {
        Male,
        Female
    }


    class Student
    {
        protected string name;
        protected int standard;

        public int Standard
        {
            get{return standard;}
            set{standard = value;}
        }

        public string Name
        {
            get{return name;}
            set{name = value;}
        }


        public Gender Sex { get; set; }
        

        //------------------------------------------------------------------------------------------------------------------------------------------
        //Constructor with 2 paramters to make sure that everytime an object is created there two values are initialized for sure
        public Student(string name, Gender sex, int standard = 10)
        {
            Name = name;
            Sex = sex;
            Standard = standard;
        }

        //------------------------------------------------------------------------------------------------------------------------------------------
        //Printing student info
        public void StudentInfo()
        {
            Console.WriteLine("\n Student info :");
            Console.WriteLine(" Name: " + name + " | Sex : " + Sex + " | Standard : " + standard);
        }

    }

    class SportsTeam : IEnumerable<Student>
    {

        protected List<Student> studentDetails = new List<Student>();

        public List<Student> StudentDetails
        {
            get { return this.studentDetails; }
        }

        public SportsTeam(List<Student> studentDetails = null)
        {
            if (studentDetails != null)
            { this.studentDetails = studentDetails; }

        }

        public IEnumerator<Student> GetEnumerator()
        {
            return studentDetails.GetEnumerator();
        }

        //IEnumerable<T> inherits from IEnumerable, thus you need to implement IEnumerator as well
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }

    /*output
            Student s1 = new Student("Student1", Gender.Male, 11);   
            Student s2 = new Student("Student2", Gender.Female);
            Student s3 = new Student("Student3", Gender.Male);
            Student s4 = new Student("Student4", Gender.Female, 9);
            Student s5 = new Student("Student5", Gender.Male, 12);
           

            List<Student> kids = new List<Student>();
            kids.AddRange(new List<Student>() { s1, s2, s3, s4, s5 });
            
            SportsTeam team = new SportsTeam(kids);
            foreach (var item in team)               //you can loop through the SportsTeam object as it implements IEnumerable
            {
                item.StudentInfo();
            }

            //If sportsteam was not implementing IEnemurable then you would get the following error
            //foreach statement cannot operate on variables of type 'StudentGroup' because 
            //'StudentGroup' does not contain a public instance or extension definition for 'GetEnumerator'	
 
   
     */

}
