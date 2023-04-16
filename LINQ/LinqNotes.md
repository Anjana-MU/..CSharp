Language-Integrated Query (LINQ) is the name for a set of technologies based on the integration of query capabilities directly into the C# language.

All LINQ query operations consist of three distinct actions:![image](https://user-images.githubusercontent.com/77484700/232289538-fcdc32bc-4160-47e1-a502-82374a4cfc93.png)
- Obtain Data Souce
- Create query
- Execute query

![image](https://user-images.githubusercontent.com/77484700/232289559-a49f3b56-0fdd-468d-a72a-f495f5b4e202.png)

- A query is not executed until you iterate over a query variable
- If you waant to execute the query on declaration itself, you can force execution by using .ToArray or .ToList
