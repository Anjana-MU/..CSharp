- Arrays are used to store multiple values in a single variable

-  Create an array of four elements, and add values later
 	string[] cars =new string[4];
	
-  Create an array of four elements and add values right away
	 string[] cars =new string[4 ] {"Volvo","BMW","Ford","Mazda"};
	
 -  Create an array of four elements without specifying the size
	 string[] cars =new string[] {"Volvo","BMW","Ford","Mazda"};
	
-  Create an array of four elements, omitting the new keyword, and without specifying the size
	string[] cars = {"Volvo","BMW","Ford","Mazda"};
	
**- An array stores a fixed-size sequential collection of elements of the same type.**
- **Array is stored in contiguous manner**


- A jagged array is an array of arrays, and therefore its elements are reference types and are initialized to null.


Single dimension array:
- Can be created by specifying the type of array(value or reference) and size of array
- The array values are initialized to its default values

Multi-dimensional array:
- Array can be of different dimensions depending on the its declaration during creation
- Two - dimensional array of 2 rows and 3 columns
	Int[,] twodimarray = new int[2,3];  --> array with 2 rows and 3 columns
- 3D - Array (the first rank indicates the number of rows of inner two-dimensional arrays. )
	Int[,,] threedimarray = new int [2,3,4] --> 2 array with 3rows and 4cols
	
Jagged array
- A jagged array is an array whose elements are arrays, possibly of different sizes. A jagged array is sometimes called an "array of arrays."
- 
![image](https://user-images.githubusercontent.com/77484700/232307606-85a32a47-ceb6-4890-86c5-ad8293a7f509.png)


Shallow copy of array:
- Array.clone() creates a shallow copy
- Using a assignment operator(=) you can do a shallow copy as well

Deep copy:
- One way of deep copy is to loop through all the elements of the original array and assign it to new array
	For(i=0; i<new_array.length;i++)
	{
	New_array[i] = original_array[i];
	}
- Array.Copy(original_array, new_array_2, original_array.Length);
- When you are deep copying an array which has reference values, those values need to be deep copied as well

Built-in methods of arrays are
- Rank
- Sort
- Reverse

