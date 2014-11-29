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
            // ... and more ...
            // Add them to the list.
            // The list is of type 'InputCommand', yet these different class types can be added!
            inputs.Add( godMode );
            inputs.Add( exit );
            // Loop until we should exit.
            while (exit.ShouldExit() == false)
            {
                // Get the user input.
                UserInput userInput = GetUserInput("Enter A Command:");
                // Make sure we have something.
                if (userInput.GetCommand() != "" )
                {
                    // Loop all of our commands.
                    foreach (InputCommand i in inputs)
                    {
                        // Check to see if the name matches.
                        if (userInput.GetCommand() == i.GetName())
                        {
                            i.Execute(userInput.GetArguments());
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