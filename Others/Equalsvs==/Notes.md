EqualityOperator(==) and EqualsMethod
- "==" is a comparison operator and Equals() method compares string
- "==" compares the reference identity and Equals() method compares only content 


== Operator
- Value types: Checks for values
- Reference type: Checks for reference of object
- String: checks for value
- == Operator compares the reference value
- When two or more string literals that are equivalent according to the string equality operator (§7.10.7) appear in the same program, these string literals refer to the same string instance. This means that if two string values are same then they are pointing to the same reference
- It can be overloaded but not overridden
- For predefined value types, the equality operator (==) returns true if the values of its operands are equal, false otherwise. For reference types other than string, == returns true if its two operands refer to the same object. For the string type, == compares the values of the strings.
	

ReferenceEquals
- Value types: Always returns false and gives a warning when used
- Reference type: Checks if two instances are pointing to same object
- It’s a static method
- It is same as == and compares the references, the difference is that it can be overridden
- It cannot be used on value types


Equals method
- Value types: Checks for values
- Reference types: Checks for reference
- Equals checks data equality for value types, and reference equality for non-value types (general objects).
- .Equals() tests for data equality. .Equals() can return True for different instances of the same object
- It's an instance method. Cannot work with null 
- It can be overridden	
	
Object ?
- Reference types have references so they can have null values, value types cannot have null values
- ? Allows value types to have null values
- T? is syntactic sugar for Nullable<T>
	
	https://coding.abel.nu/2014/09/net-and-equals/
	
	
Usage
- The rule of thumb is that for nearly all reference types, use Equals when you want to test the equality rather than reference identity. The exception is for strings; comparing strings with == does make things much simpler and more readable but you need to remember that both sides of the operator must be expressions of type string for the comparison to work properly.


Difference:
- == Checks if identity is equal i.e if it is exactly equal, Equals check its is data equal i.e logically equal
- The Equals method is just a virtual one defined in System.Object, and overridden by whichever classes choose to do so. The == operator is an operator which can be overloaded by classes, but which usually has identity behaviour.
- Essentially == is going to be bound at compile time using the types of the variables and .Equals is going to be dynamically bound at runtime.
