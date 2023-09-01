// String Interpolation

string first = "Hello";
string second = "World";
Console.WriteLine("{1} {0}!", first, second);
Console.WriteLine("{0} {0} {0}!", first, second);
// Formatting
// {amount:C} - Currency
// {amount:N} - Number
// {amount:P} - Percentage

// Padding

string input = "Pad this";
Console.WriteLine(input.PadLeft(12));

//PadLeftOrRight(totalLength, 'character')
// PadLeft - Makes the total length of the string x by padding to the left
// PadRight - Same but for the right