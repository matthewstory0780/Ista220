Homework 07, ISTA-220
Chapter 07, C# Step by Step
--
Matthew Story
--
Homework
--

Read chapter 7, pages 153 – 174 in the C# Step by Step book.
1.2 Discussion Questions
Answer the discussion questions in writing.


1. What is a class? According to the book, what does a class “arrange?”

--A class is a way to store and arrange information.

2. What are the two purposes of encapsulation?
 

--To combine methods and data within a class; 
To control the accessibility of the methods and data.

3. How do you instantiate an instance of a class? How do you access that instance?

--To instantiate an instance of a class, you create a variable specifying the class as its type, and then you initialize the variable with some valid data. You access the instance by calling the variable it is assigned to.

4. What is the default access of the ﬁelds and methods of a class? How do you change the default?

--By default, the fields and methods of a class are private and inaccessible to code outside the class, but you can use the public keyword to expose fields and methods to the outside world.

5. What is the syntax for writing a constructor?

--The syntax for writing a constructor is a public method that does not return a value (not even void) and has the same name as the class. 

6. What is the diﬀerence between class ﬁelds and methods, and instance ﬁelds ad methods? How do you create class ﬁelds and methods?

--Class fields and methods provide a useful function that is independent of any specific class instance. If you declare a method or a field as static, you can call the method or access the field by using the name of the class.

7. How do you bring a static class in scope? Why would you want to bring a static class in scope?

--Static using statements enable you to bring a class into scope and omit the class name when accessing static members. This could be helpful if static methods from a specific class are called often throughout the code.


8. Can you think of a good reason to create an anonymous class? What is it?

--You can use anonymous classes to query expressions.

9. What is polymorphism as this term is used in computer science? This is not in the book.

--A feature of a programming language that allows routines to use variables of different types at different times.

10. What is message passing as this term is used in computer science? This is not in the book.
 
--In computer science, message passing sends a message to a process (which may be an actor or object) and relies on the process and the supporting infrastructure to select and invoke the actual code to run. Message passing differs from conventional programming where a process, subroutine, or function is directly invoked by name.

11. What was the ﬁrst object-oriented programming language?

--Simula 67

12. Consider this quote by Alexander Stepanov:
I ﬁnd OOP technically unsound. It attempts to decompose the world in terms of interfaces that vary on a single type. To deal with the real problems you need multisorted algebras — families of interfaces that span multiple types. I ﬁnd OOP philosophically unsound. It claims that everything is an object. Even if it is true it is not very interesting — saying that everything is an object is saying nothing at all.
Who is Alexander Stephanov? What do you think about this quote?


--Alexander Stephanov designed C++ Standard Template Library. I agree that real world problems typically are too complex to simply classify into basic objects.