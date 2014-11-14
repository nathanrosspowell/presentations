class: center, middle
# Programmer Talk

By Nathan Ross Powell

Source: [programmer_talk.md](https://github.com/nathanrosspowell/presentations/blob/master/src/markdown/beginner_guides/programmer_talk.md)
Webpage: [programmer_talk/index.html](http://nathanrosspowell.com/presentations/beginner_guides/programmer_talk/index.html)
???

These are where the slide notes go.

---
# Intro

The information here should get everyone up to speed on the words that programmers use all the time.

These slides will be more like a giant cheat sheet than a structured lesson.

It's good to have a general idea of what these words and concepts mean, but don't stress about remembering all of it.

---
class: center, middle
# Easy Topics

The set of upcoming words are relatively easy to explain in a few short sentences.
If you have never heard of them before do _not_ worry!

You are not going to become an expert in one hour but you will have some kind of basic understanding (hopefully)!

???
Notes: ... 
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

???
Notes: ... 
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

???
ttp://en.wikipedia.org/wiki/Computer_memory
---
.left-column[
  ### Easy
  ###-Memory
  ###-Variable
]
.right-column[
# Variable/Variables

The basic building block of any computer program.
It is a named container of 'something'.

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
Giving variables a good name is a daily struggle for programmers.
]

???
http://en.wikipedia.org/wiki/Variable_(computer_science)

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
 Here is a trivial function, that does something which you don't want to type multiple times.

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
int myMoney = Money(); // Calling 'Money'
```
]
???
http://en.wikipedia.org/wiki/Function_object

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

???
http://en.wikipedia.org/wiki/Pointer_(computer_programming)

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

???
http://en.wikipedia.org/wiki/C%2B%2B_classes

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
*public:
    int hours;
*protected;
    int minutes;
*private:
    int seconds;
};
```
`public` variables can be accessed anywhere. `protected` and `private` are more restricted.
]

???
http://en.wikipedia.org/wiki/C%2B%2B_classes

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

???
http://en.wikipedia.org/wiki/Binary

---
class: center, middle
# More Technical Terms

Now we move into trickier territory.
These terms are a step above the foundations of programming in the previous section.

???
Notes: ... 
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

???
Notes: ... 
---
.left-column[
  ### Medium
  ###-Hex
]
.right-column[
# Hexadecimal

Imagine a world where people have 16 fingers, this is how they 'count'

    0   1  2  3  4  5  6  7  8  9  A  B  C  D  E  F
    10 11 12 13 14 15 16 17 18 19 1A 1B 1C 1D 1E 1F
    20 22 22 23 24 25 26 27 28 29 2A 2B 2C 2D 2E 2F

Conversion table:

    | Bits | Decimal             | Hexadecimal         |
    |======|=====================|=====================|
    | 0001 | 1 * 1 = 1           | 1 * 1 = 1           |
    | 0010 | 1* 10 = 10          | 1 * 16 = 16         |
    | 0100 | 10* 10 = 100        | 16 * 16 = 256       |
    | 1000 | 10 * 10 * 10 = 1000 | 16 * 16 * 16 = 4096 |
    |      |                     |                     |

]

???
http://en.wikipedia.org/wiki/Hexadecimal

---
.left-column[
  ### Medium
  ###-Hex
  ###-Call stack
]
.right-column[
# Call Stack

The 'stack' of 'calls'...

A stack is a first on, last off concept.

	1   1st push
	12  2nd push
	123 3rd push
	12  1st pop
	124 4th push
	12  2nd pop
	1   3rd pop
	    4th pop

A function gets added to the stack when you use it (call it).
It gets removed when the function ends.

In the example stack, function 2 calls 3 and 4 before it ends.
	
]
???
http://en.wikipedia.org/wiki/Call_stack

---
.left-column[
  ### Medium
  ###-Hex
  ###-Call stack
  ###-Stack
]
.right-column[

# The Stack

The variables that a function creates all live on their 'The Stack'.
While our Call Stack is a stack of functions, The Stack is a stack of memory addresses.

As a function executes, each variable gets added to the stack.
When the function finishes, they all get 'popped' off as they're not needed.
This happens in the order you expect - first on, last off.

Memory leaks do not come from variables on the stack.
But, you will have trouble if you return pointers to things on the stack!
]

???
http://en.wikipedia.org/wiki/Stack_(abstract_data_type)
 
---
.left-column[
  ### Medium
  ###-Hex
  ###-Call stack
  ###-Stack
  ###-Heap
]
.right-column[
# The Heap

The Heap is a place where variables live also, but it doesn't work the same way.

If you make a variable on The Heap, it will stay there until you decided to remove it.
The way to do this is `C++` is with the `new` and `delete` keywords.

The Heap is where memory leaks happen.
Make a new variable on The Heap and you will get a pointer to it.
If you loose that pointer (it goes out of scope, you set the pointer to be another value, etc) then there is NO WAY to remove the variable.

In C# the 'new' keyword is very different.
You don't have to worry about memory leaks in C#.

]

???
http://en.wikipedia.org/wiki/Memory_management#HEAP
 
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

Another name for Binary and Hexadecimal.
The 

    Base  2 -> 0010 =  2  - 0, 1
    Base 10 -> 0010 = 10  - 0, 1, ... 8, 9
    Base 16 -> 0010 = 16  - 0, 1, ... E, F
    Base 99 -> 0010 = 99  - 0, 1, ... '98', '99'
    
Here you can see that any base can be used.
It is very inconvenient that we can't express '10' in one numerical digit, that is why Hexadecimal uses 'A'.

_(I don't know of any use for Base 99)_
    
]

???
http://en.wikipedia.org/wiki/Radix
 
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

Technically, a float is a representation of the a number.
There can only be 6 significant digits in the number.

A `double` is a decimal number which far more precise, but it uses more memory.

```cpp
double preciceSpeedModifier = 1.5; // no 'f' needed
```

]

???
http://en.wikipedia.org/wiki/Floating_point
  
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

These are the most common ones for C++
* MSVC - Microsoft Visual Compiler
* GCC - GNU Compiler Collection
* Clang - C Language Compiler

C# exsists mainly on the Windows platform, but alternative free compilers do exists.
Unity uses the Mono project which has its own compiler.
]
???
http://en.wikipedia.org/wiki/Compiler
 
---
class: center, middle
# Complex Topics


Okay, these are harder to understand but you are likely to hear the terms being thrown around when programmers are about.

???

---
.left-column[
  ### Hard
]
.right-column[
# Complex  Topics
* Template
* Handle
* Interface
* Stack Overflow
* Memory Corruption
* Segfault / segmentation fault
]

???
Notes: ... 
---
.left-column[
  ### Hard
  ###-Template
]
.right-column[
# Template

A template is a way to make a class which has other variable types.
Variable for the variables!

```cpp
template< class T > class Container
{
public: 
	T m_data;
};
```

The `T` can be an `int` or a `char` or anything you like.

In C# templates are called generics.

```cpp
Container<int> myIntegerData;
```

]

???
http://en.wikipedia.org/wiki/Template_(C%2B%2B)
 
---
.left-column[
  ### Hard
  ###-Template
  ###-Handle
]
.right-column[
# Handle

A handle is very close to a pointer in concept.
It is a abstract reference (alias) to a resource in your program.

When you use a handle you don't have direct access to the resource.
This is beneficial if you want to provide restricted (and safer) functionality.

An 'int' can be used as an handle.
Think of a sports team - each player has a name, but you can use their jersey number to interact with them:

    I want to substitute #7 for #11

_(A handle is a software construct. It is not a part of the programming language)_
]

???
http://en.wikipedia.org/wiki/Handle_(computing)
---
.left-column[
  ### Hard
  ###-Template
  ###-Handle
  ###-Interface
]
.right-column[
# Interface

There are many uses for this word, here are some examples:
* Hardware - a keyboard and mouse are an interface to the computer
* Software - The icons on your phone is a 'user interface'
* Programming language - A way to specify abstract rules for object usage

A 'clickable' interface.
An object must implement these functions for other code to be able to see it as a 'clickable' object.
```cpp
class ClickableInterface
{
    virtual void OnClick( int xPosition, int yPosition ) = 0;
    virtual void OnDoubleClick( int xPosition, int yPosition ) = 0;
    virtual void OnHold( int xPosition, int yPosition ) = 0;
};
```
_(This is `C++` syntax for a "pure virtual function")_


]

???
http://en.wikipedia.org/wiki/Interface_(computing)
---
.left-column[
  ### Hard
  ###-Template
  ###-Handle
  ###-Interface
  ###-Overflow
]
.right-column[
# Buffer Overflow

A buffer is a name for consecutive blocks of memory.
An array one type of buffer.
A file on the computer is another.

In `C++` you can easily write too much into a buffer.
If you have an array with space for three characters (player initials) and you try and a full name into that list, the extra letters `stomp` over the memory directly after the array

```cpp
char initials[3] = { 'X', 'X', 'X' };
char firstLetter = 'A';
char lastLetter = 'A';
```

    0   1   2   3   4   
    |X  |X  |X  |A  |Z  |
    ¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯
    // try and set 'initials' to 'Bobby'
    0   1   2   3   4   
    |B  |o  |b  |b  |y  |
    ¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯
]

???
http://en.wikipedia.org/wiki/Buffer_overflow
---
.left-column[
  ### Hard
  ###-Template
  ###-Handle
  ###-Interface
  ###-Overflow
  ###-Corrupt
]
.right-column[
# Memory Corruption

The buffer overflow is one type of memory corruption - running passed the memory location you are meant to be using.

If you have a pointer to memory, then that memory gets used for an object of a different type... using that original pointer is going to do crazy things to memory.
_Hopefully_ when something like that happens the program crashes instantly, otherwise you have to wait for the corruption to manifest as a bug.
At that point it is hard to know what caused the corruption.

This is one of the hardest class of bugs to track down and fix!
]

???
http://en.wikipedia.org/wiki/Memory_corruption
Notes: ... 
---
.left-column[
  ### Hard
  ###-Template
  ###-Handle
  ###-Interface
  ###-Overflow
  ###-Corrupt
  ###-Segfault
]
.right-column[
# Segmentation Fault

This is a technical term for an _access violation_.

When the program tries to use memory that it shouldn't, the operating system running the program raises a segfault - this normally triggers the termination of a program.

A 'null pointer crash/dereference' is the classic cause of this.
This is a very common error (doh), but it is normally trivial to fix with a _pointer check_

```cpp
Player* playerPointer = NULL;
if ( playerPointer ) // same as 'playerPointer != NULL'
{
    // poitner can't be NULL
*   playerPointer->JumpAround();
}
```
]
???
http://en.wikipedia.org/wiki/Segmentation_fault
Notes: ... 
---
class: center, middle
# Questions?

???
Notes: ... 
---
class: center, middle
# End

Got back to the [presentations](http://nathanrosspowell.com/presentations/) home page.

???
Notes: ... 
