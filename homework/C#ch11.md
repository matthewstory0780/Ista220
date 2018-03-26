C# chapter 11
--


1. How do you deﬁne a method that takes an arbitrary number of arguments?

--Using a params array, you can pass a variable number of arguments to a method. You indicate a params array by using the params keyword as an array parameter modifier when you define the method parameters. For example: public static int Example(params int[] paramList).


2. How do you call a method that takes an arbitrary number of argiments?

--The effect of the params keyword is that it allows you to call the method by using any number of integer arguments without worrying about creating an array. For example: int ex = Example(int1, int2);

3. Why can’t you use an array to pass an arbitrary number of arguments to a method?

--You can't use an array to pass an arbitrary number of arguments to a method because an array's size is fixed so it wouldn't be arbitrary.

4. How many parameters can a method have?

--Methods can only contain one params array, and it must be the last parameter.

5. Do parameter arguments have to have the same type?

--Parameter arguments must be the same type as the defined params array. However, if the params array is an object type, it will wrap value types (boxing) and allow you to use different types.

6. What is the diﬀerence between a method that takes a parameter argument and one that takes optional arguments?

--A method that takes optional parameters still has a fixed parameter list, and you cannot pass an arbitrary list of arguments. The compiler generates code that inserts the default values onto the stack for any missing arguments before the method runs, and the method is not aware of which of the arguments are provided by the caller and which are compiler-generated defaults. A method that uses a parameter array effectively has a completely arbitrary list of parameters, and none of them has a default value. Furthermore, the method can determine exactly how many arguments the caller provided.

7. How do you deﬁne a method that takes diﬀerent (and arbitrary) types of arguments?7. 

--To define a method that takes different and arbitrary types of arguments, you use the object type params array. For example: public static void Example(params object[] paramList)

