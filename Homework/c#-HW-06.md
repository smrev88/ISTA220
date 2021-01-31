
## cSharp HW CH 6
### Scott Revillar





1. What is an exception?
 Exceptions are used to indicate that an error has occurred while running the program.

2. What happens in a try block if the program executes without errors?
The program runs normally one after another.

3. How does the catch mechanism work for unhandled exceptions?
It throws the exception to the enclosing block and if none of the blocks can handle it,the program crashes.

If this occurs and the try block is part of a method, the method immediately exits and execution returns to the calling method. If the calling
method uses a try block, the runtime attempts to locate and execute a matching catch handler for this
try block. If the calling method does not use a try block or if there is no matching catch handler, the
calling method immediately exits, and execution returns to its caller, where the process is repeated. If
a matching catch handler is eventually found, the handler runs and execution continues with the fi rst statement that
 follows the catch handler in the catching method.

4. What happens in a program if an exception block fails to handle a particular error?
It is called an unhandled exception.  If runtime is unable to find a catch handler, the program will end.

5. What is the parent class for all exceptions? How does this work?
'exception' It is a hierachical structure with different families of exceptions.  

6. How do you determine the type of an error?
Debugger
Cache- property of the expression
exception.get type method


7. What is the purpose of integer checking?
Control overflow checking on integer expressions

8. What is the range of values than a signed Int32 type can contain? State the lowest value and the
highest value.
−2,147,483,648 to 2,147,483,647
int32.minvalue   int32.maxvalue

9. What is the range of values than an unsigned Int32 type can contain? State the lowest value and the
highest value. What is the difference between a signed integer and an unsigned integer? Can signed
integers and unsigned integers represent the same amount of numbers?
0 to 4,294,967,295

10. What does the finally block do?
It makes sure a statement will always run whether an exception has been thrown or not. It occurs rught after the try block or immediately after the
last catch handler

11. (Thought question) When would you not use a finally block in a try/catch construction?
When you don't want the program to keep running after an exception.
