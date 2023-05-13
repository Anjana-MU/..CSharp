using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{

    /*Use case:
     * Create a student class with name,gender,standard and marks attributes
     * Make sure the Name and Gender fields are initialized mandatorily when object is created
     * Depending on the marks, come with up grade
     * Print Student Info
     * Capable of comparing two students depending on grade using operator ( >, < , =, !=)
     */

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
            get
            {
                return standard;
            }
            set
            {
                standard = value;

            }
        }

        public string Name
        { 
            get
            {
                return name;
            }
            set
            {
                name = value;

            }
        }

                

        public Gender Sex { get; set; }

        public StudentGrades Grade { get; set; }

        //------------------------------------------------------------------------------------------------------------------------------------------
        //Constructor with 2 paramters to make sure that everytime an object is created there two values are initialized for sure
        public Student(string name, Gender sex, int standard = 10)
        {
            Name = name;
            Sex = sex;
            Standard = standard;
        }         

       
        public enum StudentGrades
        {
            A = 5,
            B = 4,
            C = 3,
            F = 0
        }

        public void CalculateGrade(List<int> marks)
        {
            int total = marks.Sum();
            if (total > 400)
            {
                this.Grade = StudentGrades.A;
            }
            else if (total > 300)
            {
                this.Grade = StudentGrades.B;
            }
            else if (total > 100)
            {
                this.Grade = StudentGrades.C;
            }
            else if (total < 100)
            {
                this.Grade = StudentGrades.F;
            }
        }

        //------------------------------------------------------------------------------------------------------------------------------------------
        //Operator overloading
        public static bool operator >(Student c1, Student c2)
        {
            
           return ((int)c1.Grade > (int)c2.Grade) ? true : false;
            
        }

        public static bool operator <(Student c1, Student c2)
        {

            return ((int)c1.Grade < (int)c2.Grade) ? true : false;
        }

        public static bool operator ==(Student c1, Student c2)
        {

            return ((int)c1.Grade == (int)c2.Grade) ? true : false;
        }

        public static bool operator !=(Student c1, Student c2)
        {

            return ((int)c1.Grade != (int)c2.Grade) ? true : false;
        }
        //------------------------------------------------------------------------------------------------------------------------------------------
        //Printing student info
        public void StudentInfo()
        {
            Console.WriteLine("\n Student info :");
            Console.WriteLine(" Name: " + name + " | Sex : " + Sex + " | Standard : " + standard + " | Grade : " + Grade);
        }


        /*output
            Student s1 = new Student("Student1", Gender.Male,11);
            List<int> smarks1 = new List<int>() { 90, 60, 70, 90, 100 };
            s1.CalculateGrade(smarks1);                                           //Student info :
            s1.StudentInfo();                                                    // Name: Student1 | Sex : Male | Standard : 11 | Grade : A
            


            Student s2 = new Student("Student2", Gender.Female);
            List<int> smarks2 = new List<int>() {90, 60, 70, 40, 90 };          //Student info :
            s2.CalculateGrade(smarks2);                                         //Name: Student2 | Sex : Female | Standard : 10 | Grade : B
            s2.StudentInfo();

            Student s3 = new Student("Student3", Gender.Male);
            List<int> smarks3 = new List<int>() {30, 30, 3, 10, 10 };
            s3.CalculateGrade(smarks3);                                         //Student info:
            s3.StudentInfo();                                                   //Name: Student3 | Sex : Male | Standard : 10 | Grade : F

            Student s4 = new Student("Student4", Gender.Female,9);
            List<int> smarks4 = new List<int>() { 50, 60, 70, 40, 90 };
            s4.CalculateGrade(smarks4);                                         //Student info
            s4.StudentInfo();                                                   //Name: Student4 | Sex : Female | Standard : 9 | Grade : B



            Student s5 = new Student("Student5", Gender.Male, 12);
            List<int> smarks5 = new List<int>() { 50, 60, 70, 40, 10 };         
            s5.CalculateGrade(smarks5);                                         //Student info
            s5.StudentInfo();                                                   //Name: Student5 | Sex : Male | Standard : 12 | Grade : C


            Console.WriteLine();
            Console.WriteLine("Is student 1 greater than student 2 :{0}", s1 > s2);   //True
            Console.WriteLine("Is student 2 less than student 4 :{0}", s2 < s4);     //False
            Console.WriteLine("Is student 1 equals student 2 :{0}", s1 == s2);       //False
            Console.WriteLine("Is student 1 not equals student 2 :{0}", s1 != s2);   //True
         */

    }


    /*Usecase
     * Group name mandatory, List students can be added later or during initialization
     * Print information
     * GetStudent list based on gender
     * GetStudentList based on standard
     * Possible to add student to list anytime
     * New student  group object = StudentGroup + Student here you are returning new group
     * New student  group object = StudentGroup + StudentGroup here you are retuning new group
    */

    class StudentGroup
    {
        protected string groupName;
        protected List<Student> studentDetails = new List<Student>();

        public string GroupName
        {
            get
            {
                return this.groupName;
            }
            set
            {
                groupName = value;
            }
        }

        public StudentGroup(string groupName, List<Student> studentDetails = null) 
        {
            GroupName = groupName;
            if (studentDetails != null)
            { this.studentDetails = studentDetails; }

        }

        public void Add(Student std)
        {
            studentDetails.Add(std);
        }

        public void CompleteInfo()
        {            
            Console.WriteLine(" Group Name: " + GroupName);
            Console.WriteLine(" Total number of students : " + studentDetails.Count);
        }

        public void DetailsBasedonGender(Gender g)
        {
            Console.WriteLine(" Details of student with gender {0}", g);
            foreach (var item in studentDetails)
            {
                
                if (item.Sex == g)
                {
                    Console.WriteLine(" Name: " + item.Name + " | Sex : " + item.Sex + " | Standard : " + item.Standard + " | Grade : " + item.Grade);
                }
            }
        }

        public void DetailsBasedonStandard(int s)
        {
            Console.WriteLine(" Details of student with standard {0}", s);
            foreach (var item in studentDetails)
            {

                if (item.Standard == s)
                {
                    Console.WriteLine(" Name: " + item.Name + " | Sex : " + item.Sex + " | Standard : " + item.Standard + " | Grade : " + item.Grade);
                }
            }
        }

        public static StudentGroup operator +(StudentGroup c1, List<Student> c2)
        {

            return new StudentGroup("Drama",c2);

        }

        public static StudentGroup operator +(StudentGroup c1, StudentGroup c2)
        {

            return new StudentGroup("Debate");

        }

    }

    /*output
     
            List<Student> kids = new List<Student>();
            kids.AddRange(new List<Student>() { s1, s2, s3, s4, s5 });

            Console.WriteLine();
            StudentGroup sp1 = new StudentGroup("Sports");
            sp1.Add(s4);
            sp1.Add(s1);
            sp1.DetailsBasedonGender(Gender.Male);       //Details of student with gender Male
                                                        //Name: Student1 | Sex : Male | Standard : 11 | Grade : A

            Console.WriteLine();
            StudentGroup sp2 = new StudentGroup("Sports", kids);            // Details of student with gender Female
            sp2.DetailsBasedonGender(Gender.Female);                        // Name: Student2 | Sex : Female | Standard : 10 | Grade : B
            sp2.DetailsBasedonStandard(10);                                 //  Name: Student4 | Sex : Female | Standard : 9 | Grade : B

                                                                            // Details of student with standard 10
                                                                            //Name: Student2 | Sex : Female | Standard : 10 | Grade : B
                                                                            // Name: Student3 | Sex : Male | Standard : 10 | Grade : F


            Console.WriteLine();                                            //Group Name: Sports
            sp2.CompleteInfo();                                             //Total number of students : 5
                                                                            

            Console.WriteLine();                                            //Group Name: Drama
            StudentGroup dr1 = sp2 + kids;                                  //// Total number of students : 5
            dr1.CompleteInfo();

            Console.WriteLine();                                            //Group Name: Debate
            StudentGroup de1 = sp2 + sp1;                                   // Total number of students : 0
            de1.CompleteInfo();
     */


}
