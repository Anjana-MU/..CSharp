            class findexample
            {
               static void Main(string[] args)
               {
                  int[] ar = { 3, 20, 30, 40, 100, 110, 140, 190, 190 };
                  //The Array.Find() method searches for an element that matches the specified conditions using predicate delegate
                  //returns the first occurrence within the entire Array. 
                  //trying to find the first even element
                  int ar_result = Array.Find(ar, element => element % 2 == 0);
                  Console.WriteLine("First even element is {0}", ar_result);      //First even element is 20

                  List<string> newlist = new List<string> { "Steve", "Bill", "Bill Gates", "Ravi", "Mohan", "Salman", "Boski" };
                  //FindAllretrives all the matching elements
                  List<string> result= newlist.FindAll(element => element.StartsWith("B"));
                  Console.WriteLine("Items that start with B are: {0}", string.Join(',',result));   //Items that start with B are: Bill,Bill Gates,Boski
                 }
            }
