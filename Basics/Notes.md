

Signed and Unsigned Integral types:
![image](https://user-images.githubusercontent.com/77484700/232238800-ecd3e5e7-49f4-468a-9f86-0c179b96c162.png)

Floating point types:
![image](https://user-images.githubusercontent.com/77484700/232238839-9e37fadf-b18b-4544-bd0b-118a91bb13e1.png)

	
Decimal types:
![image](https://user-images.githubusercontent.com/77484700/232238832-66f0105d-1dae-4ffa-9868-70301b6af052.png)

	
Character types:
![image](https://user-images.githubusercontent.com/77484700/232238826-eac257a5-f80d-4cec-b407-7f12f8b51cf1.png)


Boolean types:

![image](https://user-images.githubusercontent.com/77484700/232238819-26944ac1-8881-415c-87ab-93e3206a24b1.png)

**Reference and Value types:**

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
- 
![image](https://user-images.githubusercontent.com/77484700/232238865-58bc8f74-fa11-4790-a4ab-0438369f12f8.png)

Address of the reference type is stored on stack.![image](https://user-images.githubusercontent.com/77484700/232238882-13ea8b95-e60f-4fd2-bfa9-cb5fc2c6c0a8.png)

**Enumerations**                                                                                   

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
-
![image](https://user-images.githubusercontent.com/77484700/232238895-5285c016-9c0f-4dbb-8fc0-3390a94c2bf2.png)


**Struct**
- Struct is used to encapsulate data and related functionality
- They do not support inheritance but they can implement interface
- struct can include constructors, constants, fields, methods, properties, indexers, operators, events & nested types.
- struct cannot include a parameter less constructor or a destructor.
- Structs and classes seem similar, but struct is value type and should be used only when you are sure that you would be performing some basic assignment/declaration
- Default modifier for struct is internal , for class it is public
- Use struct when you want to store data
- Struct cannot have parameter less constructor
- 
![image](https://user-images.githubusercontent.com/77484700/232238902-9a5d4c27-5ebf-41cd-b491-5b29ef5e03e2.png)

