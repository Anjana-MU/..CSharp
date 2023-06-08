//The below example is to search for a particular 31 in an integer array using linear search
    class LinearSearchAlgo
    {
        //Linear search is a sequential search
        public static int LinearSearch(int[] numbers, int target)
        {
            //loops through each element of the array
            for (int i = 0; i < numbers.Length; i++)
            {
                //checks if the array value matches the key given
                if (numbers[i] == target)
                {
                    //returns the index of the key if found
                    return i;
                }
            }
            return -11;
        }        
       
    }

    /*
     Output:
    int[] array = {56, 30, 20, 41, 67, 31, 22, 14, 52 };
    Console.WriteLine(LinearSearchAlgo.LinearSearch(array, 31));  //5
     */
