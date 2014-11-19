// Lession 1 C# examples
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class GenericType<T>
    {
        private T _privateData;

        public void SetData( T setValue )
        {
            _privateData = setValue;
        }

        public T GetData()
        {
            return _privateData;
        }
    }

    class CallStackExample
    {
        private int _mathsQuestions = 10;
        private int _scienceQuestions = 15;
        private int _bonusQuestions = 3;

        public void Run()
        {
            float score = GetScore();
            float total = GetTotal();
            float average = (score / total ) * 100;
            System.Console.WriteLine("Score: {0}/{1} Average: {2}", score, GetTotalTheHardWay(), average );
        }

        public int GetScore()
        {
            return 16;
        }

        public int GetTotal()
        {
            return _mathsQuestions + _scienceQuestions + _bonusQuestions;
        }

        public int GetTotalTheHardWay()
        {
            return The();
        }

        public int The()
        {
            return Hard();
        }

        public int Hard()
        {
            return Way();
        }

        public int Way()
        {
            return GetTotal();
        }
    }

    class Exercise3
    {
        public void StackOverflow()
        {

        }
    }

    // This class, and the main function, are what C# targets as the starting point.
    // Program.Main will be the function at the bottom of every call stack (first on, last off)
    class Program
    {
        // This is called the 'entry point' of the program.
        // The function parameter is a array of strings.
        // This is how command line arguments are injected into the program.
        static void Main(string[] args)
        {
            Example1();
            Example2();
            Example3();

            UserExercise1();
            UserExercise2();
            UserExercise3();

            // The progam will exit when it's finished.
            // Put a breakpoint (F9) on this line of code to keep the console window open.
            System.Console.WriteLine("The program is going to finish!");
        }

        // In C# all functions have to be inside of a class.
        // A static function cannot access member variables of the class, unless they are also static.
        // A static member variable is shared between all instances of the class!
        // http://en.wikipedia.org/wiki/Static_(keyword)
        // http://en.wikipedia.org/wiki/Static_variable
        static void Example1()
        {
            // These are some basic variable types.
            int age = 27; // int is a whole number
            char middleInitial = 'R'; // use ' for chars
            string firstName = "Nathan"; // use " for strings
            float hateForOlives = 97.3f; // a number with a decimal point, the 'f' is manditory

            // Here are some arrays.
            char[] favoriteAnimal = new char[] { 'C', 'u', 't', 't', 'l', 'e', 'f', 'i', 's', 'h' }; // https://www.youtube.com/watch?v=GDwOi7HpHtQ
            float[] coolNumbers = new float[] { 99.66f, 88.88f, 66.99f };

            // Here are some generic (templated) types.
            List<int> testScores = new List<int>() { 7, 9, 8, 10, 6 };
            List<char> lastName = new List<char>() { 'P', 'o', 'w', 'e', 'l', 'l' };
            List<string> catchphrase = new List<string>() { "That's", "a", "bingo!" };

            // A way to use a list of chars
            string bestAnimal = "";
            foreach( char i in favoriteAnimal )
            {
                bestAnimal += i;
            }

            // A way to use a list of numbers.
            int sum = 0;
            foreach( int i in testScores )
            {
                sum += i;
            }
            int average = sum / testScores.Count(); // what is the bug here?
            
            // C# wizardry to turn a list of chars into a string
            string familyName = String.Concat(lastName);

            // Output to the screen.
            System.Console.WriteLine("Name: {0} {1} {2} Age: {3}", firstName, middleInitial, familyName, age);
            System.Console.WriteLine("Average test score: {0}", average );
            System.Console.WriteLine("Hate for Olives: {0}% Fave Animal: {1}", hateForOlives, bestAnimal );
        }

        static void Example2()
        {
            // Generic (template) example.
            GenericType<string> myName = new GenericType<string>();
            myName.SetData("Nathan");

            GenericType<int> myAge = new GenericType<int>();
            myAge.SetData(27);

            // Output to the screen.
            System.Console.WriteLine("{0} is {1}", myName.GetData(), myAge.GetData() );
        }

        static void Example3()
        {
            // Call Stack example.
            // Go put a breakpoint inside the function GetTotal.
            // When the breakpoint hits, look at the call stack.
            // Continue the program (F5).
            // Look at the next callstack.
            CallStackExample example = new CallStackExample();
            example.Run();
        }

        static void UserExercise1()
        {
            // Following Example1, print out your name and gamer tag.
            // Store each part in a variable.
            // Do not use the 'string' class.

            System.Console.WriteLine("Print out UserExercise1 here...");
        }

        static void UserExercise2()
        {
            // Following Example2, make a your own template class.
            // The class must have a function called 'GetDoubled', which uses the '+' operation
            // Print out the results for int, float and string.
            System.Console.WriteLine("Print out UserExercise2 here...");
        }

        static void UserExercise3()
        {
            // Make this function call create a stack overflow.
            Exercise3 uhoh = new Exercise3();
            uhoh.StackOverflow();
            System.Console.WriteLine("This won't get printed out if UserExercise3 is completed!");
        }
    }
}
