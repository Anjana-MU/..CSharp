using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_2023
{
    class DictionaryExamples
    {
        public static void DictCreate()
        {
            Dictionary<int, string> studentDetails= new Dictionary<int, string>();
            //Add can be used to add values to dictionary
            studentDetails.Add(001, "Student1");
            studentDetails.Add(002, "Student2");
            studentDetails.Add(003, "Student3");

            // The Add method throws an exception if the new key is already in the dictionary.
            try
            {
                studentDetails.Add(001, "Student0");
            }
            catch(ArgumentException)
            {
                Console.WriteLine("An element with key 001 already exists");
            }

            //You can access the value using index
            Console.WriteLine("The value of 001 is {0}", studentDetails[1]);

            //Value of an index can be changed using the index
            studentDetails[2] = "Student002";
            Console.WriteLine(studentDetails[2]);

            //If key does not exist, then 'keynotfound' error is thrown
            try
            {
                Console.WriteLine(studentDetails[4]);
            }
            catch (Exception)
            {

                Console.WriteLine("Key does not exist");
            }

            //ContainsKey can be used to check if a key exists before retrieving or creating
            if (!studentDetails.ContainsKey(005))
            {
                studentDetails.Add(005, "Student5");            
            }

            //When forrach loop is used to enemurate values, key-values are returned
            foreach (KeyValuePair<int,string> student in studentDetails)
            {
                Console.WriteLine("Key is {0} for student {1}",student.Key, student.Value );
            }

            //Dict.Remove can be used to remove values
            studentDetails.Remove(002);
            Console.WriteLine("StudentDetails{0}", string.Join(',',studentDetails));           

        }

        public static void copyDict()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();

            dict.Add("White", "#FFFFFF");
            dict.Add("Grey", "#808080");
            dict.Add("Silver", "#C0C0C0");
            dict.Add("Black", "#000000");

            var dictCopy = new Dictionary<string, string>(dict);

            Console.WriteLine("New copied dict{0}",String.Join(", ", dictCopy));

            dictCopy.Remove("White");
            Console.WriteLine("Changed original dict {0}",string.Join(",", dict));
            Console.WriteLine("Changed new dict {0}", string.Join(",", dictCopy));
        }
    }
}
