
# C# HW CH 3
 ## By Scott Revillar
 ## 1/20/21
 
 



### 1. What is a method?
Named sequence of statements. has a name and a body. it should have a name with a meaningful identifier.
*named block of code that optionally accepts input and returns output*


### 2. (Not in book) What is the difference between a function and a procedure/subprocedure/subroutine?
Functions will be used for computing a value usually.
Stored procedures may or not return values.
a method that does not return a value (a procedure or subroutine). 
Function- name block of code that returns a value
Subprocedure-takes an action like print


### 3. What does a return statement do?
if you want a method to return information (that is, its return type is not void), you must include a return statement at 
the end of the processing in the method body. A return statement consists of the keyword return followed by an expression 
that specifies the returned value and a semicolon. The type of the expression must be the same as the type specified by the 
method declaration. Function has a return value but subprocedure optionally could have return

### 4. What is an expression bodied method?
simple method performing a single task or returning results without involving additional logic.
int addValues(int leftHandSide, int rightHandSide) => leftHandSide + rightHandSide;

### 5. What is the scope of a variable?
simply the region of the program in which that variable is usable. Scope applies to methods as well as variables. 
The scope of an identifier (of a variable or method) is linked to the location of the declaration that introduces the identifier
in the program

### 6. What is a field?
variable defined by a class
Any variables you declare within the body of a class (but not within a method) are scoped to that class
you can use fields to share information between methods

### 7. What is an overloaded method?
two identifiers have the same name and are declared in the same scope, they are said to be overloaded
 You can overload a method when the different implementations have different sets of parameters; that is, when they have the same name but a 
 different number of parameters or when the types of the parameters differ. When you call a method, you supply a comma-separated list of arguments, and the 
 number and type of the arguments are used by the compiler to select one of the overloaded methods. However, keep in mind that although you can overload the 
 parameters of a method, you can’t overload the return type of a method. In other words, you can’t declare two methods with the same name that differ only in 
 their return type. (The compiler is clever, but not that clever.)
 -multiple instances of the same method. more than one method with the same name. tell the difference by the different parameter lists for each

### 8. How do you call a method that requires arguments?
addValues(39, 3); // okay
use a method with parentheses with a parameter list 
if method requires arguments, you place them in the parameter list

### 9. How do you write a method, that is, specify the method definition, that requires a parameter list?
private int addValues(int leftHandSide, int rightHandSide)
1."return type" specify the type of method, int, string etc
2. put the parameters in the perentheses/parameter list
3. name the method
4. body of the method

### 10. How do you specify a parameter as optional when defining a method?
You specify that a parameter is optional when you *define a method by providing a default value for the parameter.* You indicate a 
default value by using the assignment operator. In the optMethod method shown next, the first parameter is mandatory because it does not 
specify a default value, but the second and third parameters are optional:
You must specify all mandatory parameters before any optional parameters.

### 11. How do you pass a argument to a method as a named parameter?
optMethod(first : 99, second : 123.45, third : "World");
you can also specify parameters by name. This feature lets you pass the arguments in a different sequence. To pass an 
argument as a named parameter, you specify the name of the parameter, followed by a colon and the value to use
-positional means that the order of the arguments is correlated to the order of the parameters, first parameter gets argument 1
second parameter gets arg 2 and third param gets arg 3, fourth param gets arg 4 etc etc when you want to change the order, you use 
named parameters

### 12. How do you return values from a method? Can you return multiple values from a method, and if so,how?
return followed by an expression that specifies the returned value and a semicolon.
specify mult values when using the method
~~
(int, int)returnMultipleValues(...)

{    
	int val1;    
	int val2;     
		// Calculate values for val1 and val2    
	return(val1, val2);
}
### 13. What is a tuple? How do you define a method that returns multiple values? Give an example of a
### method that returns multiple values other than the example in the book.
A tuple is simply a small collection of values (strictly speaking, a tuple contains two values, but C# tuples can comprise bigger sets 
than this). You indicate that a method returns a tuple by specifying a list of types as part of the method definition; one type 
for each value returned. see above example

### 14. Examine the method definition on page 83 of the book. Desk check the execution of this method.
### What do you discover? This is called recursion. 

keeps going until it hits 1 and multiplies them all 
~~~
long factorial ( int dataValue )
{
	if ( dataValue == 1)
		return 1;
	else
		return dataValue * factorial( dataValue - 1);
}
~~~
keeps going and going?

### 15. How does the compiler resolve an ambiguity between named arguments and optional parameters?
The compiler can distinguish between the methods because they have different parameter lists. 
is the version that most closely matches the method call, so the code invokes the method that takes three parameters 
and not the version that takes four

### 16. The book states: \A key feature of C# and other languages designed for the .NET Framework is the
ability to interoperate with applications and components written with other technologies." What is
the COM and how is the CLR dependent on the COM?
Component Object Model 

COM does not support overloaded methods; instead, it uses methods that can take optional parameters. To make 
it easier to incorporate COM libraries and components into a C# solution, C# also supports optional parameters