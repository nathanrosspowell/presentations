// Program.cpp 
#include "stdafx.h"

void Example1();
void Example2();
void Example3();

void UserExercise1();
void UserExercise2();
void UserExercise3();

void SetIntTo42( int* toChange );
void SwapNumbers( int* a, int* b );
void ReverseString( char* name );

// The entry point of the program.
int _tmain(int argc, _TCHAR* argv[])
{
    Example1();
    Example2();
    Example3();

    UserExercise1();
    UserExercise2();
    UserExercise3();
    
    return 0;
}

// A basic example of how pointer can be used to edit variables in different parts of the code.
void Example1()
{
    // Set an number to 99
    int secretNumber = 99;
    // Use '&' to get a pointer to that number.
    SetIntTo42( &secretNumber );
    // See that we have a new value.
    printf( "Secret Number was 99, now it's %d\n", secretNumber );
}

// Takes a 'int pointer' as a parameter.
void SetIntTo42( int* toChange )
{
    // we use '*' on a pointer to say 'get me the value this points to'.
    *toChange = 42;
}

// Basic array and loop usage.
void Example2()
{
    // 'const' means 'constant', aka 'this value will never change'.
    const int size = 3;
    // Make an array of size 3.
    int scores[size] = { 25, 50, 75 };
    // Create the variable to store the total of all the scores.
    int sum = 0;
    // Loop from 0 - 2. '++i' means, add one to i at the end of each loop.
    for ( int i = 0; i < size; ++ i )
    {
        // Add the value from each index in the array. "sum += 4" is the same as "sum = sum + 4"
        sum += scores[ i ];
    }
    // Divide to get the average score.
    int average = sum / size;
    printf( "The average is %d\n", average );
}

// Proof of how arrays are pointers and how to use a pointer to get values from an array.
void Example3()
{
    // 'const' means 'constant', aka 'this value will never change'.
    const int size = 4;
    // Make an array of size 4.
    int numbers[size] = { 25, 26, 27, 28 };
    // See that we don't need to use '&' to get a pointer, the array is a point type internally.
    int* pointerInArray  = numbers;
    // Loop from 0 - 3. '++i' means, add one to i at the end of each loop.
    for ( int i = 0; i < size; ++i )
    {
        // Proof that the value at index i is the same as 
        if ( numbers[ i ] == *pointerInArray )
        {
            printf( "Index %d has the value %d at memory address 0x%X\n", i, numbers[i], pointerInArray );
        }
        // The same as '+= 1'
        ++pointerInArray; 
    }
}

// Implement SwapNumbers so that you get the correct print out.
void UserExercise1()
{
    // The data.
    int big = 1;
    int small = 99;
    // The function to swap numbers.
    SwapNumbers( &big, &small );
    // Print out the results
    if ( small == 1 && big == 99 )
    {
        printf( "Correctly swapped values by using pointer magic!\n");
    }
    else
    {
        printf( "Big = %d and small = %d, try again...\n", big, small );
    }
}

// Do whatever you need to do so that a has the value of b, and b has the value of a.
void SwapNumbers( int* a, int* b )
{
    // TODO....
}

void UserExercise2()
{
    // The set up.
    const int size = 10;
    int scores[size] = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

    // Task 1:
    //        Get the sum of the 1st, 2nd and 3rd numbers
    int firstThreeNumbers = 0;
    /*
    for ( use a for loop )
    {
    }
    */
    // Results
    if ( firstThreeNumbers == 60)
    {
        printf( "Summed the first 3 number to 30!");
    }
    else
    {
        printf( "firstThreeNumbers = %d, try again...\n", firstThreeNumbers );
    }

    // Task 2:
    //        Get the sum, skipping a number each time - e.g. 20, 40...
    int sumOfEveryNextNumber = 0;
    /*
    for ( use a for loop )
    {
    }
    */
    // Results
    if ( sumOfEveryNextNumber == 300 )
    {
        printf( "Summed the number to 300!");
    }
    else
    {
        printf( "sumOfEveryNextNumber = %d, try again...\n", sumOfEveryNextNumber );
    }

} 

// Very ticky! This is a C/C++ interview question for programmers to answer on white board
// Use the pointer to a char array to swap the letters around
// SPECIAL RULE: 
//              Arrays of strings always end with a NULL terminator, even though you don't type them in.
// Example:
//          'o', 'i', 's', NULL
void UserExercise3()
{
    char name[] = "Jean-Francois";
    ReverseString( name );
    printf( "Name = %s\n", name );
}

void ReverseString( char* name )
{

}