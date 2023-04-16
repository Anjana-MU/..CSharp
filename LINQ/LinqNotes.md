Language-Integrated Query (LINQ) is the name for a set of technologies based on the integration of query capabilities directly into the C# language.

All LINQ query operations consist of three distinct actions:
	1. Obtain the data source.
	2. Create the query.
	3. Execute the query.
  
![image](https://user-images.githubusercontent.com/77484700/232289494-4e4f1b8c-3af8-48df-ac3d-f24a0b69d449.png)

- A query is not executed until you iterate over the query variable
- If  you want to execute the query on declaration itself, you can use .ToArray to .ToList(i.e force execution)
