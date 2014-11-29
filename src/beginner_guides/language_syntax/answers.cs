// C# practical work
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lesson2
{
    // An interface for making an input command
    // We can only define functions.
    // They are 'public' be default.
    interface InputCommand
    {
        // All must have a way to return the name of the command.
        string GetName();
        // All commands must have an Execute function which takes a string.
        // The 'arguments' string can be empty "" or it can have data: "true", "false", "1", "0" etc.
        void Execute( string arguments );
        // Add a function to see test if a command should be removed
        bool ShouldRemove();
    }

    // A simple class.
    // It 'inherits' from InputComand
    // See how it 'implements' the interface
    //    - we dont use the 'public' property on the function
    //    - we specify the interface name when naming the function 'InputCommand.FUNCTION'
    class Exit : InputCommand
    {
        private bool _exit = false;

        public bool ShouldExit() { return _exit; }

        // Implement the InputCommand interface below
        string InputCommand.GetName()
        { 
            return "ExitProgram"; 
        }
        void InputCommand.Execute(string arguments)
        {
            _exit = true;
            System.Console.WriteLine("Goodbye!");
            System.Threading.Thread.Sleep(1000); // 1 second delay.
        }
        bool InputCommand.ShouldRemove() { return false; }
    }

    // A input which needs an on/off arguments passed to it
    // See how we can return a class member in hte 'GetName' funciton.
    class GodMode : InputCommand
    {
        private string _myCommandName = "GodMode";
        private bool _inGodMode = false;

        // Implement the InputCommand interface below
        string InputCommand.GetName() 
        { 
            return _myCommandName; 
        }
        void InputCommand.Execute( string arguments )
        {
            // This is an example of complex logic.
            // There are three options for turning on the flag...
            if ( arguments == "on" || arguments == "true" || arguments == "1" )
            {
                if ( !_inGodMode )
                {
                    _inGodMode = true;
                    System.Console.WriteLine( "{0} is now {1}", _myCommandName, _inGodMode );
                }
            }
            // ... and three options for turning off the flag!
            else if ( arguments == "off" || arguments == "false" || arguments == "0" )
            {
                if ( _inGodMode )
                {
                    _inGodMode = false;
                    System.Console.WriteLine( "{0} is now {1}", _myCommandName, _inGodMode );
                }
            }
            // Maybe there should be some feedback when the function fails to do anything?
        }
        bool InputCommand.ShouldRemove() { return false; }
    }

    // A class made to pass around the result of the user input to the program.
    class UserInput
    {
        private string _command = "";
        private string _arguments = "";

        public string GetCommand()
        { 
            return _command;
        }
        public void SetCommand( string command )
        {
            _command = command;
        }

        public string GetArguments()
        { 
            return _arguments;
        }
        public void SetArguments( string arguments )
        {
            _arguments = arguments;
        }
    }

    class HelloPerson : InputCommand
    {
        public string Name { get; set; }

        // Implement the InputCommand interface below
        string InputCommand.GetName()
        { 
            return Name;
        }
        void InputCommand.Execute(string arguments)
        {
            System.Console.WriteLine("Hello, {0}!", Name );
        }
        bool InputCommand.ShouldRemove() { return false; }
    }

    class Counter : InputCommand
    {
        private int _count = 0; 

        // Implement the InputCommand interface below
        string InputCommand.GetName()
        { 
            return "Counter";
        }
        void InputCommand.Execute(string arguments)
        {
            _count += 1;
            System.Console.WriteLine("Executed {0} times!", _count );
        }
        bool InputCommand.ShouldRemove() { return _count > 2; }
    }
    
    class Shape: InputCommand
    {
        virtual public string GetShapeName() { return "Shape"; }
        virtual public double GetArea() { return 0; }

        // Implement the InputCommand interface below
        string InputCommand.GetName()
        { 
            return GetShapeName(); 
        }
        void InputCommand.Execute(string arguments)
        {
            System.Console.WriteLine("The area of '{0}' is {1} meters squared.", GetShapeName(), GetArea() );
        }
        bool InputCommand.ShouldRemove() { return false; }
    }
    
    class Square : Shape
    {
        public int Width { get; set; }

        override public string GetShapeName() { return "Square"; }
        override public double GetArea() { return Width * Width; } 
    }

    class Circle : Shape
    {
        public int Radius { get; set; }

        override public string GetShapeName() { return "Circle"; }
        override public double GetArea() { return Math.PI * ( Radius * Radius ); }
    }

    class Program
    {
        // The static entry point of the program.
        static void Main(string[] args)
        {
            // An empty list of commands.
            List<InputCommand> inputs = new List<InputCommand>();
            // Create some instances which implement the InputCommand interface.
            GodMode godMode = new GodMode();
            Exit exit = new Exit();
            HelloPerson nathan = new HelloPerson();
            nathan.Name = "Nathan";
            HelloPerson elliot = new HelloPerson() { Name = "Elliot" };
            // ... and more ...
            // Add them to the list.
            // The list is of type 'InputCommand', yet these different class types can be added!
            inputs.Add( godMode );
            inputs.Add( exit );
            inputs.Add( nathan );
            inputs.Add( elliot );
            inputs.Add( new Counter() );
            inputs.Add( new Square() { Width = 5 } );
            inputs.Add( new Circle() { Radius = 2 } );
            // Loop until we should exit.
            while (exit.ShouldExit() == false)
            {
                // Get the user input.
                UserInput userInput = GetUserInput("Enter A Command:");
                // Make sure we have something.
                if (userInput.GetCommand() != "" )
                {
                    // Loop all of our commands.
                    foreach (InputCommand i in inputs.ToArray()) // Get the array representation of the list - this makes a copy.
                    {
                        // Check to see if the name matches.
                        if (userInput.GetCommand() == i.GetName())
                        {
                            i.Execute(userInput.GetArguments());
                            if ( i.ShouldRemove() )
                            {
                                System.Console.WriteLine( "Removing {0}...", i.GetName() );
                                inputs.Remove( i ); // do not remove something from a list if you are looping it. But we are looping a copy of the list.
                            }
                        }
                    }
                }
            }
        }

        // A helper function for getting user input.
        // The input text will be split at the first space.
        // This means the first word will be in _command
        // and all of the rest will be in _arguments.
        //    - [ "myCommand" ]
        //    - [ "myCommand", "argument" ]
        //    - [ "myCommand", "argument1 argument2 ..." ]
        static UserInput GetUserInput(string prompt)
        {
            // Tell the user what they should input.
            System.Console.WriteLine(prompt);
            // Read in the user input.
            string inputLine = System.Console.ReadLine();
            // Split into two strings at the first space ' ' character.
            // This can result in only one item.
            string[] splits = inputLine.Split( new char[]{' '}, 2);
            UserInput userInput = new UserInput();
            userInput.SetCommand( splits[0] );
            if ( splits.Length > 1 )
            {
                userInput.SetArguments( splits[1] );
            }
            // return the UserInput class.
            return userInput;
        }
    }
}