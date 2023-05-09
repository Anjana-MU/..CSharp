- Use the static modifier to declare a static member, which belongs to the type itself rather than to a specific object.
- Accessed with the name of the class 
- Static member has only one copy of the member
- Static classes are useful and provide an easy way to access their members that do not need to work differently for different objects. 
	For eg: Database connection details
- static class should be container for sets of methods that just operate on input parameters and do not have to get or set any internal instance fields.
- In simpler words they are global values
- Use static classes for utility classes(System.Math) where no further modification would be required.
	
Static class:
- A static class can only have static members
- You cannot use 'this'  keyword to access static members
- Cannot be instantiated
- Is sealed
	
Static Fields
- Static local variable are not supported in c#(i.e variables declared inside a method). Because the static field can be used to achieve the same(also some design fault).
- Static fields can be declared as readonly and they would act as constant

Static Constructor
- Does not take any parameters
- It can’t be called directly.
- When it is executing, then the user has no control.
- It does not take access modifiers or any parameters.	

Static Method
- Can access static and non-static variables
- Static methods can be overloaded but cannot be overridden.

Static vs Instance
- If object under the consideration can exists only once in entire application then it would come under "static"
- If a method does not use any field variable inside it then it can be static method.
- If your class has no state and is just a series of related methods that, when given an input, will give you an output then you have an excellent candidate for a static class. (state here refers to changed behaviour) 

Possible:
- In classes, interfaces, and structs, you may add the static modifier to fields, methods, properties, operators, events, and constructors.
- Overload

Not possible:
- Local method variables
- Override as classes are sealed

Usage:
Static class:
Used when the implementation is same across all objects. 
**A static class can be used as a convenient container for sets of methods that just operate on input parameters and do not have to get or set 
any internal instance fields.**


Static method:
When there is no state to maintain(is same for distinct object calls), helper methods.
Main methos is static as its entry point to program and runs without creating an instance of class

Local static variables:
Are not supported because it was not included in the design and the same can be achieved with the static field

	
https://stackoverflow.com/questions/241339/when-to-use-static-classes-in-c-sharp
