class ListMethodExamples
    {
        public static void ListExamples()
        {
            int[] intarray = { 7, 8, 9 };
            List<int> intList = new List<int>() { 4, 31, 908, 3 , 3};
            intList.AddRange(intarray);
            //Adds value to the end of collection
            Console.WriteLine(string.Join(",",intList));
            //Output: 4,31,908,3,3,7,8,9

            var distinct_val = intList.Distinct();
            Console.WriteLine(string.Join(",",distinct_val));
            //output: 4,31,908,3,7,8,9

        }

    }
