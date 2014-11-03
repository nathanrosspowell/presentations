class: center, middle
# Programmer Talk

By Nathan Ross Powell


???

These are where the slide notes go.

---
# Intro

This will be more like a giant cheat sheet than a structured lesson.
This should get some people up to speed on the words that programmers use, but maybe not everyone understands them.

Remember, sometime it is hard to know what kind of technical knowledge other people have when you work with lots of different people on a daily basis.

The peered



---
class: center, middle
# Easy

The set of upcoming words are relatively easy to understand.
If you have never heard of them before do _not_ worry!
They are easy to comprehend.

---
.left-column[
  ### Easy
]
.right-column[
* Memory
* Variable
* Function
* Pointer
* Struct
* Class
* Binary
]

---
.left-column[
  ### Easy
  ###-Memory
]
.right-column[
This is RAM (Random Access Memory).
Your computer probably has a lot of it!

A computers memory is where currently executing programs live.
Whereas the hard drive is where _all_ computer programs (`.exe` files) live.
]

---
.left-column[
  ### Easy
  ###-Memory
  ###-Variable
]
.right-column[
The basic building block of any computer program.
It is a named 'block' of something.

Here we have named 'integers' AKA, whole numbers.
```cpp
int variable = 1;
int VARIABLE = 1 + 1;
int _var = 3;
int MY_VAR = 4;
int myVariableName = 5;
int and_so_on = 5 + 1;
int timeOfDay = 7;
```
A variable is the name for a piece of data, which is understandable to humans!

A variable name is a label on a piece of data.
]

---
.left-column[
  ### Easy
  ###-Memory
  ###-Variable
  ###-Function
]
.right-column[
A function is a programming term for "manipulate this data like this".
A function that runs once every second could update the data which stores the time of day:

```cpp
void UpdateFunction()
{
    timeOfDay.Add( 1 );
}
```

Here we see the full definition of the a function named 'UpdateFunction'.
We can also see a function called 'Add', but that function is being used (or being 'called').
The definition of the function 'Add' is somewhere else in the program.
]

---
.left-column[
  ### Easy
  ###-Memory
  ###-Variable
  ###-Function
  ###-Pointer
]
.right-column[
In day to day terms a 'pointer' is an 'alias'.

Just like "007" is an alias for James Bond, we can have an alias for a variable in a programming language.
The alias is another name for the real deal, it is not clone of the information.
Here is a C++ pointer which makes an alias for "timeOfDay"

```cpp
int* pointer = &timeOfDay;
```

The '*' means pointer.
The '&' means 'get the memory address for' the variable.

Variables are a name we give data.
The variable and any pointers to it will resolve to be the same piece of data in memory.

]

---
.left-column[
  ### Easy
  ###-Memory
  ###-Variable
  ###-Function
  ###-Pointer
  ###-Struct 
]
.right-column[
struct => structure

A structure is a set of variables.

```cpp
struct Time 
{
    int hours;
    int minutes;
    int seconds;
};
```
You can then make a variable which is an 'instance' of your structure.

```cpp
Time timeOfDay;
```

(That form of code is allowed, but it is not great. You will learn why later)
]

---
.left-column[
  ### Easy
  ###-Memory
  ###-Variable
  ###-Function
  ###-Pointer
  ###-Struct
  ###-Class
]
.right-column[
A class is the same a 'struct' but with more rules.

A class restricts access to the variables it contains.

```cpp
class TimeOfDay
{
public:
    int hours;
protected;
    int minutes;
private:
    int seconds;
};
```
This is a contrived example, but it has the most accessible ('public') variable at the top and the lower you go the harder it is to access the variable.
]

---
.left-column[
  ### Easy
  ###-Memory
  ###-Variable
  ###-Function
  ###-Pointer
  ###-Struct
  ###-Class
  ###-Binary
]
.right-column[
Binary is the classic computer 'language' of 1's and 0's!
```cpp
0001        =    1
0010        =    2
0011        =    3
0100        =    4
1    +    4 =    5
0001 + 0100 = 0101
```

This is called 'base 2'.
Instead of counting to '10' before using another digit to represent the number, you only count to '2'.

You will rarely code directly in binary numbers.
]

---
class: center, middle
# Medium 

Stuff

---
.left-column[
  ### Medium
]
.right-column[
* Hex
* Call stack
* Stack
* Heap
* Base 2 and base 16
* Float
* Compiler
* Memory
]

---
.left-column[
  ### Medium
  ###-Hex
]
.right-column[
* Call stack
* Stack
* Heap
* Base 2/16
* Float
* Compiler
* Memory
]

---
.left-column[
  ### Medium
  ###-Hex
  ###-Call stack
]
.right-column[
* Stack
* Heap
* Base 2/16
* Float
* Compiler
* Memory
]

---
.left-column[
  ### Medium
  ###-Hex
  ###-Call stack
  ###-Stack
]
.right-column[
* Heap
* Base 2/16
* Float
* Compiler
* Memory
]

---
.left-column[
  ### Medium
  ###-Hex
  ###-Call stack
  ###-Stack
  ###-Heap
]
.right-column[
* Base 2/16
* Float
* Compiler
* Memory
]

---
.left-column[
  ### Medium
  ###-Hex
  ###-Call stack
  ###-Stack
  ###-Heap
  ###-Base 2/16
]
.right-column[
* Float
* Compiler
]

---
.left-column[
  ### Medium
  ###-Hex
  ###-Call stack
  ###-Stack
  ###-Heap
  ###-Base 2/16
  ###-Float
]
.right-column[
* Compiler
]

---
.left-column[
  ### Medium
  ###-Hex
  ###-Call stack
  ###-Stack
  ###-Heap
  ###-Base 2/16
  ###-Float
  ###-Compiler
]
.right-column[
]
---
class: center, middle
# Complex

stuff

---
.left-column[
  ### Complex
]
.right-column[
* Template
* Handle
* Interface
* Stack Overflow
* Memory Corruption
* Memory Violation
* Segfault / segmentation fault
]

---
.left-column[
  ### Complex
  ###-Template
]
.right-column[
* Handle
* Interface
* Overflow
* Corruption
* Violation
* Segfault
]

---
.left-column[
  ### Complex
  ###-Template
  ###-Handle
]
.right-column[
* Interface
* Overflow
* Corruption
* Violation
* Segfault
]

---
.left-column[
  ### Complex
  ###-Template
  ###-Handle
  ###-Interface
]
.right-column[
* Overflow
* Corruption
* Violation
* Segfault
]

---
.left-column[
  ### Complex
  ###-Template
  ###-Handle
  ###-Interface
  ###-Overflow
]
.right-column[
* Corruption
* Violation
* Segfault
]

---
.left-column[
  ### Complex
  ###-Template
  ###-Handle
  ###-Interface
  ###-Overflow
  ###-Corrupt
]
.right-column[
* Violation
* Segfault
]

---
.left-column[
  ### Complex
  ###-Template
  ###-Handle
  ###-Interface
  ###-Overflow
  ###-Corrupt
  ###-Violation
]
.right-column[
* Segfault
]

---
.left-column[
  ### Complex
  ###-Template
  ###-Handle
  ###-Interface
  ###-Overflow
  ###-Corrupt
  ###-Violation
  ###-Segfault
]
.right-column[
]

---
class: center, middle
# Questions?

---
class: center, middle
# End

Got back to the [presentations](http://nathanrosspowell.com/presentations/) home page.
