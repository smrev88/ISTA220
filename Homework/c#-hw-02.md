# Homework Ch 2

1. A local variable is a variable that exist only in a method or another small section of code.

1. (2)A statement is a command that performs an action, such as calculating a value and storing 
the result or displaying a message to a user. You combine statements to create methods.

1. (3)Identifiers are the names you use to ID the elements in your programs, such as namespaces, classes, methods,
and variables. can only use letters, digits and underscores, must start with a letter or underscore

1. (4) Keywords are identifiers that C# reserves, there are 77, each one has a particular meaning. 
Like class, namespace, using, break, bool

1. (5) A variable is a storage location that holds a value. Like a box in the computer's memory that holds temp 
information. You use a variable to refer to the value it holds.

1. (6) a.  You declare the type and name of a variable in a declaration statement/ int age;
       b.   age = 42; 
	   c. yes
	   d. yes

1. (7) VS will create a new solution file for it. This can be confusing if you are not aware of this feature because
it can result in you accidentally generating multiple solutions for the same project

1. (8) Arithmetic operators let you set a variable to an math equation like 2+2. + is the operator and 2 is 
the operand. Can only use arithmetic operators for certain variable types 

1. (9) ToString () method
using System;
class MyApplication {
   static void Main(string[] args) {
      String s;
      int num = 299;
      s = num.ToString();
      Console.WriteLine("String = "+s);
      Console.ReadLine();
   }

1. (10)int.Parse method.... Int32.Parse that you can use to convert a string value to an integer if you need to perform arithmetic 
computations on values held as strings.

1. (11) Precedence governs the order in which an expression's operators are evaluated
		Associativity is the direction (left or right) in which the operands of an operator are evaluated.
		
		using the = operator for multiple variables
		myInt5 = myInt4 = myInt3 = myInt2 = myInt = 10;
1. (12) You must assign a value to a variable before you can use it.

1. (13) Prefix increments before returning a value while postfix returns the value before incrementing

1. (14) Where you dont need to use + to concantenate strings. You use a $ instead, its more efficient
$"Hello {username.txt}" instead of "Hello " + username.txt
you can direct the computer to evaluate an expression in a string, you can include multiple variables and operators

1. (15) causes the compiler to deduce the type of the variables rom the types of the expressions used to initialize them
let computer decide what type of variable it is
implicit typing instead of explicit typing
