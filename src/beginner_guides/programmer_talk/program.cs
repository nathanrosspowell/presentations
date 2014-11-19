// Lesson 1 CPP examples.
#include "stdafx.h" // This is what a basic 'Console Application' gets set up with in Visual Studio
#include <stdio.h>    // Includes the function like printf

#include <vector> // Includes std::vector, which means standard resizable array -or- a list
#include <string> // Includes std::string 

// In C++ if you want to call a before it is defined (when reading from top to bottom), then you have to do this:
void Example1();
void Example2();
void Example3();
void UserExercise1();
void UserExercise2();
void UserExercise3();
// This is called a forward decleration and the compiler needs it to know that the function WILL exsist at some point.

template<class T> class GenericType
{
private:
    T _privateData;

public:
    void SetData( T setValue )
    {
        _privateData = setValue;
    }

    T GetData()
    {
        return _privateData;
    }
};

class CallStackExample
{
private:
    int _mathsQuestions = 10;
    int _scienceQuestions = 15;
    int _bonusQuestions = 3;

public:

    void Run()
    {
        float score = (float)GetScore(); // This is how to 'cast' (change the type) from int to a float.
        float total = (float)GetTotal();
        float average = (score / total ) * 100;
        printf("Score: %d/%d Average: %f\n", GetScore(), GetTotalTheHardWay(), average );
    }

    int GetScore()
    {
        return 16;
    }

    int GetTotal()
    {
        return _mathsQuestions + _scienceQuestions + _bonusQuestions;
    }

    int GetTotalTheHardWay()
    {
        return The();
    }

    int The()
    {
        return Hard();
    }

    int Hard()
    {
        return Way();
    }

    int Way()
    {
        return GetTotal();
    }
};

class Exercise3
{
public:
    void StackOverflow()
    {

    }
};

// This is called the 'entry point' of the program.
// The function parameters are the number of arguments and an array of pointers to strings.
// This is how command line arguments are injected into the program.
int _tmain(int argc, _TCHAR* argv[])
{
    Example1();
    Example2();
    Example3();

    UserExercise1();
    UserExercise2();
    UserExercise3();

    // The progam will exit when it's finished.
    // Put a breakpoint (F9) on this line of code to keep the console window open.
    printf("The program is going to finish!");

	return 0;
}

void Example1()
{
    // These are some basic variable types.
    int age = 27; // int is a whole number
    char middleInitial = 'R'; // use ' for chars
    std::string firstName = "Nathan"; // use " for strings
    float hateForOlives = 97.3f; // a number with a decimal point, the 'f' is manditory

    // Here are some arrays.
    char favoriteAnimal[] = { 'C', 'u', 't', 't', 'l', 'e', 'f', 'i', 's', 'h' }; // https://www.youtube.com/watch?v=GDwOi7HpHtQ
    float coolNumbers[] = { 99.66f, 88.88f, 66.99f };

    // Here are some generic (templated) types.
    std::vector<int> testScores = { 7, 9, 8, 10, 6 };
    std::vector<char> lastName = { 'P', 'o', 'w', 'e', 'l', 'l' };
    std::vector<std::string> catchphrase = { "That's", "a", "bingo!" };

    // A way to use a list of chars
    std::string bestAnimal = "";
    for( char i : favoriteAnimal )
    {
        bestAnimal += i;
    }

    // A way to use a list of numbers.
    int sum = 0;
    for( int i : testScores )
    {
        sum += i;
    }
    int average = sum / testScores.size(); // what is the bug here?

    // Some standard library wizardy to make a list of chars in to a string
    std::string familyName(lastName.begin(), lastName.end());

    // Output to the screen.
    // printf uses escape codes;
    //   %s = string
    //   %c = char
    //   %d = int
    //   %f = float
    //   \n = new line (return)
    //   %% = %
    //   \a = ???? try it!
    printf("Name: %s %c %s Age: %d\n", firstName.c_str(), middleInitial, familyName.c_str(), age);
    printf("Average test score: %d\n", average );
    printf("Hate for Olives: %f%% Fave Animal: %s\n", hateForOlives, bestAnimal.c_str());

}

void Example2()
{
    // Generic (template) example.
    GenericType<std::string> myName;
    myName.SetData("Nathan");

    GenericType<int> myAge;
    myAge.SetData(27);

    printf( "%s is %u\n", myName.GetData().c_str(), myAge.GetData() );
}

void Example3()
{
    // Call Stack example.
    // Go put a breakpoint inside the function GetTotal.
    // When the breakpoint hits, look at the call stack.
    // Continue the program (F5).
    // Look at the next callstack.
    CallStackExample example; 
    example.Run();
}

void UserExercise1()
{
    // Following Example1, print out your name and gamer tag.
    // Store each part in a variable.
    // Do not use the 'string' class.
    printf("Print out UserExercise1 here...\n");
}

void UserExercise2()
{
    // Following Example2, make a your own template class.
    // The class must have a function called 'GetDoubled', which uses the '+' operation
    // Print out the results for int, float and string.
    printf("Print out UserExercise2 here...\n");
}

void UserExercise3()
{
    // Make this function call create a stack overflow.
    Exercise3 uhoh;
    uhoh.StackOverflow();
    printf("This won't get printed out if UserExercise3 is completed!\n");
}
