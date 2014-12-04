class: center, middle
# Why Crashes Happen
By Nathan Ross Powell

Source: [why_crashes_happen/README.md](https://github.com/nathanrosspowell/presentations/blob/master/src/beginner_guides/why_crashes_happen/README.md)
Webpage: [why_crashes_happen/index.html](http://nathanrosspowell.com/presentations/beginner_guides/why_crashes_happen)
???
These are where the slide notes go.
---
# Intro

We will look at how programs crash and investigate why.
I will go over identifying the type of crash (null pointer, index out of bounds, hardware breakpoint, etc) and reviewing why programmers make these mistakes (copy paste errors, bad code reviews, lack of understand of the program etc).
I will prepare some examples of each that I might attempt to debug live in the session!

---
# Types of Crashes
* Null pointer
* Invalid handle
* Index out of range / Buffer overrun
* Stack overflow
* Out of memory
* Divide by zero
* Hardware breakpoints (special mention to asserts)

---
.left-column[
  ### Null ptr 
]
.right-column[
# Null Pointer

A pointer holds the value of a memory adress.

They type of the pointer defines what is in that memory adress.

```cpp
int* ptr = NULL;
```

This is a pointer to an int, that has been initalised to `NULL` (aka empty).
That is the __CORRECT__ way to initalise a pointer.
But you need to set it to something before you use it.
]

---
.left-column[
  ### Null ptr 
  ###-What
]
.right-column[
# What

Have a pointer, which points to nothing, then try and use it.
```cpp
Player* player = NULL; // = nullptr; // = 0;
player->Update(); // CRASH
```

Here we see `->` used to call a function instead of the `.` method.
Using `->` is the same as doing `(*player).Update();`.

`(*player)` is a dereference, which means 'use the value at the memory address `player`'.
]

---
.left-column[
  ### Null ptr 
  ###-What
  ###-How
]
.right-column[
# How

It isn't pointing at a memory adress.

If the pointer is set to `NULL`, that means it is set to the memory adress `0`.

If you try to get the value from a memory adress that doesn't exsits (adress `0`), then there is going to be a problem.

]

---
.left-column[
  ### Null ptr 
  ###-What
  ###-How
  ###-Why
]
.right-column[
# Why 

Lazy programmers.  Pointers are used so much that sometimes people simply forget to check.

Pointers are often used as parameters to functions where it is just assumed that a valid pointer is passed.
```cpp
void Test(int* ptr) { /* do stuff with ptr */ }
```
But there is nothing stopping someone doing `Test(NULL);`

Functions can also return pointers, which means they can return NULL. It is another place where people forget to put checks.

```cpp
TimeOfDay* GetTimeOfDay(){ return NULL; }
TimeOfDay* ptr = Get();
ptr->GetSeconds(); // CRASH
```
]


---
.left-column[
  ### Handle 
]
.right-column[
# Invalid Handle

]


---
.left-column[
  ### Handle 
  ###-What
]
.right-column[
# What

]

---
.left-column[
  ### Handle 
  ###-What
  ###-How
]
.right-column[
# How

]

---
.left-column[
  ### Handle 
  ###-What
  ###-How
  ###-Why
]
.right-column[
# Why 

]


---
.left-column[
  ### Index 
  ###-What
]
.right-column[
# Index Out Of Range
## What

]

---
.left-column[
  ### Index 
  ###-What
  ###-How
]
.right-column[

# Index Out Of Range
## How

]

---
.left-column[
  ### Index 
  ###-What
  ###-How
  ###-Why
]
.right-column[
# Index Out Of Range
## Why 

]


---
.left-column[
  ### Stack 
  ###-What
]
.right-column[
# Stack Overflow
## What

]

---
.left-column[
  ### Stack 
  ###-What
  ###-How
]
.right-column[

# Stack Overflow
## How

]

---
.left-column[
  ### Stack 
  ###-What
  ###-How
  ###-Why
]
.right-column[
# Stack Overflow
## Why 

]

---
.left-column[
  ### Memory 
  ###-What
]
.right-column[
# Out Of Memory
## What

]

---
.left-column[
  ### Memory 
  ###-What
  ###-How
]
.right-column[

# Out Of Memory
## How

]

---
.left-column[
  ### Memory 
  ###-What
  ###-How
  ###-Why
]
.right-column[
# Out Of Memory
## Why 

]


---
.left-column[
  ### Zero 
  ###-What
]
.right-column[
# Divide By Zero
## What

]

---
.left-column[
  ### Zero 
  ###-What
  ###-How
]
.right-column[

# Divide By Zero
## How

]

---
.left-column[
  ### Zero 
  ###-What
  ###-How
  ###-Why
]
.right-column[
# Divide By Zero
## Why 

]


---
.left-column[
  ### Traps 
  ###-What
]
.right-column[
# Traps And Asserts
## What

]

---
.left-column[
  ### Traps 
  ###-What
  ###-How
]
.right-column[

# Traps And Asserts
## How

]

---
.left-column[
  ### Traps 
  ###-What
  ###-How
  ###-Why
]
.right-column[
# Traps And Asserts
## Why 

]



---

class: center, middle
# Questions?

???
Notes: ...
---
class: center, middle
# End

Got back to the [why_crashes_happen](http://nathanrosspowell.com/presentations/beginner_guides/why_crashes_happen) page to see the practical work.
???
Notes: ...

