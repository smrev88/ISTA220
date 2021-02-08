## cSharp HW CH 7
### Scott Revillar

1. What is the difference between deep copy and shallow copy?
Deep copy will clone fields that are reference types where shallow copy just copies the referemces
shallow copy just copies whats on the stack, deep copy copies everything from the stack and follow pointers
to the heap

2. What is the value of a reference after you declare and initialize it?
The value held is the address held in memory.

3. How do you declare a value type?
int i = 42;
giving it a type, name and optionally a value

4. How do you declare a reference type?
Circle c  = new Circle(42);
giving it a type, name, new,type,value

5. Does C# allow you to assign NULL to a value type?
to value types, no
to reference types yes, automatically contains null

6. Can you assign a nullable value type to a non-nullable variable of the same type? Why or why not?
No  you cannot assign nullable value type
	To a NON nullable variable

7. What is the difference between the stack and the heap?
When you call a method, the memory required for its parameters and its local variables is
always acquired from the stack

When you create an object (an instance of a class) by using the new keyword, the memory required to 
build the object is always acquired from the heap.
Objects created on the heap therefore have a
more indeterminate lifespan; an object is created by using the new keyword, but it disappears only 
sometime after the last reference to the object is removed.

8. What does it mean when we say that all classes are specialized types?
you can use System.Object to create a variable that can refer to any reference type.


9. What does ref do?
passes a reference
to the actual argument rather than a copy of the argument. When using a ref parameter, anything you
do to the parameter you also do to the original argument because the parameter and the argument
both reference the same data.

10. What does out do?
want the method itself to initialize the parameter. You can do this with the out keyword.
parameter becomes an alias for the argument

11. Describe boxing and unboxing in your own words.
automatic copying of an item from the stack to the heap is called boxing.



12. What does cast do?
This is an operation
that checks whether converting an item of one type to another is safe before actually making the copy