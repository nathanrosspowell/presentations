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
// C++ code.
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
While variables are data, functions are groups of command.
A function is a programming convention of grouping together and naming a set of commands, which you can then use multiple times.
 Here is a trivial function, that does something which you dont want to type multiple times.

```cpp
// C++ code.
int Money()
{
    int moneyInBank = 1000;
    int moneyInWallet = 50;
    int moneyInPockets = 5;
    return moneyInBank + moneyInWallet + moneyInPockets;
}
```
The 'Money' function can be used as many times as you like. In programmer talk we say that you 'call the function'

```cpp
// C++ code.
int myMoney = Money(); // Calling the Money function and using it's return value
```

A function can also calculate something for you.
```cpp
// C++ code.
int Addition(int x, int y)
{
    return x + y;
}
```
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
You can think of an pointer as an alias.
Just as James Bond has the alias of "007", a variables can have an alias.

```cpp
// C++ code.
int* megaTimeOfDay = &timeOfDay; // A pointer to time of day, with a cooler name
```
(The '*' means pointer, the '&' means 'get the memory address for' the variable. Don't worry about it.)

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
# Hexidecimal

Imagine a world where people have 16 fingers, this is how they 'count'

  0   1  2  3  4  5  6  7  8  9  A  B  C  D  E  F 
  10 11 12 13 14 15 16 17 18 19 1A 1B 1C 1D 1E 1F
  
|      | Decimal             | Hexidecimal         |
|------|---------------------|---------------------|
| 0001 | 1 * 1 = 1           | 1 * 1 = 1           |
| 0010 | 1* 10 = 10          | 1 * 16 = 16         |
| 0100 | 10* 10 = 100        | 16 * 16 = 256       |
| 1000 | 10 * 10 * 10 = 1000 | 16 * 16 * 16 = 4096 |
|      |                     |                     |

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
# Call Stack

The 'stack' of 'calls'...
---
.left-column[
  ### Medium
  ###-Hex
  ###-Call stack
  ###-Stack
]
.right-column[

# Stack 

Where nice ordered things live.
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
# Heap

Where random stuff lives
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
# Base 2 and Base 16

Another name for Binary and Hexidecimal.
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
# Float

A 'floating point number'. 
Maybe you know it as a number with a decimal point.
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
# Compiler

The program that turns you code into it's own program.
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
# Template

It can mean lots of things.
]

---
.left-column[
  ### Complex
  ###-Template
  ###-Handle
]
.right-column[
# Handle

A pointer with extra features.
]

---
.left-column[
  ### Complex
  ###-Template
  ###-Handle
  ###-Interface
]
.right-column[
# Interface

Like a user interface.
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
# Buffer Overflow

Bad things
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
# Memory Corruption

When something edited the wrong memory.
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
# Access Violation
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
# Segmentation Fault

Trying to use a null pointer.
]


---
class: center, middle
# Questions?

---
class: center, middle
# End

Got back to the [presentations](http://nathanrosspowell.com/presentations/) home page.
