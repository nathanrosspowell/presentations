class: center, middle
# Language Syntax

By Nathan Ross Powell

Source: [language_syntax/README.md](https://github.com/nathanrosspowell/presentations/blob/master/src/beginner_guides/language_syntax/README.md)
Webpage: [language_syntax/index.html](http://nathanrosspowell.com/presentations/beginner_guides/language_syntax)
???

These are where the slide notes go.

---
.left-column[
  ### Refresh
]
.right-column[

# Quick Pit Stop Tour

Let's go over the basics.
* Quiz 1
* Quiz 2
* Quiz 3
]

---
.left-column[
  ### Refresh
  ### 1.
]
.right-column[

# These are... 

```cs
int aSpecialNumber = 42;

char endOfTheAlphabet = 'Z';

string month = "November";

List<int> countDown = new List<int>() { 2, 3, 4, 5 };
```
]
???
These are variables, each with there own 'type'
int - whole numbers
char - a single character
string - a list of characters
List<T> - a list of 'T', which can be any 'type'

---

.left-column[
  ### Refresh
  ### 1.
  ### 2.
]
.right-column[
# And these... 

```cs
string GetName() 
{ 
    return "Bob";
}

int Money() 
{ 
    return 3 + 54 + 77;
}

void DoStuff
{
    TestA();
    MakeB( SetupC( 3 ) );
}
```
]
???
These are all functions

---

.left-column[
  ### Refresh
  ### 1.
  ### 2.
  ### 3.
]
.right-column[
# Finally...

```cs
class Obvious // 1
{
    private string _name = "Captain"; // 2
    public int Multiplier { get; set; } // 3 (C# specific) 
}

class Container<T> // 4
{
    private T _myData; // 5
    void T Data // 6
    get 
    { 
        return _myData; 
    }
    set 
    {
        name = value; 
    }
}
```
]
???
These are all functions

---


class: center, middle
# Class Hierarchies

We will look over the principles of OOP* to describe class hierarchies.

_*Object Oriented Programming_

---
.left-column[
  ### OOP 
]
.right-column[
# Class Hierarachies 
* Definition of OOP
* Classic Example
* Advantages
* Drawbacks
* Other solutions
]

???
Notes: ... 

---
.left-column[
  ### OOP 
  ### Definition
]
.right-column[
# Definition of OOP
]

???
Notes: ... 

---
.left-column[
  ### OOP 
  ### Definition
  ### Example
]
.right-column[
# Classic OOP Use Case
]

???
Notes: ... 

---
.left-column[
  ### OOP 
  ### Definition
  ### Example
  ### Advantages
]
.right-column[
# Advantages of Class Hierarchies
]

???
Notes: ... 

---
.left-column[
  ### OOP 
  ### Definition
  ### Example
  ### Advantages
  ### Drawbacks
]
.right-column[
# Drawbacks To Using Class Hierarchies
]

???
Notes: ... 

---
.left-column[
  ### OOP 
  ### Definition
  ### Example
  ### Advantages
  ### Drawbacks
  ### Alternatives
]
.right-column[
# Alternatives
* Component based
* Interfaces
* Data Oriented
]

???
Notes: ... 

---
class: center, middle
# Questions?

???
Notes: ... 
---
class: center, middle
# End

Got back to the [language_syntax](http://nathanrosspowell.com/presentations/language_syntax) page to see the practical work.

???
Notes: ... 
