- Interface is used to achieve multiple inheritance
- Interface define a "has a" relationship.
- An interfaces defines a contract. Any class that implements an interface has to fulfil that contract. This means that the class must implement methods defined in the interface.
- Interface methods do not have a body - the body is provided by the "implement" class
- Beginning with C# 8.0, an interface may define default implementations for some or all of its members. A class or struct that implements the interface doesn't have to implement members that have default implementations.
- To implement an interface member, the corresponding member of the implementing class must be public, non-static, and have the same name and signature as the interface member.
- Like you can convert a derived class to a base class, you can also convert the classes that is implementing interfaces to that interface
	
Interface vs Class
- Use interfaces when implementations of the same functionality will differ.
- Use abstract/base classes when you need to share a common concrete implementation.
	
Defaults:
- By default interfaces are public. 
- Interface keyword is used followed by the name starting with the letter capital I (IEnumerable)

Possible:
- Interfaces can contain properties and methods
- Inherit from another interface
- Static methods, which must have an implementation
- Static fields and constructors
- Abstract methods

Not possible:
- Interface cannot contain instance fields, instance constructors, auto-implemented properties
- Cannot be instantiated		

Usage:
- Use interfaces when implementations of the same functionality will differ.
- Provides abstraction behaviours

Some In-built interfaces:
- IEnumerable (and IEnumerable): for use with foreach and LINQ
- IDisposable: for resources requiring cleanup, used with using
- IQueryable: lets you execute requests against queriable data sources.
- INotifyPropertyChange : For data binding to UI classes in WPF, winforms and silverlight
- IComparable and IComparer: for generalized sorting
- IEquatable and IEqualityComparer: for generalized equality
- IList and ICollection: for mutable collections
- IDictionary: for lookup collections


