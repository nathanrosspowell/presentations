///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
void UserExercise1()
{
	// Following Example1, print out your name and gamer tag.
	// Store each part in a variable.
	// Do not use the 'string' class.

	// List of chars with a space intbetween the first and last name.
	char name[] = { 'N', 'a', 't', 'h', 'a', 'n', ' ', 'P', 'o', 'w', 'e', 'l', 'l' };
	// Loop all the letters
	for(char letter : name)
	{
		// Write does not add a newline (line return) like WriteLine does.
		printf( "%c", letter );
	}
	printf(" goes by: ");
	// Array of chars
	char* gamerTag = "BlackMullet";
	// A char array can be written out just like a string (this is what a string is internally).
	printf( "%s\n", gamerTag);
}

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
template<class T> class Doubler
{
private:
	T _privateData;

public:
	void SetData(T setValue)
	{
		_privateData = setValue;
	}

	T GetData()
	{
		return _privateData;
	}

	T GetDouble()
	{
		return _privateData + _privateData;
	}
};

void UserExercise2()
{
	// Following Example2, make a your own template class.
	// The class must have a function called 'GetDoubled', which uses the '+' operation
	// Print out the results for int, float and string.

	Doubler<std::string> myName;
	myName.SetData("Nathan");
	printf("Double %s is %s\n", myName.GetData().c_str(), myName.GetDouble().c_str());

	Doubler<int> myAge;
	myAge.SetData(27);
	printf("Double %d is %d\n", myAge.GetData(), myAge.GetDouble());

	Doubler<float> pi;
	pi.SetData(3.14159f);
	printf("Double %f is %f\n", pi.GetData(), pi.GetDouble());
}

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
class Exercise3
{
public:
	void StackOverflow()
	{
		StackOverflow();
	}
};

void UserExercise3()
{
	// Make this function call create a stack overflow.
    
	Exercise3 uhoh;
	uhoh.StackOverflow();
	printf("This won't get printed out if UserExercise3 is completed!\n");
}