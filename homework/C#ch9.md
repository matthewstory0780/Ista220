Homework 09, ISTA-220
--
Chapter 09, C# Step by Step
--

Discussion Questions


1. Declare an enum for military ranks, either oﬃcer or enlisted. Name it Ranks. What are the 
symbols, like Private, PFD, Corporal, or 1stLt, 2ndLt, Capt?

enum Enlisted

{
  REC, PVT, PV2, PFC, SPC, CPL = SPC, SGT,
  SSG, SFC, MSG, FSG = MSG, SGM, CSM = SGM
}

2. Using the Ranks enum, assign a rank to yourself or a friend.

--Enlisted Story = Enlisted.SPC;

3. Determine the numeric index of particular ranks, using the Ranks enum.

--The following code Console.WriteLine((int)Matthew); returns the index integer of 8

4. How do you select the type of an enum?

--enum Enlisted : short { REC, ... CSM = SGM}


5. Are structs stored on the stack or on the heap? What about enums?

--Structs and enums are both value types and are thus stored on the stack.

6. Declare a struct named DOD with four branches.

struct DoD
{
  private string army, airforce, navy, coastguard;
}

7. Why can’t you create a default constructor for a struct?

--he reason you can’t declare your own default constructor for a structure is that the compiler always generates one.

8. What is CIL? What does the CLR do to the CIL?8. 
 
When you compile a C# application, the compiler converts your C# code into a set of instructions using a pseudo-machine code called the Common Intermediate Language (CIL). These are the instructions that are stored in an assembly. When you run a C# application, the CLR takes responsibility for converting the CIL instructions into real machine instructions that the processor on your computer can understand and execute.
