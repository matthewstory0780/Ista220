Homework 10, ISTA-220
--
Chapter 10, C# Step by Step
--


1. What does an array look like in memory?

--Arrays are reference types, regardless of the type of their elements. On the stack, they look like a memory address to the location in the heap that contains the array. An array on the heap is a contiguous block of memory.

2. Where is memory allocated to hold an array, on the stack or on the heap?

--The contents of the array are stored on the heap.

3. Where is memory allocated to hold an array reference, on the stack or on the heap?

--The array reference is stored on the stack.

4. Can an array hoold values of diﬀerent types? This is a trick question, the answer is, “It depends.”

--The foreach statement accepts two arguments. The first argument declares an iteration variable that automatically acquires the value of each element in the array. The type of this variable must match the type of the elements in the array. The other argument provided is the variable name of the array. For example, foreach (double d in myarray){//do stuff} would iterate through each double in myarray referencing each double as d in the code block.

5. Describe the syntax of the condition or a foreach loop.

--The foreach statement accepts two arguments. The first argument declares an iteration variable that automatically acquires the value of each element in the array. The type of this variable must match the type of the elements in the array. The other argument provided is the variable name of the array. For example, foreach (double d in myarray){//do stuff} would iterate through each double in myarray referencing each double as d in the code block.

6. How do you make a deep copy of a array?

--If you want to make a copy of the array instance (the data on the heap) that an array variable refers to, you have to do two things. First, you create a new array instance of the same type and the same length as the array you are copying. Second, you copy the data from the original array, element by element to the new array. You can do this by either iterating through the arrays and copying each element, or by using the Array methods Copy(), CopyTo() or Clone().

7. What is the diﬀerence between a multi-dimensional array and an array of arrays?

--An array of arrays, instead of being a two-dimensional array, has only a single dimension, but the elements in that dimension are themselves arrays. Ordinary multidimensional arrays are sometimes referred to as rectangular arrays. Each dimension has a regular shape.

8. How do you “ﬂatten” a multidimensional array? In other words, take something that looks like a matrix  1 2 3 4 5 6 7 8 9 and turn it into an array [1,2,3,4,5,6,7,8,9]?


--To flatten a multidimensional array, you can use the ToArray() extension of the Cast<int>() array method. For example, given a multidimentional array named mdarray, int[] flattened = mdarray.Cast<int>().ToArray(); would assign the values in mdarray to the flattened array. You could also use foreach to iterate through the multi-dimensional array and assign each element to a one-dimensional array.