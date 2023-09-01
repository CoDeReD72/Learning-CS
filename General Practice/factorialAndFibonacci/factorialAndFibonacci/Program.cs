




// == TESTING ==
static void TestFactorial()
{
    Console.WriteLine("=== FACTORIAL TESTS ===");

    Console.WriteLine("Test 1 - Factorial of 0");
    Console.WriteLine("\t - Test Criteria: Factorial(0) should return 1.");
    if (factorial(0) == 1)
    {
        Console.WriteLine("\t - Pass");
    }
    else
    {
        Console.WriteLine("\t - Fail");
    }

    Console.WriteLine("Test 2 - Factorial of 5");
    Console.WriteLine("\t - Test Criteria: Factorial(5) should return 120.");
    if (factorial(5) == 120)
    {
        Console.WriteLine("\t - Pass");
    }
    else
    {
        Console.WriteLine("\t - Fail");
    }

    Console.WriteLine('\n');
    // Add more test cases as needed
}

static void TestFibonacci()
{
    Console.WriteLine("=== FIBONACCI TESTS ===");
    Console.WriteLine("Test 1 - Fibonacci at position 0");
    Console.WriteLine("\t - Test Criteria: Fibonacci(0) should return 0.");
    if (fibonacci(0) == 0)
    {
        Console.WriteLine("\t - Pass");
    }
    else
    {
        Console.WriteLine("\t - Fail");
    }

    Console.WriteLine("Test 2 - Fibonacci at position 5");
    Console.WriteLine("\t - Test Criteria: Fibonacci(5) should return 5.");
    if (fibonacci(5) == 5)
    {
        Console.WriteLine("\t - Pass");
    }
    else
    {
        Console.WriteLine("\t - Fail");
    }

    Console.WriteLine('\n');
    // Add more test cases as needed
}

static int fibonacci(int n)
{
    if (n < 0)
    {
        throw new ArgumentException("Fibonacci sequence is not defined for negative numbers.");
    }

    // Base cases: Fibonacci(0) = 0 and Fibonacci(1) = 1
    if (n == 0)
    {
        return 0;
    }
    else if (n == 1)
    {
        return 1;
    }

    // Recursive case
    return fibonacci(n - 1) + fibonacci(n - 2);
}


static int factorial(int n)
{

    // Error handling - Negative number
    if (n < 0)
    {
        throw new Exception("Negative Number Inputted");
    }

    // Base case: factorial of 0 is 1
    if (n == 0)
    {
        return 1;
    }

    // Recursive case: n! = n * (n-1)!
    return n * factorial(n - 1);

}


TestFactorial();

TestFibonacci();
