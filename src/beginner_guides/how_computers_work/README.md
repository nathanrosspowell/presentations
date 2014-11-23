class: center, middle
# How Computers Work

By Nathan Ross Powell

Source: [how_computers_work/README.md](https://github.com/nathanrosspowell/presentations/blob/master/src/beginner_guides/how_computers_work/README.md)
Webpage: [how_computers_work/index.html](http://nathanrosspowell.com/presentations/beginner_guides/how_computers_work)
???
These are where the slide notes go.
---
# Intro

To understand computer programs, you need to be able to think like a computer.

---
# Thought Exercise

There are two drinks coasters:
* Coaster A
* Coaster B

Each one has a drink on it:
* Drink 1
* Drink 2

How do you swap them so A has drink 2 on it and B has drink 1 on it?

Describe your steps in _extreme detail_!

---
# Computers Work Sequentially 

Doing things one step at a time is how a CPU works.

A human might pick up both drinks and swtich them in place, a computer just doesn't think like that!

---
# My Imaginary PC

The `NP20` is a computer spec which describes a computer with 20 'slots' of memory. 

    MEMORY SLOTS
    0   1   2   3   4   5   6   7   8   9   10  11  12  13  14  15  16  17  18  19  END
    |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |
    ¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯
The `NP20` supports integers and they are one slot in size.
There is no such thing as an 'empty' slot, there is always a value in there.
When the computer starts it is nice enought to set them all to zero.

The computer can run C/C++ programs.
We will make some examples and then study the memory slots after each line of code!

---
# Example NP20 Program

Here is a program that uses `3 slots` of memory:
```cpp
int hours = 24;
int days = 7;
int workHours = a * b;
```
Here are the detailed steps of the program as seem by the computer:

    SET SLOT 0 TO 24
    SET SLOT 1 TO 7
    SET SLOT 2 TO RESULT SLOT 0 MULTIPLY SLOT 1 AND SET SLOT 2 TO THE RESULT

When we compile* our program, the computer strips away the variable names and uses the only thing it knows, slots.
Each slot has a number.
In the computer you have at your desk this is called a 'memory address' and they look like this: 0x3A28213A.
This is why we are using the simlified `NP20` computer for now.

In programming the amazing `pointer` has one job, to point to a memory address. 
See this [xkcd](http://xkcd.com/138/) for more details.

---
# Example Step-by-Step

In the example we see there are three steps.
This is what the memory slots look like at the end of each one:

    0   1   2   3   4   5   6   7   8   9   10  11  12  13  14  15  16  17  18  19  END
    |24 |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  | Hours
    |24 |7  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  | Days
    |24 |7  |168|0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  | Work Hours
    ¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯
    hours
        days
            workHours


---
# Swapping The Drinks

Here is the swap algorithm:
```cpp
int a = 1;
int b = 2;
int c = a;
a = b;
b = c;
```

This is how it loops step by step:

     0   1   2   3   4   5   6   7   8   9   10  11  12  13  14  15  16  17  18  19  END
    |1  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  | a
    |1  |2  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  | b
    |1  |2  |1  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  | c
    |2  |2  |1  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  | a=b
    |2  |1  |1  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |0  | b=c
    ¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯

---
class: center, middle
# Questions?

???
Notes: ... 
---
class: center, middle
# End

Got back to the [how_computers_work](http://nathanrosspowell.com/presentations/beginner_guides/how_computers_work) page to see the practical work.
???
Notes: ... 
