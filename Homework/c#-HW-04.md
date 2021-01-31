
# C# HW CH 4
 ## By Scott Revillar
 ## 1/21/21
 
 
1. What are all possible values of Boolean expression?
 true or false
 
2. List the equality operators. List the relational operators. List the logical operators. How are they the
same? How are they different?
== equality
!= inequality

relational: <,>,<=,>=

logical: NOT, &&(and), ||(or),


3. What is the general concept of short circuiting? This question has a short and simple answer and you
do not need to have a detailed response. 
the whole expression can be evaluated to true or false without evaluating all sub expressions.



4. What are the difference in how short circuiting works for && and ||?
&& both operands have to be true or false
|| one or the other is true or false

5. Look at the list of operators. What operator has the highest precedence? Which has the lowest?
() highest
= assignment

6. In an if or else construction using multiple lines of code, what effect does the use of curly braces have?
compiler reads the blocks of code separately otherwise it would just read the first if no matter what . else 
statement will report a syntax error because its not recognized as part of the if statement

7. In a switch statement, what happens if you omit break?
The compiler will continue running the next code blocks instead of return the next--- falls through, it stops

When the break statement is encountered inside a loop, the loop is immediately terminated and program control resumes 
at the next statement following the loop. It can be used to terminate a case in the switch statement.

8. The four keywords in a switch statement are switch, case, break, and default. Explain what each
keyword does.

switch makes it more efficient to use multiple if, else if statements
break-finished the statement and continues to the first statement that follows the closing brace of statement
default- if none of the statements before that are valid, default can run, if given variable doesnt match
case- label to compare the expressions


9. Look at the source listing below. It contains two methods: recurr1() and recurr2(). There is a
significant difference between the two methods. What is it?

the first method takes one paramenter while the second takes two paramenters, they give you the same value
recurr2 is tail recursion
every time you call a method, the computer makes a stack in memory 


10. (Not in book) What is a recursive method? Using a language you know (such as English), write a
recursive method that adds up the integers in a list of integers. The input to the method is a list of
integers and the output is a scalar value representing a sum.

-method keeps going until it reaches a value that stops the loop


11. (Not in book) Read a short summary of De Morgan’s laws.
(a) Explain how this statement, ”It’s not snowing or raining,” is the same as this statement, ”It’s not
snowing and it’s not raining.”
Both are false

(b) Explain how this statement, ”I’m not running and walking,” is the same as this statement, ”I’m
not running or I’m not walking.

Theyre both the same statement