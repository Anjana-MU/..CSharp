class TernarySearchAlgo
    {
        // Function to perform Ternary Search
        //l is start index
        //r is last index
        public static int ternarySearch(int l, int r, int key, int[] ar)
        {
            if (r >= l) //4
            {

                // Find the mid1 and mid2
                int mid1 = l + (r - l) / 3; //0+(7-0)/3 = 0 + 3 = 2  after recursive call 3
                int mid2 = r - (r - l) / 3; //7-(7-0)/3 = 7 - 2 = 5  after recursive call 4

                // Check if key is present at any mid
                if (ar[mid1] == key)  // 30 == 40
                {
                    return mid1;
                }
                if (ar[mid2] == key) // 110 == 40
                {
                    return mid2;
                }

                // Since key is not present at mid,
                // check in which region it is present
                // then repeat the Search operation
                // in that region

                if (key < ar[mid1]) //40 < 30
                {

                    // The key lies in between l and mid1
                    return ternarySearch(l, mid1 - 1, key, ar);
                }
                else if (key > ar[mid2])  //40 > 110
                {

                    // The key lies in between mid2 and r
                    return ternarySearch(mid2 + 1, r, key, ar);
                }
                else
                {

                    // The key lies in between mid1 and mid2
                    return ternarySearch(mid1 + 1, mid2 - 1, key, ar); //(l = 3, r = 4, 40, ar)
                }
            }

            // Key not found
            return -1;
        }
    }

    /*Output
     int l, r, p, key;

            // Get the array
            // Sort the array if not sorted
            int[] ar = { 1, 20, 30, 40, 100, 110, 140, 190 };

            // Starting index
            l = 0;

            // end element index
            r = ar.Length - 1;

            // Checking for 5
            // Key to be searched in the array
            key = 40;

            // Search the key using ternarySearch
            p = TernarySearchAlgo.ternarySearch(l, r, key, ar);

            // Print the result
            Console.WriteLine("Index of " + key + " is " + p);           //Index of 40 is 3
     */
