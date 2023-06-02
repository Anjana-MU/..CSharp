using System;
using System.Collections;
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
     * New student  group object = StudentGroup + Student returns the same group with added student
     * New student  group object = StudentGroup + StudentGroup returns a new group with student from both groups and the name of the group as that of the first one
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

        public List<Student> StudentDetails
        {
            get { return this.studentDetails; }
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
            foreach (var item in studentDetails)
            {
                Console.WriteLine(" Name: " + item.Name + " | Sex : " + item.Sex + " | Standard : " + item.Standard + " | Grade : " + item.Grade);
                
            }
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
            StudentGroup sameGroup = c1;
            foreach (var stu in c2)
            {
                if (!sameGroup.StudentDetails.Contains(stu))
                {
                    sameGroup.Add(stu);
                }
            }  
            return sameGroup;

        }

        public static StudentGroup operator +(StudentGroup c1, StudentGroup c2)
        {
            IEnumerable<Student> c3 = c1.StudentDetails.Union(c2.StudentDetails);
            return new StudentGroup(c1.groupName, c3.ToList());

        }

    }

    /*output
     
            List<Student> kids = new List<Student>();
            kids.AddRange(new List<Student>() { s1, s2});

            List<Student> kids_1 = new List<Student>();
            kids_1.AddRange(new List<Student>() { s3, s1, s4});

            Console.WriteLine();
            StudentGroup sp1 = new StudentGroup("Sports");
            sp1.Add(s4);
            sp1.Add(s5);
            sp1.DetailsBasedonGender(Gender.Male);       //Details of student with gender Male
                                                        // Name: Student5 | Sex : Male | Standard : 12 | Grade : C

            Console.WriteLine();
            StudentGroup sp2 = new StudentGroup("Music", kids);            // Details of student with gender Female
            sp2.DetailsBasedonGender(Gender.Female);                        // Name: Student2 | Sex : Female | Standard : 10 | Grade : B

                                                                            // Details of student with standard 10
                                                                            //Name: Student2 | Sex : Female | Standard : 10 | Grade : B


            
            Console.WriteLine();
            StudentGroup sp3 = new StudentGroup("Karate", kids_1);          // Group Name: Karate
            sp3.CompleteInfo();                                             // Total number of students : 3
                                                                            //Name: Student3 | Sex : Male | Standard : 10 | Grade : F
                                                                            // Name: Student1 | Sex : Male | Standard : 11 | Grade : A
                                                                            // Name: Student4 | Sex : Female | Standard : 9 | Grade : B



            Console.WriteLine(); //sp2 has s1,s2 --- kids_1 has s3,s1,s4       //Group Name: Music
            StudentGroup dr1 = sp2 + kids_1;                                  // Total number of students : 4
            dr1.CompleteInfo();                                                //Name: Student1 | Sex : Male | Standard : 11 | Grade : A
                                                                               // Name: Student2 | Sex : Female | Standard : 10 | Grade : B
                                                                               // Name: Student3 | Sex : Male | Standard : 10 | Grade : F
                                                                                //Name: Student4 | Sex : Female | Standard : 9 | Grade : B

            Console.WriteLine(); //sp1 has s4,s5 --- sp3 has s3,s1,s4        //Group Name: Sports
            StudentGroup de1 = sp1 + sp3;                                   // Total number of students : 4
            de1.CompleteInfo();                                             // Name: Student4 | Sex : Female | Standard : 9 | Grade : B
                                                                            //Name: Student5 | Sex : Male | Standard : 12 | Grade : C
                                                                            //Name: Student3 | Sex : Male | Standard : 10 | Grade : F
                                                                            // Name: Student1 | Sex : Male | Standard : 11 | Grade : A
     */


}
