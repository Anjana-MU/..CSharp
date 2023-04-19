Reference and Value types:

Value type:
- Stores a copy of the value
- Changes made to that value does not affect the original value
- Characters, Structs, Enumerations, integer and floating types are all values types
- Stored on stack

Reference type:
- Passes the address of the value
- Changes to the value, changes the original value
- Arrays, Dictionary, Lists, Collections, Class objects, Delegates, String, Interface are reference types
- 'ref' keyword can be used to pass value types as reference type
- Stored on heap
- Address of the reference type is stored on stack.


![image](https://user-images.githubusercontent.com/77484700/232970949-23948621-7de8-4eb1-991b-4358f69e1f51.png)

Enumerations                                                                                        
- Used to give list of options to user                                                        
- Storing values one after another           
- All enum will be associated with int values by default
- Enum name can be passed as an argument in methods
- An enum is a special "class" that represents a group of constants (unchangeable/read-only variables).
- To get the integer value from an item, you must explicitly convert the item to an int:


enumMonths
{
January, // 0
February,// 1 
}
staticvoidMain(string[]args)
{
intmyNum =(int)Months.January;
Console.WriteLine(myNum);
}


- Use enums when you have values that you know aren't going to change


Struct
- Struct is used to encapsulate data and related functionality
- They do not support inheritance but they can implement interface
- struct can include constructors, constants, fields, methods, properties, indexers, operators, events & nested types.
- struct cannot include a parameter less constructor or a destructor.
- Structs and classes seem similar, but struct is value type and should be used only when you are sure that you would be performing some basic assignment/declaration
- Default modifier for struct is internal , for class it is public
- Use struct when you want to store data
- Struct cannot have parameter less constructor

