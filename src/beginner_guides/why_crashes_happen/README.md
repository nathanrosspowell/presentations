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
# What does it look like

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
  ###-Why
]
.right-column[
# Why does it crash

It isn't pointing at a memory adress.

If the pointer is set to `NULL`, that means it is set to the memory adress `0`.

If you try to get the value from a memory adress that doesn't exsits (adress `0`), then there is going to be a problem.

]

---
.left-column[
  ### Null ptr 
  ###-What
  ###-Why
  ###-How
]
.right-column[
# How does it happen

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
  ### Null ptr 
  ###-What
  ###-Why
  ###-How
  ###-Fix
]
.right-column[
# The fix

A pointer can be put into an if check.
The if fails if the pointer is `NULL` as `0` is equal to `false`.

```cpp
TimeOfDay* GetTimeOfDay(){ return NULL; }
/* ...... */
TimeOfDay* ptr = Get();
if ( ptr )
{
    ptr->GetSeconds(); // no crash :)
}

// Another option in C++
if ( TimeOfDay* ptr = Get() )
{
    ptr->GetSeconds(); // no crash :)
}
```
]


---
.left-column[
  ### Handle 
]
.right-column[
# Invalid Handle

A handle is a type which adds a level of indirection to accessing an object.

Just like a pointer, a handle can be set to 'nothing' (`NULL`), which leads to problems.

```cpp
class EntityHandle
{
private:
    int m_id;
public:
    bool IsValid() { return m_id != 0; }
    int GetId() { return m_id };
    Entity* Get() { return EntityManager::Get(m_id); }
    Entity* operator->() const { return Get(); }
};
```
Here we can see that access to an `Entity` class has been wrapped inside of `EntityHandle`.
]


---
.left-column[
  ### Handle 
  ###-What
]
.right-column[
# What does it look like

The value returned by the handle (in our case it is an `Entity*`) is not valid, but it is used anyway.

```cpp
myHandle.Get()->Update(); // Get() returns NULL, so CRASH
```
Here we get a valid handle, which we can use, but then it becomes invalid.
Using it after it's invalid is going to cause a crash.

```cpp
EntityHandle player = GetPlayerHandle(); // Gives valid handle
/* ... lots of other code, player gets deleted ... */
player->ScorePoint(); // the -> operator returns NULL, CRASH
```
Notice the use of `->` directly on the handle.
This is custom behaviour defined by the operator overload in the class.

]

---
.left-column[
  ### Handle 
  ###-What
  ###-Why
]
.right-column[
# Why does it crash

A handle will always do a step to find the object. 
This is done by using some kind of ID and a look up function.

If the object matching the ID cannot be found, or the ID is invalid, then no object can be returned.

Unlike pointer, a handle _WILL_ work if the object is moved about in memory.
This is a big advantage to using handles.

]

---
.left-column[
  ### Handle 
  ###-What
  ###-Why
  ###-How
]
.right-column[
# How does it happen

Again, lazyness.

It is easy to forget to check a handle to see if it is valid.

In theory a handle is safer than a pointer so many people are not as strick when using them.

Programmers make assumtions to like "The player will always be there, so no need to check the handle"... so things will crash when the player respawns or teleports!

]


---
.left-column[
  ### Handle 
  ###-What
  ###-Why
  ###-How
  ###-Fix
]
.right-column[
# The fix

You could check it like a pointer, but there is a better way.

The handle is a class so a descriptive function can be used to make code readable and more maintainable.
If you have good eyes you will have seen the answer in the class.

```cpp
EntityHandle player = GetPlayerHandle(); // Gives valid handle!
if ( player.IsValid() )
{
    player->ScorePoint(); // -> operator gives a valid pointer
}
```

Now the pointer is checked! The `IsValid()` function can also hold any custom logic you may need to add in the future.

]


---
.left-column[
  ### Index 
]
.right-column[
# Index Out Of Range

The index operator _or_ subscript operator is what we have been using to access elements in a list.

```cpp
int scores[] = { 5, 6, 7, 8 };
scores[ 0 ] = 9; // sets 5 to be 9
```
The possible indexes for this list are `[0]`, `[1]`, `[2]` and `[3]`.
The general formular is range `0 to (size - 1)`.
]
---
.left-column[
  ### Index 
  ###-What
]
.right-column[
# What does it look like

Any direct access with an incorrect index.
```cpp
scores[99] = 10;
scores[-1] = 11;
```
This can easily happen in a loop.
```cpp
for ( int i = 0; i < 20; ++i )
{
    scores[ i ]; // if i > 3, CRASH
}
```
]

---
.left-column[
  ### Index 
  ###-What
  ###-Why
]
.right-column[
# Why does it crash

The answer is; it doesn't always!

Depending on the list type being used and the compiler (etc etc) you can get differnt results.

When this doesn't crash - we have the case of memory corruption...

Going past the end of the arry will access the memory addresses directly after the array, which could be anything.

]

---
.left-column[
  ### Index 
  ###-What
  ###-Why
  ###-How
]
.right-column[
# How does it happen

This one is a monster!

Like checking every pointer, you really need to do a range check before trying to get an item via an index!
```cpp
scores[ PlayerIndex() ] = 100; // could CRASH
```
As soon as a variable is being used inside the `[]` you have to makes sure no crazy values are going to be used as an index.

Programmers might try to do clever maths inside of a loop... this will end badly most of the time.
```cpp
for ( int i = 0; i < 4; ++i )
{
    // score = next score. When i = 3, CRASH
    scores[ i ] = scores[ i + 1 ];
}
```
]


---
.left-column[
  ### Index 
  ###-What
  ###-Why
  ###-Fix
]
.right-column[
# The fix

FORCE a crash whenever a bad index happens.
To do this:
* ditch standard _raw_ C++ arrays.
* overload the subscript (`[]`) operator

```cpp
class ListOf4 
{
private:
    int m_array[4];
public:
    int operator[] (const int index)
    {
        ASSERT( index > 0 && index < 4 );
        return m_array[index];
    }
};
```
This is impractical as you would need a class for each type and length of array.
This is where templates come into play.
```cpp
std::array<int, 4> scores = {1, 2, 3, 4};
std::vector<int> scores = {1, 2, 3, 4};
```

]

---
.left-column[
  ### Stack 
]
.right-column[
# Stack Overflow

Each time you call a funtion it uses a bit of memory.
As functions nest:
```cpp
void A(){ B(); }
void B(){ C(); }
/* and so on... */
```
... they use up the space on the call stack.

At a certain point - we run out of memory.
]

---
.left-column[
  ### Stack 
  ###-What
]
.right-column[
# What does it look like

The probably cause of Stack overflow is recursive function.

A recursive function is one that calls itself!

``cpp
void Recursion()
{
    Recursion();
}
```
]

---
.left-column[
  ### Stack 
  ###-What
  ###-Why
]
.right-column[
# Why does it crash

As explained, the program runs out of space to call more functions.

The stack is a _first on, last off_ memory structure.
When a function finishes, program needs to know where it should carry on executing commands.
This is all explained by the information on the stack.

On platforms with not a lot of memory (games consoles, mars rovers, etc) the maxium stack size you program produces is very important.
The memory availble to use for the call stack can be optimized to suit your program.

]

---
.left-column[
  ### Stack 
  ###-What
  ###-Why
  ###-How
]
.right-column[
## How does it happen

No one would make the function like 'Recursive()', but the recursive function pattern is very powerful for things which hold copies of themselves, like 'linked lists`.

```cpp
int Count( Node* node )
{
    int value = node->value;
    if ( node->next )
    {
        value += Count( node->next );
    }
    return value;
}
```
If the linked lists loops, this function will keep going until the call stack explides!

]

???
http://en.wikipedia.org/wiki/Linked_list

---
.left-column[
  ### Stack 
  ###-What
  ###-Why
  ###-How
  ###-Fix
]
.right-column[
# The Fix

You _HAVE_ to have a good breaking case to stop recursive functions.

It is very hard to guarentee that your function will stop before busting the call stack.
For a real brain exercise look up the [Halting Problem](http://en.wikipedia.org/wiki/Halting_problem).


]


---
.left-column[
  ### Memory 
  ###-What
]
.right-column[
# Out Of Memory
# What does it look like

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

