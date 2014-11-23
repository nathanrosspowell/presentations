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
    public int Multiplier { get; set; } // 3
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
6. explicit public property

---

class: center, middle
# Class Hierarchies

We will look over the principles of OOP* to describe class hierarchies.
You will use class hierarchies to organize functionality and avoid duplication of code, even if you don't use the OOP methodology.

_*Object Oriented Programming_

---
.left-column[
  ### OOP 
]
.right-column[
# Class Hierarchies 
* Definition of OOP
* Classic Example
* Virtual Functions
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

OOP is the using a model of real world object descriptions to organize data and functionality.

`base class->derived class->really derived class`

The derived classes have all of the functionality of the classes before it and also there own functionality.
The base class also defines `virtual` functions which the deriving classes can choose to `override`.

```csharp
class Base {}
class Derived : Base {}
class ReallyDerived : Derived {}
```

Everyone can access `public` code, deriving classes can see `protected` code, and only the class can see it's own `private`s.
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

This is an inheritance with one level.

`shape->square`, `shape->circle` and `shape->triangle`.

The `shape` class can have data such as a `public` color and a `public` name. All derived classes will then have this functionality by default - cutting down on code duplication. 

The `shape` class can define a `GetArea()` function which each of the inheriting classes must define.

Here are two more complex examples:

`entity->vehicle->car->police car` and `entity->vehicle->boat->police boat`

]

???
Notes: ... 

---
.left-column[
  ### OOP 
  ### Definition
  ### Example
  ### Virtuals
]
.right-column[
# Virtual Functions 

If we have a function that other classes need to implement differently, we do this:
```csharp
class Shape
{
    public virtual int GetArea() { return 0; }
}
```
Then override it in another class:
```csharp
class Square : Shape
{
    private int _width = 5;
    public override int GetArea() 
    { 
        return _width * _width;
    };
}
``` 
Then when you put a `Square` into a list of `Shapes`, the `GetArea` function will give the right answer. 

]

???
Notes: ... 


---
.left-column[
  ### OOP 
  ### Definition
  ### Example
  ### Virtuals
  ### Advantages
]
.right-column[
# Advantages of OOP

1. Easy visualization of the code structure
2. Therefore, easy to learn
3. Easy to extend
4. Reduce the amount of typing
5. Data encapsulation - `private` data is hidden away
6. A class be used like **ANY** of the classes in it's hierarchies!
7. Virtual functions allow flexibility
]

???
Notes: ... 

---
.left-column[
  ### OOP 
  ### Definition
  ### Example
  ### Advantages
  ### Virtuals
  ### Drawbacks
]
.right-column[
# Drawbacks To OOP
Look at our previous example, how do we fit in a shared `police` class?

`entity->vehicle->car->police car` and `entity->vehicle->boat->police boat`

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
  ### Virtuals
  ### Advantages
  ### Drawbacks
  ### Alternatives
]
.right-column[
# Alternatives

Class hierarchies and OOP can be used for some parts of you program, while other parts can leave it. 
It is totally up to the programmer to decided which methods and patterns they wish to use.

Here are some other programing techniques to look up:
* Functional Programming (FP)
* Interfaces / Components
* Data Oriented
]

???
Notes: ... 

---
class: center, middle
# Interfaces

Where as a class can only inherit from one base class (in C#), a class can implement multiple interfaces.

???
Notes: ... 

---
.left-column[
  ### Interface
]
.right-column[
# Interface Slides 
* Syntax
* Advantage
* Downsides
]

???
Notes: ... 

---
.left-column[
  ### Interface
  ### Syntax
]
.right-column[
# Interface Syntax

An interface lists all the specific functions that need to be implemented by a class which wishes to interface with the system.

It is a naming convention to use `I` at the start of your interface names.
```csharp
interface IClickable
{
    Rect GetRect();
    void OnClick(Pos position);
}
class Button : IClickable
{
    Rect IClickable.GetRect()
    { 
        return new Rect( x, y, width, height);
    }
    void IClickable.OnClick(Pos position) 
    { 
        Execute(position);
    }
}
```

]

???
Notes: ... 

---
.left-column[
  ### Interface
  ### Syntax
  ### Advantage
]
.right-column[
# Advantages 

You can have a manager class which has a list of all the `IClickable` classes in you game.
(you could even have an interface for managers...)
```csharp
class ClickManager
{
    public void Update()
    {
        Click newClick = DetectClick();
        foreach( IClickable i in _clickables )
        {
            if ( i.GetRect().Contains( newClick.GetPos ) )
            {
                i.OnClick( newClick.GetPos  );
            }
        }
    }
}
```
If we used OOP with a `BaseButton` class, it would make the program far less flexible.
Now, if you some reason NPCs need to be clickable, just implement the interface and add them to the list: DONE!

]

???
Notes: ... 

---
.left-column[
  ### Interface
  ### Syntax
  ### Advantage
  ### Downsides
]
.right-column[
# Downsides

If you _don't_ get have to extend your system a lot, working through an interface means you have to type out a lot of extra code.

If lot's of things use your interface and you have to add a function then __every__ class needs to add an implementation - virtual functions do not have this issue!
]

???
Notes: ... 


---
# Practical Work

The practical work has a interface named `InputCommand`. In the program I have made a loop which interacts with what the user types in.

There is a `List<InputCommand>` variable storing all the commands. You should add some more!

When you want to step it up, add a `Shape` class hierarchy. _Only_ the base class `Shape` will implement `InputCommand`. The execute function should print the area of each shape correctly. You will have to add your own `virtual` function calls to achieve this.
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
