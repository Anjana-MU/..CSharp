class BinarySearchAlgo
    {
        //The below example is to search for a particular 31 in an integer array using binary search
        //BinarySearch uses Divide and conquer technique, it works on sorted collection
        public static int BinarySearchIterative(int[] inputArray, int key)
        {
            int min = 0;
            int max = inputArray.Length - 1;
            while (min <= max)
            {
                //Getting the middle value from the given array
                int mid = (min + max) / 2;
                //Best case, the middle value is the key value
                if (key == inputArray[mid])
                {             
                    //if key is found then its index is returned
                    return ++mid;
                }
                //The key value is less than the middle value
                else if (key < inputArray[mid])
                {
                    //ignoring the second part of the array
                    max = mid - 1;
                }
                else
                {
                    //ignoring the first part of array
                    min = mid + 1;
                }
            }
            //if key not found the -1 is returned
            return -1;
        }

        /*Output
            int[] array = {56, 30, 20, 41, 67, 31, 22, 14, 52 };
            Console.WriteLine(BinarySearchAlgo.BinarySearchIterative(array, 31));  // here the array is not sorted, hence the key was not found
        
            int[] array = {56, 30, 20, 41, 67, 31, 22, 14, 52 };
            Array.Sort(array);
            Console.WriteLine(BinarySearchAlgo.BinarySearchIterative(array, 31));  //5
         
         */


        //Binary search can also be done recursively
        public static int BinarySearchRecursive(int[] inputArray, int key, int min, int max)
        {
            if (min > max)
            {
                return -1;
            }
            else
            {
                int mid = (min + max) / 2;
                if (key == inputArray[mid])
                //Best case, the middle value is the key value
                {
                    return ++mid;
                }
                else if (key < inputArray[mid])
                {
                    //ignoring the second part of the array
                    //resetting the max value when the key value is less than the mid value so as to change the checking range
                    return BinarySearchRecursive(inputArray, key, min, mid - 1);
                }
                else
                {
                    //ignoring the first part of array
                    //resetting the max value when the key value is less than the min value so as to change the checking range
                    return BinarySearchRecursive(inputArray, key, mid + 1, max);
                }
            }
        }

        /*Output
             int[] array = { 56, 30, 20, 41, 67, 31, 22, 14, 52 };
            Console.WriteLine(BinarySearchAlgo.BinarySearchRecursive(array, 31,0,array.Length - 1));  // -1 here the array is not sorted, hence the key was not found

            int[] array1 = { 56, 30, 20, 41, 67, 31, 22, 14, 52 };
            Array.Sort(array);
            Console.WriteLine(BinarySearchAlgo.BinarySearchRecursive(array, 31, 0, array.Length - 1));  //5
         
         */



        //==================================================================================

        //BinarySearch can also be done using in-built methods

        /*
        List<int> newlist = new List<int> { 4, 1, 14, 6 };
        newlist.Sort();
        Console.WriteLine(newlist.BinarySearch(4)); //1, if list was not sorted, then you would get a random negative number as output like -3
        Console.WriteLine(newlist.BinarySearch(400)); //-5
         */

        /*
            int[] array = {56, 30, 20, 41, 67, 31, 22, 14, 52 };
            Array.Sort(array);            
            Console.WriteLine(BinarySearchAlgo.BinarySearchIterative(array, 311)); //-1
            Console.WriteLine(BinarySearchAlgo.BinarySearchIterative(array, 31)); //5
         */
    }
