///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
static void UserExercise1()
{
    // Following Example1, print out your name and gamer tag.
    // Store each part in a variable.
    // Do not use the 'string' class.

    // List of chars with a space intbetween the first and last name.
    List<char> name = new List<char>() { 'N', 'a', 't', 'h', 'a', 'n', ' ', 'P', 'o', 'w', 'e', 'l', 'l' };
    // Loop all the letters
    foreach( char letter in name )
    {
        // Write does not add a newline (line return) like WriteLine does.
        System.Console.Write(letter);
    }
    System.Console.Write(" goes by: ");
    // Array of chars
    char[] gamerTag = new char[] { 'B', 'l', 'a', 'c', 'k', 'M', 'u', 'l', 'l', 'e', 't'};
    // A char array can be written out just like a string (this is what a string is internally).
    System.Console.WriteLine(gamerTag);

}

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
class TypeWriter<T>
{
    private T _privateData;

    public void SetData(T data)
    {
        _privateData = data;
    }

    public T GetData()
    {
        return _privateData;
    }

    public Type GetType()
    {
        return _privateData.GetType();
    }
}

static void UserExercise2()
{
    // Following Example2, make a your own template class.
    // Make a functino to return the type of the template data
    // http://msdn.microsoft.com/en-us/library/system.object.gettype(v=vs.110).aspx
    // Print out the results for different types (int, float, string, etc)
    // WriteLine("Value is {1}. Type is {0}", variable.GetData(), variable.GetType() );
    // Generic (template) example.
    
    TypeWriter<string> myName = new TypeWriter<string>();
    myName.SetData("Nathan");
    System.Console.WriteLine("{0} is of type {1}", myName.GetData(), myName.GetType());

    TypeWriter<int> myAge = new TypeWriter<int>();
    myAge.SetData(27);
    System.Console.WriteLine("{0} is of type {1}", myAge.GetData(), myAge.GetType());

    TypeWriter<float> pi = new TypeWriter<float>();
    pi.SetData(3.14159f);
    System.Console.WriteLine("{0} is of type {1}", pi.GetData(), pi.GetType());

}

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
class Exercise3
{
    public void StackOverflow()
    {
        // Making the function call itself is called 'recursion'!
        // If there is way to stop the recursion that means there is no 'break condition'
        // With no break condition, we will keep calling the function until there is no space left on the callstack!
        StackOverflow();
    }
}

static void UserExercise3()
{
    // Make this function call create a stack overflow.
    
    Exercise3 uhoh = new Exercise3();
    uhoh.StackOverflow();
    System.Console.WriteLine("This won't get printed out if UserExercise3 is completed!");
}