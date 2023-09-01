int[] data; // Creates a variable to hold a reference to an array of integers
data = new int[3]; // Creates new instance of reference type and assigns it to the variable (allocated heap memory too)

string shortenedString = "Hello World!"; // New is not required for strings - they are reference types but are so commonly used that they have a special syntax
Console.WriteLine(shortenedString);