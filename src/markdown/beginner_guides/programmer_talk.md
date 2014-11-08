class: center, middle
# Programmer Talk

By Nathan Ross Powell


???

These are where the slide notes go.

---
# Intro

The information here should get some people up to speed on the words that programmers use all the time.

These slides will be more like a giant cheat sheet than a structured lesson.

It's good to have a general idea of what these words and concepts mean, but don't stress about remembering all of it.

---
class: center, middle
# Easy

The set of upcoming words are relatively easy to explain in a short sentence.
If you have never heard of them before do _not_ worry!

You are not going to become an expert, but you will be a bit more up to speed.

---
.left-column[
  ### Easy
]
.right-column[
# Easy Topics
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
# Memory

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
# Variable/Variables

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
# Functions
While variables are data, functions are groups of command.
A function is a programming convention of grouping together and naming a set of commands, which you can then use multiple times.
 Here is a trivial function, that does something which you dont want to type multiple times.

```cpp
int Money()
{
    int moneyInBank = 1000;
    int moneyInWallet = 50;
    int moneyInPockets = 5;
    return moneyInBank + moneyInWallet + moneyInPockets;
}
```
The 'Money' function can be used as many times as you like. In programmer talk we say that you 'call the function'.

```cpp
int myMoney = Money(); // Calling 'Money' and storing it's return value
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
# Pointers

You can think of an pointer as an alias.

Just as James Bond has the alias of "007", a variable can have an alias.

In a spreadsheet you can make a cell get it's value from another cell.
You make the first cell 'point' to a second one.

```cpp
int* megaTimeOfDay = &timeOfDay; // An int pointer
```
When you use `megaTimeOfDay` like an `int` it will  give you the current value of `timeOfDay`, even if someone changes that value.

_(The '*' means pointer, the '&' means 'get the memory address for' the variable. Don't worry about it.)_


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
# Structures

`struct => structure`

A structure is a collection of variables which define something bigger.

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

_(That form of code is allowed, but it is not great. You will learn why later)_
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
# Class

A class is the same a 'struct' but with more rules.

A class restricts access to the variables it contains.

```cpp
class Time
{
public:
    int hours;
protected;
    int minutes;
private:
    int seconds;
};
```
`public` variables can be accessed anywhere. `protected` and `private` are more restrive.
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
# Binary

Binary is the classic computer 'language' of 1's and 0's!

```cpp
0001 = 1
0010 = 2
0011 = 3
0100 = 4
0101 = 5
0001 + 0100 = 0101
```

This is called 'base 2'.
Instead of counting to 10 before using another digit to represent the number, you only count to 2.

You will rarely use binary numbers directly in code.
]

---
class: center, middle
# More Technical Terms

Now we move into trickier territory.
These terms are a step above the foundations of programming in the previous section.

---
.left-column[
  ### Medium
]
.right-column[
# More Technical Terms
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
# Call Stack

The 'stack' of 'calls'...
]
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
The 

    Base  2 -> 0010 =  2  - 0, 1
    Base 10 -> 0010 = 10  - 0, 1, ... 8, 9
    Base 16 -> 0010 = 16  - 0, 1, ... E, F
    Base 99 -> 0010 = 99  - 0, 1, ... '98', '99'
    
Here you can see that any base can be used.
It is very inconvinent that we can't express '10' in one numerical digit, that is why Hexidecimal uses 'A'.

_(I don't know of any use for Base 99)_
    
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

```cpp
float speedModifier = 1.5f;
```

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

* MSVC
* GCC
* Clang

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