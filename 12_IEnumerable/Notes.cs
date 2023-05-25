IEnumerable is for non-generic types
	- IEnumerable is an interface
	- Exposes an enumerator, which supports a simple iteration over a non-generic collection.
	
	- Method: GetEnumerator()
	Returns: IEnemurator
		
	- IEnemuratorMethods: 
	MoveNext(): 
		Sets the enumerator to the next element of the collection; it Returns true if the enumerator was successfully set to the next element and false if the enumerator has reached the end of the collection. 
	Reset():
		Sets the enumerator to its initial position, which is before the first element in the collection. 
	- IEnemuratorProperty
		Current:
		Current which returns the current element in the collection.
		
			
	Usage:
	- IEnumerable can be used on custom non-generic classes so that the class objects sub-items can be enumerated(looped over a foreach loop)


The key difference between Generic and Non-generic Collection in C# is that a Generic Collection is strongly typed while a Non-Generic Collection(ArrayList, Stack, Queue) is not strongly typed
https://stackoverflow.com/questions/558304/can-anyone-explain-ienumerable-and-ienumerator-to-me 
		
		
		
		
IEnemurable<T> is for generic types
	- IEnemurable<T> inherits from IEnumerable 


