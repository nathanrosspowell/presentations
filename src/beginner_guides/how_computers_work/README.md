class: center, middle
# How Computers Work 
By Nathan Ross Powell

Source: [how_computers_work/README.md](https://github.com/nathanrosspowell/presentations/blob/master/src/beginner_guides/how_computers_work/README.md)
Webpage: [how_computers_work/index.html](http://nathanrosspowell.com/presentations/beginner_guides/how_computers_work)
???
These are where the slide notes go.
---
# Intro

This will be the most technical topic we cover, but it should help tie together some of the concepts we have already been looking over in the previous lessons. 

We will focus mostly on memory access.

In the lessons before we have read out lines of code in human language: `int number = 3;` becomes _“an integer named ‘number’ is equal to 3”_. 
Now we will learn what a computer does with this information.

To understand computer programs, you need to be able to think like a computer!

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

A human might pick up both drinks and switch them in place, a computer just doesn't _think_ like that!

The though exercise can be done by listing out one step at a time instructions (just how the computer likes it), if you just add one more variable to the mix.

---
# My Imaginary PC

The `NP10` is a computer spec which describes a computer with 10 'slots' of memory.

```
MEMORY SLOTS
1   2   3   4   5   6   7   8   9   10  END
|0  |0  |0  |0  |0  |0  |0  |0  |0  |0  |
¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯
```
The `NP10` supports integers and integer pointers and they are both one slot in size.
When the computer starts it is nice enough to set all slots to zero.

The computer can run `C` programs.
We will make some examples and then study the memory slots after each line of code!

The memory slots are used as a 'stack' : _"first on, last off"_

---
# Example NP10 Program

Here is a program that uses `3 slots` of memory:
```cpp
int hours = 24;
int days = 7;
int workHours = a * b;
```
Here are the detailed steps of the program as seem by the computer:

```
SET SLOT 1 TO 24
SET SLOT 2 TO 7
SET SLOT 3 TO SLOT 1 MULTIPLY SLOT 2
```

When we compile our program, the computer strips away the variable names and uses the only thing it knows, slots.
Each slot has a number.
In the computer you have at your desk this is called a 'memory address' and they look like this: `0x3A28213A`.
This is why we are using the simplified `NP10` computer for now.

In programming the amazing `pointer` has one job, to point to a memory address.
See this [xkcd](http://xkcd.com/138/) for more details.

---
# Example - step by step

In the example we see there are three steps.
This is what the memory slots look like at the end of each one:

```
1   2   3   4   5   6   7   8   9   10   END
|24 |0  |0  |0  |0  |0  |0  |0  |0  |0  | Hours
|24 |7  |0  |0  |0  |0  |0  |0  |0  |0  | Days
|24 |7  |168|0  |0  |0  |0  |0  |0  |0  | Work Hours
¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯
hours
-   days
-   -   workHours
```

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

```
1   2   3   4   5   6   7   8   9   10  END
|1  |0  |0  |0  |0  |0  |0  |0  |0  |0  | a
|1  |2  |0  |0  |0  |0  |0  |0  |0  |0  | b
|1  |2  |1  |0  |0  |0  |0  |0  |0  |0  | c
|2  |2  |1  |0  |0  |0  |0  |0  |0  |0  | a=b
|2  |1  |1  |0  |0  |0  |0  |0  |0  |0  | b=c
¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯
a
-   b
-   -   c
```

---

# Arrays

We have seen arrays of many types before.
Here is basic example of using an array of `int`s, including use of the `[]` operator

```cpp
int first[] = { 5, 6, 7 };
first[0] = 8;
int second[3];
second[2] = 4;
```

The array can be initialized in one go without specifying the size.
You can use the subscript operator `[]` to specify an item in the list you want to use.

It is also an option to set the size of the array and not initialize it.
This is not normally a good idea!
If you declare a variable or an array but don't give it a there is a initial value, the value will be whatever is there already!
In debug modes memory will start as `0` for you, but that is slow.
There is a special `C++` syntax to set an array to all zeros: `int second[3] = {}`

---

# Arrays - step by step


```cpp
int first[] = { 5, 6, 7 };
first[0] = 8;
int second[3];
second[2] = 4;
```

```
SET SLOT 1 TO ARRAY SIZE 3 WITH 5 6 7
SET SLOT 1 TO 8
SET SLOT 4 TO ARRAY SIZE 3
SET SLOT 6 TO 4
```

```
1   2   3   4   5   6   7   8   9   10   END
|5  |6  |7  |0  |0  |0  |0  |0  |0  |0  | set first
|8  |6  |7  |0  |0  |0  |0  |0  |0  |0  | = 8
|8  |6  |7  |0  |0  |0  |0  |0  |0  |0  | reserve second
|8  |6  |7  |0  |0  |4  |0  |0  |0  |0  | = 4
¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯
[-first----]
-   -   -   [-second----]
```

The computer see's out array access just like any other variable interaction.

---

# Common Array Usage

If using an item in a list is the same as using a normal variable, then why use them?
* It very simple to increase the size of an array
* It is harder to add a new variable
* Looping over array is very easy!

Here is a list of test scores which we compute the average from:

```cpp
const int size = 3; // const means 'constant' aka 'never changes'
int scores[size] = { 25, 50, 75 };
int sum = 0;
for ( int i = 0; i < size; ++ i )
{
    sum += scores[ i ];
}
int average = sum / size;
```

This is very interesting step by step.

---

# Common Usage - step by step

```
1   2   3   4   5   6   7   8   9   10   END
|3  |0  |0  |0  |0  |0  |0  |0  |0  |0  | size
|3  |25 |50 |75 |0  |0  |0  |0  |0  |0  | scores
|3  |25 |50 |75 |0  |0  |0  |0  |0  |0  | sum
|3  |25 |50 |75 |0  |0  |0  |0  |0  |0  | i
|3  |25 |50 |75 |25 |0  |0  |0  |0  |0  | loop 1
|3  |25 |50 |75 |25 |1  |0  |0  |0  |0  | increment i 
|3  |25 |50 |75 |75 |1  |0  |0  |0  |0  | loop 2
|3  |25 |50 |75 |75 |2  |0  |0  |0  |0  | increment i
|3  |25 |50 |75 |150|2  |0  |0  |0  |0  | loop 3
|3  |25 |50 |75 |150|3  |0  |0  |0  |0  | increment i
|3  |25 |50 |75 |150|0  |0  |0  |0  |0  | done with i
|3  |25 |50 |75 |150|50 |0  |0  |0  |0  | average
¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯
size
-   [-scores---]
-   -   -   -   sum
-   -   -   -   -   i
-   -   -   -   -   average
```

The variable `i` is in it's own _scope_.
This means it can only be used inside the loop.
After the loop ends, we `pop` it from the stack.
The next variable, `average`, goes into the first free slot.
Which is where `i` used to be!

???

The line 'done with i' sets the slot back to 0.
This is just to make it explicitly clear!

---

# Pointers

We can also use pointers in our code.

```
int clark = 66;
int kent = 77;
int* superman = &clark;
**superman = 88;
superman += 1;
**superman = 99;
```

* `&clark` means _'get the memory slot clark is in"_.
* `*superman` means _'get the value of the slot that superman is pointing to'_.
* You can use normal math operations on pointers
* This makes them very powerful!

???
http://www.cplusplus.com/doc/tutorial/pointers/

(if you are viewing the source file, it shows '**superman', that is because the slideshow tool eats the first one)

---

# Pointers - step by step

```
int clark = 66;
int kent = 77;
int* superman = &clark;
**superman = 88;
superman += 1;
**superman = 99;
```

```
SET SLOT 1 TO 66
SET SLOT 2 TO 77
SET SLOT 3 TO POINT TO SLOT 1
SET SLOT POINTED TO BY 3 TO 88
SET SLOT 3 TO SLOT 3 PLUS 1
SET SLOT POINTED TO BY 3 TO 99
```

```
1   2   3   4   5   6   7   8   9   10   END
|66 |0  |0  |0  |0  |0  |0  |0  |0  |0  | clark
|66 |77 |0  |0  |0  |0  |0  |0  |0  |0  | kent
|66 |77 |1  |0  |0  |0  |0  |0  |0  |0  | superman 
|88 |77 |1  |0  |0  |0  |0  |0  |0  |0  | = 88
|88 |77 |2  |0  |0  |0  |0  |0  |0  |0  | += 1 
|88 |99 |2  |0  |0  |0  |0  |0  |0  |0  | = 99
¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯
clark
-   kent
-   -   superman
```

---

# The Power Of The Array

The example of adding 1 to the pointer so that it accessed a different memory slot is the basis of how arrays work.
These two programs have the same results:

```
int nums[] = { 22, 33, 44 };
nums[0] = 55;
nums[1] = 66;
```

```
int nums[] = { 22, 33, 44 };
int* slot = nums;
**slot = 55;
slot = nums + 1;
**slot = 66;
```

The variable `nums` holding the array is the pointer to the first element - nothing more!
It use this array anywhere in the program, all you have to do is pass the pointer to it (which gives the first element) and **ALSO** the size.

---

# In Real Life

The differences between the `NP10` model and a real `X86` PC setup is this:

* A `int` (or `int32`) uses 4 `bytes`
* A `byte` is 8 `bits` in size
* The program memory address doesn't start at 1
* More than just 'int' types are supported

```
ONE 32 BIT MEMORY SLOT
0x3A282132                                                      0x3A282136
|               |               |               |               |
|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|1|1|0|0|1|0|0|
¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯
```

`00000000000000000000000001100100 binary = 100 decimal`

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
