Interfaces:
- Interfaces can contain properties and methods, but not fields.
- Like abstract classes, interfaces cannot be used to create objects
- Interface methods do not have a body - the body is provided by the "implement" class
- An interface cannot contain a constructor (as it cannot be used to create objects)

Explicit Interface implementation
- If a class is implementing two interfaces and both have same method name and signature, to call a different implementation depending on which interface is in use,
 you can implement an interface member explicitly. An explicit interface implementation is a class member that is only called through the specified interface. 
 Name the class member by prefixing it with the name of the interface and a period in the derived class.


Difference between Interface and Abstract class:
	1. The default modifier for interface is public, for abstract it is private
	2. Interface cannot have any other modifier other than public
![image](https://user-images.githubusercontent.com/77484700/236635371-5315e6d5-ab5c-47be-9f97-7e52c7c6c97b.png)
