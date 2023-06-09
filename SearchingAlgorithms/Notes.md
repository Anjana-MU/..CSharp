Searching Algorithms are designed to check for an element or retrieve an element from any data structure where it is stored.
- Sequential Search: In this, the list or array is traversed sequentially and every element is checked. Eg: Linear Search
- Interval Search: These algorithms are specifically designed for searching in sorted data-structures. These type of searching algorithms are much more efficient than Linear Search as they repeatedly target the center of the search structure and divide the search space in half. Eg: Binary Search


Time Complexity
- Time taken by an algorithm to solve the given problem is called time complexity

Space Complexity
- The amount of memory required by the algorithm to solve given problem is called space complexity

**Linear Search**

Advantages of Linear Search:
- Linear search can be used irrespective of whether the array is sorted or not. It can be used on arrays of any data type.
- Does not require any additional memory.
- It is a well-suited algorithm for small datasets.
Drawbacks of Linear Search:
- Linear search has a time complexity of O(N), which in turn makes it slow for large datasets.
- Not suitable for large arrays.
When to use Linear Search?
- When we are dealing with a small dataset.
- When you are searching for a dataset stored in contiguous memory.

Linear search has a time complexity of O(n), which means that the time it takes to find a specific value increases linearly with the size of the array or list.


**Binary Search**
- Binary search works on a sorted array. The value is compared with the middle element of the array. If equality is not found, then the half part is eliminated in which the value is not there. In the same way, the other half part is searched.
- Time complexity for binary search is O(log n)

Advantages of Binary Search:
- Binary search is faster than linear search, especially for large arrays.
- More efficient than other searching algorithms with a similar time complexity, such as interpolation search or exponential search.
- Binary search is well-suited for searching large datasets that are stored in external memory, such as on a hard drive or in the cloud.
Drawbacks of Binary Search:
- The array should be sorted.
- Binary search requires that the data structure being searched be stored in contiguous memory locations. 
- Binary search requires that the elements of the array be comparable, meaning that they must be able to be ordered.
Applications of Binary Search:
- It can be used for searching a database.

**Interpolation search**
- It is improvement over binary search
- It works well on a sorted array which is uniformly distributed(continues values)
- Interpolation search may go to different locations according to the value of the key being searched. For example, if the value of the key is closer to the last element, interpolation search is likely to start search toward the end side.

**Ternary search**
- It is similar to binary search, but has two mid values
- Here the collection is divided into three parts instead of two like in binary and key is searched in those parts
	
Steps to perform Ternary Search: 
- First, we compare the key with the element at mid1. If found equal, we return mid1.
- If not, then we compare the key with the element at mid2. If found equal, we return mid2.
- If not, then we check whether the key is less than the element at mid1. If yes, then recur to the first part.
- If not, then we check whether the key is greater than the element at mid2. If yes, then recur to the third part.
- If not, then we recur to the second (middle) part.


Built-In Searching methods:
- Collection.Find , collection.FindAll, collection.FindLast can be used to search for a particular element
- Array.BinarySearch() can also be used. It has 8 different overloads


