Homework 05, ISTA-220
Chapter 05, C# Step by Step
--Matthew Story 
4 March 2018


1.2 Discussion Questions

1. What is a compound assignment operator? How does it work?

Compound assignment operators are a combination of an arithmetic and assignment operators.
It is basically a shorthand way to perform arithmetic where the result is stored in one of the operands. 
For example, instead of a = a + b; you write a += b;. It works with all the arithmetic operators and in 
all cases the arithmetic operator precedes the assignment operator.


2. List all the compound assignment operators.

The compound assignment operators are +=, -=, *=, /=, and %=.


3. List two ways to increment a numeric variable by 5. List two ways to decrement a numeric variable by 50.

Two ways to increment a numeric variable by 5 are, var = var + 5; and var += 5;. 
Two ways to decrement a numeric variable by 50 are, var = var – 50; and var -= 50;.


4. How long does a while loop run?

A while loop will run as long as the given condition is true.


5. What happens if you don’t change the loop variable in the body of the while loop block?

If you don’t change the loop variable in the body of a while loop block you will end up with an infinite loop.


6. How many parts does a for loop statement have? Can you omit any of them? Can you omit all of them? What happens if you omit all of them?

The for loop statement has three parts: initialization, Boolean statement, and code that updates the control variable. You can omit any or all
of the parts. If you omit the Boolean statement, it defaults to true and creates an infinite loop. If you omit the initialization and update parts, 
it acts like a while loop. If you omit all three, you create an infinite loop.

7. How do you guarantee that a loop runs at least once?

To guarantee that a loop runs at least once, use a do-while loop.



8. What does the break statement do?

The break statement exits the loop immediately and execution continues at the first statement that follows the loop.


9. What does the continue statement do?

The continue statement causes the program to perform the next iteration of the loop immediately (after re-evaluating the Boolean expression). 
Basically, it skips the rest of the code in the loop (for that iteration).
