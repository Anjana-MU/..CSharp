**Loops**
Iteration statements: The iteration statements repeatedly execute a statement or block of statements.
- For statement: Executes its body repeatedly while a specified Boolean expression evaluates to true.
- For each statement: Enumerates the elements of a collection and executes its body for each element of the collection.
- Do statement: conditionally executes its body one or more times. 
- While statement: conditionally executes its body zero or more times.
	
At any point within the body of an iteration statement, you can break out of the loop using the break statement. 
You can step to the next iteration in the loop using the continue statement.


**For loop:**
for(statement 1;statement 2;statement 3)
{
// code block to be executed
}

Statement 1 is executed (one time) before the execution of the code block.
Statement 2 defines the condition for executing the code block.
Statement 3 is executed (every time) after the code block has been executed.

for(initialization; test; increment)    

- The for loop executes a statement or a block of statements repeatedly until a specified expression evaluates to false. 
- Eg: This can be used if you want to print only the second number from the list of numbers or you want only even numbers
- All parts of for loop are optional. For can be as simple as
- For(;;;) implies an infinite loop


**Foreach loop:**
foreach(var d in data) 


**For vs Foreach**(https://stackoverflow.com/questions/10929586/what-is-the-difference-between-for-and-foreach)
- For each needs object collection(IEnumerable Collection)
- With for you can modify the collection item you are looping through, with for each you cannot (if you try to it gives an exception)
- With for loop you can specify the order of collection.
- For just needs to call get_item whereas for each needs to call Current, MoveNext and Reset
- The performance of for is better than for each.
- Use for when the collection you are looping through is a indexable collection
- IEnumerable (implementing IEnumerable just means that you provide a method that returns an enumerator). Lists, Arrays, Dictionaries, and all other group types all implement IEnumerable.


**While loop:**
The while loop loops through a block of code as long as a specified condition is True:
While (condition)
{
//code block to be executed
}

**Do/While loop**
The do/while loop is a variant of the while loop. This loop will execute the code block once, before checking if the condition is true, then it will repeat the loop as long as the condition is true.

**Do**
{// code block to be executed}
while(condition);

- A do while can be used in case you want to execute the block at least once. For eg: You want to retry accessing a resource
- while -> 'repeat until',
- do ... while -> 'repeat if'.

**For VS While**
- Both the loops have same performance
- Use a for loop if you know the number of iterations beforehand
	
	
**Ternary operator:** It is shorthand of if else. 
- Condition is an boolean expression, if condition is true statement 1 is executed else stmt2
	Condition ? Statement1 : statement2
	
**Lambda expression**
- Used to create an anonymous function
- Lambda declaration operator =>

**Break**
- Break statement will make the execution exit the loop, whereas continue will make the execution.
- Break can be used when you want to exit the loop if condition is not satisfied

**Continue**
- continue within the loop while ignoring the statements below the continue line.
- This is used when you want to continue with the next element in the loop when a condition is not satisfied

	

