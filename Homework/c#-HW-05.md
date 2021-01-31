## cSharp HW CH 5
### Scott Revillar

1. What is a compound assignment operator? How does it work?
combines any arithmetic operator with the assignment operator

2. List all the compound assignment operators.
*=	/= %= += -=

3. List two ways to increment a numeric variable by 5. List two ways to decrement a numeric variable by
50.
count++, count +=, count--, count-=

4. How long does a while loop run?
until the Boolean expression is evaluated to false.

5. What is an iteratiion variable? (Not in book)
it is the variable that is changed each iteration of the loop

6. What happens if you don’t change the loop variable in the body of the while loop block?
the loop will not end

7. How many parts does a for loop statement have? Can you omit any of them? Can you omit all of
them? What happens if you omit all of them?
3
for(initialization;boolean expression; update control variable)
you can omit any of them but not all of them- it wouldnt run anything

8. How do you guarantee that a loop runs at least once?
make sure the initialization is evaluated to true at the start

9. What does the break statement do?
it is used to jump out of the body of an iteratiion statement, the loop exits immediately

10. What does the continue statement do?
causes the program to perform the next iteration of the loop immediately

11. (Thought question) Can you think of any reason why you would want to have an infinite loop? An
“infinite loop” is a loop without an update variable that in effect runs forever. As you will see, these
kinds of loops are written intentionally to perform various kinds of tasks.
a clock task