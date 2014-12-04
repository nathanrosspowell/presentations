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
  ###-Example
]
.right-column[
#  Null pointer example

```cpp
Player* player = NULL; // = nullptr; // = 0;
player->Update(); // CRASH
```

]

---
.left-column[
  ### Null ptr 
  ###-Example
  ###-Explanation
]
.right-column[
#  Null pointer explanation

It isn't pointing at a memory adress.

]

---
.left-column[
  ### Null ptr 
  ###-Example
  ###-Explanation
  ###-The why
]
.right-column[
#  Why Null pointer crashes happen

Lazy programmers.

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

