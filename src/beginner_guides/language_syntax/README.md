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
  ### Quiz 1
]
.right-column[

# These are... 

```csharp
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
  ### Quiz 1
  ### Quiz 2
]
.right-column[
# And these... 

```csharp
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
  ### Quiz 1
  ### Quiz 2
  ### Quiz 3
]
.right-column[
# Finally...

```csharp
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
1. Class
2. private member
3. public property
4. generic class
5. private template member
6. explicity public property

---

class: center, middle
# Class Hierarchies

We will look over the principles of OOP* to describe class hierarchies.
You will use class hierarchies to organise functionality and avoid duplication of code, even if you don't use the OOP methodology.

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

OOP is the using a model of real world object descriptions to organise data and functionality.

`base class->derived class->really derived class`

The derived classes have all of the functionality of the classes before it and also there own functionality.
The base class also defines `virtual` functions which the deriving classes can choose to `override`.

```csharp
class Base {}
class Derived : Base {}
class ReallyDerived : Derived {}
```
]

???
http://en.wikipedia.org/wiki/Object-oriented_programming
http://en.wikipedia.org/wiki/Inheritance_(object-oriented_programming)

---
.left-column[
  ### OOP 
  ### Definition
  ### Example
]
.right-column[
# Classic OOP Use Case

This is an inheritence with one level.

`shape->square`, `shape->circle` and `shape->triangle`.

The `shape` class can have data such as a `public` colour and a `public` name. All derived classes will then have this functionality by default - cutting down on code duplication. 

The `shape` class can define a `GetArea()` function which each of the inheriting classes must define.

Here are two more complex examples:

`entity->vehicle->car->police car` and `entity->vehilce->boat->police boat`

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
# Advantages of OOP

1. Easy visualisation of the code structure
2. Therefore, easy to learn
3. Easy to extend
4. Reduce the amount of typing!
5. Data encapsulation - `private` data is hidden away
6. Virtual functions allow flexibility
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
# Drawbacks To OOP
Look at our previous example, how do we fit in a shared `poilice` class?

`entity->vehicle->car->police car` and `entity->vehilce->boat->police boat`

The OOP model cannot branch out then branch back in, this is called the [Diamond Problem](http://en.wikipedia.org/wiki/Multiple_inheritance#The_diamond_problem).
<img src="http://i.imgur.com/b9tdFfj.jpg" title="source: imgur.com" />
]

???
If mammal has a function called Speak(), both Man and Wolf will implement it! No problem there.

Man.Speak() { return "Hello friend"; } Wolf.Speak() { return "HAWOOOOOOO"; }

Now, if we call Werewolf.Speak, which of the base classes should it use?

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
* Interfaces
* Component based
* Data Oriented
]

???
Notes: ... 

---
class: center, middle
# Interfaces

This method avoid the diamond problem.

???
Notes: ... 

---
.left-column[
  ### Interface
]
.right-column[
# Interface stuff
* 1
* 2
* 3
]

???
Notes: ... 

---
class: center, middle
# Practical Work

Quick review of what is going on in the practicle work.

???
Notes: ... 

---
.left-column[
  ### Practical 
]
.right-column[
# Review the Practical code
* 1
* 2
* 3
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

Got back to the [language_syntax](http://nathanrosspowell.com/presentations/beginner_guides/language_syntax) page to see the practical work.
???
Notes: ... 
