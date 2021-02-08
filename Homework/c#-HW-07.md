## cSharp HW CH 7
### Scott Revillar

1. What is a class? According to the book, what does a class “arrange?”
You store the data or variables that a class holds as fields
and use methods to implement the operations that a class can perform.

When you design a class, you systematically arrange
information and behavior into a meaningful entity. This arranging is an act of classifi cation and is
something that everyone does, not just programmers

2. What are the two purposes of encapsulation?
AKA information hiding
	1. To combine methods and data within a class; in other words, to support classification
	1. To control the accessibility of the methods and data; in other words, to control the use of
the class


3. How do you instantiate an instance of a class? How do you access that instance?
using the class keyword
-use the new keyword-instantiates the class
-new is the operator


4. What is the default access of the fields and methods of a class? How do you change the default?
private
by changing the class or fields to public 

5. What is the syntax for writing a constructor?
the default constructor is a constructor that does not take any parameters.
constructor does not have a return type and exactly same name as the class

class Circle
{
private int radius;
public Circle() // default constructor
{
radius = 0;
}


class Circle
{
private int radius;
public Circle() // default constructor
{
radius = 0;
}
public Circle(int initialRadius) // overloaded constructor
{
radius = initialRadius;
}
public double Area()
{
return Math.PI * radius * radius;
}

6. What is the difference between class fields and methods, and instance fields and methods? How do you
create class fields and methods?

Methods that belong to a class and that operate on the data belonging to a particular instance of
a class are called instance methods.

instance defined by class and get them through that method or class

class methods belong to all objects you create in that class
use  the static keyword
access it by the name of the class like console.writeline
class field- bathroom sink

instance methods belong only to the instance, not shared
your toothbrush-instance field


class field
Math.pi
class method
Math.Sqrt()

Duck donald = new Duck();
instance field
donald.sound = "quack";
instance method
donald.walk(); //produces a waddle





7. How do you bring a static class in scope? Why would you want to bring a static class in scope?

if you declare a method or a field
as static, you can call the method or access the fi eld by using the name of the class. No instance is
required

You can invoke the Sqrt method like this:
double d = Math.Sqrt(42.24);


DBonn dbc = new DBconn(); //database connection
string query = "select * from tanks";
var mytanks = dbc.runQuery(query);
var user = {"Name": "Charles","CardNo" : 124874828448}

8. Can you think of a good reason to create an anonymous class? What is it?
 when using query expressions.

myAnonymousObject = new { Name = "John ", Age = 47 };

9. What is polymorphism as this term is used in computer science? This is not in the book.
Polymorphism is often referred to as the third pillar of object-oriented programming, after encapsulation and 
inheritance. Polymorphism is a Greek word that means "many-shaped" and it has two distinct aspects:

At run time, objects of a derived class may be treated as objects of a base class in places such as method parameters a
nd collections or arrays. When this polymorphism occurs, the object's declared type is no longer identical to its
run-time type.
Base classes may define and implement virtual methods, and derived classes can override them, which means they provide 
their own definition and implementation. At run-time, when client code calls the method, the CLR looks up the run-time 
type of the object, and invokes that override of the virtual method. In your source code you can call a method on a base 
class, and cause a derived class's version of the method to be executed.



10. What is message passing as this term is used in computer science? This is not in the book.

With message passing, each object acts as an independent cell. The only thing an object can do to communicate
 with other objects is to send a message. In a mainstream OOP language like Java or C#, you'd have objects which 
 define their methods that you call to make changes within those objects.
 
 how OOP operate, caller tells the call method to do something and doesnt worry how the call method does it
 

11. What was the first object-oriented programming language?
Simula

12. Consider this quote by Alexander Stepanov:
I find OOP technically unsound. It attempts to decompose the world in terms of interfaces
that vary on a single type. To deal with the real problems you need multisorted algebras
— families of interfaces that span multiple types. I find OOP philosophically unsound. It
claims that everything is an object. Even if it is true it is not very interesting — saying that
everything is an object is saying nothing at all.
Who is Alexander Stephanov? What do you think about this quote?

He didn't like OOP. It is an interesting opinion considering most languages are OOP and help with organization.
