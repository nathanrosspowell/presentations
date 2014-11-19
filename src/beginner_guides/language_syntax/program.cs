// Language Syntax
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
        string GetName();
        void Execute( string option );
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

        string InputCommand.GetName() { return "Exit"; }
        void InputCommand.Execute(string option)
        {
            _exit = true;
            System.Console.WriteLine("Goodbye!");
            System.Threading.Thread.Sleep(1000); // 1 second delay.
        }
    }

    // A input which needs an on/off option passed to it
    // See how we can return a class member in hte 'GetName' funciton.
    class GodMode : InputCommand
    {
        private string _myCommandName = "GodMode";
        private bool _inGodMode = false;

        string InputCommand.GetName() { return _myCommandName; }
        void InputCommand.Execute( string option )
        {
            // This is an example of complex logic.
            // There are three options for turning on the flag...
            if ( option == "on" || option == "true" || option == "1" )
            {
                if ( !_inGodMode )
                {
                    _inGodMode = true;
                    System.Console.WriteLine( "{0} is now {1}", _myCommandName, _inGodMode );
                }
            }
            // ... and three options for turning off the flag!
            else if ( option == "off" || option == "false" || option == "0" )
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
                string[] userInput = GetUserInput("Enter A Command:");
                // Make sure we have something.
                if (userInput.Length > 0)
                {
                    // Loop all of our commands.
                    foreach (InputCommand i in inputs)
                    {
                        // Check to see if the name matches.
                        if (userInput[0] == i.GetName())
                        {
                            // If we gave a parameter, use it...
                            if (userInput.Length > 1 )
                            {
                                i.Execute(userInput[1]);
                            }
                            // ... otherwise, pass an empty string.
                            else
                            {
                                i.Execute("");
                            }
                        }
                    }
                }
            }
        }

        // A helper function for getting user input
        // returns an arry of either size 1 or 2
        //    - [ "myCommand" ]
        //    - [ "myCommand", "argument" ]
        //    - [ "myCommand", "argument1 argument2 ..." ]
        static string[] GetUserInput(string prompt)
        {
            // Tell the user what they should input.
            System.Console.WriteLine(prompt);
            // Read in the user input.
            string inputLine = System.Console.ReadLine();
            // Split into two strings at the first space ' ' character.
            // This can result in only one item.
            string[] splits = inputLine.Split( new char[]{' '}, 2);
            // return the array.
            return splits;
        }
    }
}
