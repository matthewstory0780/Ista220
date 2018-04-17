CH 18 C#
--
1. You are building a help ticket system. You want to ensure that the older the ticket, the sooner it will be handled by the team. For example, a ticket submitted a week ago has a higher priority than a ticked just submitted. What kind of data structure would you use, and why?

--I would use a Queue because it is a First In, First Out (FIFO) data structure.

2. You are building a tracking system for seasonal agricultural farm labor. Te labor requirements vary widely, depending on the season. Your requirement is that the newest hires are terminated ﬁrst, and that our more experienced hires are kept longer. What kind of data structure would you use, and why?

--I would use a Stack because it is a First In, Last Out (FILO) data structure.


3. You are building a transaction database. Your requirement is that the database adds data very quickly, and that deletions, updates, and searches happen infrequently. In other words, data is typically added in the order in which the transaction occurs. What kind of data structure would you use, and why?

--I would use a List because it offers the basic functionality described.

4. You are building an analytical database. YOur requirement is that the database handle queries very quickly, but that the data never changes, i.e., there are no inserts, deletions, or updates. What kind of data structure would you use, and why?

--I would use a Dictionary because the searches using keywords would go directly to the value for that key.

5. You are building a personnel directory, where searched are performed by last name, ﬁrst name, middle name. What kind of data structure would you use, and why?

--I would use a HashSet is because it is optimized for fast retrieval of data and provides set-oriented methods for determining whether the items it holds are a subset of another HashSet object.

6. You are building a username/password database. Your requirement is that updates happen frequently (when users change their passwords) and that searches (to authenticate users) happenb extremely quickly. What kind of data structure would you use, and why?

--I would use a Dictionary because it offers fast searching and prevents duplicate usernames (keys).

7. What is a lambda expression? Give an example. Why would we use a lambda expression?

--A lambda expression is an expression that returns a method. For example, Person match = personnel.Find(p => p.ID == 3);. We would use a lambda expression when we want to add functionality without writing a new method.

8. What is the diﬀerence between lambda expressions and anonymous methods? What are the advantages of each?8. 


--Anonymous methods were added primarily so that you can define delegates without having to create a named method—you simply provide the definition of the method body in place of the method name. Whenever you introduce an anonymous method, you must prefix it with the delegate keyword. Also, any parameters needed are specified in parentheses following the delegate keyword. Lambda expressions provide a more succinct and natural syntax than anonymous methods, and they pervade many of the more advanced aspects of C#.

